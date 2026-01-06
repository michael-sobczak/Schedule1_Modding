public class ProductManagerData : SaveData // TypeDefIndex: 1099
{
	// Fields
	public string[] DiscoveredProducts; // 0x28
	public string[] ListedProducts; // 0x30
	public NewMixOperation ActiveMixOperation; // 0x38
	public bool IsMixComplete; // 0x40
	public MixRecipeData[] MixRecipes; // 0x48
	public StringIntPair[] ProductPrices; // 0x50
	public string[] FavouritedProducts; // 0x58
	public WeedProductData[] CreatedWeed; // 0x60
	public MethProductData[] CreatedMeth; // 0x68
	public CocaineProductData[] CreatedCocaine; // 0x70
	public ShroomProductData[] CreatedShrooms; // 0x78
	public ContractReceipt[] ContractReceipts; // 0x80

	// Methods

	// RVA: 0x5E9CF0 Offset: 0x5E86F0 VA: 0x1805E9CF0
	public void .ctor(string[] discoveredProducts, string[] listedProducts, NewMixOperation activeOperation, bool isMixComplete, MixRecipeData[] mixRecipes, StringIntPair[] productPrices, string[] favouritedProducts, WeedProductData[] createdWeed, MethProductData[] createdMeth, CocaineProductData[] createdCocaine, ShroomProductData[] createdShrooms, ContractReceipt[] receipts) { }
}
