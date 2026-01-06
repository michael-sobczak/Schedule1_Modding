public class DialogueController_Ming : DialogueController // TypeDefIndex: 1562
{
	// Fields
	public Property Property; // 0x80
	public float Price; // 0x88
	public DialogueContainer BuyDialogue; // 0x90
	public string BuyText; // 0x98
	public string RemindText; // 0xA0
	public DialogueContainer RemindLocationDialogue; // 0xA8
	public QuestEntry[] PurchaseRoomQuests; // 0xB0
	public UnityEvent onPurchase; // 0xB8

	// Methods

	// RVA: 0x6EDCE0 Offset: 0x6EC6E0 VA: 0x1806EDCE0 Slot: 4
	protected override void Start() { }

	// RVA: 0x6ED6D0 Offset: 0x6EC0D0 VA: 0x1806ED6D0
	private bool CanBuyRoom(bool enabled) { }

	// RVA: 0x6EDB20 Offset: 0x6EC520 VA: 0x1806EDB20 Slot: 10
	public override string ModifyChoiceText(string choiceLabel, string choiceText) { }

	// RVA: 0x6EDC00 Offset: 0x6EC600 VA: 0x1806EDC00 Slot: 9
	public override string ModifyDialogueText(string dialogueLabel, string dialogueText) { }

	// RVA: 0x6ED860 Offset: 0x6EC260 VA: 0x1806ED860 Slot: 13
	public override bool CheckChoice(string choiceLabel, out string invalidReason) { }

	// RVA: 0x6ED980 Offset: 0x6EC380 VA: 0x1806ED980 Slot: 12
	public override void ChoiceCallback(string choiceLabel) { }

	// RVA: 0x6EDFF0 Offset: 0x6EC9F0 VA: 0x1806EDFF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6EDFC0 Offset: 0x6EC9C0 VA: 0x1806EDFC0
	private bool <Start>b__8_0(bool enabled) { }
}
