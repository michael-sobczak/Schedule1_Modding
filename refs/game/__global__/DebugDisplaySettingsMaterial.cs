public class DebugDisplaySettingsMaterial : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery // TypeDefIndex: 8795
{
	// Fields
	private DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData[] m_AlbedoDebugValidationPresetData; // 0x10
	private DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset m_AlbedoValidationPreset; // 0x18
	[CompilerGenerated]
	private float <albedoMinLuminance>k__BackingField; // 0x1C
	[CompilerGenerated]
	private float <albedoMaxLuminance>k__BackingField; // 0x20
	private float m_AlbedoHueTolerance; // 0x24
	private float m_AlbedoSaturationTolerance; // 0x28
	[CompilerGenerated]
	private Color <albedoCompareColor>k__BackingField; // 0x2C
	[CompilerGenerated]
	private float <metallicMinValue>k__BackingField; // 0x3C
	[CompilerGenerated]
	private float <metallicMaxValue>k__BackingField; // 0x40
	[CompilerGenerated]
	private DebugMaterialValidationMode <materialValidationMode>k__BackingField; // 0x44
	[CompilerGenerated]
	private DebugMaterialMode <materialDebugMode>k__BackingField; // 0x48
	[CompilerGenerated]
	private DebugVertexAttributeMode <vertexAttributeDebugMode>k__BackingField; // 0x4C

	// Properties
	public DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset albedoValidationPreset { get; set; }
	public float albedoMinLuminance { get; set; }
	public float albedoMaxLuminance { get; set; }
	public float albedoHueTolerance { get; set; }
	public float albedoSaturationTolerance { get; set; }
	public Color albedoCompareColor { get; set; }
	public float metallicMinValue { get; set; }
	public float metallicMaxValue { get; set; }
	public DebugMaterialValidationMode materialValidationMode { get; set; }
	public DebugMaterialMode materialDebugMode { get; set; }
	public DebugVertexAttributeMode vertexAttributeDebugMode { get; set; }
	public bool AreAnySettingsActive { get; }
	public bool IsPostProcessingAllowed { get; }
	public bool IsLightingActive { get; }

	// Methods

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset get_albedoValidationPreset() { }

	// RVA: 0x2AC74E0 Offset: 0x2AC5EE0 VA: 0x182AC74E0
	public void set_albedoValidationPreset(DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset value) { }

	[CompilerGenerated]
	// RVA: 0x498A60 Offset: 0x497460 VA: 0x180498A60
	public float get_albedoMinLuminance() { }

	[CompilerGenerated]
	// RVA: 0x49D820 Offset: 0x49C220 VA: 0x18049D820
	public void set_albedoMinLuminance(float value) { }

	[CompilerGenerated]
	// RVA: 0x4975C0 Offset: 0x495FC0 VA: 0x1804975C0
	public float get_albedoMaxLuminance() { }

	[CompilerGenerated]
	// RVA: 0x49CD70 Offset: 0x49B770 VA: 0x18049CD70
	public void set_albedoMaxLuminance(float value) { }

	// RVA: 0x2AC7490 Offset: 0x2AC5E90 VA: 0x182AC7490
	public float get_albedoHueTolerance() { }

	// RVA: 0x4944A0 Offset: 0x492EA0 VA: 0x1804944A0
	public void set_albedoHueTolerance(float value) { }

	// RVA: 0x2AC74B0 Offset: 0x2AC5EB0 VA: 0x182AC74B0
	public float get_albedoSaturationTolerance() { }

	// RVA: 0x54B820 Offset: 0x54A220 VA: 0x18054B820
	public void set_albedoSaturationTolerance(float value) { }

	[CompilerGenerated]
	// RVA: 0x1A4A650 Offset: 0x1A49050 VA: 0x181A4A650
	public Color get_albedoCompareColor() { }

	[CompilerGenerated]
	// RVA: 0x2AC74D0 Offset: 0x2AC5ED0 VA: 0x182AC74D0
	public void set_albedoCompareColor(Color value) { }

	[CompilerGenerated]
	// RVA: 0x4E2CC0 Offset: 0x4E16C0 VA: 0x1804E2CC0
	public float get_metallicMinValue() { }

	[CompilerGenerated]
	// RVA: 0x4E2CE0 Offset: 0x4E16E0 VA: 0x1804E2CE0
	public void set_metallicMinValue(float value) { }

	[CompilerGenerated]
	// RVA: 0x495F60 Offset: 0x494960 VA: 0x180495F60
	public float get_metallicMaxValue() { }

	[CompilerGenerated]
	// RVA: 0x49D330 Offset: 0x49BD30 VA: 0x18049D330
	public void set_metallicMaxValue(float value) { }

	[CompilerGenerated]
	// RVA: 0x594500 Offset: 0x592F00 VA: 0x180594500
	public DebugMaterialValidationMode get_materialValidationMode() { }

	[CompilerGenerated]
	// RVA: 0x1EEA950 Offset: 0x1EE9350 VA: 0x181EEA950
	public void set_materialValidationMode(DebugMaterialValidationMode value) { }

	[CompilerGenerated]
	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public DebugMaterialMode get_materialDebugMode() { }

	[CompilerGenerated]
	// RVA: 0x4E28C0 Offset: 0x4E12C0 VA: 0x1804E28C0
	public void set_materialDebugMode(DebugMaterialMode value) { }

	[CompilerGenerated]
	// RVA: 0x4D60C0 Offset: 0x4D4AC0 VA: 0x1804D60C0
	public DebugVertexAttributeMode get_vertexAttributeDebugMode() { }

	[CompilerGenerated]
	// RVA: 0x4E27E0 Offset: 0x4E11E0 VA: 0x1804E27E0
	public void set_vertexAttributeDebugMode(DebugVertexAttributeMode value) { }

	// RVA: 0x2AC7450 Offset: 0x2AC5E50 VA: 0x182AC7450 Slot: 5
	public bool get_AreAnySettingsActive() { }

	// RVA: 0x2AC7470 Offset: 0x2AC5E70 VA: 0x182AC7470 Slot: 6
	public bool get_IsPostProcessingAllowed() { }

	// RVA: 0x2AC7470 Offset: 0x2AC5E70 VA: 0x182AC7470 Slot: 7
	public bool get_IsLightingActive() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public bool TryGetScreenClearColor(ref Color color) { }

	// RVA: 0x2AC6B50 Offset: 0x2AC5550 VA: 0x182AC6B50 Slot: 4
	private IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel() { }

	// RVA: 0x2AC6BB0 Offset: 0x2AC55B0 VA: 0x182AC6BB0
	public void .ctor() { }
}
