public class DialogueController_Fixer : DialogueController // TypeDefIndex: 1559
{
	// Fields
	private EEmployeeType selectedEmployeeType; // 0x80
	private Property selectedProperty; // 0x88
	private bool lastConfirmationWasInitial; // 0x90

	// Methods

	// RVA: 0x6EB8D0 Offset: 0x6EA2D0 VA: 0x1806EB8D0 Slot: 12
	public override void ChoiceCallback(string choiceLabel) { }

	// RVA: 0x6EBF80 Offset: 0x6EA980 VA: 0x1806EBF80 Slot: 11
	public override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices) { }

	// RVA: 0x6EB450 Offset: 0x6E9E50 VA: 0x1806EB450 Slot: 13
	public override bool CheckChoice(string choiceLabel, out string invalidReason) { }

	// RVA: 0x6EC280 Offset: 0x6EAC80 VA: 0x1806EC280 Slot: 9
	public override string ModifyDialogueText(string dialogueLabel, string dialogueText) { }

	// RVA: 0x6EBF00 Offset: 0x6EA900 VA: 0x1806EBF00 Slot: 14
	public override bool DecideBranch(string branchLabel, out int index) { }

	// RVA: 0x6EBC20 Offset: 0x6EA620 VA: 0x1806EBC20
	private void Confirm() { }

	// RVA: 0x6EC450 Offset: 0x6EAE50 VA: 0x1806EC450
	public void .ctor() { }
}
