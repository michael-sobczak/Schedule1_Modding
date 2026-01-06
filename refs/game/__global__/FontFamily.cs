public sealed class FontFamily : MarshalByRefObject, IDisposable // TypeDefIndex: 17144
{
	// Fields
	private string name; // 0x18
	private IntPtr nativeFontFamily; // 0x20

	// Properties
	internal IntPtr NativeFamily { get; }
	public string Name { get; }
	public static FontFamily GenericSansSerif { get; }
	public static FontFamily[] Families { get; }

	// Methods

	// RVA: 0x2139370 Offset: 0x2137D70 VA: 0x182139370
	internal void .ctor(IntPtr fntfamily) { }

	// RVA: 0x2139760 Offset: 0x2138160 VA: 0x182139760
	internal void refreshName() { }

	// RVA: 0x21390E0 Offset: 0x2137AE0 VA: 0x1821390E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal IntPtr get_NativeFamily() { }

	// RVA: 0x21393A0 Offset: 0x2137DA0 VA: 0x1821393A0
	public void .ctor(GenericFontFamilies genericFamily) { }

	// RVA: 0x2139510 Offset: 0x2137F10 VA: 0x182139510
	public void .ctor(string name) { }

	// RVA: 0x2139470 Offset: 0x2137E70 VA: 0x182139470
	public void .ctor(string name, FontCollection fontCollection) { }

	// RVA: 0x21396B0 Offset: 0x21380B0 VA: 0x1821396B0
	public string get_Name() { }

	// RVA: 0x21395F0 Offset: 0x2137FF0 VA: 0x1821395F0
	public static FontFamily get_GenericSansSerif() { }

	// RVA: 0x21391D0 Offset: 0x2137BD0 VA: 0x1821391D0
	public int GetCellAscent(FontStyle style) { }

	// RVA: 0x2139250 Offset: 0x2137C50 VA: 0x182139250
	public int GetCellDescent(FontStyle style) { }

	// RVA: 0x2138F90 Offset: 0x2137990 VA: 0x182138F90 Slot: 6
	public void Dispose() { }

	// RVA: 0x2139040 Offset: 0x2137A40 VA: 0x182139040 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21392D0 Offset: 0x2137CD0 VA: 0x1821392D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2139590 Offset: 0x2137F90 VA: 0x182139590
	public static FontFamily[] get_Families() { }

	// RVA: 0x2139310 Offset: 0x2137D10 VA: 0x182139310 Slot: 3
	public override string ToString() { }
}
