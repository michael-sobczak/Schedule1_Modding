public class DefaultInputActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable // TypeDefIndex: 7444
{
	// Fields
	[CompilerGenerated]
	private readonly InputActionAsset <asset>k__BackingField; // 0x10
	private readonly InputActionMap m_Player; // 0x18
	private DefaultInputActions.IPlayerActions m_PlayerActionsCallbackInterface; // 0x20
	private readonly InputAction m_Player_Move; // 0x28
	private readonly InputAction m_Player_Look; // 0x30
	private readonly InputAction m_Player_Fire; // 0x38
	private readonly InputActionMap m_UI; // 0x40
	private DefaultInputActions.IUIActions m_UIActionsCallbackInterface; // 0x48
	private readonly InputAction m_UI_Navigate; // 0x50
	private readonly InputAction m_UI_Submit; // 0x58
	private readonly InputAction m_UI_Cancel; // 0x60
	private readonly InputAction m_UI_Point; // 0x68
	private readonly InputAction m_UI_Click; // 0x70
	private readonly InputAction m_UI_ScrollWheel; // 0x78
	private readonly InputAction m_UI_MiddleClick; // 0x80
	private readonly InputAction m_UI_RightClick; // 0x88
	private readonly InputAction m_UI_TrackedDevicePosition; // 0x90
	private readonly InputAction m_UI_TrackedDeviceOrientation; // 0x98
	private int m_KeyboardMouseSchemeIndex; // 0xA0
	private int m_GamepadSchemeIndex; // 0xA4
	private int m_TouchSchemeIndex; // 0xA8
	private int m_JoystickSchemeIndex; // 0xAC
	private int m_XRSchemeIndex; // 0xB0

	// Properties
	public InputActionAsset asset { get; }
	public Nullable<InputBinding> bindingMask { get; set; }
	public Nullable<ReadOnlyArray<InputDevice>> devices { get; set; }
	public ReadOnlyArray<InputControlScheme> controlSchemes { get; }
	public IEnumerable<InputBinding> bindings { get; }
	public DefaultInputActions.PlayerActions Player { get; }
	public DefaultInputActions.UIActions UI { get; }
	public InputControlScheme KeyboardMouseScheme { get; }
	public InputControlScheme GamepadScheme { get; }
	public InputControlScheme TouchScheme { get; }
	public InputControlScheme JoystickScheme { get; }
	public InputControlScheme XRScheme { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public InputActionAsset get_asset() { }

	// RVA: 0x281EC40 Offset: 0x281D640 VA: 0x18281EC40
	public void .ctor() { }

	// RVA: 0x281EB30 Offset: 0x281D530 VA: 0x18281EB30 Slot: 17
	public void Dispose() { }

	// RVA: 0x281F460 Offset: 0x281DE60 VA: 0x18281F460 Slot: 7
	public Nullable<InputBinding> get_bindingMask() { }

	// RVA: 0x281F550 Offset: 0x281DF50 VA: 0x18281F550 Slot: 8
	public void set_bindingMask(Nullable<InputBinding> value) { }

	// RVA: 0x281F510 Offset: 0x281DF10 VA: 0x18281F510 Slot: 9
	public Nullable<ReadOnlyArray<InputDevice>> get_devices() { }

	// RVA: 0x281F5B0 Offset: 0x281DFB0 VA: 0x18281F5B0 Slot: 10
	public void set_devices(Nullable<ReadOnlyArray<InputDevice>> value) { }

	// RVA: 0x281F4D0 Offset: 0x281DED0 VA: 0x18281F4D0 Slot: 11
	public ReadOnlyArray<InputControlScheme> get_controlSchemes() { }

	// RVA: 0x281EAF0 Offset: 0x281D4F0 VA: 0x18281EAF0 Slot: 12
	public bool Contains(InputAction action) { }

	// RVA: 0x281EC20 Offset: 0x281D620 VA: 0x18281EC20 Slot: 15
	public IEnumerator<InputAction> GetEnumerator() { }

	// RVA: 0x281EC20 Offset: 0x281D620 VA: 0x18281EC20 Slot: 16
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x281EB80 Offset: 0x281D580 VA: 0x18281EB80 Slot: 13
	public void Enable() { }

	// RVA: 0x281EB10 Offset: 0x281D510 VA: 0x18281EB10 Slot: 14
	public void Disable() { }

	// RVA: 0x281F4B0 Offset: 0x281DEB0 VA: 0x18281F4B0 Slot: 4
	public IEnumerable<InputBinding> get_bindings() { }

	// RVA: 0x281EBA0 Offset: 0x281D5A0 VA: 0x18281EBA0 Slot: 5
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = False) { }

	// RVA: 0x281EBC0 Offset: 0x281D5C0 VA: 0x18281EBC0 Slot: 6
	public int FindBinding(InputBinding bindingMask, out InputAction action) { }

	// RVA: 0x1CF6580 Offset: 0x1CF4F80 VA: 0x181CF6580
	public DefaultInputActions.PlayerActions get_Player() { }

	// RVA: 0x1CF6580 Offset: 0x1CF4F80 VA: 0x181CF6580
	public DefaultInputActions.UIActions get_UI() { }

	// RVA: 0x281F1F0 Offset: 0x281DBF0 VA: 0x18281F1F0
	public InputControlScheme get_KeyboardMouseScheme() { }

	// RVA: 0x281F050 Offset: 0x281DA50 VA: 0x18281F050
	public InputControlScheme get_GamepadScheme() { }

	// RVA: 0x281F2C0 Offset: 0x281DCC0 VA: 0x18281F2C0
	public InputControlScheme get_TouchScheme() { }

	// RVA: 0x281F120 Offset: 0x281DB20 VA: 0x18281F120
	public InputControlScheme get_JoystickScheme() { }

	// RVA: 0x281F390 Offset: 0x281DD90 VA: 0x18281F390
	public InputControlScheme get_XRScheme() { }
}
