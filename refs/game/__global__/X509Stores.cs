public class X509Stores // TypeDefIndex: 17500
{
	// Fields
	private string _storePath; // 0x10
	private bool _newFormat; // 0x18
	private X509Store _trusted; // 0x20

	// Properties
	public X509Store TrustedRoot { get; }

	// Methods

	// RVA: 0x1A6E860 Offset: 0x1A6D260 VA: 0x181A6E860
	internal void .ctor(string path, bool newFormat) { }

	// RVA: 0x1A6E8B0 Offset: 0x1A6D2B0 VA: 0x181A6E8B0
	public X509Store get_TrustedRoot() { }

	// RVA: 0x1A6E730 Offset: 0x1A6D130 VA: 0x181A6E730
	public X509Store Open(string storeName, bool create) { }
}
