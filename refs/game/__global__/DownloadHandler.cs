public class DownloadHandler : IDisposable // TypeDefIndex: 18707
{
	// Fields
	[VisibleToOtherModules]
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public byte[] data { get; }
	public string text { get; }

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2F57B90 Offset: 0x2F56590 VA: 0x182F57B90
	private void Release() { }

	[VisibleToOtherModules]
	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x2F575C0 Offset: 0x2F55FC0 VA: 0x182F575C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2F57570 Offset: 0x2F55F70 VA: 0x182F57570 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x493100 Offset: 0x491B00 VA: 0x180493100
	public byte[] get_data() { }

	// RVA: 0x7BFF30 Offset: 0x7BE930 VA: 0x1807BFF30
	public string get_text() { }

	// RVA: 0x553970 Offset: 0x552370 VA: 0x180553970 Slot: 6
	protected virtual NativeArray<byte> GetNativeData() { }

	// RVA: 0x2F57670 Offset: 0x2F56070 VA: 0x182F57670 Slot: 7
	protected virtual byte[] GetData() { }

	// RVA: 0x2F57930 Offset: 0x2F56330 VA: 0x182F57930 Slot: 8
	protected virtual string GetText() { }

	// RVA: 0x2F57710 Offset: 0x2F56110 VA: 0x182F57710
	private Encoding GetTextEncoder() { }

	// RVA: 0x2F57630 Offset: 0x2F56030 VA: 0x182F57630
	private string GetContentType() { }

	[RequiredByNativeCode]
	// RVA: 0x1366110 Offset: 0x1364B10 VA: 0x181366110 Slot: 9
	protected virtual bool ReceiveData(byte[] data, int dataLength) { }

	[RequiredByNativeCode]
	// RVA: 0x2250F80 Offset: 0x224F980 VA: 0x182250F80 Slot: 10
	protected virtual void ReceiveContentLengthHeader(ulong contentLength) { }

	[Obsolete("Use ReceiveContentLengthHeader")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	protected virtual void ReceiveContentLength(int contentLength) { }

	[RequiredByNativeCode]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	protected virtual void CompleteContent() { }

	[RequiredByNativeCode]
	// RVA: 0x2F57700 Offset: 0x2F56100 VA: 0x182F57700 Slot: 13
	protected virtual float GetProgress() { }

	[VisibleToOtherModules]
	[NativeThrows]
	// RVA: 0x2F57A20 Offset: 0x2F56420 VA: 0x182F57A20
	internal static byte* InternalGetByteArray(DownloadHandler dh, out int length) { }

	// RVA: 0x2F57670 Offset: 0x2F56070 VA: 0x182F57670
	internal static byte[] InternalGetByteArray(DownloadHandler dh) { }

	// RVA: 0x2F57A70 Offset: 0x2F56470 VA: 0x182F57A70
	internal static NativeArray<byte> InternalGetNativeArray(DownloadHandler dh, ref NativeArray<byte> nativeArray) { }

	// RVA: 0x2F57530 Offset: 0x2F55F30 VA: 0x182F57530
	internal static void DisposeNativeArray(ref NativeArray<byte> data) { }

	// RVA: 0x2F574C0 Offset: 0x2F55EC0 VA: 0x182F574C0
	internal static void CreateNativeArrayForNativeData(ref NativeArray<byte> data, byte* bytes, int length) { }
}
