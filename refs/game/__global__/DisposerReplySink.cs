internal class DisposerReplySink : IMessageSink // TypeDefIndex: 4293
{
	// Fields
	private IMessageSink _next; // 0x10
	private IDisposable _disposable; // 0x18

	// Methods

	// RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	public void .ctor(IMessageSink next, IDisposable disposable) { }

	// RVA: 0x1B0D8B0 Offset: 0x1B0C2B0 VA: 0x181B0D8B0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1B0D870 Offset: 0x1B0C270 VA: 0x181B0D870 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}
