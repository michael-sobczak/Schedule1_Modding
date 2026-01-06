public class ManagementMode : Singleton<ManagementMode> // TypeDefIndex: 1230
{
	// Fields
	[CompilerGenerated]
	private Property <CurrentProperty>k__BackingField; // 0x28
	[Header("References")]
	public InputPrompt ManagementModeInputPrompt; // 0x30
	[Header("UI References")]
	public Canvas Canvas; // 0x38
	public UnityEvent OnEnterManagementMode; // 0x40
	public UnityEvent onExitManagementMode; // 0x48

	// Properties
	public Property CurrentProperty { get; set; }
	public bool isActive { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Property get_CurrentProperty() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_CurrentProperty(Property value) { }

	// RVA: 0x61AC60 Offset: 0x619660 VA: 0x18061AC60
	public bool get_isActive() { }

	// RVA: 0x61A580 Offset: 0x618F80 VA: 0x18061A580 Slot: 4
	protected override void Start() { }

	// RVA: 0x61AB10 Offset: 0x619510 VA: 0x18061AB10
	private void Update() { }

	// RVA: 0x61A650 Offset: 0x619050 VA: 0x18061A650
	private void UpdateInput() { }

	// RVA: 0x61A4E0 Offset: 0x618EE0 VA: 0x18061A4E0
	private void Exit(ExitAction exitAction) { }

	// RVA: 0x61A260 Offset: 0x618C60 VA: 0x18061A260
	public void EnterManagementMode(Property property) { }

	// RVA: 0x61A3A0 Offset: 0x618DA0 VA: 0x18061A3A0
	public void ExitManagementMode() { }

	// RVA: 0x61A150 Offset: 0x618B50 VA: 0x18061A150
	public static bool CanEnterManagementMode() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	public static bool CanExitManagementMode() { }

	// RVA: 0x61AC20 Offset: 0x619620 VA: 0x18061AC20
	public void .ctor() { }
}
