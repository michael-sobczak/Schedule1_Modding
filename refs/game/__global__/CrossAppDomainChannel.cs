internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver // TypeDefIndex: 4333
{
	// Fields
	private static object s_lock; // 0x0

	// Properties
	public virtual string ChannelName { get; }
	public virtual int ChannelPriority { get; }
	public virtual object ChannelData { get; }

	// Methods

	// RVA: 0x1B2D470 Offset: 0x1B2BE70 VA: 0x181B2D470
	internal static void RegisterCrossAppDomainChannel() { }

	// RVA: 0x1B2D710 Offset: 0x1B2C110 VA: 0x181B2D710 Slot: 9
	public virtual string get_ChannelName() { }

	// RVA: 0xF72900 Offset: 0xF71300 VA: 0x180F72900 Slot: 10
	public virtual int get_ChannelPriority() { }

	// RVA: 0x1B2D630 Offset: 0x1B2C030 VA: 0x181B2D630 Slot: 11
	public virtual object get_ChannelData() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	public virtual void StartListening(object data) { }

	// RVA: 0x1B2D2F0 Offset: 0x1B2BCF0 VA: 0x181B2D2F0 Slot: 13
	public virtual IMessageSink CreateMessageSink(string url, object data, out string uri) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1B2D5B0 Offset: 0x1B2BFB0 VA: 0x181B2D5B0
	private static void .cctor() { }
}
