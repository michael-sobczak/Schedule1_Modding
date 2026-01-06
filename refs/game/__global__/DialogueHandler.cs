public class DialogueHandler : MonoBehaviour // TypeDefIndex: 1595
{
	// Fields
	public const float TimePerChar = 0.2;
	public const float WorldspaceDialogueMinDuration = 1.5;
	public const float WorldspaceDialogueMaxDuration = 5;
	public static DialogueContainer activeDialogue; // 0x0
	public static DialogueNodeData activeDialogueNode; // 0x8
	[CompilerGenerated]
	private bool <IsDialogueInProgress>k__BackingField; // 0x20
	public DialogueDatabase Database; // 0x28
	[CompilerGenerated]
	private List<DialogueModule> <runtimeModules>k__BackingField; // 0x30
	[Header("References")]
	public Transform LookPosition; // 0x38
	public WorldspaceDialogueRenderer WorldspaceRend; // 0x40
	[CompilerGenerated]
	private NPC <NPC>k__BackingField; // 0x48
	public VOEmitter VOEmitter; // 0x50
	[HideInInspector]
	public List<DialogueChoiceData> CurrentChoices; // 0x58
	[Header("Events")]
	public DialogueEvent[] DialogueEvents; // 0x60
	public UnityEvent onConversationStart; // 0x68
	public UnityEvent<string> onDialogueNodeDisplayed; // 0x70
	public UnityEvent<string> onDialogueChoiceChosen; // 0x78
	[SerializeField]
	protected List<DialogueContainer> dialogueContainers; // 0x80
	protected string overrideText; // 0x88
	protected List<NodeLinkData> tempLinks; // 0x90
	protected bool skipNextDialogueBehaviourEnd; // 0x98
	protected List<DialogueChoiceData> finalChoices; // 0xA0
	private bool passChecked; // 0xA8

	// Properties
	public bool IsDialogueInProgress { get; set; }
	public List<DialogueModule> runtimeModules { get; set; }
	public NPC NPC { get; set; }
	protected DialogueCanvas canvas { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsDialogueInProgress() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsDialogueInProgress(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public List<DialogueModule> get_runtimeModules() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	private void set_runtimeModules(List<DialogueModule> value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public NPC get_NPC() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	protected void set_NPC(NPC value) { }

	// RVA: 0x6F4870 Offset: 0x6F3270 VA: 0x1806F4870
	protected DialogueCanvas get_canvas() { }

	// RVA: 0x6F0650 Offset: 0x6EF050 VA: 0x1806F0650 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x6F3B00 Offset: 0x6F2500 VA: 0x1806F3B00 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x6F25E0 Offset: 0x6F0FE0 VA: 0x1806F25E0
	public void InitializeDialogue(DialogueContainer container) { }

	// RVA: 0x6F2640 Offset: 0x6F1040 VA: 0x1806F2640
	public void InitializeDialogue(DialogueContainer dialogueContainer, bool enableDialogueBehaviour = True, string entryNodeLabel = "ENTRY") { }

	// RVA: 0x6F2990 Offset: 0x6F1390 VA: 0x1806F2990
	public void InitializeDialogue(string dialogueContainerName, bool enableDialogueBehaviour = True, string entryNodeLabel = "ENTRY") { }

	// RVA: 0x6F0800 Offset: 0x6EF200 VA: 0x1806F0800 Slot: 6
	public virtual bool CanBeginConversation() { }

	// RVA: 0x6F2B40 Offset: 0x6F1540 VA: 0x1806F2B40
	public void OverrideShownDialogue(string _overrideText) { }

	// RVA: 0x6F3D10 Offset: 0x6F2710 VA: 0x1806F3D10
	public void StopOverride() { }

	// RVA: 0x6F1120 Offset: 0x6EFB20 VA: 0x1806F1120 Slot: 7
	public virtual void EndDialogue() { }

	// RVA: 0x6F3AF0 Offset: 0x6F24F0 VA: 0x1806F3AF0
	public void SkipNextDialogueBehaviourEnd() { }

	// RVA: 0x499060 Offset: 0x497A60 VA: 0x180499060 Slot: 8
	protected virtual DialogueNodeData FinalizeDialogueNode(DialogueNodeData data) { }

	// RVA: 0x6F34F0 Offset: 0x6F1EF0 VA: 0x1806F34F0
	public void ShowNode(DialogueNodeData node) { }

	// RVA: 0x6F2290 Offset: 0x6F0C90 VA: 0x1806F2290
	private void EvaluateBranch(BranchNodeData node) { }

	// RVA: 0x6F0AB0 Offset: 0x6EF4B0 VA: 0x1806F0AB0
	public void ChoiceSelected(int choiceIndex) { }

	// RVA: 0x6F0CF0 Offset: 0x6EF6F0 VA: 0x1806F0CF0
	public void ContinueSubmitted() { }

	// RVA: 0x6F09A0 Offset: 0x6EF3A0 VA: 0x1806F09A0 Slot: 9
	public virtual bool CheckChoice(string choiceLabel, out string invalidReason) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 10
	public virtual bool ShouldChoiceBeShown(string choiceLabel) { }

	// RVA: 0x6F0870 Offset: 0x6EF270 VA: 0x1806F0870 Slot: 11
	protected virtual int CheckBranch(string branchLabel) { }

	// RVA: 0x6EE2F0 Offset: 0x6ECCF0 VA: 0x1806EE2F0 Slot: 12
	protected virtual string ModifyDialogueText(string dialogueLabel, string dialogueText) { }

	// RVA: 0x6EE2F0 Offset: 0x6ECCF0 VA: 0x1806EE2F0 Slot: 13
	protected virtual string ModifyChoiceText(string choiceLabel, string choiceText) { }

	// RVA: 0x6F0A50 Offset: 0x6EF450 VA: 0x1806F0A50 Slot: 14
	protected virtual void ChoiceCallback(string choiceLabel) { }

	// RVA: 0x6F0FA0 Offset: 0x6EF9A0 VA: 0x1806F0FA0 Slot: 15
	protected virtual void DialogueCallback(string dialogueLabel) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 16
	protected virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices) { }

	// RVA: 0x6F0E70 Offset: 0x6EF870 VA: 0x1806F0E70
	protected void CreateTempLink(string baseNodeGUID, string baseOptionGUID, string targetNodeGUID) { }

	// RVA: 0x6F24A0 Offset: 0x6F0EA0 VA: 0x1806F24A0
	private NodeLinkData GetLink(string baseChoiceOrOptionGUID) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 17
	public virtual void Hovered() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 18
	public virtual void Interacted() { }

	// RVA: 0x6F2B90 Offset: 0x6F1590 VA: 0x1806F2B90 Slot: 19
	public virtual void PlayReaction_Local(string key) { }

	// RVA: 0x6F2BC0 Offset: 0x6F15C0 VA: 0x1806F2BC0 Slot: 20
	public virtual void PlayReaction_Networked(string key) { }

	// RVA: 0x6F2BF0 Offset: 0x6F15F0 VA: 0x1806F2BF0 Slot: 21
	public virtual void PlayReaction(string key, float duration, bool network) { }

	// RVA: 0x6F25C0 Offset: 0x6F0FC0 VA: 0x1806F25C0 Slot: 22
	public virtual void HideWorldspaceDialogue() { }

	// RVA: 0x6F3A90 Offset: 0x6F2490 VA: 0x1806F3A90 Slot: 23
	public virtual void ShowWorldspaceDialogue(string text, float duration) { }

	// RVA: 0x6F3A70 Offset: 0x6F2470 VA: 0x1806F3A70 Slot: 24
	public virtual void ShowWorldspaceDialogue_5s(string text) { }

	// RVA: 0x6F46B0 Offset: 0x6F30B0 VA: 0x1806F46B0
	public void .ctor() { }
}
