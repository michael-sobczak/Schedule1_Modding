internal class MonoBtlsX509LookupMonoCollection : MonoBtlsX509LookupMono // TypeDefIndex: 9465
{
	// Fields
	private long[] hashes; // 0x48
	private MonoBtlsX509[] certificates; // 0x50
	private X509CertificateCollection collection; // 0x58
	private MonoBtlsX509TrustKind trust; // 0x60

	// Methods

	// RVA: 0x2601950 Offset: 0x2600350 VA: 0x182601950
	internal void .ctor(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	// RVA: 0x2601570 Offset: 0x25FFF70 VA: 0x182601570
	private void Initialize() { }

	// RVA: 0x2601880 Offset: 0x2600280 VA: 0x182601880 Slot: 6
	protected override MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

	// RVA: 0x2601410 Offset: 0x25FFE10 VA: 0x182601410 Slot: 5
	protected override void Close() { }
}
