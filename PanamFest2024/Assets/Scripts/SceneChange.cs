using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [Tooltip("The name of the loading scene")]
    [SerializeField] string LoadingScene;

    [Tooltip("The name of the scene you want to got to next")]
    [SerializeField] string NextScene;

    IEnumerator LoadNextScene()
    {
        AsyncOperation AsyncLoading = SceneManager.LoadSceneAsync(NextScene);

        while (!AsyncLoading.isDone) // Add extra check is you want to wait for certain animations or feature to be done before the new scene loads
        {
            yield return null;
        }
    }

    public void OnClick()
    {
        SceneManager.LoadScene(LoadingScene);
        StartCoroutine(LoadNextScene());
    }

    public void OnLoadScene()
    {
        SceneManager.LoadScene(LoadingScene);
        StartCoroutine(LoadNextScene());
    }

}
