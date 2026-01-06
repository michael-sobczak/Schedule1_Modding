public class WeedDefinition : ProductDefinition // TypeDefIndex: 2518
{
	// Fields
	[Header("Weed Materials")]
	public Material MainMat; // 0x120
	public Material SecondaryMat; // 0x128
	public Material LeafMat; // 0x130
	public Material StemMat; // 0x138
	private WeedAppearanceSettings appearance; // 0x140

	// Methods

	// RVA: 0x8C2BD0 Offset: 0x8C15D0 VA: 0x1808C2BD0 Slot: 4
	public override ItemInstance GetDefaultInstance(int quantity = 1) { }

	// RVA: 0x8C2E00 Offset: 0x8C1800 VA: 0x1808C2E00
	public void Initialize(List<Effect> properties, List<EDrugType> drugTypes, WeedAppearanceSettings _appearance) { }

	// RVA: 0x8C2C50 Offset: 0x8C1650 VA: 0x1808C2C50 Slot: 33
	public override ProductData GetSaveData() { }

	// RVA: 0x8C2570 Offset: 0x8C0F70 VA: 0x1808C2570 Slot: 32
	public override void GenerateAppearanceSettings() { }

	// RVA: 0x8C20E0 Offset: 0x8C0AE0 VA: 0x1808C20E0
	private void ApplyAppearanceSettings() { }

	// RVA: 0x8C25C0 Offset: 0x8C0FC0 VA: 0x1808C25C0
	public static WeedAppearanceSettings GetAppearanceSettings(List<Effect> properties) { }

	// RVA: 0x60CA10 Offset: 0x60B410 VA: 0x18060CA10
	public Material GetMaterial(WeedAppearanceSettings.EWeedAppearanceType type) { }

	// RVA: 0x88D200 Offset: 0x88BC00 VA: 0x18088D200
	public void .ctor() { }
}
