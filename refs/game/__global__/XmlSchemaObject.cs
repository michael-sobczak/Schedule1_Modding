public abstract class XmlSchemaObject // TypeDefIndex: 8464
{
	// Fields
	private int lineNum; // 0x10
	private int linePos; // 0x14
	private string sourceUri; // 0x18
	private XmlSerializerNamespaces namespaces; // 0x20
	private XmlSchemaObject parent; // 0x28
	private bool isProcessing; // 0x30

	// Properties
	[XmlIgnore]
	public int LineNumber { get; set; }
	[XmlIgnore]
	public int LinePosition { get; set; }
	[XmlIgnore]
	public string SourceUri { get; set; }
	[XmlIgnore]
	public XmlSchemaObject Parent { get; set; }
	[XmlNamespaceDeclarations]
	public XmlSerializerNamespaces Namespaces { get; set; }
	[XmlIgnore]
	internal virtual string IdAttribute { get; set; }
	[XmlIgnore]
	internal virtual string NameAttribute { get; set; }
	[XmlIgnore]
	internal bool IsProcessing { get; set; }

	// Methods

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_LineNumber() { }

	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_LineNumber(int value) { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_LinePosition() { }

	// RVA: 0x65C890 Offset: 0x65B290 VA: 0x18065C890
	public void set_LinePosition(int value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_SourceUri() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_SourceUri(string value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public XmlSchemaObject get_Parent() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_Parent(XmlSchemaObject value) { }

	// RVA: 0x244C8E0 Offset: 0x244B2E0 VA: 0x18244C8E0
	public XmlSerializerNamespaces get_Namespaces() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Namespaces(XmlSerializerNamespaces value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	internal virtual void OnAdd(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	internal virtual void OnRemove(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	internal virtual void OnClear(XmlSchemaObjectCollection container) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 7
	internal virtual string get_IdAttribute() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	internal virtual void set_IdAttribute(string value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 11
	internal virtual string get_NameAttribute() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	internal virtual void set_NameAttribute(string value) { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	internal bool get_IsProcessing() { }

	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	internal void set_IsProcessing(bool value) { }

	// RVA: 0x244C860 Offset: 0x244B260 VA: 0x18244C860 Slot: 13
	internal virtual XmlSchemaObject Clone() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
