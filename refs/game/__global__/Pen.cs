public sealed class Pen : MarshalByRefObject, ICloneable, IDisposable // TypeDefIndex: 17163
{
	// Fields
	internal IntPtr nativeObject; // 0x18
	internal bool isModifiable; // 0x20
	private Color color; // 0x28
	private CustomLineCap startCap; // 0x40
	private CustomLineCap endCap; // 0x48

	// Properties
	public DashStyle DashStyle { set; }
	public float Width { get; }
	internal IntPtr NativePen { get; }

	// Methods

	// RVA: 0x2164940 Offset: 0x2163340 VA: 0x182164940
	internal void .ctor(IntPtr p) { }

	// RVA: 0x2164970 Offset: 0x2163370 VA: 0x182164970
	public void .ctor(Brush brush) { }

	// RVA: 0x2164700 Offset: 0x2163100 VA: 0x182164700
	public void .ctor(Color color) { }

	// RVA: 0x2164590 Offset: 0x2162F90 VA: 0x182164590
	public void .ctor(Brush brush, float width) { }

	// RVA: 0x2164820 Offset: 0x2163220 VA: 0x182164820
	public void .ctor(Color color, float width) { }

	// RVA: 0x2164BB0 Offset: 0x21635B0 VA: 0x182164BB0
	public void set_DashStyle(DashStyle value) { }

	// RVA: 0x2164AE0 Offset: 0x21634E0 VA: 0x182164AE0
	public float get_Width() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal IntPtr get_NativePen() { }

	// RVA: 0x2164250 Offset: 0x2162C50 VA: 0x182164250 Slot: 6
	public object Clone() { }

	// RVA: 0x2164380 Offset: 0x2162D80 VA: 0x182164380 Slot: 7
	public void Dispose() { }

	// RVA: 0x21643E0 Offset: 0x2162DE0 VA: 0x1821643E0
	private void Dispose(bool disposing) { }

	// RVA: 0x2164530 Offset: 0x2162F30 VA: 0x182164530 Slot: 1
	protected override void Finalize() { }
}
