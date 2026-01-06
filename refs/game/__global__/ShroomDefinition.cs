public class ShroomDefinition : ProductDefinition // TypeDefIndex: 2502
{
	// Fields
	[SerializeField]
	[CompilerGenerated]
	private Material <ShroomMaterial>k__BackingField; // 0x120
	[CompilerGenerated]
	[SerializeField]
	private Material <BulkMaterial>k__BackingField; // 0x128
	[SerializeField]
	[CompilerGenerated]
	private Material <EyeballMaterial>k__BackingField; // 0x130
	[CompilerGenerated]
	private ShroomAppearanceSettings <AppearanceSettings>k__BackingField; // 0x138

	// Properties
	public Material ShroomMaterial { get; set; }
	public Material BulkMaterial { get; set; }
	public Material EyeballMaterial { get; set; }
	public ShroomAppearanceSettings AppearanceSettings { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public Material get_ShroomMaterial() { }

	[CompilerGenerated]
	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640
	private void set_ShroomMaterial(Material value) { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public Material get_BulkMaterial() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0
	private void set_BulkMaterial(Material value) { }

	[CompilerGenerated]
	// RVA: 0x65D840 Offset: 0x65C240 VA: 0x18065D840
	public Material get_EyeballMaterial() { }

	[CompilerGenerated]
	// RVA: 0x65D8D0 Offset: 0x65C2D0 VA: 0x18065D8D0
	private void set_EyeballMaterial(Material value) { }

	[CompilerGenerated]
	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850
	public ShroomAppearanceSettings get_AppearanceSettings() { }

	[CompilerGenerated]
	// RVA: 0x65D8F0 Offset: 0x65C2F0 VA: 0x18065D8F0
	private void set_AppearanceSettings(ShroomAppearanceSettings value) { }

	// RVA: 0x8BC060 Offset: 0x8BAA60 VA: 0x1808BC060 Slot: 5
	public override void ValidateDefinition() { }

	// RVA: 0x8BBF50 Offset: 0x8BA950 VA: 0x1808BBF50
	public void Initialize(List<Effect> properties, List<EDrugType> drugTypes, ShroomAppearanceSettings _appearance) { }

	// RVA: 0x8BBCB0 Offset: 0x8BA6B0 VA: 0x1808BBCB0 Slot: 4
	public override ItemInstance GetDefaultInstance(int quantity = 1) { }

	// RVA: 0x8BBDA0 Offset: 0x8BA7A0 VA: 0x1808BBDA0 Slot: 33
	public override ProductData GetSaveData() { }

	// RVA: 0x8BAC50 Offset: 0x8B9650 VA: 0x1808BAC50 Slot: 32
	public override void GenerateAppearanceSettings() { }

	// RVA: 0x8BACA0 Offset: 0x8B96A0 VA: 0x1808BACA0
	private void GenerateMaterials() { }

	// RVA: 0x8BB4D0 Offset: 0x8B9ED0 VA: 0x1808BB4D0
	public static ShroomAppearanceSettings GetAppearanceSettings(List<Effect> properties) { }

	// RVA: 0x88D200 Offset: 0x88BC00 VA: 0x18088D200
	public void .ctor() { }
}
