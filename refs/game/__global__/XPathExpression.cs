public abstract class XPathExpression // TypeDefIndex: 8132
{
	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetContext(IXmlNamespaceResolver nsResolver);

	// RVA: 0x252CB00 Offset: 0x252B500 VA: 0x18252CB00
	public static XPathExpression Compile(string xpath) { }

	// RVA: 0x252CBD0 Offset: 0x252B5D0 VA: 0x18252CBD0
	public static XPathExpression Compile(string xpath, IXmlNamespaceResolver nsResolver) { }
}
