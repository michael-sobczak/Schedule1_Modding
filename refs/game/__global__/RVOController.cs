public class RVOController : VersionedMonoBehaviour // TypeDefIndex: 13426
{
	// Fields
	[FormerlySerializedAs("radius")]
	[SerializeField]
	internal float radiusBackingField; // 0x28
	[SerializeField]
	[FormerlySerializedAs("height")]
	private float heightBackingField; // 0x2C
	[SerializeField]
	[FormerlySerializedAs("center")]
	private float centerBackingField; // 0x30
	[Tooltip("A locked unit cannot move. Other units will still avoid it. But avoidance quality is not the best")]
	public bool locked; // 0x34
	[Tooltip("Automatically set #locked to true when desired velocity is approximately zero")]
	public bool lockWhenNotMoving; // 0x35
	[Tooltip("How far into the future to look for collisions with other agents (in seconds)")]
	public float agentTimeHorizon; // 0x38
	[Tooltip("How far into the future to look for collisions with obstacles (in seconds)")]
	public float obstacleTimeHorizon; // 0x3C
	[Tooltip("Max number of other agents to take into account.
A smaller value can reduce CPU load, a higher value can lead to better local avoidance quality.")]
	public int maxNeighbours; // 0x40
	public RVOLayer layer; // 0x44
	[EnumFlag]
	public RVOLayer collidesWith; // 0x48
	[Obsolete]
	[HideInInspector]
	public float wallAvoidForce; // 0x4C
	[HideInInspector]
	[Obsolete]
	public float wallAvoidFalloff; // 0x50
	[Tooltip("How strongly other agents will avoid this agent")]
	[Range(0, 1)]
	public float priority; // 0x54
	[CompilerGenerated]
	private IAgent <rvoAgent>k__BackingField; // 0x58
	[CompilerGenerated]
	private Simulator <simulator>k__BackingField; // 0x60
	protected Transform tr; // 0x68
	[SerializeField]
	[FormerlySerializedAs("ai")]
	private IAstarAI aiBackingField; // 0x70
	public bool debug; // 0x78

	// Properties
	public float radius { get; set; }
	public float height { get; set; }
	public float center { get; set; }
	[Obsolete("This field is obsolete in version 4.0 and will not affect anything. Use the LegacyRVOController if you need the old behaviour")]
	public LayerMask mask { get; set; }
	[Obsolete("This field is obsolete in version 4.0 and will not affect anything. Use the LegacyRVOController if you need the old behaviour")]
	public bool enableRotation { get; set; }
	[Obsolete("This field is obsolete in version 4.0 and will not affect anything. Use the LegacyRVOController if you need the old behaviour")]
	public float rotationSpeed { get; set; }
	[Obsolete("This field is obsolete in version 4.0 and will not affect anything. Use the LegacyRVOController if you need the old behaviour")]
	public float maxSpeed { get; set; }
	public MovementPlane movementPlane { get; }
	public IAgent rvoAgent { get; set; }
	public Simulator simulator { get; set; }
	protected IAstarAI ai { get; set; }
	public Vector3 position { get; }
	public Vector3 velocity { get; set; }

	// Methods

	// RVA: 0xBC3DA0 Offset: 0xBC27A0 VA: 0x180BC3DA0
	public float get_radius() { }

	// RVA: 0xBC40E0 Offset: 0xBC2AE0 VA: 0x180BC40E0
	public void set_radius(float value) { }

	// RVA: 0xBC3B80 Offset: 0xBC2580 VA: 0x180BC3B80
	public float get_height() { }

	// RVA: 0xBC4060 Offset: 0xBC2A60 VA: 0x180BC4060
	public void set_height(float value) { }

	// RVA: 0xBC3B00 Offset: 0xBC2500 VA: 0x180BC3B00
	public float get_center() { }

	// RVA: 0x49D320 Offset: 0x49BD20 VA: 0x18049D320
	public void set_center(float value) { }

	// RVA: 0xBC3BF0 Offset: 0xBC25F0 VA: 0x180BC3BF0
	public LayerMask get_mask() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void set_mask(LayerMask value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public bool get_enableRotation() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void set_enableRotation(bool value) { }

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590
	public float get_rotationSpeed() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void set_rotationSpeed(float value) { }

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590
	public float get_maxSpeed() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void set_maxSpeed(float value) { }

	// RVA: 0xBC3C00 Offset: 0xBC2600 VA: 0x180BC3C00
	public MovementPlane get_movementPlane() { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public IAgent get_rvoAgent() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	private void set_rvoAgent(IAgent value) { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public Simulator get_simulator() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	private void set_simulator(Simulator value) { }

	// RVA: 0xBC3A30 Offset: 0xBC2430 VA: 0x180BC3A30
	protected IAstarAI get_ai() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	protected void set_ai(IAstarAI value) { }

	// RVA: 0xBC3CE0 Offset: 0xBC26E0 VA: 0x180BC3CE0
	public Vector3 get_position() { }

	// RVA: 0xBC3E10 Offset: 0xBC2810 VA: 0x180BC3E10
	public Vector3 get_velocity() { }

	// RVA: 0xBC2680 Offset: 0xBC1080 VA: 0x180BC2680
	public void set_velocity(Vector3 value) { }

	// RVA: 0xBC2320 Offset: 0xBC0D20 VA: 0x180BC2320
	public Vector3 CalculateMovementDelta(float deltaTime) { }

	// RVA: 0xBC2530 Offset: 0xBC0F30 VA: 0x180BC2530
	public Vector3 CalculateMovementDelta(Vector3 position, float deltaTime) { }

	// RVA: 0xBC3320 Offset: 0xBC1D20 VA: 0x180BC3320
	public void SetCollisionNormal(Vector3 normal) { }

	[Obsolete("Set the 'velocity' property instead")]
	// RVA: 0xBC2680 Offset: 0xBC1080 VA: 0x180BC2680
	public void ForceSetVelocity(Vector3 velocity) { }

	// RVA: 0xBC3540 Offset: 0xBC1F40 VA: 0x180BC3540
	public Vector2 To2D(Vector3 p) { }

	// RVA: 0xBC34E0 Offset: 0xBC1EE0 VA: 0x180BC34E0
	public Vector2 To2D(Vector3 p, out float elevation) { }

	// RVA: 0xBC35A0 Offset: 0xBC1FA0 VA: 0x180BC35A0
	public Vector3 To3D(Vector2 p, float elevationCoordinate) { }

	// RVA: 0xBC28E0 Offset: 0xBC12E0 VA: 0x180BC28E0
	private void OnDisable() { }

	// RVA: 0xBC2E00 Offset: 0xBC1800 VA: 0x180BC2E00
	private void OnEnable() { }

	// RVA: 0xBC3610 Offset: 0xBC2010 VA: 0x180BC3610
	protected void UpdateAgentProperties() { }

	// RVA: 0xBC33C0 Offset: 0xBC1DC0 VA: 0x180BC33C0
	public void SetTarget(Vector3 pos, float speed, float maxSpeed) { }

	// RVA: 0xBC2720 Offset: 0xBC1120 VA: 0x180BC2720
	public void Move(Vector3 vel) { }

	[Obsolete("Use transform.position instead, the RVOController can now handle that without any issues.")]
	// RVA: 0xBC34A0 Offset: 0xBC1EA0 VA: 0x180BC34A0
	public void Teleport(Vector3 pos) { }

	// RVA: 0xBC2900 Offset: 0xBC1300 VA: 0x180BC2900
	private void OnDrawGizmos() { }

	// RVA: 0xBC3190 Offset: 0xBC1B90 VA: 0x180BC3190 Slot: 9
	protected override int OnUpgradeSerializedData(int version, bool unityThread) { }

	// RVA: 0xBC39D0 Offset: 0xBC23D0 VA: 0x180BC39D0
	public void .ctor() { }
}
