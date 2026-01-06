internal class X509ChainImplMono : X509ChainImpl // TypeDefIndex: 9641
{
	// Fields
	private StoreLocation location; // 0x10
	private X509ChainElementCollection elements; // 0x18
	private X509ChainPolicy policy; // 0x20
	private X509ChainStatus[] status; // 0x28
	private static X509ChainStatus[] Empty; // 0x0
	private int max_path_length; // 0x30
	private X500DistinguishedName working_issuer_name; // 0x38
	private AsymmetricAlgorithm working_public_key; // 0x40
	private X509ChainElement bce_restriction; // 0x48
	private X509Certificate2Collection roots; // 0x50
	private X509Certificate2Collection cas; // 0x58
	private X509Store root_store; // 0x60
	private X509Store ca_store; // 0x68
	private X509Store user_root_store; // 0x70
	private X509Store user_ca_store; // 0x78
	private X509Certificate2Collection collection; // 0x80

	// Properties
	public override bool IsValid { get; }
	public override X509ChainElementCollection ChainElements { get; }
	public override X509ChainPolicy ChainPolicy { get; }
	public override X509ChainStatus[] ChainStatus { get; }
	private X509Certificate2Collection Roots { get; }
	private X509Certificate2Collection CertificateAuthorities { get; }
	private X509Store LMRootStore { get; }
	private X509Store UserRootStore { get; }
	private X509Store LMCAStore { get; }
	private X509Store UserCAStore { get; }
	private X509Certificate2Collection CertificateCollection { get; }

	// Methods

	// RVA: 0x2655680 Offset: 0x2654080 VA: 0x182655680
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 6
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 7
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x2655C70 Offset: 0x2654670 VA: 0x182655C70 Slot: 8
	public override X509ChainStatus[] get_ChainStatus() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	public override void AddStatus(X509ChainStatusFlags error) { }

	[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
	// RVA: 0x26528C0 Offset: 0x26512C0 VA: 0x1826528C0 Slot: 9
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x2654D70 Offset: 0x2653770 VA: 0x182654D70 Slot: 11
	public override void Reset() { }

	// RVA: 0x2655E20 Offset: 0x2654820 VA: 0x182655E20
	private X509Certificate2Collection get_Roots() { }

	// RVA: 0x2655880 Offset: 0x2654280 VA: 0x182655880
	private X509Certificate2Collection get_CertificateAuthorities() { }

	// RVA: 0x2655D80 Offset: 0x2654780 VA: 0x182655D80
	private X509Store get_LMRootStore() { }

	// RVA: 0x2656070 Offset: 0x2654A70 VA: 0x182656070
	private X509Store get_UserRootStore() { }

	// RVA: 0x2655CE0 Offset: 0x26546E0 VA: 0x182655CE0
	private X509Store get_LMCAStore() { }

	// RVA: 0x2655FD0 Offset: 0x26549D0 VA: 0x182655FD0
	private X509Store get_UserCAStore() { }

	// RVA: 0x2655A30 Offset: 0x2654430 VA: 0x182655A30
	private X509Certificate2Collection get_CertificateCollection() { }

	// RVA: 0x2652530 Offset: 0x2650F30 VA: 0x182652530
	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	// RVA: 0x2654F50 Offset: 0x2653950 VA: 0x182654F50
	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	// RVA: 0x2653A90 Offset: 0x2652490 VA: 0x182653A90
	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	// RVA: 0x2653F70 Offset: 0x2652970 VA: 0x182653F70
	private bool IsChainComplete(X509Certificate2 certificate) { }

	// RVA: 0x26540C0 Offset: 0x2652AC0 VA: 0x1826540C0
	private bool IsSelfIssued(X509Certificate2 certificate) { }

	// RVA: 0x2655200 Offset: 0x2653C00 VA: 0x182655200
	private void ValidateChain(X509ChainStatusFlags flag) { }

	// RVA: 0x2654A00 Offset: 0x2653400 VA: 0x182654A00
	private void Process(int n) { }

	// RVA: 0x2654160 Offset: 0x2652B60 VA: 0x182654160
	private void PrepareForNextCertificate(int n) { }

	// RVA: 0x26554A0 Offset: 0x2653EA0 VA: 0x1826554A0
	private void WrapUp() { }

	// RVA: 0x2654490 Offset: 0x2652E90 VA: 0x182654490
	private void ProcessCertificateExtensions(X509ChainElement element) { }

	// RVA: 0x2654110 Offset: 0x2652B10 VA: 0x182654110
	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	// RVA: 0x2653EC0 Offset: 0x26528C0 VA: 0x182653EC0
	private string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x2653C40 Offset: 0x2652640 VA: 0x182653C40
	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x2653CD0 Offset: 0x26526D0 VA: 0x182653CD0
	private static string GetAuthorityKeyIdentifier(X509Crl crl) { }

	// RVA: 0x2653D50 Offset: 0x2652750 VA: 0x182653D50
	private static string GetAuthorityKeyIdentifier(X509Extension ext) { }

	// RVA: 0x2653250 Offset: 0x2651C50 VA: 0x182653250
	private void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	// RVA: 0x26536C0 Offset: 0x26520C0 VA: 0x1826536C0
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	// RVA: 0x26534B0 Offset: 0x2651EB0 VA: 0x1826534B0
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	// RVA: 0x2653020 Offset: 0x2651A20 VA: 0x182653020
	private static X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	// RVA: 0x2653800 Offset: 0x2652200 VA: 0x182653800
	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	// RVA: 0x2654800 Offset: 0x2653200 VA: 0x182654800
	private bool ProcessCrlExtensions(X509Crl crl) { }

	// RVA: 0x2654640 Offset: 0x2653040 VA: 0x182654640
	private bool ProcessCrlEntryExtensions(X509Crl.X509CrlEntry entry) { }

	// RVA: 0x2655610 Offset: 0x2654010 VA: 0x182655610
	private static void .cctor() { }
}
