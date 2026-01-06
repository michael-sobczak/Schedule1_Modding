public sealed class NatPunchModule // TypeDefIndex: 12396
{
	// Fields
	private readonly NetManager _socket; // 0x10
	private readonly ConcurrentQueue<NatPunchModule.RequestEventData> _requestEvents; // 0x18
	private readonly ConcurrentQueue<NatPunchModule.SuccessEventData> _successEvents; // 0x20
	private readonly NetDataReader _cacheReader; // 0x28
	private readonly NetDataWriter _cacheWriter; // 0x30
	private readonly NetPacketProcessor _netPacketProcessor; // 0x38
	private INatPunchListener _natPunchListener; // 0x40
	public const int MaxTokenLength = 256;
	public bool UnsyncedEvents; // 0x48

	// Methods

	// RVA: 0xCF3BF0 Offset: 0xCF25F0 VA: 0x180CF3BF0
	internal void .ctor(NetManager socket) { }

	// RVA: 0xCF37F0 Offset: 0xCF21F0 VA: 0x180CF37F0
	internal void ProcessMessage(IPEndPoint senderEndPoint, NetPacket packet) { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void Init(INatPunchListener listener) { }

	// RVA: -1 Offset: -1
	private void Send<T>(T packet, IPEndPoint target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF085D0 Offset: 0xF06FD0 VA: 0x180F085D0
	|-NatPunchModule.Send<object>
	*/

	// RVA: 0xCF3020 Offset: 0xCF1A20 VA: 0x180CF3020
	public void NatIntroduce(IPEndPoint hostInternal, IPEndPoint hostExternal, IPEndPoint clientInternal, IPEndPoint clientExternal, string additionalInfo) { }

	// RVA: 0xCF3510 Offset: 0xCF1F10 VA: 0x180CF3510
	public void PollEvents() { }

	// RVA: 0xCF3900 Offset: 0xCF2300 VA: 0x180CF3900
	public void SendNatIntroduceRequest(string host, int port, string additionalInfo) { }

	// RVA: 0xCF3AA0 Offset: 0xCF24A0 VA: 0x180CF3AA0
	public void SendNatIntroduceRequest(IPEndPoint masterServerEndPoint, string additionalInfo) { }

	// RVA: 0xCF3140 Offset: 0xCF1B40 VA: 0x180CF3140
	private void OnNatIntroductionRequest(NatPunchModule.NatIntroduceRequestPacket req, IPEndPoint senderEndPoint) { }

	// RVA: 0xCF3260 Offset: 0xCF1C60 VA: 0x180CF3260
	private void OnNatIntroductionResponse(NatPunchModule.NatIntroduceResponsePacket req) { }

	// RVA: 0xCF33E0 Offset: 0xCF1DE0 VA: 0x180CF33E0
	private void OnNatPunch(NatPunchModule.NatPunchPacket req, IPEndPoint senderEndPoint) { }
}
