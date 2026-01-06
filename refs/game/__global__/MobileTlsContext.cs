internal abstract class MobileTlsContext : IDisposable // TypeDefIndex: 9404
{
	// Fields
	private ChainValidationHelper certificateValidator; // 0x10
	[CompilerGenerated]
	private readonly MonoSslAuthenticationOptions <Options>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly bool <IsServer>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <TargetHost>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly string <ServerName>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly bool <AskForClientCertificate>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly SslProtocols <EnabledProtocols>k__BackingField; // 0x44
	[CompilerGenerated]
	private readonly X509CertificateCollection <ClientCertificates>k__BackingField; // 0x48
	[CompilerGenerated]
	private X509Certificate <LocalServerCertificate>k__BackingField; // 0x50

	// Properties
	internal MonoSslAuthenticationOptions Options { get; }
	internal MobileAuthenticatedStream Parent { get; }
	public MonoTlsSettings Settings { get; }
	public abstract bool IsAuthenticated { get; }
	public bool IsServer { get; }
	internal string TargetHost { get; }
	protected string ServerName { get; }
	protected bool AskForClientCertificate { get; }
	protected SslProtocols EnabledProtocols { get; }
	protected X509CertificateCollection ClientCertificates { get; }
	internal X509Certificate LocalServerCertificate { get; set; }
	internal abstract X509Certificate LocalClientCertificate { get; }
	public abstract X509Certificate2 RemoteCertificate { get; }

	// Methods

	// RVA: 0x2013780 Offset: 0x2012180 VA: 0x182013780
	protected void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal MonoSslAuthenticationOptions get_Options() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0x2013A30 Offset: 0x2012430 VA: 0x182013A30
	public MonoTlsSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsAuthenticated();

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsServer() { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal string get_TargetHost() { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	protected string get_ServerName() { }

	[CompilerGenerated]
	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	protected bool get_AskForClientCertificate() { }

	[CompilerGenerated]
	// RVA: 0x594500 Offset: 0x592F00 VA: 0x180594500
	protected SslProtocols get_EnabledProtocols() { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x2012E30 Offset: 0x2011830 VA: 0x182012E30
	protected void GetProtocolVersions(out Nullable<TlsProtocolCode> min, out Nullable<TlsProtocolCode> max) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StartHandshake();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ProcessHandshake();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FinishHandshake();

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	internal X509Certificate get_LocalServerCertificate() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	private void set_LocalServerCertificate(X509Certificate value) { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract X509Certificate get_LocalClientCertificate();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract X509Certificate2 get_RemoteCertificate();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Flush();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void Shutdown();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool PendingRenegotiation();

	// RVA: 0x2013720 Offset: 0x2012120 VA: 0x182013720
	protected bool ValidateCertificate(X509Certificate2 leaf, X509Chain chain) { }

	// RVA: 0x2013450 Offset: 0x2011E50 VA: 0x182013450
	protected X509Certificate SelectServerCertificate(string serverIdentity) { }

	// RVA: 0x2012F20 Offset: 0x2011920 VA: 0x182012F20
	protected X509Certificate SelectClientCertificate(string[] acceptableIssuers) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Renegotiate();

	// RVA: 0x2012D50 Offset: 0x2011750 VA: 0x182012D50 Slot: 4
	public void Dispose() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 17
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2012DC0 Offset: 0x20117C0 VA: 0x182012DC0 Slot: 1
	protected override void Finalize() { }
}
