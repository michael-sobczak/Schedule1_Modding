public class Billy : NPC // TypeDefIndex: 1624
{
	// Fields
	public const int REQUESTED_PRODUCT_AMOUNT = 20;
	public const string REQUESTED_PRODUCT_ID = "cocaine";
	[Header("References")]
	public Contract TradeContract; // 0x2F0
	public ItemDefinition RDXDefinition; // 0x2F8
	private Customer customerComp; // 0x300
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.BillyAssembly-CSharp.dll_Excuted; // 0x308
	private bool NetworkInitialize__LateScheduleOne.NPCs.BillyAssembly-CSharp.dll_Excuted; // 0x309

	// Methods

	// RVA: 0x700FA0 Offset: 0x6FF9A0 VA: 0x180700FA0 Slot: 65
	public override void Awake() { }

	// RVA: 0x701470 Offset: 0x6FFE70 VA: 0x180701470
	public void OpenRDXTradeHandover() { }

	// RVA: 0x701200 Offset: 0x6FFC00 VA: 0x180701200
	private void HandoverOutcome(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> givenItems, float payment) { }

	// RVA: 0x700FF0 Offset: 0x6FF9F0 VA: 0x180700FF0
	private float GetSucccessChance(List<ItemInstance> items, float price) { }

	// RVA: 0x701620 Offset: 0x700020 VA: 0x180701620
	public void .ctor() { }

	// RVA: 0x701450 Offset: 0x6FFE50 VA: 0x180701450 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7013F0 Offset: 0x6FFDF0 VA: 0x1807013F0 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x700C80 Offset: 0x6FF680 VA: 0x180700C80 Slot: 111
	protected override void Awake_UserLogic_ScheduleOne.NPCs.Billy_Assembly-CSharp.dll() { }
}
