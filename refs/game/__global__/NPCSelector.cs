public class NPCSelector : MonoBehaviour // TypeDefIndex: 2901
{
	// Fields
	public const float SELECTION_RANGE = 5;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[Header("Settings")]
	public LayerMask DetectionMask; // 0x24
	public Color HoverOutlineColor; // 0x28
	private Type TypeRequirement; // 0x38
	private Action<NPC> callback; // 0x40
	private NPC hoveredNPC; // 0x48
	private NPC highlightedNPC; // 0x50

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_IsOpen(bool value) { }

	// RVA: 0x966B10 Offset: 0x965510 VA: 0x180966B10
	private void Start() { }

	// RVA: 0x966900 Offset: 0x965300 VA: 0x180966900 Slot: 4
	public virtual void Open(string selectionTitle, Type typeRequirement, Action<NPC> _callback) { }

	// RVA: 0x966340 Offset: 0x964D40 VA: 0x180966340 Slot: 5
	public virtual void Close(bool returnToClipboard) { }

	// RVA: 0x966C60 Offset: 0x965660 VA: 0x180966C60
	private void Update() { }

	// RVA: 0x9666E0 Offset: 0x9650E0 VA: 0x1809666E0
	private NPC GetHoveredNPC() { }

	// RVA: 0x9667E0 Offset: 0x9651E0 VA: 0x1809667E0
	public bool IsNPCTypeValid(NPC npc) { }

	// RVA: 0x9668A0 Offset: 0x9652A0 VA: 0x1809668A0
	public void NPCClicked(NPC npc) { }

	// RVA: 0x966320 Offset: 0x964D20 VA: 0x180966320
	private void ClipboardClosed() { }

	// RVA: 0x966680 Offset: 0x965080 VA: 0x180966680
	private void Exit(ExitAction exitAction) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
