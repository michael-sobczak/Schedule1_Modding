public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable // TypeDefIndex: 4053
{
	// Fields
	internal static int s_taskIdCounter; // 0x0
	private int m_taskId; // 0x10
	internal Delegate m_action; // 0x18
	internal object m_stateObject; // 0x20
	internal TaskScheduler m_taskScheduler; // 0x28
	internal readonly Task m_parent; // 0x30
	internal int m_stateFlags; // 0x38
	private const int OptionsMask = 65535;
	internal const int TASK_STATE_STARTED = 65536;
	internal const int TASK_STATE_DELEGATE_INVOKED = 131072;
	internal const int TASK_STATE_DISPOSED = 262144;
	internal const int TASK_STATE_EXCEPTIONOBSERVEDBYPARENT = 524288;
	internal const int TASK_STATE_CANCELLATIONACKNOWLEDGED = 1048576;
	internal const int TASK_STATE_FAULTED = 2097152;
	internal const int TASK_STATE_CANCELED = 4194304;
	internal const int TASK_STATE_WAITING_ON_CHILDREN = 8388608;
	internal const int TASK_STATE_RAN_TO_COMPLETION = 16777216;
	internal const int TASK_STATE_WAITINGFORACTIVATION = 33554432;
	internal const int TASK_STATE_COMPLETION_RESERVED = 67108864;
	internal const int TASK_STATE_THREAD_WAS_ABORTED = 134217728;
	internal const int TASK_STATE_WAIT_COMPLETION_NOTIFICATION = 268435456;
	private const int TASK_STATE_COMPLETED_MASK = 23068672;
	private const int CANCELLATION_REQUESTED = 1;
	private object m_continuationObject; // 0x40
	private static readonly object s_taskCompletionSentinel; // 0x8
	internal static bool s_asyncDebuggingEnabled; // 0x10
	internal Task.ContingentProperties m_contingentProperties; // 0x48
	private static readonly Action<object> s_taskCancelCallback; // 0x18
	[ThreadStatic]
	internal static Task t_currentTask; // 0x80000000
	[ThreadStatic]
	private static StackGuard t_stackGuard; // 0x80000008
	private static readonly Func<Task.ContingentProperties> s_createContingentProperties; // 0x20
	[CompilerGenerated]
	private static readonly TaskFactory <Factory>k__BackingField; // 0x28
	[CompilerGenerated]
	private static readonly Task <CompletedTask>k__BackingField; // 0x30
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; // 0x38
	private static ContextCallback s_ecCallback; // 0x40
	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate; // 0x48
	private static readonly Dictionary<int, Task> s_currentActiveTasks; // 0x50
	private static readonly object s_activeTasksLock; // 0x58

	// Properties
	internal TaskCreationOptions Options { get; }
	internal bool IsWaitNotificationEnabledOrNotRanToCompletion { get; }
	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion { get; }
	internal bool IsWaitNotificationEnabled { get; }
	public int Id { get; }
	public static Nullable<int> CurrentId { get; }
	internal static Task InternalCurrent { get; }
	internal static StackGuard CurrentStackGuard { get; }
	public AggregateException Exception { get; }
	public TaskStatus Status { get; }
	public bool IsCanceled { get; }
	internal bool IsCancellationRequested { get; }
	internal CancellationToken CancellationToken { get; }
	internal bool IsCancellationAcknowledged { get; }
	public bool IsCompleted { get; }
	public bool IsCompletedSuccessfully { get; }
	public TaskCreationOptions CreationOptions { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }
	public object AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	internal TaskScheduler ExecutingTaskScheduler { get; }
	public static TaskFactory Factory { get; }
	public static Task CompletedTask { get; }
	internal ManualResetEventSlim CompletedEvent { get; }
	internal bool ExceptionRecorded { get; }
	public bool IsFaulted { get; }
	internal ExecutionContext CapturedContext { get; set; }
	internal bool IsExceptionObservedByParent { get; }
	internal bool IsDelegateInvoked { get; }

	// Methods

	// RVA: 0x1D00BB0 Offset: 0x1CFF5B0 VA: 0x181D00BB0
	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	// RVA: 0x1D00E90 Offset: 0x1CFF890 VA: 0x181D00E90
	internal void .ctor() { }

	// RVA: 0x1D00EC0 Offset: 0x1CFF8C0 VA: 0x181D00EC0
	internal void .ctor(object state, TaskCreationOptions creationOptions, bool promiseStyle) { }

	// RVA: 0x1D00B10 Offset: 0x1CFF510 VA: 0x181D00B10
	public void .ctor(Action action) { }

	// RVA: 0x1D010B0 Offset: 0x1CFFAB0 VA: 0x181D010B0
	public void .ctor(Action action, CancellationToken cancellationToken) { }

	// RVA: 0x1D01000 Offset: 0x1CFFA00 VA: 0x181D01000
	public void .ctor(Action<object> action, object state) { }

	// RVA: 0x1D00C80 Offset: 0x1CFF680 VA: 0x181D00C80
	public void .ctor(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }

	// RVA: 0x1D00DA0 Offset: 0x1CFF7A0 VA: 0x181D00DA0
	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x1CFF8A0 Offset: 0x1CFE2A0 VA: 0x181CFF8A0
	internal void TaskConstructorCore(Delegate action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x1CFA080 Offset: 0x1CF8A80 VA: 0x181CFA080
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	// RVA: 0x1CFF7B0 Offset: 0x1CFE1B0 VA: 0x181CFF7B0
	private static void TaskCancelCallback(object o) { }

	// RVA: 0x1CFFBD0 Offset: 0x1CFE5D0 VA: 0x181CFFBD0
	internal bool TrySetCanceled(CancellationToken tokenToRecord) { }

	// RVA: 0x1CFFBE0 Offset: 0x1CFE5E0 VA: 0x181CFFBE0
	internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x1CFFCD0 Offset: 0x1CFE6D0 VA: 0x181CFFCD0
	internal bool TrySetException(object exceptionObject) { }

	// RVA: 0x1D019E0 Offset: 0x1D003E0 VA: 0x181D019E0
	internal TaskCreationOptions get_Options() { }

	// RVA: 0xC81A80 Offset: 0xC80480 VA: 0x180C81A80
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	// RVA: 0x1CFA410 Offset: 0x1CF8E10 VA: 0x181CFA410
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	// RVA: 0x1CFA350 Offset: 0x1CF8D50 VA: 0x181CFA350
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	// RVA: 0x1CFED80 Offset: 0x1CFD780 VA: 0x181CFED80
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	// RVA: 0x1CFDD30 Offset: 0x1CFC730 VA: 0x181CFDD30
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	// RVA: 0x1D01990 Offset: 0x1D00390 VA: 0x181D01990
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	// RVA: 0x1D019C0 Offset: 0x1D003C0 VA: 0x181D019C0 Slot: 11
	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x1D019C0 Offset: 0x1D003C0 VA: 0x181D019C0
	internal bool get_IsWaitNotificationEnabled() { }

	// RVA: 0x1CFDD90 Offset: 0x1CFC790 VA: 0x181CFDD90
	private void NotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x1CFDD10 Offset: 0x1CFC710 VA: 0x181CFDD10
	internal bool MarkStarted() { }

	// RVA: 0x1CF9A80 Offset: 0x1CF8480 VA: 0x181CF9A80
	internal void AddNewChild() { }

	// RVA: 0x1CFB880 Offset: 0x1CFA280 VA: 0x181CFB880
	internal void DisregardChild() { }

	// RVA: 0x1CFF2F0 Offset: 0x1CFDCF0 VA: 0x181CFF2F0
	public void Start() { }

	// RVA: 0x1CFF350 Offset: 0x1CFDD50 VA: 0x181CFF350
	public void Start(TaskScheduler scheduler) { }

	// RVA: 0x1CFE520 Offset: 0x1CFCF20 VA: 0x181CFE520
	public void RunSynchronously(TaskScheduler scheduler) { }

	// RVA: 0x1CFD2E0 Offset: 0x1CFBCE0 VA: 0x181CFD2E0
	internal void InternalRunSynchronously(TaskScheduler scheduler, bool waitForCompletion) { }

	// RVA: 0x1CFD650 Offset: 0x1CFC050 VA: 0x181CFD650
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions) { }

	// RVA: 0x1D016E0 Offset: 0x1D000E0 VA: 0x181D016E0
	public int get_Id() { }

	// RVA: 0x1D01450 Offset: 0x1CFFE50 VA: 0x181D01450
	public static Nullable<int> get_CurrentId() { }

	// RVA: 0x1D01780 Offset: 0x1D00180 VA: 0x181D01780
	internal static Task get_InternalCurrent() { }

	// RVA: 0x1CFD250 Offset: 0x1CFBC50 VA: 0x181CFD250
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	// RVA: 0x1D01510 Offset: 0x1CFFF10 VA: 0x181D01510
	internal static StackGuard get_CurrentStackGuard() { }

	// RVA: 0x1D01640 Offset: 0x1D00040 VA: 0x181D01640
	public AggregateException get_Exception() { }

	// RVA: 0x1D01A30 Offset: 0x1D00430 VA: 0x181D01A30
	public TaskStatus get_Status() { }

	// RVA: 0x1D017D0 Offset: 0x1D001D0 VA: 0x181D017D0
	public bool get_IsCanceled() { }

	// RVA: 0x1D01820 Offset: 0x1D00220 VA: 0x181D01820
	internal bool get_IsCancellationRequested() { }

	// RVA: 0x1CFBA30 Offset: 0x1CFA430 VA: 0x181CFBA30
	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	// RVA: 0x1CFB940 Offset: 0x1CFA340 VA: 0x181CFB940
	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	// RVA: 0x1D01160 Offset: 0x1CFFB60 VA: 0x181D01160
	internal CancellationToken get_CancellationToken() { }

	// RVA: 0x1D01800 Offset: 0x1D00200 VA: 0x181D01800
	internal bool get_IsCancellationAcknowledged() { }

	// RVA: 0x1D018D0 Offset: 0x1D002D0 VA: 0x181D018D0 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x1CFDCC0 Offset: 0x1CFC6C0 VA: 0x181CFDCC0
	private static bool IsCompletedMethod(int flags) { }

	// RVA: 0x1D018A0 Offset: 0x1D002A0 VA: 0x181D018A0
	public bool get_IsCompletedSuccessfully() { }

	// RVA: 0x1D01400 Offset: 0x1CFFE00 VA: 0x181D01400
	public TaskCreationOptions get_CreationOptions() { }

	// RVA: 0x1CFF580 Offset: 0x1CFDF80 VA: 0x181CFF580 Slot: 7
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 8
	public object get_AsyncState() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	[CompilerGenerated]
	// RVA: 0x1D01690 Offset: 0x1D00090 VA: 0x181D01690
	public static TaskFactory get_Factory() { }

	[CompilerGenerated]
	// RVA: 0x1D013B0 Offset: 0x1CFFDB0 VA: 0x181D013B0
	public static Task get_CompletedTask() { }

	// RVA: 0x1D01210 Offset: 0x1CFFC10 VA: 0x181D01210
	internal ManualResetEventSlim get_CompletedEvent() { }

	// RVA: 0x1D015D0 Offset: 0x1CFFFD0 VA: 0x181D015D0
	internal bool get_ExceptionRecorded() { }

	// RVA: 0x1D01970 Offset: 0x1D00370 VA: 0x181D01970
	public bool get_IsFaulted() { }

	// RVA: 0x1D01190 Offset: 0x1CFFB90 VA: 0x181D01190
	internal ExecutionContext get_CapturedContext() { }

	// RVA: 0x1D01AC0 Offset: 0x1D004C0 VA: 0x181D01AC0
	internal void set_CapturedContext(ExecutionContext value) { }

	// RVA: 0x1CFB810 Offset: 0x1CFA210 VA: 0x181CFB810 Slot: 10
	public void Dispose() { }

	// RVA: 0x1CFB6A0 Offset: 0x1CFA0A0 VA: 0x181CFB6A0 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1CFEA00 Offset: 0x1CFD400 VA: 0x181CFEA00
	internal void ScheduleAndStart(bool needsProtection) { }

	// RVA: 0x1CF9700 Offset: 0x1CF8100 VA: 0x181CF9700
	internal void AddException(object exceptionObject) { }

	// RVA: 0x1CF93E0 Offset: 0x1CF7DE0 VA: 0x181CF93E0
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x1CFCCD0 Offset: 0x1CFB6D0 VA: 0x181CFCCD0
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	// RVA: 0x1CFCAB0 Offset: 0x1CFB4B0 VA: 0x181CFCAB0
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x1CFCA70 Offset: 0x1CFB470 VA: 0x181CFCA70
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x1CFFB80 Offset: 0x1CFE580 VA: 0x181CFFB80
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	// RVA: 0x1CFFDD0 Offset: 0x1CFE7D0 VA: 0x181CFFDD0
	internal void UpdateExceptionObservedStatus() { }

	// RVA: 0x1D01950 Offset: 0x1D00350 VA: 0x181D01950
	internal bool get_IsExceptionObservedByParent() { }

	// RVA: 0x1D01930 Offset: 0x1D00330 VA: 0x181D01930
	internal bool get_IsDelegateInvoked() { }

	// RVA: 0x1CFC750 Offset: 0x1CFB150 VA: 0x181CFC750
	internal void Finish(bool bUserDelegateExecuted) { }

	// RVA: 0x1CFC610 Offset: 0x1CFB010 VA: 0x181CFC610
	internal void FinishStageTwo() { }

	// RVA: 0x1CFC560 Offset: 0x1CFAF60 VA: 0x181CFC560
	internal void FinishStageThree() { }

	// RVA: 0x1CFDDC0 Offset: 0x1CFC7C0 VA: 0x181CFDDC0
	internal void ProcessChildCompletion(Task childTask) { }

	// RVA: 0x1CF9710 Offset: 0x1CF8110 VA: 0x181CF9710
	internal void AddExceptionsFromChildren() { }

	// RVA: 0x1CFBF00 Offset: 0x1CFA900 VA: 0x181CFBF00
	private void Execute() { }

	// RVA: 0x1CFF7A0 Offset: 0x1CFE1A0 VA: 0x181CFF7A0 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x1CFBB30 Offset: 0x1CFA530 VA: 0x181CFBB30
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	// RVA: 0x1CFBF40 Offset: 0x1CFA940 VA: 0x181CFBF40
	private static void ExecutionContextCallback(object obj) { }

	// RVA: 0x1CFCFE0 Offset: 0x1CFB9E0 VA: 0x181CFCFE0 Slot: 13
	internal virtual void InnerInvoke() { }

	// RVA: 0x1CFCED0 Offset: 0x1CFB8D0 VA: 0x181CFCED0
	private void HandleException(Exception unhandledException) { }

	// RVA: 0x1CF6580 Offset: 0x1CF4F80 VA: 0x181CF6580
	public TaskAwaiter GetAwaiter() { }

	// RVA: 0x1CFA5A0 Offset: 0x1CF8FA0 VA: 0x181CFA5A0
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x1CFEBB0 Offset: 0x1CFD5B0 VA: 0x181CFEBB0
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext) { }

	// RVA: 0x1CFFEE0 Offset: 0x1CFE8E0 VA: 0x181CFFEE0
	public void Wait() { }

	// RVA: 0x1CFFFE0 Offset: 0x1CFE9E0 VA: 0x181CFFFE0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1D00660 Offset: 0x1CFF060 VA: 0x181D00660
	private bool WrappedTryRunInline() { }

	// RVA: 0x1CFD7F0 Offset: 0x1CFC1F0 VA: 0x181CFD7F0
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1CFEE50 Offset: 0x1CFD850 VA: 0x181CFEE50
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1CFF190 Offset: 0x1CFDB90 VA: 0x181CFF190
	private bool SpinWait(int millisecondsTimeout) { }

	// RVA: 0x1CFD080 Offset: 0x1CFBA80 VA: 0x181CFD080
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	// RVA: 0x1CFE0E0 Offset: 0x1CFCAE0 VA: 0x181CFE0E0
	internal void RecordInternalCancellationRequest() { }

	// RVA: 0x1CFE050 Offset: 0x1CFCA50 VA: 0x181CFE050
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	// RVA: 0x1CFDF90 Offset: 0x1CFC990 VA: 0x181CFDF90
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x1CFA4D0 Offset: 0x1CF8ED0 VA: 0x181CFA4D0
	internal void CancellationCleanupLogic() { }

	// RVA: 0x1CFEB80 Offset: 0x1CFD580 VA: 0x181CFEB80
	private void SetCancellationAcknowledged() { }

	// RVA: 0x1CFBFD0 Offset: 0x1CFA9D0 VA: 0x181CFBFD0
	internal void FinishContinuations() { }

	// RVA: 0x1CFDCD0 Offset: 0x1CFC6D0 VA: 0x181CFDCD0
	private void LogFinishCompletionNotification() { }

	// RVA: 0x1CFA860 Offset: 0x1CF9260 VA: 0x181CFA860
	public Task ContinueWith(Action<Task> continuationAction) { }

	// RVA: 0x1CFA8D0 Offset: 0x1CF92D0 VA: 0x181CFA8D0
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	// RVA: 0x1CFA830 Offset: 0x1CF9230 VA: 0x181CFA830
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x1CFAB70 Offset: 0x1CF9570 VA: 0x181CFAB70
	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	// RVA: 0x1CFAE10 Offset: 0x1CF9810 VA: 0x181CFAE10
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	// RVA: 0x1CFA5C0 Offset: 0x1CF8FC0 VA: 0x181CFA5C0
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	// RVA: 0x1CF92F0 Offset: 0x1CF7CF0 VA: 0x181CF92F0
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	// RVA: 0x1CF9360 Offset: 0x1CF7D60 VA: 0x181CF9360
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	// RVA: 0x1CF9B80 Offset: 0x1CF8580 VA: 0x181CF9B80
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	// RVA: 0x1CF9E60 Offset: 0x1CF8860 VA: 0x181CF9E60
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	// RVA: 0x1CFE1A0 Offset: 0x1CFCBA0 VA: 0x181CFE1A0
	internal void RemoveContinuation(object continuationObject) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5E6D0 Offset: 0xF5D0D0 VA: 0x180F5E6D0
	|-Task.FromResult<Nullable<bool>>
	|
	|-RVA: 0xF5E7B0 Offset: 0xF5D1B0 VA: 0x180F5E7B0
	|-Task.FromResult<Nullable<DateTime>>
	|
	|-RVA: 0xF5E5C0 Offset: 0xF5CFC0 VA: 0x180F5E5C0
	|-Task.FromResult<Nullable<DateTimeOffset>>
	|
	|-RVA: 0xF5E530 Offset: 0xF5CF30 VA: 0x180F5E530
	|-Task.FromResult<Nullable<Decimal>>
	|
	|-RVA: 0xF5E650 Offset: 0xF5D050 VA: 0x180F5E650
	|-Task.FromResult<Nullable<double>>
	|
	|-RVA: 0xF5E740 Offset: 0xF5D140 VA: 0x180F5E740
	|-Task.FromResult<Nullable<int>>
	|
	|-RVA: 0xF5E360 Offset: 0xF5CD60 VA: 0x180F5E360
	|-Task.FromResult<bool>
	|
	|-RVA: 0xF5E4C0 Offset: 0xF5CEC0 VA: 0x180F5E4C0
	|-Task.FromResult<int>
	|
	|-RVA: 0xF5E830 Offset: 0xF5D230 VA: 0x180F5E830
	|-Task.FromResult<object>
	|
	|-RVA: 0xF5E3D0 Offset: 0xF5CDD0 VA: 0x180F5E3D0
	|-Task.FromResult<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1CFCA10 Offset: 0x1CFB410 VA: 0x181CFCA10
	public static Task FromException(Exception exception) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5E1C0 Offset: 0xF5CBC0 VA: 0x180F5E1C0
	|-Task.FromException<int>
	|
	|-RVA: 0xF5E290 Offset: 0xF5CC90 VA: 0x180F5E290
	|-Task.FromException<VoidTaskResult>
	|
	|-RVA: 0xF5E0F0 Offset: 0xF5CAF0 VA: 0x180F5E0F0
	|-Task.FromException<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1CFC920 Offset: 0x1CFB320 VA: 0x181CFC920
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	// RVA: 0x1CFC8D0 Offset: 0x1CFB2D0 VA: 0x181CFC8D0
	public static Task FromCanceled(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5D9C0 Offset: 0xF5C3C0 VA: 0x180F5D9C0
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0xF5DD50 Offset: 0xF5C750 VA: 0x180F5DD50
	|-Task.FromCancellation<int>
	|
	|-RVA: 0xF5DF20 Offset: 0xF5C920 VA: 0x180F5DF20
	|-Task.FromCancellation<object>
	|
	|-RVA: 0xF5DB90 Offset: 0xF5C590 VA: 0x180F5DB90
	|-Task.FromCancellation<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5D880 Offset: 0xF5C280 VA: 0x180F5D880
	|-Task.FromCanceled<int>
	|
	|-RVA: 0xF5D810 Offset: 0xF5C210 VA: 0x180F5D810
	|-Task.FromCanceled<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5DE50 Offset: 0xF5C850 VA: 0x180F5DE50
	|-Task.FromCancellation<int>
	|
	|-RVA: 0xF5E020 Offset: 0xF5CA20 VA: 0x180F5E020
	|-Task.FromCancellation<VoidTaskResult>
	|
	|-RVA: 0xF5DAC0 Offset: 0xF5C4C0 VA: 0x180F5DAC0
	|-Task.FromCancellation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1CFE590 Offset: 0x1CFCF90 VA: 0x181CFE590
	public static Task Run(Action action) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5EC20 Offset: 0xF5D620 VA: 0x180F5EC20
	|-Task.Run<int>
	|
	|-RVA: 0xF5ECF0 Offset: 0xF5D6F0 VA: 0x180F5ECF0
	|-Task.Run<object>
	|
	|-RVA: 0xF5E910 Offset: 0xF5D310 VA: 0x180F5E910
	|-Task.Run<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1CFE770 Offset: 0x1CFD170 VA: 0x181CFE770
	public static Task Run(Func<Task> function) { }

	// RVA: 0x1CFE7C0 Offset: 0x1CFD1C0 VA: 0x181CFE7C0
	public static Task Run(Func<Task> function, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5EDC0 Offset: 0xF5D7C0 VA: 0x180F5EDC0
	|-Task.Run<object>
	|
	|-RVA: 0xF5E8A0 Offset: 0xF5D2A0 VA: 0x180F5E8A0
	|-Task.Run<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5EE30 Offset: 0xF5D830 VA: 0x180F5EE30
	|-Task.Run<object>
	|
	|-RVA: 0xF5E9E0 Offset: 0xF5D3E0 VA: 0x180F5E9E0
	|-Task.Run<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1CFAF70 Offset: 0x1CF9970 VA: 0x181CFAF70
	public static Task Delay(TimeSpan delay, CancellationToken cancellationToken) { }

	// RVA: 0x1CFB070 Offset: 0x1CF9A70 VA: 0x181CFB070
	public static Task Delay(int millisecondsDelay) { }

	// RVA: 0x1CFB0C0 Offset: 0x1CF9AC0 VA: 0x181CFB0C0
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	// RVA: 0x1D00410 Offset: 0x1CFEE10 VA: 0x181D00410
	public static Task<Task> WhenAny(Task[] tasks) { }

	// RVA: 0x1D00150 Offset: 0x1CFEB50 VA: 0x181D00150
	public static Task<Task> WhenAny(IEnumerable<Task> tasks) { }

	[FriendAccessAllowed]
	// RVA: 0x1CF9F40 Offset: 0x1CF8940 VA: 0x181CF9F40
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowed]
	// RVA: 0x1CFE400 Offset: 0x1CFCE00 VA: 0x181CFE400
	internal static void RemoveFromActiveTasks(int taskId) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public void MarkAborted(ThreadAbortException e) { }

	// RVA: 0x1CFBCE0 Offset: 0x1CFA6E0 VA: 0x181CFBCE0
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	// RVA: 0x1D00700 Offset: 0x1CFF100 VA: 0x181D00700
	private static void .cctor() { }
}
