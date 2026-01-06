public class EventBasedNetListener : INetEventListener, IDeliveryEventListener, INtpEventListener, IPeerAddressChangedListener // TypeDefIndex: 12378
{
	// Fields
	[CompilerGenerated]
	private EventBasedNetListener.OnPeerConnected PeerConnectedEvent; // 0x10
	[CompilerGenerated]
	private EventBasedNetListener.OnPeerDisconnected PeerDisconnectedEvent; // 0x18
	[CompilerGenerated]
	private EventBasedNetListener.OnNetworkError NetworkErrorEvent; // 0x20
	[CompilerGenerated]
	private EventBasedNetListener.OnNetworkReceive NetworkReceiveEvent; // 0x28
	[CompilerGenerated]
	private EventBasedNetListener.OnNetworkReceiveUnconnected NetworkReceiveUnconnectedEvent; // 0x30
	[CompilerGenerated]
	private EventBasedNetListener.OnNetworkLatencyUpdate NetworkLatencyUpdateEvent; // 0x38
	[CompilerGenerated]
	private EventBasedNetListener.OnConnectionRequest ConnectionRequestEvent; // 0x40
	[CompilerGenerated]
	private EventBasedNetListener.OnDeliveryEvent DeliveryEvent; // 0x48
	[CompilerGenerated]
	private EventBasedNetListener.OnNtpResponseEvent NtpResponseEvent; // 0x50
	[CompilerGenerated]
	private EventBasedNetListener.OnPeerAddressChangedEvent PeerAddressChangedEvent; // 0x58

	// Methods

	[CompilerGenerated]
	// RVA: 0xCF26A0 Offset: 0xCF10A0 VA: 0x180CF26A0
	public void add_PeerConnectedEvent(EventBasedNetListener.OnPeerConnected value) { }

	[CompilerGenerated]
	// RVA: 0xCF2CE0 Offset: 0xCF16E0 VA: 0x180CF2CE0
	public void remove_PeerConnectedEvent(EventBasedNetListener.OnPeerConnected value) { }

	[CompilerGenerated]
	// RVA: 0xCF2740 Offset: 0xCF1140 VA: 0x180CF2740
	public void add_PeerDisconnectedEvent(EventBasedNetListener.OnPeerDisconnected value) { }

	[CompilerGenerated]
	// RVA: 0xCF2D80 Offset: 0xCF1780 VA: 0x180CF2D80
	public void remove_PeerDisconnectedEvent(EventBasedNetListener.OnPeerDisconnected value) { }

	[CompilerGenerated]
	// RVA: 0xCF22E0 Offset: 0xCF0CE0 VA: 0x180CF22E0
	public void add_NetworkErrorEvent(EventBasedNetListener.OnNetworkError value) { }

	[CompilerGenerated]
	// RVA: 0xCF2920 Offset: 0xCF1320 VA: 0x180CF2920
	public void remove_NetworkErrorEvent(EventBasedNetListener.OnNetworkError value) { }

	[CompilerGenerated]
	// RVA: 0xCF2420 Offset: 0xCF0E20 VA: 0x180CF2420
	public void add_NetworkReceiveEvent(EventBasedNetListener.OnNetworkReceive value) { }

	[CompilerGenerated]
	// RVA: 0xCF2A60 Offset: 0xCF1460 VA: 0x180CF2A60
	public void remove_NetworkReceiveEvent(EventBasedNetListener.OnNetworkReceive value) { }

	[CompilerGenerated]
	// RVA: 0xCF24C0 Offset: 0xCF0EC0 VA: 0x180CF24C0
	public void add_NetworkReceiveUnconnectedEvent(EventBasedNetListener.OnNetworkReceiveUnconnected value) { }

	[CompilerGenerated]
	// RVA: 0xCF2B00 Offset: 0xCF1500 VA: 0x180CF2B00
	public void remove_NetworkReceiveUnconnectedEvent(EventBasedNetListener.OnNetworkReceiveUnconnected value) { }

	[CompilerGenerated]
	// RVA: 0xCF2380 Offset: 0xCF0D80 VA: 0x180CF2380
	public void add_NetworkLatencyUpdateEvent(EventBasedNetListener.OnNetworkLatencyUpdate value) { }

	[CompilerGenerated]
	// RVA: 0xCF29C0 Offset: 0xCF13C0 VA: 0x180CF29C0
	public void remove_NetworkLatencyUpdateEvent(EventBasedNetListener.OnNetworkLatencyUpdate value) { }

	[CompilerGenerated]
	// RVA: 0xCF21A0 Offset: 0xCF0BA0 VA: 0x180CF21A0
	public void add_ConnectionRequestEvent(EventBasedNetListener.OnConnectionRequest value) { }

	[CompilerGenerated]
	// RVA: 0xCF27E0 Offset: 0xCF11E0 VA: 0x180CF27E0
	public void remove_ConnectionRequestEvent(EventBasedNetListener.OnConnectionRequest value) { }

	[CompilerGenerated]
	// RVA: 0xCF2240 Offset: 0xCF0C40 VA: 0x180CF2240
	public void add_DeliveryEvent(EventBasedNetListener.OnDeliveryEvent value) { }

	[CompilerGenerated]
	// RVA: 0xCF2880 Offset: 0xCF1280 VA: 0x180CF2880
	public void remove_DeliveryEvent(EventBasedNetListener.OnDeliveryEvent value) { }

	[CompilerGenerated]
	// RVA: 0xCF2560 Offset: 0xCF0F60 VA: 0x180CF2560
	public void add_NtpResponseEvent(EventBasedNetListener.OnNtpResponseEvent value) { }

	[CompilerGenerated]
	// RVA: 0xCF2BA0 Offset: 0xCF15A0 VA: 0x180CF2BA0
	public void remove_NtpResponseEvent(EventBasedNetListener.OnNtpResponseEvent value) { }

	[CompilerGenerated]
	// RVA: 0xCF2600 Offset: 0xCF1000 VA: 0x180CF2600
	public void add_PeerAddressChangedEvent(EventBasedNetListener.OnPeerAddressChangedEvent value) { }

	[CompilerGenerated]
	// RVA: 0xCF2C40 Offset: 0xCF1640 VA: 0x180CF2C40
	public void remove_PeerAddressChangedEvent(EventBasedNetListener.OnPeerAddressChangedEvent value) { }

	// RVA: 0xAFE5A0 Offset: 0xAFCFA0 VA: 0x180AFE5A0
	public void ClearPeerConnectedEvent() { }

	// RVA: 0x50B620 Offset: 0x50A020 VA: 0x18050B620
	public void ClearPeerDisconnectedEvent() { }

	// RVA: 0x5717F0 Offset: 0x5701F0 VA: 0x1805717F0
	public void ClearNetworkErrorEvent() { }

	// RVA: 0xCF1FE0 Offset: 0xCF09E0 VA: 0x180CF1FE0
	public void ClearNetworkReceiveEvent() { }

	// RVA: 0xCF2000 Offset: 0xCF0A00 VA: 0x180CF2000
	public void ClearNetworkReceiveUnconnectedEvent() { }

	// RVA: 0x4F4EF0 Offset: 0x4F38F0 VA: 0x1804F4EF0
	public void ClearNetworkLatencyUpdateEvent() { }

	// RVA: 0xCF1FC0 Offset: 0xCF09C0 VA: 0x180CF1FC0
	public void ClearConnectionRequestEvent() { }

	// RVA: 0x6E9E30 Offset: 0x6E8830 VA: 0x1806E9E30
	public void ClearDeliveryEvent() { }

	// RVA: 0xCF2020 Offset: 0xCF0A20 VA: 0x180CF2020
	public void ClearNtpResponseEvent() { }

	// RVA: 0x5506F0 Offset: 0x54F0F0 VA: 0x1805506F0
	public void ClearPeerAddressChangedEvent() { }

	// RVA: 0xCF2110 Offset: 0xCF0B10 VA: 0x180CF2110 Slot: 4
	private void LiteNetLib.INetEventListener.OnPeerConnected(NetPeer peer) { }

	// RVA: 0xCF2130 Offset: 0xCF0B30 VA: 0x180CF2130 Slot: 5
	private void LiteNetLib.INetEventListener.OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo) { }

	// RVA: 0xCF2080 Offset: 0xCF0A80 VA: 0x180CF2080 Slot: 6
	private void LiteNetLib.INetEventListener.OnNetworkError(IPEndPoint endPoint, SocketError socketErrorCode) { }

	// RVA: 0xCF20E0 Offset: 0xCF0AE0 VA: 0x180CF20E0 Slot: 7
	private void LiteNetLib.INetEventListener.OnNetworkReceive(NetPeer peer, NetPacketReader reader, byte channelNumber, DeliveryMethod deliveryMethod) { }

	// RVA: 0xCF20C0 Offset: 0xCF0AC0 VA: 0x180CF20C0 Slot: 8
	private void LiteNetLib.INetEventListener.OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType) { }

	// RVA: 0xCF20A0 Offset: 0xCF0AA0 VA: 0x180CF20A0 Slot: 9
	private void LiteNetLib.INetEventListener.OnNetworkLatencyUpdate(NetPeer peer, int latency) { }

	// RVA: 0xCF2060 Offset: 0xCF0A60 VA: 0x180CF2060 Slot: 10
	private void LiteNetLib.INetEventListener.OnConnectionRequest(ConnectionRequest request) { }

	// RVA: 0xCF2040 Offset: 0xCF0A40 VA: 0x180CF2040 Slot: 11
	private void LiteNetLib.IDeliveryEventListener.OnMessageDelivered(NetPeer peer, object userData) { }

	// RVA: 0xCF2160 Offset: 0xCF0B60 VA: 0x180CF2160 Slot: 12
	private void LiteNetLib.INtpEventListener.OnNtpResponse(NtpPacket packet) { }

	// RVA: 0xCF2180 Offset: 0xCF0B80 VA: 0x180CF2180 Slot: 13
	private void LiteNetLib.IPeerAddressChangedListener.OnPeerAddressChanged(NetPeer peer, IPEndPoint previousAddress) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
