//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Input/InputActions.inputactions
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

public partial class @InputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""XRInteractor"",
            ""id"": ""d416b2c7-c8d7-4059-a85c-832fde417cd7"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Value"",
                    ""id"": ""c77f268e-f0e7-4c87-ad3f-36b099ad62ed"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bd2b85ef-571b-4d65-8e0b-dd629d89e0e6"",
                    ""path"": ""<XRController>{LeftHand}/isTracked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bbf20bb-c82e-4b6c-a1a1-3719ffb09bd1"",
                    ""path"": ""<XRController>{RightHand}/isTracked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // XRInteractor
        m_XRInteractor = asset.FindActionMap("XRInteractor", throwIfNotFound: true);
        m_XRInteractor_Newaction = m_XRInteractor.FindAction("New action", throwIfNotFound: true);
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

    // XRInteractor
    private readonly InputActionMap m_XRInteractor;
    private IXRInteractorActions m_XRInteractorActionsCallbackInterface;
    private readonly InputAction m_XRInteractor_Newaction;
    public struct XRInteractorActions
    {
        private @InputActions m_Wrapper;
        public XRInteractorActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_XRInteractor_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_XRInteractor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(XRInteractorActions set) { return set.Get(); }
        public void SetCallbacks(IXRInteractorActions instance)
        {
            if (m_Wrapper.m_XRInteractorActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_XRInteractorActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_XRInteractorActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_XRInteractorActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_XRInteractorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public XRInteractorActions @XRInteractor => new XRInteractorActions(this);
    public interface IXRInteractorActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
