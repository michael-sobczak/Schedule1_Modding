public class GenericUIScreen : MonoBehaviour // TypeDefIndex: 2612
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[Header("Settings")]
	public string Name; // 0x28
	public bool UseExitActions; // 0x30
	public int ExitActionPriority; // 0x34
	public bool CanExitWithRightClick; // 0x38
	public bool ReenableControlsOnClose; // 0x39
	public bool ReenableInventoryOnClose; // 0x3A
	public bool ReenableEquippingOnClose; // 0x3B
	public UnityEvent onOpen; // 0x40
	public UnityEvent onClose; // 0x48

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsOpen(bool value) { }

	// RVA: 0x8E6940 Offset: 0x8E5340 VA: 0x1808E6940
	private void Awake() { }

	// RVA: 0x8E6CB0 Offset: 0x8E56B0 VA: 0x1808E6CB0
	public void Open() { }

	// RVA: 0x8E69E0 Offset: 0x8E53E0 VA: 0x1808E69E0
	public void Close() { }

	// RVA: 0x8E6C50 Offset: 0x8E5650 VA: 0x1808E6C50
	private void Exit(ExitAction action) { }

	// RVA: 0x8E6EB0 Offset: 0x8E58B0 VA: 0x1808E6EB0
	public void .ctor() { }
}
