using System.Collections;
using UnityEngine;

public class TutorialObjectives : MonoBehaviour
{
	[SerializeField]
    private GameObject lookUpDown;
	[SerializeField]
	private GameObject lookLeftRight;
	[SerializeField]
	private GameObject scope;
	[SerializeField]
	private GameObject shoot;

	private GameObject tutorialCompleteCanvas;

    private PlayerController playerController;
    private Vector2 playerLookInput;

    void Awake()
    {
        playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
		tutorialCompleteCanvas = SceneController.Instance.tutorialCompleteCanvas;
	}

    void Start()
    {
        Enable(lookUpDown);
    }

    void Update()
    {
        playerLookInput = playerController.lookInput;

        Debug.Log($"lookInput: {playerLookInput}");

        if (playerLookInput.y != 0 && lookUpDown.activeInHierarchy)
        {
			StartCoroutine(DelayTutorialChange(lookUpDown, lookLeftRight, 1f, 1f));
        }

		if (playerLookInput.x != 0 && lookLeftRight.activeInHierarchy)
		{
			StartCoroutine(DelayTutorialChange(lookLeftRight, scope, 1f, 1f));
		}

        if (tutorialCompleteCanvas.activeInHierarchy)
        {
			Time.timeScale = 0f;

			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}
	}

    public void OnScopeTutorialDone()
    {
        if (scope.activeInHierarchy)
        {
			StartCoroutine(DelayTutorialChange(scope, shoot, 1f, 1f));
        }
    }

	public void OnShootTutorialDone()
	{
		if (shoot.activeInHierarchy)
		{
			StartCoroutine(DelayTutorialChange(shoot, tutorialCompleteCanvas, 1f, 1f));
		}
	}

	IEnumerator DelayTutorialChange(GameObject disableObject, GameObject enableObject, float secondsBeforeDisable, float secondsBeforeEnable)
	{
		yield return new WaitForSecondsRealtime(secondsBeforeDisable);
		Disable(disableObject);
		yield return new WaitForSecondsRealtime(secondsBeforeEnable);
		Enable(enableObject);
	}

	private void Enable(GameObject objective)
    {
        objective.SetActive(true);
    }

	private void Disable(GameObject objective)
	{
		objective.SetActive(false);
	}
}
