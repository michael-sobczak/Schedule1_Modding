internal class SingletonIdentity : ServerIdentity // TypeDefIndex: 4291
{
	// Methods

	// RVA: 0x1B1B7E0 Offset: 0x1B1A1E0 VA: 0x181B1B7E0
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x1B1BC20 Offset: 0x1B1A620 VA: 0x181B1BC20
	public MarshalByRefObject GetServerObject() { }

	// RVA: 0x1B1BD40 Offset: 0x1B1A740 VA: 0x181B1BD40 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0x1B1BB70 Offset: 0x1B1A570 VA: 0x181B1BB70 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }
}
