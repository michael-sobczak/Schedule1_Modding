public class CinemachineCollider : CinemachineExtension // TypeDefIndex: 16052
{
	// Fields
	[Header("Obstacle Detection")]
	[Tooltip("Objects on these layers will be detected")]
	public LayerMask m_CollideAgainst; // 0x30
	[TagField]
	[Tooltip("Obstacles with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
	public string m_IgnoreTag; // 0x38
	[Tooltip("Objects on these layers will never obstruct view of the target")]
	public LayerMask m_TransparentLayers; // 0x40
	[Tooltip("Obstacles closer to the target than this will be ignored")]
	public float m_MinimumDistanceFromTarget; // 0x44
	[Tooltip("When enabled, will attempt to resolve situations where the line of sight to the target is blocked by an obstacle")]
	[Space]
	[FormerlySerializedAs("m_PreserveLineOfSight")]
	public bool m_AvoidObstacles; // 0x48
	[Tooltip("The maximum raycast distance when checking if the line of sight to this camera's target is clear.  If the setting is 0 or less, the current actual distance to target will be used.")]
	[FormerlySerializedAs("m_LineOfSightFeelerDistance")]
	public float m_DistanceLimit; // 0x4C
	[Tooltip("Don't take action unless occlusion has lasted at least this long.")]
	public float m_MinimumOcclusionTime; // 0x50
	[Tooltip("Camera will try to maintain this distance from any obstacle.  Try to keep this value small.  Increase it if you are seeing inside obstacles due to a large FOV on the camera.")]
	public float m_CameraRadius; // 0x54
	[Tooltip("The way in which the Collider will attempt to preserve sight of the target.")]
	public CinemachineCollider.ResolutionStrategy m_Strategy; // 0x58
	[Range(1, 10)]
	[Tooltip("Upper limit on how many obstacle hits to process.  Higher numbers may impact performance.  In most environments, 4 is enough.")]
	public int m_MaximumEffort; // 0x5C
	[Range(0, 2)]
	[Tooltip("Smoothing to apply to obstruction resolution.  Nearest camera point is held for at least this long")]
	public float m_SmoothingTime; // 0x60
	[FormerlySerializedAs("m_Smoothing")]
	[Range(0, 10)]
	[Tooltip("How gradually the camera returns to its normal position after having been corrected.  Higher numbers will move the camera more gradually back to normal.")]
	public float m_Damping; // 0x64
	[Range(0, 10)]
	[Tooltip("How gradually the camera moves to resolve an occlusion.  Higher numbers will move the camera more gradually.")]
	public float m_DampingWhenOccluded; // 0x68
	[Header("Shot Evaluation")]
	[Tooltip("If greater than zero, a higher score will be given to shots when the target is closer to this distance.  Set this to zero to disable this feature.")]
	public float m_OptimalTargetDistance; // 0x6C
	private const float k_PrecisionSlush = 0.001;
	private RaycastHit[] m_CornerBuffer; // 0x70
	private const float k_AngleThreshold = 0.1;
	private static Collider[] s_ColliderBuffer; // 0x0

	// Properties
	public List<List<Vector3>> DebugPaths { get; }

	// Methods

	// RVA: 0xBE4D30 Offset: 0xBE3730 VA: 0x180BE4D30
	public bool IsTargetObscured(ICinemachineCamera vcam) { }

	// RVA: 0xBE30D0 Offset: 0xBE1AD0 VA: 0x180BE30D0
	public bool CameraWasDisplaced(ICinemachineCamera vcam) { }

	// RVA: 0xBE4240 Offset: 0xBE2C40 VA: 0x180BE4240
	public float GetCameraDisplacementDistance(ICinemachineCamera vcam) { }

	// RVA: 0xBE5430 Offset: 0xBE3E30 VA: 0x180BE5430
	private void OnValidate() { }

	// RVA: 0xBE5310 Offset: 0xBE3D10 VA: 0x180BE5310 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0xBE82E0 Offset: 0xBE6CE0 VA: 0x180BE82E0
	public List<List<Vector3>> get_DebugPaths() { }

	// RVA: 0xBE42A0 Offset: 0xBE2CA0 VA: 0x180BE42A0 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0xBE5360 Offset: 0xBE3D60 VA: 0x180BE5360 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0xBE5480 Offset: 0xBE3E80 VA: 0x180BE5480 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0xBE6520 Offset: 0xBE4F20 VA: 0x180BE6520
	private Vector3 PreserveLineOfSight(ref CameraState state, ref CinemachineCollider.VcamExtraState extra) { }

	// RVA: 0xBE6A10 Offset: 0xBE5410 VA: 0x180BE6A10
	private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo) { }

	// RVA: 0xBE6E90 Offset: 0xBE5890 VA: 0x180BE6E90
	private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref CinemachineCollider.VcamExtraState extra) { }

	// RVA: 0xBE4480 Offset: 0xBE2E80 VA: 0x180BE4480
	private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir) { }

	// RVA: 0xBE42C0 Offset: 0xBE2CC0 VA: 0x180BE42C0
	private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos) { }

	// RVA: 0xBE3420 Offset: 0xBE1E20 VA: 0x180BE3420
	private static float ClampRayToBounds(Ray ray, float distance, Bounds bounds) { }

	// RVA: 0xBE7710 Offset: 0xBE6110 VA: 0x180BE7710
	private Vector3 RespectCameraRadius(Vector3 cameraPos, Vector3 lookAtPos) { }

	// RVA: 0xBE3140 Offset: 0xBE1B40 VA: 0x180BE3140
	private bool CheckForTargetObstructions(CameraState state) { }

	// RVA: 0xBE4D90 Offset: 0xBE3790 VA: 0x180BE4D90
	private static bool IsTargetOffscreen(CameraState state) { }

	// RVA: 0xBE8220 Offset: 0xBE6C20 VA: 0x180BE8220
	public void .ctor() { }

	// RVA: 0xBE81B0 Offset: 0xBE6BB0 VA: 0x180BE81B0
	private static void .cctor() { }
}
