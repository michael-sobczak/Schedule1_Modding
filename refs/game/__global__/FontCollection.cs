public abstract class FontCollection : IDisposable // TypeDefIndex: 17197
{
	// Fields
	internal IntPtr _nativeFontCollection; // 0x10

	// Properties
	public FontFamily[] Families { get; }

	// Methods

	// RVA: 0x21502E0 Offset: 0x214ECE0 VA: 0x1821502E0
	internal void .ctor() { }

	// RVA: 0x2150270 Offset: 0x214EC70 VA: 0x182150270 Slot: 4
	public void Dispose() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2150300 Offset: 0x214ED00 VA: 0x182150300
	public FontFamily[] get_Families() { }

	// RVA: 0x4D8670 Offset: 0x4D7070 VA: 0x1804D8670 Slot: 1
	protected override void Finalize() { }
}
