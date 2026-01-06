public sealed class Matrix : MarshalByRefObject, IDisposable // TypeDefIndex: 17234
{
	// Fields
	internal IntPtr nativeMatrix; // 0x18

	// Properties
	public float[] Elements { get; }
	public float OffsetX { get; }
	public float OffsetY { get; }

	// Methods

	// RVA: 0x2163B30 Offset: 0x2162530 VA: 0x182163B30
	public void .ctor() { }

	// RVA: 0x2163BF0 Offset: 0x21625F0 VA: 0x182163BF0
	public float[] get_Elements() { }

	// RVA: 0x2163E30 Offset: 0x2162830 VA: 0x182163E30
	public float get_OffsetX() { }

	// RVA: 0x2163E60 Offset: 0x2162860 VA: 0x182163E60
	public float get_OffsetY() { }

	// RVA: 0x21637A0 Offset: 0x21621A0 VA: 0x1821637A0 Slot: 6
	public void Dispose() { }

	// RVA: 0x21638B0 Offset: 0x21622B0 VA: 0x1821638B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21639D0 Offset: 0x21623D0 VA: 0x1821639D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }
}
