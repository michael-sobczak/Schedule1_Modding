public sealed class XmlSchemaCollection : ICollection, IEnumerable // TypeDefIndex: 8418
{
	// Fields
	private Hashtable collection; // 0x10
	private XmlNameTable nameTable; // 0x18
	private SchemaNames schemaNames; // 0x20
	private ReaderWriterLock wLock; // 0x28
	private int timeout; // 0x30
	private bool isThreadSafe; // 0x34
	private ValidationEventHandler validationEventHandler; // 0x38
	private XmlResolver xmlResolver; // 0x40

	// Properties
	public int Count { get; }
	public XmlNameTable NameTable { get; }
	internal XmlResolver XmlResolver { set; }
	public XmlSchema Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	internal ValidationEventHandler EventHandler { get; set; }

	// Methods

	// RVA: 0x24466B0 Offset: 0x24450B0 VA: 0x1824466B0
	public void .ctor(XmlNameTable nametable) { }

	// RVA: 0x21C3E50 Offset: 0x21C2850 VA: 0x1821C3E50
	public int get_Count() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x24467F0 Offset: 0x24451F0 VA: 0x1824467F0
	public XmlSchema get_Item(string ns) { }

	// RVA: 0x2446620 Offset: 0x2445020 VA: 0x182446620 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2446210 Offset: 0x2444C10 VA: 0x182446210
	public XmlSchemaCollectionEnumerator GetEnumerator() { }

	// RVA: 0x2446410 Offset: 0x2444E10 VA: 0x182446410 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x21C3E50 Offset: 0x21C2850 VA: 0x1821C3E50 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x24462A0 Offset: 0x2444CA0 VA: 0x1824462A0
	internal SchemaInfo GetSchemaInfo(string ns) { }

	// RVA: 0x2446350 Offset: 0x2444D50 VA: 0x182446350
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x2445EF0 Offset: 0x24448F0 VA: 0x182445EF0
	internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	// RVA: 0x2446080 Offset: 0x2444A80 VA: 0x182446080
	private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	// RVA: 0x2445DB0 Offset: 0x24447B0 VA: 0x182445DB0
	private void Add(string ns, XmlSchemaCollectionNode node) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	internal ValidationEventHandler get_EventHandler() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	internal void set_EventHandler(ValidationEventHandler value) { }
}
