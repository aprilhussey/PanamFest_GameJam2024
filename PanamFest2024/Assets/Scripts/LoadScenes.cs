using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
	[SerializeField]
	private UnityEngine.Object loadingScene;

	public void LoadScene(string sceneName)
	{
		if (loadingScene != null)
		{
			SceneManager.LoadSceneAsync(loadingScene.name);
		}
		StartCoroutine(LoadNextScene(sceneName));
	}

	IEnumerator LoadNextScene(string nextScene)
	{
		AsyncOperation AsyncLoading = SceneManager.LoadSceneAsync(nextScene);

		while (!AsyncLoading.isDone) // Add extra check is you want to wait for certain animations or feature to be done before the new scene loads
		{
			yield return null;
		}
	}
}
