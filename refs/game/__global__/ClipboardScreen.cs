public class ClipboardScreen : MonoBehaviour // TypeDefIndex: 2864
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[Header("References")]
	public RectTransform Container; // 0x28
	[Header("Settings")]
	public float ClosedOffset; // 0x30
	public bool OpenOnStart; // 0x34
	public bool UseExitListener; // 0x35
	public int ExitActionPriority; // 0x38
	private Coroutine lerpRoutine; // 0x40

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_IsOpen(bool value) { }

	// RVA: 0x93FEC0 Offset: 0x93E8C0 VA: 0x18093FEC0 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x93FC50 Offset: 0x93E650 VA: 0x18093FC50
	private void Exit(ExitAction exitAction) { }

	// RVA: 0x93FE70 Offset: 0x93E870 VA: 0x18093FE70 Slot: 5
	public virtual void Open() { }

	// RVA: 0x93FBD0 Offset: 0x93E5D0 VA: 0x18093FBD0 Slot: 6
	public virtual void Close() { }

	// RVA: 0x93FCB0 Offset: 0x93E6B0 VA: 0x18093FCB0
	private void Lerp(bool open, Action callback) { }

	// RVA: 0x940040 Offset: 0x93EA40 VA: 0x180940040
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x940010 Offset: 0x93EA10 VA: 0x180940010
	private void <Close>b__13_0() { }
}
