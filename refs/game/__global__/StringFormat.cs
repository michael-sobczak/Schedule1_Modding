public sealed class StringFormat : MarshalByRefObject, IDisposable, ICloneable // TypeDefIndex: 17166
{
	// Fields
	private IntPtr nativeStrFmt; // 0x18

	// Properties
	public StringAlignment Alignment { get; set; }
	public StringAlignment LineAlignment { set; }
	public StringFormatFlags FormatFlags { get; set; }
	public HotkeyPrefix HotkeyPrefix { set; }
	public StringTrimming Trimming { set; }
	public static StringFormat GenericTypographic { get; }
	internal IntPtr NativeObject { get; }

	// Methods

	// RVA: 0x2166290 Offset: 0x2164C90 VA: 0x182166290
	public void .ctor() { }

	// RVA: 0x2166360 Offset: 0x2164D60 VA: 0x182166360
	public void .ctor(StringFormatFlags options, int language) { }

	// RVA: 0x2141210 Offset: 0x213FC10 VA: 0x182141210
	internal void .ctor(IntPtr native) { }

	// RVA: 0x2165FE0 Offset: 0x21649E0 VA: 0x182165FE0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2165EA0 Offset: 0x21648A0 VA: 0x182165EA0 Slot: 6
	public void Dispose() { }

	// RVA: 0x2165F00 Offset: 0x2164900 VA: 0x182165F00
	private void Dispose(bool disposing) { }

	// RVA: 0x2166440 Offset: 0x2164E40 VA: 0x182166440
	public void .ctor(StringFormat format) { }

	// RVA: 0x2166510 Offset: 0x2164F10 VA: 0x182166510
	public StringAlignment get_Alignment() { }

	// RVA: 0x21667B0 Offset: 0x21651B0 VA: 0x1821667B0
	public void set_Alignment(StringAlignment value) { }

	// RVA: 0x2166AC0 Offset: 0x21654C0 VA: 0x182166AC0
	public void set_LineAlignment(StringAlignment value) { }

	// RVA: 0x21665E0 Offset: 0x2164FE0 VA: 0x1821665E0
	public StringFormatFlags get_FormatFlags() { }

	// RVA: 0x21668D0 Offset: 0x21652D0 VA: 0x1821668D0
	public void set_FormatFlags(StringFormatFlags value) { }

	// RVA: 0x21669A0 Offset: 0x21653A0 VA: 0x1821669A0
	public void set_HotkeyPrefix(HotkeyPrefix value) { }

	// RVA: 0x2166BE0 Offset: 0x21655E0 VA: 0x182166BE0
	public void set_Trimming(StringTrimming value) { }

	// RVA: 0x21666B0 Offset: 0x21650B0 VA: 0x1821666B0
	public static StringFormat get_GenericTypographic() { }

	// RVA: 0x2165D90 Offset: 0x2164790 VA: 0x182165D90 Slot: 7
	public object Clone() { }

	// RVA: 0x2166140 Offset: 0x2164B40 VA: 0x182166140 Slot: 3
	public override string ToString() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal IntPtr get_NativeObject() { }

	// RVA: 0x2166040 Offset: 0x2164A40 VA: 0x182166040
	public void SetTabStops(float firstTabOffset, float[] tabStops) { }
}
