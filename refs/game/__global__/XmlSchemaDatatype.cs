public abstract class XmlSchemaDatatype // TypeDefIndex: 8430
{
	// Properties
	public abstract Type ValueType { get; }
	public abstract XmlTokenizedType TokenizedType { get; }
	public virtual XmlSchemaDatatypeVariety Variety { get; }
	public virtual XmlTypeCode TypeCode { get; }
	internal abstract bool HasLexicalFacets { get; }
	internal abstract bool HasValueFacets { get; }
	internal abstract XmlValueConverter ValueConverter { get; }
	internal abstract RestrictionFacets Restriction { get; }
	internal abstract FacetsChecker FacetsChecker { get; }
	internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal string TypeCodeString { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XmlTokenizedType get_TokenizedType();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr);

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 7
	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 8
	public virtual XmlTypeCode get_TypeCode() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool get_HasLexicalFacets();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool get_HasValueFacets();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract XmlValueConverter get_ValueConverter();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract RestrictionFacets get_Restriction();

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract int Compare(object value1, object value2);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue);

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue);

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract FacetsChecker get_FacetsChecker();

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType);

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType);

	// RVA: -1 Offset: -1 Slot: 22
	internal abstract void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller);

	// RVA: -1 Offset: -1 Slot: 23
	internal abstract bool IsEqual(object o1, object o2);

	// RVA: -1 Offset: -1 Slot: 24
	internal abstract bool IsComparable(XmlSchemaDatatype dtype);

	// RVA: 0x244A070 Offset: 0x2448A70 VA: 0x18244A070
	internal string get_TypeCodeString() { }

	// RVA: 0x2449920 Offset: 0x2448320 VA: 0x182449920
	internal string TypeCodeToString(XmlTypeCode typeCode) { }

	// RVA: 0x24491C0 Offset: 0x2447BC0 VA: 0x1824491C0
	internal static string ConcatenatedToString(object value) { }

	// RVA: 0x24498D0 Offset: 0x24482D0 VA: 0x1824498D0
	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x2449880 Offset: 0x2448280 VA: 0x182449880
	internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x2449830 Offset: 0x2448230 VA: 0x182449830
	internal static XmlSchemaDatatype FromXdrName(string name) { }

	// RVA: 0x24497D0 Offset: 0x24481D0 VA: 0x1824497D0
	internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x2449EB0 Offset: 0x24488B0 VA: 0x182449EB0
	internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
