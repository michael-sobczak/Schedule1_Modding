public class SynchronizationContext // TypeDefIndex: 3967
{
	// Fields
	private SynchronizationContextProperties _props; // 0x10
	private static Type s_cachedPreparedType1; // 0x0
	private static Type s_cachedPreparedType2; // 0x8
	private static Type s_cachedPreparedType3; // 0x10
	private static Type s_cachedPreparedType4; // 0x18
	private static Type s_cachedPreparedType5; // 0x20

	// Properties
	public static SynchronizationContext Current { get; }
	internal static SynchronizationContext CurrentNoFlow { get; }
	internal static SynchronizationContext CurrentExplicit { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1CE51A0 Offset: 0x1CE3BA0 VA: 0x181CE51A0
	public bool IsWaitNotificationRequired() { }

	// RVA: 0x1CE5230 Offset: 0x1CE3C30 VA: 0x181CE5230 Slot: 4
	public virtual void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x1CE51B0 Offset: 0x1CE3BB0 VA: 0x181CE51B0 Slot: 5
	public virtual void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	public virtual void OperationStarted() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	public virtual void OperationCompleted() { }

	[CLSCompliant(False)]
	[PrePrepareMethod]
	// RVA: 0x1CE5420 Offset: 0x1CE3E20 VA: 0x181CE5420 Slot: 8
	public virtual int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

	[CLSCompliant(False)]
	[PrePrepareMethod]
	[ReliabilityContract(3, 1)]
	// RVA: 0x1CE5370 Offset: 0x1CE3D70 VA: 0x181CE5370
	protected static int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

	// RVA: 0x1CE5260 Offset: 0x1CE3C60 VA: 0x181CE5260
	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

	// RVA: 0x1CE55B0 Offset: 0x1CE3FB0 VA: 0x181CE55B0
	public static SynchronizationContext get_Current() { }

	[FriendAccessAllowed]
	// RVA: 0x1CE5520 Offset: 0x1CE3F20 VA: 0x181CE5520
	internal static SynchronizationContext get_CurrentNoFlow() { }

	// RVA: 0x1CE4FE0 Offset: 0x1CE39E0 VA: 0x181CE4FE0
	private static SynchronizationContext GetThreadLocalContext() { }

	// RVA: 0x1CE4F90 Offset: 0x1CE3990 VA: 0x181CE4F90 Slot: 9
	public virtual SynchronizationContext CreateCopy() { }

	// RVA: 0x1CE5510 Offset: 0x1CE3F10 VA: 0x181CE5510
	internal static SynchronizationContext get_CurrentExplicit() { }
}
