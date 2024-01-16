//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/InputSystem/InputSystem.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputSystem: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""RexyInput"",
            ""id"": ""54412a10-ad24-4f6d-ac80-0238f3519c4d"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7200e914-694e-4ffc-8b08-bad14e1e41c8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""fdc74e27-ced7-4b9e-be3d-65d6642d325e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""301cb3ad-bf4b-401d-a612-6e35d71c4cba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchInputLayout"",
                    ""type"": ""Button"",
                    ""id"": ""4f1e306c-63eb-4dc1-a6f0-c9d6a56a18b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9ec3559b-2c5a-46fe-8113-3896b2a88251"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""34646342-e8ee-45e6-9fd6-06dfac784f53"",
                    ""path"": ""<Mouse>/delta/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4362b0e3-2712-4bbe-b276-f3a2b8605320"",
                    ""path"": ""<Mouse>/delta/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""eacf3e28-84e3-4862-9bde-a05e1c336c62"",
                    ""path"": ""<Mouse>/delta/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""461c5c5e-8976-4e09-a9dc-37a1f4a862e4"",
                    ""path"": ""<Mouse>/delta/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bb490b80-ef32-4cb9-b988-751b7684d245"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ceb4b71b-51f7-49e3-b8ff-fff1030a0ff4"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""248c30db-7e06-41fb-921e-62160918407d"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchInputLayout"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""InvertedRexyInput"",
            ""id"": ""696fba3f-8386-406b-8acb-667af9459e83"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f25c4db4-5652-49e4-a8e6-0daebfff81eb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""098a1ee2-912b-4f29-af2f-a4182be993a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""7eab1f5f-67ff-4d1a-9958-53c1a33dfa62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchInputLayout"",
                    ""type"": ""Button"",
                    ""id"": ""c672b972-d5e0-4c29-ae26-a474678d871f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e6c9f192-9d5c-4883-8d90-2564cb483a18"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cec6966c-e316-4dc4-bdef-b6f9196db0ef"",
                    ""path"": ""<Mouse>/delta/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""623ec3ab-eac3-4afa-8285-cb8baf0d1ed8"",
                    ""path"": ""<Mouse>/delta/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2bc83d4c-7b0f-47e0-9765-f56af71addaf"",
                    ""path"": ""<Mouse>/delta/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e0c934cc-b07d-4a4a-8927-94a375be41a3"",
                    ""path"": ""<Mouse>/delta/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b9f67889-1f5b-4a3e-9fc6-aaf3cdc1a9ae"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02637e31-78fb-4065-8511-017b8e192ac2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cbed1b09-9fd1-4b7f-8af3-b60b10f263fd"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchInputLayout"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // RexyInput
        m_RexyInput = asset.FindActionMap("RexyInput", throwIfNotFound: true);
        m_RexyInput_Look = m_RexyInput.FindAction("Look", throwIfNotFound: true);
        m_RexyInput_Aim = m_RexyInput.FindAction("Aim", throwIfNotFound: true);
        m_RexyInput_Shoot = m_RexyInput.FindAction("Shoot", throwIfNotFound: true);
        m_RexyInput_SwitchInputLayout = m_RexyInput.FindAction("SwitchInputLayout", throwIfNotFound: true);
        // InvertedRexyInput
        m_InvertedRexyInput = asset.FindActionMap("InvertedRexyInput", throwIfNotFound: true);
        m_InvertedRexyInput_Look = m_InvertedRexyInput.FindAction("Look", throwIfNotFound: true);
        m_InvertedRexyInput_Aim = m_InvertedRexyInput.FindAction("Aim", throwIfNotFound: true);
        m_InvertedRexyInput_Shoot = m_InvertedRexyInput.FindAction("Shoot", throwIfNotFound: true);
        m_InvertedRexyInput_SwitchInputLayout = m_InvertedRexyInput.FindAction("SwitchInputLayout", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // RexyInput
    private readonly InputActionMap m_RexyInput;
    private List<IRexyInputActions> m_RexyInputActionsCallbackInterfaces = new List<IRexyInputActions>();
    private readonly InputAction m_RexyInput_Look;
    private readonly InputAction m_RexyInput_Aim;
    private readonly InputAction m_RexyInput_Shoot;
    private readonly InputAction m_RexyInput_SwitchInputLayout;
    public struct RexyInputActions
    {
        private @InputSystem m_Wrapper;
        public RexyInputActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_RexyInput_Look;
        public InputAction @Aim => m_Wrapper.m_RexyInput_Aim;
        public InputAction @Shoot => m_Wrapper.m_RexyInput_Shoot;
        public InputAction @SwitchInputLayout => m_Wrapper.m_RexyInput_SwitchInputLayout;
        public InputActionMap Get() { return m_Wrapper.m_RexyInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RexyInputActions set) { return set.Get(); }
        public void AddCallbacks(IRexyInputActions instance)
        {
            if (instance == null || m_Wrapper.m_RexyInputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_RexyInputActionsCallbackInterfaces.Add(instance);
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @Aim.started += instance.OnAim;
            @Aim.performed += instance.OnAim;
            @Aim.canceled += instance.OnAim;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @SwitchInputLayout.started += instance.OnSwitchInputLayout;
            @SwitchInputLayout.performed += instance.OnSwitchInputLayout;
            @SwitchInputLayout.canceled += instance.OnSwitchInputLayout;
        }

        private void UnregisterCallbacks(IRexyInputActions instance)
        {
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @Aim.started -= instance.OnAim;
            @Aim.performed -= instance.OnAim;
            @Aim.canceled -= instance.OnAim;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @SwitchInputLayout.started -= instance.OnSwitchInputLayout;
            @SwitchInputLayout.performed -= instance.OnSwitchInputLayout;
            @SwitchInputLayout.canceled -= instance.OnSwitchInputLayout;
        }

        public void RemoveCallbacks(IRexyInputActions instance)
        {
            if (m_Wrapper.m_RexyInputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IRexyInputActions instance)
        {
            foreach (var item in m_Wrapper.m_RexyInputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_RexyInputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public RexyInputActions @RexyInput => new RexyInputActions(this);

    // InvertedRexyInput
    private readonly InputActionMap m_InvertedRexyInput;
    private List<IInvertedRexyInputActions> m_InvertedRexyInputActionsCallbackInterfaces = new List<IInvertedRexyInputActions>();
    private readonly InputAction m_InvertedRexyInput_Look;
    private readonly InputAction m_InvertedRexyInput_Aim;
    private readonly InputAction m_InvertedRexyInput_Shoot;
    private readonly InputAction m_InvertedRexyInput_SwitchInputLayout;
    public struct InvertedRexyInputActions
    {
        private @InputSystem m_Wrapper;
        public InvertedRexyInputActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_InvertedRexyInput_Look;
        public InputAction @Aim => m_Wrapper.m_InvertedRexyInput_Aim;
        public InputAction @Shoot => m_Wrapper.m_InvertedRexyInput_Shoot;
        public InputAction @SwitchInputLayout => m_Wrapper.m_InvertedRexyInput_SwitchInputLayout;
        public InputActionMap Get() { return m_Wrapper.m_InvertedRexyInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InvertedRexyInputActions set) { return set.Get(); }
        public void AddCallbacks(IInvertedRexyInputActions instance)
        {
            if (instance == null || m_Wrapper.m_InvertedRexyInputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InvertedRexyInputActionsCallbackInterfaces.Add(instance);
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @Aim.started += instance.OnAim;
            @Aim.performed += instance.OnAim;
            @Aim.canceled += instance.OnAim;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @SwitchInputLayout.started += instance.OnSwitchInputLayout;
            @SwitchInputLayout.performed += instance.OnSwitchInputLayout;
            @SwitchInputLayout.canceled += instance.OnSwitchInputLayout;
        }

        private void UnregisterCallbacks(IInvertedRexyInputActions instance)
        {
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @Aim.started -= instance.OnAim;
            @Aim.performed -= instance.OnAim;
            @Aim.canceled -= instance.OnAim;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @SwitchInputLayout.started -= instance.OnSwitchInputLayout;
            @SwitchInputLayout.performed -= instance.OnSwitchInputLayout;
            @SwitchInputLayout.canceled -= instance.OnSwitchInputLayout;
        }

        public void RemoveCallbacks(IInvertedRexyInputActions instance)
        {
            if (m_Wrapper.m_InvertedRexyInputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInvertedRexyInputActions instance)
        {
            foreach (var item in m_Wrapper.m_InvertedRexyInputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InvertedRexyInputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InvertedRexyInputActions @InvertedRexyInput => new InvertedRexyInputActions(this);
    public interface IRexyInputActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnSwitchInputLayout(InputAction.CallbackContext context);
    }
    public interface IInvertedRexyInputActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnSwitchInputLayout(InputAction.CallbackContext context);
    }
}
