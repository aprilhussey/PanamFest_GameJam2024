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
            Disable(lookUpDown);
            Enable(lookLeftRight);
        }

		if (playerLookInput.x != 0 && lookLeftRight.activeInHierarchy)
		{
			Disable(lookLeftRight);
			Enable(scope);
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
            Disable(scope);
            Enable(shoot);
        }
    }

	public void OnShootTutorialDone()
	{
		if (shoot.activeInHierarchy)
		{
			Disable(shoot);
			Enable(tutorialCompleteCanvas);
		}
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
