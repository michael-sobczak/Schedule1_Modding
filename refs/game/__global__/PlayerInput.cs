public class PlayerInput : MonoBehaviour // TypeDefIndex: 7450
{
	// Fields
	public const string DeviceLostMessage = "OnDeviceLost";
	public const string DeviceRegainedMessage = "OnDeviceRegained";
	public const string ControlsChangedMessage = "OnControlsChanged";
	private int m_AllMapsHashCode; // 0x20
	[Tooltip("Input actions associated with the player.")]
	[SerializeField]
	internal InputActionAsset m_Actions; // 0x28
	[Tooltip("Determine how notifications should be sent when an input-related event associated with the player happens.")]
	[SerializeField]
	internal PlayerNotifications m_NotificationBehavior; // 0x30
	[SerializeField]
	[Tooltip("UI InputModule that should have it's input actions synchronized to this PlayerInput's actions.")]
	internal InputSystemUIInputModule m_UIInputModule; // 0x38
	[SerializeField]
	[Tooltip("Event that is triggered when the PlayerInput loses a paired device (e.g. its battery runs out).")]
	internal PlayerInput.DeviceLostEvent m_DeviceLostEvent; // 0x40
	[SerializeField]
	internal PlayerInput.DeviceRegainedEvent m_DeviceRegainedEvent; // 0x48
	[SerializeField]
	internal PlayerInput.ControlsChangedEvent m_ControlsChangedEvent; // 0x50
	[SerializeField]
	internal PlayerInput.ActionEvent[] m_ActionEvents; // 0x58
	[SerializeField]
	internal bool m_NeverAutoSwitchControlSchemes; // 0x60
	[SerializeField]
	internal string m_DefaultControlScheme; // 0x68
	[SerializeField]
	internal string m_DefaultActionMap; // 0x70
	[SerializeField]
	internal int m_SplitScreenIndex; // 0x78
	[SerializeField]
	[Tooltip("Reference to the player's view camera. Note that this is only required when using split-screen and/or per-player UIs. Otherwise it is safe to leave this property uninitialized.")]
	internal Camera m_Camera; // 0x80
	private InputValue m_InputValueObject; // 0x88
	internal InputActionMap m_CurrentActionMap; // 0x90
	private int m_PlayerIndex; // 0x98
	private bool m_InputActive; // 0x9C
	private bool m_Enabled; // 0x9D
	internal bool m_ActionsInitialized; // 0x9E
	private Dictionary<string, string> m_ActionMessageNames; // 0xA0
	private InputUser m_InputUser; // 0xA8
	private Action<InputAction.CallbackContext> m_ActionTriggeredDelegate; // 0xB0
	private CallbackArray<Action<PlayerInput>> m_DeviceLostCallbacks; // 0xB8
	private CallbackArray<Action<PlayerInput>> m_DeviceRegainedCallbacks; // 0x108
	private CallbackArray<Action<PlayerInput>> m_ControlsChangedCallbacks; // 0x158
	private CallbackArray<Action<InputAction.CallbackContext>> m_ActionTriggeredCallbacks; // 0x1A8
	private Action<InputControl, InputEventPtr> m_UnpairedDeviceUsedDelegate; // 0x1F8
	private Func<InputDevice, InputEventPtr, bool> m_PreFilterUnpairedDeviceUsedDelegate; // 0x200
	private bool m_OnUnpairedDeviceUsedHooked; // 0x208
	private Action<InputDevice, InputDeviceChange> m_DeviceChangeDelegate; // 0x210
	private bool m_OnDeviceChangeHooked; // 0x218
	internal static int s_AllActivePlayersCount; // 0x0
	internal static PlayerInput[] s_AllActivePlayers; // 0x8
	private static Action<InputUser, InputUserChange, InputDevice> s_UserChangeDelegate; // 0x10
	private static int s_InitPairWithDevicesCount; // 0x18
	private static InputDevice[] s_InitPairWithDevices; // 0x20
	private static int s_InitPlayerIndex; // 0x28
	private static int s_InitSplitScreenIndex; // 0x2C
	private static string s_InitControlScheme; // 0x30
	internal static bool s_DestroyIfDeviceSetupUnsuccessful; // 0x38

	// Properties
	public bool inputIsActive { get; }
	[Obsolete("Use inputIsActive instead.")]
	public bool active { get; }
	public int playerIndex { get; }
	public int splitScreenIndex { get; }
	public InputActionAsset actions { get; set; }
	public string currentControlScheme { get; }
	public string defaultControlScheme { get; set; }
	public bool neverAutoSwitchControlSchemes { get; set; }
	public InputActionMap currentActionMap { get; set; }
	public string defaultActionMap { get; set; }
	public PlayerNotifications notificationBehavior { get; set; }
	public ReadOnlyArray<PlayerInput.ActionEvent> actionEvents { get; set; }
	public PlayerInput.DeviceLostEvent deviceLostEvent { get; }
	public PlayerInput.DeviceRegainedEvent deviceRegainedEvent { get; }
	public PlayerInput.ControlsChangedEvent controlsChangedEvent { get; }
	public Camera camera { get; set; }
	public InputSystemUIInputModule uiInputModule { get; set; }
	public InputUser user { get; }
	public ReadOnlyArray<InputDevice> devices { get; }
	public bool hasMissingRequiredDevices { get; }
	public static ReadOnlyArray<PlayerInput> all { get; }
	public static bool isSinglePlayer { get; }

	// Methods

	// RVA: 0x23E1790 Offset: 0x23E0190 VA: 0x1823E1790
	public bool get_inputIsActive() { }

	// RVA: 0x23E1790 Offset: 0x23E0190 VA: 0x1823E1790
	public bool get_active() { }

	// RVA: 0x4B62D0 Offset: 0x4B4CD0 VA: 0x1804B62D0
	public int get_playerIndex() { }

	// RVA: 0x553640 Offset: 0x552040 VA: 0x180553640
	public int get_splitScreenIndex() { }

	// RVA: 0x28331B0 Offset: 0x2831BB0 VA: 0x1828331B0
	public InputActionAsset get_actions() { }

	// RVA: 0x2833AB0 Offset: 0x28324B0 VA: 0x182833AB0
	public void set_actions(InputActionAsset value) { }

	// RVA: 0x2833320 Offset: 0x2831D20 VA: 0x182833320
	public string get_currentControlScheme() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public string get_defaultControlScheme() { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_defaultControlScheme(string value) { }

	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	public bool get_neverAutoSwitchControlSchemes() { }

	// RVA: 0x2833C70 Offset: 0x2832670 VA: 0x182833C70
	public void set_neverAutoSwitchControlSchemes(bool value) { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public InputActionMap get_currentActionMap() { }

	// RVA: 0x2833BF0 Offset: 0x28325F0 VA: 0x182833BF0
	public void set_currentActionMap(InputActionMap value) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public string get_defaultActionMap() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void set_defaultActionMap(string value) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public PlayerNotifications get_notificationBehavior() { }

	// RVA: 0x2833CB0 Offset: 0x28326B0 VA: 0x182833CB0
	public void set_notificationBehavior(PlayerNotifications value) { }

	// RVA: 0x2833150 Offset: 0x2831B50 VA: 0x182833150
	public ReadOnlyArray<PlayerInput.ActionEvent> get_actionEvents() { }

	// RVA: 0x2833A30 Offset: 0x2832430 VA: 0x182833A30
	public void set_actionEvents(ReadOnlyArray<PlayerInput.ActionEvent> value) { }

	// RVA: 0x28333D0 Offset: 0x2831DD0 VA: 0x1828333D0
	public PlayerInput.DeviceLostEvent get_deviceLostEvent() { }

	// RVA: 0x2833460 Offset: 0x2831E60 VA: 0x182833460
	public PlayerInput.DeviceRegainedEvent get_deviceRegainedEvent() { }

	// RVA: 0x2833290 Offset: 0x2831C90 VA: 0x182833290
	public PlayerInput.ControlsChangedEvent get_controlsChangedEvent() { }

	// RVA: 0x2832ED0 Offset: 0x28318D0 VA: 0x182832ED0
	public void add_onActionTriggered(Action<InputAction.CallbackContext> value) { }

	// RVA: 0x28337B0 Offset: 0x28321B0 VA: 0x1828337B0
	public void remove_onActionTriggered(Action<InputAction.CallbackContext> value) { }

	// RVA: 0x2833010 Offset: 0x2831A10 VA: 0x182833010
	public void add_onDeviceLost(Action<PlayerInput> value) { }

	// RVA: 0x28338F0 Offset: 0x28322F0 VA: 0x1828338F0
	public void remove_onDeviceLost(Action<PlayerInput> value) { }

	// RVA: 0x28330B0 Offset: 0x2831AB0 VA: 0x1828330B0
	public void add_onDeviceRegained(Action<PlayerInput> value) { }

	// RVA: 0x2833990 Offset: 0x2832390 VA: 0x182833990
	public void remove_onDeviceRegained(Action<PlayerInput> value) { }

	// RVA: 0x2832F70 Offset: 0x2831970 VA: 0x182832F70
	public void add_onControlsChanged(Action<PlayerInput> value) { }

	// RVA: 0x2833850 Offset: 0x2832250 VA: 0x182833850
	public void remove_onControlsChanged(Action<PlayerInput> value) { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public Camera get_camera() { }

	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	public void set_camera(Camera value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public InputSystemUIInputModule get_uiInputModule() { }

	// RVA: 0x2833D00 Offset: 0x2832700 VA: 0x182833D00
	public void set_uiInputModule(InputSystemUIInputModule value) { }

	// RVA: 0x587050 Offset: 0x585A50 VA: 0x180587050
	public InputUser get_user() { }

	// RVA: 0x28334F0 Offset: 0x2831EF0 VA: 0x1828334F0
	public ReadOnlyArray<InputDevice> get_devices() { }

	// RVA: 0x28335A0 Offset: 0x2831FA0 VA: 0x1828335A0
	public bool get_hasMissingRequiredDevices() { }

	// RVA: 0x2833200 Offset: 0x2831C00 VA: 0x182833200
	public static ReadOnlyArray<PlayerInput> get_all() { }

	// RVA: 0x28336A0 Offset: 0x28320A0 VA: 0x1828336A0
	public static bool get_isSinglePlayer() { }

	// RVA: -1 Offset: -1
	public TDevice GetDevice<TDevice>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF244C0 Offset: 0xF22EC0 VA: 0x180F244C0
	|-PlayerInput.GetDevice<object>
	*/

	// RVA: 0x282CCB0 Offset: 0x282B6B0 VA: 0x18282CCB0
	public void ActivateInput() { }

	// RVA: 0x2832C80 Offset: 0x2831680 VA: 0x182832C80
	private void UpdateDelegates() { }

	// RVA: 0x282E2A0 Offset: 0x282CCA0 VA: 0x18282E2A0
	public void DeactivateInput() { }

	[Obsolete("Use DeactivateInput instead.")]
	// RVA: 0x282E2A0 Offset: 0x282CCA0 VA: 0x18282E2A0
	public void PassivateInput() { }

	// RVA: 0x2832070 Offset: 0x2830A70 VA: 0x182832070
	public bool SwitchCurrentControlScheme(InputDevice[] devices) { }

	// RVA: 0x28322E0 Offset: 0x2830CE0 VA: 0x1828322E0
	public void SwitchCurrentControlScheme(string controlScheme, InputDevice[] devices) { }

	// RVA: 0x2831E80 Offset: 0x2830880 VA: 0x182831E80
	public void SwitchCurrentActionMap(string mapNameOrId) { }

	// RVA: 0x282E8A0 Offset: 0x282D2A0 VA: 0x18282E8A0
	public static PlayerInput GetPlayerByIndex(int playerIndex) { }

	// RVA: 0x282E680 Offset: 0x282D080 VA: 0x18282E680
	public static PlayerInput FindFirstPairedToDevice(InputDevice device) { }

	// RVA: 0x282F4F0 Offset: 0x282DEF0 VA: 0x18282F4F0
	public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1, string controlScheme, int splitScreenIndex = -1, InputDevice pairWithDevice) { }

	// RVA: 0x282F310 Offset: 0x282DD10 VA: 0x18282F310
	public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1, string controlScheme, int splitScreenIndex = -1, InputDevice[] pairWithDevices) { }

	// RVA: 0x282E330 Offset: 0x282CD30 VA: 0x18282E330
	private static PlayerInput DoInstantiate(GameObject prefab) { }

	// RVA: 0x282EDC0 Offset: 0x282D7C0 VA: 0x18282EDC0
	private void InitializeActions() { }

	// RVA: 0x282E010 Offset: 0x282CA10 VA: 0x18282E010
	private void CopyActionAssetAndApplyBindingOverrides() { }

	// RVA: 0x2832910 Offset: 0x2831310 VA: 0x182832910
	private void UninitializeActions() { }

	// RVA: 0x282F170 Offset: 0x282DB70 VA: 0x18282F170
	private void InstallOnActionTriggeredHook() { }

	// RVA: 0x2832B30 Offset: 0x2831530 VA: 0x182832B30
	private void UninstallOnActionTriggeredHook() { }

	// RVA: 0x282F6B0 Offset: 0x282E0B0 VA: 0x18282F6B0
	private void OnActionTriggered(InputAction.CallbackContext context) { }

	// RVA: 0x282DCC0 Offset: 0x282C6C0 VA: 0x18282DCC0
	private void CacheMessageNames() { }

	// RVA: 0x282DFC0 Offset: 0x282C9C0 VA: 0x18282DFC0
	private void ClearCaches() { }

	// RVA: 0x282D0A0 Offset: 0x282BAA0 VA: 0x18282D0A0
	private void AssignUserAndDevices() { }

	// RVA: 0x282ECB0 Offset: 0x282D6B0 VA: 0x18282ECB0
	private bool HaveBindingForDevice(InputDevice device) { }

	// RVA: 0x28327D0 Offset: 0x28311D0 VA: 0x1828327D0
	private void UnassignUserAndDevices() { }

	// RVA: 0x2832430 Offset: 0x2830E30 VA: 0x182832430
	private bool TryToActivateControlScheme(InputControlScheme controlScheme) { }

	// RVA: 0x282CD70 Offset: 0x282B770 VA: 0x18282CD70
	private void AssignPlayerIndex() { }

	// RVA: 0x282FFE0 Offset: 0x282E9E0 VA: 0x18282FFE0
	private void OnEnable() { }

	// RVA: 0x2831260 Offset: 0x282FC60 VA: 0x182831260
	private void StartListeningForUnpairedDeviceActivity() { }

	// RVA: 0x2831510 Offset: 0x282FF10 VA: 0x182831510
	private void StopListeningForUnpairedDeviceActivity() { }

	// RVA: 0x2831190 Offset: 0x282FB90 VA: 0x182831190
	private void StartListeningForDeviceChanges() { }

	// RVA: 0x28314A0 Offset: 0x282FEA0 VA: 0x1828314A0
	private void StopListeningForDeviceChanges() { }

	// RVA: 0x282FA60 Offset: 0x282E460 VA: 0x18282FA60
	private void OnDisable() { }

	// RVA: 0x282E2D0 Offset: 0x282CCD0 VA: 0x18282E2D0
	public void DebugLogAction(InputAction.CallbackContext context) { }

	// RVA: 0x282EAB0 Offset: 0x282D4B0 VA: 0x18282EAB0
	private void HandleDeviceLost() { }

	// RVA: 0x282EBB0 Offset: 0x282D5B0 VA: 0x18282EBB0
	private void HandleDeviceRegained() { }

	// RVA: 0x282E9B0 Offset: 0x282D3B0 VA: 0x18282E9B0
	private void HandleControlsChanged() { }

	// RVA: 0x2830F90 Offset: 0x282F990 VA: 0x182830F90
	private static void OnUserChange(InputUser user, InputUserChange change, InputDevice device) { }

	// RVA: 0x2830610 Offset: 0x282F010 VA: 0x182830610
	private static bool OnPreFilterUnpairedDeviceUsed(InputDevice device, InputEventPtr eventPtr) { }

	// RVA: 0x28307E0 Offset: 0x282F1E0 VA: 0x1828307E0
	private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x282F900 Offset: 0x282E300 VA: 0x18282F900
	private void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x2831690 Offset: 0x2830090 VA: 0x182831690
	private void SwitchControlSchemeInternal(ref InputControlScheme controlScheme, InputDevice[] devices) { }

	// RVA: 0x2832EB0 Offset: 0x28318B0 VA: 0x182832EB0
	public void .ctor() { }

	// RVA: 0x2832E60 Offset: 0x2831860 VA: 0x182832E60
	private static void .cctor() { }
}
