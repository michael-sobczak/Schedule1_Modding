public class ProductDefinition : PropertyItemDefinition, ISaveable // TypeDefIndex: 2467
{
	// Fields
	[Header("Product Settings")]
	public List<DrugTypeContainer> DrugTypes; // 0xC8
	public float LawIntensityChange; // 0xD0
	public float BasePrice; // 0xD4
	public float MarketValue; // 0xD8
	public FunctionalProduct FunctionalProduct; // 0xE0
	public int EffectsDuration; // 0xE8
	[Range(0, 1)]
	public float BaseAddictiveness; // 0xEC
	[Header("Packaging that can be applied to this product. MUST BE ORDERED FROm LOWEST TO HIGHEST QUANTITY")]
	public PackagingDefinition[] ValidPackaging; // 0xF0
	[Header("Product References")]
	public ProductConsumeAnimation ConsumeAnimation; // 0xF8
	[CompilerGenerated]
	private List<StationRecipe> <Recipes>k__BackingField; // 0x100
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x108
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x110
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x118

	// Properties
	public EDrugType DrugType { get; }
	public float Price { get; }
	public List<StationRecipe> Recipes { get; set; }
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFolders { get; set; }
	public List<string> LocalExtraFiles { get; set; }
	public bool HasChanged { get; set; }

	// Methods

	// RVA: 0x8936F0 Offset: 0x8920F0 VA: 0x1808936F0
	public EDrugType get_DrugType() { }

	// RVA: 0x893750 Offset: 0x892150 VA: 0x180893750
	public float get_Price() { }

	[CompilerGenerated]
	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	public List<StationRecipe> get_Recipes() { }

	[CompilerGenerated]
	// RVA: 0x51DD20 Offset: 0x51C720 VA: 0x18051DD20
	private void set_Recipes(List<StationRecipe> value) { }

	// RVA: 0x8937E0 Offset: 0x8921E0 VA: 0x1808937E0 Slot: 8
	public string get_SaveFolderName() { }

	// RVA: 0x8937E0 Offset: 0x8921E0 VA: 0x1808937E0 Slot: 9
	public string get_SaveFileName() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 10
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 11
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x516260 Offset: 0x514C60 VA: 0x180516260 Slot: 14
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x505FC0 Offset: 0x5049C0 VA: 0x180505FC0 Slot: 15
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0 Slot: 12
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x8937F0 Offset: 0x8921F0 VA: 0x1808937F0 Slot: 13
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x51D980 Offset: 0x51C380 VA: 0x18051D980 Slot: 16
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x662310 Offset: 0x660D10 VA: 0x180662310 Slot: 17
	public void set_HasChanged(bool value) { }

	// RVA: 0x893040 Offset: 0x891A40 VA: 0x180893040 Slot: 4
	public override ItemInstance GetDefaultInstance(int quantity = 1) { }

	// RVA: 0x893540 Offset: 0x891F40 VA: 0x180893540
	public void OnValidate() { }

	// RVA: 0x893320 Offset: 0x891D20 VA: 0x180893320
	public void Initialize(List<Effect> properties, List<EDrugType> drugTypes) { }

	// RVA: 0x893290 Offset: 0x891C90 VA: 0x180893290 Slot: 31
	public virtual void InitializeSaveable() { }

	// RVA: 0x892F70 Offset: 0x891970 VA: 0x180892F70
	public float GetAddictiveness() { }

	// RVA: 0x892E80 Offset: 0x891880 VA: 0x180892E80
	public void CleanRecipes() { }

	// RVA: 0x892D60 Offset: 0x891760 VA: 0x180892D60
	public void AddRecipe(StationRecipe recipe) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 32
	public virtual void GenerateAppearanceSettings() { }

	// RVA: 0x8930C0 Offset: 0x891AC0 VA: 0x1808930C0 Slot: 33
	public virtual ProductData GetSaveData() { }

	// RVA: 0x893250 Offset: 0x891C50 VA: 0x180893250 Slot: 34
	public virtual string GetSaveString() { }

	// RVA: 0x8935C0 Offset: 0x891FC0 VA: 0x1808935C0
	public void .ctor() { }
}
