using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Defeat : MonoBehaviour
{

    public string level001;
    public string mainMenu;


    public void ReloadLevel()
    { 
        SceneManager.LoadScene(level001);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
