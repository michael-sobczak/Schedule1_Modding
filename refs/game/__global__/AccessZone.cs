public class AccessZone : MonoBehaviour // TypeDefIndex: 3324
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[Header("Settings")]
	public bool AllowExitWhenClosed; // 0x21
	public bool AutoCloseDoor; // 0x22
	[Header("References")]
	public DoorController[] Doors; // 0x28
	public ToggleableLight[] Lights; // 0x30
	public UnityEvent onOpen; // 0x38
	public UnityEvent onClose; // 0x40

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_IsOpen(bool value) { }

	// RVA: 0xA486C0 Offset: 0xA470C0 VA: 0x180A486C0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0xA486E0 Offset: 0xA470E0 VA: 0x180A486E0 Slot: 5
	public virtual void SetIsOpen(bool open) { }

	// RVA: 0xA48930 Offset: 0xA47330 VA: 0x180A48930
	public void .ctor() { }
}
