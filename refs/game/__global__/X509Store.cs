public class X509Store // TypeDefIndex: 17498
{
	// Fields
	private string _storePath; // 0x10
	private X509CertificateCollection _certificates; // 0x18
	private ArrayList _crls; // 0x20
	private bool _crl; // 0x28
	private bool _newFormat; // 0x29

	// Properties
	public X509CertificateCollection Certificates { get; }
	public ArrayList Crls { get; }

	// Methods

	// RVA: 0x1A6E600 Offset: 0x1A6D000 VA: 0x181A6E600
	internal void .ctor(string path, bool crl, bool newFormat) { }

	// RVA: 0x1A6E660 Offset: 0x1A6D060 VA: 0x181A6E660
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x1A6E6A0 Offset: 0x1A6D0A0 VA: 0x181A6E6A0
	public ArrayList get_Crls() { }

	// RVA: 0x1A6E4A0 Offset: 0x1A6CEA0 VA: 0x181A6E4A0
	private byte[] Load(string filename) { }

	// RVA: 0x1A6E2D0 Offset: 0x1A6CCD0 VA: 0x181A6E2D0
	private X509Certificate LoadCertificate(string filename) { }

	// RVA: 0x1A6E340 Offset: 0x1A6CD40 VA: 0x181A6E340
	private X509Crl LoadCrl(string filename) { }

	// RVA: 0x1A6E270 Offset: 0x1A6CC70 VA: 0x181A6E270
	private bool CheckStore(string path, bool throwException) { }

	// RVA: 0x1A6DF50 Offset: 0x1A6C950 VA: 0x181A6DF50
	private X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	// RVA: 0x1A6E120 Offset: 0x1A6CB20 VA: 0x181A6E120
	private ArrayList BuildCrlsCollection(string storeName) { }
}
