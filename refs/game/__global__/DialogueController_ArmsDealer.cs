public class DialogueController_ArmsDealer : DialogueController // TypeDefIndex: 1555
{
	// Fields
	public List<DialogueController_ArmsDealer.WeaponOption> MeleeWeapons; // 0x80
	public List<DialogueController_ArmsDealer.WeaponOption> RangedWeapons; // 0x88
	public List<DialogueController_ArmsDealer.WeaponOption> Ammo; // 0x90
	public ItemDefinition RDX; // 0x98
	public ItemDefinition Bomb; // 0xA0
	private List<DialogueController_ArmsDealer.WeaponOption> allWeapons; // 0xA8
	private DialogueController_ArmsDealer.WeaponOption chosenWeapon; // 0xB0
	private Quest_DefeatCartel questDefeatCartel; // 0xB8

	// Methods

	// RVA: 0x6E8270 Offset: 0x6E6C70 VA: 0x1806E8270
	private void Awake() { }

	// RVA: 0x6E9070 Offset: 0x6E7A70 VA: 0x1806E9070 Slot: 4
	protected override void Start() { }

	// RVA: 0x6E8710 Offset: 0x6E7110 VA: 0x1806E8710 Slot: 12
	public override void ChoiceCallback(string choiceLabel) { }

	// RVA: 0x6E8C40 Offset: 0x6E7640 VA: 0x1806E8C40 Slot: 11
	public override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices) { }

	// RVA: 0x6E8980 Offset: 0x6E7380 VA: 0x1806E8980
	private List<DialogueChoiceData> GetWeaponChoices(List<DialogueController_ArmsDealer.WeaponOption> options) { }

	// RVA: 0x6E8360 Offset: 0x6E6D60 VA: 0x1806E8360 Slot: 13
	public override bool CheckChoice(string choiceLabel, out string invalidReason) { }

	// RVA: 0x6E8DA0 Offset: 0x6E77A0 VA: 0x1806E8DA0 Slot: 9
	public override string ModifyDialogueText(string dialogueLabel, string dialogueText) { }

	// RVA: 0x6E9320 Offset: 0x6E7D20 VA: 0x1806E9320
	private void TradeRDXForBomb() { }

	// RVA: 0x6E9440 Offset: 0x6E7E40 VA: 0x1806E9440
	public void .ctor() { }
}
