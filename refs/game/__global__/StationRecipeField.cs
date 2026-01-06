public class StationRecipeField : ConfigField // TypeDefIndex: 1222
{
	// Fields
	[CompilerGenerated]
	private StationRecipe <SelectedRecipe>k__BackingField; // 0x18
	public List<StationRecipe> Options; // 0x20
	public UnityEvent<StationRecipe> onRecipeChanged; // 0x28

	// Properties
	public StationRecipe SelectedRecipe { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public StationRecipe get_SelectedRecipe() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	protected void set_SelectedRecipe(StationRecipe value) { }

	// RVA: 0x622990 Offset: 0x621390 VA: 0x180622990
	public void .ctor(EntityConfiguration parentConfig) { }

	// RVA: 0x6228F0 Offset: 0x6212F0 VA: 0x1806228F0
	public void SetRecipe(StationRecipe recipe, bool network) { }

	// RVA: 0x622790 Offset: 0x621190 VA: 0x180622790 Slot: 4
	public override bool IsValueDefault() { }

	// RVA: 0x6226B0 Offset: 0x6210B0 VA: 0x1806226B0
	public StationRecipeFieldData GetData() { }

	// RVA: 0x6227E0 Offset: 0x6211E0 VA: 0x1806227E0
	public void Load(StationRecipeFieldData data) { }
}
