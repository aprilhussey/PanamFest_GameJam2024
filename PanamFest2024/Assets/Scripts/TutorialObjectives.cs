using UnityEngine;

public class TutorialObjectives : MonoBehaviour
{
    [SerializeField]
    private GameObject lookUpDown;
	[SerializeField]
	private GameObject lookLeftRight;
	[SerializeField]
	private GameObject zoom;
	[SerializeField]
	private GameObject shoot;

	[SerializeField]
	private GameObject tutorialComplete;

    private PlayerController playerController;
    private Vector2 playerLookInput;

    void Awake()
    {
        playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
    }

    void Start()
    {
        Enable(lookUpDown);
    }

    void Update()
    {
        playerLookInput = playerController.lookInput;

        Debug.Log($"lookInput: {playerLookInput}");
    }

    private void Enable(GameObject objective)
    {
        objective.SetActive(true);
    }

	private void Disable(GameObject objective)
	{
		objective.SetActive(true);
	}

	/*[SerializeField] GameObject ObjectiveOne;
    [SerializeField] GameObject ObjectiveTwo;
    [SerializeField] GameObject ObjectiveThree;
    [SerializeField] GameObject ObjectiveFour;

    int CurrentObjective;

    [SerializeField] float Timer;
    float TimeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        CurrentObjective = 0;
        TimeRemaining = Timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeRemaining <= 0)
        {
            if (CurrentObjective == 0)
            {
                ObjectiveOne.SetActive(true);
                ObjectiveTwo.SetActive(false);
                ObjectiveThree.SetActive(false);
                ObjectiveFour.SetActive(false);
            }
            else if (CurrentObjective == 1)
            {
                ObjectiveOne.SetActive(false);
                ObjectiveTwo.SetActive(true);
                ObjectiveThree.SetActive(false);
                ObjectiveFour.SetActive(false);
            }
            else if (CurrentObjective == 2)
            {
                ObjectiveOne.SetActive(false);
                ObjectiveTwo.SetActive(false);
                ObjectiveThree.SetActive(true);
                ObjectiveFour.SetActive(false);
            }
            else if (CurrentObjective == 3)
            {
                ObjectiveOne.SetActive(false);
                ObjectiveTwo.SetActive(false);
                ObjectiveThree.SetActive(false);
                ObjectiveFour.SetActive(true);
            }

            ObjectiveCriteria();
        }

        
    }

    public void ObjectiveCriteria()
    {
        if (Input.GetAxis("Horizontal") > 0.1 || Input.GetAxis("Horizontal") < -0.1)
        {
            CurrentObjective += 1;
            TimeRemaining = Timer;
        }
        
        else if ((Input.GetAxis("Vertacle") > 0.1 && CurrentObjective == 1) || (Input.GetAxis("Vertacle") < -0.1 && CurrentObjective == 1))
        {
            CurrentObjective += 1;
            TimeRemaining = Timer;
        }

        else if ((Input.GetButtonDown("MouseLeft") && CurrentObjective == 2))
        {
            CurrentObjective += 1;
            TimeRemaining = Timer;
        }

        else if ((Input.GetButtonDown("MouseRight") && CurrentObjective == 3))
        {
            CurrentObjective += 1;
            TimeRemaining = Timer;
        }
    }*/
}
