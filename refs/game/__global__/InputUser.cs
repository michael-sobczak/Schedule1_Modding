public struct InputUser : IEquatable<InputUser> // TypeDefIndex: 7503
{
	// Fields
	public const uint InvalidId = 0;
	private static readonly ProfilerMarker k_InputUserOnChangeMarker; // 0x0
	private static readonly ProfilerMarker k_InputCheckForUnpairMarker; // 0x8
	private uint m_Id; // 0x0
	private static InputUser.GlobalState s_GlobalState; // 0x10

	// Properties
	public bool valid { get; }
	public int index { get; }
	public uint id { get; }
	public Nullable<InputUserAccountHandle> platformUserAccountHandle { get; }
	public string platformUserAccountName { get; }
	public string platformUserAccountId { get; }
	public ReadOnlyArray<InputDevice> pairedDevices { get; }
	public ReadOnlyArray<InputDevice> lostDevices { get; }
	public IInputActionCollection actions { get; }
	public Nullable<InputControlScheme> controlScheme { get; }
	public InputControlScheme.MatchResult controlSchemeMatch { get; }
	public bool hasMissingRequiredDevices { get; }
	public static ReadOnlyArray<InputUser> all { get; }
	public static int listenForUnpairedDeviceActivity { get; set; }

	// Methods

	// RVA: 0x2829050 Offset: 0x2827A50 VA: 0x182829050
	public bool get_valid() { }

	// RVA: 0x2828A90 Offset: 0x2827490 VA: 0x182828A90
	public int get_index() { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public uint get_id() { }

	// RVA: 0x2828E80 Offset: 0x2827880 VA: 0x182828E80
	public Nullable<InputUserAccountHandle> get_platformUserAccountHandle() { }

	// RVA: 0x2828FC0 Offset: 0x28279C0 VA: 0x182828FC0
	public string get_platformUserAccountName() { }

	// RVA: 0x2828F30 Offset: 0x2827930 VA: 0x182828F30
	public string get_platformUserAccountId() { }

	// RVA: 0x2828DB0 Offset: 0x28277B0 VA: 0x182828DB0
	public ReadOnlyArray<InputDevice> get_pairedDevices() { }

	// RVA: 0x2828CE0 Offset: 0x28276E0 VA: 0x182828CE0
	public ReadOnlyArray<InputDevice> get_lostDevices() { }

	// RVA: 0x2828750 Offset: 0x2827150 VA: 0x182828750
	public IInputActionCollection get_actions() { }

	// RVA: 0x2828940 Offset: 0x2827340 VA: 0x182828940
	public Nullable<InputControlScheme> get_controlScheme() { }

	// RVA: 0x2828870 Offset: 0x2827270 VA: 0x182828870
	public InputControlScheme.MatchResult get_controlSchemeMatch() { }

	// RVA: 0x28289F0 Offset: 0x28273F0 VA: 0x1828289F0
	public bool get_hasMissingRequiredDevices() { }

	// RVA: 0x28287E0 Offset: 0x28271E0 VA: 0x1828287E0
	public static ReadOnlyArray<InputUser> get_all() { }

	// RVA: 0x28284E0 Offset: 0x2826EE0 VA: 0x1828284E0
	public static void add_onChange(Action<InputUser, InputUserChange, InputDevice> value) { }

	// RVA: 0x2829120 Offset: 0x2827B20 VA: 0x182829120
	public static void remove_onChange(Action<InputUser, InputUserChange, InputDevice> value) { }

	// RVA: 0x2828660 Offset: 0x2827060 VA: 0x182828660
	public static void add_onUnpairedDeviceUsed(Action<InputControl, InputEventPtr> value) { }

	// RVA: 0x28292A0 Offset: 0x2827CA0 VA: 0x1828292A0
	public static void remove_onUnpairedDeviceUsed(Action<InputControl, InputEventPtr> value) { }

	// RVA: 0x28285A0 Offset: 0x2826FA0 VA: 0x1828285A0
	public static void add_onPrefilterUnpairedDeviceActivity(Func<InputDevice, InputEventPtr, bool> value) { }

	// RVA: 0x28291E0 Offset: 0x2827BE0 VA: 0x1828291E0
	public static void remove_onPrefilterUnpairedDeviceActivity(Func<InputDevice, InputEventPtr, bool> value) { }

	// RVA: 0x2828C80 Offset: 0x2827680 VA: 0x182828C80
	public static int get_listenForUnpairedDeviceActivity() { }

	// RVA: 0x28293C0 Offset: 0x2827DC0 VA: 0x1828293C0
	public static void set_listenForUnpairedDeviceActivity(int value) { }

	// RVA: 0x2826380 Offset: 0x2824D80 VA: 0x182826380 Slot: 3
	public override string ToString() { }

	// RVA: 0x28221F0 Offset: 0x2820BF0 VA: 0x1828221F0
	public void AssociateActionsWithUser(IInputActionCollection actions) { }

	// RVA: 0x28216D0 Offset: 0x28200D0 VA: 0x1828216D0
	public InputUser.ControlSchemeChangeSyntax ActivateControlScheme(string schemeName) { }

	// RVA: 0x2826680 Offset: 0x2825080 VA: 0x182826680
	private bool TryFindControlScheme(string schemeName, out InputControlScheme scheme) { }

	// RVA: 0x2822A60 Offset: 0x2821460 VA: 0x182822A60
	internal void FindControlScheme(string schemeName, out InputControlScheme scheme) { }

	// RVA: 0x28214D0 Offset: 0x281FED0 VA: 0x1828214D0
	public InputUser.ControlSchemeChangeSyntax ActivateControlScheme(InputControlScheme scheme) { }

	// RVA: 0x2820FF0 Offset: 0x281F9F0 VA: 0x182820FF0
	private void ActivateControlSchemeInternal(int userIndex, InputControlScheme scheme) { }

	// RVA: 0x2826FC0 Offset: 0x28259C0 VA: 0x182826FC0
	public void UnpairDevice(InputDevice device) { }

	// RVA: 0x2827150 Offset: 0x2825B50 VA: 0x182827150
	public void UnpairDevices() { }

	// RVA: 0x2825A10 Offset: 0x2824410 VA: 0x182825A10
	private static void RemoveLostDevicesForUser(int userIndex) { }

	// RVA: 0x28270E0 Offset: 0x2825AE0 VA: 0x1828270E0
	public void UnpairDevicesAndRemoveUser() { }

	// RVA: 0x2823350 Offset: 0x2821D50 VA: 0x182823350
	public static InputControlList<InputDevice> GetUnpairedInputDevices() { }

	// RVA: 0x2823160 Offset: 0x2821B60 VA: 0x182823160
	public static int GetUnpairedInputDevices(ref InputControlList<InputDevice> list) { }

	// RVA: 0x2822F00 Offset: 0x2821900 VA: 0x182822F00
	public static Nullable<InputUser> FindUserPairedToDevice(InputDevice device) { }

	// RVA: 0x2822C70 Offset: 0x2821670 VA: 0x182822C70
	public static Nullable<InputUser> FindUserByAccount(InputUserAccountHandle platformUserAccountHandle) { }

	// RVA: 0x2822850 Offset: 0x2821250 VA: 0x182822850
	public static InputUser CreateUserWithoutPairedDevices() { }

	// RVA: 0x2824CC0 Offset: 0x28236C0 VA: 0x182824CC0
	public static InputUser PerformPairingWithDevice(InputDevice device, InputUser user, InputUserPairingOptions options = 0) { }

	// RVA: 0x2823900 Offset: 0x2822300 VA: 0x182823900
	private static bool InitiateUserAccountSelection(int userIndex, InputDevice device, InputUserPairingOptions options) { }

	// RVA: 0xC7B890 Offset: 0xC7A290 VA: 0x180C7B890 Slot: 4
	public bool Equals(InputUser other) { }

	// RVA: 0x28229C0 Offset: 0x28213C0 VA: 0x1828229C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7B900 Offset: 0xC7A300 VA: 0x180C7B900
	public static bool op_Equality(InputUser left, InputUser right) { }

	// RVA: 0xCB1130 Offset: 0xCAFB30 VA: 0x180CB1130
	public static bool op_Inequality(InputUser left, InputUser right) { }

	// RVA: 0x2822050 Offset: 0x2820A50 VA: 0x182822050
	private static int AddUser() { }

	// RVA: 0x2825C40 Offset: 0x2824640 VA: 0x182825C40
	private static void RemoveUser(int userIndex) { }

	// RVA: 0x2823B40 Offset: 0x2822540 VA: 0x182823B40
	private static void Notify(int userIndex, InputUserChange change, InputDevice device) { }

	// RVA: 0x28269A0 Offset: 0x28253A0 VA: 0x1828269A0
	private static int TryFindUserIndex(uint userId) { }

	// RVA: 0x2826BD0 Offset: 0x28255D0 VA: 0x182826BD0
	private static int TryFindUserIndex(InputUserAccountHandle platformHandle) { }

	// RVA: 0x2826A80 Offset: 0x2825480 VA: 0x182826A80
	private static int TryFindUserIndex(InputDevice device) { }

	// RVA: 0x28217B0 Offset: 0x28201B0 VA: 0x1828217B0
	private static void AddDeviceToUser(int userIndex, InputDevice device, bool asLostDevice = False, bool dontUpdateControlScheme = False) { }

	// RVA: 0x2825210 Offset: 0x2823C10 VA: 0x182825210
	private static void RemoveDeviceFromUser(int userIndex, InputDevice device, bool asLostDevice = False) { }

	// RVA: 0x28273E0 Offset: 0x2825DE0 VA: 0x1828273E0
	private static void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing = False) { }

	// RVA: 0x2827DC0 Offset: 0x28267C0 VA: 0x182827DC0
	private static long UpdatePlatformUserAccount(int userIndex, InputDevice device) { }

	// RVA: 0x2824FB0 Offset: 0x28239B0 VA: 0x182824FB0
	private static long QueryPairedPlatformUserAccount(InputDevice device, out Nullable<InputUserAccountHandle> platformAccountHandle, out string platformAccountName, out string platformAccountId) { }

	// RVA: 0x2823850 Offset: 0x2822250 VA: 0x182823850
	private static bool InitiateUserAccountSelectionAtPlatformLevel(InputDevice device) { }

	// RVA: 0x2823E10 Offset: 0x2822810 VA: 0x182823E10
	private static void OnActionChange(object obj, InputActionChange change) { }

	// RVA: 0x2823F80 Offset: 0x2822980 VA: 0x182823F80
	private static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x2822B80 Offset: 0x2821580 VA: 0x182822B80
	private static int FindLostDevice(InputDevice device, int startIndex = 0) { }

	// RVA: 0x2824720 Offset: 0x2823120 VA: 0x182824720
	private static void OnEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x2826120 Offset: 0x2824B20 VA: 0x182826120
	internal static ISavedState SaveAndResetState() { }

	// RVA: 0x28233D0 Offset: 0x2821DD0 VA: 0x1828233D0
	private static void HookIntoActionChange() { }

	// RVA: 0x2826D10 Offset: 0x2825710 VA: 0x182826D10
	private static void UnhookFromActionChange() { }

	// RVA: 0x2823550 Offset: 0x2821F50 VA: 0x182823550
	private static void HookIntoDeviceChange() { }

	// RVA: 0x2826E10 Offset: 0x2825810 VA: 0x182826E10
	private static void UnhookFromDeviceChange() { }

	// RVA: 0x28236C0 Offset: 0x28220C0 VA: 0x1828236C0
	private static void HookIntoEvents() { }

	// RVA: 0x2826ED0 Offset: 0x28258D0 VA: 0x182826ED0
	private static void UnhookFromDeviceStateChange() { }

	// RVA: 0x28228C0 Offset: 0x28212C0 VA: 0x1828228C0
	private static void DisposeAndResetGlobalState() { }

	// RVA: 0x2825FE0 Offset: 0x28249E0 VA: 0x182825FE0
	internal static void ResetGlobals() { }

	// RVA: 0x2828440 Offset: 0x2826E40 VA: 0x182828440
	private static void .cctor() { }
}
