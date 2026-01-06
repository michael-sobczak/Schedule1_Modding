public class CinemachineComposer : CinemachineComponentBase // TypeDefIndex: 16098
{
	// Fields
	[Tooltip("Target offset from the target object's center in target-local space. Use this to fine-tune the tracking target position when the desired area is not the tracked object's center.")]
	public Vector3 m_TrackedObjectOffset; // 0x28
	[Space]
	[Tooltip("This setting will instruct the composer to adjust its target offset based on the motion of the target.  The composer will look at a point where it estimates the target will be this many seconds into the future.  Note that this setting is sensitive to noisy animation, and can amplify the noise, resulting in undesirable camera jitter.  If the camera jitters unacceptably when the target is in motion, turn down this setting, or animate the target more smoothly.")]
	[Range(0, 1)]
	public float m_LookaheadTime; // 0x34
	[Tooltip("Controls the smoothness of the lookahead algorithm.  Larger values smooth out jittery predictions and also increase prediction lag")]
	[Range(0, 30)]
	public float m_LookaheadSmoothing; // 0x38
	[Tooltip("If checked, movement along the Y axis will be ignored for lookahead calculations")]
	public bool m_LookaheadIgnoreY; // 0x3C
	[Range(0, 20)]
	[Space]
	[Tooltip("How aggressively the camera tries to follow the target in the screen-horizontal direction. Small numbers are more responsive, rapidly orienting the camera to keep the target in the dead zone. Larger numbers give a more heavy slowly responding camera. Using different vertical and horizontal settings can yield a wide range of camera behaviors.")]
	public float m_HorizontalDamping; // 0x40
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to follow the target in the screen-vertical direction. Small numbers are more responsive, rapidly orienting the camera to keep the target in the dead zone. Larger numbers give a more heavy slowly responding camera. Using different vertical and horizontal settings can yield a wide range of camera behaviors.")]
	public float m_VerticalDamping; // 0x44
	[Tooltip("Horizontal screen position for target. The camera will rotate to position the tracked object here.")]
	[Range(-0.5, 1.5)]
	[Space]
	public float m_ScreenX; // 0x48
	[Range(-0.5, 1.5)]
	[Tooltip("Vertical screen position for target, The camera will rotate to position the tracked object here.")]
	public float m_ScreenY; // 0x4C
	[Range(0, 2)]
	[Tooltip("Camera will not rotate horizontally if the target is within this range of the position.")]
	public float m_DeadZoneWidth; // 0x50
	[Tooltip("Camera will not rotate vertically if the target is within this range of the position.")]
	[Range(0, 2)]
	public float m_DeadZoneHeight; // 0x54
	[Range(0, 2)]
	[Tooltip("When target is within this region, camera will gradually rotate horizontally to re-align towards the desired position, depending on the damping speed.")]
	public float m_SoftZoneWidth; // 0x58
	[Range(0, 2)]
	[Tooltip("When target is within this region, camera will gradually rotate vertically to re-align towards the desired position, depending on the damping speed.")]
	public float m_SoftZoneHeight; // 0x5C
	[Range(-0.5, 0.5)]
	[Tooltip("A non-zero bias will move the target position horizontally away from the center of the soft zone.")]
	public float m_BiasX; // 0x60
	[Range(-0.5, 0.5)]
	[Tooltip("A non-zero bias will move the target position vertically away from the center of the soft zone.")]
	public float m_BiasY; // 0x64
	[Tooltip("Force target to center of screen when this camera activates.  If false, will clamp target to the edges of the dead zone")]
	public bool m_CenterOnActivate; // 0x68
	[CompilerGenerated]
	private Vector3 <TrackedPoint>k__BackingField; // 0x6C
	private Vector3 m_CameraPosPrevFrame; // 0x78
	private Vector3 m_LookAtPrevFrame; // 0x84
	private Vector2 m_ScreenOffsetPrevFrame; // 0x90
	private Quaternion m_CameraOrientationPrevFrame; // 0x98
	internal PositionPredictor m_Predictor; // 0xA8
	private CinemachineComposer.FovCache mCache; // 0xB0

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	public Vector3 TrackedPoint { get; set; }
	internal Rect SoftGuideRect { get; set; }
	internal Rect HardGuideRect { get; set; }

	// Methods

	// RVA: 0xBF89C0 Offset: 0xBF73C0 VA: 0x180BF89C0 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	[CompilerGenerated]
	// RVA: 0xBF8A80 Offset: 0xBF7480 VA: 0x180BF8A80
	public Vector3 get_TrackedPoint() { }

	[CompilerGenerated]
	// RVA: 0xBF8BD0 Offset: 0xBF75D0 VA: 0x180BF8BD0
	private void set_TrackedPoint(Vector3 value) { }

	// RVA: 0xBF73B0 Offset: 0xBF5DB0 VA: 0x180BF73B0 Slot: 14
	protected virtual Vector3 GetLookAtPointAndSetTrackedPoint(Vector3 lookAt, Vector3 up, float deltaTime) { }

	// RVA: 0xBF8190 Offset: 0xBF6B90 VA: 0x180BF8190 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0xBF7340 Offset: 0xBF5D40 VA: 0x180BF7340 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0xBF7670 Offset: 0xBF6070 VA: 0x180BF7670 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0xBF8310 Offset: 0xBF6D10 VA: 0x180BF8310 Slot: 5
	public override void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0xBF7680 Offset: 0xBF6080 VA: 0x180BF7680 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0xBF8A30 Offset: 0xBF7430 VA: 0x180BF8A30
	internal Rect get_SoftGuideRect() { }

	// RVA: 0xBF8B10 Offset: 0xBF7510 VA: 0x180BF8B10
	internal void set_SoftGuideRect(Rect value) { }

	// RVA: 0xBF8940 Offset: 0xBF7340 VA: 0x180BF8940
	internal Rect get_HardGuideRect() { }

	// RVA: 0xBF8AA0 Offset: 0xBF74A0 VA: 0x180BF8AA0
	internal void set_HardGuideRect(Rect value) { }

	// RVA: 0xBF8400 Offset: 0xBF6E00 VA: 0x180BF8400
	private void RotateToScreenBounds(ref CameraState state, Rect screenRect, Vector3 trackedPoint, ref Quaternion rigOrientation, float fov, float fovH, float deltaTime) { }

	// RVA: 0xBF7220 Offset: 0xBF5C20 VA: 0x180BF7220
	private bool ClampVerticalBounds(ref Rect r, Vector3 dir, Vector3 up, float fov) { }

	// RVA: 0xBF8770 Offset: 0xBF7170 VA: 0x180BF8770
	public void .ctor() { }
}
