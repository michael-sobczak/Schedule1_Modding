internal sealed class XDRSchema : XMLSchema // TypeDefIndex: 12986
{
	// Fields
	internal string _schemaName; // 0x10
	internal string _schemaUri; // 0x18
	internal XmlElement _schemaRoot; // 0x20
	internal DataSet _ds; // 0x28
	private static readonly char[] s_colonArray; // 0x0
	private static XDRSchema.NameType[] s_mapNameTypeXdr; // 0x8
	private static XDRSchema.NameType s_enumerationNameType; // 0x10

	// Methods

	// RVA: 0x20AC3D0 Offset: 0x20AADD0 VA: 0x1820AC3D0
	internal void .ctor(DataSet ds, bool fInline) { }

	// RVA: 0x20AAC70 Offset: 0x20A9670 VA: 0x1820AAC70
	internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	// RVA: 0x20A8770 Offset: 0x20A7170 VA: 0x1820A8770
	internal XmlElement FindTypeNode(XmlElement node) { }

	// RVA: 0x20AA7B0 Offset: 0x20A91B0 VA: 0x1820AA7B0
	internal bool IsTextOnlyContent(XmlElement node) { }

	// RVA: 0x20AA970 Offset: 0x20A9370 VA: 0x1820AA970
	internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	// RVA: 0x20A9BB0 Offset: 0x20A85B0 VA: 0x1820A9BB0
	internal DataTable HandleTable(XmlElement node) { }

	// RVA: 0x20A8690 Offset: 0x20A7090 VA: 0x1820A8690
	private static XDRSchema.NameType FindNameType(string name) { }

	// RVA: 0x20AAEF0 Offset: 0x20A98F0 VA: 0x1820AAEF0
	private Type ParseDataType(string dt, string dtValues) { }

	// RVA: 0x20A8B20 Offset: 0x20A7520 VA: 0x1820A8B20
	internal string GetInstanceName(XmlElement node) { }

	// RVA: 0x20A90A0 Offset: 0x20A7AA0 VA: 0x1820A90A0
	internal void HandleColumn(XmlElement node, DataTable table) { }

	// RVA: 0x20A9070 Offset: 0x20A7A70 VA: 0x1820A9070
	internal void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0x20A8CB0 Offset: 0x20A76B0 VA: 0x1820A8CB0
	internal void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0x20A9D70 Offset: 0x20A8770 VA: 0x1820A9D70
	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	// RVA: 0x20AA1F0 Offset: 0x20A8BF0 VA: 0x1820AA1F0
	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	// RVA: 0x20A9F90 Offset: 0x20A8990 VA: 0x1820A9F90
	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	// RVA: 0x20AB040 Offset: 0x20A9A40 VA: 0x1820AB040
	private static void .cctor() { }
}
