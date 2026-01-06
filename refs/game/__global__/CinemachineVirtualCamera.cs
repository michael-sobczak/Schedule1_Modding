public class CinemachineVirtualCamera : CinemachineVirtualCameraBase // TypeDefIndex: 16094
{
	// Fields
	[Tooltip("The object that the camera wants to look at (the Aim target).  If this is null, then the vcam's Transform orientation will define the camera's orientation.")]
	[NoSaveDuringPlay]
	[VcamTargetProperty]
	public Transform m_LookAt; // 0xA8
	[Tooltip("The object that the camera wants to move with (the Body target).  If this is null, then the vcam's Transform position will define the camera's position.")]
	[NoSaveDuringPlay]
	[VcamTargetProperty]
	public Transform m_Follow; // 0xB0
	[FormerlySerializedAs("m_LensAttributes")]
	[Tooltip("Specifies the lens properties of this Virtual Camera.  This generally mirrors the Unity Camera's lens settings, and will be used to drive the Unity camera when the vcam is active.")]
	public LensSettings m_Lens; // 0xB8
	public CinemachineVirtualCameraBase.TransitionParams m_Transitions; // 0xF0
	[FormerlySerializedAs("m_BlendHint")]
	[FormerlySerializedAs("m_PositionBlending")]
	[SerializeField]
	[HideInInspector]
	private CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint; // 0x100
	public const string PipelineName = "cm";
	public static CinemachineVirtualCamera.CreatePipelineDelegate CreatePipelineOverride; // 0x0
	public static CinemachineVirtualCamera.DestroyPipelineDelegate DestroyPipelineOverride; // 0x8
	private CameraState m_State; // 0x108
	private CinemachineComponentBase[] m_ComponentPipeline; // 0x1F0
	[SerializeField]
	[HideInInspector]
	private Transform m_ComponentOwner; // 0x1F8
	private Transform mCachedLookAtTarget; // 0x200
	private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x208

	// Properties
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }

	// Methods

	// RVA: 0xC04730 Offset: 0xC03130 VA: 0x180C04730 Slot: 27
	public override CameraState get_State() { }

	// RVA: 0xBDC7D0 Offset: 0xBDB1D0 VA: 0x180BDC7D0 Slot: 29
	public override Transform get_LookAt() { }

	// RVA: 0x4B6D20 Offset: 0x4B5720 VA: 0x1804B6D20 Slot: 30
	public override void set_LookAt(Transform value) { }

	// RVA: 0xBDC7B0 Offset: 0xBDB1B0 VA: 0x180BDC7B0 Slot: 31
	public override Transform get_Follow() { }

	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80 Slot: 32
	public override void set_Follow(Transform value) { }

	// RVA: 0xC0A4D0 Offset: 0xC08ED0 VA: 0x180C0A4D0 Slot: 23
	public override float GetMaxDampTime() { }

	// RVA: 0xC0A590 Offset: 0xC08F90 VA: 0x180C0A590 Slot: 35
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0xC0AC20 Offset: 0xC09620 VA: 0x180C0AC20 Slot: 42
	protected override void OnEnable() { }

	// RVA: 0xC0A980 Offset: 0xC09380 VA: 0x180C0A980 Slot: 37
	protected override void OnDestroy() { }

	// RVA: 0xC0B700 Offset: 0xC0A100 VA: 0x180C0B700 Slot: 41
	protected override void OnValidate() { }

	// RVA: 0xC0A8A0 Offset: 0xC092A0 VA: 0x180C0A8A0
	private void OnTransformChildrenChanged() { }

	// RVA: 0xC0B8C0 Offset: 0xC0A2C0 VA: 0x180C0B8C0
	private void Reset() { }

	// RVA: 0xC09CD0 Offset: 0xC086D0 VA: 0x180C09CD0
	internal void DestroyPipeline() { }

	// RVA: 0xC09AE0 Offset: 0xC084E0 VA: 0x180C09AE0
	internal Transform CreatePipeline(CinemachineVirtualCamera copyFrom) { }

	// RVA: 0xC0A8A0 Offset: 0xC092A0 VA: 0x180C0A8A0
	public void InvalidateComponentPipeline() { }

	// RVA: 0xC0A490 Offset: 0xC08E90 VA: 0x180C0A490
	public Transform GetComponentOwner() { }

	// RVA: 0xC0A4B0 Offset: 0xC08EB0 VA: 0x180C0A4B0
	public CinemachineComponentBase[] GetComponentPipeline() { }

	// RVA: 0xC0A3E0 Offset: 0xC08DE0 VA: 0x180C0A3E0
	public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage) { }

	// RVA: -1 Offset: -1
	public T GetCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE607A0 Offset: 0xE5F1A0 VA: 0x180E607A0
	|-CinemachineVirtualCamera.GetCinemachineComponent<object>
	*/

	// RVA: -1 Offset: -1
	public T AddCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE60490 Offset: 0xE5EE90 VA: 0x180E60490
	|-CinemachineVirtualCamera.AddCinemachineComponent<object>
	*/

	// RVA: -1 Offset: -1
	public void DestroyCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE606A0 Offset: 0xE5F0A0 VA: 0x180E606A0
	|-CinemachineVirtualCamera.DestroyCinemachineComponent<object>
	*/

	// RVA: 0xC0B9D0 Offset: 0xC0A3D0 VA: 0x180C0B9D0
	private void UpdateComponentPipeline() { }

	// RVA: 0xC0B8E0 Offset: 0xC0A2E0 VA: 0x180C0B8E0
	internal static void SetFlagsForHiddenChild(GameObject child) { }

	// RVA: 0xC09410 Offset: 0xC07E10 VA: 0x180C09410
	private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0xC0B030 Offset: 0xC09A30 VA: 0x180C0B030 Slot: 45
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0xC0A250 Offset: 0xC08C50 VA: 0x180C0A250 Slot: 46
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0xC0B9B0 Offset: 0xC0A3B0 VA: 0x180C0B9B0
	internal void SetStateRawPosition(Vector3 pos) { }

	// RVA: 0xC0B250 Offset: 0xC09C50 VA: 0x180C0B250 Slot: 36
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0xC0B780 Offset: 0xC0A180 VA: 0x180C0B780 Slot: 40
	internal override bool RequiresUserInput() { }

	// RVA: 0xC0A8C0 Offset: 0xC092C0 VA: 0x180C0A8C0 Slot: 48
	internal override void OnBeforeSerialize() { }

	// RVA: 0xC0BEF0 Offset: 0xC0A8F0 VA: 0x180C0BEF0
	public void .ctor() { }
}
