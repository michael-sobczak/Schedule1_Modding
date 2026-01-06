public class MethDefinition : ProductDefinition // TypeDefIndex: 2461
{
	// Fields
	public Material CrystalMaterial; // 0x120
	[ColorUsage(True, True)]
	[SerializeField]
	public Color TintColor; // 0x128
	[CompilerGenerated]
	private MethAppearanceSettings <AppearanceSettings>k__BackingField; // 0x138

	// Properties
	public MethAppearanceSettings AppearanceSettings { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850
	public MethAppearanceSettings get_AppearanceSettings() { }

	[CompilerGenerated]
	// RVA: 0x65D8F0 Offset: 0x65C2F0 VA: 0x18065D8F0
	private void set_AppearanceSettings(MethAppearanceSettings value) { }

	// RVA: 0x88F400 Offset: 0x88DE00 VA: 0x18088F400 Slot: 4
	public override ItemInstance GetDefaultInstance(int quantity = 1) { }

	// RVA: 0x88F8C0 Offset: 0x88E2C0 VA: 0x18088F8C0
	public void Initialize(List<Effect> properties, List<EDrugType> drugTypes, MethAppearanceSettings _appearance) { }

	// RVA: 0x88F710 Offset: 0x88E110 VA: 0x18088F710 Slot: 33
	public override ProductData GetSaveData() { }

	// RVA: 0x88EDF0 Offset: 0x88D7F0 VA: 0x18088EDF0 Slot: 32
	public override void GenerateAppearanceSettings() { }

	// RVA: 0x88EC90 Offset: 0x88D690 VA: 0x18088EC90
	private void ApplyAppearanceSettings() { }

	// RVA: 0x88EE30 Offset: 0x88D830 VA: 0x18088EE30
	public static MethAppearanceSettings GetAppearanceSettings(List<Effect> properties) { }

	// RVA: 0x88F9D0 Offset: 0x88E3D0 VA: 0x18088F9D0
	public void .ctor() { }
}
