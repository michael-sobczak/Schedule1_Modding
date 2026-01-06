public class DialogueController_SkateboardSeller : DialogueController // TypeDefIndex: 1568
{
	// Fields
	public List<DialogueController_SkateboardSeller.Option> Options; // 0x80
	private DialogueController_SkateboardSeller.Option chosenWeapon; // 0x88
	public UnityEvent onPurchase; // 0x90

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void Awake() { }

	// RVA: 0x6EF0B0 Offset: 0x6EDAB0 VA: 0x1806EF0B0 Slot: 12
	public override void ChoiceCallback(string choiceLabel) { }

	// RVA: 0x6EF6E0 Offset: 0x6EE0E0 VA: 0x1806EF6E0 Slot: 11
	public override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices) { }

	// RVA: 0x6EF440 Offset: 0x6EDE40 VA: 0x1806EF440
	private List<DialogueChoiceData> GetChoices(List<DialogueController_SkateboardSeller.Option> options) { }

	// RVA: 0x6EEE80 Offset: 0x6ED880 VA: 0x1806EEE80 Slot: 13
	public override bool CheckChoice(string choiceLabel, out string invalidReason) { }

	// RVA: 0x6EF7E0 Offset: 0x6EE1E0 VA: 0x1806EF7E0 Slot: 9
	public override string ModifyDialogueText(string dialogueLabel, string dialogueText) { }

	// RVA: 0x6EF910 Offset: 0x6EE310 VA: 0x1806EF910
	public void .ctor() { }
}
