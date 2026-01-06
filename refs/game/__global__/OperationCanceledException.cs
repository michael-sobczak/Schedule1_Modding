public class OperationCanceledException : SystemException // TypeDefIndex: 3706
{
	// Fields
	private CancellationToken _cancellationToken; // 0x90

	// Properties
	public CancellationToken CancellationToken { get; set; }

	// Methods

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public CancellationToken get_CancellationToken() { }

	// RVA: 0x1C81900 Offset: 0x1C80300 VA: 0x181C81900
	private void set_CancellationToken(CancellationToken value) { }

	// RVA: 0x1C81770 Offset: 0x1C80170 VA: 0x181C81770
	public void .ctor() { }

	// RVA: 0x1C81800 Offset: 0x1C80200 VA: 0x181C81800
	public void .ctor(string message) { }

	// RVA: 0x1C816C0 Offset: 0x1C800C0 VA: 0x181C816C0
	public void .ctor(CancellationToken token) { }

	// RVA: 0x1C81870 Offset: 0x1C80270 VA: 0x181C81870
	public void .ctor(string message, CancellationToken token) { }

	// RVA: 0x1C79FD0 Offset: 0x1C789D0 VA: 0x181C79FD0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}
