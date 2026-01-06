internal class LeaseSink : IMessageSink // TypeDefIndex: 4312
{
	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x1B0F5A0 Offset: 0x1B0DFA0 VA: 0x181B0F5A0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1B0F360 Offset: 0x1B0DD60 VA: 0x181B0F360 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x1B0F3E0 Offset: 0x1B0DDE0 VA: 0x181B0F3E0
	private void RenewLease(IMessage msg) { }
}
