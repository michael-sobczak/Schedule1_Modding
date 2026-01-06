internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode // TypeDefIndex: 11419
{
	// Fields
	[Nullable(1)]
	[CompilerGenerated]
	private readonly XDeclaration <Declaration>k__BackingField; // 0x18

	// Properties
	[Nullable(1)]
	internal XDeclaration Declaration { get; }
	public override XmlNodeType NodeType { get; }
	public string Version { get; }
	public string Encoding { get; set; }
	public string Standalone { get; set; }

	// Methods

	[CompilerGenerated]
	[NullableContext(1)]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal XDeclaration get_Declaration() { }

	[NullableContext(1)]
	// RVA: 0x1DF3B60 Offset: 0x1DF2560 VA: 0x181DF3B60
	public void .ctor(XDeclaration declaration) { }

	// RVA: 0x1DF3BD0 Offset: 0x1DF25D0 VA: 0x181DF3BD0 Slot: 14
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1DF3BE0 Offset: 0x1DF25E0 VA: 0x181DF3BE0 Slot: 23
	public string get_Version() { }

	// RVA: 0x1DF3BB0 Offset: 0x1DF25B0 VA: 0x181DF3BB0 Slot: 24
	public string get_Encoding() { }

	// RVA: 0x1DF3C00 Offset: 0x1DF2600 VA: 0x181DF3C00 Slot: 25
	public void set_Encoding(string value) { }

	// RVA: 0x14E79D0 Offset: 0x14E63D0 VA: 0x1814E79D0 Slot: 26
	public string get_Standalone() { }

	// RVA: 0x1DF3C30 Offset: 0x1DF2630 VA: 0x181DF3C30 Slot: 27
	public void set_Standalone(string value) { }
}
