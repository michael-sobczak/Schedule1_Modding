public class GameInput : PersistentSingleton<GameInput> // TypeDefIndex: 592
{
	// Fields
	[CompilerGenerated]
	private static GameInput.InputDeviceType <CurrentInputDevice>k__BackingField; // 0x0
	public static Action<GameInput.InputDeviceType> OnInputDeviceChanged; // 0x8
	public static List<GameInput.ExitListener> exitListeners; // 0x10
	public PlayerInput PlayerInput; // 0x28
	public static bool IsTyping; // 0x18
	public static Vector2 MotionAxis; // 0x1C
	public static Vector2 CameraAxis; // 0x24
	public static float MouseWheelAxis; // 0x2C
	public static bool ControllerComboActive; // 0x30
	private float vehicleDriveAxis; // 0x30
	private List<GameInput.ButtonCode> buttonsDownThisFrame; // 0x38
	private List<GameInput.ButtonCode> buttonsDown; // 0x40
	private List<GameInput.ButtonCode> buttonsUpThisFrame; // 0x48

	// Properties
	public static GameInput.InputDeviceType CurrentInputDevice { get; set; }
	public static Vector2 MouseDelta { get; }
	public static Vector3 MousePosition { get; }
	public static float MouseScrollDelta { get; }
	public static float VehicleDriveAxis { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xA9D110 Offset: 0xA9BB10 VA: 0x180A9D110
	public static GameInput.InputDeviceType get_CurrentInputDevice() { }

	[CompilerGenerated]
	// RVA: 0xA9D290 Offset: 0xA9BC90 VA: 0x180A9D290
	private static void set_CurrentInputDevice(GameInput.InputDeviceType value) { }

	// RVA: 0xA9D160 Offset: 0xA9BB60 VA: 0x180A9D160
	public static Vector2 get_MouseDelta() { }

	// RVA: 0xA9D1C0 Offset: 0xA9BBC0 VA: 0x180A9D1C0
	public static Vector3 get_MousePosition() { }

	// RVA: 0xA9D1F0 Offset: 0xA9BBF0 VA: 0x180A9D1F0
	public static float get_MouseScrollDelta() { }

	// RVA: 0xA9D240 Offset: 0xA9BC40 VA: 0x180A9D240
	public static float get_VehicleDriveAxis() { }

	// RVA: 0xA9D2F0 Offset: 0xA9BCF0 VA: 0x180A9D2F0
	private static void set_VehicleDriveAxis(float value) { }

	// RVA: 0xA98240 Offset: 0xA96C40 VA: 0x180A98240 Slot: 5
	protected override void Awake() { }

	// RVA: 0xA992F0 Offset: 0xA97CF0 VA: 0x180A992F0 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0xA9CB50 Offset: 0xA9B550 VA: 0x180A9CB50 Slot: 4
	protected override void Start() { }

	// RVA: 0xA98960 Offset: 0xA97360 VA: 0x180A98960
	private void OnApplicationFocus(bool focus) { }

	// RVA: 0xA98860 Offset: 0xA97260 VA: 0x180A98860
	public static bool GetButton(GameInput.ButtonCode buttonCode) { }

	// RVA: 0xA98720 Offset: 0xA97120 VA: 0x180A98720
	public static bool GetButtonDown(GameInput.ButtonCode buttonCode) { }

	// RVA: 0xA987C0 Offset: 0xA971C0 VA: 0x180A987C0
	public static bool GetButtonUp(GameInput.ButtonCode buttonCode) { }

	// RVA: 0xA9CE00 Offset: 0xA9B800 VA: 0x180A9CE00 Slot: 7
	protected virtual void Update() { }

	// RVA: 0xA98560 Offset: 0xA96F60 VA: 0x180A98560
	private void Exit(ExitType type) { }

	// RVA: 0xA98900 Offset: 0xA97300 VA: 0x180A98900
	private void LateUpdate() { }

	// RVA: 0xA983C0 Offset: 0xA96DC0 VA: 0x180A983C0
	public void ExitAll() { }

	// RVA: 0xA98EC0 Offset: 0xA978C0 VA: 0x180A98EC0
	private void OnControlsChanged(PlayerInput input) { }

	// RVA: 0xA99F80 Offset: 0xA98980 VA: 0x180A99F80
	private void OnMotion(InputValue value) { }

	// RVA: 0xA9ABF0 Offset: 0xA995F0 VA: 0x180A9ABF0
	private void OnPrimaryClick() { }

	// RVA: 0xA9B4C0 Offset: 0xA99EC0 VA: 0x180A9B4C0
	private void OnSecondaryClick() { }

	// RVA: 0xA9BCE0 Offset: 0xA9A6E0 VA: 0x180A9BCE0
	private void OnTertiaryClick() { }

	// RVA: 0xA99C00 Offset: 0xA98600 VA: 0x180A99C00
	private void OnJump() { }

	// RVA: 0xA99110 Offset: 0xA97B10 VA: 0x180A99110
	private void OnCrouch() { }

	// RVA: 0xA9B9A0 Offset: 0xA9A3A0 VA: 0x180A9B9A0
	private void OnSprint() { }

	// RVA: 0xA993A0 Offset: 0xA97DA0 VA: 0x180A993A0
	private void OnEscape() { }

	// RVA: 0xA98B00 Offset: 0xA97500 VA: 0x180A98B00
	private void OnBack() { }

	// RVA: 0xA996E0 Offset: 0xA980E0 VA: 0x180A996E0
	private void OnInteract() { }

	// RVA: 0xA9BB40 Offset: 0xA9A540 VA: 0x180A9BB40
	private void OnSubmit() { }

	// RVA: 0xA9C020 Offset: 0xA9AA20 VA: 0x180A9C020
	private void OnTogglePhone() { }

	// RVA: 0xA9C5E0 Offset: 0xA9AFE0 VA: 0x180A9C5E0
	private void OnVehicleToggleLights() { }

	// RVA: 0xA9C2A0 Offset: 0xA9ACA0 VA: 0x180A9C2A0
	private void OnVehicleHandbrake() { }

	// RVA: 0xA9B0F0 Offset: 0xA99AF0 VA: 0x180A9B0F0
	private void OnRotateLeft() { }

	// RVA: 0xA9B290 Offset: 0xA99C90 VA: 0x180A9B290
	private void OnRotateRight() { }

	// RVA: 0xA99DE0 Offset: 0xA987E0 VA: 0x180A99DE0
	private void OnManagementMode() { }

	// RVA: 0xA9A8B0 Offset: 0xA992B0 VA: 0x180A9A8B0
	private void OnOpenMap() { }

	// RVA: 0xA9A710 Offset: 0xA99110 VA: 0x180A9A710
	private void OnOpenJournal() { }

	// RVA: 0xA9AA50 Offset: 0xA99450 VA: 0x180A9AA50
	private void OnOpenTexts() { }

	// RVA: 0xA9AD70 Offset: 0xA99770 VA: 0x180A9AD70
	private void OnQuickMove() { }

	// RVA: 0xA9BE80 Offset: 0xA9A880 VA: 0x180A9BE80
	private void OnToggleFlashlight() { }

	// RVA: 0xA9C780 Offset: 0xA9B180 VA: 0x180A9C780
	private void OnViewAvatar() { }

	// RVA: 0xA9AF10 Offset: 0xA99910 VA: 0x180A9AF10
	private void OnReload() { }

	// RVA: 0xA98CE0 Offset: 0xA976E0 VA: 0x180A98CE0
	private void OnCamera(InputValue value) { }

	// RVA: 0xA9B430 Offset: 0xA99E30 VA: 0x180A9B430
	private void OnScrollWheel(InputValue value) { }

	// RVA: 0xA998C0 Offset: 0xA982C0 VA: 0x180A998C0
	private void OnInventoryLeft() { }

	// RVA: 0xA99A60 Offset: 0xA98460 VA: 0x180A99A60
	private void OnInventoryRight() { }

	// RVA: 0xA99540 Offset: 0xA97F40 VA: 0x180A99540
	private void OnHolster() { }

	// RVA: 0xA98E10 Offset: 0xA97810 VA: 0x180A98E10
	private void OnControllerCombo(InputValue value) { }

	// RVA: 0xA9C440 Offset: 0xA9AE40 VA: 0x180A9C440
	private void OnVehicleResetCamera() { }

	// RVA: 0xA9C1C0 Offset: 0xA9ABC0 VA: 0x180A9C1C0
	private void OnVehicleDrive(InputValue value) { }

	// RVA: 0xA9B660 Offset: 0xA9A060 VA: 0x180A9B660
	private void OnSkateboardDismount() { }

	// RVA: 0xA9B800 Offset: 0xA9A200 VA: 0x180A9B800
	private void OnSkateboardMount() { }

	// RVA: 0xA9C920 Offset: 0xA9B320 VA: 0x180A9C920
	public static void RegisterExitListener(GameInput.ExitDelegate listener, int priority = 0) { }

	// RVA: 0xA98280 Offset: 0xA96C80 VA: 0x180A98280
	public static void DeregisterExitListener(GameInput.ExitDelegate listener) { }

	// RVA: 0xA98690 Offset: 0xA97090 VA: 0x180A98690
	public InputAction GetAction(GameInput.ButtonCode code) { }

	// RVA: 0xA9D020 Offset: 0xA9BA20 VA: 0x180A9D020
	public void .ctor() { }

	// RVA: 0xA9CEE0 Offset: 0xA9B8E0 VA: 0x180A9CEE0
	private static void .cctor() { }
}
