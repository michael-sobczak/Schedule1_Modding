public class OvenCookOperation // TypeDefIndex: 3261
{
	// Fields
	[CodegenExclude]
	private StorableItemDefinition _itemDefinition; // 0x10
	[CodegenExclude]
	private StorableItemDefinition _productionDefinition; // 0x18
	[CodegenExclude]
	private CookableModule _cookable; // 0x20
	public string IngredientID; // 0x28
	public EQuality IngredientQuality; // 0x30
	public int IngredientQuantity; // 0x34
	public string ProductID; // 0x38
	public int CookProgress; // 0x40
	[CodegenExclude]
	private int cookDuration; // 0x44

	// Properties
	[CodegenExclude]
	public StorableItemDefinition Ingredient { get; }
	[CodegenExclude]
	public StorableItemDefinition Product { get; }
	[CodegenExclude]
	public CookableModule Cookable { get; }

	// Methods

	// RVA: 0xA30540 Offset: 0xA2EF40 VA: 0x180A30540
	public StorableItemDefinition get_Ingredient() { }

	// RVA: 0xA30650 Offset: 0xA2F050 VA: 0x180A30650
	public StorableItemDefinition get_Product() { }

	// RVA: 0xA30490 Offset: 0xA2EE90 VA: 0x180A30490
	public CookableModule get_Cookable() { }

	// RVA: 0xA30370 Offset: 0xA2ED70 VA: 0x180A30370
	public void .ctor(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID) { }

	// RVA: 0xA30410 Offset: 0xA2EE10 VA: 0x180A30410
	public void .ctor(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID, int progress) { }

	// RVA: 0xA303F0 Offset: 0xA2EDF0 VA: 0x180A303F0
	public void .ctor() { }

	// RVA: 0xA30360 Offset: 0xA2ED60 VA: 0x180A30360
	public void UpdateCookProgress(int change) { }

	// RVA: 0xA300A0 Offset: 0xA2EAA0 VA: 0x180A300A0
	public int GetCookDuration() { }

	// RVA: 0xA30110 Offset: 0xA2EB10 VA: 0x180A30110
	public ItemInstance GetProductItem(int quantity) { }

	// RVA: 0xA302E0 Offset: 0xA2ECE0 VA: 0x180A302E0
	public bool IsReady() { }
}
