public class CashInstance : StorableItemInstance // TypeDefIndex: 3044
{
	// Fields
	public const float MAX_BALANCE = 1E+09;
	[CompilerGenerated]
	private float <Balance>k__BackingField; // 0x38

	// Properties
	public float Balance { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0
	public float get_Balance() { }

	[CompilerGenerated]
	// RVA: 0x4E2CD0 Offset: 0x4E16D0 VA: 0x1804E2CD0
	protected void set_Balance(float value) { }

	// RVA: 0x7CFB30 Offset: 0x7CE530 VA: 0x1807CFB30
	public void .ctor() { }

	// RVA: 0x9944C0 Offset: 0x992EC0 VA: 0x1809944C0
	public void .ctor(ItemDefinition definition, int quantity) { }

	// RVA: 0x994340 Offset: 0x992D40 VA: 0x180994340 Slot: 12
	public override ItemInstance GetCopy(int overrideQuantity = -1) { }

	// RVA: 0x9942C0 Offset: 0x992CC0 VA: 0x1809942C0
	public void ChangeBalance(float amount) { }

	// RVA: 0x994440 Offset: 0x992E40 VA: 0x180994440
	public void SetBalance(float newBalance, bool blockClear = False) { }

	// RVA: 0x9943C0 Offset: 0x992DC0 VA: 0x1809943C0 Slot: 14
	public override ItemData GetItemData() { }

	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0 Slot: 15
	public override float GetMonetaryValue() { }
}
