public class LightweightRVO : MonoBehaviour // TypeDefIndex: 13440
{
	// Fields
	public int agentCount; // 0x20
	public float exampleScale; // 0x24
	public LightweightRVO.RVOExampleType type; // 0x28
	public float radius; // 0x2C
	public float maxSpeed; // 0x30
	public float agentTimeHorizon; // 0x34
	[HideInInspector]
	public float obstacleTimeHorizon; // 0x38
	public int maxNeighbours; // 0x3C
	public Vector3 renderingOffset; // 0x40
	public bool debug; // 0x4C
	private Mesh mesh; // 0x50
	private Simulator sim; // 0x58
	private List<IAgent> agents; // 0x60
	private List<Vector3> goals; // 0x68
	private List<Color> colors; // 0x70
	private Vector3[] verts; // 0x78
	private Vector2[] uv; // 0x80
	private int[] tris; // 0x88
	private Color[] meshColors; // 0x90
	private Vector2[] interpolatedVelocities; // 0x98
	private Vector2[] interpolatedRotations; // 0xA0

	// Methods

	// RVA: 0xBC05D0 Offset: 0xBBEFD0 VA: 0x180BC05D0
	public void Start() { }

	// RVA: 0xBBFF30 Offset: 0xBBE930 VA: 0x180BBFF30
	public void OnGUI() { }

	// RVA: 0xBC1AC0 Offset: 0xBC04C0 VA: 0x180BC1AC0
	private float uniformDistance(float radius) { }

	// RVA: 0xBBED00 Offset: 0xBBD700 VA: 0x180BBED00
	public void CreateAgents(int num) { }

	// RVA: 0xBC02B0 Offset: 0xBBECB0 VA: 0x180BC02B0
	private void SetAgentSettings() { }

	// RVA: 0xBC07C0 Offset: 0xBBF1C0 VA: 0x180BC07C0
	public void Update() { }

	// RVA: 0xBC1A10 Offset: 0xBC0410 VA: 0x180BC1A10
	public void .ctor() { }
}
