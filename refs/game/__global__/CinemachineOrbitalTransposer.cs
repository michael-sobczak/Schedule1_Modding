public class CinemachineOrbitalTransposer : CinemachineTransposer // TypeDefIndex: 16111
{
	// Fields
	[Space]
	[OrbitalTransposerHeadingProperty]
	[Tooltip("The definition of Forward.  Camera will follow behind.")]
	public CinemachineOrbitalTransposer.Heading m_Heading; // 0xA0
	[Tooltip("Automatic heading recentering.  The settings here defines how the camera will reposition itself in the absence of player input.")]
	public AxisState.Recentering m_RecenterToTargetHeading; // 0xAC
	[Tooltip("Heading Control.  The settings here control the behaviour of the camera in response to the player's input.")]
	[AxisStateProperty]
	public AxisState m_XAxis; // 0xD0
	[FormerlySerializedAs("m_Radius")]
	[HideInInspector]
	[SerializeField]
	private float m_LegacyRadius; // 0x140
	[FormerlySerializedAs("m_HeightOffset")]
	[HideInInspector]
	[SerializeField]
	private float m_LegacyHeightOffset; // 0x144
	[HideInInspector]
	[FormerlySerializedAs("m_HeadingBias")]
	[SerializeField]
	private float m_LegacyHeadingBias; // 0x148
	[NoSaveDuringPlay]
	[HideInInspector]
	public bool m_HeadingIsSlave; // 0x14C
	internal CinemachineOrbitalTransposer.UpdateHeadingDelegate HeadingUpdater; // 0x150
	private Vector3 m_LastTargetPosition; // 0x158
	private HeadingTracker mHeadingTracker; // 0x168
	private Rigidbody m_TargetRigidBody; // 0x170
	private Transform m_PreviousTarget; // 0x178
	private Vector3 m_LastCameraPosition; // 0x180
	private float m_LastHeading; // 0x18C

	// Properties
	public override bool RequiresUserInput { get; }

	// Methods

	// RVA: 0xBFF2F0 Offset: 0xBFDCF0 VA: 0x180BFF2F0 Slot: 14
	protected override void OnValidate() { }

	// RVA: 0xBFF440 Offset: 0xBFDE40 VA: 0x180BFF440
	public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis) { }

	// RVA: 0xBFF480 Offset: 0xBFDE80 VA: 0x180BFF480
	public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis, ref AxisState.Recentering recentering, bool isLive) { }

	// RVA: 0xBFEEA0 Offset: 0xBFD8A0 VA: 0x180BFEEA0
	private void OnEnable() { }

	// RVA: 0xBFF5D0 Offset: 0xBFDFD0 VA: 0x180BFF5D0
	public void UpdateInputAxisProvider() { }

	// RVA: 0xBFEFC0 Offset: 0xBFD9C0 VA: 0x180BFEFC0 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0xBFD8A0 Offset: 0xBFC2A0 VA: 0x180BFD8A0 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0xBFF0F0 Offset: 0xBFDAF0 VA: 0x180BFF0F0 Slot: 9
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) { }

	// RVA: 0xBFDA00 Offset: 0xBFC400 VA: 0x180BFDA00
	public float GetAxisClosestValue(Vector3 cameraPos, Vector3 up) { }

	// RVA: 0xBFE6A0 Offset: 0xBFD0A0 VA: 0x180BFE6A0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0xBFDF20 Offset: 0xBFC920 VA: 0x180BFDF20 Slot: 15
	public override Vector3 GetTargetCameraPosition(Vector3 worldUp) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 13
	public override bool get_RequiresUserInput() { }

	// RVA: 0xBFE230 Offset: 0xBFCC30 VA: 0x180BFE230
	private float GetTargetHeading(float currentHeading, Quaternion targetOrientation) { }

	// RVA: 0xBFF6A0 Offset: 0xBFE0A0 VA: 0x180BFF6A0
	public void .ctor() { }
}
