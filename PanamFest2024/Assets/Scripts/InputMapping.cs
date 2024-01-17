using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputMapping : MonoBehaviour
{

    PlayerInput InputSystem;
    InputActionMap RexyInput;
    InputActionMap InvertedRexyInput;

    public bool FlippedWheels;

    // Start is called before the first frame update
    void Start()
    {
        InputSystem = GetComponent<PlayerInput>();

        RexyInput = InputSystem.currentActionMap = InputSystem.actions.FindActionMap("RexyInput");
        InvertedRexyInput = InputSystem.currentActionMap = InputSystem.actions.FindActionMap("InvertedRexyInput");

        RexyInput.Enable();
        InvertedRexyInput.Disable();

        FlippedWheels = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSwitchInputLayout()
    {
        Debug.Log("Switched...");

        if (!RexyInput.enabled)
        {
            Debug.Log("to RexyInput");

            RexyInput.Enable();
            InvertedRexyInput.Disable();

            FlippedWheels = false;
        }
        else if (!InvertedRexyInput.enabled)
        {
            Debug.Log("to InvertedRexyInput");

            RexyInput.Disable();
            InvertedRexyInput.Enable();

            FlippedWheels = true;
        }
    }
}
