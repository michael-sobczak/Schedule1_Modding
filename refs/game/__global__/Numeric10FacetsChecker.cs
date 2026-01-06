internal class Numeric10FacetsChecker : FacetsChecker // TypeDefIndex: 8349
{
	// Fields
	private static readonly char[] signs; // 0x0
	private Decimal maxValue; // 0x10
	private Decimal minValue; // 0x20

	// Methods

	// RVA: 0x2594A60 Offset: 0x2593460 VA: 0x182594A60
	internal void .ctor(Decimal minVal, Decimal maxVal) { }

	// RVA: 0x2593E00 Offset: 0x2592800 VA: 0x182593E00 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x2593EA0 Offset: 0x25928A0 VA: 0x182593EA0 Slot: 6
	internal override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x2594670 Offset: 0x2593070 VA: 0x182594670 Slot: 7
	internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0x25945E0 Offset: 0x2592FE0 VA: 0x1825945E0 Slot: 8
	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x2593D70 Offset: 0x2592770 VA: 0x182593D70 Slot: 9
	internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0x2594700 Offset: 0x2593100 VA: 0x182594700 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x2594890 Offset: 0x2593290 VA: 0x182594890
	internal bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x25939C0 Offset: 0x25923C0 VA: 0x1825939C0
	internal Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

	// RVA: 0x25949C0 Offset: 0x25933C0 VA: 0x1825949C0
	private static void .cctor() { }
}
