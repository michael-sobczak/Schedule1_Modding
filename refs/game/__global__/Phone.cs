public class Phone : PlayerSingleton<Phone> // TypeDefIndex: 2807
{
	// Fields
	public static GameObject ActiveApp; // 0x0
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <isHorizontal>k__BackingField; // 0x21
	[CompilerGenerated]
	private bool <isOpenable>k__BackingField; // 0x22
	[CompilerGenerated]
	private bool <FlashlightOn>k__BackingField; // 0x23
	public PhoneCallData testData; // 0x28
	public CallerID testCalller; // 0x30
	[SerializeField]
	[Header("References")]
	protected GameObject phoneModel; // 0x38
	[SerializeField]
	protected Transform orientation_Vertical; // 0x40
	[SerializeField]
	protected Transform orientation_Horizontal; // 0x48
	[SerializeField]
	protected GraphicRaycaster raycaster; // 0x50
	[SerializeField]
	protected GameObject PhoneFlashlight; // 0x58
	[SerializeField]
	protected AudioSourceController FlashlightToggleSound; // 0x60
	[Header("Settings")]
	public float rotationTime; // 0x68
	public float LookOffsetMax; // 0x6C
	public float LookOffsetMin; // 0x70
	public float OpenVerticalOffset; // 0x74
	public Action onPhoneOpened; // 0x78
	public Action onPhoneClosed; // 0x80
	public Action closeApps; // 0x88
	private EventSystem eventSystem; // 0x90
	private VisibilityAttribute flashlightVisibility; // 0x98
	private Coroutine rotationCoroutine; // 0xA0
	private Coroutine lookOffsetCoroutine; // 0xA8

	// Properties
	public bool IsOpen { get; set; }
	public bool isHorizontal { get; set; }
	public bool isOpenable { get; set; }
	public bool FlashlightOn { get; set; }
	public float ScaledLookOffset { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x563D50 Offset: 0x562750 VA: 0x180563D50
	public bool get_isHorizontal() { }

	[CompilerGenerated]
	// RVA: 0x563DA0 Offset: 0x5627A0 VA: 0x180563DA0
	protected void set_isHorizontal(bool value) { }

	[CompilerGenerated]
	// RVA: 0x563D70 Offset: 0x562770 VA: 0x180563D70
	public bool get_isOpenable() { }

	[CompilerGenerated]
	// RVA: 0x9341D0 Offset: 0x932BD0 VA: 0x1809341D0
	protected void set_isOpenable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x563D60 Offset: 0x562760 VA: 0x180563D60
	public bool get_FlashlightOn() { }

	[CompilerGenerated]
	// RVA: 0x9347A0 Offset: 0x9331A0 VA: 0x1809347A0
	protected void set_FlashlightOn(bool value) { }

	// RVA: 0x934700 Offset: 0x933100 VA: 0x180934700
	public float get_ScaledLookOffset() { }

	// RVA: 0x9338B0 Offset: 0x9322B0 VA: 0x1809338B0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x933BC0 Offset: 0x9325C0 VA: 0x180933BC0 Slot: 6
	public override void OnStartClient(bool IsOwner) { }

	// RVA: 0x9341E0 Offset: 0x932BE0 VA: 0x1809341E0 Slot: 5
	protected override void Start() { }

	// RVA: 0x9343A0 Offset: 0x932DA0 VA: 0x1809343A0 Slot: 8
	protected virtual void Update() { }

	// RVA: 0x933B50 Offset: 0x932550 VA: 0x180933B50 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x9342E0 Offset: 0x932CE0 VA: 0x1809342E0
	private void ToggleFlashlight() { }

	// RVA: 0x933930 Offset: 0x932330 VA: 0x180933930
	private void LateUpdate() { }

	// RVA: 0x9341D0 Offset: 0x932BD0 VA: 0x1809341D0
	public void SetOpenable(bool o) { }

	// RVA: 0x933E30 Offset: 0x932830 VA: 0x180933E30
	public void SetIsOpen(bool o) { }

	// RVA: 0x933D70 Offset: 0x932770 VA: 0x180933D70
	public void SetIsHorizontal(bool h) { }

	[IteratorStateMachine(typeof(Phone.<SetIsHorizontal_Process>d__47))]
	// RVA: 0x933CF0 Offset: 0x9326F0 VA: 0x180933CF0
	protected IEnumerator SetIsHorizontal_Process(bool h) { }

	// RVA: 0x934010 Offset: 0x932A10 VA: 0x180934010
	public void SetLookOffsetMultiplier(float multiplier) { }

	// RVA: 0x933C50 Offset: 0x932650 VA: 0x180933C50
	public void RequestCloseApp() { }

	[IteratorStateMachine(typeof(Phone.<SetLookOffset_Process>d__51))]
	// RVA: 0x934150 Offset: 0x932B50 VA: 0x180934150
	protected IEnumerator SetLookOffset_Process(float lookOffset) { }

	// RVA: 0x9339A0 Offset: 0x9323A0 VA: 0x1809339A0
	public bool MouseRaycast(out RaycastResult result) { }

	// RVA: 0x9346A0 Offset: 0x9330A0 VA: 0x1809346A0
	public void .ctor() { }
}
