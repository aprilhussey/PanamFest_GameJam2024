using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialLevelFinished : MonoBehaviour
{

    public string level001;
    public string tutorial;


    public void LoadLevel()
    {
        SceneManager.LoadScene(level001);
    }

    public void Restart()
    {
        SceneManager.LoadScene(tutorial);
    }
}
