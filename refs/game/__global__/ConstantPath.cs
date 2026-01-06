public class ConstantPath : Path // TypeDefIndex: 13313
{
	// Fields
	public GraphNode startNode; // 0xD0
	public Vector3 startPoint; // 0xD8
	public Vector3 originalStartPoint; // 0xE4
	public List<GraphNode> allNodes; // 0xF0
	public PathEndingCondition endingCondition; // 0xF8

	// Properties
	public override bool FloodingPath { get; }

	// Methods

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 17
	public override bool get_FloodingPath() { }

	// RVA: 0xB7DB30 Offset: 0xB7C530 VA: 0x180B7DB30
	public static ConstantPath Construct(Vector3 start, int maxGScore, OnPathDelegate callback) { }

	// RVA: 0xB7E140 Offset: 0xB7CB40 VA: 0x180B7E140
	protected void Setup(Vector3 start, int maxGScore, OnPathDelegate callback) { }

	// RVA: 0xB7DE90 Offset: 0xB7C890 VA: 0x180B7DE90 Slot: 19
	protected override void OnEnterPool() { }

	// RVA: 0xB7E000 Offset: 0xB7CA00 VA: 0x180B7E000 Slot: 20
	protected override void Reset() { }

	// RVA: 0xB7DF10 Offset: 0xB7C910 VA: 0x180B7DF10 Slot: 24
	protected override void Prepare() { }

	// RVA: 0xB7DC60 Offset: 0xB7C660 VA: 0x180B7DC60 Slot: 26
	protected override void Initialize() { }

	// RVA: 0xB7DA60 Offset: 0xB7C460 VA: 0x180B7DA60 Slot: 25
	protected override void Cleanup() { }

	// RVA: 0xB7D7D0 Offset: 0xB7C1D0 VA: 0x180B7D7D0 Slot: 27
	protected override void CalculateStep(long targetTick) { }

	// RVA: 0xB7E210 Offset: 0xB7CC10 VA: 0x180B7E210
	public void .ctor() { }
}
