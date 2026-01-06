internal abstract class MobileAuthenticatedStream : AuthenticatedStream, IDisposable // TypeDefIndex: 9403
{
	// Fields
	private MobileTlsContext xobileTlsContext; // 0x38
	private ExceptionDispatchInfo lastException; // 0x40
	private AsyncProtocolRequest asyncHandshakeRequest; // 0x48
	private AsyncProtocolRequest asyncReadRequest; // 0x50
	private AsyncProtocolRequest asyncWriteRequest; // 0x58
	private BufferOffsetSize2 readBuffer; // 0x60
	private BufferOffsetSize2 writeBuffer; // 0x68
	private object ioLock; // 0x70
	private int closeRequested; // 0x78
	private bool shutdown; // 0x7C
	private MobileAuthenticatedStream.Operation operation; // 0x80
	private static int uniqueNameInteger; // 0x0
	[CompilerGenerated]
	private readonly SslStream <SslStream>k__BackingField; // 0x88
	[CompilerGenerated]
	private readonly MonoTlsSettings <Settings>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly MobileTlsProvider <Provider>k__BackingField; // 0x98
	[CompilerGenerated]
	private string <TargetHost>k__BackingField; // 0xA0
	private static int nextId; // 0x4
	internal readonly int ID; // 0xA8

	// Properties
	public SslStream SslStream { get; }
	public MonoTlsSettings Settings { get; }
	public MobileTlsProvider Provider { get; }
	internal string TargetHost { get; set; }
	public override bool IsAuthenticated { get; }
	public X509Certificate LocalCertificate { get; }
	public X509Certificate InternalLocalCertificate { get; }
	public override bool CanRead { get; }
	public override bool CanTimeout { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x20126F0 Offset: 0x20110F0 VA: 0x1820126F0
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	[CompilerGenerated]
	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080 Slot: 41
	public SslStream get_SslStream() { }

	[CompilerGenerated]
	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public MonoTlsSettings get_Settings() { }

	[CompilerGenerated]
	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public MobileTlsProvider get_Provider() { }

	[CompilerGenerated]
	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	internal string get_TargetHost() { }

	[CompilerGenerated]
	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00
	private void set_TargetHost(string value) { }

	// RVA: 0x2010A70 Offset: 0x200F470 VA: 0x182010A70
	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = False) { }

	// RVA: 0x2010FA0 Offset: 0x200F9A0 VA: 0x182010FA0
	internal static Exception GetSSPIException(Exception e) { }

	// RVA: 0x2010D80 Offset: 0x200F780 VA: 0x182010D80
	internal static Exception GetIOException(Exception e, string message) { }

	// RVA: 0x2010F00 Offset: 0x200F900 VA: 0x182010F00
	internal static Exception GetInternalError() { }

	// RVA: 0x2010F50 Offset: 0x200F950 VA: 0x182010F50
	internal static Exception GetInvalidNestedCallException() { }

	// RVA: 0x2012320 Offset: 0x2010D20 VA: 0x182012320
	internal ExceptionDispatchInfo SetException(Exception e) { }

	// RVA: 0x2010870 Offset: 0x200F270 VA: 0x182010870
	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x20106E0 Offset: 0x200F0E0 VA: 0x1820106E0 Slot: 42
	public Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	[AsyncStateMachine(typeof(MobileAuthenticatedStream.<ProcessAuthentication>d__48))]
	// RVA: 0x2011A40 Offset: 0x2010440 VA: 0x182011A40
	private Task ProcessAuthentication(bool runSynchronously, MonoSslAuthenticationOptions options, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 43
	protected abstract MobileTlsContext CreateContext(MonoSslAuthenticationOptions options);

	// RVA: 0x20121E0 Offset: 0x2010BE0 VA: 0x1820121E0 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x20125C0 Offset: 0x2010FC0 VA: 0x1820125C0 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2012130 Offset: 0x2010B30 VA: 0x182012130 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x2012510 Offset: 0x2010F10 VA: 0x182012510 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(MobileAuthenticatedStream.<StartOperation>d__57))]
	// RVA: 0x2012370 Offset: 0x2010D70 VA: 0x182012370
	private Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	// RVA: 0x2011510 Offset: 0x200FF10 VA: 0x182011510
	internal int InternalRead(byte[] buffer, int offset, int size, out bool outWantMore) { }

	// RVA: 0x2011390 Offset: 0x200FD90 VA: 0x182011390
	private ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size) { }

	// RVA: 0x20118C0 Offset: 0x20102C0 VA: 0x1820118C0
	internal bool InternalWrite(byte[] buffer, int offset, int size) { }

	// RVA: 0x2011700 Offset: 0x2010100 VA: 0x182011700
	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size) { }

	[AsyncStateMachine(typeof(MobileAuthenticatedStream.<InnerRead>d__66))]
	// RVA: 0x2011120 Offset: 0x200FB20 VA: 0x182011120
	internal Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(MobileAuthenticatedStream.<InnerWrite>d__67))]
	// RVA: 0x2011270 Offset: 0x200FC70 VA: 0x182011270
	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	// RVA: 0x2011B80 Offset: 0x2010580 VA: 0x182011B80
	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status, bool renegotiate) { }

	// RVA: 0x2011EB0 Offset: 0x20108B0 VA: 0x182011EB0
	internal ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer) { }

	// RVA: 0x2011FF0 Offset: 0x20109F0 VA: 0x182011FF0
	internal ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer) { }

	// RVA: 0x2012A70 Offset: 0x2011470 VA: 0x182012A70 Slot: 40
	public override bool get_IsAuthenticated() { }

	// RVA: 0x2010B70 Offset: 0x200F570 VA: 0x182010B70 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1C01DA0 Offset: 0x1C007A0 VA: 0x181C01DA0 Slot: 22
	public override void Flush() { }

	// RVA: 0x2012B40 Offset: 0x2011540 VA: 0x182012B40 Slot: 44
	public X509Certificate get_LocalCertificate() { }

	// RVA: 0x2012980 Offset: 0x2011380 VA: 0x182012980 Slot: 45
	public X509Certificate get_InternalLocalCertificate() { }

	// RVA: 0x20122E0 Offset: 0x2010CE0 VA: 0x1820122E0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E306D0 Offset: 0x1E2F0D0 VA: 0x181E306D0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x2012890 Offset: 0x2011290 VA: 0x182012890 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x20128E0 Offset: 0x20112E0 VA: 0x1820128E0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x2012910 Offset: 0x2011310 VA: 0x182012910 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1E30880 Offset: 0x1E2F280 VA: 0x181E30880 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1E308B0 Offset: 0x1E2F2B0 VA: 0x181E308B0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x2012CB0 Offset: 0x20116B0 VA: 0x182012CB0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x2012C50 Offset: 0x2011650 VA: 0x182012C50 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x2012CF0 Offset: 0x20116F0 VA: 0x182012CF0 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x2012C80 Offset: 0x2011680 VA: 0x182012C80 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x2012D20 Offset: 0x2011720 VA: 0x182012D20 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x20126B0 Offset: 0x20110B0 VA: 0x1820126B0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x20124C0 Offset: 0x2010EC0 VA: 0x1820124C0
	private void <InnerWrite>b__67_0() { }
}
