internal static class NativeSocket // TypeDefIndex: 12385
{
	// Fields
	public static readonly bool IsSupported; // 0x0
	public static readonly bool UnixMode; // 0x1
	public const int IPv4AddrSize = 16;
	public const int IPv6AddrSize = 28;
	public const int AF_INET = 2;
	public const int AF_INET6 = 10;
	private static readonly Dictionary<int, SocketError> NativeErrorToSocketError; // 0x8

	// Methods

	// RVA: 0xCF48C0 Offset: 0xCF32C0 VA: 0x180CF48C0
	private static void .cctor() { }

	// RVA: 0xCF4680 Offset: 0xCF3080 VA: 0x180CF4680
	public static int RecvFrom(IntPtr socketHandle, byte[] pinnedBuffer, int len, byte[] socketAddress, ref int socketAddressSize) { }

	// RVA: 0xCF4730 Offset: 0xCF3130 VA: 0x180CF4730
	public static int SendTo(IntPtr socketHandle, byte[] pinnedBuffer, int len, byte[] socketAddress, int socketAddressSize) { }

	// RVA: 0xCF4440 Offset: 0xCF2E40 VA: 0x180CF4440
	public static SocketError GetSocketError() { }

	// RVA: 0xCF4530 Offset: 0xCF2F30 VA: 0x180CF4530
	public static SocketException GetSocketException() { }

	// RVA: 0xCF43A0 Offset: 0xCF2DA0 VA: 0x180CF43A0
	public static short GetNativeAddressFamily(IPEndPoint remoteEndPoint) { }
}
