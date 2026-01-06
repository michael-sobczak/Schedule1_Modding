public sealed class RNGCryptoServiceProvider : RandomNumberGenerator // TypeDefIndex: 4246
{
	// Fields
	private static object _lock; // 0x0
	private IntPtr _handle; // 0x10

	// Methods

	// RVA: 0x1AF96A0 Offset: 0x1AF80A0 VA: 0x181AF96A0
	private static void .cctor() { }

	// RVA: 0x1AF9730 Offset: 0x1AF8130 VA: 0x181AF9730
	public void .ctor() { }

	// RVA: 0x1AF9300 Offset: 0x1AF7D00 VA: 0x181AF9300
	private void Check() { }

	// RVA: 0x1AF9690 Offset: 0x1AF8090 VA: 0x181AF9690
	private static bool RngOpen() { }

	// RVA: 0x1AF9680 Offset: 0x1AF8080 VA: 0x181AF9680
	private static IntPtr RngInitialize(byte* seed, IntPtr seed_length) { }

	// RVA: 0x1AF9670 Offset: 0x1AF8070 VA: 0x181AF9670
	private static IntPtr RngGetBytes(IntPtr handle, byte* data, IntPtr data_length) { }

	// RVA: 0x1AF9660 Offset: 0x1AF8060 VA: 0x181AF9660
	private static void RngClose(IntPtr handle) { }

	// RVA: 0x1AF9460 Offset: 0x1AF7E60 VA: 0x181AF9460 Slot: 6
	public override void GetBytes(byte[] data) { }

	// RVA: 0x1AF93A0 Offset: 0x1AF7DA0 VA: 0x181AF93A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AF9390 Offset: 0x1AF7D90 VA: 0x181AF9390 Slot: 5
	protected override void Dispose(bool disposing) { }
}
