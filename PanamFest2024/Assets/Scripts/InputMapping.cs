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

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSwitchInputLayout()
    {
        Debug.Log("Switched...");

        if (PlayerPrefs.GetInt("FlipWheels") == 1)
        {
            Debug.Log("to RexyInput");

            RexyInput.Enable();
            InvertedRexyInput.Disable();

        }
        else if (PlayerPrefs.GetInt("FlipWheels") == 0)
        {
            Debug.Log("to InvertedRexyInput");

            RexyInput.Disable();
            InvertedRexyInput.Enable();

        }
    }
}
