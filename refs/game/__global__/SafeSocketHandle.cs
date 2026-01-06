internal sealed class SafeSocketHandle : SafeHandleMinusOneIsInvalid // TypeDefIndex: 10210
{
	// Fields
	private List<Thread> blocking_threads; // 0x20
	private Dictionary<Thread, StackTrace> threads_stacktraces; // 0x28
	private bool in_cleanup; // 0x30
	private const int SOCKET_CLOSED = 10004;
	private const int ABORT_RETRIES = 10;
	private static bool THROW_ON_ABORT_RETRIES; // 0x0

	// Methods

	// RVA: 0x25E29B0 Offset: 0x25E13B0 VA: 0x1825E29B0
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0x25E29A0 Offset: 0x25E13A0 VA: 0x1825E29A0
	internal void .ctor() { }

	// RVA: 0x25E2250 Offset: 0x25E0C50 VA: 0x1825E2250 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x25E2110 Offset: 0x25E0B10 VA: 0x1825E2110
	public void RegisterForBlockingSyscall() { }

	// RVA: 0x25E2790 Offset: 0x25E1190 VA: 0x1825E2790
	public void UnRegisterForBlockingSyscall() { }

	// RVA: 0x25E2930 Offset: 0x25E1330 VA: 0x1825E2930
	private static void .cctor() { }
}
