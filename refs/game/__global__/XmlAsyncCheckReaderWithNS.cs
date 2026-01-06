internal class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader, IXmlNamespaceResolver // TypeDefIndex: 7951
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x20

	// Methods

	// RVA: 0x24C4A70 Offset: 0x24C3470 VA: 0x1824C4A70
	public void .ctor(XmlReader reader) { }

	// RVA: 0x24C4950 Offset: 0x24C3350 VA: 0x1824C4950 Slot: 54
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x24C49B0 Offset: 0x24C33B0 VA: 0x1824C49B0 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x24C4A10 Offset: 0x24C3410 VA: 0x1824C4A10 Slot: 56
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }
}
