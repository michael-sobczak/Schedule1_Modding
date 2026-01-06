public class ManualResetEventSlim : IDisposable // TypeDefIndex: 3934
{
	// Fields
	private const int DEFAULT_SPIN_SP = 1;
	private object m_lock; // 0x10
	private ManualResetEvent m_eventObj; // 0x18
	private int m_combinedState; // 0x20
	private const int SignalledState_BitMask = -2147483648;
	private const int SignalledState_ShiftCount = 31;
	private const int Dispose_BitMask = 1073741824;
	private const int SpinCountState_BitMask = 1073217536;
	private const int SpinCountState_ShiftCount = 19;
	private const int SpinCountState_MaxValue = 2047;
	private const int NumWaitersState_BitMask = 524287;
	private const int NumWaitersState_ShiftCount = 0;
	private const int NumWaitersState_MaxValue = 524287;
	private static Action<object> s_cancellationTokenCallback; // 0x0

	// Properties
	public WaitHandle WaitHandle { get; }
	public bool IsSet { get; set; }
	public int SpinCount { get; set; }
	private int Waiters { get; set; }

	// Methods

	// RVA: 0x1CE0C80 Offset: 0x1CDF680 VA: 0x181CE0C80
	public WaitHandle get_WaitHandle() { }

	// RVA: 0x1CE0BC0 Offset: 0x1CDF5C0 VA: 0x181CE0BC0
	public bool get_IsSet() { }

	// RVA: 0x1CE0D70 Offset: 0x1CDF770 VA: 0x181CE0D70
	private void set_IsSet(bool value) { }

	// RVA: 0x1CE0C20 Offset: 0x1CDF620 VA: 0x181CE0C20
	public int get_SpinCount() { }

	// RVA: 0x1CE0DA0 Offset: 0x1CDF7A0 VA: 0x181CE0DA0
	private void set_SpinCount(int value) { }

	// RVA: 0x1CE0D20 Offset: 0x1CDF720 VA: 0x181CE0D20
	private int get_Waiters() { }

	// RVA: 0x1CE0DE0 Offset: 0x1CDF7E0 VA: 0x181CE0DE0
	private void set_Waiters(int value) { }

	// RVA: 0x1CE08A0 Offset: 0x1CDF2A0 VA: 0x181CE08A0
	public void .ctor() { }

	// RVA: 0x1CE0990 Offset: 0x1CDF390 VA: 0x181CE0990
	public void .ctor(bool initialState) { }

	// RVA: 0x1CE0A90 Offset: 0x1CDF490 VA: 0x181CE0A90
	public void .ctor(bool initialState, int spinCount) { }

	// RVA: 0x1CDF5E0 Offset: 0x1CDDFE0 VA: 0x181CDF5E0
	private void Initialize(bool initialState, int spinCount) { }

	// RVA: 0x1CDF550 Offset: 0x1CDDF50 VA: 0x181CDF550
	private void EnsureLockObjectCreated() { }

	// RVA: 0x1CDF6A0 Offset: 0x1CDE0A0 VA: 0x181CDF6A0
	private bool LazyInitializeEvent() { }

	// RVA: 0x1CDFAD0 Offset: 0x1CDE4D0 VA: 0x181CDFAD0
	public void Set() { }

	// RVA: 0x1CDFAE0 Offset: 0x1CDE4E0 VA: 0x181CDFAE0
	private void Set(bool duringCancellation) { }

	// RVA: 0x1CDF9D0 Offset: 0x1CDE3D0 VA: 0x181CDF9D0
	public void Reset() { }

	// RVA: 0x1CDFFE0 Offset: 0x1CDE9E0 VA: 0x181CDFFE0
	public void Wait() { }

	// RVA: 0x1CDFFF0 Offset: 0x1CDE9F0 VA: 0x181CDFFF0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1CDF380 Offset: 0x1CDDD80 VA: 0x181CDF380 Slot: 4
	public void Dispose() { }

	// RVA: 0x1CDF3F0 Offset: 0x1CDDDF0 VA: 0x181CDF3F0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1CDFE60 Offset: 0x1CDE860 VA: 0x181CDFE60
	private void ThrowIfDisposed() { }

	// RVA: 0x1CDF170 Offset: 0x1CDDB70 VA: 0x181CDF170
	private static void CancellationTokenCallback(object obj) { }

	// RVA: 0x1CDFED0 Offset: 0x1CDE8D0 VA: 0x181CDFED0
	private void UpdateStateAtomically(int newBits, int updateBitsMask) { }

	// RVA: 0x1CDF5D0 Offset: 0x1CDDFD0 VA: 0x181CDF5D0
	private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount) { }

	// RVA: 0xB0B4A0 Offset: 0xB09EA0 VA: 0x180B0B4A0
	private static int ExtractStatePortion(int state, int mask) { }

	// RVA: 0x1CE0810 Offset: 0x1CDF210 VA: 0x181CE0810
	private static void .cctor() { }
}
