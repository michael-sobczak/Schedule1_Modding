public class GraphCollision // TypeDefIndex: 13220
{
	// Fields
	public ColliderType type; // 0x10
	public float diameter; // 0x14
	public float height; // 0x18
	public float collisionOffset; // 0x1C
	public RayDirection rayDirection; // 0x20
	public LayerMask mask; // 0x24
	public LayerMask heightMask; // 0x28
	public float fromHeight; // 0x2C
	public bool thickRaycast; // 0x30
	public float thickRaycastDiameter; // 0x34
	public bool unwalkableWhenNoGround; // 0x38
	public bool use2D; // 0x39
	public bool collisionCheck; // 0x3A
	public bool heightCheck; // 0x3B
	public Vector3 up; // 0x3C
	private Vector3 upheight; // 0x48
	private ContactFilter2D contactFilter; // 0x54
	private static Collider2D[] dummyArray; // 0x0
	private float finalRadius; // 0x70
	private float finalRaycastRadius; // 0x74
	public const float RaycastErrorMargin = 0.005;
	private RaycastHit[] hitBuffer; // 0x78

	// Methods

	// RVA: 0xB2F2E0 Offset: 0xB2DCE0 VA: 0x180B2F2E0
	public void Initialize(GraphTransform transform, float scale) { }

	// RVA: 0xB2EB20 Offset: 0xB2D520 VA: 0x180B2EB20
	public bool Check(Vector3 position) { }

	// RVA: 0xB2E670 Offset: 0xB2D070 VA: 0x180B2E670
	public Vector3 CheckHeight(Vector3 position) { }

	// RVA: 0xB2E6F0 Offset: 0xB2D0F0 VA: 0x180B2E6F0
	public Vector3 CheckHeight(Vector3 position, out RaycastHit hit, out bool walkable) { }

	// RVA: 0xB2E380 Offset: 0xB2CD80 VA: 0x180B2E380
	public RaycastHit[] CheckHeightAll(Vector3 position, out int numHits) { }

	// RVA: 0xB2F0C0 Offset: 0xB2DAC0 VA: 0x180B2F0C0
	public void DeserializeSettingsCompatibility(GraphSerializationContext ctx) { }

	// RVA: 0xB2F540 Offset: 0xB2DF40 VA: 0x180B2F540
	public void .ctor() { }

	// RVA: 0xB2F4D0 Offset: 0xB2DED0 VA: 0x180B2F4D0
	private static void .cctor() { }
}
