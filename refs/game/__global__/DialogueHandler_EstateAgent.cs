public class DialogueHandler_EstateAgent : ControlledDialogueHandler // TypeDefIndex: 1601
{
	// Fields
	private Property selectedProperty; // 0xB8
	private Business selectedBusiness; // 0xC0

	// Methods

	// RVA: 0x6F1360 Offset: 0x6EFD60 VA: 0x1806F1360 Slot: 9
	public override bool CheckChoice(string choiceLabel, out string invalidReason) { }

	// RVA: 0x6F2020 Offset: 0x6F0A20 VA: 0x1806F2020 Slot: 10
	public override bool ShouldChoiceBeShown(string choiceLabel) { }

	// RVA: 0x6F16A0 Offset: 0x6F00A0 VA: 0x1806F16A0 Slot: 14
	protected override void ChoiceCallback(string choiceLabel) { }

	// RVA: 0x6F1900 Offset: 0x6F0300 VA: 0x1806F1900 Slot: 15
	protected override void DialogueCallback(string choiceLabel) { }

	// RVA: 0x6F1ED0 Offset: 0x6F08D0 VA: 0x1806F1ED0 Slot: 12
	protected override string ModifyDialogueText(string dialogueLabel, string dialogueText) { }

	// RVA: 0x6F1B60 Offset: 0x6F0560 VA: 0x1806F1B60 Slot: 13
	protected override string ModifyChoiceText(string choiceLabel, string choiceText) { }

	// RVA: 0x6E7910 Offset: 0x6E6310 VA: 0x1806E7910
	public void .ctor() { }
}
