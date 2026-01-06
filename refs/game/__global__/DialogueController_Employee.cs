public class DialogueController_Employee : DialogueController // TypeDefIndex: 1580
{
	// Fields
	private Property selectedProperty; // 0x80

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void Awake() { }

	// RVA: 0x6EA880 Offset: 0x6E9280 VA: 0x1806EA880 Slot: 12
	public override void ChoiceCallback(string choiceLabel) { }

	// RVA: 0x6EB0E0 Offset: 0x6E9AE0 VA: 0x1806EB0E0 Slot: 11
	public override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices) { }

	// RVA: 0x6EAAA0 Offset: 0x6E94A0 VA: 0x1806EAAA0
	private List<DialogueChoiceData> GetChoices() { }

	// RVA: 0x6EB050 Offset: 0x6E9A50 VA: 0x1806EB050
	private Property GetPropertyByCode(string code) { }

	// RVA: 0x6EA790 Offset: 0x6E9190 VA: 0x1806EA790 Slot: 13
	public override bool CheckChoice(string choiceLabel, out string invalidReason) { }

	// RVA: 0x6EB1E0 Offset: 0x6E9BE0 VA: 0x1806EB1E0 Slot: 9
	public override string ModifyDialogueText(string dialogueLabel, string dialogueText) { }

	// RVA: 0x6EB400 Offset: 0x6E9E00 VA: 0x1806EB400
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x6EB2D0 Offset: 0x6E9CD0 VA: 0x1806EB2D0
	private int <GetChoices>b__4_0(DialogueChoiceData x, DialogueChoiceData y) { }
}
