internal struct XEvent // TypeDefIndex: 5760
{
	// Fields
	internal XEventName type; // 0x0
	internal XAnyEvent AnyEvent; // 0x0
	internal XKeyEvent KeyEvent; // 0x0
	internal XButtonEvent ButtonEvent; // 0x0
	internal XMotionEvent MotionEvent; // 0x0
	internal XCrossingEvent CrossingEvent; // 0x0
	internal XFocusChangeEvent FocusChangeEvent; // 0x0
	internal XExposeEvent ExposeEvent; // 0x0
	internal XGraphicsExposeEvent GraphicsExposeEvent; // 0x0
	internal XNoExposeEvent NoExposeEvent; // 0x0
	internal XVisibilityEvent VisibilityEvent; // 0x0
	internal XCreateWindowEvent CreateWindowEvent; // 0x0
	internal XDestroyWindowEvent DestroyWindowEvent; // 0x0
	internal XUnmapEvent UnmapEvent; // 0x0
	internal XMapEvent MapEvent; // 0x0
	internal XMapRequestEvent MapRequestEvent; // 0x0
	internal XReparentEvent ReparentEvent; // 0x0
	internal XConfigureEvent ConfigureEvent; // 0x0
	internal XGravityEvent GravityEvent; // 0x0
	internal XResizeRequestEvent ResizeRequestEvent; // 0x0
	internal XConfigureRequestEvent ConfigureRequestEvent; // 0x0
	internal XCirculateEvent CirculateEvent; // 0x0
	internal XCirculateRequestEvent CirculateRequestEvent; // 0x0
	internal XPropertyEvent PropertyEvent; // 0x0
	internal XSelectionClearEvent SelectionClearEvent; // 0x0
	internal XSelectionRequestEvent SelectionRequestEvent; // 0x0
	internal XSelectionEvent SelectionEvent; // 0x0
	internal XColormapEvent ColormapEvent; // 0x0
	internal XClientMessageEvent ClientMessageEvent; // 0x0
	internal XMappingEvent MappingEvent; // 0x0
	internal XErrorEvent ErrorEvent; // 0x0
	internal XKeymapEvent KeymapEvent; // 0x0
	internal XEventPad Pad; // 0x0

	// Methods

	// RVA: 0x227D710 Offset: 0x227C110 VA: 0x18227D710 Slot: 3
	public override string ToString() { }

	// RVA: 0x227D4D0 Offset: 0x227BED0 VA: 0x18227D4D0
	public static string ToString(object ev) { }
}
