public class UploadHandler : IDisposable // TypeDefIndex: 18714
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string contentType { set; }

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2F59E10 Offset: 0x2F58810 VA: 0x182F59E10
	private void Release() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x2F575C0 Offset: 0x2F55FC0 VA: 0x182F575C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2F59D70 Offset: 0x2F58770 VA: 0x182F59D70 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x1CBDE10 Offset: 0x1CBC810 VA: 0x181CBDE10
	public void set_contentType(string value) { }

	// RVA: 0x2F59DC0 Offset: 0x2F587C0 VA: 0x182F59DC0 Slot: 6
	internal virtual void SetContentType(string newContentType) { }

	[NativeMethod("SetContentType")]
	// RVA: 0x2F59DC0 Offset: 0x2F587C0 VA: 0x182F59DC0
	private void InternalSetContentType(string newContentType) { }
}
