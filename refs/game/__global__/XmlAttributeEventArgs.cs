public class XmlAttributeEventArgs : EventArgs // TypeDefIndex: 8143
{
	// Fields
	private object o; // 0x10
	private XmlAttribute attr; // 0x18
	private string qnames; // 0x20
	private int lineNumber; // 0x28
	private int linePosition; // 0x2C

	// Methods

	// RVA: 0x25301F0 Offset: 0x252EBF0 VA: 0x1825301F0
	internal void .ctor(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }
}
