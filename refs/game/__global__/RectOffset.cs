public class RectOffset : IFormattable // TypeDefIndex: 11631
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
	internal IntPtr m_Ptr; // 0x10
	private readonly object m_SourceStyle; // 0x18

	// Properties
	[NativeProperty("left", False, 1)]
	public int left { get; set; }
	[NativeProperty("right", False, 1)]
	public int right { get; set; }
	[NativeProperty("top", False, 1)]
	public int top { get; set; }
	[NativeProperty("bottom", False, 1)]
	public int bottom { get; set; }
	public int horizontal { get; }
	public int vertical { get; }

	// Methods

	// RVA: 0x2C9C3C0 Offset: 0x2C9ADC0 VA: 0x182C9C3C0
	public void .ctor() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
	// RVA: 0x2C9C270 Offset: 0x2C9AC70 VA: 0x182C9C270
	internal void .ctor(object sourceStyle, IntPtr source) { }

	// RVA: 0x2C9BD90 Offset: 0x2C9A790 VA: 0x182C9BD90 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2C9C2C0 Offset: 0x2C9ACC0 VA: 0x182C9C2C0
	public void .ctor(int left, int right, int top, int bottom) { }

	// RVA: 0x2C9BF70 Offset: 0x2C9A970 VA: 0x182C9BF70 Slot: 3
	public override string ToString() { }

	// RVA: 0x2C9BF80 Offset: 0x2C9A980 VA: 0x182C9BF80 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2C9BD30 Offset: 0x2C9A730 VA: 0x182C9BD30
	private void Destroy() { }

	[ThreadAndSerializationSafe]
	// RVA: 0x2C9BE40 Offset: 0x2C9A840 VA: 0x182C9BE40
	private static IntPtr InternalCreate() { }

	[ThreadAndSerializationSafe]
	// RVA: 0x2C9BE70 Offset: 0x2C9A870 VA: 0x182C9BE70
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x2C9C480 Offset: 0x2C9AE80 VA: 0x182C9C480
	public int get_left() { }

	// RVA: 0x2C9C5C0 Offset: 0x2C9AFC0 VA: 0x182C9C5C0
	public void set_left(int value) { }

	// RVA: 0x2C9C4C0 Offset: 0x2C9AEC0 VA: 0x182C9C4C0
	public int get_right() { }

	// RVA: 0x2C9C600 Offset: 0x2C9B000 VA: 0x182C9C600
	public void set_right(int value) { }

	// RVA: 0x2C9C500 Offset: 0x2C9AF00 VA: 0x182C9C500
	public int get_top() { }

	// RVA: 0x2C9C640 Offset: 0x2C9B040 VA: 0x182C9C640
	public void set_top(int value) { }

	// RVA: 0x2C9C400 Offset: 0x2C9AE00 VA: 0x182C9C400
	public int get_bottom() { }

	// RVA: 0x2C9C580 Offset: 0x2C9AF80 VA: 0x182C9C580
	public void set_bottom(int value) { }

	// RVA: 0x2C9C440 Offset: 0x2C9AE40 VA: 0x182C9C440
	public int get_horizontal() { }

	// RVA: 0x2C9C540 Offset: 0x2C9AF40 VA: 0x182C9C540
	public int get_vertical() { }

	// RVA: 0x2C9BF10 Offset: 0x2C9A910 VA: 0x182C9BF10
	public Rect Remove(Rect rect) { }

	// RVA: 0x2C9BEB0 Offset: 0x2C9A8B0 VA: 0x182C9BEB0
	private void Remove_Injected(ref Rect rect, out Rect ret) { }
}
