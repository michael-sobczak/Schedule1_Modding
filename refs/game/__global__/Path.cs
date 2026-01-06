public abstract class Path : IPathInternals // TypeDefIndex: 13202
{
	// Fields
	protected PathHandler pathHandler; // 0x10
	public OnPathDelegate callback; // 0x18
	public OnPathDelegate immediateCallback; // 0x20
	[CompilerGenerated]
	private PathState <PipelineState>k__BackingField; // 0x28
	private object stateLock; // 0x30
	public ITraversalProvider traversalProvider; // 0x38
	protected PathCompleteState completeState; // 0x40
	[CompilerGenerated]
	private string <errorLog>k__BackingField; // 0x48
	public List<GraphNode> path; // 0x50
	public List<Vector3> vectorPath; // 0x58
	protected PathNode currentR; // 0x60
	public float duration; // 0x68
	[CompilerGenerated]
	private int <searchedNodes>k__BackingField; // 0x6C
	[CompilerGenerated]
	private bool <Pathfinding.IPathInternals.Pooled>k__BackingField; // 0x70
	protected bool hasBeenReset; // 0x71
	public NNConstraint nnConstraint; // 0x78
	internal Path next; // 0x80
	public Heuristic heuristic; // 0x88
	public float heuristicScale; // 0x8C
	[CompilerGenerated]
	private ushort <pathID>k__BackingField; // 0x90
	protected GraphNode hTargetNode; // 0x98
	protected Int3 hTarget; // 0xA0
	public int enabledTags; // 0xAC
	private static readonly int[] ZeroTagPenalties; // 0x0
	protected int[] internalTagPenalties; // 0xB0
	protected int[] manualTagPenalties; // 0xB8
	private List<object> claimed; // 0xC0
	private bool releasedNotSilent; // 0xC8

	// Properties
	public PathState PipelineState { get; set; }
	public PathCompleteState CompleteState { get; set; }
	public bool error { get; }
	public string errorLog { get; set; }
	public int searchedNodes { get; set; }
	private bool Pathfinding.IPathInternals.Pooled { get; set; }
	[Obsolete("Has been renamed to 'Pooled' to use more widely underestood terminology", True)]
	internal bool recycled { get; }
	public ushort pathID { get; set; }
	public int[] tagPenalties { get; set; }
	public virtual bool FloodingPath { get; }
	private PathHandler Pathfinding.IPathInternals.PathHandler { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public PathState get_PipelineState() { }

	[CompilerGenerated]
	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	private void set_PipelineState(PathState value) { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public PathCompleteState get_CompleteState() { }

	// RVA: 0xB2A730 Offset: 0xB29130 VA: 0x180B2A730
	protected void set_CompleteState(PathCompleteState value) { }

	// RVA: 0xB2A710 Offset: 0xB29110 VA: 0x180B2A710
	public bool get_error() { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public string get_errorLog() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	private void set_errorLog(string value) { }

	[CompilerGenerated]
	// RVA: 0xA9F7F0 Offset: 0xA9E1F0 VA: 0x180A9F7F0
	public int get_searchedNodes() { }

	[CompilerGenerated]
	// RVA: 0xA9F820 Offset: 0xA9E220 VA: 0x180A9F820
	protected void set_searchedNodes(int value) { }

	[CompilerGenerated]
	// RVA: 0x83DB90 Offset: 0x83C590 VA: 0x18083DB90 Slot: 5
	private bool Pathfinding.IPathInternals.get_Pooled() { }

	[CompilerGenerated]
	// RVA: 0x83DBC0 Offset: 0x83C5C0 VA: 0x18083DBC0 Slot: 6
	private void Pathfinding.IPathInternals.set_Pooled(bool value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	internal bool get_recycled() { }

	[CompilerGenerated]
	// RVA: 0xB2A720 Offset: 0xB29120 VA: 0x180B2A720
	public ushort get_pathID() { }

	[CompilerGenerated]
	// RVA: 0xB2A7D0 Offset: 0xB291D0 VA: 0x180B2A7D0
	private void set_pathID(ushort value) { }

	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	public int[] get_tagPenalties() { }

	// RVA: 0xB2A7E0 Offset: 0xB291E0 VA: 0x180B2A7E0
	public void set_tagPenalties(int[] value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 17
	public virtual bool get_FloodingPath() { }

	// RVA: 0xB293D0 Offset: 0xB27DD0 VA: 0x180B293D0
	public float GetTotalLength() { }

	[IteratorStateMachine(typeof(Path.<WaitForPath>d__54))]
	// RVA: 0xB2A550 Offset: 0xB28F50 VA: 0x180B2A550
	public IEnumerator WaitForPath() { }

	// RVA: 0xB28510 Offset: 0xB26F10 VA: 0x180B28510
	public void BlockUntilCalculated() { }

	// RVA: 0xB28560 Offset: 0xB26F60 VA: 0x180B28560
	internal uint CalculateHScore(GraphNode node) { }

	// RVA: 0xB293A0 Offset: 0xB27DA0 VA: 0x180B293A0
	public uint GetTagPenalty(int tag) { }

	// RVA: 0xB29380 Offset: 0xB27D80 VA: 0x180B29380
	protected Int3 GetHTarget() { }

	// RVA: 0xB288F0 Offset: 0xB272F0 VA: 0x180B288F0
	public bool CanTraverse(GraphNode node) { }

	// RVA: 0xB29580 Offset: 0xB27F80 VA: 0x180B29580
	public uint GetTraversalCost(GraphNode node) { }

	// RVA: 0xB29370 Offset: 0xB27D70 VA: 0x180B29370 Slot: 18
	public virtual uint GetConnectionSpecialCost(GraphNode a, GraphNode b, uint currentCost) { }

	// RVA: 0xB296B0 Offset: 0xB280B0 VA: 0x180B296B0
	public bool IsDone() { }

	// RVA: 0xB297E0 Offset: 0xB281E0 VA: 0x180B297E0 Slot: 7
	private void Pathfinding.IPathInternals.AdvanceState(PathState s) { }

	[Obsolete("Use the 'PipelineState' property instead")]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public PathState GetState() { }

	// RVA: 0xB292B0 Offset: 0xB27CB0 VA: 0x180B292B0
	public void FailWithError(string msg) { }

	[Obsolete("Use FailWithError instead")]
	// RVA: 0xB296C0 Offset: 0xB280C0 VA: 0x180B296C0
	protected void LogError(string msg) { }

	[Obsolete("Use FailWithError instead")]
	// RVA: 0xB296C0 Offset: 0xB280C0 VA: 0x180B296C0
	protected void Log(string msg) { }

	// RVA: 0xB292A0 Offset: 0xB27CA0 VA: 0x180B292A0
	public void Error() { }

	// RVA: 0xB291C0 Offset: 0xB27BC0 VA: 0x180B291C0
	private void ErrorCheck() { }

	// RVA: 0xB296F0 Offset: 0xB280F0 VA: 0x180B296F0 Slot: 19
	protected virtual void OnEnterPool() { }

	// RVA: 0xB29E50 Offset: 0xB28850 VA: 0x180B29E50 Slot: 20
	protected virtual void Reset() { }

	// RVA: 0xB289F0 Offset: 0xB273F0 VA: 0x180B289F0
	public void Claim(object o) { }

	[Obsolete("Use Release(o, true) instead")]
	// RVA: 0xB29B80 Offset: 0xB28580 VA: 0x180B29B80
	internal void ReleaseSilent(object o) { }

	// RVA: 0xB29B90 Offset: 0xB28590 VA: 0x180B29B90
	public void Release(object o, bool silent = False) { }

	// RVA: 0xB2A190 Offset: 0xB28B90 VA: 0x180B2A190 Slot: 21
	protected virtual void Trace(PathNode from) { }

	// RVA: 0xB28C10 Offset: 0xB27610 VA: 0x180B28C10
	protected void DebugStringPrefix(PathLog logMode, StringBuilder text) { }

	// RVA: 0xB28DA0 Offset: 0xB277A0 VA: 0x180B28DA0
	protected void DebugStringSuffix(PathLog logMode, StringBuilder text) { }

	// RVA: 0xB28F90 Offset: 0xB27990 VA: 0x180B28F90 Slot: 22
	protected virtual string DebugString(PathLog logMode) { }

	// RVA: 0xB2A170 Offset: 0xB28B70 VA: 0x180B2A170 Slot: 23
	protected virtual void ReturnPath() { }

	// RVA: 0xB29950 Offset: 0xB28350 VA: 0x180B29950
	protected void PrepareBase(PathHandler pathHandler) { }

	// RVA: -1 Offset: -1 Slot: 24
	protected abstract void Prepare();

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 25
	protected virtual void Cleanup() { }

	// RVA: -1 Offset: -1 Slot: 26
	protected abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 27
	protected abstract void CalculateStep(long targetTick);

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 4
	private PathHandler Pathfinding.IPathInternals.get_PathHandler() { }

	// RVA: 0xB1DDB0 Offset: 0xB1C7B0 VA: 0x180B1DDB0 Slot: 8
	private void Pathfinding.IPathInternals.OnEnterPool() { }

	// RVA: 0x7722F0 Offset: 0x770CF0 VA: 0x1807722F0 Slot: 9
	private void Pathfinding.IPathInternals.Reset() { }

	// RVA: 0x7C9EE0 Offset: 0x7C88E0 VA: 0x1807C9EE0 Slot: 10
	private void Pathfinding.IPathInternals.ReturnPath() { }

	// RVA: 0xB29920 Offset: 0xB28320 VA: 0x180B29920 Slot: 11
	private void Pathfinding.IPathInternals.PrepareBase(PathHandler handler) { }

	// RVA: 0xB29930 Offset: 0xB28330 VA: 0x180B29930 Slot: 12
	private void Pathfinding.IPathInternals.Prepare() { }

	// RVA: 0xB298E0 Offset: 0xB282E0 VA: 0x180B298E0 Slot: 14
	private void Pathfinding.IPathInternals.Cleanup() { }

	// RVA: 0xB29900 Offset: 0xB28300 VA: 0x180B29900 Slot: 13
	private void Pathfinding.IPathInternals.Initialize() { }

	// RVA: 0xB298C0 Offset: 0xB282C0 VA: 0x180B298C0 Slot: 15
	private void Pathfinding.IPathInternals.CalculateStep(long targetTick) { }

	// RVA: 0xB1E130 Offset: 0xB1CB30 VA: 0x180B1E130 Slot: 16
	private string Pathfinding.IPathInternals.DebugString(PathLog logMode) { }

	// RVA: 0xB2A630 Offset: 0xB29030 VA: 0x180B2A630
	protected void .ctor() { }

	// RVA: 0xB2A5C0 Offset: 0xB28FC0 VA: 0x180B2A5C0
	private static void .cctor() { }
}
