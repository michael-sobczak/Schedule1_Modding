public class ChemistryCookOperation // TypeDefIndex: 3239
{
	// Fields
	[CodegenExclude]
	private StationRecipe recipe; // 0x10
	public string RecipeID; // 0x18
	public EQuality ProductQuality; // 0x20
	public Color StartLiquidColor; // 0x24
	public float LiquidLevel; // 0x34
	public int CurrentTime; // 0x38

	// Properties
	[CodegenExclude]
	public StationRecipe Recipe { get; }

	// Methods

	// RVA: 0xA02C20 Offset: 0xA01620 VA: 0x180A02C20
	public StationRecipe get_Recipe() { }

	// RVA: 0xA02BA0 Offset: 0xA015A0 VA: 0x180A02BA0
	public void .ctor(StationRecipe recipe, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime = 0) { }

	// RVA: 0xA02B30 Offset: 0xA01530 VA: 0x180A02B30
	public void .ctor(string recipeID, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime = 0) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0xA02AD0 Offset: 0xA014D0 VA: 0x180A02AD0
	public void Progress(int mins) { }

	[CompilerGenerated]
	// RVA: 0xA02AF0 Offset: 0xA014F0 VA: 0x180A02AF0
	private bool <get_Recipe>b__2_0(StationRecipe r) { }
}
