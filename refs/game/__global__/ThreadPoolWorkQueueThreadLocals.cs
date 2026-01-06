internal sealed class ThreadPoolWorkQueueThreadLocals // TypeDefIndex: 3985
{
	// Fields
	[ThreadStatic]
	public static ThreadPoolWorkQueueThreadLocals threadLocals; // 0x80000000
	public readonly ThreadPoolWorkQueue workQueue; // 0x10
	public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue; // 0x18
	public readonly Random random; // 0x20

	// Methods

	// RVA: 0x1D023C0 Offset: 0x1D00DC0 VA: 0x181D023C0
	public void .ctor(ThreadPoolWorkQueue tpq) { }

	// RVA: 0x1D02230 Offset: 0x1D00C30 VA: 0x181D02230
	private void CleanUp() { }

	// RVA: 0x1D02330 Offset: 0x1D00D30 VA: 0x181D02330 Slot: 1
	protected override void Finalize() { }
}
