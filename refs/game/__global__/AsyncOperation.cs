internal class AsyncOperation : IAsyncOperation, IEnumerator // TypeDefIndex: 17812
{
	// Fields
	[CompilerGenerated]
	private bool <IsDone>k__BackingField; // 0x10
	[CompilerGenerated]
	private AsyncOperationStatus <Status>k__BackingField; // 0x14
	[CompilerGenerated]
	private Exception <Exception>k__BackingField; // 0x18
	protected Action<IAsyncOperation> m_CompletedCallback; // 0x20

	// Properties
	public bool IsDone { get; set; }
	public AsyncOperationStatus Status { get; set; }
	public Exception Exception { get; set; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40 Slot: 4
	public bool get_IsDone() { }

	[CompilerGenerated]
	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	protected void set_IsDone(bool value) { }

	[CompilerGenerated]
	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70 Slot: 5
	public AsyncOperationStatus get_Status() { }

	[CompilerGenerated]
	// RVA: 0x65C890 Offset: 0x65B290 VA: 0x18065C890
	protected void set_Status(AsyncOperationStatus value) { }

	// RVA: 0x2B9AFF0 Offset: 0x2B999F0 VA: 0x182B9AFF0 Slot: 6
	public void add_Completed(Action<IAsyncOperation> value) { }

	// RVA: 0x2B9B0D0 Offset: 0x2B99AD0 VA: 0x182B9B0D0 Slot: 7
	public void remove_Completed(Action<IAsyncOperation> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 8
	public Exception get_Exception() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	protected void set_Exception(Exception value) { }

	// RVA: 0x2B9AF70 Offset: 0x2B99970 VA: 0x182B9AF70
	public void SetInProgress() { }

	// RVA: 0x2B9AF80 Offset: 0x2B99980 VA: 0x182B9AF80
	public void Succeed() { }

	// RVA: 0x2B9AF10 Offset: 0x2B99910 VA: 0x182B9AF10
	public void Fail(Exception reason) { }

	// RVA: 0x2B9AE60 Offset: 0x2B99860 VA: 0x182B9AE60
	public void Cancel() { }

	// RVA: 0x2B9AFE0 Offset: 0x2B999E0 VA: 0x182B9AFE0 Slot: 9
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 10
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
