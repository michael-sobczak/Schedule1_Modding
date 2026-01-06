internal class X509ChainImplUnityTls : X509ChainImpl // TypeDefIndex: 9381
{
	// Fields
	private X509ChainElementCollection elements; // 0x10
	private UnityTls.unitytls_x509list* ownedList; // 0x18
	private UnityTls.unitytls_x509list_ref nativeCertificateChain; // 0x20
	private X509ChainPolicy policy; // 0x28
	private List<X509ChainStatus> chainStatusList; // 0x30
	private bool reverseOrder; // 0x38

	// Properties
	public override bool IsValid { get; }
	internal UnityTls.unitytls_x509list_ref NativeCertificateChain { get; }
	public override X509ChainElementCollection ChainElements { get; }
	public override X509ChainPolicy ChainPolicy { get; }
	public override X509ChainStatus[] ChainStatus { get; }

	// Methods

	// RVA: 0x2026150 Offset: 0x2024B50 VA: 0x182026150
	internal void .ctor(UnityTls.unitytls_x509list_ref nativeCertificateChain, bool reverseOrder = False) { }

	// RVA: 0x2026070 Offset: 0x2024A70 VA: 0x182026070
	internal void .ctor(UnityTls.unitytls_x509list* ownedList, UnityTls.unitytls_errorstate* errorState, bool reverseOrder = False) { }

	// RVA: 0x20265D0 Offset: 0x2024FD0 VA: 0x1820265D0 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal UnityTls.unitytls_x509list_ref get_NativeCertificateChain() { }

	// RVA: 0x20261F0 Offset: 0x2024BF0 VA: 0x1820261F0 Slot: 6
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x2025E60 Offset: 0x2024860 VA: 0x182025E60 Slot: 10
	public override void AddStatus(X509ChainStatusFlags error) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 7
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x2026560 Offset: 0x2024F60 VA: 0x182026560 Slot: 8
	public override X509ChainStatus[] get_ChainStatus() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x2025FE0 Offset: 0x20249E0 VA: 0x182025FE0 Slot: 11
	public override void Reset() { }

	// RVA: 0x2025FA0 Offset: 0x20249A0 VA: 0x182025FA0 Slot: 12
	protected override void Dispose(bool disposing) { }
}
