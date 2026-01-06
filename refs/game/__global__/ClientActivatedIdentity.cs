internal class ClientActivatedIdentity : ServerIdentity // TypeDefIndex: 4290
{
	// Fields
	private MarshalByRefObject _targetThis; // 0x70

	// Methods

	// RVA: 0x1B07050 Offset: 0x1B05A50 VA: 0x181B07050
	public void .ctor(string objectUri, Type objectType) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public MarshalByRefObject GetServerObject() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void SetClientProxy(MarshalByRefObject obj) { }

	// RVA: 0x1B06F50 Offset: 0x1B05950 VA: 0x181B06F50 Slot: 5
	public override void OnLifetimeExpired() { }

	// RVA: 0x1B06FB0 Offset: 0x1B059B0 VA: 0x181B06FB0 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0x1B06E90 Offset: 0x1B05890 VA: 0x181B06E90 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }
}
