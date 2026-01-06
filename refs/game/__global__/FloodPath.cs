public class FloodPath : Path // TypeDefIndex: 13316
{
	// Fields
	public Vector3 originalStartPoint; // 0xD0
	public Vector3 startPoint; // 0xDC
	public GraphNode startNode; // 0xE8
	public bool saveParents; // 0xF0
	protected Dictionary<GraphNode, GraphNode> parents; // 0xF8

	// Properties
	public override bool FloodingPath { get; }

	// Methods

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 17
	public override bool get_FloodingPath() { }

	// RVA: 0xB80960 Offset: 0xB7F360 VA: 0x180B80960
	public bool HasPathTo(GraphNode node) { }

	// RVA: 0xB80900 Offset: 0xB7F300 VA: 0x180B80900
	public GraphNode GetParent(GraphNode node) { }

	// RVA: 0xB80FE0 Offset: 0xB7F9E0 VA: 0x180B80FE0
	public void .ctor() { }

	// RVA: 0xB806C0 Offset: 0xB7F0C0 VA: 0x180B806C0
	public static FloodPath Construct(Vector3 start, OnPathDelegate callback) { }

	// RVA: 0xB80780 Offset: 0xB7F180 VA: 0x180B80780
	public static FloodPath Construct(GraphNode start, OnPathDelegate callback) { }

	// RVA: 0xB80F80 Offset: 0xB7F980 VA: 0x180B80F80
	protected void Setup(Vector3 start, OnPathDelegate callback) { }

	// RVA: 0xB80EB0 Offset: 0xB7F8B0 VA: 0x180B80EB0
	protected void Setup(GraphNode start, OnPathDelegate callback) { }

	// RVA: 0xB80D90 Offset: 0xB7F790 VA: 0x180B80D90 Slot: 20
	protected override void Reset() { }

	// RVA: 0xB80BB0 Offset: 0xB7F5B0 VA: 0x180B80BB0 Slot: 24
	protected override void Prepare() { }

	// RVA: 0xB809D0 Offset: 0xB7F3D0 VA: 0x180B809D0 Slot: 26
	protected override void Initialize() { }

	// RVA: 0xB80470 Offset: 0xB7EE70 VA: 0x180B80470 Slot: 27
	protected override void CalculateStep(long targetTick) { }
}
