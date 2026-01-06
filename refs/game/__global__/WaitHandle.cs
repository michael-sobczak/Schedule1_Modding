public abstract class WaitHandle : MarshalByRefObject, IDisposable // TypeDefIndex: 3990
{
	// Fields
	public const int WaitTimeout = 258;
	private const int MAX_WAITHANDLES = 64;
	private IntPtr waitHandle; // 0x18
	internal SafeWaitHandle safeWaitHandle; // 0x20
	internal bool hasThreadAffinity; // 0x28
	private const int WAIT_OBJECT_0 = 0;
	private const int WAIT_ABANDONED = 128;
	private const int WAIT_FAILED = 2147483647;
	private const int ERROR_TOO_MANY_POSTS = 298;
	private const int ERROR_NOT_OWNED_BY_CALLER = 299;
	protected static readonly IntPtr InvalidHandle; // 0x0
	internal const int MaxWaitHandles = 64;

	// Properties
	[Obsolete("Use the SafeWaitHandle property instead.")]
	public virtual IntPtr Handle { set; }
	public SafeWaitHandle SafeWaitHandle { get; }

	// Methods

	// RVA: 0x1D07060 Offset: 0x1D05A60 VA: 0x181D07060
	protected void .ctor() { }

	// RVA: 0x1D05B20 Offset: 0x1D04520 VA: 0x181D05B20
	private void Init() { }

	// RVA: 0x1D071B0 Offset: 0x1D05BB0 VA: 0x181D071B0 Slot: 7
	public virtual void set_Handle(IntPtr value) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1D070E0 Offset: 0x1D05AE0 VA: 0x181D070E0
	public SafeWaitHandle get_SafeWaitHandle() { }

	// RVA: 0x1D05CC0 Offset: 0x1D046C0 VA: 0x181D05CC0
	internal void SetHandleInternal(SafeWaitHandle handle) { }

	// RVA: 0x1D06CF0 Offset: 0x1D056F0 VA: 0x181D06CF0 Slot: 8
	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x1D06CD0 Offset: 0x1D056D0 VA: 0x181D06CD0 Slot: 9
	public virtual bool WaitOne() { }

	// RVA: 0x1D06CB0 Offset: 0x1D056B0 VA: 0x181D06CB0 Slot: 10
	public virtual bool WaitOne(int millisecondsTimeout) { }

	// RVA: 0x1D06EB0 Offset: 0x1D058B0 VA: 0x181D06EB0
	private bool WaitOne(long timeout, bool exitContext) { }

	// RVA: 0x1D05BA0 Offset: 0x1D045A0 VA: 0x181D05BA0
	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	// RVA: 0x1D05E10 Offset: 0x1D04810 VA: 0x181D05E10
	public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x1D05DB0 Offset: 0x1D047B0 VA: 0x181D05DB0
	public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1D06340 Offset: 0x1D04D40 VA: 0x181D06340
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1D061C0 Offset: 0x1D04BC0 VA: 0x181D061C0
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1D062E0 Offset: 0x1D04CE0 VA: 0x181D062E0
	public static int WaitAny(WaitHandle[] waitHandles) { }

	// RVA: 0x1D05D70 Offset: 0x1D04770 VA: 0x181D05D70
	private static void ThrowAbandonedMutexException() { }

	// RVA: 0x1D05D10 Offset: 0x1D04710 VA: 0x181D05D10
	private static void ThrowAbandonedMutexException(int location, WaitHandle handle) { }

	// RVA: 0x1D059F0 Offset: 0x1D043F0 VA: 0x181D059F0 Slot: 11
	public virtual void Close() { }

	// RVA: 0x1D05AD0 Offset: 0x1D044D0 VA: 0x181D05AD0 Slot: 12
	protected virtual void Dispose(bool explicitDisposing) { }

	// RVA: 0x1D05A60 Offset: 0x1D04460 VA: 0x181D05A60 Slot: 6
	public void Dispose() { }

	// RVA: 0x1D06AB0 Offset: 0x1D054B0 VA: 0x181D06AB0
	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	// RVA: 0x1D06720 Offset: 0x1D05120 VA: 0x181D06720
	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll) { }

	// RVA: 0x1D07000 Offset: 0x1D05A00 VA: 0x181D07000
	internal static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms) { }

	// RVA: 0x1D07010 Offset: 0x1D05A10 VA: 0x181D07010
	private static void .cctor() { }
}
