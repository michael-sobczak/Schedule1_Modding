public class UniversalAdditionalCameraData : MonoBehaviour, ISerializationCallbackReceiver, IAdditionalData // TypeDefIndex: 9044
{
	// Fields
	private const string k_GizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/";
	private const string k_BaseCameraGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_Base.png";
	private const string k_OverlayCameraGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_Base.png";
	private const string k_PostProcessingGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_PostProcessing.png";
	[FormerlySerializedAs("renderShadows")]
	[SerializeField]
	private bool m_RenderShadows; // 0x20
	[SerializeField]
	private CameraOverrideOption m_RequiresDepthTextureOption; // 0x24
	[SerializeField]
	private CameraOverrideOption m_RequiresOpaqueTextureOption; // 0x28
	[SerializeField]
	private CameraRenderType m_CameraType; // 0x2C
	[SerializeField]
	private List<Camera> m_Cameras; // 0x30
	[SerializeField]
	private int m_RendererIndex; // 0x38
	[SerializeField]
	private LayerMask m_VolumeLayerMask; // 0x3C
	[SerializeField]
	private Transform m_VolumeTrigger; // 0x40
	[SerializeField]
	private VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateModeOption; // 0x48
	[SerializeField]
	private bool m_RenderPostProcessing; // 0x4C
	[SerializeField]
	private AntialiasingMode m_Antialiasing; // 0x50
	[SerializeField]
	private AntialiasingQuality m_AntialiasingQuality; // 0x54
	[SerializeField]
	private bool m_StopNaN; // 0x58
	[SerializeField]
	private bool m_Dithering; // 0x59
	[SerializeField]
	private bool m_ClearDepth; // 0x5A
	[SerializeField]
	private bool m_AllowXRRendering; // 0x5B
	[SerializeField]
	private bool m_AllowHDROutput; // 0x5C
	[SerializeField]
	private bool m_UseScreenCoordOverride; // 0x5D
	[SerializeField]
	private Vector4 m_ScreenSizeOverride; // 0x60
	[SerializeField]
	private Vector4 m_ScreenCoordScaleBias; // 0x70
	private Camera m_Camera; // 0x80
	[FormerlySerializedAs("requiresDepthTexture")]
	[SerializeField]
	private bool m_RequiresDepthTexture; // 0x88
	[FormerlySerializedAs("requiresColorTexture")]
	[SerializeField]
	private bool m_RequiresColorTexture; // 0x89
	[HideInInspector]
	[SerializeField]
	private float m_Version; // 0x8C
	private MotionVectorsPersistentData m_MotionVectorsPersistentData; // 0x90
	private TaaPersistentData m_TaaPersistentData; // 0x98
	[SerializeField]
	internal TemporalAA.Settings m_TaaSettings; // 0xA0
	private static UniversalAdditionalCameraData s_DefaultAdditionalCameraData; // 0x0
	private static List<VolumeStack> s_CachedVolumeStacks; // 0x8
	private VolumeStack m_VolumeStack; // 0xC0

	// Properties
	public float version { get; }
	internal static UniversalAdditionalCameraData defaultAdditionalCameraData { get; }
	internal Camera camera { get; }
	public bool renderShadows { get; set; }
	public CameraOverrideOption requiresDepthOption { get; set; }
	public CameraOverrideOption requiresColorOption { get; set; }
	public CameraRenderType renderType { get; set; }
	public List<Camera> cameraStack { get; }
	public bool clearDepth { get; }
	public bool requiresDepthTexture { get; set; }
	public bool requiresColorTexture { get; set; }
	public ScriptableRenderer scriptableRenderer { get; }
	public LayerMask volumeLayerMask { get; set; }
	public Transform volumeTrigger { get; set; }
	internal VolumeFrameworkUpdateMode volumeFrameworkUpdateMode { get; set; }
	public bool requiresVolumeFrameworkUpdate { get; }
	public VolumeStack volumeStack { get; set; }
	public bool renderPostProcessing { get; set; }
	public AntialiasingMode antialiasing { get; set; }
	public AntialiasingQuality antialiasingQuality { get; set; }
	public TemporalAA.Settings taaSettings { get; }
	internal TaaPersistentData taaPersistentData { get; }
	internal MotionVectorsPersistentData motionVectorsPersistentData { get; }
	public bool resetHistory { get; set; }
	public bool stopNaN { get; set; }
	public bool dithering { get; set; }
	public bool allowXRRendering { get; set; }
	public bool useScreenCoordOverride { get; set; }
	public Vector4 screenSizeOverride { get; set; }
	public Vector4 screenCoordScaleBias { get; set; }
	public bool allowHDROutput { get; set; }

	// Methods

	// RVA: 0x8D2160 Offset: 0x8D0B60 VA: 0x1808D2160
	public float get_version() { }

	// RVA: 0x2B36ED0 Offset: 0x2B358D0 VA: 0x182B36ED0
	internal static UniversalAdditionalCameraData get_defaultAdditionalCameraData() { }

	// RVA: 0x2B36E30 Offset: 0x2B35830 VA: 0x182B36E30
	internal Camera get_camera() { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_renderShadows() { }

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_renderShadows(bool value) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public CameraOverrideOption get_requiresDepthOption() { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_requiresDepthOption(CameraOverrideOption value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public CameraOverrideOption get_requiresColorOption() { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void set_requiresColorOption(CameraOverrideOption value) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public CameraRenderType get_renderType() { }

	// RVA: 0x65E020 Offset: 0x65CA20 VA: 0x18065E020
	public void set_renderType(CameraRenderType value) { }

	// RVA: 0x2B36CC0 Offset: 0x2B356C0 VA: 0x182B36CC0
	public List<Camera> get_cameraStack() { }

	// RVA: 0x2B36880 Offset: 0x2B35280 VA: 0x182B36880
	internal void UpdateCameraStack() { }

	// RVA: 0x79D120 Offset: 0x79BB20 VA: 0x18079D120
	public bool get_clearDepth() { }

	// RVA: 0x2B37150 Offset: 0x2B35B50 VA: 0x182B37150
	public bool get_requiresDepthTexture() { }

	// RVA: 0x2B37560 Offset: 0x2B35F60 VA: 0x182B37560
	public void set_requiresDepthTexture(bool value) { }

	// RVA: 0x2B370E0 Offset: 0x2B35AE0 VA: 0x182B370E0
	public bool get_requiresColorTexture() { }

	// RVA: 0x2B37540 Offset: 0x2B35F40 VA: 0x182B37540
	public void set_requiresColorTexture(bool value) { }

	// RVA: 0x2B37240 Offset: 0x2B35C40 VA: 0x182B37240
	public ScriptableRenderer get_scriptableRenderer() { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	public void SetRenderer(int index) { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	public LayerMask get_volumeLayerMask() { }

	// RVA: 0xC21CD0 Offset: 0xC206D0 VA: 0x180C21CD0
	public void set_volumeLayerMask(LayerMask value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public Transform get_volumeTrigger() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_volumeTrigger(Transform value) { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	internal VolumeFrameworkUpdateMode get_volumeFrameworkUpdateMode() { }

	// RVA: 0x4E28C0 Offset: 0x4E12C0 VA: 0x1804E28C0
	internal void set_volumeFrameworkUpdateMode(VolumeFrameworkUpdateMode value) { }

	// RVA: 0x2B371C0 Offset: 0x2B35BC0 VA: 0x182B371C0
	public bool get_requiresVolumeFrameworkUpdate() { }

	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public VolumeStack get_volumeStack() { }

	// RVA: 0x2B375C0 Offset: 0x2B35FC0 VA: 0x182B375C0
	public void set_volumeStack(VolumeStack value) { }

	// RVA: 0x2B36260 Offset: 0x2B34C60 VA: 0x182B36260
	internal void GetOrCreateVolumeStack() { }

	// RVA: 0x4B5BF0 Offset: 0x4B45F0 VA: 0x1804B5BF0
	public bool get_renderPostProcessing() { }

	// RVA: 0xAEE590 Offset: 0xAECF90 VA: 0x180AEE590
	public void set_renderPostProcessing(bool value) { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public AntialiasingMode get_antialiasing() { }

	// RVA: 0x4E28A0 Offset: 0x4E12A0 VA: 0x1804E28A0
	public void set_antialiasing(AntialiasingMode value) { }

	// RVA: 0x4C3B40 Offset: 0x4C2540 VA: 0x1804C3B40
	public AntialiasingQuality get_antialiasingQuality() { }

	// RVA: 0xD80F50 Offset: 0xD7F950 VA: 0x180D80F50
	public void set_antialiasingQuality(AntialiasingQuality value) { }

	// RVA: 0x2B37520 Offset: 0x2B35F20 VA: 0x182B37520
	public ref TemporalAA.Settings get_taaSettings() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	internal TaaPersistentData get_taaPersistentData() { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	internal MotionVectorsPersistentData get_motionVectorsPersistentData() { }

	// RVA: 0x2B37230 Offset: 0x2B35C30 VA: 0x182B37230
	public bool get_resetHistory() { }

	// RVA: 0x2B37580 Offset: 0x2B35F80 VA: 0x182B37580
	public void set_resetHistory(bool value) { }

	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	public bool get_stopNaN() { }

	// RVA: 0x4D6520 Offset: 0x4D4F20 VA: 0x1804D6520
	public void set_stopNaN(bool value) { }

	// RVA: 0x79D110 Offset: 0x79BB10 VA: 0x18079D110
	public bool get_dithering() { }

	// RVA: 0x79D240 Offset: 0x79BC40 VA: 0x18079D240
	public void set_dithering(bool value) { }

	// RVA: 0x2B36CB0 Offset: 0x2B356B0 VA: 0x182B36CB0
	public bool get_allowXRRendering() { }

	// RVA: 0x2B37530 Offset: 0x2B35F30 VA: 0x182B37530
	public void set_allowXRRendering(bool value) { }

	// RVA: 0x4CD970 Offset: 0x4CC370 VA: 0x1804CD970
	public bool get_useScreenCoordOverride() { }

	// RVA: 0xCE3D50 Offset: 0xCE2750 VA: 0x180CE3D50
	public void set_useScreenCoordOverride(bool value) { }

	// RVA: 0x1D191B0 Offset: 0x1D17BB0 VA: 0x181D191B0
	public Vector4 get_screenSizeOverride() { }

	// RVA: 0x1DA3850 Offset: 0x1DA2250 VA: 0x181DA3850
	public void set_screenSizeOverride(Vector4 value) { }

	// RVA: 0x1DA37D0 Offset: 0x1DA21D0 VA: 0x181DA37D0
	public Vector4 get_screenCoordScaleBias() { }

	// RVA: 0x1DA3840 Offset: 0x1DA2240 VA: 0x181DA3840
	public void set_screenCoordScaleBias(Vector4 value) { }

	// RVA: 0x4CD980 Offset: 0x4CC380 VA: 0x1804CD980
	public bool get_allowHDROutput() { }

	// RVA: 0xCE3D60 Offset: 0xCE2760 VA: 0x180CE3D60
	public void set_allowHDROutput(bool value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x2B36630 Offset: 0x2B35030 VA: 0x182B36630 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2B36730 Offset: 0x2B35130 VA: 0x182B36730
	public void OnDrawGizmos() { }

	// RVA: 0x2B36660 Offset: 0x2B35060 VA: 0x182B36660
	public void OnDestroy() { }

	// RVA: 0x2B36B50 Offset: 0x2B35550 VA: 0x182B36B50
	public void .ctor() { }
}
