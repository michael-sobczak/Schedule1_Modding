public sealed class UploadHandlerRaw : UploadHandler // TypeDefIndex: 18715
{
	// Fields
	private NativeArray<byte> m_Payload; // 0x18

	// Methods

	// RVA: 0x2F59A20 Offset: 0x2F58420 VA: 0x182F59A20
	private static IntPtr Create(UploadHandlerRaw self, byte* data, int dataLength) { }

	// RVA: 0x2F59B10 Offset: 0x2F58510 VA: 0x182F59B10
	public void .ctor(byte[] data) { }

	// RVA: 0x2F59C80 Offset: 0x2F58680 VA: 0x182F59C80
	public void .ctor(NativeArray<byte> data, bool transferOwnership) { }

	// RVA: 0x2F59A80 Offset: 0x2F58480 VA: 0x182F59A80 Slot: 5
	public override void Dispose() { }
}
