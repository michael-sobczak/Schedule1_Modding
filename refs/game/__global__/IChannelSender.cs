public interface IChannelSender : IChannel // TypeDefIndex: 4341
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);
}
