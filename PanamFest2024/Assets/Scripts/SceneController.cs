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
	public GameObject pauseMenuCanvas;
	public GameObject optionsMenuCanvas;

	private Scene currentScene;

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

		currentScene = SceneManager.GetActiveScene();
	}

	void Update()
	{
		currentScene = SceneManager.GetActiveScene();
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
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;

			mainMenuCanvas.SetActive(true);
			pauseMenuCanvas.SetActive(false);
			optionsMenuCanvas.SetActive(false);
		}

		if (scene.name == "Loading" || scene.name == "Credits"  || scene.name == "Level001" || scene.name == "Credits")
		{
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;

			mainMenuCanvas.SetActive(false);
			pauseMenuCanvas.SetActive(false);
			optionsMenuCanvas.SetActive(false);
		}
	}

	public void OnResumeButtonClick()
	{
		Time.timeScale = 1f;

		pauseMenuCanvas.SetActive(false);
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void OnBackButtonClick()
	{
		if (currentScene.name == "Tutorial" || currentScene.name == "Level001")
		{
			pauseMenuCanvas.SetActive(true);
			optionsMenuCanvas.SetActive(false);
		}
		if (currentScene.name == "MainMenu")
		{
			mainMenuCanvas.SetActive(true);
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
