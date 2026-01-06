internal class MonoTlsStream : IDisposable // TypeDefIndex: 9410
{
	// Fields
	private readonly MobileTlsProvider provider; // 0x10
	private readonly NetworkStream networkStream; // 0x18
	private readonly HttpWebRequest request; // 0x20
	private readonly MonoTlsSettings settings; // 0x28
	private SslStream sslStream; // 0x30
	private readonly object sslStreamLock; // 0x38
	private WebExceptionStatus status; // 0x40
	[CompilerGenerated]
	private bool <CertificateValidationFailed>k__BackingField; // 0x44

	// Properties
	internal HttpWebRequest Request { get; }
	internal WebExceptionStatus ExceptionStatus { get; }
	internal bool CertificateValidationFailed { get; set; }

	// Methods

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal HttpWebRequest get_Request() { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	internal WebExceptionStatus get_ExceptionStatus() { }

	[CompilerGenerated]
	// RVA: 0x495FF0 Offset: 0x4949F0 VA: 0x180495FF0
	internal bool get_CertificateValidationFailed() { }

	[CompilerGenerated]
	// RVA: 0x200E0A0 Offset: 0x200CAA0 VA: 0x18200E0A0
	internal void set_CertificateValidationFailed(bool value) { }

	// RVA: 0x201D4E0 Offset: 0x201BEE0 VA: 0x18201D4E0
	public void .ctor(HttpWebRequest request, NetworkStream networkStream) { }

	[AsyncStateMachine(typeof(MonoTlsStream.<CreateStream>d__18))]
	// RVA: 0x201D380 Offset: 0x201BD80 VA: 0x18201D380
	internal Task<Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken) { }

	// RVA: 0x201D4D0 Offset: 0x201BED0 VA: 0x18201D4D0 Slot: 4
	public void Dispose() { }

	// RVA: 0x201D2D0 Offset: 0x201BCD0 VA: 0x18201D2D0
	private void CloseSslStream() { }
}
