public class CinemachineVolumeSettings : CinemachineExtension // TypeDefIndex: 16255
{
	// Fields
	public static float s_VolumePriority; // 0x0
	[HideInInspector]
	public bool m_FocusTracksTarget; // 0x30
	[Tooltip("If the profile has the appropriate overrides, will set the base focus distance to be the distance from the selected target to the camera.The Focus Offset field will then modify that distance.")]
	public CinemachineVolumeSettings.FocusTrackingMode m_FocusTracking; // 0x34
	[Tooltip("The target to use if Focus Tracks Target is set to Custom Target")]
	public Transform m_FocusTarget; // 0x38
	[Tooltip("Offset from target distance, to be used with Focus Tracks Target.  Offsets the sharpest point away from the focus target.")]
	public float m_FocusOffset; // 0x40
	[Tooltip("This profile will be applied whenever this virtual camera is live")]
	public VolumeProfile m_Profile; // 0x48
	private static string sVolumeOwnerName; // 0x8
	private static List<Volume> sVolumes; // 0x10

	// Properties
	public bool IsValid { get; }

	// Methods

	// RVA: 0xC45080 Offset: 0xC43A80 VA: 0x180C45080
	public bool get_IsValid() { }

	// RVA: 0xC44910 Offset: 0xC43310 VA: 0x180C44910
	public void InvalidateCachedProfile() { }

	// RVA: 0xC44B10 Offset: 0xC43510 VA: 0x180C44B10 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0xC44A60 Offset: 0xC43460 VA: 0x180C44A60 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0xC44BC0 Offset: 0xC435C0 VA: 0x180C44BC0 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void OnCameraCut(CinemachineBrain brain) { }

	// RVA: 0xC43EE0 Offset: 0xC428E0 VA: 0x180C43EE0
	private static void ApplyPostFX(CinemachineBrain brain) { }

	// RVA: 0xC442B0 Offset: 0xC42CB0 VA: 0x180C442B0
	private static List<Volume> GetDynamicBrainVolumes(CinemachineBrain brain, int minVolumes) { }

	[RuntimeInitializeOnLoadMethod]
	// RVA: 0xC44740 Offset: 0xC43140 VA: 0x180C44740
	private static void InitializeModule() { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	public void .ctor() { }

	// RVA: 0xC44FA0 Offset: 0xC439A0 VA: 0x180C44FA0
	private static void .cctor() { }
}
