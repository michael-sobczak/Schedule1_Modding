public abstract class XmlSchemaFacet : XmlSchemaAnnotated // TypeDefIndex: 8437
{
	// Fields
	private string value; // 0x50
	private bool isFixed; // 0x58
	private FacetType facetType; // 0x5C

	// Properties
	[Xml("value")]
	public string Value { get; set; }
	[Xml("fixed")]
	[DefaultValue(False)]
	public virtual bool IsFixed { get; set; }
	internal FacetType FacetType { get; set; }

	// Methods

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_Value() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_Value(string value) { }

	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0 Slot: 14
	public virtual bool get_IsFixed() { }

	// RVA: 0x244B7A0 Offset: 0x244A1A0 VA: 0x18244B7A0 Slot: 15
	public virtual void set_IsFixed(bool value) { }

	// RVA: 0x54CEC0 Offset: 0x54B8C0 VA: 0x18054CEC0
	internal FacetType get_FacetType() { }

	// RVA: 0x8E6930 Offset: 0x8E5330 VA: 0x1808E6930
	internal void set_FacetType(FacetType value) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
