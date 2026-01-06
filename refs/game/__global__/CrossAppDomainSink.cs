internal class CrossAppDomainSink : IMessageSink // TypeDefIndex: 4335
{
	// Fields
	private static Hashtable s_sinks; // 0x0
	private static MethodInfo processMessageMethod; // 0x8
	private int _domainID; // 0x10

	// Properties
	internal int TargetDomainId { get; }

	// Methods

	// RVA: 0x445F80 Offset: 0x444980 VA: 0x180445F80
	internal void .ctor(int domainID) { }

	// RVA: 0x1B2D8D0 Offset: 0x1B2C2D0 VA: 0x181B2D8D0
	internal static CrossAppDomainSink GetSink(int domainID) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	internal int get_TargetDomainId() { }

	// RVA: 0x1B2DBA0 Offset: 0x1B2C5A0 VA: 0x181B2DBA0
	private static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg) { }

	// RVA: 0x1B2DD60 Offset: 0x1B2C760 VA: 0x181B2DD60 Slot: 6
	public virtual IMessage SyncProcessMessage(IMessage msgRequest) { }

	// RVA: 0x1B2D7F0 Offset: 0x1B2C1F0 VA: 0x181B2D7F0 Slot: 7
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink) { }

	// RVA: 0x1B2DCA0 Offset: 0x1B2C6A0 VA: 0x181B2DCA0
	public void SendAsyncMessage(object data) { }

	// RVA: 0x1B2E1F0 Offset: 0x1B2CBF0 VA: 0x181B2E1F0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1B2E130 Offset: 0x1B2CB30 VA: 0x181B2E130
	private void <AsyncProcessMessage>b__10_0(object data) { }
}
