public class CinemachineTrackedDolly : CinemachineComponentBase // TypeDefIndex: 16117
{
	// Fields
	[Tooltip("The path to which the camera will be constrained.  This must be non-null.")]
	public CinemachinePathBase m_Path; // 0x28
	[Tooltip("The position along the path at which the camera will be placed.  This can be animated directly, or set automatically by the Auto-Dolly feature to get as close as possible to the Follow target.  The value is interpreted according to the Position Units setting.")]
	public float m_PathPosition; // 0x30
	[Tooltip("How to interpret Path Position.  If set to Path Units, values are as follows: 0 represents the first waypoint on the path, 1 is the second, and so on.  Values in-between are points on the path in between the waypoints.  If set to Distance, then Path Position represents distance along the path.")]
	public CinemachinePathBase.PositionUnits m_PositionUnits; // 0x34
	[Tooltip("Where to put the camera relative to the path position.  X is perpendicular to the path, Y is up, and Z is parallel to the path.  This allows the camera to be offset from the path itself (as if on a tripod, for example).")]
	public Vector3 m_PathOffset; // 0x38
	[Tooltip("How aggressively the camera tries to maintain its position in a direction perpendicular to the path.  Small numbers are more responsive, rapidly translating the camera to keep the target's x-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	[Range(0, 20)]
	public float m_XDamping; // 0x44
	[Tooltip("How aggressively the camera tries to maintain its position in the path-local up direction.  Small numbers are more responsive, rapidly translating the camera to keep the target's y-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	[Range(0, 20)]
	public float m_YDamping; // 0x48
	[Tooltip("How aggressively the camera tries to maintain its position in a direction parallel to the path.  Small numbers are more responsive, rapidly translating the camera to keep the target's z-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	[Range(0, 20)]
	public float m_ZDamping; // 0x4C
	[Tooltip("How to set the virtual camera's Up vector.  This will affect the screen composition, because the camera Aim behaviours will always try to respect the Up direction.")]
	public CinemachineTrackedDolly.CameraUpMode m_CameraUp; // 0x50
	[Tooltip("How aggressively the camera tries to track the target rotation's X angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	[Range(0, 20)]
	public float m_PitchDamping; // 0x54
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to track the target rotation's Y angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_YawDamping; // 0x58
	[Tooltip("How aggressively the camera tries to track the target rotation's Z angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	[Range(0, 20)]
	public float m_RollDamping; // 0x5C
	[Tooltip("Controls how automatic dollying occurs.  A Follow target is necessary to use this feature.")]
	public CinemachineTrackedDolly.AutoDolly m_AutoDolly; // 0x60
	private float m_PreviousPathPosition; // 0x70
	private Quaternion m_PreviousOrientation; // 0x74
	private Vector3 m_PreviousCameraPosition; // 0x84

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	private Vector3 AngularDamping { get; }

	// Methods

	// RVA: 0xC1CCB0 Offset: 0xC1B6B0 VA: 0x180C1CCB0 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0xC1BBC0 Offset: 0xC1A5C0 VA: 0x180C1BBC0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0xC1BC70 Offset: 0xC1A670 VA: 0x180C1BC70 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0xC1B8E0 Offset: 0xC1A2E0 VA: 0x180C1B8E0
	private Quaternion GetCameraOrientationAtPathPoint(Quaternion pathOrientation, Vector3 up) { }

	// RVA: 0xC1CC10 Offset: 0xC1B610 VA: 0x180C1CC10
	private Vector3 get_AngularDamping() { }

	// RVA: 0xC1CB10 Offset: 0xC1B510 VA: 0x180C1CB10
	public void .ctor() { }
}
