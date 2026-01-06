public class ConnectionRequest // TypeDefIndex: 12360
{
	// Fields
	private readonly NetManager _listener; // 0x10
	private int _used; // 0x18
	[CompilerGenerated]
	private ConnectionRequestResult <Result>k__BackingField; // 0x1C
	internal NetConnectRequestPacket InternalPacket; // 0x20
	public readonly IPEndPoint RemoteEndPoint; // 0x28

	// Properties
	public NetDataReader Data { get; }
	internal ConnectionRequestResult Result { get; set; }

	// Methods

	// RVA: 0xA77FE0 Offset: 0xA769E0 VA: 0x180A77FE0
	public NetDataReader get_Data() { }

	[CompilerGenerated]
	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	internal ConnectionRequestResult get_Result() { }

	[CompilerGenerated]
	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	private void set_Result(ConnectionRequestResult value) { }

	// RVA: 0xCF1C30 Offset: 0xCF0630 VA: 0x180CF1C30
	internal void UpdateRequest(NetConnectRequestPacket connectRequest) { }

	// RVA: 0xCF1C00 Offset: 0xCF0600 VA: 0x180CF1C00
	private bool TryActivate() { }

	// RVA: 0xCF1C90 Offset: 0xCF0690 VA: 0x180CF1C90
	internal void .ctor(IPEndPoint remoteEndPoint, NetConnectRequestPacket requestPacket, NetManager listener) { }

	// RVA: 0xCF15F0 Offset: 0xCEFFF0 VA: 0x180CF15F0
	public NetPeer AcceptIfKey(string key) { }

	// RVA: 0xCF1730 Offset: 0xCF0130 VA: 0x180CF1730
	public NetPeer Accept() { }

	// RVA: 0xCF1A90 Offset: 0xCF0490 VA: 0x180CF1A90
	public void Reject(byte[] rejectData, int start, int length, bool force) { }

	// RVA: 0xCF1A00 Offset: 0xCF0400 VA: 0x180CF1A00
	public void Reject(byte[] rejectData, int start, int length) { }

	// RVA: 0xCF1790 Offset: 0xCF0190 VA: 0x180CF1790
	public void RejectForce(byte[] rejectData, int start, int length) { }

	// RVA: 0xCF18A0 Offset: 0xCF02A0 VA: 0x180CF18A0
	public void RejectForce() { }

	// RVA: 0xCF1820 Offset: 0xCF0220 VA: 0x180CF1820
	public void RejectForce(byte[] rejectData) { }

	// RVA: 0xCF1900 Offset: 0xCF0300 VA: 0x180CF1900
	public void RejectForce(NetDataWriter rejectData) { }

	// RVA: 0xCF1BA0 Offset: 0xCF05A0 VA: 0x180CF1BA0
	public void Reject() { }

	// RVA: 0xCF1980 Offset: 0xCF0380 VA: 0x180CF1980
	public void Reject(byte[] rejectData) { }

	// RVA: 0xCF1B20 Offset: 0xCF0520 VA: 0x180CF1B20
	public void Reject(NetDataWriter rejectData) { }
}
