public class DialogueHandler_VehicleSalesman : ControlledDialogueHandler // TypeDefIndex: 1605
{
	// Fields
	public Jeremy Salesman; // 0xB8
	public Jeremy.DealershipListing selectedVehicle; // 0xC0

	// Methods

	// RVA: 0x6F43D0 Offset: 0x6F2DD0 VA: 0x1806F43D0 Slot: 13
	protected override string ModifyChoiceText(string choiceLabel, string choiceText) { }

	// RVA: 0x6F3E90 Offset: 0x6F2890 VA: 0x1806F3E90 Slot: 9
	public override bool CheckChoice(string choiceLabel, out string invalidReason) { }

	// RVA: 0x6F4040 Offset: 0x6F2A40 VA: 0x1806F4040 Slot: 14
	protected override void ChoiceCallback(string choiceLabel) { }

	// RVA: 0x6F3DC0 Offset: 0x6F27C0 VA: 0x1806F3DC0 Slot: 11
	protected override int CheckBranch(string branchLabel) { }

	// RVA: 0x6F43C0 Offset: 0x6F2DC0 VA: 0x1806F43C0 Slot: 15
	protected override void DialogueCallback(string choiceLabel) { }

	// RVA: 0x6F45E0 Offset: 0x6F2FE0 VA: 0x1806F45E0 Slot: 12
	protected override string ModifyDialogueText(string dialogueLabel, string dialogueText) { }

	// RVA: 0x6E7910 Offset: 0x6E6310 VA: 0x1806E7910
	public void .ctor() { }
}
