internal class ServerObjectTerminatorSink : IMessageSink // TypeDefIndex: 4405
{
	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x1B411D0 Offset: 0x1B3FBD0 VA: 0x181B411D0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1B41030 Offset: 0x1B3FA30 VA: 0x181B41030 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}
