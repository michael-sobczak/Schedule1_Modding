public class DebugDisplaySettingsRendering : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery // TypeDefIndex: 8817
{
	// Fields
	private DebugWireframeMode m_WireframeMode; // 0x10
	private bool m_Overdraw; // 0x14
	private DebugOverdrawMode m_OverdrawMode; // 0x18
	[CompilerGenerated]
	private int <maxOverdrawCount>k__BackingField; // 0x1C
	[CompilerGenerated]
	private DebugFullScreenMode <fullScreenDebugMode>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <fullScreenDebugModeOutputSizeScreenPercent>k__BackingField; // 0x24
	[CompilerGenerated]
	private DebugSceneOverrideMode <sceneOverrideMode>k__BackingField; // 0x28
	[CompilerGenerated]
	private DebugMipInfoMode <mipInfoMode>k__BackingField; // 0x2C
	[CompilerGenerated]
	private DebugPostProcessingMode <postProcessingDebugMode>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <enableMsaa>k__BackingField; // 0x34
	[CompilerGenerated]
	private bool <enableHDR>k__BackingField; // 0x35
	[CompilerGenerated]
	private DebugDisplaySettingsRendering.TaaDebugMode <taaDebugMode>k__BackingField; // 0x38
	[CompilerGenerated]
	private DebugValidationMode <validationMode>k__BackingField; // 0x3C
	[CompilerGenerated]
	private PixelValidationChannels <validationChannels>k__BackingField; // 0x40
	[CompilerGenerated]
	private float <validationRangeMin>k__BackingField; // 0x44
	[CompilerGenerated]
	private float <validationRangeMax>k__BackingField; // 0x48

	// Properties
	public DebugWireframeMode wireframeMode { get; set; }
	[Obsolete("overdraw has been deprecated. Use overdrawMode instead.", False)]
	public bool overdraw { get; set; }
	public DebugOverdrawMode overdrawMode { get; set; }
	public int maxOverdrawCount { get; set; }
	public DebugFullScreenMode fullScreenDebugMode { get; set; }
	public int fullScreenDebugModeOutputSizeScreenPercent { get; set; }
	internal DebugSceneOverrideMode sceneOverrideMode { get; set; }
	internal DebugMipInfoMode mipInfoMode { get; set; }
	public DebugPostProcessingMode postProcessingDebugMode { get; set; }
	public bool enableMsaa { get; set; }
	public bool enableHDR { get; set; }
	public DebugDisplaySettingsRendering.TaaDebugMode taaDebugMode { get; set; }
	public DebugValidationMode validationMode { get; set; }
	public PixelValidationChannels validationChannels { get; set; }
	public float validationRangeMin { get; set; }
	public float validationRangeMax { get; set; }
	public bool AreAnySettingsActive { get; }
	public bool IsPostProcessingAllowed { get; }
	public bool IsLightingActive { get; }

	// Methods

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public DebugWireframeMode get_wireframeMode() { }

	// RVA: 0x2AC7820 Offset: 0x2AC6220 VA: 0x182AC7820
	public void set_wireframeMode(DebugWireframeMode value) { }

	// RVA: 0x60D730 Offset: 0x60C130 VA: 0x18060D730
	public bool get_overdraw() { }

	// RVA: 0x2AC77C0 Offset: 0x2AC61C0 VA: 0x182AC77C0
	public void set_overdraw(bool value) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public DebugOverdrawMode get_overdrawMode() { }

	// RVA: 0x2AC7770 Offset: 0x2AC6170 VA: 0x182AC7770
	public void set_overdrawMode(DebugOverdrawMode value) { }

	[CompilerGenerated]
	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_maxOverdrawCount() { }

	[CompilerGenerated]
	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	public void set_maxOverdrawCount(int value) { }

	// RVA: 0x2AC7660 Offset: 0x2AC6060 VA: 0x182AC7660
	private void UpdateDebugSceneOverrideMode() { }

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public DebugFullScreenMode get_fullScreenDebugMode() { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_fullScreenDebugMode(DebugFullScreenMode value) { }

	[CompilerGenerated]
	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_fullScreenDebugModeOutputSizeScreenPercent() { }

	[CompilerGenerated]
	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_fullScreenDebugModeOutputSizeScreenPercent(int value) { }

	[CompilerGenerated]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	internal DebugSceneOverrideMode get_sceneOverrideMode() { }

	[CompilerGenerated]
	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	internal void set_sceneOverrideMode(DebugSceneOverrideMode value) { }

	[CompilerGenerated]
	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	internal DebugMipInfoMode get_mipInfoMode() { }

	[CompilerGenerated]
	// RVA: 0x65E020 Offset: 0x65CA20 VA: 0x18065E020
	internal void set_mipInfoMode(DebugMipInfoMode value) { }

	[CompilerGenerated]
	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public DebugPostProcessingMode get_postProcessingDebugMode() { }

	[CompilerGenerated]
	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	public void set_postProcessingDebugMode(DebugPostProcessingMode value) { }

	[CompilerGenerated]
	// RVA: 0x66AFB0 Offset: 0x6699B0 VA: 0x18066AFB0
	public bool get_enableMsaa() { }

	[CompilerGenerated]
	// RVA: 0x66B030 Offset: 0x669A30 VA: 0x18066B030
	public void set_enableMsaa(bool value) { }

	[CompilerGenerated]
	// RVA: 0x660940 Offset: 0x65F340 VA: 0x180660940
	public bool get_enableHDR() { }

	[CompilerGenerated]
	// RVA: 0x6604D0 Offset: 0x65EED0 VA: 0x1806604D0
	public void set_enableHDR(bool value) { }

	[CompilerGenerated]
	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public DebugDisplaySettingsRendering.TaaDebugMode get_taaDebugMode() { }

	[CompilerGenerated]
	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	public void set_taaDebugMode(DebugDisplaySettingsRendering.TaaDebugMode value) { }

	[CompilerGenerated]
	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	public DebugValidationMode get_validationMode() { }

	[CompilerGenerated]
	// RVA: 0xC21CD0 Offset: 0xC206D0 VA: 0x180C21CD0
	public void set_validationMode(DebugValidationMode value) { }

	[CompilerGenerated]
	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public PixelValidationChannels get_validationChannels() { }

	[CompilerGenerated]
	// RVA: 0x4E28B0 Offset: 0x4E12B0 VA: 0x1804E28B0
	public void set_validationChannels(PixelValidationChannels value) { }

	[CompilerGenerated]
	// RVA: 0x49D270 Offset: 0x49BC70 VA: 0x18049D270
	public float get_validationRangeMin() { }

	[CompilerGenerated]
	// RVA: 0x49D340 Offset: 0x49BD40 VA: 0x18049D340
	public void set_validationRangeMin(float value) { }

	[CompilerGenerated]
	// RVA: 0x495E80 Offset: 0x494880 VA: 0x180495E80
	public float get_validationRangeMax() { }

	[CompilerGenerated]
	// RVA: 0x810830 Offset: 0x80F230 VA: 0x180810830
	public void set_validationRangeMax(float value) { }

	// RVA: 0x2AC76F0 Offset: 0x2AC60F0 VA: 0x182AC76F0 Slot: 5
	public bool get_AreAnySettingsActive() { }

	// RVA: 0x2AC7750 Offset: 0x2AC6150 VA: 0x182AC7750 Slot: 6
	public bool get_IsPostProcessingAllowed() { }

	// RVA: 0x2AC7730 Offset: 0x2AC6130 VA: 0x182AC7730 Slot: 7
	public bool get_IsLightingActive() { }

	// RVA: 0x2AC7550 Offset: 0x2AC5F50 VA: 0x182AC7550 Slot: 8
	public bool TryGetScreenClearColor(ref Color color) { }

	// RVA: 0x2AC7600 Offset: 0x2AC6000 VA: 0x182AC7600 Slot: 4
	private IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel() { }

	// RVA: 0x2AC76C0 Offset: 0x2AC60C0 VA: 0x182AC76C0
	public void .ctor() { }
}
