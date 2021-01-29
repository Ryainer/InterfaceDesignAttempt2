﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllerScript : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";

    private float totalHorizontalInput;
    private float LeftHorizontalInput;
    private float RightHorizontalInput;
    private float verticalInput;
    private float currentSteerAngle;
    private float currentBreakForce;
    private bool isBreaking;
    private bool isTiltControl = false;
    private Quaternion calibrationQuaternion;
    Vector3 zeroAc;
    Vector3 curAc;
    float sensH = 10;
    float sensV = 10;
    float smooth = 0.5f;
    float GetAxisH  = 0;
    float GetAxisV = 0;

    public GameObject outputText;

    [SerializeField] private float motorForce;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSteerAngle;
    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider frontRightWheelCollider;
    [SerializeField] private WheelCollider backLeftWheelCollider;
    [SerializeField] private WheelCollider backRightWheelCollider;

    [SerializeField] private Transform frontLeftWheelTransform;
    [SerializeField] private Transform frontRightWheelTransform;
    [SerializeField] private Transform backLeftWheelTransform;
    [SerializeField] private Transform backRightWheelTransform;

    // Used to calibrate the Input.acceleration
    void CalibrateAccelerometer()
    {
        zeroAc = Input.acceleration;
        curAc = Vector3.zero;
    }

    // Start is called before the first frame update
    void Start()
    {
        CalibrateAccelerometer();
        Input.gyro.enabled = true;
    }
    private void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
        calculateSpeed();
    }
    private void GetInput()
    {
        if (isTiltControl == false)
        {
            totalHorizontalInput = LeftHorizontalInput + RightHorizontalInput;
        }
        verticalInput = 1.0f;
    }
    private void HandleMotor()
    {
        frontLeftWheelCollider.motorTorque = verticalInput * motorForce;
        frontRightWheelCollider.motorTorque = verticalInput * motorForce;
        currentBreakForce = isBreaking ? breakForce : 0f;
         ApplyBreaking();
    
    }
    private void calculateSpeed()
    {
        float circumFerence = 2.0f * 3.14f * frontLeftWheelCollider.radius; // Finding circumFerence 2 Pi R
        float speedOnKmh = ((circumFerence * frontLeftWheelCollider.rpm) / 1000) * 60; // finding kmh
        float speedOnMph = speedOnKmh * 0.62f; // converting kmh to mph
        outputText.GetComponent<TextMesh>().text = (speedOnMph).ToString() + "/mph";
    }
    private void HandleSteering()
    {
        currentSteerAngle = maxSteerAngle * totalHorizontalInput;
        frontLeftWheelCollider.steerAngle = currentSteerAngle;
        frontRightWheelCollider.steerAngle = currentSteerAngle;
    }
    private void UpdateWheels()
    {
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(backLeftWheelCollider, backLeftWheelTransform);
        UpdateSingleWheel(backRightWheelCollider, backRightWheelTransform);
    }
    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
      
    }
    private void ApplyBreaking()
    {
        frontLeftWheelCollider.brakeTorque = currentBreakForce;
        frontRightWheelCollider.brakeTorque = currentBreakForce;
        backLeftWheelCollider.brakeTorque = currentBreakForce;
        backRightWheelCollider.brakeTorque = currentBreakForce;

    }


    public void pressedDownLeft()
    {
        if(isTiltControl == false)
        LeftHorizontalInput = -1.0f;
    }
    public void releasedLeft()
    {
        if (isTiltControl == false)
            LeftHorizontalInput = 0.0f;
    }

    public void pressedDownRight()
    {
        if (isTiltControl == false)
            RightHorizontalInput = 1.0f;
    }
    public void releasedRight()
    {
        if (isTiltControl == false)
            RightHorizontalInput = -0.0f;
    }
    public void SetTiltControl(int value)
    {
        if(value == 0)
        {
            isTiltControl = false;
        }
        else if(value == 1)
        {
            isTiltControl = true;
            CalibrateAccelerometer();
        }
    }
    public void pressedDownBreak()
    {
        isBreaking = true;
    }
    public void releasedBreak()
    {
        isBreaking = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (isTiltControl == true)
        {
     
            curAc = Vector3.Lerp(curAc, Input.acceleration - zeroAc, Time.deltaTime / smooth);
            GetAxisV = Mathf.Clamp(curAc.y * sensV, -1, 1);
            GetAxisH = Mathf.Clamp(curAc.x * sensH, -1, 1);
            totalHorizontalInput = GetAxisH;
            Debug.Log("TILT INPUT" + GetAxisH);
        }

    }
}
