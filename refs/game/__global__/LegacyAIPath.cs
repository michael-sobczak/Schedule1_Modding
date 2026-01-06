public class LegacyAIPath : AIPath // TypeDefIndex: 13347
{
	// Fields
	public float forwardLook; // 0x168
	public bool closestOnPathCheck; // 0x16C
	protected float minMoveScale; // 0x170
	protected int currentWaypointIndex; // 0x174
	protected Vector3 lastFoundWaypointPosition; // 0x178
	protected float lastFoundWaypointTime; // 0x184
	protected Vector3 targetDirection; // 0x188

	// Methods

	// RVA: 0xB84230 Offset: 0xB82C30 VA: 0x180B84230 Slot: 7
	protected override void Awake() { }

	// RVA: 0xB84B00 Offset: 0xB83500 VA: 0x180B84B00 Slot: 34
	protected override void OnPathComplete(Path _p) { }

	// RVA: 0xB85010 Offset: 0xB83A10 VA: 0x180B85010 Slot: 27
	protected override void Update() { }

	// RVA: 0xB85240 Offset: 0xB83C40 VA: 0x180B85240
	protected float XZSqrMagnitude(Vector3 a, Vector3 b) { }

	// RVA: 0xB84610 Offset: 0xB83010 VA: 0x180B84610
	protected Vector3 CalculateVelocity(Vector3 currentPosition) { }

	// RVA: 0xB84DE0 Offset: 0xB837E0 VA: 0x180B84DE0
	protected void RotateTowards(Vector3 dir) { }

	// RVA: 0xB843A0 Offset: 0xB82DA0 VA: 0x180B843A0
	protected Vector3 CalculateTargetPoint(Vector3 p, Vector3 a, Vector3 b) { }

	// RVA: 0xB85270 Offset: 0xB83C70 VA: 0x180B85270
	public void .ctor() { }
}
