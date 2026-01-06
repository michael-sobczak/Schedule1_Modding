public class XDocumentType : XNode // TypeDefIndex: 18620
{
	// Fields
	private string _name; // 0x28
	private string _publicId; // 0x30
	private string _systemId; // 0x38
	private string _internalSubset; // 0x40

	// Properties
	public string InternalSubset { get; }
	public string Name { get; }
	public override XmlNodeType NodeType { get; }
	public string PublicId { get; }
	public string SystemId { get; }

	// Methods

	// RVA: 0x23C6FF0 Offset: 0x23C59F0 VA: 0x1823C6FF0
	public void .ctor(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x23C6F30 Offset: 0x23C5930 VA: 0x1823C6F30
	public void .ctor(XDocumentType other) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public string get_InternalSubset() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Name() { }

	// RVA: 0xA2A280 Offset: 0xA28C80 VA: 0x180A2A280 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_PublicId() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_SystemId() { }

	// RVA: 0x23C6E90 Offset: 0x23C5890 VA: 0x1823C6E90 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x23C6DA0 Offset: 0x23C57A0 VA: 0x1823C6DA0 Slot: 10
	internal override XNode CloneNode() { }
}
