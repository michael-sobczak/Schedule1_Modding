internal sealed class NtpRequest // TypeDefIndex: 12478
{
	// Fields
	private const int ResendTimer = 1000;
	private const int KillTimer = 10000;
	public const int DefaultPort = 123;
	private readonly IPEndPoint _ntpEndPoint; // 0x10
	private int _resendTime; // 0x18
	private int _killTime; // 0x1C

	// Properties
	public bool NeedToKill { get; }

	// Methods

	// RVA: 0xD162F0 Offset: 0xD14CF0 VA: 0x180D162F0
	public void .ctor(IPEndPoint endPoint) { }

	// RVA: 0xD16330 Offset: 0xD14D30 VA: 0x180D16330
	public bool get_NeedToKill() { }

	// RVA: 0xD16210 Offset: 0xD14C10 VA: 0x180D16210
	public bool Send(Socket socket, int time) { }
}
