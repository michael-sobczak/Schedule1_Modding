public class DialogueContainer : ScriptableObject // TypeDefIndex: 1619
{
	// Fields
	[CompilerGenerated]
	private bool <allowExit>k__BackingField; // 0x18
	public List<NodeLinkData> NodeLinks; // 0x20
	public List<DialogueNodeData> DialogueNodeData; // 0x28
	public List<BranchNodeData> BranchNodeData; // 0x30

	// Properties
	public bool allowExit { get; set; }
	public bool AllowExit { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	public bool get_allowExit() { }

	[CompilerGenerated]
	// RVA: 0x698000 Offset: 0x696A00 VA: 0x180698000
	private void set_allowExit(bool value) { }

	// RVA: 0x701D30 Offset: 0x700730 VA: 0x180701D30
	public bool get_AllowExit() { }

	// RVA: 0x701A60 Offset: 0x700460 VA: 0x180701A60
	public DialogueNodeData GetDialogueNodeByLabel(string dialogueNodeLabel) { }

	// RVA: 0x7018A0 Offset: 0x7002A0 VA: 0x1807018A0
	public BranchNodeData GetBranchNodeByLabel(string branchLabel) { }

	// RVA: 0x701980 Offset: 0x700380 VA: 0x180701980
	public DialogueNodeData GetDialogueNodeByGUID(string dialogueNodeGUID) { }

	// RVA: 0x7017C0 Offset: 0x7001C0 VA: 0x1807017C0
	public BranchNodeData GetBranchNodeByGUID(string branchGUID) { }

	// RVA: 0x701B40 Offset: 0x700540 VA: 0x180701B40
	public NodeLinkData GetLink(string baseChoiceOrOptionGUID) { }

	// RVA: 0x698000 Offset: 0x696A00 VA: 0x180698000
	public void SetAllowExit(bool allowed) { }

	// RVA: 0x701C20 Offset: 0x700620 VA: 0x180701C20
	public void .ctor() { }
}
