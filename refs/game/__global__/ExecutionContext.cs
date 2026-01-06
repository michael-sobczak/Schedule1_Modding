public sealed class ExecutionContext : IDisposable, ISerializable // TypeDefIndex: 3964
{
	// Fields
	private SynchronizationContext _syncContext; // 0x10
	private SynchronizationContext _syncContextNoFlow; // 0x18
	private LogicalCallContext _logicalCallContext; // 0x20
	private IllogicalCallContext _illogicalCallContext; // 0x28
	private ExecutionContext.Flags _flags; // 0x30
	private Dictionary<IAsyncLocal, object> _localValues; // 0x38
	private List<IAsyncLocal> _localChangeNotifications; // 0x40
	private static readonly ExecutionContext s_dummyDefaultEC; // 0x0
	internal static readonly ExecutionContext Default; // 0x8

	// Properties
	internal bool isNewCapture { get; set; }
	internal bool isFlowSuppressed { get; set; }
	internal bool IsPreAllocatedDefault { get; }
	internal LogicalCallContext LogicalCallContext { get; set; }
	internal IllogicalCallContext IllogicalCallContext { get; set; }
	internal SynchronizationContext SynchronizationContext { get; set; }
	internal SynchronizationContext SynchronizationContextNoFlow { get; set; }

	// Methods

	// RVA: 0x1CDE9F0 Offset: 0x1CDD3F0 VA: 0x181CDE9F0
	internal bool get_isNewCapture() { }

	// RVA: 0x1CDEA20 Offset: 0x1CDD420 VA: 0x181CDEA20
	internal void set_isNewCapture(bool value) { }

	// RVA: 0x1CDE9E0 Offset: 0x1CDD3E0 VA: 0x181CDE9E0
	internal bool get_isFlowSuppressed() { }

	// RVA: 0x1CDEA00 Offset: 0x1CDD400 VA: 0x181CDEA00
	internal void set_isFlowSuppressed(bool value) { }

	// RVA: 0x1CDE960 Offset: 0x1CDD360 VA: 0x181CDE960
	internal bool get_IsPreAllocatedDefault() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CDE780 Offset: 0x1CDD180 VA: 0x181CDE780
	internal void .ctor(bool isPreAllocatedDefault) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x1CDDC40 Offset: 0x1CDC640 VA: 0x181CDDC40
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current) { }

	// RVA: 0x1CDE970 Offset: 0x1CDD370 VA: 0x181CDE970
	internal LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	internal void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x1CDE8F0 Offset: 0x1CDD2F0 VA: 0x181CDE8F0
	internal IllogicalCallContext get_IllogicalCallContext() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	internal void set_IllogicalCallContext(IllogicalCallContext value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal SynchronizationContext get_SynchronizationContext() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	internal void set_SynchronizationContext(SynchronizationContext value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal SynchronizationContext get_SynchronizationContextNoFlow() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void set_SynchronizationContextNoFlow(SynchronizationContext value) { }

	// RVA: 0x9F93E0 Offset: 0x9F7DE0 VA: 0x1809F93E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1CDE3B0 Offset: 0x1CDCDB0 VA: 0x181CDE3B0
	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[FriendAccessAllowed]
	// RVA: 0x1CDE320 Offset: 0x1CDCD20 VA: 0x181CDE320
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	// RVA: 0x1CDE2A0 Offset: 0x1CDCCA0 VA: 0x181CDE2A0
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x1CDE000 Offset: 0x1CDCA00 VA: 0x181CDE000
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	// RVA: 0x1CDD8C0 Offset: 0x1CDC2C0 VA: 0x181CDD8C0
	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw) { }

	// RVA: 0x1CDD9A0 Offset: 0x1CDC3A0 VA: 0x181CDD9A0
	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x1CDE510 Offset: 0x1CDCF10 VA: 0x181CDE510
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx) { }

	// RVA: 0x1CDD580 Offset: 0x1CDBF80 VA: 0x181CDD580
	public ExecutionContext CreateCopy() { }

	// RVA: 0x1CDD710 Offset: 0x1CDC110 VA: 0x181CDD710
	internal ExecutionContext CreateMutableCopy() { }

	// RVA: 0x1CDDBB0 Offset: 0x1CDC5B0 VA: 0x181CDDBB0
	public static bool IsFlowSuppressed() { }

	// RVA: 0x1CDD530 Offset: 0x1CDBF30 VA: 0x181CDD530
	public static ExecutionContext Capture() { }

	[FriendAccessAllowed]
	// RVA: 0x1CDDA10 Offset: 0x1CDC410 VA: 0x181CDDA10
	internal static ExecutionContext FastCapture() { }

	// RVA: 0x1CDD2E0 Offset: 0x1CDBCE0 VA: 0x181CDD2E0
	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options) { }

	// RVA: 0x1CDDA60 Offset: 0x1CDC460 VA: 0x181CDDA60 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1CDE7B0 Offset: 0x1CDD1B0 VA: 0x181CDE7B0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1CDDB60 Offset: 0x1CDC560 VA: 0x181CDDB60
	internal bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x1CDE6C0 Offset: 0x1CDD0C0 VA: 0x181CDE6C0
	private static void .cctor() { }
}
