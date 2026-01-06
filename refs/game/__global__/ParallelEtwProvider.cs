internal sealed class ParallelEtwProvider : EventSource // TypeDefIndex: 4026
{
	// Fields
	public static readonly ParallelEtwProvider Log; // 0x0

	// Methods

	// RVA: 0x1C0B270 Offset: 0x1C09C70 VA: 0x181C0B270
	private void .ctor() { }

	[Event(1, Level = 4, Task = 1, Opcode = 1)]
	// RVA: 0x1CF1C70 Offset: 0x1CF0670 VA: 0x181CF1C70
	public void ParallelLoopBegin(int OriginatingTaskSchedulerID, int OriginatingTaskID, int ForkJoinContextID, ParallelEtwProvider.ForkJoinOperationType OperationType, long InclusiveFrom, long ExclusiveTo) { }

	[Event(2, Level = 4, Task = 1, Opcode = 2)]
	// RVA: 0x1CF1DD0 Offset: 0x1CF07D0 VA: 0x181CF1DD0
	public void ParallelLoopEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int ForkJoinContextID, long TotalIterations) { }

	[Event(5, Level = 5, Task = 5, Opcode = 1)]
	// RVA: 0x1CF1B90 Offset: 0x1CF0590 VA: 0x181CF1B90
	public void ParallelFork(int OriginatingTaskSchedulerID, int OriginatingTaskID, int ForkJoinContextID) { }

	[Event(6, Level = 5, Task = 5, Opcode = 2)]
	// RVA: 0x1CF1C00 Offset: 0x1CF0600 VA: 0x181CF1C00
	public void ParallelJoin(int OriginatingTaskSchedulerID, int OriginatingTaskID, int ForkJoinContextID) { }

	// RVA: 0x1CF1EF0 Offset: 0x1CF08F0 VA: 0x181CF1EF0
	private static void .cctor() { }
}
