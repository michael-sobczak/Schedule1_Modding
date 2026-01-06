public class Wheel : MonoBehaviour // TypeDefIndex: 2191
{
	// Fields
	public const float SIDEWAY_SLIP_THRESHOLD = 0.2;
	public const float FORWARD_SLIP_THRESHOLD = 0.8;
	public const float DRIFT_AUDIO_THRESHOLD = 0.2;
	public const float MIN_SPEED_FOR_DRIFT = 8;
	public const float WHEEL_ANIMATION_DISTANCE = 40;
	public const float HandbrakeFowardStiffnessMultiplier_Front = 0.9;
	public const float HandbrakeSidewayStiffnessMultiplier_Front = 0.7;
	public const float HandbrakeFowardStiffnessMultiplier_Rear = 0.9;
	public const float HandbrakeSidewayStiffnessMultiplier_Rear = 0.3;
	public bool DEBUG_MODE; // 0x20
	[Header("References")]
	public Transform wheelModel; // 0x28
	public Transform modelContainer; // 0x30
	public WheelCollider wheelCollider; // 0x38
	public Transform axleConnectionPoint; // 0x40
	public Collider staticCollider; // 0x48
	public ParticleSystem DriftParticles; // 0x50
	[Header("Settings")]
	public bool DriftParticlesEnabled; // 0x58
	[Header("Drift Audio")]
	public bool DriftAudioEnabled; // 0x59
	public AudioSourceController DriftAudioSource; // 0x60
	private float defaultForwardStiffness; // 0x68
	private float defaultSidewaysStiffness; // 0x6C
	[CompilerGenerated]
	private bool <IsDrifting>k__BackingField; // 0x70
	[CompilerGenerated]
	private float <DriftTime>k__BackingField; // 0x74
	[CompilerGenerated]
	private float <DriftIntensity>k__BackingField; // 0x78
	[CompilerGenerated]
	private bool <IsSteerWheel>k__BackingField; // 0x7C
	private LandVehicle vehicle; // 0x80
	private Vector3 lastFixedUpdatePosition; // 0x88
	private WheelHit wheelData; // 0x98
	private WheelFrictionCurve forwardCurve; // 0xE0
	private WheelFrictionCurve sidewaysCurve; // 0xF4

	// Properties
	public bool IsDrifting { get; set; }
	public bool IsDrifting_Smoothed { get; }
	public float DriftTime { get; set; }
	public float DriftIntensity { get; set; }
	public bool IsSteerWheel { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x83DB90 Offset: 0x83C590 VA: 0x18083DB90
	public bool get_IsDrifting() { }

	[CompilerGenerated]
	// RVA: 0x83DBC0 Offset: 0x83C5C0 VA: 0x18083DBC0
	protected void set_IsDrifting(bool value) { }

	// RVA: 0x83DB80 Offset: 0x83C580 VA: 0x18083DB80
	public bool get_IsDrifting_Smoothed() { }

	[CompilerGenerated]
	// RVA: 0x4CD180 Offset: 0x4CBB80 VA: 0x1804CD180
	public float get_DriftTime() { }

	[CompilerGenerated]
	// RVA: 0x4E28F0 Offset: 0x4E12F0 VA: 0x1804E28F0
	protected void set_DriftTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x6A5230 Offset: 0x6A3C30 VA: 0x1806A5230
	public float get_DriftIntensity() { }

	[CompilerGenerated]
	// RVA: 0x83DBB0 Offset: 0x83C5B0 VA: 0x18083DBB0
	protected void set_DriftIntensity(float value) { }

	[CompilerGenerated]
	// RVA: 0x83DBA0 Offset: 0x83C5A0 VA: 0x18083DBA0
	public bool get_IsSteerWheel() { }

	[CompilerGenerated]
	// RVA: 0x83DBD0 Offset: 0x83C5D0 VA: 0x18083DBD0
	public void set_IsSteerWheel(bool value) { }

	// RVA: 0x83CE40 Offset: 0x83B840 VA: 0x18083CE40
	private void Awake() { }

	// RVA: 0x83D8E0 Offset: 0x83C2E0 VA: 0x18083D8E0 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x83D380 Offset: 0x83BD80 VA: 0x18083D380
	public void FixedUpdateWheel() { }

	// RVA: 0x83D180 Offset: 0x83BB80 VA: 0x18083D180
	public void FakeWheelRotation() { }

	// RVA: 0x83CE90 Offset: 0x83B890 VA: 0x18083CE90
	private void CheckDrifting() { }

	// RVA: 0x83DA90 Offset: 0x83C490 VA: 0x18083DA90
	private void UpdateDriftEffects() { }

	// RVA: 0x83D9A0 Offset: 0x83C3A0 VA: 0x18083D9A0
	private void UpdateDriftAudio() { }

	// RVA: 0x83CCC0 Offset: 0x83B6C0 VA: 0x18083CCC0
	private void ApplyFriction() { }

	// RVA: 0x83D680 Offset: 0x83C080 VA: 0x18083D680 Slot: 5
	public virtual void SetPhysicsEnabled(bool enabled) { }

	// RVA: 0x83D630 Offset: 0x83C030 VA: 0x18083D630
	public bool IsWheelGrounded() { }

	// RVA: 0x83DB10 Offset: 0x83C510 VA: 0x18083DB10
	public void .ctor() { }
}
