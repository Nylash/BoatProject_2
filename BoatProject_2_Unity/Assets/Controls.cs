//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Controls.inputactions
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

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""4fdf3504-16b9-4ec1-a86f-021f2b029ca0"",
            ""actions"": [
                {
                    ""name"": ""Debug_Respawn"",
                    ""type"": ""Button"",
                    ""id"": ""7f94ae01-2a95-48f1-8dcb-97f3d1adf940"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Orientation"",
                    ""type"": ""Value"",
                    ""id"": ""a87e72b2-b2e2-484b-a690-1574cf050721"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SpeedUp"",
                    ""type"": ""Button"",
                    ""id"": ""b1f5b203-1c80-4318-80e8-60bd8e33d21a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SpeedDown"",
                    ""type"": ""Button"",
                    ""id"": ""16f80dc0-1ce2-486d-b109-d8c7d5f55e74"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""743e7e7c-e494-4337-ba6c-88954a09e546"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Debug_Respawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbb99a9b-e90e-4e5b-b1fd-d9883b6bc31f"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Orientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""6d39761c-3ad0-4886-a1c5-0bb55bcade26"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Orientation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c9b5f5f2-a69e-488c-a47a-944bd366b78b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Orientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""730f93e1-115d-4f5c-b172-ed0afab9a214"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Orientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""13c863da-efc0-47e6-b500-79aa84ac23c1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""SpeedUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18bc8959-bb96-4110-b0e3-a25daeb4c345"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpeedUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2eac762-3bf5-4787-bdf0-c2223bec92d3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""SpeedDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91d539b0-9947-4675-8486-e6a9903b664d"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpeedDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Debug_Respawn = m_Gameplay.FindAction("Debug_Respawn", throwIfNotFound: true);
        m_Gameplay_Orientation = m_Gameplay.FindAction("Orientation", throwIfNotFound: true);
        m_Gameplay_SpeedUp = m_Gameplay.FindAction("SpeedUp", throwIfNotFound: true);
        m_Gameplay_SpeedDown = m_Gameplay.FindAction("SpeedDown", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Debug_Respawn;
    private readonly InputAction m_Gameplay_Orientation;
    private readonly InputAction m_Gameplay_SpeedUp;
    private readonly InputAction m_Gameplay_SpeedDown;
    public struct GameplayActions
    {
        private @Controls m_Wrapper;
        public GameplayActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Debug_Respawn => m_Wrapper.m_Gameplay_Debug_Respawn;
        public InputAction @Orientation => m_Wrapper.m_Gameplay_Orientation;
        public InputAction @SpeedUp => m_Wrapper.m_Gameplay_SpeedUp;
        public InputAction @SpeedDown => m_Wrapper.m_Gameplay_SpeedDown;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Debug_Respawn.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebug_Respawn;
                @Debug_Respawn.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebug_Respawn;
                @Debug_Respawn.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebug_Respawn;
                @Orientation.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOrientation;
                @Orientation.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOrientation;
                @Orientation.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOrientation;
                @SpeedUp.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeedUp;
                @SpeedUp.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeedUp;
                @SpeedUp.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeedUp;
                @SpeedDown.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeedDown;
                @SpeedDown.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeedDown;
                @SpeedDown.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeedDown;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Debug_Respawn.started += instance.OnDebug_Respawn;
                @Debug_Respawn.performed += instance.OnDebug_Respawn;
                @Debug_Respawn.canceled += instance.OnDebug_Respawn;
                @Orientation.started += instance.OnOrientation;
                @Orientation.performed += instance.OnOrientation;
                @Orientation.canceled += instance.OnOrientation;
                @SpeedUp.started += instance.OnSpeedUp;
                @SpeedUp.performed += instance.OnSpeedUp;
                @SpeedUp.canceled += instance.OnSpeedUp;
                @SpeedDown.started += instance.OnSpeedDown;
                @SpeedDown.performed += instance.OnSpeedDown;
                @SpeedDown.canceled += instance.OnSpeedDown;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnDebug_Respawn(InputAction.CallbackContext context);
        void OnOrientation(InputAction.CallbackContext context);
        void OnSpeedUp(InputAction.CallbackContext context);
        void OnSpeedDown(InputAction.CallbackContext context);
    }
}
