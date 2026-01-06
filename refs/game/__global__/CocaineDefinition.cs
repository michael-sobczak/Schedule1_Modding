public class CocaineDefinition : ProductDefinition // TypeDefIndex: 2450
{
	// Fields
	[Header("Materials")]
	public Material RockMaterial; // 0x120
	[CompilerGenerated]
	private CocaineAppearanceSettings <AppearanceSettings>k__BackingField; // 0x128

	// Properties
	public CocaineAppearanceSettings AppearanceSettings { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public CocaineAppearanceSettings get_AppearanceSettings() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0
	private void set_AppearanceSettings(CocaineAppearanceSettings value) { }

	// RVA: 0x88CC30 Offset: 0x88B630 VA: 0x18088CC30 Slot: 4
	public override ItemInstance GetDefaultInstance(int quantity = 1) { }

	// RVA: 0x88D0F0 Offset: 0x88BAF0 VA: 0x18088D0F0
	public void Initialize(List<Effect> properties, List<EDrugType> drugTypes, CocaineAppearanceSettings _appearance) { }

	// RVA: 0x88CF40 Offset: 0x88B940 VA: 0x18088CF40 Slot: 33
	public override ProductData GetSaveData() { }

	// RVA: 0x88C620 Offset: 0x88B020 VA: 0x18088C620 Slot: 32
	public override void GenerateAppearanceSettings() { }

	// RVA: 0x88C4C0 Offset: 0x88AEC0 VA: 0x18088C4C0
	private void ApplyAppearanceSettings() { }

	// RVA: 0x88C660 Offset: 0x88B060 VA: 0x18088C660
	public static CocaineAppearanceSettings GetAppearanceSettings(List<Effect> properties) { }

	// RVA: 0x88D200 Offset: 0x88BC00 VA: 0x18088D200
	public void .ctor() { }
}
