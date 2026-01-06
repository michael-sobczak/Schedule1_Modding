public class DialogueController : MonoBehaviour // TypeDefIndex: 1578
{
	// Fields
	public static float GREETING_COOLDOWN; // 0x0
	[Header("References")]
	public InteractableObject IntObj; // 0x20
	public DialogueContainer GenericDialogue; // 0x28
	[Header("Settings")]
	public bool DialogueEnabled; // 0x30
	public bool UseDialogueBehaviour; // 0x31
	public List<DialogueController.DialogueChoice> Choices; // 0x38
	public List<DialogueController.GreetingOverride> GreetingOverrides; // 0x40
	public DialogueContainer OverrideContainer; // 0x48
	protected NPC npc; // 0x50
	protected DialogueHandler handler; // 0x58
	private float lastGreetingTime; // 0x60
	private List<DialogueController.DialogueChoice> shownChoices; // 0x68
	private bool dialogueQueued; // 0x70
	private string cachedGreeting; // 0x78

	// Methods

	// RVA: 0x6EF9F0 Offset: 0x6EE3F0 VA: 0x1806EF9F0 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x6ECA90 Offset: 0x6EB490 VA: 0x1806ECA90
	private void Hovered() { }

	// RVA: 0x6EF9B0 Offset: 0x6EE3B0 VA: 0x1806EF9B0
	public void StartGenericDialogue(bool allowExit = True) { }

	// RVA: 0x6ECC20 Offset: 0x6EB620 VA: 0x1806ECC20
	private void Interacted() { }

	// RVA: 0x6EFF00 Offset: 0x6EE900 VA: 0x1806EFF00
	private void Unqueue() { }

	// RVA: 0x6EC730 Offset: 0x6EB130 VA: 0x1806EC730
	private string GetActiveGreeting(out bool playVO, out EVOLineType voLineType) { }

	// RVA: 0x6EC4A0 Offset: 0x6EAEA0 VA: 0x1806EC4A0
	private List<DialogueController.DialogueChoice> GetActiveChoices() { }

	// RVA: 0x6EC920 Offset: 0x6EB320 VA: 0x1806EC920 Slot: 5
	protected virtual bool GetCustomGreeting(out string greeting, out bool playVO, out EVOLineType voLineType) { }

	// RVA: 0x6E80D0 Offset: 0x6E6AD0 VA: 0x1806E80D0 Slot: 6
	public virtual int AddDialogueChoice(DialogueController.DialogueChoice data, int priority = 0) { }

	// RVA: 0x6E81B0 Offset: 0x6E6BB0 VA: 0x1806E81B0 Slot: 7
	public virtual int AddGreetingOverride(DialogueController.GreetingOverride data) { }

	// RVA: 0x6E9820 Offset: 0x6E8220 VA: 0x1806E9820 Slot: 8
	public virtual bool CanStartDialogue() { }

	// RVA: 0x6EE300 Offset: 0x6ECD00 VA: 0x1806EE300 Slot: 9
	public virtual string ModifyDialogueText(string dialogueLabel, string dialogueText) { }

	// RVA: 0x6EE2F0 Offset: 0x6ECCF0 VA: 0x1806EE2F0 Slot: 10
	public virtual string ModifyChoiceText(string choiceLabel, string choiceText) { }

	// RVA: 0x6EE0A0 Offset: 0x6ECAA0 VA: 0x1806EE0A0 Slot: 11
	public virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices) { }

	// RVA: 0x6E9C60 Offset: 0x6E8660 VA: 0x1806E9C60 Slot: 12
	public virtual void ChoiceCallback(string choiceLabel) { }

	// RVA: 0x6E9AB0 Offset: 0x6E84B0 VA: 0x1806E9AB0 Slot: 13
	public virtual bool CheckChoice(string choiceLabel, out string invalidReason) { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void SetOverrideContainer(DialogueContainer container) { }

	// RVA: 0x6E9E30 Offset: 0x6E8830 VA: 0x1806E9E30
	public void ClearOverrideContainer() { }

	// RVA: 0x6EA780 Offset: 0x6E9180 VA: 0x1806EA780 Slot: 14
	public virtual bool DecideBranch(string branchLabel, out int index) { }

	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	public void SetDialogueEnabled(bool enabled) { }

	// RVA: 0x6EFF50 Offset: 0x6EE950 VA: 0x1806EFF50
	public void .ctor() { }

	// RVA: 0x6EFF10 Offset: 0x6EE910 VA: 0x1806EFF10
	private static void .cctor() { }
}
