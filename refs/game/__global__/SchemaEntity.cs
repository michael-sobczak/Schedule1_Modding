internal sealed class SchemaEntity : IDtdEntityInfo // TypeDefIndex: 8379
{
	// Fields
	private XmlQualifiedName qname; // 0x10
	private string url; // 0x18
	private string pubid; // 0x20
	private string text; // 0x28
	private XmlQualifiedName ndata; // 0x30
	private int lineNumber; // 0x38
	private int linePosition; // 0x3C
	private bool isParameter; // 0x40
	private bool isExternal; // 0x41
	private bool parsingInProgress; // 0x42
	private bool isDeclaredInExternal; // 0x43
	private string baseURI; // 0x48
	private string declaredURI; // 0x50

	// Properties
	private string System.Xml.IDtdEntityInfo.Name { get; }
	private bool System.Xml.IDtdEntityInfo.IsExternal { get; }
	private bool System.Xml.IDtdEntityInfo.IsDeclaredInExternal { get; }
	private bool System.Xml.IDtdEntityInfo.IsUnparsedEntity { get; }
	private bool System.Xml.IDtdEntityInfo.IsParameterEntity { get; }
	private string System.Xml.IDtdEntityInfo.BaseUriString { get; }
	private string System.Xml.IDtdEntityInfo.DeclaredUriString { get; }
	private string System.Xml.IDtdEntityInfo.SystemId { get; }
	private string System.Xml.IDtdEntityInfo.PublicId { get; }
	private string System.Xml.IDtdEntityInfo.Text { get; }
	private int System.Xml.IDtdEntityInfo.LineNumber { get; }
	private int System.Xml.IDtdEntityInfo.LinePosition { get; }
	internal XmlQualifiedName Name { get; }
	internal string Url { get; set; }
	internal string Pubid { get; set; }
	internal bool IsExternal { get; set; }
	internal bool DeclaredInExternal { get; set; }
	internal XmlQualifiedName NData { get; set; }
	internal string Text { get; set; }
	internal int Line { get; set; }
	internal int Pos { get; set; }
	internal string BaseURI { get; set; }
	internal bool ParsingInProgress { get; set; }
	internal string DeclaredURI { get; set; }

	// Methods

	// RVA: 0x242D0B0 Offset: 0x242BAB0 VA: 0x18242D0B0
	internal void .ctor(XmlQualifiedName qname, bool isParameter) { }

	// RVA: 0x13C7AA0 Offset: 0x13C64A0 VA: 0x1813C7AA0 Slot: 4
	private string System.Xml.IDtdEntityInfo.get_Name() { }

	// RVA: 0x1C12200 Offset: 0x1C10C00 VA: 0x181C12200 Slot: 5
	private bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	// RVA: 0x1C121F0 Offset: 0x1C10BF0 VA: 0x181C121F0 Slot: 6
	private bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x242D080 Offset: 0x242BA80 VA: 0x18242D080 Slot: 7
	private bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0 Slot: 8
	private bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	// RVA: 0x242CFE0 Offset: 0x242B9E0 VA: 0x18242CFE0 Slot: 9
	private string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	// RVA: 0x242D030 Offset: 0x242BA30 VA: 0x18242D030 Slot: 10
	private string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 11
	private string System.Xml.IDtdEntityInfo.get_SystemId() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 12
	private string System.Xml.IDtdEntityInfo.get_PublicId() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 13
	private string System.Xml.IDtdEntityInfo.get_Text() { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50 Slot: 14
	private int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0 Slot: 15
	private int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	// RVA: 0x242CF10 Offset: 0x242B910 VA: 0x18242CF10
	internal static bool IsPredefinedEntity(string n) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal string get_Url() { }

	// RVA: 0x242D230 Offset: 0x242BC30 VA: 0x18242D230
	internal void set_Url(string value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal string get_Pubid() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	internal void set_Pubid(string value) { }

	// RVA: 0x1C12200 Offset: 0x1C10C00 VA: 0x181C12200
	internal bool get_IsExternal() { }

	// RVA: 0x242D200 Offset: 0x242BC00 VA: 0x18242D200
	internal void set_IsExternal(bool value) { }

	// RVA: 0x1C121F0 Offset: 0x1C10BF0 VA: 0x181C121F0
	internal bool get_DeclaredInExternal() { }

	// RVA: 0x242D1F0 Offset: 0x242BBF0 VA: 0x18242D1F0
	internal void set_DeclaredInExternal(bool value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal XmlQualifiedName get_NData() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	internal void set_NData(XmlQualifiedName value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal string get_Text() { }

	// RVA: 0x242D210 Offset: 0x242BC10 VA: 0x18242D210
	internal void set_Text(string value) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	internal int get_Line() { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	internal void set_Line(int value) { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	internal int get_Pos() { }

	// RVA: 0xC21CD0 Offset: 0xC206D0 VA: 0x180C21CD0
	internal void set_Pos(int value) { }

	// RVA: 0x242D150 Offset: 0x242BB50 VA: 0x18242D150
	internal string get_BaseURI() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	internal void set_BaseURI(string value) { }

	// RVA: 0xC31540 Offset: 0xC2FF40 VA: 0x180C31540
	internal bool get_ParsingInProgress() { }

	// RVA: 0xC31570 Offset: 0xC2FF70 VA: 0x180C31570
	internal void set_ParsingInProgress(bool value) { }

	// RVA: 0x242D1A0 Offset: 0x242BBA0 VA: 0x18242D1A0
	internal string get_DeclaredURI() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	internal void set_DeclaredURI(string value) { }
}
