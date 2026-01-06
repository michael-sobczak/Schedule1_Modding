public class XDeclaration // TypeDefIndex: 18618
{
	// Fields
	private string _version; // 0x10
	private string _encoding; // 0x18
	private string _standalone; // 0x20

	// Properties
	public string Encoding { get; set; }
	public string Standalone { get; set; }
	public string Version { get; }

	// Methods

	// RVA: 0x43EE90 Offset: 0x43D890 VA: 0x18043EE90
	public void .ctor(string version, string encoding, string standalone) { }

	// RVA: 0x23C6CF0 Offset: 0x23C56F0 VA: 0x1823C6CF0
	public void .ctor(XDeclaration other) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Encoding() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Encoding(string value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Standalone() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Standalone(string value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Version() { }

	// RVA: 0x23C6B30 Offset: 0x23C5530 VA: 0x1823C6B30 Slot: 3
	public override string ToString() { }
}
