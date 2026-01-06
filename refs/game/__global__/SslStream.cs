public class SslStream : AuthenticatedStream // TypeDefIndex: 10235
{
	// Fields
	private MobileTlsProvider provider; // 0x38
	private MonoTlsSettings settings; // 0x40
	private RemoteCertificateValidationCallback validationCallback; // 0x48
	private LocalCertificateSelectionCallback selectionCallback; // 0x50
	private MobileAuthenticatedStream impl; // 0x58
	private bool explicitSettings; // 0x60

	// Properties
	internal MobileAuthenticatedStream Impl { get; }
	internal string InternalTargetHost { get; }
	public override bool IsAuthenticated { get; }
	public virtual X509Certificate LocalCertificate { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanTimeout { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x25F0790 Offset: 0x25EF190 VA: 0x1825F0790
	internal MobileAuthenticatedStream get_Impl() { }

	// RVA: 0x25F0800 Offset: 0x25EF200 VA: 0x1825F0800
	internal string get_InternalTargetHost() { }

	// RVA: 0x25EFD90 Offset: 0x25EE790 VA: 0x1825EFD90
	private static MobileTlsProvider GetProvider() { }

	// RVA: 0x25F04F0 Offset: 0x25EEEF0 VA: 0x1825F04F0
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) { }

	// RVA: 0x25F0510 Offset: 0x25EEF10 VA: 0x1825F0510
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) { }

	// RVA: 0x25F0380 Offset: 0x25EED80 VA: 0x1825F0380
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x25F0110 Offset: 0x25EEB10 VA: 0x1825F0110
	private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback) { }

	// RVA: 0x25EFF60 Offset: 0x25EE960 VA: 0x1825EFF60
	private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback) { }

	// RVA: 0x25EF9F0 Offset: 0x25EE3F0 VA: 0x1825EF9F0 Slot: 41
	public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x25EFA70 Offset: 0x25EE470 VA: 0x1825EFA70 Slot: 42
	public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1ACAE10 Offset: 0x1AC9810 VA: 0x181ACAE10 Slot: 43
	public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x25EF970 Offset: 0x25EE370 VA: 0x1825EF970 Slot: 44
	public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x25F0870 Offset: 0x25EF270 VA: 0x1825F0870 Slot: 40
	public override bool get_IsAuthenticated() { }

	// RVA: 0x25F0970 Offset: 0x25EF370 VA: 0x1825F0970 Slot: 45
	public virtual X509Certificate get_LocalCertificate() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x25F0730 Offset: 0x25EF130 VA: 0x1825F0730 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x20128E0 Offset: 0x20112E0 VA: 0x1820128E0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x25F0760 Offset: 0x25EF160 VA: 0x1825F0760 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x25F0A60 Offset: 0x25EF460 VA: 0x1825F0A60 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x25F0BC0 Offset: 0x25EF5C0 VA: 0x1825F0BC0 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x25F0AE0 Offset: 0x25EF4E0 VA: 0x1825F0AE0 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x25F0C40 Offset: 0x25EF640 VA: 0x1825F0C40 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x25F08F0 Offset: 0x25EF2F0 VA: 0x1825F08F0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x25F09E0 Offset: 0x25EF3E0 VA: 0x1825F09E0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x25F0B60 Offset: 0x25EF560 VA: 0x1825F0B60 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x25F0200 Offset: 0x25EEC00 VA: 0x1825F0200 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x25EFF00 Offset: 0x25EE900 VA: 0x1825EFF00 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2171280 Offset: 0x216FC80 VA: 0x182171280 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1C01DA0 Offset: 0x1C007A0 VA: 0x181C01DA0 Slot: 22
	public override void Flush() { }

	// RVA: 0x25EFC30 Offset: 0x25EE630 VA: 0x1825EFC30
	private void CheckDisposed() { }

	// RVA: 0x25EFCA0 Offset: 0x25EE6A0 VA: 0x1825EFCA0 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x25EFE80 Offset: 0x25EE880 VA: 0x1825EFE80 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x25F0300 Offset: 0x25EED00 VA: 0x1825F0300 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x25EFE00 Offset: 0x25EE800 VA: 0x1825EFE00 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x25F0280 Offset: 0x25EEC80 VA: 0x1825F0280 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x25EFB10 Offset: 0x25EE510 VA: 0x1825EFB10 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x25EFD50 Offset: 0x25EE750 VA: 0x1825EFD50 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x25EFBA0 Offset: 0x25EE5A0 VA: 0x1825EFBA0 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1ACAE10 Offset: 0x1AC9810 VA: 0x181ACAE10 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }
}
