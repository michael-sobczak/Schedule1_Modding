internal class Variable : AstNode // TypeDefIndex: 8591
{
	// Fields
	private string _localname; // 0x10
	private string _prefix; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public string Localname { get; }
	public string Prefix { get; }

	// Methods

	// RVA: 0x4870B0 Offset: 0x485AB0 VA: 0x1804870B0
	public void .ctor(string name, string prefix) { }

	// RVA: 0xA02640 Offset: 0xA01040 VA: 0x180A02640 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x578D60 Offset: 0x577760 VA: 0x180578D60 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Localname() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Prefix() { }
}
