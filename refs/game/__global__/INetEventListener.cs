public interface INetEventListener // TypeDefIndex: 12364
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPeerConnected(NetPeer peer);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnNetworkError(IPEndPoint endPoint, SocketError socketError);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnNetworkReceive(NetPeer peer, NetPacketReader reader, byte channelNumber, DeliveryMethod deliveryMethod);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnNetworkLatencyUpdate(NetPeer peer, int latency);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnConnectionRequest(ConnectionRequest request);
}
