internal class ClientContextTerminatorSink : IMessageSink // TypeDefIndex: 4375
{
	// Fields
	private Context _context; // 0x10

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(Context ctx) { }

	// RVA: 0x1B2B890 Offset: 0x1B2A290 VA: 0x181B2B890 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1B2B650 Offset: 0x1B2A050 VA: 0x181B2B650 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}
