public class WaterContainerInstance : StorableItemInstance // TypeDefIndex: 3092
{
	// Fields
	[CompilerGenerated]
	private float <CurrentFillAmount>k__BackingField; // 0x38

	// Properties
	public float CurrentFillAmount { get; set; }
	public float NormalizedFillAmount { get; }
	public WaterContainerDefinition WaterContainerDefinition { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0
	public float get_CurrentFillAmount() { }

	[CompilerGenerated]
	// RVA: 0x4E2CD0 Offset: 0x4E16D0 VA: 0x1804E2CD0
	private void set_CurrentFillAmount(float value) { }

	// RVA: 0x9A79C0 Offset: 0x9A63C0 VA: 0x1809A79C0
	public float get_NormalizedFillAmount() { }

	// RVA: 0x9A7A00 Offset: 0x9A6400 VA: 0x1809A7A00
	public WaterContainerDefinition get_WaterContainerDefinition() { }

	// RVA: 0x7CFB30 Offset: 0x7CE530 VA: 0x1807CFB30
	public void .ctor() { }

	// RVA: 0x9A7990 Offset: 0x9A6390 VA: 0x1809A7990
	public void .ctor(ItemDefinition definition, int quantity, float fillAmount) { }

	// RVA: 0x9A7810 Offset: 0x9A6210 VA: 0x1809A7810 Slot: 12
	public override ItemInstance GetCopy(int overrideQuantity = -1) { }

	// RVA: 0x9A7790 Offset: 0x9A6190 VA: 0x1809A7790
	public void ChangeFillAmount(float change) { }

	// RVA: 0x9A76F0 Offset: 0x9A60F0 VA: 0x1809A76F0
	public void ChangeFillAmountByPercentage(float percentage) { }

	// RVA: 0x9A7920 Offset: 0x9A6320 VA: 0x1809A7920
	public void SetFillAmount(float amount) { }

	// RVA: 0x9A78A0 Offset: 0x9A62A0 VA: 0x1809A78A0 Slot: 14
	public override ItemData GetItemData() { }
}
