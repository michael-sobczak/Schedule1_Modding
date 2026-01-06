public abstract class XsltContext : XmlNamespaceManager // TypeDefIndex: 8231
{
	// Properties
	public abstract bool Whitespace { get; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	internal void .ctor(bool dummy) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract IXsltContextVariable ResolveVariable(string prefix, string name);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool get_Whitespace();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract bool PreserveWhitespace(XPathNavigator node);
}
