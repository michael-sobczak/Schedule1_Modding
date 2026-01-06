public abstract class AuthenticatedStream : Stream // TypeDefIndex: 10226
{
	// Fields
	private Stream _InnerStream; // 0x28
	private bool _LeaveStreamOpen; // 0x30

	// Properties
	protected Stream InnerStream { get; }
	public abstract bool IsAuthenticated { get; }

	// Methods

	// RVA: 0x25D9190 Offset: 0x25D7B90 VA: 0x1825D9190
	protected void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	protected Stream get_InnerStream() { }

	// RVA: 0x25D90C0 Offset: 0x25D7AC0 VA: 0x1825D90C0 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 40
	public abstract bool get_IsAuthenticated();
}
