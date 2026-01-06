internal class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo, IXmlNamespaceResolver // TypeDefIndex: 7953
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x28

	// Methods

	// RVA: 0x24C4700 Offset: 0x24C3100 VA: 0x1824C4700
	public void .ctor(XmlReader reader) { }

	// RVA: 0x24C45E0 Offset: 0x24C2FE0 VA: 0x1824C45E0 Slot: 60
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x24C4640 Offset: 0x24C3040 VA: 0x1824C4640 Slot: 61
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x24C46A0 Offset: 0x24C30A0 VA: 0x1824C46A0 Slot: 62
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }
}
