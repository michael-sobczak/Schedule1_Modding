public class ControlledDialogueHandler : DialogueHandler // TypeDefIndex: 1571
{
	// Fields
	private DialogueController controller; // 0xB0

	// Methods

	// RVA: 0x6E7520 Offset: 0x6E5F20 VA: 0x1806E7520 Slot: 4
	protected override void Awake() { }

	// RVA: 0x6E78E0 Offset: 0x6E62E0 VA: 0x1806E78E0 Slot: 12
	protected override string ModifyDialogueText(string dialogueLabel, string dialogueText) { }

	// RVA: 0x6E78B0 Offset: 0x6E62B0 VA: 0x1806E78B0 Slot: 13
	protected override string ModifyChoiceText(string choiceLabel, string choiceText) { }

	// RVA: 0x6E7880 Offset: 0x6E6280 VA: 0x1806E7880 Slot: 16
	protected override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices) { }

	// RVA: 0x6E7800 Offset: 0x6E6200 VA: 0x1806E7800 Slot: 14
	protected override void ChoiceCallback(string choiceLabel) { }

	// RVA: 0x6E7580 Offset: 0x6E5F80 VA: 0x1806E7580 Slot: 11
	protected override int CheckBranch(string branchLabel) { }

	// RVA: 0x6E7720 Offset: 0x6E6120 VA: 0x1806E7720 Slot: 9
	public override bool CheckChoice(string choiceLabel, out string invalidReason) { }

	// RVA: 0x6E7910 Offset: 0x6E6310 VA: 0x1806E7910
	public void .ctor() { }
}
