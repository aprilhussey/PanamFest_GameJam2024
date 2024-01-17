using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
	public static SceneController Instance;

	[SerializeField]
	private UnityEngine.Object loadingScene;

	[SerializeField]
	private GameObject mainMenuCanvas;
	[SerializeField]
	private GameObject pauseMenuCanvas;
	[SerializeField]
	private GameObject optionsMenuCanvas;

	void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	private void OnEnable()
	{
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	private void OnDisable()
	{
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		if (scene.name == "MainMenu")
		{
			mainMenuCanvas.SetActive(true);
			pauseMenuCanvas.SetActive(false);
			optionsMenuCanvas.SetActive(false);
		}

		if (scene.name == "Loading" || scene.name == "Credits" || scene.name == "Level001" || scene.name == "Credits")
		{
			mainMenuCanvas.SetActive(false);
			pauseMenuCanvas.SetActive(false);
			optionsMenuCanvas.SetActive(false);
		}
	}

	public void OnQuitButtonClick()
	{
		Application.Quit();
	}

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
