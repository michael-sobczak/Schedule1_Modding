public sealed class Region : MarshalByRefObject, IDisposable // TypeDefIndex: 17165
{
	// Fields
	private IntPtr nativeRegion; // 0x18

	// Properties
	internal IntPtr NativeObject { get; }

	// Methods

	// RVA: 0x2165A80 Offset: 0x2164480 VA: 0x182165A80
	public void .ctor() { }

	// RVA: 0x2141210 Offset: 0x213FC10 VA: 0x182141210
	internal void .ctor(IntPtr native) { }

	// RVA: 0x2165B50 Offset: 0x2164550 VA: 0x182165B50
	public void .ctor(Rectangle rect) { }

	// RVA: 0x2165A10 Offset: 0x2164410 VA: 0x182165A10
	public void Union(Rectangle rect) { }

	// RVA: 0x2165700 Offset: 0x2164100 VA: 0x182165700
	public void Intersect(Region region) { }

	// RVA: 0x2165260 Offset: 0x2163C60 VA: 0x182165260
	public void Exclude(Rectangle rect) { }

	// RVA: 0x21654A0 Offset: 0x2163EA0 VA: 0x1821654A0
	public RectangleF GetBounds(Graphics g) { }

	// RVA: 0x2165820 Offset: 0x2164220 VA: 0x182165820
	public bool IsInfinite(Graphics g) { }

	// RVA: 0x2165950 Offset: 0x2164350 VA: 0x182165950
	public void MakeEmpty() { }

	// RVA: 0x2165330 Offset: 0x2163D30 VA: 0x182165330
	public static Region FromHrgn(IntPtr hrgn) { }

	// RVA: 0x2165600 Offset: 0x2164000 VA: 0x182165600
	public IntPtr GetHrgn(Graphics g) { }

	// RVA: 0x2165200 Offset: 0x2163C00 VA: 0x182165200 Slot: 6
	public void Dispose() { }

	// RVA: 0x2165120 Offset: 0x2163B20 VA: 0x182165120
	private void DisposeHandle() { }

	// RVA: 0x21652D0 Offset: 0x2163CD0 VA: 0x1821652D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal IntPtr get_NativeObject() { }
}
