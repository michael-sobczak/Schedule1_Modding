public class PathProcessor // TypeDefIndex: 13186
{
	// Fields
	[CompilerGenerated]
	private Action<Path> OnPathPreSearch; // 0x10
	[CompilerGenerated]
	private Action<Path> OnPathPostSearch; // 0x18
	[CompilerGenerated]
	private Action OnQueueUnblocked; // 0x20
	internal readonly ThreadControlQueue queue; // 0x28
	private readonly AstarPath astar; // 0x30
	private readonly PathReturnQueue returnQueue; // 0x38
	private readonly PathHandler[] pathHandlers; // 0x40
	private readonly Thread[] threads; // 0x48
	private IEnumerator threadCoroutine; // 0x50
	private int nextNodeIndex; // 0x58
	private readonly Stack<int> nodeIndexPool; // 0x60
	private readonly List<int> locks; // 0x68
	private int nextLockID; // 0x70
	private CustomSampler profilingSampler; // 0x78

	// Properties
	public int NumThreads { get; }
	public bool IsUsingMultithreading { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xB27C80 Offset: 0xB26680 VA: 0x180B27C80
	public void add_OnPathPreSearch(Action<Path> value) { }

	[CompilerGenerated]
	// RVA: 0xB27EB0 Offset: 0xB268B0 VA: 0x180B27EB0
	public void remove_OnPathPreSearch(Action<Path> value) { }

	[CompilerGenerated]
	// RVA: 0xB27BD0 Offset: 0xB265D0 VA: 0x180B27BD0
	public void add_OnPathPostSearch(Action<Path> value) { }

	[CompilerGenerated]
	// RVA: 0xB27E00 Offset: 0xB26800 VA: 0x180B27E00
	public void remove_OnPathPostSearch(Action<Path> value) { }

	[CompilerGenerated]
	// RVA: 0xB27D30 Offset: 0xB26730 VA: 0x180B27D30
	public void add_OnQueueUnblocked(Action value) { }

	[CompilerGenerated]
	// RVA: 0xB27F60 Offset: 0xB26960 VA: 0x180B27F60
	public void remove_OnQueueUnblocked(Action value) { }

	// RVA: 0xB27DE0 Offset: 0xB267E0 VA: 0x180B27DE0
	public int get_NumThreads() { }

	// RVA: 0xB27DD0 Offset: 0xB267D0 VA: 0x180B27DD0
	public bool get_IsUsingMultithreading() { }

	// RVA: 0xB274D0 Offset: 0xB25ED0 VA: 0x180B274D0
	internal void .ctor(AstarPath astar, PathReturnQueue returnQueue, int processors, bool multithreaded) { }

	// RVA: 0xB27180 Offset: 0xB25B80 VA: 0x180B27180
	private int Lock(bool block) { }

	// RVA: 0xB273E0 Offset: 0xB25DE0 VA: 0x180B273E0
	private void Unlock(int id) { }

	// RVA: 0xB27290 Offset: 0xB25C90 VA: 0x180B27290
	public PathProcessor.GraphUpdateLock PausePathfinding(bool block) { }

	// RVA: 0xB272B0 Offset: 0xB25CB0 VA: 0x180B272B0
	public void TickNonMultithreaded() { }

	// RVA: 0xB27040 Offset: 0xB25A40 VA: 0x180B27040
	public void JoinThreads() { }

	// RVA: 0xB26280 Offset: 0xB24C80 VA: 0x180B26280
	public void AbortThreads() { }

	// RVA: 0xB26DE0 Offset: 0xB257E0 VA: 0x180B26DE0
	public int GetNewNodeIndex() { }

	// RVA: 0xB26E50 Offset: 0xB25850 VA: 0x180B26E50
	public void InitializeNode(GraphNode node) { }

	// RVA: 0xB26CA0 Offset: 0xB256A0 VA: 0x180B26CA0
	public void DestroyNode(GraphNode node) { }

	// RVA: 0xB26320 Offset: 0xB24D20 VA: 0x180B26320
	private void CalculatePathsThreaded(PathHandler pathHandler) { }

	[IteratorStateMachine(typeof(PathProcessor.<CalculatePaths>d__36))]
	// RVA: 0xB26C10 Offset: 0xB25610 VA: 0x180B26C10
	private IEnumerator CalculatePaths(PathHandler pathHandler) { }
}
