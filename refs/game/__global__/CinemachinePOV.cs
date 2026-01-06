public class CinemachinePOV : CinemachineComponentBase // TypeDefIndex: 16113
{
	// Fields
	public CinemachinePOV.RecenterTargetMode m_RecenterTarget; // 0x28
	[Tooltip("The Vertical axis.  Value is -90..90. Controls the vertical orientation")]
	[AxisStateProperty]
	public AxisState m_VerticalAxis; // 0x30
	[Tooltip("Controls how automatic recentering of the Vertical axis is accomplished")]
	public AxisState.Recentering m_VerticalRecentering; // 0xA0
	[AxisStateProperty]
	[Tooltip("The Horizontal axis.  Value is -180..180.  Controls the horizontal orientation")]
	public AxisState m_HorizontalAxis; // 0xC0
	[Tooltip("Controls how automatic recentering of the Horizontal axis is accomplished")]
	public AxisState.Recentering m_HorizontalRecentering; // 0x130
	[Tooltip("Obsolete - no longer used")]
	[HideInInspector]
	public bool m_ApplyBeforeBody; // 0x150
	private Quaternion m_PreviousCameraRotation; // 0x154

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	public override bool RequiresUserInput { get; }

	// Methods

	// RVA: 0xC01070 Offset: 0xBFFA70 VA: 0x180C01070 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0xC00760 Offset: 0xBFF160 VA: 0x180C00760
	private void OnValidate() { }

	// RVA: 0xC00490 Offset: 0xBFEE90 VA: 0x180C00490
	private void OnEnable() { }

	// RVA: 0xC00490 Offset: 0xBFEE90 VA: 0x180C00490
	public void UpdateInputAxisProvider() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public override void PrePipelineMutateCameraState(ref CameraState state, float deltaTime) { }

	// RVA: 0xBFFE20 Offset: 0xBFE820 VA: 0x180BFFE20 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0xBFFB00 Offset: 0xBFE500 VA: 0x180BFFB00
	public Vector2 GetRecenterTarget() { }

	// RVA: 0xC00460 Offset: 0xBFEE60 VA: 0x180C00460
	private static float NormalizeAngle(float angle) { }

	// RVA: 0xBFFAE0 Offset: 0xBFE4E0 VA: 0x180BFFAE0 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0xC00570 Offset: 0xBFEF70 VA: 0x180C00570 Slot: 9
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 13
	public override bool get_RequiresUserInput() { }

	// RVA: 0xC007B0 Offset: 0xBFF1B0 VA: 0x180C007B0
	private void SetAxesForRotation(Quaternion targetRot) { }

	// RVA: 0xC00DE0 Offset: 0xBFF7E0 VA: 0x180C00DE0
	public void .ctor() { }
}
