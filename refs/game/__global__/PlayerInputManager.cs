public class PlayerInputManager : MonoBehaviour // TypeDefIndex: 7453
{
	// Fields
	public const string PlayerJoinedMessage = "OnPlayerJoined";
	public const string PlayerLeftMessage = "OnPlayerLeft";
	[CompilerGenerated]
	private static PlayerInputManager <instance>k__BackingField; // 0x0
	[SerializeField]
	internal PlayerNotifications m_NotificationBehavior; // 0x20
	[Tooltip("Set a limit for the maximum number of players who are able to join.")]
	[SerializeField]
	internal int m_MaxPlayerCount; // 0x24
	[SerializeField]
	internal bool m_AllowJoining; // 0x28
	[SerializeField]
	internal PlayerJoinBehavior m_JoinBehavior; // 0x2C
	[SerializeField]
	internal PlayerInputManager.PlayerJoinedEvent m_PlayerJoinedEvent; // 0x30
	[SerializeField]
	internal PlayerInputManager.PlayerLeftEvent m_PlayerLeftEvent; // 0x38
	[SerializeField]
	internal InputActionProperty m_JoinAction; // 0x40
	[SerializeField]
	internal GameObject m_PlayerPrefab; // 0x58
	[SerializeField]
	internal bool m_SplitScreen; // 0x60
	[SerializeField]
	internal bool m_MaintainAspectRatioInSplitScreen; // 0x61
	[SerializeField]
	[Tooltip("Explicitly set a fixed number of screens or otherwise allow the screen to be divided automatically to best fit the number of players.")]
	internal int m_FixedNumberOfSplitScreens; // 0x64
	[SerializeField]
	internal Rect m_SplitScreenRect; // 0x68
	private bool m_JoinActionDelegateHooked; // 0x78
	private bool m_UnpairedDeviceUsedDelegateHooked; // 0x79
	private Action<InputAction.CallbackContext> m_JoinActionDelegate; // 0x80
	private Action<InputControl, InputEventPtr> m_UnpairedDeviceUsedDelegate; // 0x88
	private CallbackArray<Action<PlayerInput>> m_PlayerJoinedCallbacks; // 0x90
	private CallbackArray<Action<PlayerInput>> m_PlayerLeftCallbacks; // 0xE0

	// Properties
	public bool splitScreen { get; set; }
	public bool maintainAspectRatioInSplitScreen { get; }
	public int fixedNumberOfSplitScreens { get; }
	public Rect splitScreenArea { get; }
	public int playerCount { get; }
	public int maxPlayerCount { get; }
	public bool joiningEnabled { get; }
	public PlayerJoinBehavior joinBehavior { get; set; }
	public InputActionProperty joinAction { get; set; }
	public PlayerNotifications notificationBehavior { get; set; }
	public PlayerInputManager.PlayerJoinedEvent playerJoinedEvent { get; }
	public PlayerInputManager.PlayerLeftEvent playerLeftEvent { get; }
	public GameObject playerPrefab { get; set; }
	public static PlayerInputManager instance { get; set; }
	internal static string[] messages { get; }

	// Methods

	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	public bool get_splitScreen() { }

	// RVA: 0x282CA20 Offset: 0x282B420 VA: 0x18282CA20
	public void set_splitScreen(bool value) { }

	// RVA: 0x848340 Offset: 0x846D40 VA: 0x180848340
	public bool get_maintainAspectRatioInSplitScreen() { }

	// RVA: 0x4B5430 Offset: 0x4B3E30 VA: 0x1804B5430
	public int get_fixedNumberOfSplitScreens() { }

	// RVA: 0x4F9E50 Offset: 0x4F8850 VA: 0x1804F9E50
	public Rect get_splitScreenArea() { }

	// RVA: 0x282C610 Offset: 0x282B010 VA: 0x18282C610
	public int get_playerCount() { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_maxPlayerCount() { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_joiningEnabled() { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public PlayerJoinBehavior get_joinBehavior() { }

	// RVA: 0x282C9D0 Offset: 0x282B3D0 VA: 0x18282C9D0
	public void set_joinBehavior(PlayerJoinBehavior value) { }

	// RVA: 0x1BB9720 Offset: 0x1BB8120 VA: 0x181BB9720
	public InputActionProperty get_joinAction() { }

	// RVA: 0x282C920 Offset: 0x282B320 VA: 0x18282C920
	public void set_joinAction(InputActionProperty value) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public PlayerNotifications get_notificationBehavior() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_notificationBehavior(PlayerNotifications value) { }

	// RVA: 0x282C660 Offset: 0x282B060 VA: 0x18282C660
	public PlayerInputManager.PlayerJoinedEvent get_playerJoinedEvent() { }

	// RVA: 0x282C6F0 Offset: 0x282B0F0 VA: 0x18282C6F0
	public PlayerInputManager.PlayerLeftEvent get_playerLeftEvent() { }

	// RVA: 0x282C3F0 Offset: 0x282ADF0 VA: 0x18282C3F0
	public void add_onPlayerJoined(Action<PlayerInput> value) { }

	// RVA: 0x282C780 Offset: 0x282B180 VA: 0x18282C780
	public void remove_onPlayerJoined(Action<PlayerInput> value) { }

	// RVA: 0x282C490 Offset: 0x282AE90 VA: 0x18282C490
	public void add_onPlayerLeft(Action<PlayerInput> value) { }

	// RVA: 0x282C820 Offset: 0x282B220 VA: 0x18282C820
	public void remove_onPlayerLeft(Action<PlayerInput> value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public GameObject get_playerPrefab() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_playerPrefab(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x282C530 Offset: 0x282AF30 VA: 0x18282C530
	public static PlayerInputManager get_instance() { }

	[CompilerGenerated]
	// RVA: 0x282C8C0 Offset: 0x282B2C0 VA: 0x18282C8C0
	private static void set_instance(PlayerInputManager value) { }

	// RVA: 0x282A8C0 Offset: 0x28292C0 VA: 0x18282A8C0
	public void EnableJoining() { }

	// RVA: 0x282A780 Offset: 0x2829180 VA: 0x18282A780
	public void DisableJoining() { }

	// RVA: 0x282B080 Offset: 0x2829A80 VA: 0x18282B080
	internal void JoinPlayerFromUI() { }

	// RVA: 0x282B010 Offset: 0x2829A10 VA: 0x18282B010
	public void JoinPlayerFromAction(InputAction.CallbackContext context) { }

	// RVA: 0x282AF20 Offset: 0x2829920 VA: 0x18282AF20
	public void JoinPlayerFromActionIfNotAlreadyJoined(InputAction.CallbackContext context) { }

	// RVA: 0x282B0E0 Offset: 0x2829AE0 VA: 0x18282B0E0
	public PlayerInput JoinPlayer(int playerIndex = -1, int splitScreenIndex = -1, string controlScheme, InputDevice pairWithDevice) { }

	// RVA: 0x282B300 Offset: 0x2829D00 VA: 0x18282B300
	public PlayerInput JoinPlayer(int playerIndex = -1, int splitScreenIndex = -1, string controlScheme, InputDevice[] pairWithDevices) { }

	// RVA: 0x282C570 Offset: 0x282AF70 VA: 0x18282C570
	internal static string[] get_messages() { }

	// RVA: 0x282A480 Offset: 0x2828E80 VA: 0x18282A480
	private bool CheckIfPlayerCanJoin(int playerIndex = -1) { }

	// RVA: 0x282BCA0 Offset: 0x282A6A0 VA: 0x18282BCA0
	private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr) { }

	// RVA: 0x282B890 Offset: 0x282A290 VA: 0x18282B890
	private void OnEnable() { }

	// RVA: 0x282B7B0 Offset: 0x282A1B0 VA: 0x18282B7B0
	private void OnDisable() { }

	// RVA: 0x282BD50 Offset: 0x282A750 VA: 0x18282BD50
	private void UpdateSplitScreen() { }

	// RVA: 0x282AB00 Offset: 0x2829500 VA: 0x18282AB00
	private bool IsDeviceUsableWithPlayerActions(InputDevice device) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void ValidateInputActionAsset() { }

	// RVA: 0x282B550 Offset: 0x2829F50 VA: 0x18282B550
	internal void NotifyPlayerJoined(PlayerInput player) { }

	// RVA: 0x282B680 Offset: 0x282A080 VA: 0x18282B680
	internal void NotifyPlayerLeft(PlayerInput player) { }

	// RVA: 0x282C3C0 Offset: 0x282ADC0 VA: 0x18282C3C0
	public void .ctor() { }
}
