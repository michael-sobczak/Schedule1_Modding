internal abstract class MonoBtlsObject : IDisposable // TypeDefIndex: 9434
{
	// Fields
	private MonoBtlsObject.MonoBtlsHandle handle; // 0x10
	private Exception lastError; // 0x18

	// Properties
	internal MonoBtlsObject.MonoBtlsHandle Handle { get; }
	public bool IsValid { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(MonoBtlsObject.MonoBtlsHandle handle) { }

	// RVA: 0x20188E0 Offset: 0x20172E0 VA: 0x1820188E0
	internal MonoBtlsObject.MonoBtlsHandle get_Handle() { }

	// RVA: 0x2018900 Offset: 0x2017300 VA: 0x182018900
	public bool get_IsValid() { }

	// RVA: 0x20185F0 Offset: 0x2016FF0 VA: 0x1820185F0
	protected void CheckThrow() { }

	// RVA: 0x20188B0 Offset: 0x20172B0 VA: 0x1820188B0
	protected Exception SetException(Exception ex) { }

	// RVA: 0x2018250 Offset: 0x2016C50 VA: 0x182018250
	protected void CheckError(bool ok, string callerName) { }

	// RVA: 0x20183E0 Offset: 0x2016DE0 VA: 0x1820183E0
	protected void CheckError(int ret, string callerName) { }

	// RVA: 0x20183F0 Offset: 0x2016DF0 VA: 0x1820183F0
	protected internal void CheckLastError(string callerName) { }

	// RVA: 0x2018940 Offset: 0x2017340 VA: 0x182018940
	private static extern void mono_btls_free(IntPtr data) { }

	// RVA: 0x2018830 Offset: 0x2017230 VA: 0x182018830
	protected void FreeDataPtr(IntPtr data) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	protected virtual void Close() { }

	// RVA: 0x2018690 Offset: 0x2017090 VA: 0x182018690
	protected void Dispose(bool disposing) { }

	// RVA: 0x2018770 Offset: 0x2017170 VA: 0x182018770 Slot: 4
	public void Dispose() { }

	// RVA: 0x20187D0 Offset: 0x20171D0 VA: 0x1820187D0 Slot: 1
	protected override void Finalize() { }
}
