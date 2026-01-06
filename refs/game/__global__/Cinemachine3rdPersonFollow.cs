public class Cinemachine3rdPersonFollow : CinemachineComponentBase // TypeDefIndex: 16095
{
	// Fields
	[Tooltip("How responsively the camera tracks the target.  Each axis (camera-local) can have its own setting.  Value is the approximate time it takes the camera to catch up to the target's new position.  Smaller values give a more rigid effect, larger values give a squishier one")]
	public Vector3 Damping; // 0x28
	[Header("Rig")]
	[Tooltip("Position of the shoulder pivot relative to the Follow target origin.  This offset is in target-local space")]
	public Vector3 ShoulderOffset; // 0x34
	[Tooltip("Vertical offset of the hand in relation to the shoulder.  Arm length will affect the follow target's screen position when the camera rotates vertically")]
	public float VerticalArmLength; // 0x40
	[Tooltip("Specifies which shoulder (left, right, or in-between) the camera is on")]
	[Range(0, 1)]
	public float CameraSide; // 0x44
	[Tooltip("How far behind the hand the camera will be placed")]
	public float CameraDistance; // 0x48
	[Tooltip("Camera will avoid obstacles on these layers")]
	[Header("Obstacles")]
	public LayerMask CameraCollisionFilter; // 0x4C
	[Tooltip("Obstacles with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
	[TagField]
	public string IgnoreTag; // 0x50
	[Tooltip("Specifies how close the camera can get to obstacles")]
	[Range(0, 1)]
	public float CameraRadius; // 0x58
	[Range(0, 10)]
	[Tooltip("How gradually the camera moves to correct for occlusions.  Higher numbers will move the camera more gradually.")]
	public float DampingIntoCollision; // 0x5C
	[Range(0, 10)]
	[Tooltip("How gradually the camera returns to its normal position after having been corrected by the built-in collision resolution system.  Higher numbers will move the camera more gradually back to normal.")]
	public float DampingFromCollision; // 0x60
	private Vector3 m_PreviousFollowTargetPosition; // 0x64
	private Vector3 m_DampingCorrection; // 0x70
	private float m_CamPosCollisionCorrection; // 0x7C

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }

	// Methods

	// RVA: 0xBF5B90 Offset: 0xBF4590 VA: 0x180BF5B90
	private void OnValidate() { }

	// RVA: 0xBF6180 Offset: 0xBF4B80 VA: 0x180BF6180
	private void Reset() { }

	// RVA: 0xBF5A70 Offset: 0xBF4470 VA: 0x180BF5A70
	private void OnDestroy() { }

	// RVA: 0xBF6620 Offset: 0xBF5020 VA: 0x180BF6620 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0xBF55F0 Offset: 0xBF3FF0 VA: 0x180BF55F0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0xBF59E0 Offset: 0xBF43E0 VA: 0x180BF59E0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0xBF5AB0 Offset: 0xBF44B0 VA: 0x180BF5AB0 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0xBF5C10 Offset: 0xBF4610 VA: 0x180BF5C10
	private void PositionCamera(ref CameraState curState, float deltaTime) { }

	// RVA: 0xBF57C0 Offset: 0xBF41C0 VA: 0x180BF57C0
	public void GetRigPositions(out Vector3 root, out Vector3 shoulder, out Vector3 hand) { }

	// RVA: 0xBF5340 Offset: 0xBF3D40 VA: 0x180BF5340
	internal static Quaternion GetHeading(Quaternion targetRot, Vector3 up) { }

	// RVA: 0xBF5620 Offset: 0xBF4020 VA: 0x180BF5620
	private void GetRawRigPositions(Vector3 root, Quaternion targetRot, Quaternion heading, out Vector3 shoulder, out Vector3 hand) { }

	// RVA: 0xBF6200 Offset: 0xBF4C00 VA: 0x180BF6200
	private Vector3 ResolveCollisions(Vector3 root, Vector3 tip, float deltaTime, float cameraRadius, ref float collisionCorrection) { }

	// RVA: 0xBF65C0 Offset: 0xBF4FC0 VA: 0x180BF65C0
	public void .ctor() { }
}
