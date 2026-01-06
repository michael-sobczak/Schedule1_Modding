public class ColorGradingModel : PostProcessingModel // TypeDefIndex: 184
{
	// Fields
	[SerializeField]
	private ColorGradingModel.Settings m_Settings; // 0x18
	[CompilerGenerated]
	private bool <isDirty>k__BackingField; // 0x120
	[CompilerGenerated]
	private RenderTexture <bakedLut>k__BackingField; // 0x128

	// Properties
	public ColorGradingModel.Settings settings { get; set; }
	public bool isDirty { get; set; }
	public RenderTexture bakedLut { get; set; }

	// Methods

	// RVA: 0x695E60 Offset: 0x694860 VA: 0x180695E60
	public ColorGradingModel.Settings get_settings() { }

	// RVA: 0x695EE0 Offset: 0x6948E0 VA: 0x180695EE0
	public void set_settings(ColorGradingModel.Settings value) { }

	[CompilerGenerated]
	// RVA: 0x513170 Offset: 0x511B70 VA: 0x180513170
	public bool get_isDirty() { }

	[CompilerGenerated]
	// RVA: 0x5EB2E0 Offset: 0x5E9CE0 VA: 0x1805EB2E0
	internal void set_isDirty(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public RenderTexture get_bakedLut() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0
	internal void set_bakedLut(RenderTexture value) { }

	// RVA: 0x695C30 Offset: 0x694630 VA: 0x180695C30 Slot: 4
	public override void Reset() { }

	// RVA: 0x5EAB30 Offset: 0x5E9530 VA: 0x1805EAB30 Slot: 5
	public override void OnValidate() { }

	// RVA: 0x695D50 Offset: 0x694750 VA: 0x180695D50
	public void .ctor() { }
}
