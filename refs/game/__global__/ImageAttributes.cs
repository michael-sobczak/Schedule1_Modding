public sealed class ImageAttributes : ICloneable, IDisposable // TypeDefIndex: 17210
{
	// Fields
	internal IntPtr nativeImageAttributes; // 0x10

	// Methods

	// RVA: 0x215A130 Offset: 0x2158B30 VA: 0x18215A130
	internal void SetNativeImageAttributes(IntPtr handle) { }

	// RVA: 0x215A1B0 Offset: 0x2158BB0 VA: 0x18215A1B0
	public void .ctor() { }

	// RVA: 0x215A2C0 Offset: 0x2158CC0 VA: 0x18215A2C0
	internal void .ctor(IntPtr newNativeImageAttributes) { }

	// RVA: 0x2159920 Offset: 0x2158320 VA: 0x182159920 Slot: 5
	public void Dispose() { }

	// RVA: 0x2159980 Offset: 0x2158380 VA: 0x182159980
	private void Dispose(bool disposing) { }

	// RVA: 0x2159B10 Offset: 0x2158510 VA: 0x182159B10 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x21597B0 Offset: 0x21581B0 VA: 0x1821597B0 Slot: 4
	public object Clone() { }

	// RVA: 0x2159FE0 Offset: 0x21589E0 VA: 0x182159FE0
	public void SetColorMatrix(ColorMatrix newColorMatrix) { }

	// RVA: 0x2159E80 Offset: 0x2158880 VA: 0x182159E80
	public void SetColorMatrix(ColorMatrix newColorMatrix, ColorMatrixFlag mode, ColorAdjustType type) { }

	// RVA: 0x2159CE0 Offset: 0x21586E0 VA: 0x182159CE0
	public void SetColorKey(Color colorLow, Color colorHigh) { }

	// RVA: 0x2159B70 Offset: 0x2158570 VA: 0x182159B70
	public void SetColorKey(Color colorLow, Color colorHigh, ColorAdjustType type) { }
}
