internal struct Win32_IP_ADAPTER_UNICAST_ADDRESS // TypeDefIndex: 10163
{
	// Fields
	public Win32LengthFlagsUnion LengthFlags; // 0x0
	public IntPtr Next; // 0x8
	public Win32_SOCKET_ADDRESS Address; // 0x10
	public PrefixOrigin PrefixOrigin; // 0x20
	public SuffixOrigin SuffixOrigin; // 0x24
	public DuplicateAddressDetectionState DadState; // 0x28
	public uint ValidLifetime; // 0x2C
	public uint PreferredLifetime; // 0x30
	public uint LeaseLifetime; // 0x34
	public byte OnLinkPrefixLength; // 0x38
}
