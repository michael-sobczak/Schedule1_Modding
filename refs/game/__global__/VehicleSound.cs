public class VehicleSound : MonoBehaviour // TypeDefIndex: 2193
{
	// Fields
	public const float COLLISION_SOUND_COOLDOWN = 0.5;
	public const float AUDIO_LERP_SPEED = 2;
	public const float MinCollisionMomentum = 4000;
	public const float MaxCollisionMomentum = 25000;
	public const float MinCollisionVolume = 0.2;
	public const float MaxCollisionVolume = 0.8;
	public const float MinCollisionPitch = 0.6;
	public const float MaxCollisionPitch = 1.1;
	public float EngineVolumeMultiplier; // 0x20
	public float EnginePitchMultiplier; // 0x24
	[Header("References")]
	public AudioSourceController EngineStartSource; // 0x28
	public AudioSourceController EngineIdleSource; // 0x30
	public AudioSourceController EngineLoopSource; // 0x38
	public AudioSourceController HandbrakeSource; // 0x40
	public AudioSourceController ImpactSound; // 0x48
	[Header("Engine Loop Settings")]
	public AnimationCurve EngineLoopPitchCurve; // 0x50
	public AnimationCurve EngineLoopVolumeCurve; // 0x58
	[CompilerGenerated]
	private LandVehicle <Vehicle>k__BackingField; // 0x60
	private float lastCollisionTime; // 0x68
	private float lastCollisionMomentum; // 0x6C
	private Coroutine volumeRoutine; // 0x70

	// Properties
	public LandVehicle Vehicle { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public LandVehicle get_Vehicle() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	private void set_Vehicle(LandVehicle value) { }

	// RVA: 0x83C1F0 Offset: 0x83ABF0 VA: 0x18083C1F0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x83C530 Offset: 0x83AF30 VA: 0x18083C530
	private void EngineStart() { }

	// RVA: 0x83C610 Offset: 0x83B010 VA: 0x18083C610
	private void HandbrakeApplied() { }

	// RVA: 0x83C8F0 Offset: 0x83B2F0 VA: 0x18083C8F0
	private void StartUpdateVolume() { }

	// RVA: 0x83CBB0 Offset: 0x83B5B0 VA: 0x18083CBB0
	private void UpdateIdle(bool engineRunning) { }

	// RVA: 0x83CA00 Offset: 0x83B400 VA: 0x18083CA00
	private void UpdateEngineLoop(bool engineRunning, float normalizedspeed) { }

	// RVA: 0x83C640 Offset: 0x83B040 VA: 0x18083C640
	private void OnCollision(Collision collision) { }

	// RVA: 0x7B3A50 Offset: 0x7B2450 VA: 0x1807B3A50
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(VehicleSound.<<StartUpdateVolume>g__Routine|27_0>d))]
	// RVA: 0x83C990 Offset: 0x83B390 VA: 0x18083C990
	private IEnumerator <StartUpdateVolume>g__Routine|27_0() { }
}
