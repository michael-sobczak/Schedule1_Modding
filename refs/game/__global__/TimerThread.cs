internal static class TimerThread // TypeDefIndex: 10013
{
	// Fields
	private static LinkedList<WeakReference> s_Queues; // 0x0
	private static LinkedList<WeakReference> s_NewQueues; // 0x8
	private static int s_ThreadState; // 0x10
	private static AutoResetEvent s_ThreadReadyEvent; // 0x18
	private static ManualResetEvent s_ThreadShutdownEvent; // 0x20
	private static WaitHandle[] s_ThreadEvents; // 0x28
	private static int s_CacheScanIteration; // 0x30
	private static Hashtable s_QueuesCache; // 0x38

	// Methods

	// RVA: 0x26CB840 Offset: 0x26CA240 VA: 0x1826CB840
	private static void .cctor() { }

	// RVA: 0x26CA390 Offset: 0x26C8D90 VA: 0x1826CA390
	internal static TimerThread.Queue CreateQueue(int durationMilliseconds) { }

	// RVA: 0x26CA5B0 Offset: 0x26C8FB0 VA: 0x1826CA5B0
	internal static TimerThread.Queue GetOrCreateQueue(int durationMilliseconds) { }

	// RVA: 0x26CAF00 Offset: 0x26C9900 VA: 0x1826CAF00
	private static void Prod() { }

	// RVA: 0x26CB0A0 Offset: 0x26C9AA0 VA: 0x1826CB0A0
	private static void ThreadProc() { }

	// RVA: 0x26CB020 Offset: 0x26C9A20 VA: 0x1826CB020
	private static void StopTimerThread() { }

	// RVA: 0x26CAE20 Offset: 0x26C9820 VA: 0x1826CAE20
	private static bool IsTickBetween(int start, int end, int comparand) { }

	// RVA: 0x26CAE40 Offset: 0x26C9840 VA: 0x1826CAE40
	private static void OnDomainUnload(object sender, EventArgs e) { }
}
