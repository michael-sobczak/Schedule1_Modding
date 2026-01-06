internal class X509ChainImplBtls : X509ChainImpl // TypeDefIndex: 9480
{
	// Fields
	private MonoBtlsX509StoreCtx storeCtx; // 0x10
	private MonoBtlsX509Chain chain; // 0x18
	private MonoBtlsX509Chain untrustedChain; // 0x20
	private X509ChainElementCollection elements; // 0x28
	private X509Certificate2Collection untrusted; // 0x30
	private X509Certificate2[] certificates; // 0x38
	private X509ChainPolicy policy; // 0x40
	private List<X509ChainStatus> chainStatusList; // 0x48

	// Properties
	public override bool IsValid { get; }
	internal MonoBtlsX509StoreCtx StoreCtx { get; }
	public override X509ChainElementCollection ChainElements { get; }
	public override X509ChainPolicy ChainPolicy { get; }
	public override X509ChainStatus[] ChainStatus { get; }

	// Methods

	// RVA: 0x2611850 Offset: 0x2610250 VA: 0x182611850
	internal void .ctor(MonoBtlsX509Chain chain) { }

	// RVA: 0x2611290 Offset: 0x260FC90 VA: 0x182611290
	internal void .ctor(MonoBtlsX509StoreCtx storeCtx) { }

	// RVA: 0x2611D30 Offset: 0x2610730 VA: 0x182611D30 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x2611D50 Offset: 0x2610750 VA: 0x182611D50
	internal MonoBtlsX509StoreCtx get_StoreCtx() { }

	// RVA: 0x2611A00 Offset: 0x2610400 VA: 0x182611A00 Slot: 6
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 7
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x2611CC0 Offset: 0x26106C0 VA: 0x182611CC0 Slot: 8
	public override X509ChainStatus[] get_ChainStatus() { }

	// RVA: 0x2610F40 Offset: 0x260F940 VA: 0x182610F40 Slot: 10
	public override void AddStatus(X509ChainStatusFlags errorCode) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x26111E0 Offset: 0x260FBE0 VA: 0x1826111E0 Slot: 11
	public override void Reset() { }

	// RVA: 0x2611080 Offset: 0x260FA80 VA: 0x182611080 Slot: 12
	protected override void Dispose(bool disposing) { }
}
