public class StationRecipe : ScriptableObject // TypeDefIndex: 2444
{
	// Fields
	[HideInInspector]
	public bool IsDiscovered; // 0x18
	public string RecipeTitle; // 0x20
	public bool Unlocked; // 0x28
	public List<StationRecipe.IngredientQuantity> Ingredients; // 0x30
	public StationRecipe.ItemQuantity Product; // 0x38
	public Color FinalLiquidColor; // 0x40
	[Tooltip("The time it takes to cook this recipe in minutes")]
	public int CookTime_Mins; // 0x50
	[Range(0, 500)]
	[Tooltip("The temperature at which this recipe should be cooked")]
	public float CookTemperature; // 0x54
	[Range(0, 100)]
	public float CookTemperatureTolerance; // 0x58
	public StationRecipe.EQualityCalculationMethod QualityCalculationMethod; // 0x5C

	// Properties
	public float CookTemperatureLowerBound { get; }
	public float CookTemperatureUpperBound { get; }
	public string RecipeID { get; }

	// Methods

	// RVA: 0x8A9960 Offset: 0x8A8360 VA: 0x1808A9960
	public float get_CookTemperatureLowerBound() { }

	// RVA: 0x8A9970 Offset: 0x8A8370 VA: 0x1808A9970
	public float get_CookTemperatureUpperBound() { }

	// RVA: 0x8A9980 Offset: 0x8A8380 VA: 0x1808A9980
	public string get_RecipeID() { }

	// RVA: 0x8A9600 Offset: 0x8A8000 VA: 0x1808A9600
	public StorableItemInstance GetProductInstance(List<ItemInstance> ingredients) { }

	// RVA: 0x8A9780 Offset: 0x8A8180 VA: 0x1808A9780
	public StorableItemInstance GetProductInstance(EQuality quality) { }

	// RVA: 0x8A92B0 Offset: 0x8A7CB0 VA: 0x1808A92B0
	public bool DoIngredientsSuffice(List<ItemInstance> ingredients) { }

	// RVA: 0x8A90A0 Offset: 0x8A7AA0 VA: 0x1808A90A0
	public EQuality CalculateQuality(List<ItemInstance> ingredients) { }

	// RVA: 0x8A98C0 Offset: 0x8A82C0 VA: 0x1808A98C0
	public void .ctor() { }
}
