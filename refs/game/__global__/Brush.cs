public abstract class Brush : MarshalByRefObject, ICloneable, IDisposable // TypeDefIndex: 17094
{
	// Fields
	private IntPtr _nativeBrush; // 0x18

	// Properties
	[Browsable(False)]
	[EditorBrowsable(1)]
	internal IntPtr NativeBrush { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object Clone();

	// RVA: 0xCC4EC0 Offset: 0xCC38C0 VA: 0x180CC4EC0
	protected internal void SetNativeBrush(IntPtr brush) { }

	// RVA: 0xCC4EC0 Offset: 0xCC38C0 VA: 0x180CC4EC0
	internal void SetNativeBrushInternal(IntPtr brush) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal IntPtr get_NativeBrush() { }

	// RVA: 0x2134A80 Offset: 0x2133480 VA: 0x182134A80 Slot: 7
	public void Dispose() { }

	// RVA: 0x2134AF0 Offset: 0x21334F0 VA: 0x182134AF0 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2134C60 Offset: 0x2133660 VA: 0x182134C60 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
