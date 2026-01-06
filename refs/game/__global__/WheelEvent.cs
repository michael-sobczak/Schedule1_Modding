public class WheelEvent : MouseEventBase<WheelEvent> // TypeDefIndex: 6581
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Vector3 <delta>k__BackingField; // 0xC0

	// Properties
	public Vector3 delta { get; set; }

	// Methods

	// RVA: 0x2E9ECA0 Offset: 0x2E9D6A0 VA: 0x182E9ECA0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x4EFF90 Offset: 0x4EE990 VA: 0x1804EFF90
	public Vector3 get_delta() { }

	[CompilerGenerated]
	// RVA: 0xBFBB70 Offset: 0xBFA570 VA: 0x180BFBB70
	private void set_delta(Vector3 value) { }

	// RVA: 0x2E9E940 Offset: 0x2E9D340 VA: 0x182E9E940
	public static WheelEvent GetPooled(Event systemEvent) { }

	// RVA: 0x2E9EAF0 Offset: 0x2E9D4F0 VA: 0x182E9EAF0
	internal static WheelEvent GetPooled(Vector3 delta, Vector3 mousePosition, EventModifiers modifiers = 0) { }

	// RVA: 0x2E9EA80 Offset: 0x2E9D480 VA: 0x182E9EA80
	internal static WheelEvent GetPooled(Vector3 delta, IPointerEvent pointerEvent) { }

	// RVA: 0x2E9EBC0 Offset: 0x2E9D5C0 VA: 0x182E9EBC0 Slot: 12
	protected override void Init() { }

	// RVA: 0x2E9EC40 Offset: 0x2E9D640 VA: 0x182E9EC40
	private void LocalInit() { }

	// RVA: 0x2E9ED80 Offset: 0x2E9D780 VA: 0x182E9ED80
	public void .ctor() { }
}
