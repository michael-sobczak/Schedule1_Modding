public class XmlSchemaObjectTable // TypeDefIndex: 8472
{
	// Fields
	private Dictionary<XmlQualifiedName, XmlSchemaObject> table; // 0x10
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x18

	// Properties
	public int Count { get; }
	public XmlSchemaObject Item { get; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x2455B70 Offset: 0x2454570 VA: 0x182455B70
	internal void .ctor() { }

	// RVA: 0x24554A0 Offset: 0x2453EA0 VA: 0x1824554A0
	internal void Add(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x2455830 Offset: 0x2454230 VA: 0x182455830
	internal void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x2455A40 Offset: 0x2454440 VA: 0x182455A40
	internal void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x24555D0 Offset: 0x2453FD0 VA: 0x1824555D0
	internal void Clear() { }

	// RVA: 0x2455980 Offset: 0x2454380 VA: 0x182455980
	internal void Remove(XmlQualifiedName name) { }

	// RVA: 0x24556C0 Offset: 0x24540C0 VA: 0x1824556C0
	private int FindIndexByValue(XmlSchemaObject xso) { }

	// RVA: 0x2455C30 Offset: 0x2454630 VA: 0x182455C30
	public int get_Count() { }

	// RVA: 0x2455660 Offset: 0x2454060 VA: 0x182455660
	public bool Contains(XmlQualifiedName name) { }

	// RVA: 0x2455C80 Offset: 0x2454680 VA: 0x182455C80
	public XmlSchemaObject get_Item(XmlQualifiedName name) { }

	// RVA: 0x2455D00 Offset: 0x2454700 VA: 0x182455D00
	public ICollection get_Values() { }

	// RVA: 0x2455780 Offset: 0x2454180 VA: 0x182455780
	public IDictionaryEnumerator GetEnumerator() { }
}
