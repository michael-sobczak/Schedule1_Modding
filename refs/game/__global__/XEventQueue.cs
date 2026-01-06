internal class XEventQueue // TypeDefIndex: 5808
{
	// Fields
	private XEventQueue.XQueue xqueue; // 0x10
	private XEventQueue.XQueue lqueue; // 0x18
	private XEventQueue.PaintQueue paint; // 0x20
	internal ArrayList timer_list; // 0x28
	private Thread thread; // 0x30
	private bool dispatch_idle; // 0x38
	private static readonly int InitialXEventSize; // 0x0
	private static readonly int InitialLXEventSize; // 0x4
	private static readonly int InitialPaintSize; // 0x8

	// Properties
	public int Count { get; }
	public XEventQueue.PaintQueue Paint { get; }
	public Thread Thread { get; }
	public bool DispatchIdle { get; set; }

	// Methods

	// RVA: 0x227D140 Offset: 0x227BB40 VA: 0x18227D140
	public void .ctor(Thread thread) { }

	// RVA: 0x227D0D0 Offset: 0x227BAD0 VA: 0x18227D0D0
	private static void .cctor() { }

	// RVA: 0x227D430 Offset: 0x227BE30 VA: 0x18227D430
	public int get_Count() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public XEventQueue.PaintQueue get_Paint() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public Thread get_Thread() { }

	// RVA: 0x227CC00 Offset: 0x227B600 VA: 0x18227CC00
	public void EnqueueLocked(XEvent xevent) { }

	// RVA: 0x227C920 Offset: 0x227B320 VA: 0x18227C920
	public XEvent Dequeue() { }

	// RVA: 0x227CDF0 Offset: 0x227B7F0 VA: 0x18227CDF0
	public XEvent Peek() { }

	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_DispatchIdle() { }

	// RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	public void set_DispatchIdle(bool value) { }
}
