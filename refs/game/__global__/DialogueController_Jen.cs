public class DialogueController_Jen : DialogueController // TypeDefIndex: 1560
{
	// Fields
	public string BuyKeyText; // 0x80
	public StorableItemDefinition KeyItem; // 0x88
	public DialogueContainer BuyKeyDialogue; // 0x90
	public float MinRelationToBuyKey; // 0x98

	// Methods

	// RVA: 0x6ED490 Offset: 0x6EBE90 VA: 0x1806ED490 Slot: 4
	protected override void Start() { }

	// RVA: 0x6ECE40 Offset: 0x6EB840 VA: 0x1806ECE40
	private bool CanBuyKey(out string invalidReason) { }

	// RVA: 0x6ED2C0 Offset: 0x6EBCC0 VA: 0x1806ED2C0 Slot: 10
	public override string ModifyChoiceText(string choiceLabel, string choiceText) { }

	// RVA: 0x6ED3A0 Offset: 0x6EBDA0 VA: 0x1806ED3A0 Slot: 9
	public override string ModifyDialogueText(string dialogueLabel, string dialogueText) { }

	// RVA: 0x6ECF80 Offset: 0x6EB980 VA: 0x1806ECF80 Slot: 13
	public override bool CheckChoice(string choiceLabel, out string invalidReason) { }

	// RVA: 0x6ED0A0 Offset: 0x6EBAA0 VA: 0x1806ED0A0 Slot: 12
	public override void ChoiceCallback(string choiceLabel) { }

	// RVA: 0x6ED650 Offset: 0x6EC050 VA: 0x1806ED650
	public void .ctor() { }
}
