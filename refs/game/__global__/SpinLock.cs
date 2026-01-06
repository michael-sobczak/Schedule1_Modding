public struct SpinLock // TypeDefIndex: 3957
{
	// Fields
	private int m_owner; // 0x0
	private static int MAXIMUM_WAITERS; // 0x0

	// Properties
	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }

	// Methods

	// RVA: 0x1CE4A30 Offset: 0x1CE3430 VA: 0x181CE4A30
	public void .ctor(bool enableThreadOwnerTracking) { }

	// RVA: 0x1CE46A0 Offset: 0x1CE30A0 VA: 0x181CE46A0
	public void Enter(ref bool lockTaken) { }

	// RVA: 0x1CE4920 Offset: 0x1CE3320 VA: 0x181CE4920
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1CE4110 Offset: 0x1CE2B10 VA: 0x181CE4110
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1CE45C0 Offset: 0x1CE2FC0 VA: 0x181CE45C0
	private void DecrementWaiters() { }

	// RVA: 0x1CE3E90 Offset: 0x1CE2890 VA: 0x181CE3E90
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CE4890 Offset: 0x1CE3290 VA: 0x181CE4890
	public void Exit(bool useMemoryBarrier) { }

	// RVA: 0x1CE4750 Offset: 0x1CE3150 VA: 0x181CE4750
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CE4A70 Offset: 0x1CE3470 VA: 0x181CE4A70
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CE4BA0 Offset: 0x1CE35A0 VA: 0x181CE4BA0
	public bool get_IsThreadOwnerTrackingEnabled() { }

	// RVA: 0x1CE49F0 Offset: 0x1CE33F0 VA: 0x181CE49F0
	private static void .cctor() { }
}
