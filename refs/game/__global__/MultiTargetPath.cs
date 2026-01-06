public class MultiTargetPath : ABPath // TypeDefIndex: 13320
{
	// Fields
	public OnPathDelegate[] callbacks; // 0x138
	public GraphNode[] targetNodes; // 0x140
	protected int targetNodeCount; // 0x148
	public bool[] targetsFound; // 0x150
	public Vector3[] targetPoints; // 0x158
	public Vector3[] originalTargetPoints; // 0x160
	public List<Vector3>[] vectorPaths; // 0x168
	public List<GraphNode>[] nodePaths; // 0x170
	public bool pathsForAll; // 0x178
	public int chosenTarget; // 0x17C
	private int sequentialTarget; // 0x180
	public MultiTargetPath.HeuristicMode heuristicMode; // 0x184
	[CompilerGenerated]
	private bool <inverted>k__BackingField; // 0x188

	// Properties
	public bool inverted { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xA59C90 Offset: 0xA58690 VA: 0x180A59C90
	public bool get_inverted() { }

	[CompilerGenerated]
	// RVA: 0xA59D10 Offset: 0xA58710 VA: 0x180A59D10
	protected void set_inverted(bool value) { }

	// RVA: 0xB8A460 Offset: 0xB88E60 VA: 0x180B8A460
	public void .ctor() { }

	// RVA: 0xB87C40 Offset: 0xB86640 VA: 0x180B87C40
	public static MultiTargetPath Construct(Vector3[] startPoints, Vector3 target, OnPathDelegate[] callbackDelegates, OnPathDelegate callback) { }

	// RVA: 0xB87B70 Offset: 0xB86570 VA: 0x180B87B70
	public static MultiTargetPath Construct(Vector3 start, Vector3[] targets, OnPathDelegate[] callbackDelegates, OnPathDelegate callback) { }

	// RVA: 0xB89FB0 Offset: 0xB889B0 VA: 0x180B89FB0
	protected void Setup(Vector3 start, Vector3[] targets, OnPathDelegate[] callbackDelegates, OnPathDelegate callback) { }

	// RVA: 0xB89AE0 Offset: 0xB884E0 VA: 0x180B89AE0 Slot: 20
	protected override void Reset() { }

	// RVA: 0xB88890 Offset: 0xB87290 VA: 0x180B88890 Slot: 19
	protected override void OnEnterPool() { }

	// RVA: 0xB87870 Offset: 0xB86270 VA: 0x180B87870
	private void ChooseShortestPath() { }

	// RVA: 0xB89DF0 Offset: 0xB887F0 VA: 0x180B89DF0
	private void SetPathParametersForReturn(int target) { }

	// RVA: 0xB89B30 Offset: 0xB88530 VA: 0x180B89B30 Slot: 23
	protected override void ReturnPath() { }

	// RVA: 0xB883C0 Offset: 0xB86DC0 VA: 0x180B883C0
	protected void FoundTarget(PathNode nodeR, int i) { }

	// RVA: 0xB89140 Offset: 0xB87B40 VA: 0x180B89140
	protected void RebuildOpenList() { }

	// RVA: 0xB88AD0 Offset: 0xB874D0 VA: 0x180B88AD0 Slot: 24
	protected override void Prepare() { }

	// RVA: 0xB891F0 Offset: 0xB87BF0 VA: 0x180B891F0
	private void RecalculateHTarget(bool firstTime) { }

	// RVA: 0xB88600 Offset: 0xB87000 VA: 0x180B88600 Slot: 26
	protected override void Initialize() { }

	// RVA: 0xB879B0 Offset: 0xB863B0 VA: 0x180B879B0 Slot: 25
	protected override void Cleanup() { }

	// RVA: 0xB89A30 Offset: 0xB88430 VA: 0x180B89A30
	private void ResetFlags() { }

	// RVA: 0xB87600 Offset: 0xB86000 VA: 0x180B87600 Slot: 27
	protected override void CalculateStep(long targetTick) { }

	// RVA: 0xB8A220 Offset: 0xB88C20 VA: 0x180B8A220 Slot: 21
	protected override void Trace(PathNode node) { }

	// RVA: 0xB87D20 Offset: 0xB86720 VA: 0x180B87D20 Slot: 22
	protected override string DebugString(PathLog logMode) { }
}
