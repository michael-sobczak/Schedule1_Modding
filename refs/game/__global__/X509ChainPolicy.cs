public sealed class X509ChainPolicy // TypeDefIndex: 9642
{
	// Fields
	private OidCollection apps; // 0x10
	private OidCollection cert; // 0x18
	private X509CertificateCollection store; // 0x20
	private X509Certificate2Collection store2; // 0x28
	private X509RevocationFlag rflag; // 0x30
	private X509RevocationMode mode; // 0x34
	private TimeSpan timeout; // 0x38
	private X509VerificationFlags vflags; // 0x40
	private DateTime vtime; // 0x48

	// Properties
	public X509Certificate2Collection ExtraStore { get; set; }
	public X509RevocationFlag RevocationFlag { get; set; }
	public X509RevocationMode RevocationMode { get; set; }
	public TimeSpan UrlRetrievalTimeout { set; }
	public X509VerificationFlags VerificationFlags { get; set; }
	public DateTime VerificationTime { get; }

	// Methods

	// RVA: 0x26562E0 Offset: 0x2654CE0 VA: 0x1826562E0
	public void .ctor() { }

	// RVA: 0x2656400 Offset: 0x2654E00 VA: 0x182656400
	public X509Certificate2Collection get_ExtraStore() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	internal void set_ExtraStore(X509Certificate2Collection value) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public X509RevocationFlag get_RevocationFlag() { }

	// RVA: 0x2656750 Offset: 0x2655150 VA: 0x182656750
	public void set_RevocationFlag(X509RevocationFlag value) { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public X509RevocationMode get_RevocationMode() { }

	// RVA: 0x26567C0 Offset: 0x26551C0 VA: 0x1826567C0
	public void set_RevocationMode(X509RevocationMode value) { }

	// RVA: 0x57CCF0 Offset: 0x57B6F0 VA: 0x18057CCF0
	public void set_UrlRetrievalTimeout(TimeSpan value) { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public X509VerificationFlags get_VerificationFlags() { }

	// RVA: 0x2656830 Offset: 0x2655230 VA: 0x182656830
	public void set_VerificationFlags(X509VerificationFlags value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public DateTime get_VerificationTime() { }

	// RVA: 0x26561D0 Offset: 0x2654BD0 VA: 0x1826561D0
	public void Reset() { }
}
