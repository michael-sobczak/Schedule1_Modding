internal class TaskExceptionHolder // TypeDefIndex: 4074
{
	// Fields
	private static readonly bool s_failFastOnUnobservedException; // 0x0
	private readonly Task m_task; // 0x10
	private LowLevelListWithIList<ExceptionDispatchInfo> m_faultExceptions; // 0x18
	private ExceptionDispatchInfo m_cancellationException; // 0x20
	private bool m_isHandled; // 0x28

	// Properties
	internal bool ContainsFaultList { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(Task task) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	private static bool ShouldFailFastOnUnobservedException() { }

	// RVA: 0x1CF6EC0 Offset: 0x1CF58C0 VA: 0x181CF6EC0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1CF73C0 Offset: 0x1CF5DC0 VA: 0x181CF73C0
	internal bool get_ContainsFaultList() { }

	// RVA: 0x1CF6BC0 Offset: 0x1CF55C0 VA: 0x181CF6BC0
	internal void Add(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x1CF7280 Offset: 0x1CF5C80 VA: 0x181CF7280
	private void SetCancellationException(object exceptionObject) { }

	// RVA: 0x1CF6780 Offset: 0x1CF5180 VA: 0x181CF6780
	private void AddFaultException(object exceptionObject) { }

	// RVA: 0x1CF7210 Offset: 0x1CF5C10 VA: 0x181CF7210
	private void MarkAsUnhandled() { }

	// RVA: 0x1CF7190 Offset: 0x1CF5B90 VA: 0x181CF7190
	internal void MarkAsHandled(bool calledFromFinalizer) { }

	// RVA: 0x1CF6CD0 Offset: 0x1CF56D0 VA: 0x181CF6CD0
	internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException) { }

	// RVA: 0x1CF70C0 Offset: 0x1CF5AC0 VA: 0x181CF70C0
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x1CF7380 Offset: 0x1CF5D80 VA: 0x181CF7380
	private static void .cctor() { }
}
