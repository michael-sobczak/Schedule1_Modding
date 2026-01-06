public class X509Certificate2Collection : X509CertificateCollection // TypeDefIndex: 9628
{
	// Fields
	private static string[] newline_split; // 0x0

	// Properties
	public X509Certificate2 Item { get; }

	// Methods

	// RVA: 0x1A67BB0 Offset: 0x1A665B0 VA: 0x181A67BB0
	public void .ctor() { }

	// RVA: 0x264BC60 Offset: 0x264A660 VA: 0x18264BC60
	public void .ctor(X509Certificate2Collection certificates) { }

	// RVA: 0x264BD00 Offset: 0x264A700 VA: 0x18264BD00
	public X509Certificate2 get_Item(int index) { }

	// RVA: 0x264A780 Offset: 0x2649180 VA: 0x18264A780
	public int Add(X509Certificate2 certificate) { }

	[MonoTODO("Method isn't transactional (like documented)")]
	// RVA: 0x264A6F0 Offset: 0x26490F0 VA: 0x18264A6F0
	public void AddRange(X509Certificate2Collection certificates) { }

	// RVA: 0x264A810 Offset: 0x2649210 VA: 0x18264A810
	public bool Contains(X509Certificate2 certificate) { }

	// RVA: 0x264BAE0 Offset: 0x264A4E0 VA: 0x18264BAE0
	private string GetKeyIdentifier(X509Certificate2 x) { }

	[MonoTODO("Does not support X509FindType.FindByTemplateName, FindByApplicationPolicy and FindByCertificatePolicy")]
	// RVA: 0x264AA30 Offset: 0x2649430 VA: 0x18264AA30
	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) { }

	// RVA: 0x264BA40 Offset: 0x264A440 VA: 0x18264BA40
	public X509Certificate2Enumerator GetEnumerator() { }

	// RVA: 0x264BBC0 Offset: 0x264A5C0 VA: 0x18264BBC0
	private static void .cctor() { }
}
