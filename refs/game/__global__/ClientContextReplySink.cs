internal class ClientContextReplySink : IMessageSink // TypeDefIndex: 4376
{
	// Fields
	private IMessageSink _replySink; // 0x10
	private Context _context; // 0x18

	// Methods

	// RVA: 0x1B24A10 Offset: 0x1B23410 VA: 0x181B24A10
	public void .ctor(Context ctx, IMessageSink replySink) { }

	// RVA: 0x1B2B590 Offset: 0x1B29F90 VA: 0x181B2B590 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1B2B550 Offset: 0x1B29F50 VA: 0x181B2B550 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}
