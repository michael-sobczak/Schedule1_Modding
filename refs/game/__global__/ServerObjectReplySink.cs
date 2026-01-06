internal class ServerObjectReplySink : IMessageSink // TypeDefIndex: 4406
{
	// Fields
	private IMessageSink _replySink; // 0x10
	private ServerIdentity _identity; // 0x18

	// Methods

	// RVA: 0x1B24A10 Offset: 0x1B23410 VA: 0x181B24A10
	public void .ctor(ServerIdentity identity, IMessageSink replySink) { }

	// RVA: 0x1B40FB0 Offset: 0x1B3F9B0 VA: 0x181B40FB0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1B40F70 Offset: 0x1B3F970 VA: 0x181B40F70 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}
