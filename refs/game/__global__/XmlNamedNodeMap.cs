public class XmlNamedNodeMap : IEnumerable // TypeDefIndex: 8058
{
	// Fields
	internal XmlNode parent; // 0x10
	internal XmlNamedNodeMap.SmallXmlNodeList nodes; // 0x18

	// Properties
	public virtual int Count { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x25162A0 Offset: 0x2514CA0 VA: 0x1825162A0 Slot: 5
	public virtual XmlNode GetNamedItem(string name) { }

	// RVA: 0x25167C0 Offset: 0x25151C0 VA: 0x1825167C0 Slot: 6
	public virtual XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x25169B0 Offset: 0x25153B0 VA: 0x1825169B0 Slot: 7
	public virtual int get_Count() { }

	// RVA: 0x2516290 Offset: 0x2514C90 VA: 0x182516290 Slot: 8
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x2516050 Offset: 0x2514A50 VA: 0x182516050
	internal int FindNodeOffset(string name) { }

	// RVA: 0x2516150 Offset: 0x2514B50 VA: 0x182516150
	internal int FindNodeOffset(string localName, string namespaceURI) { }

	// RVA: 0x2515EB0 Offset: 0x25148B0 VA: 0x182515EB0 Slot: 9
	internal virtual XmlNode AddNode(XmlNode node) { }

	// RVA: 0x2515DE0 Offset: 0x25147E0 VA: 0x182515DE0 Slot: 10
	internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	// RVA: 0x25165D0 Offset: 0x2514FD0 VA: 0x1825165D0 Slot: 11
	internal virtual XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x2516750 Offset: 0x2515150 VA: 0x182516750
	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	// RVA: 0x2516420 Offset: 0x2514E20 VA: 0x182516420 Slot: 12
	internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }
}
