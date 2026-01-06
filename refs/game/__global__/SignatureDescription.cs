public class SignatureDescription // TypeDefIndex: 4230
{
	// Fields
	private string _strKey; // 0x10
	private string _strDigest; // 0x18
	private string _strFormatter; // 0x20
	private string _strDeformatter; // 0x28

	// Properties
	public string KeyAlgorithm { set; }
	public string DigestAlgorithm { set; }
	public string FormatterAlgorithm { set; }
	public string DeformatterAlgorithm { set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_KeyAlgorithm(string value) { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_DigestAlgorithm(string value) { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_FormatterAlgorithm(string value) { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_DeformatterAlgorithm(string value) { }
}
