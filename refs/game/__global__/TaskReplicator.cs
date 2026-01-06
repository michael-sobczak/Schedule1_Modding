internal class TaskReplicator // TypeDefIndex: 4039
{
	// Fields
	private readonly TaskScheduler _scheduler; // 0x10
	private readonly bool _stopOnFirstFailure; // 0x18
	private readonly ConcurrentQueue<TaskReplicator.Replica> _pendingReplicas; // 0x20
	private ConcurrentQueue<Exception> _exceptions; // 0x28
	private bool _stopReplicating; // 0x30

	// Methods

	// RVA: 0x1CF7F30 Offset: 0x1CF6930 VA: 0x181CF7F30
	private void .ctor(ParallelOptions options, bool stopOnFirstFailure) { }

	// RVA: -1 Offset: -1
	public static void Run<TState>(TaskReplicator.ReplicatableUserAction<TState> action, ParallelOptions options, bool stopOnFirstFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5D000 Offset: 0xF5BA00 VA: 0x180F5D000
	|-TaskReplicator.Run<RangeWorker>
	|
	|-RVA: 0xF5CE50 Offset: 0xF5B850 VA: 0x180F5CE50
	|-TaskReplicator.Run<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1CF7ED0 Offset: 0x1CF68D0 VA: 0x181CF7ED0
	private static int GenerateCooperativeMultitaskingTaskTimeout() { }
}
