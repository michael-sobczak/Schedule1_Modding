public class Cinemachine3rdPersonAim : CinemachineExtension // TypeDefIndex: 16036
{
	// Fields
	[Tooltip("Objects on these layers will be detected")]
	[Header("Aim Target Detection")]
	public LayerMask AimCollisionFilter; // 0x30
	[Tooltip("Objects with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
	[TagField]
	public string IgnoreTag; // 0x38
	[Tooltip("How far to project the object detection ray")]
	public float AimDistance; // 0x40
	[Tooltip("This 2D object will be positioned in the game view over the raycast hit point, if any, or will remain in the center of the screen if no hit point is detected.  May be null, in which case no on-screen indicator will appear")]
	public RectTransform AimTargetReticle; // 0x48
	[CompilerGenerated]
	private Vector3 <AimTarget>k__BackingField; // 0x50

	// Properties
	public Vector3 AimTarget { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4CD420 Offset: 0x4CBE20 VA: 0x1804CD420
	public Vector3 get_AimTarget() { }

	[CompilerGenerated]
	// RVA: 0xAEE570 Offset: 0xAECF70 VA: 0x180AEE570
	private void set_AimTarget(Vector3 value) { }

	// RVA: 0xBDAAD0 Offset: 0xBD94D0 VA: 0x180BDAAD0
	private void OnValidate() { }

	// RVA: 0xBDAEA0 Offset: 0xBD98A0 VA: 0x180BDAEA0
	private void Reset() { }

	// RVA: 0xBDA9A0 Offset: 0xBD93A0 VA: 0x180BDA9A0 Slot: 12
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0xBDA630 Offset: 0xBD9030 VA: 0x180BDA630
	private void DrawReticle(CinemachineBrain brain) { }

	// RVA: 0xBDA2A0 Offset: 0xBD8CA0 VA: 0x180BDA2A0
	private Vector3 ComputeLookAtPoint(Vector3 camPos, Transform player) { }

	// RVA: 0xBDA0D0 Offset: 0xBD8AD0 VA: 0x180BDA0D0
	private Vector3 ComputeAimTarget(Vector3 cameraLookAt, Transform player) { }

	// RVA: 0xBDAAF0 Offset: 0xBD94F0 VA: 0x180BDAAF0 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0xBDAF20 Offset: 0xBD9920 VA: 0x180BDAF20
	public void .ctor() { }
}
