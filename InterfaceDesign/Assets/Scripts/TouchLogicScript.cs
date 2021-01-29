using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TouchLogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeToMainMenuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void changeToSinglePlayerScene()
    {
        SceneManager.LoadScene(1);
    }
    public void changeToMultiplayerScene()
    {
        SceneManager.LoadScene(2);
    }
    public void changeToPartScene()
    {
        SceneManager.LoadScene(5);
    }
    public void changeToGameSceneScene()
    {
        SceneManager.LoadScene(3);
    }

    public void changeToGarageScene()
    {
        SceneManager.LoadScene(4);
    }
}
