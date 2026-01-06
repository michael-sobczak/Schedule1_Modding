public class HBAO : MonoBehaviour // TypeDefIndex: 18564
{
	// Fields
	public Shader hbaoShader; // 0x20
	[SerializeField]
	[SettingsGroup]
	private HBAO.Presets m_Presets; // 0x28
	[SettingsGroup]
	[SerializeField]
	private HBAO.GeneralSettings m_GeneralSettings; // 0x2C
	[SerializeField]
	[SettingsGroup]
	private HBAO.AOSettings m_AOSettings; // 0x44
	[SerializeField]
	[SettingsGroup]
	private HBAO.TemporalFilterSettings m_TemporalFilterSettings; // 0x7C
	[SerializeField]
	[SettingsGroup]
	private HBAO.BlurSettings m_BlurSettings; // 0x84
	[SettingsGroup]
	[SerializeField]
	private HBAO.ColorBleedingSettings m_ColorBleedingSettings; // 0x8C
	private static readonly Vector2[] s_jitter; // 0x0
	private static readonly float[] s_temporalRotations; // 0x8
	private static readonly float[] s_temporalOffsets; // 0x10
	[CompilerGenerated]
	private Material <material>k__BackingField; // 0xA8
	[CompilerGenerated]
	private Camera <hbaoCamera>k__BackingField; // 0xB0
	[CompilerGenerated]
	private CommandBuffer <cmdBuffer>k__BackingField; // 0xB8
	[CompilerGenerated]
	private int <width>k__BackingField; // 0xC0
	[CompilerGenerated]
	private int <height>k__BackingField; // 0xC4
	[CompilerGenerated]
	private bool <stereoActive>k__BackingField; // 0xC8
	[CompilerGenerated]
	private int <xrActiveEye>k__BackingField; // 0xCC
	[CompilerGenerated]
	private HBAO.StereoRenderingMode <stereoRenderingMode>k__BackingField; // 0xD0
	[CompilerGenerated]
	private int <screenWidth>k__BackingField; // 0xD4
	[CompilerGenerated]
	private int <screenHeight>k__BackingField; // 0xD8
	[CompilerGenerated]
	private int <aoWidth>k__BackingField; // 0xDC
	[CompilerGenerated]
	private int <aoHeight>k__BackingField; // 0xE0
	[CompilerGenerated]
	private int <reinterleavedAoWidth>k__BackingField; // 0xE4
	[CompilerGenerated]
	private int <reinterleavedAoHeight>k__BackingField; // 0xE8
	[CompilerGenerated]
	private int <deinterleavedAoWidth>k__BackingField; // 0xEC
	[CompilerGenerated]
	private int <deinterleavedAoHeight>k__BackingField; // 0xF0
	[CompilerGenerated]
	private int <frameCount>k__BackingField; // 0xF4
	[CompilerGenerated]
	private bool <motionVectorsSupported>k__BackingField; // 0xF8
	[CompilerGenerated]
	private RenderTexture <aoHistoryBuffer>k__BackingField; // 0x100
	[CompilerGenerated]
	private RenderTexture <colorBleedingHistoryBuffer>k__BackingField; // 0x108
	[CompilerGenerated]
	private Texture2D <noiseTex>k__BackingField; // 0x110
	private RenderTextureDescriptor m_sourceDescriptor; // 0x118
	private string[] m_ShaderKeywords; // 0x150
	private Vector4[] m_UVToViewPerEye; // 0x158
	private float[] m_RadiusPerEye; // 0x160
	private bool m_IsCommandBufferDirty; // 0x168
	private Mesh m_FullscreenTriangle; // 0x170
	private Nullable<HBAO.PipelineStage> m_PreviousPipelineStage; // 0x178
	private Nullable<HBAO.Resolution> m_PreviousResolution; // 0x180
	private Nullable<HBAO.Deinterleaving> m_PreviousDeinterleaving; // 0x188
	private Nullable<HBAO.DebugMode> m_PreviousDebugMode; // 0x190
	private Nullable<HBAO.NoiseType> m_PreviousNoiseType; // 0x198
	private Nullable<HBAO.BlurType> m_PreviousBlurAmount; // 0x1A0
	private int m_PreviousWidth; // 0x1A8
	private int m_PreviousHeight; // 0x1AC
	private bool m_PreviousAllowHDR; // 0x1B0
	private bool m_PreviousUseMultibounce; // 0x1B1
	private bool m_PreviousColorBleedingEnabled; // 0x1B2
	private bool m_PreviousTemporalFilterEnabled; // 0x1B3
	private RenderingPath m_PreviousRenderingPath; // 0x1B4
	private HBAO.StereoRenderingMode m_PrevStereoRenderingMode; // 0x1B8

	// Properties
	public HBAO.Presets presets { get; set; }
	public HBAO.GeneralSettings generalSettings { get; set; }
	public HBAO.AOSettings aoSettings { get; set; }
	public HBAO.TemporalFilterSettings temporalFilterSettings { get; set; }
	public HBAO.BlurSettings blurSettings { get; set; }
	public HBAO.ColorBleedingSettings colorBleedingSettings { get; set; }
	private Material material { get; set; }
	private Camera hbaoCamera { get; set; }
	private CommandBuffer cmdBuffer { get; set; }
	private int width { get; set; }
	private int height { get; set; }
	private bool stereoActive { get; set; }
	private int xrActiveEye { get; set; }
	private HBAO.StereoRenderingMode stereoRenderingMode { get; set; }
	private int screenWidth { get; set; }
	private int screenHeight { get; set; }
	private int aoWidth { get; set; }
	private int aoHeight { get; set; }
	private int reinterleavedAoWidth { get; set; }
	private int reinterleavedAoHeight { get; set; }
	private int deinterleavedAoWidth { get; set; }
	private int deinterleavedAoHeight { get; set; }
	private int frameCount { get; set; }
	private bool motionVectorsSupported { get; set; }
	private RenderTexture aoHistoryBuffer { get; set; }
	private RenderTexture colorBleedingHistoryBuffer { get; set; }
	private Texture2D noiseTex { get; set; }
	private Mesh fullscreenTriangle { get; }
	private CameraEvent cameraEvent { get; }
	private bool isCommandBufferDirty { get; set; }
	private bool isHistoryBufferDirty { get; }
	private static RenderTextureFormat defaultHDRRenderTextureFormat { get; }
	private RenderTextureFormat sourceFormat { get; }
	private static RenderTextureFormat colorFormat { get; }
	private static RenderTextureFormat depthFormat { get; }
	private static RenderTextureFormat normalsFormat { get; }
	private static bool isLinearColorSpace { get; }
	private bool renderingInSceneView { get; }

	// Methods

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public HBAO.Presets get_presets() { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void set_presets(HBAO.Presets value) { }

	// RVA: 0x1A3A800 Offset: 0x1A39200 VA: 0x181A3A800
	public HBAO.GeneralSettings get_generalSettings() { }

	// RVA: 0x1A3AEB0 Offset: 0x1A398B0 VA: 0x181A3AEB0
	public void set_generalSettings(HBAO.GeneralSettings value) { }

	// RVA: 0x1A3A360 Offset: 0x1A38D60 VA: 0x181A3A360
	public HBAO.AOSettings get_aoSettings() { }

	// RVA: 0x1A3AE40 Offset: 0x1A39840 VA: 0x181A3AE40
	public void set_aoSettings(HBAO.AOSettings value) { }

	// RVA: 0xCE3DB0 Offset: 0xCE27B0 VA: 0x180CE3DB0
	public HBAO.TemporalFilterSettings get_temporalFilterSettings() { }

	// RVA: 0xCE3E10 Offset: 0xCE2810 VA: 0x180CE3E10
	public void set_temporalFilterSettings(HBAO.TemporalFilterSettings value) { }

	// RVA: 0x1A3A390 Offset: 0x1A38D90 VA: 0x181A3A390
	public HBAO.BlurSettings get_blurSettings() { }

	// RVA: 0xBBA7B0 Offset: 0xBB91B0 VA: 0x180BBA7B0
	public void set_blurSettings(HBAO.BlurSettings value) { }

	// RVA: 0x1A3A3F0 Offset: 0x1A38DF0 VA: 0x181A3A3F0
	public HBAO.ColorBleedingSettings get_colorBleedingSettings() { }

	// RVA: 0x1A3AE70 Offset: 0x1A39870 VA: 0x181A3AE70
	public void set_colorBleedingSettings(HBAO.ColorBleedingSettings value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public HBAO.Preset GetCurrentPreset() { }

	// RVA: 0x1A32850 Offset: 0x1A31250 VA: 0x181A32850
	public void ApplyPreset(HBAO.Preset preset) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public HBAO.PipelineStage GetPipelineStage() { }

	// RVA: 0x65E020 Offset: 0x65CA20 VA: 0x18065E020
	public void SetPipelineStage(HBAO.PipelineStage pipelineStage) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public HBAO.Quality GetQuality() { }

	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	public void SetQuality(HBAO.Quality quality) { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public HBAO.Deinterleaving GetDeinterleaving() { }

	// RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40
	public void SetDeinterleaving(HBAO.Deinterleaving deinterleaving) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public HBAO.Resolution GetResolution() { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	public void SetResolution(HBAO.Resolution resolution) { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	public HBAO.NoiseType GetNoiseType() { }

	// RVA: 0xC21CD0 Offset: 0xC206D0 VA: 0x180C21CD0
	public void SetNoiseType(HBAO.NoiseType noiseType) { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public HBAO.DebugMode GetDebugMode() { }

	// RVA: 0x4E28B0 Offset: 0x4E12B0 VA: 0x1804E28B0
	public void SetDebugMode(HBAO.DebugMode debugMode) { }

	// RVA: 0x49D270 Offset: 0x49BC70 VA: 0x18049D270
	public float GetAoRadius() { }

	// RVA: 0x1A37E00 Offset: 0x1A36800 VA: 0x181A37E00
	public void SetAoRadius(float radius) { }

	// RVA: 0x495E80 Offset: 0x494880 VA: 0x180495E80
	public float GetAoMaxRadiusPixels() { }

	// RVA: 0x1A37D70 Offset: 0x1A36770 VA: 0x181A37D70
	public void SetAoMaxRadiusPixels(float maxRadiusPixels) { }

	// RVA: 0x495F70 Offset: 0x494970 VA: 0x180495F70
	public float GetAoBias() { }

	// RVA: 0x1A37D00 Offset: 0x1A36700 VA: 0x181A37D00
	public void SetAoBias(float bias) { }

	// RVA: 0x4B5C00 Offset: 0x4B4600 VA: 0x1804B5C00
	public float GetAoOffscreenSamplesContribution() { }

	// RVA: 0x1A37DD0 Offset: 0x1A367D0 VA: 0x181A37DD0
	public void SetAoOffscreenSamplesContribution(float contribution) { }

	// RVA: 0x4B5440 Offset: 0x4B3E40 VA: 0x1804B5440
	public float GetAoMaxDistance() { }

	// RVA: 0x810840 Offset: 0x80F240 VA: 0x180810840
	public void SetAoMaxDistance(float maxDistance) { }

	// RVA: 0x4CD1A0 Offset: 0x4CBBA0 VA: 0x1804CD1A0
	public float GetAoDistanceFalloff() { }

	// RVA: 0x1A37D30 Offset: 0x1A36730 VA: 0x181A37D30
	public void SetAoDistanceFalloff(float distanceFalloff) { }

	// RVA: 0x54CEB0 Offset: 0x54B8B0 VA: 0x18054CEB0
	public HBAO.PerPixelNormals GetAoPerPixelNormals() { }

	// RVA: 0x54CF80 Offset: 0x54B980 VA: 0x18054CF80
	public void SetAoPerPixelNormals(HBAO.PerPixelNormals perPixelNormals) { }

	// RVA: 0x4B5E00 Offset: 0x4B4800 VA: 0x1804B5E00
	public Color GetAoColor() { }

	// RVA: 0x4B6970 Offset: 0x4B5370 VA: 0x1804B6970
	public void SetAoColor(Color color) { }

	// RVA: 0x4C3B50 Offset: 0x4C2550 VA: 0x1804C3B50
	public float GetAoIntensity() { }

	// RVA: 0x1A37D40 Offset: 0x1A36740 VA: 0x181A37D40
	public void SetAoIntensity(float intensity) { }

	// RVA: 0x4E2420 Offset: 0x4E0E20 VA: 0x1804E2420
	public bool UseMultiBounce() { }

	// RVA: 0x4E2920 Offset: 0x4E1320 VA: 0x1804E2920
	public void EnableMultiBounce(bool enabled = True) { }

	// RVA: 0x4B6210 Offset: 0x4B4C10 VA: 0x1804B6210
	public float GetAoMultiBounceInfluence() { }

	// RVA: 0x1A37DA0 Offset: 0x1A367A0 VA: 0x181A37DA0
	public void SetAoMultiBounceInfluence(float multiBounceInfluence) { }

	// RVA: 0x83DBA0 Offset: 0x83C5A0 VA: 0x18083DBA0
	public bool IsTemporalFilterEnabled() { }

	// RVA: 0x83DBD0 Offset: 0x83C5D0 VA: 0x18083DBD0
	public void EnableTemporalFilter(bool enabled = True) { }

	// RVA: 0x4D6280 Offset: 0x4D4C80 VA: 0x1804D6280
	public HBAO.VarianceClipping GetTemporalFilterVarianceClipping() { }

	// RVA: 0x4D6540 Offset: 0x4D4F40 VA: 0x1804D6540
	public void SetTemporalFilterVarianceClipping(HBAO.VarianceClipping varianceClipping) { }

	// RVA: 0x6A52B0 Offset: 0x6A3CB0 VA: 0x1806A52B0
	public HBAO.BlurType GetBlurType() { }

	// RVA: 0x9883D0 Offset: 0x986DD0 VA: 0x1809883D0
	public void SetBlurType(HBAO.BlurType blurType) { }

	// RVA: 0x6A5250 Offset: 0x6A3C50 VA: 0x1806A5250
	public float GetBlurSharpness() { }

	// RVA: 0x1A37E30 Offset: 0x1A36830 VA: 0x181A37E30
	public void SetBlurSharpness(float sharpness) { }

	// RVA: 0x1A37560 Offset: 0x1A35F60 VA: 0x181A37560
	public bool IsColorBleedingEnabled() { }

	// RVA: 0x1A36D50 Offset: 0x1A35750 VA: 0x181A36D50
	public void EnableColorBleeding(bool enabled = True) { }

	// RVA: 0x4B6130 Offset: 0x4B4B30 VA: 0x1804B6130
	public float GetColorBleedingSaturation() { }

	// RVA: 0x1A37F20 Offset: 0x1A36920 VA: 0x181A37F20
	public void SetColorBleedingSaturation(float saturation) { }

	// RVA: 0x8D2000 Offset: 0x8D0A00 VA: 0x1808D2000
	public float GetColorBleedingAlbedoMultiplier() { }

	// RVA: 0x1A37E60 Offset: 0x1A36860 VA: 0x181A37E60
	public void SetColorBleedingAlbedoMultiplier(float albedoMultiplier) { }

	// RVA: 0x8B33F0 Offset: 0x8B1DF0 VA: 0x1808B33F0
	public float GetColorBleedingBrightnessMask() { }

	// RVA: 0x1A37EF0 Offset: 0x1A368F0 VA: 0x181A37EF0
	public void SetColorBleedingBrightnessMask(float brightnessMask) { }

	// RVA: 0x1063C70 Offset: 0x1062670 VA: 0x181063C70
	public Vector2 GetColorBleedingBrightnessMaskRange() { }

	// RVA: 0x1A37E90 Offset: 0x1A36890 VA: 0x181A37E90
	public void SetColorBleedingBrightnessMaskRange(Vector2 brightnessMaskRange) { }

	[CompilerGenerated]
	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	private Material get_material() { }

	[CompilerGenerated]
	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20
	private void set_material(Material value) { }

	[CompilerGenerated]
	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150
	private Camera get_hbaoCamera() { }

	[CompilerGenerated]
	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80
	private void set_hbaoCamera(Camera value) { }

	[CompilerGenerated]
	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	private CommandBuffer get_cmdBuffer() { }

	[CompilerGenerated]
	// RVA: 0x4B6CA0 Offset: 0x4B56A0 VA: 0x1804B6CA0
	private void set_cmdBuffer(CommandBuffer value) { }

	[CompilerGenerated]
	// RVA: 0x505900 Offset: 0x504300 VA: 0x180505900
	private int get_width() { }

	[CompilerGenerated]
	// RVA: 0x1A3AF30 Offset: 0x1A39930 VA: 0x181A3AF30
	private void set_width(int value) { }

	[CompilerGenerated]
	// RVA: 0x526FE0 Offset: 0x5259E0 VA: 0x180526FE0
	private int get_height() { }

	[CompilerGenerated]
	// RVA: 0x1A3AED0 Offset: 0x1A398D0 VA: 0x181A3AED0
	private void set_height(int value) { }

	[CompilerGenerated]
	// RVA: 0x1A3AE20 Offset: 0x1A39820 VA: 0x181A3AE20
	private bool get_stereoActive() { }

	[CompilerGenerated]
	// RVA: 0x1A3AF10 Offset: 0x1A39910 VA: 0x181A3AF10
	private void set_stereoActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6A37B0 Offset: 0x6A21B0 VA: 0x1806A37B0
	private int get_xrActiveEye() { }

	[CompilerGenerated]
	// RVA: 0x1A3AF40 Offset: 0x1A39940 VA: 0x181A3AF40
	private void set_xrActiveEye(int value) { }

	[CompilerGenerated]
	// RVA: 0x1A3AE30 Offset: 0x1A39830 VA: 0x181A3AE30
	private HBAO.StereoRenderingMode get_stereoRenderingMode() { }

	[CompilerGenerated]
	// RVA: 0x1A3AF20 Offset: 0x1A39920 VA: 0x181A3AF20
	private void set_stereoRenderingMode(HBAO.StereoRenderingMode value) { }

	[CompilerGenerated]
	// RVA: 0x1A3ADA0 Offset: 0x1A397A0 VA: 0x181A3ADA0
	private int get_screenWidth() { }

	[CompilerGenerated]
	// RVA: 0x1A3AF00 Offset: 0x1A39900 VA: 0x181A3AF00
	private void set_screenWidth(int value) { }

	[CompilerGenerated]
	// RVA: 0x516290 Offset: 0x514C90 VA: 0x180516290
	private int get_screenHeight() { }

	[CompilerGenerated]
	// RVA: 0xB39BE0 Offset: 0xB385E0 VA: 0x180B39BE0
	private void set_screenHeight(int value) { }

	[CompilerGenerated]
	// RVA: 0x510B10 Offset: 0x50F510 VA: 0x180510B10
	private int get_aoWidth() { }

	[CompilerGenerated]
	// RVA: 0xB39BD0 Offset: 0xB385D0 VA: 0x180B39BD0
	private void set_aoWidth(int value) { }

	[CompilerGenerated]
	// RVA: 0x505860 Offset: 0x504260 VA: 0x180505860
	private int get_aoHeight() { }

	[CompilerGenerated]
	// RVA: 0xC15350 Offset: 0xC13D50 VA: 0x180C15350
	private void set_aoHeight(int value) { }

	[CompilerGenerated]
	// RVA: 0x5231E0 Offset: 0x521BE0 VA: 0x1805231E0
	private int get_reinterleavedAoWidth() { }

	[CompilerGenerated]
	// RVA: 0x10F9810 Offset: 0x10F8210 VA: 0x1810F9810
	private void set_reinterleavedAoWidth(int value) { }

	[CompilerGenerated]
	// RVA: 0x51E8D0 Offset: 0x51D2D0 VA: 0x18051E8D0
	private int get_reinterleavedAoHeight() { }

	[CompilerGenerated]
	// RVA: 0x1A3AEF0 Offset: 0x1A398F0 VA: 0x181A3AEF0
	private void set_reinterleavedAoHeight(int value) { }

	[CompilerGenerated]
	// RVA: 0x523390 Offset: 0x521D90 VA: 0x180523390
	private int get_deinterleavedAoWidth() { }

	[CompilerGenerated]
	// RVA: 0x1A3AEA0 Offset: 0x1A398A0 VA: 0x181A3AEA0
	private void set_deinterleavedAoWidth(int value) { }

	[CompilerGenerated]
	// RVA: 0x1A3A440 Offset: 0x1A38E40 VA: 0x181A3A440
	private int get_deinterleavedAoHeight() { }

	[CompilerGenerated]
	// RVA: 0x1A3AE90 Offset: 0x1A39890 VA: 0x181A3AE90
	private void set_deinterleavedAoHeight(int value) { }

	[CompilerGenerated]
	// RVA: 0xD9E760 Offset: 0xD9D160 VA: 0x180D9E760
	private int get_frameCount() { }

	[CompilerGenerated]
	// RVA: 0xD9EBD0 Offset: 0xD9D5D0 VA: 0x180D9EBD0
	private void set_frameCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x516240 Offset: 0x514C40 VA: 0x180516240
	private bool get_motionVectorsSupported() { }

	[CompilerGenerated]
	// RVA: 0x1A3AEE0 Offset: 0x1A398E0 VA: 0x181A3AEE0
	private void set_motionVectorsSupported(bool value) { }

	[CompilerGenerated]
	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	private RenderTexture get_aoHistoryBuffer() { }

	[CompilerGenerated]
	// RVA: 0x51DD20 Offset: 0x51C720 VA: 0x18051DD20
	private void set_aoHistoryBuffer(RenderTexture value) { }

	[CompilerGenerated]
	// RVA: 0x516260 Offset: 0x514C60 VA: 0x180516260
	private RenderTexture get_colorBleedingHistoryBuffer() { }

	[CompilerGenerated]
	// RVA: 0x505FC0 Offset: 0x5049C0 VA: 0x180505FC0
	private void set_colorBleedingHistoryBuffer(RenderTexture value) { }

	[CompilerGenerated]
	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0
	private Texture2D get_noiseTex() { }

	[CompilerGenerated]
	// RVA: 0x8937F0 Offset: 0x8921F0 VA: 0x1808937F0
	private void set_noiseTex(Texture2D value) { }

	// RVA: 0x1A3A470 Offset: 0x1A38E70 VA: 0x181A3A470
	private Mesh get_fullscreenTriangle() { }

	// RVA: 0x1A3A3A0 Offset: 0x1A38DA0 VA: 0x181A3A3A0
	private CameraEvent get_cameraEvent() { }

	// RVA: 0x1A3A820 Offset: 0x1A39220 VA: 0x181A3A820
	private bool get_isCommandBufferDirty() { }

	// RVA: 0x618110 Offset: 0x616B10 VA: 0x180618110
	private void set_isCommandBufferDirty(bool value) { }

	// RVA: 0x1A3ABE0 Offset: 0x1A395E0 VA: 0x181A3ABE0
	private bool get_isHistoryBufferDirty() { }

	// RVA: 0x57A490 Offset: 0x578E90 VA: 0x18057A490
	private static RenderTextureFormat get_defaultHDRRenderTextureFormat() { }

	// RVA: 0x1A3ADB0 Offset: 0x1A397B0 VA: 0x181A3ADB0
	private RenderTextureFormat get_sourceFormat() { }

	// RVA: 0x1A3A410 Offset: 0x1A38E10 VA: 0x181A3A410
	private static RenderTextureFormat get_colorFormat() { }

	// RVA: 0x1A3A450 Offset: 0x1A38E50 VA: 0x181A3A450
	private static RenderTextureFormat get_depthFormat() { }

	// RVA: 0x1A3AD50 Offset: 0x1A39750 VA: 0x181A3AD50
	private static RenderTextureFormat get_normalsFormat() { }

	// RVA: 0x699ED0 Offset: 0x6988D0 VA: 0x180699ED0
	private static bool get_isLinearColorSpace() { }

	// RVA: 0x1A3AD70 Offset: 0x1A39770 VA: 0x181A3AD70
	private bool get_renderingInSceneView() { }

	// RVA: 0x1A376D0 Offset: 0x1A360D0 VA: 0x181A376D0
	private void OnEnable() { }

	// RVA: 0x1A37570 Offset: 0x1A35F70 VA: 0x181A37570
	private void OnDisable() { }

	// RVA: 0x1A37A30 Offset: 0x1A36430 VA: 0x181A37A30
	private void OnPreRender() { }

	// RVA: 0x1A37A20 Offset: 0x1A36420 VA: 0x181A37A20
	private void OnPostRender() { }

	// RVA: 0x1A37B70 Offset: 0x1A36570 VA: 0x181A37B70
	private void OnValidate() { }

	// RVA: 0x1A373B0 Offset: 0x1A35DB0 VA: 0x181A373B0
	private void Initialize() { }

	// RVA: 0x1A36D60 Offset: 0x1A35760 VA: 0x181A36D60
	private void FetchRenderParameters() { }

	// RVA: 0x1A32590 Offset: 0x1A30F90 VA: 0x181A32590
	private void AllocateHistoryBuffers() { }

	// RVA: 0x1A37C10 Offset: 0x1A36610 VA: 0x181A37C10
	private void ReleaseHistoryBuffers() { }

	// RVA: 0x1A33CA0 Offset: 0x1A326A0 VA: 0x181A33CA0
	private void ClearCommandBuffer(CommandBuffer cmd) { }

	// RVA: 0x1A33520 Offset: 0x1A31F20 VA: 0x181A33520
	private void BuildCommandBuffer(CommandBuffer cmd, CameraEvent cameraEvent) { }

	// RVA: 0x1A32360 Offset: 0x1A30D60 VA: 0x181A32360
	private void AO(CommandBuffer cmd) { }

	// RVA: 0x1A35AB0 Offset: 0x1A344B0 VA: 0x181A35AB0
	private void DeinterleavedAO(CommandBuffer cmd) { }

	// RVA: 0x1A32F00 Offset: 0x1A31900 VA: 0x181A32F00
	private void Blur(CommandBuffer cmd) { }

	// RVA: 0x1A37F50 Offset: 0x1A36950 VA: 0x181A37F50
	private void TemporalFilter(CommandBuffer cmd) { }

	// RVA: 0x1A35610 Offset: 0x1A34010 VA: 0x181A35610
	private void Composite(CommandBuffer cmd, CameraEvent cameraEvent) { }

	// RVA: 0x1A34970 Offset: 0x1A33370 VA: 0x181A34970
	private void CompositeBeforeReflections(CommandBuffer cmd) { }

	// RVA: 0x1A33D80 Offset: 0x1A32780 VA: 0x181A33D80
	private void CompositeAfterLighting(CommandBuffer cmd) { }

	// RVA: 0x1A34240 Offset: 0x1A32C40 VA: 0x181A34240
	private void CompositeBeforeImageEffectsOpaque(CommandBuffer cmd) { }

	// RVA: 0x1A34FA0 Offset: 0x1A339A0 VA: 0x181A34FA0
	private void CompositeDebug(CommandBuffer cmd, int finalPassId = 9) { }

	// RVA: 0x1A38900 Offset: 0x1A37300 VA: 0x181A38900
	private void UpdateMaterialProperties() { }

	// RVA: 0x1A398C0 Offset: 0x1A382C0 VA: 0x181A398C0
	private void UpdateShaderKeywords() { }

	// RVA: 0x1A33990 Offset: 0x1A32390 VA: 0x181A33990
	private void CheckParameters() { }

	// RVA: 0x1A36FE0 Offset: 0x1A359E0 VA: 0x181A36FE0
	private RenderTextureDescriptor GetDefaultDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0) { }

	// RVA: 0x1A371A0 Offset: 0x1A35BA0 VA: 0x181A371A0
	private RenderTexture GetScreenSpaceRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, FilterMode filter = 1, int widthOverride = 0, int heightOverride = 0) { }

	// RVA: 0x1A372D0 Offset: 0x1A35CD0 VA: 0x181A372D0
	private void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, FilterMode filter = 1, int widthOverride = 0, int heightOverride = 0) { }

	// RVA: 0x1A37CD0 Offset: 0x1A366D0 VA: 0x181A37CD0
	private void ReleaseTemporaryRT(CommandBuffer cmd, int nameID) { }

	// RVA: 0x1A32BC0 Offset: 0x1A315C0 VA: 0x181A32BC0
	private void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass = 0) { }

	// RVA: 0x1A32D50 Offset: 0x1A31750 VA: 0x181A32D50
	private void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, Material material, int pass = 0) { }

	// RVA: 0x1A32A10 Offset: 0x1A31410 VA: 0x181A32A10
	private void BlitFullscreenTriangleWithClear(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, Color clearColor, int pass = 0) { }

	// RVA: 0x1A32790 Offset: 0x1A31190 VA: 0x181A32790
	private static void ApplyFlip(CommandBuffer cmd, bool flip = True) { }

	// RVA: 0x1A324A0 Offset: 0x1A30EA0 VA: 0x181A324A0
	private static Vector2 AdjustBrightnessMaskToGammaSpace(Vector2 v) { }

	// RVA: 0x1A38870 Offset: 0x1A37270 VA: 0x181A38870
	private static float ToGammaSpace(float v) { }

	// RVA: 0x1A38880 Offset: 0x1A37280 VA: 0x181A38880
	private static Vector2 ToGammaSpace(Vector2 v) { }

	// RVA: 0x1A35690 Offset: 0x1A34090 VA: 0x181A35690
	private void CreateNoiseTexture() { }

	// RVA: 0x1A3A1D0 Offset: 0x1A38BD0 VA: 0x181A3A1D0
	public void .ctor() { }

	// RVA: 0x1A3A090 Offset: 0x1A38A90 VA: 0x181A3A090
	private static void .cctor() { }
}
