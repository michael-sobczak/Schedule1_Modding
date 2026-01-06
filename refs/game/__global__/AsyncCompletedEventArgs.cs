public class AsyncCompletedEventArgs : EventArgs // TypeDefIndex: 9775
{
	// Fields
	private readonly Exception error; // 0x10
	private readonly bool cancelled; // 0x18
	private readonly object userState; // 0x20

	// Properties
	[SRDescription("True if operation was cancelled.")]
	public bool Cancelled { get; }
	[SRDescription("Exception that occurred during operation.  Null if no error.")]
	public Exception Error { get; }

	// Methods

	// RVA: 0x265B180 Offset: 0x2659B80 VA: 0x18265B180
	public void .ctor(Exception error, bool cancelled, object userState) { }

	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	public bool get_Cancelled() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Exception get_Error() { }

	// RVA: 0x265B090 Offset: 0x2659A90 VA: 0x18265B090
	protected void RaiseExceptionIfNecessary() { }
}
