public class CinemachineBrain : MonoBehaviour, ICameraOverrideStack // TypeDefIndex: 16046
{
	// Fields
	[Tooltip("When enabled, the current camera and blend will be indicated in the game window, for debugging")]
	public bool m_ShowDebugText; // 0x20
	[Tooltip("When enabled, the camera's frustum will be shown at all times in the scene view")]
	public bool m_ShowCameraFrustum; // 0x21
	[Tooltip("When enabled, the cameras will always respond in real-time to user input and damping, even if the game is running in slow motion")]
	public bool m_IgnoreTimeScale; // 0x22
	[Tooltip("If set, this object's Y axis will define the worldspace Up vector for all the virtual cameras.  This is useful for instance in top-down game environments.  If not set, Up is worldspace Y.  Setting this appropriately is important, because Virtual Cameras don't like looking straight up or straight down.")]
	public Transform m_WorldUpOverride; // 0x28
	[Tooltip("The update time for the vcams.  Use FixedUpdate if all your targets are animated during FixedUpdate (e.g. RigidBodies), LateUpdate if all your targets are animated during the normal Update loop, and SmartUpdate if you want Cinemachine to do the appropriate thing on a per-target basis.  SmartUpdate is the recommended setting")]
	public CinemachineBrain.UpdateMethod m_UpdateMethod; // 0x30
	[Tooltip("The update time for the Brain, i.e. when the blends are evaluated and the brain's transform is updated")]
	public CinemachineBrain.BrainUpdateMethod m_BlendUpdateMethod; // 0x34
	[Tooltip("The blend that is used in cases where you haven't explicitly defined a blend between two Virtual Cameras")]
	[CinemachineBlendDefinitionProperty]
	public CinemachineBlendDefinition m_DefaultBlend; // 0x38
	[Tooltip("This is the asset that contains custom settings for blends between specific virtual cameras in your scene")]
	public CinemachineBlenderSettings m_CustomBlends; // 0x48
	private Camera m_OutputCamera; // 0x50
	private GameObject m_TargetOverride; // 0x58
	[Tooltip("This event will fire whenever a virtual camera goes live and there is no blend")]
	public CinemachineBrain.BrainEvent m_CameraCutEvent; // 0x60
	[Tooltip("This event will fire whenever a virtual camera goes live.  If a blend is involved, then the event will fire on the first frame of the blend.")]
	public CinemachineBrain.VcamActivatedEvent m_CameraActivatedEvent; // 0x68
	private static ICinemachineCamera mSoloCamera; // 0x0
	private Coroutine mPhysicsCoroutine; // 0x70
	private int m_LastFrameUpdated; // 0x78
	private WaitForFixedUpdate mWaitForFixedUpdate; // 0x80
	private List<CinemachineBrain.BrainFrame> mFrameStack; // 0x88
	private int mNextFrameId; // 0x90
	private CinemachineBlend mCurrentLiveCameras; // 0x98
	private static readonly AnimationCurve mDefaultLinearAnimationCurve; // 0x8
	private ICinemachineCamera mActiveCameraPreviousFrame; // 0xA0
	private GameObject mActiveCameraPreviousFrameGameObject; // 0xA8
	[CompilerGenerated]
	private CameraState <CurrentCameraState>k__BackingField; // 0xB0

	// Properties
	public Camera OutputCamera { get; }
	public GameObject ControlledObject { get; set; }
	public static ICinemachineCamera SoloCamera { get; set; }
	public Vector3 DefaultWorldUp { get; }
	public ICinemachineCamera ActiveVirtualCamera { get; }
	public bool IsBlending { get; }
	public CinemachineBlend ActiveBlend { get; set; }
	public CameraState CurrentCameraState { get; set; }

	// Methods

	// RVA: 0xBE0660 Offset: 0xBDF060 VA: 0x180BE0660
	public Camera get_OutputCamera() { }

	// RVA: 0xBE0440 Offset: 0xBDEE40 VA: 0x180BE0440
	public GameObject get_ControlledObject() { }

	// RVA: 0xBE0810 Offset: 0xBDF210 VA: 0x180BE0810
	public void set_ControlledObject(GameObject value) { }

	// RVA: 0xBE0730 Offset: 0xBDF130 VA: 0x180BE0730
	public static ICinemachineCamera get_SoloCamera() { }

	// RVA: 0xBE0940 Offset: 0xBDF340 VA: 0x180BE0940
	public static void set_SoloCamera(ICinemachineCamera value) { }

	// RVA: 0xBDD220 Offset: 0xBDBC20 VA: 0x180BDD220
	public static Color GetSoloGUIColor() { }

	// RVA: 0xBE0560 Offset: 0xBDEF60 VA: 0x180BE0560 Slot: 6
	public Vector3 get_DefaultWorldUp() { }

	// RVA: 0xBDDBC0 Offset: 0xBDC5C0 VA: 0x180BDDBC0
	private void OnEnable() { }

	// RVA: 0xBDD960 Offset: 0xBDC360 VA: 0x180BDD960
	private void OnDisable() { }

	// RVA: 0xBDE2E0 Offset: 0xBDCCE0 VA: 0x180BDE2E0
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0xBDE340 Offset: 0xBDCD40 VA: 0x180BDE340
	private void OnSceneUnloaded(Scene scene) { }

	// RVA: 0xBDC8F0 Offset: 0xBDB2F0 VA: 0x180BDC8F0
	private void Awake() { }

	// RVA: 0xBDF2D0 Offset: 0xBDDCD0 VA: 0x180BDF2D0
	private void Start() { }

	// RVA: 0xBDDF90 Offset: 0xBDC990 VA: 0x180BDDF90
	private void OnGuiHandler() { }

	[IteratorStateMachine(typeof(CinemachineBrain.<AfterPhysics>d__38))]
	// RVA: 0xBDC880 Offset: 0xBDB280 VA: 0x180BDC880
	private IEnumerator AfterPhysics() { }

	// RVA: 0xBDD540 Offset: 0xBDBF40 VA: 0x180BDD540
	private void LateUpdate() { }

	// RVA: 0xBDD730 Offset: 0xBDC130 VA: 0x180BDD730
	public void ManualUpdate() { }

	// RVA: 0xBDD000 Offset: 0xBDBA00 VA: 0x180BDD000
	private float GetEffectiveDeltaTime(bool fixedDelta) { }

	// RVA: 0xBDFBC0 Offset: 0xBDE5C0 VA: 0x180BDFBC0
	private void UpdateVirtualCameras(CinemachineCore.UpdateFilter updateFilter, float deltaTime) { }

	// RVA: 0xBE0290 Offset: 0xBDEC90 VA: 0x180BE0290
	public ICinemachineCamera get_ActiveVirtualCamera() { }

	// RVA: 0xBDCE30 Offset: 0xBDB830 VA: 0x180BDCE30
	private static ICinemachineCamera DeepCamBFromBlend(CinemachineBlend blend) { }

	// RVA: 0xBDD240 Offset: 0xBDBC40 VA: 0x180BDD240
	public bool IsLiveInBlend(ICinemachineCamera vcam) { }

	// RVA: 0xBE0640 Offset: 0xBDF040 VA: 0x180BE0640
	public bool get_IsBlending() { }

	// RVA: 0xBE01B0 Offset: 0xBDEBB0 VA: 0x180BE01B0
	public CinemachineBlend get_ActiveBlend() { }

	// RVA: 0xBE0780 Offset: 0xBDF180 VA: 0x180BE0780
	public void set_ActiveBlend(CinemachineBlend value) { }

	// RVA: 0xBDCEE0 Offset: 0xBDB8E0 VA: 0x180BDCEE0
	private int GetBrainFrame(int withId) { }

	// RVA: 0xBDEF70 Offset: 0xBDD970 VA: 0x180BDEF70 Slot: 4
	public int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime) { }

	// RVA: 0xBDEEA0 Offset: 0xBDD8A0 VA: 0x180BDEEA0 Slot: 5
	public void ReleaseCameraOverride(int overrideId) { }

	// RVA: 0xBDE3A0 Offset: 0xBDCDA0 VA: 0x180BDE3A0
	private void ProcessActiveCamera(float deltaTime) { }

	// RVA: 0xBDF490 Offset: 0xBDDE90 VA: 0x180BDF490
	private void UpdateFrame0(float deltaTime) { }

	// RVA: 0xBDC950 Offset: 0xBDB350 VA: 0x180BDC950
	public void ComputeCurrentBlend(ref CinemachineBlend outputBlend, int numTopLayersToExclude) { }

	// RVA: 0xBDD370 Offset: 0xBDBD70 VA: 0x180BDD370
	public bool IsLive(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	[CompilerGenerated]
	// RVA: 0xBE04C0 Offset: 0xBDEEC0 VA: 0x180BE04C0
	public CameraState get_CurrentCameraState() { }

	[CompilerGenerated]
	// RVA: 0xBE0890 Offset: 0xBDF290 VA: 0x180BE0890
	private void set_CurrentCameraState(CameraState value) { }

	// RVA: 0xBDF2F0 Offset: 0xBDDCF0 VA: 0x180BDF2F0 Slot: 7
	protected virtual ICinemachineCamera TopCameraFromPriorityQueue() { }

	// RVA: 0xBDD550 Offset: 0xBDBF50 VA: 0x180BDD550
	private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) { }

	// RVA: 0xBDE9D0 Offset: 0xBDD3D0 VA: 0x180BDE9D0
	private void PushStateToUnityCamera(ref CameraState state) { }

	// RVA: 0xBDFFA0 Offset: 0xBDE9A0 VA: 0x180BDFFA0
	public void .ctor() { }

	// RVA: 0xBDFF30 Offset: 0xBDE930 VA: 0x180BDFF30
	private static void .cctor() { }
}
