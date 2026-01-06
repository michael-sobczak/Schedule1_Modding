internal class DurationFacetsChecker : FacetsChecker // TypeDefIndex: 8351
{
	// Methods

	// RVA: 0x258DBA0 Offset: 0x258C5A0 VA: 0x18258DBA0 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x258D7F0 Offset: 0x258C1F0 VA: 0x18258D7F0 Slot: 15
	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x258DCD0 Offset: 0x258C6D0 VA: 0x18258DCD0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x258DD60 Offset: 0x258C760 VA: 0x18258DD60
	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
