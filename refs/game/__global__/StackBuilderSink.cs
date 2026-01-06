internal class StackBuilderSink : IMessageSink // TypeDefIndex: 4407
{
	// Fields
	private MarshalByRefObject _target; // 0x10
	private RealProxy _rp; // 0x18

	// Methods

	// RVA: 0x1B420D0 Offset: 0x1B40AD0 VA: 0x181B420D0
	public void .ctor(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x1B41FC0 Offset: 0x1B409C0 VA: 0x181B41FC0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1B418C0 Offset: 0x1B402C0 VA: 0x181B418C0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x1B41DF0 Offset: 0x1B407F0 VA: 0x181B41DF0
	private void ExecuteAsyncMessage(object ob) { }

	// RVA: 0x1B41A10 Offset: 0x1B40410 VA: 0x181B41A10
	private void CheckParameters(IMessage msg) { }

	[CompilerGenerated]
	// RVA: 0x1B420B0 Offset: 0x1B40AB0 VA: 0x181B420B0
	private void <AsyncProcessMessage>b__4_0(object data) { }
}
