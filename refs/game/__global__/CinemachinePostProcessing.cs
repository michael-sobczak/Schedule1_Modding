public class CinemachinePostProcessing : CinemachineExtension // TypeDefIndex: 16252
{
	// Fields
	public static float s_VolumePriority; // 0x0
	[HideInInspector]
	public bool m_FocusTracksTarget; // 0x30
	[Tooltip("If the profile has the appropriate overrides, will set the base focus distance to be the distance from the selected target to the camera.The Focus Offset field will then modify that distance.")]
	public CinemachinePostProcessing.FocusTrackingMode m_FocusTracking; // 0x34
	[Tooltip("The target to use if Focus Tracks Target is set to Custom Target")]
	public Transform m_FocusTarget; // 0x38
	[Tooltip("Offset from target distance, to be used with Focus Tracks Target.  Offsets the sharpest point away from the location of the focus target.")]
	public float m_FocusOffset; // 0x40
	[Tooltip("This Post-Processing profile will be applied whenever this virtual camera is live")]
	public PostProcessProfile m_Profile; // 0x48
	private static string sVolumeOwnerName; // 0x8
	private static List<PostProcessVolume> sVolumes; // 0x10
	private static Dictionary<CinemachineBrain, PostProcessLayer> mBrainToLayer; // 0x18

	// Properties
	public bool IsValid { get; }

	// Methods

	// RVA: 0xC43E40 Offset: 0xC42840 VA: 0x180C43E40
	public bool get_IsValid() { }

	// RVA: 0xC435E0 Offset: 0xC41FE0 VA: 0x180C435E0
	public void InvalidateCachedProfile() { }

	// RVA: 0xC43880 Offset: 0xC42280 VA: 0x180C43880 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0xC437D0 Offset: 0xC421D0 VA: 0x180C437D0 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0xC43930 Offset: 0xC42330 VA: 0x180C43930 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0xC43730 Offset: 0xC42130 VA: 0x180C43730
	private static void OnCameraCut(CinemachineBrain brain) { }

	// RVA: 0xC426A0 Offset: 0xC410A0 VA: 0x180C426A0
	private static void ApplyPostFX(CinemachineBrain brain) { }

	// RVA: 0xC42CE0 Offset: 0xC416E0 VA: 0x180C42CE0
	private static List<PostProcessVolume> GetDynamicBrainVolumes(CinemachineBrain brain, PostProcessLayer ppLayer, int minVolumes) { }

	// RVA: 0xC43110 Offset: 0xC41B10 VA: 0x180C43110
	private static PostProcessLayer GetPPLayer(CinemachineBrain brain) { }

	// RVA: 0xC42AE0 Offset: 0xC414E0 VA: 0x180C42AE0
	private static void CleanupLookupTable() { }

	[RuntimeInitializeOnLoadMethod]
	// RVA: 0xC433D0 Offset: 0xC41DD0 VA: 0x180C433D0
	private static void InitializeModule() { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	public void .ctor() { }

	// RVA: 0xC43CF0 Offset: 0xC426F0 VA: 0x180C43CF0
	private static void .cctor() { }
}
