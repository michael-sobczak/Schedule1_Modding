public class DocumentViewer : Singleton<DocumentViewer> // TypeDefIndex: 2595
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x28
	[Header("References")]
	public Canvas Canvas; // 0x30
	public RectTransform[] Documents; // 0x38
	public UnityEvent onOpen; // 0x40

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_IsOpen(bool value) { }

	// RVA: 0x8E3210 Offset: 0x8E1C10 VA: 0x1808E3210 Slot: 4
	protected override void Start() { }

	// RVA: 0x8E2D80 Offset: 0x8E1780 VA: 0x1808E2D80
	private void Exit(ExitAction action) { }

	// RVA: 0x8E2DD0 Offset: 0x8E17D0 VA: 0x1808E2DD0
	public void Open(string documentName) { }

	// RVA: 0x8E2A40 Offset: 0x8E1440 VA: 0x1808E2A40
	public void Close() { }

	// RVA: 0x8E32E0 Offset: 0x8E1CE0 VA: 0x1808E32E0
	public void .ctor() { }
}
