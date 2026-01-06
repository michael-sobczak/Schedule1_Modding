public class CertificateHandler : IDisposable // TypeDefIndex: 18706
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x2F570C0 Offset: 0x2F55AC0 VA: 0x182F570C0
	private static IntPtr Create(CertificateHandler obj) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2F571E0 Offset: 0x2F55BE0 VA: 0x182F571E0
	private void Release() { }

	// RVA: 0x2F57220 Offset: 0x2F55C20 VA: 0x182F57220
	protected void .ctor() { }

	// RVA: 0x2F57150 Offset: 0x2F55B50 VA: 0x182F57150 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xF32510 Offset: 0xF30F10 VA: 0x180F32510 Slot: 5
	protected virtual bool ValidateCertificate(byte[] certificateData) { }

	[RequiredByNativeCode]
	// RVA: 0x2250E40 Offset: 0x224F840 VA: 0x182250E40
	internal bool ValidateCertificateNative(byte[] certificateData) { }

	// RVA: 0x2F57100 Offset: 0x2F55B00 VA: 0x182F57100 Slot: 4
	public void Dispose() { }
}
