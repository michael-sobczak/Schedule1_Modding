internal class X509CertificateImplCollection : IDisposable // TypeDefIndex: 9635
{
	// Fields
	private List<X509CertificateImpl> list; // 0x10

	// Properties
	public int Count { get; }
	public X509CertificateImpl Item { get; }

	// Methods

	// RVA: 0x2650B90 Offset: 0x264F590 VA: 0x182650B90
	public void .ctor() { }

	// RVA: 0x2650C10 Offset: 0x264F610 VA: 0x182650C10
	private void .ctor(X509CertificateImplCollection other) { }

	// RVA: 0x2650E20 Offset: 0x264F820 VA: 0x182650E20
	public int get_Count() { }

	// RVA: 0x2650E60 Offset: 0x264F860 VA: 0x182650E60
	public X509CertificateImpl get_Item(int index) { }

	// RVA: 0x2650880 Offset: 0x264F280 VA: 0x182650880
	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	// RVA: 0x2650970 Offset: 0x264F370 VA: 0x182650970
	public X509CertificateImplCollection Clone() { }

	// RVA: 0x2650B20 Offset: 0x264F520 VA: 0x182650B20 Slot: 4
	public void Dispose() { }

	// RVA: 0x26509D0 Offset: 0x264F3D0 VA: 0x1826509D0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x4D8670 Offset: 0x4D7070 VA: 0x1804D8670 Slot: 1
	protected override void Finalize() { }
}
