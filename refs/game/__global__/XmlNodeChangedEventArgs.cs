public class XmlNodeChangedEventArgs : EventArgs // TypeDefIndex: 8060
{
	// Fields
	private XmlNodeChangedAction action; // 0x10
	private XmlNode node; // 0x18
	private XmlNode oldParent; // 0x20
	private XmlNode newParent; // 0x28
	private string oldValue; // 0x30
	private string newValue; // 0x38

	// Properties
	public XmlNodeChangedAction Action { get; }

	// Methods

	// RVA: 0x25169C0 Offset: 0x25153C0 VA: 0x1825169C0
	public void .ctor(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public XmlNodeChangedAction get_Action() { }
}
