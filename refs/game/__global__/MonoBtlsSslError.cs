internal enum MonoBtlsSslError // TypeDefIndex: 9449
{
	// Fields
	public int value__; // 0x0
	public const MonoBtlsSslError None = 0;
	public const MonoBtlsSslError Ssl = 1;
	public const MonoBtlsSslError WantRead = 2;
	public const MonoBtlsSslError WantWrite = 3;
	public const MonoBtlsSslError WantX509Lookup = 4;
	public const MonoBtlsSslError Syscall = 5;
	public const MonoBtlsSslError ZeroReturn = 6;
	public const MonoBtlsSslError WantConnect = 7;
	public const MonoBtlsSslError WantAccept = 8;
	public const MonoBtlsSslError WantChannelIdLookup = 9;
	public const MonoBtlsSslError PendingSession = 11;
	public const MonoBtlsSslError PendingCertificate = 12;
	public const MonoBtlsSslError WantPrivateKeyOperation = 13;
}
