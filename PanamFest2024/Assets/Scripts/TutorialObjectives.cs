using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class TutorialObjectives : MonoBehaviour
{
    [SerializeField] GameObject ObjectiveOne;
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
                ObjectiveOne.SetActive(false);
                ObjectiveOne.SetActive(false);
                ObjectiveOne.SetActive(false);
            }
            else if (CurrentObjective == 1)
            {
                ObjectiveOne.SetActive(false);
                ObjectiveOne.SetActive(true);
                ObjectiveOne.SetActive(false);
                ObjectiveOne.SetActive(false);
            }
            else if (CurrentObjective == 2)
            {
                ObjectiveOne.SetActive(false);
                ObjectiveOne.SetActive(false);
                ObjectiveOne.SetActive(true);
                ObjectiveOne.SetActive(false);
            }
            else if (CurrentObjective == 3)
            {
                ObjectiveOne.SetActive(false);
                ObjectiveOne.SetActive(false);
                ObjectiveOne.SetActive(false);
                ObjectiveOne.SetActive(true);
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
    }
}
