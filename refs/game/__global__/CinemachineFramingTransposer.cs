public class CinemachineFramingTransposer : CinemachineComponentBase // TypeDefIndex: 16101
{
	// Fields
	[Tooltip("Offset from the Follow Target object (in target-local co-ordinates).  The camera will attempt to frame the point which is the target's position plus this offset.  Use it to correct for cases when the target's origin is not the point of interest for the camera.")]
	public Vector3 m_TrackedObjectOffset; // 0x28
	[Space]
	[Range(0, 1)]
	[Tooltip("This setting will instruct the composer to adjust its target offset based on the motion of the target.  The composer will look at a point where it estimates the target will be this many seconds into the future.  Note that this setting is sensitive to noisy animation, and can amplify the noise, resulting in undesirable camera jitter.  If the camera jitters unacceptably when the target is in motion, turn down this setting, or animate the target more smoothly.")]
	public float m_LookaheadTime; // 0x34
	[Tooltip("Controls the smoothness of the lookahead algorithm.  Larger values smooth out jittery predictions and also increase prediction lag")]
	[Range(0, 30)]
	public float m_LookaheadSmoothing; // 0x38
	[Tooltip("If checked, movement along the Y axis will be ignored for lookahead calculations")]
	public bool m_LookaheadIgnoreY; // 0x3C
	[Space]
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to maintain the offset in the X-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's x-axis offset.  Larger numbers give a more heavy slowly responding camera.  Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_XDamping; // 0x40
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to maintain the offset in the Y-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's y-axis offset.  Larger numbers give a more heavy slowly responding camera.  Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_YDamping; // 0x44
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to maintain the offset in the Z-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's z-axis offset.  Larger numbers give a more heavy slowly responding camera.  Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_ZDamping; // 0x48
	[Tooltip("If set, damping will apply  only to target motion, but not to camera rotation changes.  Turn this on to get an instant response when the rotation changes.  ")]
	public bool m_TargetMovementOnly; // 0x4C
	[Space]
	[Range(-0.5, 1.5)]
	[Tooltip("Horizontal screen position for target. The camera will move to position the tracked object here.")]
	public float m_ScreenX; // 0x50
	[Tooltip("Vertical screen position for target, The camera will move to position the tracked object here.")]
	[Range(-0.5, 1.5)]
	public float m_ScreenY; // 0x54
	[Tooltip("The distance along the camera axis that will be maintained from the Follow target")]
	public float m_CameraDistance; // 0x58
	[Space]
	[Range(0, 2)]
	[Tooltip("Camera will not move horizontally if the target is within this range of the position.")]
	public float m_DeadZoneWidth; // 0x5C
	[Tooltip("Camera will not move vertically if the target is within this range of the position.")]
	[Range(0, 2)]
	public float m_DeadZoneHeight; // 0x60
	[Tooltip("The camera will not move along its z-axis if the Follow target is within this distance of the specified camera distance")]
	[FormerlySerializedAs("m_DistanceDeadZoneSize")]
	public float m_DeadZoneDepth; // 0x64
	[Space]
	[Tooltip("If checked, then then soft zone will be unlimited in size.")]
	public bool m_UnlimitedSoftZone; // 0x68
	[Tooltip("When target is within this region, camera will gradually move horizontally to re-align towards the desired position, depending on the damping speed.")]
	[Range(0, 2)]
	public float m_SoftZoneWidth; // 0x6C
	[Range(0, 2)]
	[Tooltip("When target is within this region, camera will gradually move vertically to re-align towards the desired position, depending on the damping speed.")]
	public float m_SoftZoneHeight; // 0x70
	[Range(-0.5, 0.5)]
	[Tooltip("A non-zero bias will move the target position horizontally away from the center of the soft zone.")]
	public float m_BiasX; // 0x74
	[Range(-0.5, 0.5)]
	[Tooltip("A non-zero bias will move the target position vertically away from the center of the soft zone.")]
	public float m_BiasY; // 0x78
	[Tooltip("Force target to center of screen when this camera activates.  If false, will clamp target to the edges of the dead zone")]
	public bool m_CenterOnActivate; // 0x7C
	[Tooltip("What screen dimensions to consider when framing.  Can be Horizontal, Vertical, or both")]
	[Space]
	[FormerlySerializedAs("m_FramingMode")]
	public CinemachineFramingTransposer.FramingMode m_GroupFramingMode; // 0x80
	[Tooltip("How to adjust the camera to get the desired framing.  You can zoom, dolly in/out, or do both.")]
	public CinemachineFramingTransposer.AdjustmentMode m_AdjustmentMode; // 0x84
	[Tooltip("The bounding box of the targets should occupy this amount of the screen space.  1 means fill the whole screen.  0.5 means fill half the screen, etc.")]
	public float m_GroupFramingSize; // 0x88
	[Tooltip("The maximum distance toward the target that this behaviour is allowed to move the camera.")]
	public float m_MaxDollyIn; // 0x8C
	[Tooltip("The maximum distance away the target that this behaviour is allowed to move the camera.")]
	public float m_MaxDollyOut; // 0x90
	[Tooltip("Set this to limit how close to the target the camera can get.")]
	public float m_MinimumDistance; // 0x94
	[Tooltip("Set this to limit how far from the target the camera can get.")]
	public float m_MaximumDistance; // 0x98
	[Tooltip("If adjusting FOV, will not set the FOV lower than this.")]
	[Range(1, 179)]
	public float m_MinimumFOV; // 0x9C
	[Tooltip("If adjusting FOV, will not set the FOV higher than this.")]
	[Range(1, 179)]
	public float m_MaximumFOV; // 0xA0
	[Tooltip("If adjusting Orthographic Size, will not set it lower than this.")]
	public float m_MinimumOrthoSize; // 0xA4
	[Tooltip("If adjusting Orthographic Size, will not set it higher than this.")]
	public float m_MaximumOrthoSize; // 0xA8
	private const float kMinimumCameraDistance = 0.01;
	private const float kMinimumGroupSize = 0.01;
	private Vector3 m_PreviousCameraPosition; // 0xAC
	internal PositionPredictor m_Predictor; // 0xB8
	[CompilerGenerated]
	private Vector3 <TrackedPoint>k__BackingField; // 0xC0
	private bool m_InheritingPosition; // 0xCC
	private float m_prevFOV; // 0xD0
	private Quaternion m_prevRotation; // 0xD4
	[CompilerGenerated]
	private Bounds <LastBounds>k__BackingField; // 0xE4
	[CompilerGenerated]
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0xFC

	// Properties
	internal Rect SoftGuideRect { get; set; }
	internal Rect HardGuideRect { get; set; }
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	public override bool BodyAppliesAfterAim { get; }
	public Vector3 TrackedPoint { get; set; }
	public Bounds LastBounds { get; set; }
	public Matrix4x4 LastBoundsMatrix { get; set; }

	// Methods

	// RVA: 0xBFB9A0 Offset: 0xBFA3A0 VA: 0x180BFB9A0
	internal Rect get_SoftGuideRect() { }

	// RVA: 0xBFBAB0 Offset: 0xBFA4B0 VA: 0x180BFBAB0
	internal void set_SoftGuideRect(Rect value) { }

	// RVA: 0xBFB860 Offset: 0xBFA260 VA: 0x180BFB860
	internal Rect get_HardGuideRect() { }

	// RVA: 0xBFB9F0 Offset: 0xBFA3F0 VA: 0x180BFB9F0
	internal void set_HardGuideRect(Rect value) { }

	// RVA: 0xBFB450 Offset: 0xBF9E50 VA: 0x180BFB450
	private void OnValidate() { }

	// RVA: 0xBFB8E0 Offset: 0xBFA2E0 VA: 0x180BFB8E0 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 7
	public override bool get_BodyAppliesAfterAim() { }

	[CompilerGenerated]
	// RVA: 0x4EFF90 Offset: 0x4EE990 VA: 0x1804EFF90
	public Vector3 get_TrackedPoint() { }

	[CompilerGenerated]
	// RVA: 0xBFBB70 Offset: 0xBFA570 VA: 0x180BFBB70
	private void set_TrackedPoint(Vector3 value) { }

	// RVA: 0xBFB0E0 Offset: 0xBF9AE0 VA: 0x180BFB0E0 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0xBF9180 Offset: 0xBF7B80 VA: 0x180BF9180 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0xBF9200 Offset: 0xBF7C00 VA: 0x180BF9200 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0xBFB210 Offset: 0xBF9C10 VA: 0x180BFB210 Slot: 9
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) { }

	// RVA: 0xBFB640 Offset: 0xBFA040 VA: 0x180BFB640
	private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect) { }

	// RVA: 0xBFB540 Offset: 0xBF9F40 VA: 0x180BFB540
	private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect) { }

	[CompilerGenerated]
	// RVA: 0xBFB980 Offset: 0xBFA380 VA: 0x180BFB980
	public Bounds get_LastBounds() { }

	[CompilerGenerated]
	// RVA: 0xBFBA90 Offset: 0xBFA490 VA: 0x180BFBA90
	private void set_LastBounds(Bounds value) { }

	[CompilerGenerated]
	// RVA: 0xBFB950 Offset: 0xBFA350 VA: 0x180BFB950
	public Matrix4x4 get_LastBoundsMatrix() { }

	[CompilerGenerated]
	// RVA: 0xBFBA60 Offset: 0xBFA460 VA: 0x180BFBA60
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	// RVA: 0xBF9A70 Offset: 0xBF8470 VA: 0x180BF9A70 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0xBF9860 Offset: 0xBF8260 VA: 0x180BF9860
	private float GetTargetHeight(Vector2 boundsSize) { }

	// RVA: 0xBF8BE0 Offset: 0xBF75E0 VA: 0x180BF8BE0
	private Vector3 ComputeGroupBounds(ICinemachineTargetGroup group, ref CameraState curState) { }

	// RVA: 0xBF9220 Offset: 0xBF7C20 VA: 0x180BF9220
	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation) { }

	// RVA: 0xBFB710 Offset: 0xBFA110 VA: 0x180BFB710
	public void .ctor() { }
}
