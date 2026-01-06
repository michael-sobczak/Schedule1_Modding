public abstract class XmlLinkedNode : XmlNode // TypeDefIndex: 8052
{
	// Fields
	internal XmlLinkedNode next; // 0x18

	// Properties
	public override XmlNode PreviousSibling { get; }
	public override XmlNode NextSibling { get; }

	// Methods

	// RVA: 0x25100D0 Offset: 0x250EAD0 VA: 0x1825100D0
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x25101D0 Offset: 0x250EBD0 VA: 0x1825101D0 Slot: 14
	public override XmlNode get_PreviousSibling() { }

	// RVA: 0x2510170 Offset: 0x250EB70 VA: 0x182510170 Slot: 15
	public override XmlNode get_NextSibling() { }
}
