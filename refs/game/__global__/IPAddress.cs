public class IPAddress // TypeDefIndex: 9934
{
	// Fields
	public static readonly IPAddress Any; // 0x0
	public static readonly IPAddress Loopback; // 0x8
	public static readonly IPAddress Broadcast; // 0x10
	public static readonly IPAddress None; // 0x18
	internal const long LoopbackMask = 255;
	public static readonly IPAddress IPv6Any; // 0x20
	public static readonly IPAddress IPv6Loopback; // 0x28
	public static readonly IPAddress IPv6None; // 0x30
	private uint _addressOrScopeId; // 0x10
	private readonly ushort[] _numbers; // 0x18
	private string _toString; // 0x20
	private int _hashCode; // 0x28
	internal const int NumberOfLabels = 8;

	// Properties
	private bool IsIPv4 { get; }
	private bool IsIPv6 { get; }
	private uint PrivateAddress { get; set; }
	private uint PrivateScopeId { get; set; }
	public AddressFamily AddressFamily { get; }
	public long ScopeId { get; }
	[Obsolete("This property has been deprecated. It is address family dependent. Please use IPAddress.Equals method to perform comparisons. https://go.microsoft.com/fwlink/?linkid=14202")]
	public long Address { get; }

	// Methods

	// RVA: 0x16675B0 Offset: 0x1665FB0 VA: 0x1816675B0
	private bool get_IsIPv4() { }

	// RVA: 0xC2FB40 Offset: 0xC2E540 VA: 0x180C2FB40
	private bool get_IsIPv6() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	private uint get_PrivateAddress() { }

	// RVA: 0x26AA490 Offset: 0x26A8E90 VA: 0x1826AA490
	private void set_PrivateAddress(uint value) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	private uint get_PrivateScopeId() { }

	// RVA: 0x26AA490 Offset: 0x26A8E90 VA: 0x1826AA490
	private void set_PrivateScopeId(uint value) { }

	// RVA: 0x26A9F60 Offset: 0x26A8960 VA: 0x1826A9F60
	public void .ctor(long newAddress) { }

	// RVA: 0x26A9DF0 Offset: 0x26A87F0 VA: 0x1826A9DF0
	public void .ctor(byte[] address, long scopeid) { }

	// RVA: 0x26AA1D0 Offset: 0x26A8BD0 VA: 0x1826AA1D0
	public void .ctor(ReadOnlySpan<byte> address, long scopeid) { }

	// RVA: 0x26A9E90 Offset: 0x26A8890 VA: 0x1826A9E90
	internal void .ctor(ushort* numbers, int numbersLength, uint scopeid) { }

	// RVA: 0x26A9D90 Offset: 0x26A8790 VA: 0x1826A9D90
	private void .ctor(ushort[] numbers, uint scopeid) { }

	// RVA: 0x26A9D00 Offset: 0x26A8700 VA: 0x1826A9D00
	public void .ctor(byte[] address) { }

	// RVA: 0x26AA000 Offset: 0x26A8A00 VA: 0x1826AA000
	public void .ctor(ReadOnlySpan<byte> address) { }

	// RVA: 0x26A9680 Offset: 0x26A8080 VA: 0x1826A9680
	public static bool TryParse(string ipString, out IPAddress address) { }

	// RVA: 0x26A9510 Offset: 0x26A7F10 VA: 0x1826A9510
	public static IPAddress Parse(string ipString) { }

	// RVA: 0x26A9730 Offset: 0x26A8130 VA: 0x1826A9730
	public bool TryWriteBytes(Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x2699FD0 Offset: 0x26989D0 VA: 0x182699FD0
	private void WriteIPv6Bytes(Span<byte> destination) { }

	// RVA: 0x26A9830 Offset: 0x26A8230 VA: 0x1826A9830
	private void WriteIPv4Bytes(Span<byte> destination) { }

	// RVA: 0x26A8D80 Offset: 0x26A7780 VA: 0x1826A8D80
	public byte[] GetAddressBytes() { }

	// RVA: 0x26AA3B0 Offset: 0x26A8DB0 VA: 0x1826AA3B0
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x26AA430 Offset: 0x26A8E30 VA: 0x1826AA430
	public long get_ScopeId() { }

	// RVA: 0x26A9620 Offset: 0x26A8020 VA: 0x1826A9620 Slot: 3
	public override string ToString() { }

	// RVA: 0x26A9320 Offset: 0x26A7D20 VA: 0x1826A9320
	public static bool IsLoopback(IPAddress address) { }

	// RVA: 0x26AA3D0 Offset: 0x26A8DD0 VA: 0x1826AA3D0
	public long get_Address() { }

	// RVA: 0x26A8C40 Offset: 0x26A7640 VA: 0x1826A8C40
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	// RVA: 0x26A8B30 Offset: 0x26A7530 VA: 0x1826A8B30 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x26A8E90 Offset: 0x26A7890 VA: 0x1826A8E90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26A9400 Offset: 0x26A7E00 VA: 0x1826A9400
	public IPAddress MapToIPv6() { }

	// RVA: 0x26A95D0 Offset: 0x26A7FD0 VA: 0x1826A95D0
	private static byte[] ThrowAddressNullException() { }

	// RVA: 0x26A9880 Offset: 0x26A8280 VA: 0x1826A9880
	private static void .cctor() { }
}
