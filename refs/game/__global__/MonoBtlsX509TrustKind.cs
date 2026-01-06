internal enum MonoBtlsX509TrustKind // TypeDefIndex: 9476
{
	// Fields
	public int value__; // 0x0
	public const MonoBtlsX509TrustKind DEFAULT = 0;
	public const MonoBtlsX509TrustKind TRUST_CLIENT = 1;
	public const MonoBtlsX509TrustKind TRUST_SERVER = 2;
	public const MonoBtlsX509TrustKind TRUST_ALL = 4;
	public const MonoBtlsX509TrustKind REJECT_CLIENT = 32;
	public const MonoBtlsX509TrustKind REJECT_SERVER = 64;
	public const MonoBtlsX509TrustKind REJECT_ALL = 128;
}
