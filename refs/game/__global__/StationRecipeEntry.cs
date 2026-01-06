public class StationRecipeEntry : MonoBehaviour // TypeDefIndex: 2743
{
	// Fields
	public static Color ValidColor; // 0x0
	public static Color InvalidColor; // 0x10
	public Button Button; // 0x20
	public Image Icon; // 0x28
	public TextMeshProUGUI TitleLabel; // 0x30
	public TextMeshProUGUI CookingTimeLabel; // 0x38
	public RectTransform[] IngredientRects; // 0x40
	private TextMeshProUGUI[] IngredientQuantities; // 0x48
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; // 0x50
	[CompilerGenerated]
	private StationRecipe <Recipe>k__BackingField; // 0x58

	// Properties
	public bool IsValid { get; set; }
	public StationRecipe Recipe { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x49CCF0 Offset: 0x49B6F0 VA: 0x18049CCF0
	private void set_IsValid(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public StationRecipe get_Recipe() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	private void set_Recipe(StationRecipe value) { }

	// RVA: 0x917B90 Offset: 0x916590 VA: 0x180917B90
	public void AssignRecipe(StationRecipe recipe) { }

	// RVA: 0x918670 Offset: 0x917070 VA: 0x180918670
	public void RefreshValidity(List<ItemInstance> ingredients) { }

	// RVA: 0x9181F0 Offset: 0x916BF0 VA: 0x1809181F0
	public float GetIngredientsMatchDelta(List<ItemInstance> ingredients) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x918B70 Offset: 0x917570 VA: 0x180918B70
	private static void .cctor() { }
}
