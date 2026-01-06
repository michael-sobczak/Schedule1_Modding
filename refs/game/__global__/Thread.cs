public sealed class Thread : CriticalFinalizerObject // TypeDefIndex: 3973
{
	// Fields
	private static LocalDataStoreMgr s_LocalDataStoreMgr; // 0x0
	[ThreadStatic]
	private static LocalDataStoreHolder s_LocalDataStore; // 0x80000000
	[ThreadStatic]
	internal static CultureInfo m_CurrentCulture; // 0x80000008
	[ThreadStatic]
	internal static CultureInfo m_CurrentUICulture; // 0x80000010
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture; // 0x8
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture; // 0x10
	private InternalThread internal_thread; // 0x10
	private object m_ThreadStartArg; // 0x18
	private object pending_exception; // 0x20
	[ThreadStatic]
	private static Thread current_thread; // 0x80000018
	private MulticastDelegate m_Delegate; // 0x28
	private ExecutionContext m_ExecutionContext; // 0x30
	private bool m_ExecutionContextBelongsToOuterScope; // 0x38
	private IPrincipal principal; // 0x40
	private int principal_version; // 0x48

	// Properties
	internal bool ExecutionContextBelongsToCurrentScope { get; set; }
	public ThreadPriority Priority { set; }
	public CultureInfo CurrentUICulture { get; }
	public CultureInfo CurrentCulture { get; }
	private static LocalDataStoreMgr LocalDataStoreManager { get; }
	private InternalThread Internal { get; }
	public static Context CurrentContext { get; }
	public static Thread CurrentThread { get; }
	internal static int CurrentThreadId { get; }
	public bool IsThreadPoolThread { get; }
	internal bool IsThreadPoolThreadInternal { get; }
	public bool IsAlive { get; }
	public bool IsBackground { set; }
	public string Name { set; }
	public ThreadState ThreadState { get; }
	public int ManagedThreadId { get; }

	// Methods

	// RVA: 0x1CE6D10 Offset: 0x1CE5710 VA: 0x181CE6D10
	public void .ctor(ThreadStart start) { }

	// RVA: 0x1CE6D90 Offset: 0x1CE5790 VA: 0x181CE6D90
	public void .ctor(ParameterizedThreadStart start) { }

	// RVA: 0x1CE6C10 Offset: 0x1CE5610 VA: 0x181CE6C10
	public void .ctor(ParameterizedThreadStart start, int maxStackSize) { }

	// RVA: 0x1CE6910 Offset: 0x1CE5310 VA: 0x181CE6910
	public void Start() { }

	// RVA: 0x1CE6A80 Offset: 0x1CE5480 VA: 0x181CE6A80
	public void Start(object parameter) { }

	// RVA: 0x1CE6930 Offset: 0x1CE5330 VA: 0x181CE6930
	private void Start(ref StackCrawlMark stackMark) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CE5F70 Offset: 0x1CE4970 VA: 0x181CE5F70
	internal ExecutionContext.Reader GetExecutionContextReader() { }

	// RVA: 0x1CE6F50 Offset: 0x1CE5950 VA: 0x181CE6F50
	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	// RVA: 0x1CE70D0 Offset: 0x1CE5AD0 VA: 0x181CE70D0
	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1CE5FD0 Offset: 0x1CE49D0 VA: 0x181CE5FD0
	internal ExecutionContext GetMutableExecutionContext() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CE63D0 Offset: 0x1CE4DD0 VA: 0x181CE63D0
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CE63D0 Offset: 0x1CE4DD0 VA: 0x181CE63D0
	internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope) { }

	// RVA: 0x1CE6220 Offset: 0x1CE4C20 VA: 0x181CE6220
	public static void ResetAbort() { }

	// RVA: 0x1CE6210 Offset: 0x1CE4C10 VA: 0x181CE6210
	private void ResetAbortNative() { }

	// RVA: 0x1CE6470 Offset: 0x1CE4E70 VA: 0x181CE6470
	public void set_Priority(ThreadPriority value) { }

	// RVA: 0x1CE6470 Offset: 0x1CE4E70 VA: 0x181CE6470
	private void SetPriorityNative(int priority) { }

	// RVA: 0x1CE6150 Offset: 0x1CE4B50 VA: 0x181CE6150
	private bool JoinInternal(int millisecondsTimeout) { }

	// RVA: 0x1CE6160 Offset: 0x1CE4B60 VA: 0x181CE6160
	public void Join() { }

	// RVA: 0x1CE6170 Offset: 0x1CE4B70 VA: 0x181CE6170
	public bool Join(int millisecondsTimeout) { }

	// RVA: 0x1CE67C0 Offset: 0x1CE51C0 VA: 0x181CE67C0
	private static void SleepInternal(int millisecondsTimeout) { }

	// RVA: 0x1CE67D0 Offset: 0x1CE51D0 VA: 0x181CE67D0
	public static void Sleep(int millisecondsTimeout) { }

	// RVA: 0x1CE6C00 Offset: 0x1CE5600 VA: 0x181CE6C00
	private static bool YieldInternal() { }

	// RVA: 0x1CE6C00 Offset: 0x1CE5600 VA: 0x181CE6C00
	public static bool Yield() { }

	// RVA: 0x1CE6480 Offset: 0x1CE4E80 VA: 0x181CE6480
	private void SetStartHelper(Delegate start, int maxStackSize) { }

	// RVA: 0x1CE6070 Offset: 0x1CE4A70 VA: 0x181CE6070
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x1CE5EE0 Offset: 0x1CE48E0 VA: 0x181CE5EE0
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x1CE6310 Offset: 0x1CE4D10 VA: 0x181CE6310
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1CE6F10 Offset: 0x1CE5910 VA: 0x181CE6F10
	public CultureInfo get_CurrentUICulture() { }

	// RVA: 0x1CE5E40 Offset: 0x1CE4840 VA: 0x181CE5E40
	internal CultureInfo GetCurrentUICultureNoAppX() { }

	// RVA: 0x1CE6E10 Offset: 0x1CE5810 VA: 0x181CE6E10
	public CultureInfo get_CurrentCulture() { }

	// RVA: 0x1CE5D60 Offset: 0x1CE4760 VA: 0x181CE5D60
	private CultureInfo GetCurrentCultureNoAppX() { }

	// RVA: 0x1CE6200 Offset: 0x1CE4C00 VA: 0x181CE6200
	public static void MemoryBarrier() { }

	// RVA: 0x1CE7000 Offset: 0x1CE5A00 VA: 0x181CE7000
	private static LocalDataStoreMgr get_LocalDataStoreManager() { }

	// RVA: 0x1CE5C70 Offset: 0x1CE4670 VA: 0x181CE5C70
	private void ConstructInternalThread() { }

	// RVA: 0x1CE6F60 Offset: 0x1CE5960 VA: 0x181CE6F60
	private InternalThread get_Internal() { }

	// RVA: 0x1B0CA70 Offset: 0x1B0B470 VA: 0x181B0CA70
	public static Context get_CurrentContext() { }

	// RVA: 0x1CE5E00 Offset: 0x1CE4800 VA: 0x181CE5E00
	private static void GetCurrentThread_icall(ref Thread thread) { }

	// RVA: 0x1CE5E10 Offset: 0x1CE4810 VA: 0x181CE5E10
	private static Thread GetCurrentThread() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1CE6EC0 Offset: 0x1CE58C0 VA: 0x181CE6EC0
	public static Thread get_CurrentThread() { }

	// RVA: 0x1CE6E50 Offset: 0x1CE5850 VA: 0x181CE6E50
	internal static int get_CurrentThreadId() { }

	// RVA: 0x1CE5F60 Offset: 0x1CE4960 VA: 0x181CE5F60
	public static int GetDomainID() { }

	// RVA: 0x1CE6B70 Offset: 0x1CE5570 VA: 0x181CE6B70
	private bool Thread_internal(MulticastDelegate start) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CE5D20 Offset: 0x1CE4720 VA: 0x181CE5D20 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1CE6FC0 Offset: 0x1CE59C0 VA: 0x181CE6FC0
	public bool get_IsThreadPoolThread() { }

	// RVA: 0x1CE6FC0 Offset: 0x1CE59C0 VA: 0x181CE6FC0
	internal bool get_IsThreadPoolThreadInternal() { }

	// RVA: 0x1CE6F90 Offset: 0x1CE5990 VA: 0x181CE6F90
	public bool get_IsAlive() { }

	// RVA: 0x1CE70E0 Offset: 0x1CE5AE0 VA: 0x181CE70E0
	public void set_IsBackground(bool value) { }

	// RVA: 0x1CE6410 Offset: 0x1CE4E10 VA: 0x181CE6410
	private static void SetName_icall(InternalThread thread, char* name, int nameLength) { }

	// RVA: 0x1CE6420 Offset: 0x1CE4E20 VA: 0x181CE6420
	private static void SetName_internal(InternalThread thread, string name) { }

	// RVA: 0x1CE71B0 Offset: 0x1CE5BB0 VA: 0x181CE71B0
	public void set_Name(string value) { }

	// RVA: 0x1CE70A0 Offset: 0x1CE5AA0 VA: 0x181CE70A0
	public ThreadState get_ThreadState() { }

	// RVA: 0x1CE5B80 Offset: 0x1CE4580 VA: 0x181CE5B80
	private static void Abort_internal(InternalThread thread, object stateInfo) { }

	// RVA: 0x1CE5B90 Offset: 0x1CE4590 VA: 0x181CE5B90
	public void Abort() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void ClearAbortReason() { }

	// RVA: 0x1B963C0 Offset: 0x1B94DC0 VA: 0x181B963C0
	private static void SpinWait_nop() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CE6860 Offset: 0x1CE5260 VA: 0x181CE6860
	public static void SpinWait(int iterations) { }

	// RVA: 0x1CE6890 Offset: 0x1CE5290 VA: 0x181CE6890
	private void StartInternal(object principal, ref StackCrawlMark stackMark) { }

	// RVA: 0x1CE67B0 Offset: 0x1CE51B0 VA: 0x181CE67B0
	private static void SetState(InternalThread thread, ThreadState set) { }

	// RVA: 0x1CE5C60 Offset: 0x1CE4660 VA: 0x181CE5C60
	private static void ClrState(InternalThread thread, ThreadState clr) { }

	// RVA: 0x1CE6140 Offset: 0x1CE4B40 VA: 0x181CE6140
	private static ThreadState GetState(InternalThread thread) { }

	// RVA: 0x1CE6B60 Offset: 0x1CE5560 VA: 0x181CE6B60
	private static int SystemMaxStackStize() { }

	// RVA: 0x1CE60A0 Offset: 0x1CE4AA0 VA: 0x181CE60A0
	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	// RVA: 0x1CE6760 Offset: 0x1CE5160 VA: 0x181CE6760
	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CE5FA0 Offset: 0x1CE49A0 VA: 0x181CE5FA0
	public int get_ManagedThreadId() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1CE5BC0 Offset: 0x1CE45C0 VA: 0x181CE5BC0
	public static void BeginCriticalRegion() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CE5C80 Offset: 0x1CE4680 VA: 0x181CE5C80
	public static void EndCriticalRegion() { }

	[ComVisible(False)]
	// RVA: 0x1CE5FA0 Offset: 0x1CE49A0 VA: 0x181CE5FA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1CE6B80 Offset: 0x1CE5580 VA: 0x181CE6B80
	private ThreadState ValidateThreadState() { }
}
