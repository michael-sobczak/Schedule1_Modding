public class XmlImplementation // TypeDefIndex: 8051
{
	// Fields
	private XmlNameTable nameTable; // 0x10

	// Properties
	internal XmlNameTable NameTable { get; }

	// Methods

	// RVA: 0x2510010 Offset: 0x250EA10 VA: 0x182510010
	public void .ctor() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x250FFB0 Offset: 0x250E9B0 VA: 0x18250FFB0 Slot: 4
	public virtual XmlDocument CreateDocument() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal XmlNameTable get_NameTable() { }
}
