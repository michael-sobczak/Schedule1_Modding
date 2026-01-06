public class DynamicResolutionHandler // TypeDefIndex: 13580
{
	// Fields
	private bool m_Enabled; // 0x10
	private bool m_UseMipBias; // 0x11
	private float m_MinScreenFraction; // 0x14
	private float m_MaxScreenFraction; // 0x18
	private float m_CurrentFraction; // 0x1C
	private bool m_ForcingRes; // 0x20
	private bool m_CurrentCameraRequest; // 0x21
	private float m_PrevFraction; // 0x24
	private bool m_ForceSoftwareFallback; // 0x28
	private bool m_RunUpscalerFilterOnFullResolution; // 0x29
	private float m_PrevHWScaleWidth; // 0x2C
	private float m_PrevHWScaleHeight; // 0x30
	private Vector2Int m_LastScaledSize; // 0x34
	private static DynamicResScalerSlot s_ActiveScalerSlot; // 0x0
	private static DynamicResolutionHandler.ScalerContainer[] s_ScalerContainers; // 0x8
	private Vector2Int cachedOriginalSize; // 0x3C
	[CompilerGenerated]
	private DynamicResUpscaleFilter <filter>k__BackingField; // 0x44
	private static Dictionary<int, DynamicResUpscaleFilter> s_CameraUpscaleFilters; // 0x10
	[CompilerGenerated]
	private Vector2Int <finalViewport>k__BackingField; // 0x48
	private DynamicResolutionType type; // 0x50
	private GlobalDynamicResolutionSettings m_CachedSettings; // 0x54
	private const int CameraDictionaryMaxcCapacity = 32;
	private WeakReference m_OwnerCameraWeakRef; // 0x90
	private static Dictionary<int, DynamicResolutionHandler> s_CameraInstances; // 0x18
	private static DynamicResolutionHandler s_DefaultInstance; // 0x20
	private static int s_ActiveCameraId; // 0x28
	private static DynamicResolutionHandler s_ActiveInstance; // 0x30
	private static bool s_ActiveInstanceDirty; // 0x38
	private static float s_GlobalHwFraction; // 0x3C
	private static bool s_GlobalHwUpresActive; // 0x40
	private DynamicResolutionHandler.UpsamplerScheduleType m_UpsamplerSchedule; // 0x98

	// Properties
	public DynamicResUpscaleFilter filter { get; set; }
	public Vector2Int finalViewport { get; set; }
	public bool runUpscalerFilterOnFullResolution { get; set; }
	public DynamicResolutionHandler.UpsamplerScheduleType upsamplerSchedule { get; set; }
	public static DynamicResolutionHandler instance { get; }

	// Methods

	// RVA: 0x29F30F0 Offset: 0x29F1AF0 VA: 0x1829F30F0
	private void Reset() { }

	[CompilerGenerated]
	// RVA: 0x495FF0 Offset: 0x4949F0 VA: 0x180495FF0
	public DynamicResUpscaleFilter get_filter() { }

	[CompilerGenerated]
	// RVA: 0x200E0A0 Offset: 0x200CAA0 VA: 0x18200E0A0
	private void set_filter(DynamicResUpscaleFilter value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public Vector2Int get_finalViewport() { }

	[CompilerGenerated]
	// RVA: 0xCC6410 Offset: 0xCC4E10 VA: 0x180CC6410
	public void set_finalViewport(Vector2Int value) { }

	// RVA: 0x5A9D20 Offset: 0x5A8720 VA: 0x1805A9D20
	public void set_runUpscalerFilterOnFullResolution(bool value) { }

	// RVA: 0x29F3F10 Offset: 0x29F2910 VA: 0x1829F3F10
	public bool get_runUpscalerFilterOnFullResolution() { }

	// RVA: 0x29F2400 Offset: 0x29F0E00 VA: 0x1829F2400
	private bool FlushScalableBufferManagerState() { }

	// RVA: 0x29F2730 Offset: 0x29F1130 VA: 0x1829F2730
	private static DynamicResolutionHandler GetOrCreateDrsInstanceHandler(Camera camera) { }

	// RVA: 0x4B7090 Offset: 0x4B5A90 VA: 0x1804B7090
	public void set_upsamplerSchedule(DynamicResolutionHandler.UpsamplerScheduleType value) { }

	// RVA: 0x4B62D0 Offset: 0x4B4CD0 VA: 0x1804B62D0
	public DynamicResolutionHandler.UpsamplerScheduleType get_upsamplerSchedule() { }

	// RVA: 0x29F3EC0 Offset: 0x29F28C0 VA: 0x1829F3EC0
	public static DynamicResolutionHandler get_instance() { }

	// RVA: 0x29F3DB0 Offset: 0x29F27B0 VA: 0x1829F3DB0
	private void .ctor() { }

	// RVA: 0x718A60 Offset: 0x717460 VA: 0x180718A60
	private static float DefaultDynamicResMethod() { }

	// RVA: 0x29F2EB0 Offset: 0x29F18B0 VA: 0x1829F2EB0
	private void ProcessSettings(GlobalDynamicResolutionSettings settings) { }

	// RVA: 0x29F2C60 Offset: 0x29F1660 VA: 0x1829F2C60
	public Vector2 GetResolvedScale() { }

	// RVA: 0x29F22A0 Offset: 0x29F0CA0 VA: 0x1829F22A0
	public float CalculateMipBias(Vector2Int inputResolution, Vector2Int outputResolution, bool forceApply = False) { }

	// RVA: 0x29F31A0 Offset: 0x29F1BA0 VA: 0x1829F31A0
	public static void SetDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = 1) { }

	// RVA: 0x29F3260 Offset: 0x29F1C60 VA: 0x1829F3260
	public static void SetSystemDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = 1) { }

	// RVA: 0x29F3140 Offset: 0x29F1B40 VA: 0x1829F3140
	public static void SetActiveDynamicScalerSlot(DynamicResScalerSlot slot) { }

	// RVA: 0x29F2340 Offset: 0x29F0D40 VA: 0x1829F2340
	public static void ClearSelectedCamera() { }

	// RVA: 0x29F3320 Offset: 0x29F1D20 VA: 0x1829F3320
	public static void SetUpscaleFilter(Camera camera, DynamicResUpscaleFilter filter) { }

	// RVA: 0x563DA0 Offset: 0x5627A0 VA: 0x180563DA0
	public void SetCurrentCameraRequest(bool cameraRequest) { }

	// RVA: 0x29F34A0 Offset: 0x29F1EA0 VA: 0x1829F34A0
	public static void UpdateAndUseCamera(Camera camera, Nullable<GlobalDynamicResolutionSettings> settings, Action OnResolutionChange) { }

	// RVA: 0x29F36D0 Offset: 0x29F20D0 VA: 0x1829F36D0
	public void Update(GlobalDynamicResolutionSettings settings, Action OnResolutionChange) { }

	// RVA: 0x29F3460 Offset: 0x29F1E60 VA: 0x1829F3460
	public bool SoftwareDynamicResIsEnabled() { }

	// RVA: 0x29F2E90 Offset: 0x29F1890 VA: 0x1829F2E90
	public bool HardwareDynamicResIsEnabled() { }

	// RVA: 0x29F30D0 Offset: 0x29F1AD0 VA: 0x1829F30D0
	public bool RequestsHardwareDynamicResolution() { }

	// RVA: 0x29F23D0 Offset: 0x29F0DD0 VA: 0x1829F23D0
	public bool DynamicResolutionEnabled() { }

	// RVA: 0xB2DE70 Offset: 0xB2C870 VA: 0x180B2DE70
	public void ForceSoftwareFallback() { }

	// RVA: 0x29F2CD0 Offset: 0x29F16D0 VA: 0x1829F2CD0
	public Vector2Int GetScaledSize(Vector2Int size) { }

	// RVA: 0x29F1FA0 Offset: 0x29F09A0 VA: 0x1829F1FA0
	public Vector2Int ApplyScalesOnSize(Vector2Int size) { }

	// RVA: 0x29F2150 Offset: 0x29F0B50 VA: 0x1829F2150
	internal Vector2Int ApplyScalesOnSize(Vector2Int size, Vector2 scales) { }

	// RVA: 0x29F2560 Offset: 0x29F0F60 VA: 0x1829F2560
	public float GetCurrentScale() { }

	// RVA: 0x29F2580 Offset: 0x29F0F80 VA: 0x1829F2580
	public Vector2Int GetLastScaledSize() { }

	// RVA: 0x29F2660 Offset: 0x29F1060 VA: 0x1829F2660
	public float GetLowResMultiplier(float targetLowRes) { }

	// RVA: 0x29F2590 Offset: 0x29F0F90 VA: 0x1829F2590
	public float GetLowResMultiplier(float targetLowRes, float minimumThreshold) { }

	// RVA: 0x29F39C0 Offset: 0x29F23C0 VA: 0x1829F39C0
	private static void .cctor() { }
}
