public class NPCSummonMenu : Singleton<NPCSummonMenu> // TypeDefIndex: 2648
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x28
	[Header("References")]
	public Canvas Canvas; // 0x30
	public RectTransform Container; // 0x38
	public RectTransform EntryContainer; // 0x40
	public RectTransform[] Entries; // 0x48
	private Action<NPC> callback; // 0x50

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	private void set_IsOpen(bool value) { }

	// RVA: 0x8F7A80 Offset: 0x8F6480 VA: 0x1808F7A80 Slot: 4
	protected override void Start() { }

	// RVA: 0x8F73F0 Offset: 0x8F5DF0 VA: 0x1808F73F0
	private void Exit(ExitAction exit) { }

	// RVA: 0x8F7480 Offset: 0x8F5E80 VA: 0x1808F7480
	public void Open(List<NPC> npcs, Action<NPC> _callback) { }

	// RVA: 0x8F71A0 Offset: 0x8F5BA0 VA: 0x1808F71A0
	public void Close() { }

	// RVA: 0x8F7440 Offset: 0x8F5E40 VA: 0x1808F7440
	public void NPCSelected(NPC npc) { }

	// RVA: 0x8F7B70 Offset: 0x8F6570 VA: 0x1808F7B70
	public void .ctor() { }
}
