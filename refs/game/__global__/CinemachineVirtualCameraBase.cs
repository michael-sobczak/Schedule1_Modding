public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera, ISerializationCallbackReceiver // TypeDefIndex: 16166
{
	// Fields
	[SerializeField]
	[HideInInspector]
	[NoSaveDuringPlay]
	public string[] m_ExcludedPropertiesInInspector; // 0x20
	[HideInInspector]
	[SerializeField]
	[NoSaveDuringPlay]
	public CinemachineCore.Stage[] m_LockStageInInspector; // 0x28
	private int m_ValidatingStreamVersion; // 0x30
	private bool m_OnValidateCalled; // 0x34
	[SerializeField]
	[HideInInspector]
	[NoSaveDuringPlay]
	private int m_StreamingVersion; // 0x38
	[NoSaveDuringPlay]
	[Tooltip("The priority will determine which camera becomes active based on the state of other cameras and this camera.  Higher numbers have greater priority.")]
	public int m_Priority; // 0x3C
	internal int m_ActivationId; // 0x40
	public float FollowTargetAttachment; // 0x44
	public float LookAtTargetAttachment; // 0x48
	[Tooltip("When the virtual camera is not live, this is how often the virtual camera will be updated.  Set this to tune for performance. Most of the time Never is fine, unless the virtual camera is doing shot evaluation.")]
	public CinemachineVirtualCameraBase.StandbyUpdateMode m_StandbyUpdate; // 0x4C
	[CompilerGenerated]
	private List<CinemachineExtension> <mExtensions>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <PreviousStateIsValid>k__BackingField; // 0x58
	private bool m_WasStarted; // 0x59
	private bool mSlaveStatusUpdated; // 0x5A
	private CinemachineVirtualCameraBase m_parentVcam; // 0x60
	private int m_QueuePriority; // 0x68
	private float m_blendStartPosition; // 0x6C
	private Transform m_CachedFollowTarget; // 0x70
	private CinemachineVirtualCameraBase m_CachedFollowTargetVcam; // 0x78
	private ICinemachineTargetGroup m_CachedFollowTargetGroup; // 0x80
	private Transform m_CachedLookAtTarget; // 0x88
	private CinemachineVirtualCameraBase m_CachedLookAtTargetVcam; // 0x90
	private ICinemachineTargetGroup m_CachedLookAtTargetGroup; // 0x98
	[CompilerGenerated]
	private bool <FollowTargetChanged>k__BackingField; // 0xA0
	[CompilerGenerated]
	private bool <LookAtTargetChanged>k__BackingField; // 0xA1

	// Properties
	public int ValidatingStreamVersion { get; set; }
	internal List<CinemachineExtension> mExtensions { get; set; }
	public string Name { get; }
	public virtual string Description { get; }
	public int Priority { get; set; }
	public GameObject VirtualCameraGameObject { get; }
	public bool IsValid { get; }
	public abstract CameraState State { get; }
	public ICinemachineCamera ParentCamera { get; }
	public abstract Transform LookAt { get; set; }
	public abstract Transform Follow { get; set; }
	public virtual bool PreviousStateIsValid { get; set; }
	public bool FollowTargetChanged { get; set; }
	public bool LookAtTargetChanged { get; set; }
	public ICinemachineTargetGroup AbstractFollowTargetGroup { get; }
	public CinemachineVirtualCameraBase FollowTargetAsVcam { get; }
	public ICinemachineTargetGroup AbstractLookAtTargetGroup { get; }
	public CinemachineVirtualCameraBase LookAtTargetAsVcam { get; }

	// Methods

	// RVA: 0xC21BE0 Offset: 0xC205E0 VA: 0x180C21BE0
	public int get_ValidatingStreamVersion() { }

	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	private void set_ValidatingStreamVersion(int value) { }

	// RVA: 0xC20090 Offset: 0xC1EA90 VA: 0x180C20090 Slot: 23
	public virtual float GetMaxDampTime() { }

	// RVA: 0xC1F850 Offset: 0xC1E250 VA: 0x180C1F850
	public float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0xC1F8E0 Offset: 0xC1E2E0 VA: 0x180C1F8E0
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0xC1F7A0 Offset: 0xC1E1A0 VA: 0x180C1F7A0
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	// RVA: 0xC1FC90 Offset: 0xC1E690 VA: 0x180C1FC90
	public float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0xC1FA60 Offset: 0xC1E460 VA: 0x180C1FA60
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0xC1FBE0 Offset: 0xC1E5E0 VA: 0x180C1FBE0
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	// RVA: 0xC1F010 Offset: 0xC1DA10 VA: 0x180C1F010 Slot: 24
	public virtual void AddExtension(CinemachineExtension extension) { }

	// RVA: 0xC21070 Offset: 0xC1FA70 VA: 0x180C21070 Slot: 25
	public virtual void RemoveExtension(CinemachineExtension extension) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	internal List<CinemachineExtension> get_mExtensions() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	private void set_mExtensions(List<CinemachineExtension> value) { }

	// RVA: 0xC20360 Offset: 0xC1ED60 VA: 0x180C20360
	protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime) { }

	// RVA: 0xC20590 Offset: 0xC1EF90 VA: 0x180C20590
	protected void InvokePrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState newState, float deltaTime) { }

	// RVA: 0xC201E0 Offset: 0xC1EBE0 VA: 0x180C201E0
	protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x4DEFE0 Offset: 0x4DD9E0 VA: 0x1804DEFE0 Slot: 4
	public string get_Name() { }

	// RVA: 0xC21AE0 Offset: 0xC204E0 VA: 0x180C21AE0 Slot: 26
	public virtual string get_Description() { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0 Slot: 6
	public int get_Priority() { }

	// RVA: 0xC21CD0 Offset: 0xC206D0 VA: 0x180C21CD0 Slot: 7
	public void set_Priority(int value) { }

	// RVA: 0xC1F130 Offset: 0xC1DB30 VA: 0x180C1F130
	protected void ApplyPositionBlendMethod(ref CameraState state, CinemachineVirtualCameraBase.BlendHint hint) { }

	// RVA: 0xC21C50 Offset: 0xC20650 VA: 0x180C21C50 Slot: 13
	public GameObject get_VirtualCameraGameObject() { }

	// RVA: 0xC21B10 Offset: 0xC20510 VA: 0x180C21B10 Slot: 14
	public bool get_IsValid() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract CameraState get_State();

	// RVA: 0xC21B70 Offset: 0xC20570 VA: 0x180C21B70 Slot: 15
	public ICinemachineCamera get_ParentCamera() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 28
	public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract Transform get_LookAt();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void set_LookAt(Transform value);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract Transform get_Follow();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract void set_Follow(Transform value);

	[CompilerGenerated]
	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0 Slot: 33
	public virtual bool get_PreviousStateIsValid() { }

	[CompilerGenerated]
	// RVA: 0x4D6520 Offset: 0x4D4F20 VA: 0x1804D6520 Slot: 34
	public virtual void set_PreviousStateIsValid(bool value) { }

	// RVA: 0xC21490 Offset: 0xC1FE90 VA: 0x180C21490 Slot: 17
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 35
	public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime);

	// RVA: 0xC20D80 Offset: 0xC1F780 VA: 0x180C20D80 Slot: 36
	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0xC207D0 Offset: 0xC1F1D0 VA: 0x180C207D0 Slot: 37
	protected virtual void OnDestroy() { }

	// RVA: 0xC20CF0 Offset: 0xC1F6F0 VA: 0x180C20CF0 Slot: 38
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0xC213E0 Offset: 0xC1FDE0 VA: 0x180C213E0 Slot: 39
	protected virtual void Start() { }

	// RVA: 0xC210D0 Offset: 0xC1FAD0 VA: 0x180C210D0 Slot: 40
	internal virtual bool RequiresUserInput() { }

	// RVA: 0xC1FD20 Offset: 0xC1E720 VA: 0x180C1FD20
	internal void EnsureStarted() { }

	// RVA: 0xC1FFE0 Offset: 0xC1E9E0 VA: 0x180C1FFE0
	public AxisState.IInputAxisProvider GetInputAxisProvider() { }

	// RVA: 0xC20DD0 Offset: 0xC1F7D0 VA: 0x180C20DD0 Slot: 41
	protected virtual void OnValidate() { }

	// RVA: 0xC20950 Offset: 0xC1F350 VA: 0x180C20950 Slot: 42
	protected virtual void OnEnable() { }

	// RVA: 0xC208E0 Offset: 0xC1F2E0 VA: 0x180C208E0 Slot: 43
	protected virtual void OnDisable() { }

	// RVA: 0xC21A20 Offset: 0xC20420 VA: 0x180C21A20 Slot: 44
	protected virtual void Update() { }

	// RVA: 0xC21530 Offset: 0xC1FF30 VA: 0x180C21530
	private void UpdateSlaveStatus() { }

	// RVA: 0xC212F0 Offset: 0xC1FCF0 VA: 0x180C212F0
	public Transform ResolveLookAt(Transform localLookAt) { }

	// RVA: 0xC21200 Offset: 0xC1FC00 VA: 0x180C21200
	public Transform ResolveFollow(Transform localFollow) { }

	// RVA: 0xC21840 Offset: 0xC20240 VA: 0x180C21840
	private void UpdateVcamPoolStatus() { }

	// RVA: 0xC207C0 Offset: 0xC1F1C0 VA: 0x180C207C0
	public void MoveToTopOfPrioritySubqueue() { }

	// RVA: 0xC20C20 Offset: 0xC1F620 VA: 0x180C20C20 Slot: 45
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0xC1FDD0 Offset: 0xC1E7D0 VA: 0x180C1FDD0 Slot: 46
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0xC1FEB0 Offset: 0xC1E8B0 VA: 0x180C1FEB0
	private bool GetInheritPosition(ICinemachineCamera cam) { }

	// RVA: 0xC1F350 Offset: 0xC1DD50 VA: 0x180C1F350
	protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend) { }

	// RVA: 0xC20E30 Offset: 0xC1F830 VA: 0x180C20E30
	protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens) { }

	// RVA: 0xC20150 Offset: 0xC1EB50 VA: 0x180C20150
	private void InvalidateCachedTargets() { }

	[CompilerGenerated]
	// RVA: 0x6A52A0 Offset: 0x6A3CA0 VA: 0x1806A52A0
	public bool get_FollowTargetChanged() { }

	[CompilerGenerated]
	// RVA: 0xAE7D60 Offset: 0xAE6760 VA: 0x180AE7D60
	private void set_FollowTargetChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0xC21B60 Offset: 0xC20560 VA: 0x180C21B60
	public bool get_LookAtTargetChanged() { }

	[CompilerGenerated]
	// RVA: 0xC21CC0 Offset: 0xC206C0 VA: 0x180C21CC0
	private void set_LookAtTargetChanged(bool value) { }

	// RVA: 0xC215F0 Offset: 0xC1FFF0 VA: 0x180C215F0
	protected void UpdateTargetCache() { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public ICinemachineTargetGroup get_AbstractFollowTargetGroup() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public CinemachineVirtualCameraBase get_FollowTargetAsVcam() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public ICinemachineTargetGroup get_AbstractLookAtTargetGroup() { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public CinemachineVirtualCameraBase get_LookAtTargetAsVcam() { }

	// RVA: 0xAD5CC0 Offset: 0xAD46C0 VA: 0x180AD5CC0 Slot: 21
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0xC213F0 Offset: 0xC1FDF0 VA: 0x180C213F0 Slot: 22
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 47
	protected internal virtual void LegacyUpgrade(int streamedVersion) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 48
	internal virtual void OnBeforeSerialize() { }

	// RVA: 0xC1F160 Offset: 0xC1DB60 VA: 0x180C1F160
	public void CancelDamping(bool updateNow = False) { }

	// RVA: 0xC21A30 Offset: 0xC20430 VA: 0x180C21A30
	protected void .ctor() { }
}
