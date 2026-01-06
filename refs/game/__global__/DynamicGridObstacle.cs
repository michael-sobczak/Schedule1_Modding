public class DynamicGridObstacle : GraphModifier // TypeDefIndex: 13334
{
	// Fields
	private Collider coll; // 0x40
	private Collider2D coll2D; // 0x48
	private Transform tr; // 0x50
	public float updateError; // 0x58
	public float checkTime; // 0x5C
	private Bounds prevBounds; // 0x60
	private Quaternion prevRotation; // 0x78
	private bool prevEnabled; // 0x88
	private float lastCheckTime; // 0x8C
	private Queue<GraphUpdateObject> pendingGraphUpdates; // 0x90

	// Properties
	private Bounds bounds { get; }
	private bool colliderEnabled { get; }

	// Methods

	// RVA: 0xB7F5A0 Offset: 0xB7DFA0 VA: 0x180B7F5A0
	private Bounds get_bounds() { }

	// RVA: 0xB7F6B0 Offset: 0xB7E0B0 VA: 0x180B7F6B0
	private bool get_colliderEnabled() { }

	// RVA: 0xB7E260 Offset: 0xB7CC60 VA: 0x180B7E260 Slot: 7
	protected override void Awake() { }

	// RVA: 0xB7EE70 Offset: 0xB7D870 VA: 0x180B7EE70 Slot: 13
	public override void OnPostScan() { }

	// RVA: 0xB7EF20 Offset: 0xB7D920 VA: 0x180B7EF20
	private void Update() { }

	// RVA: 0xB7ECB0 Offset: 0xB7D6B0 VA: 0x180B7ECB0 Slot: 11
	protected override void OnDisable() { }

	// RVA: 0xB7E510 Offset: 0xB7CF10 VA: 0x180B7E510
	public void DoUpdateGraphs() { }

	// RVA: 0xB7E470 Offset: 0xB7CE70 VA: 0x180B7E470
	private static float BoundsVolume(Bounds b) { }

	// RVA: 0xB7F4E0 Offset: 0xB7DEE0 VA: 0x180B7F4E0
	public void .ctor() { }
}
