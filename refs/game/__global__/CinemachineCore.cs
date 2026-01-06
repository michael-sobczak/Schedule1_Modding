public sealed class CinemachineCore // TypeDefIndex: 16143
{
	// Fields
	public static readonly int kStreamingVersion; // 0x0
	private static CinemachineCore sInstance; // 0x8
	public static bool sShowHiddenObjects; // 0x10
	public static CinemachineCore.AxisInputDelegate GetInputAxis; // 0x18
	public static float UniformDeltaTimeOverride; // 0x20
	public static float CurrentTimeOverride; // 0x24
	public static CinemachineCore.GetBlendOverrideDelegate GetBlendOverride; // 0x28
	public static CinemachineBrain.BrainEvent CameraUpdatedEvent; // 0x30
	public static CinemachineBrain.BrainEvent CameraCutEvent; // 0x38
	private List<CinemachineBrain> mActiveBrains; // 0x10
	internal static bool FrameDeltaCompensationEnabled; // 0x40
	private List<CinemachineVirtualCameraBase> mActiveCameras; // 0x18
	private bool m_ActiveCamerasAreSorted; // 0x20
	private int m_ActivationSequence; // 0x24
	private List<List<CinemachineVirtualCameraBase>> mAllCameras; // 0x28
	private CinemachineVirtualCameraBase mRoundRobinVcamLastFrame; // 0x30
	private static float s_LastUpdateTime; // 0x44
	private static int s_FixedFrameCount; // 0x48
	private Dictionary<CinemachineVirtualCameraBase, CinemachineCore.UpdateStatus> mUpdateStatus; // 0x38
	internal CinemachineCore.UpdateFilter m_CurrentUpdateFilter; // 0x40

	// Properties
	public static CinemachineCore Instance { get; }
	public static float DeltaTime { get; }
	public static float CurrentTime { get; }
	public int BrainCount { get; }
	public int VirtualCameraCount { get; }

	// Methods

	// RVA: 0xC19B60 Offset: 0xC18560 VA: 0x180C19B60
	public static CinemachineCore get_Instance() { }

	// RVA: 0xC19AD0 Offset: 0xC184D0 VA: 0x180C19AD0
	public static float get_DeltaTime() { }

	// RVA: 0xC19A40 Offset: 0xC18440 VA: 0x180C19A40
	public static float get_CurrentTime() { }

	// RVA: 0xC19A00 Offset: 0xC18400 VA: 0x180C19A00
	public int get_BrainCount() { }

	// RVA: 0xC181D0 Offset: 0xC16BD0 VA: 0x180C181D0
	public CinemachineBrain GetActiveBrain(int index) { }

	// RVA: 0xC17620 Offset: 0xC16020 VA: 0x180C17620
	internal void AddActiveBrain(CinemachineBrain brain) { }

	// RVA: 0xC18A90 Offset: 0xC17490 VA: 0x180C18A90
	internal void RemoveActiveBrain(CinemachineBrain brain) { }

	// RVA: 0xC19D40 Offset: 0xC18740 VA: 0x180C19D40
	public int get_VirtualCameraCount() { }

	// RVA: 0xC18410 Offset: 0xC16E10 VA: 0x180C18410
	public CinemachineVirtualCameraBase GetVirtualCamera(int index) { }

	// RVA: 0xC176B0 Offset: 0xC160B0 VA: 0x180C176B0
	internal void AddActiveCamera(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0xC18AF0 Offset: 0xC174F0 VA: 0x180C18AF0
	internal void RemoveActiveCamera(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0xC17780 Offset: 0xC16180 VA: 0x180C17780
	internal void CameraDestroyed(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0xC17950 Offset: 0xC16350 VA: 0x180C17950
	internal void CameraEnabled(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0xC17850 Offset: 0xC16250 VA: 0x180C17850
	internal void CameraDisabled(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0xC18B70 Offset: 0xC17570 VA: 0x180C18B70
	internal void UpdateAllActiveVirtualCameras(int layerMask, Vector3 worldUp, float deltaTime) { }

	// RVA: 0xC18F80 Offset: 0xC17980 VA: 0x180C18F80
	internal void UpdateVirtualCamera(CinemachineVirtualCameraBase vcam, Vector3 worldUp, float deltaTime) { }

	[RuntimeInitializeOnLoadMethod]
	// RVA: 0xC185A0 Offset: 0xC16FA0 VA: 0x180C185A0
	private static void InitializeModule() { }

	// RVA: 0xC18230 Offset: 0xC16C30 VA: 0x180C18230
	private static Transform GetUpdateTarget(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0xC18380 Offset: 0xC16D80 VA: 0x180C18380
	internal UpdateTracker.UpdateClock GetVcamUpdateStatus(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0xC18750 Offset: 0xC17150 VA: 0x180C18750
	public bool IsLive(ICinemachineCamera vcam) { }

	// RVA: 0xC18640 Offset: 0xC17040 VA: 0x180C18640
	public bool IsLiveInBlend(ICinemachineCamera vcam) { }

	// RVA: 0xC17ED0 Offset: 0xC168D0 VA: 0x180C17ED0
	public void GenerateCameraActivationEvent(ICinemachineCamera vcam, ICinemachineCamera vcamFrom) { }

	// RVA: 0xC18020 Offset: 0xC16A20 VA: 0x180C18020
	public void GenerateCameraCutEvent(ICinemachineCamera vcam) { }

	// RVA: 0xC17C30 Offset: 0xC16630 VA: 0x180C17C30
	public CinemachineBrain FindPotentialTargetBrain(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0xC18870 Offset: 0xC17270 VA: 0x180C18870
	public void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0xC198F0 Offset: 0xC182F0 VA: 0x180C198F0
	public void .ctor() { }

	// RVA: 0xC196A0 Offset: 0xC180A0 VA: 0x180C196A0
	private static void .cctor() { }
}
