public class CinemachineTransposer : CinemachineComponentBase // TypeDefIndex: 16120
{
	// Fields
	[Tooltip("The coordinate space to use when interpreting the offset from the target.  This is also used to set the camera's Up vector, which will be maintained when aiming the camera.")]
	public CinemachineTransposer.BindingMode m_BindingMode; // 0x28
	[Tooltip("The distance vector that the transposer will attempt to maintain from the Follow target")]
	public Vector3 m_FollowOffset; // 0x2C
	[Tooltip("How aggressively the camera tries to maintain the offset in the X-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's x-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	[Range(0, 20)]
	public float m_XDamping; // 0x38
	[Tooltip("How aggressively the camera tries to maintain the offset in the Y-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's y-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	[Range(0, 20)]
	public float m_YDamping; // 0x3C
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to maintain the offset in the Z-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's z-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_ZDamping; // 0x40
	public CinemachineTransposer.AngularDampingMode m_AngularDampingMode; // 0x44
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to track the target rotation's X angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_PitchDamping; // 0x48
	[Tooltip("How aggressively the camera tries to track the target rotation's Y angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	[Range(0, 20)]
	public float m_YawDamping; // 0x4C
	[Tooltip("How aggressively the camera tries to track the target rotation's Z angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	[Range(0, 20)]
	public float m_RollDamping; // 0x50
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to track the target's orientation.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_AngularDamping; // 0x54
	[CompilerGenerated]
	private bool <HideOffsetInInspector>k__BackingField; // 0x58
	private Vector3 m_PreviousTargetPosition; // 0x5C
	private Quaternion m_PreviousReferenceOrientation; // 0x68
	private Quaternion m_targetOrientationOnAssign; // 0x78
	private Vector3 m_PreviousOffset; // 0x88
	private Transform m_previousTarget; // 0x98

	// Properties
	public bool HideOffsetInInspector { get; set; }
	public Vector3 EffectiveOffset { get; }
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	protected Vector3 Damping { get; }
	protected Vector3 AngularDamping { get; }

	// Methods

	// RVA: 0xC1E060 Offset: 0xC1CA60 VA: 0x180C1E060 Slot: 14
	protected virtual void OnValidate() { }

	[CompilerGenerated]
	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	public bool get_HideOffsetInInspector() { }

	[CompilerGenerated]
	// RVA: 0x4D6520 Offset: 0x4D4F20 VA: 0x1804D6520
	public void set_HideOffsetInInspector(bool value) { }

	// RVA: 0xC1EF60 Offset: 0xC1D960 VA: 0x180C1EF60
	public Vector3 get_EffectiveOffset() { }

	// RVA: 0xC1EFA0 Offset: 0xC1D9A0 VA: 0x180C1EFA0 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0xC1CED0 Offset: 0xC1B8D0 VA: 0x180C1CED0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0xC1DB80 Offset: 0xC1C580 VA: 0x180C1DB80 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0xC1DFA0 Offset: 0xC1C9A0 VA: 0x180C1DFA0 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0xC1CD20 Offset: 0xC1B720 VA: 0x180C1CD20 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0xC1DA10 Offset: 0xC1C410 VA: 0x180C1DA10
	protected void InitPrevFrameStateInfo(ref CameraState curState, float deltaTime) { }

	// RVA: 0xC1E0B0 Offset: 0xC1CAB0 VA: 0x180C1E0B0
	protected void TrackTarget(float deltaTime, Vector3 up, Vector3 desiredCameraOffset, out Vector3 outTargetPosition, out Quaternion outTargetOrient) { }

	// RVA: 0xC1CF60 Offset: 0xC1B960 VA: 0x180C1CF60
	protected Vector3 GetOffsetForMinimumTargetDistance(Vector3 dampedTargetPos, Vector3 cameraOffset, Vector3 cameraFwd, Vector3 up, Vector3 actualTargetPos) { }

	// RVA: 0xC1EF20 Offset: 0xC1D920 VA: 0x180C1EF20
	protected Vector3 get_Damping() { }

	// RVA: 0xC1EE50 Offset: 0xC1D850 VA: 0x180C1EE50
	protected Vector3 get_AngularDamping() { }

	// RVA: 0xC1D8A0 Offset: 0xC1C2A0 VA: 0x180C1D8A0 Slot: 15
	public virtual Vector3 GetTargetCameraPosition(Vector3 worldUp) { }

	// RVA: 0xC1D3A0 Offset: 0xC1BDA0 VA: 0x180C1D3A0
	public Quaternion GetReferenceOrientation(Vector3 worldUp) { }

	// RVA: 0xC1ED20 Offset: 0xC1D720 VA: 0x180C1ED20
	public void .ctor() { }
}
