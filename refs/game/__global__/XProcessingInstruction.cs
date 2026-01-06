public class XProcessingInstruction : XNode // TypeDefIndex: 18640
{
	// Fields
	internal string target; // 0x28
	internal string data; // 0x30

	// Properties
	public string Data { get; set; }
	public override XmlNodeType NodeType { get; }
	public string Target { get; }

	// Methods

	// RVA: 0x23CB8E0 Offset: 0x23CA2E0 VA: 0x1823CB8E0
	public void .ctor(string target, string data) { }

	// RVA: 0x23CBA40 Offset: 0x23CA440 VA: 0x1823CBA40
	public void .ctor(XProcessingInstruction other) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_Data() { }

	// RVA: 0x23CBAE0 Offset: 0x23CA4E0 VA: 0x1823CBAE0
	public void set_Data(string value) { }

	// RVA: 0xA02640 Offset: 0xA01040 VA: 0x180A02640 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Target() { }

	// RVA: 0x23CB850 Offset: 0x23CA250 VA: 0x1823CB850 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x23CB6B0 Offset: 0x23CA0B0 VA: 0x1823CB6B0 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: 0x23CB770 Offset: 0x23CA170 VA: 0x1823CB770
	private static void ValidateName(string name) { }
}
