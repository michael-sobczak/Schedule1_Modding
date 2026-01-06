public class XmlSchemaObjectCollection : CollectionBase // TypeDefIndex: 8465
{
	// Fields
	private XmlSchemaObject parent; // 0x18

	// Properties
	public virtual XmlSchemaObject Item { get; set; }

	// Methods

	// RVA: 0x1A67BB0 Offset: 0x1A665B0 VA: 0x181A67BB0
	public void .ctor() { }

	// RVA: 0x244C730 Offset: 0x244B130 VA: 0x18244C730 Slot: 29
	public virtual XmlSchemaObject get_Item(int index) { }

	// RVA: 0x244C7E0 Offset: 0x244B1E0 VA: 0x18244C7E0 Slot: 30
	public virtual void set_Item(int index, XmlSchemaObject value) { }

	// RVA: 0x244C460 Offset: 0x244AE60 VA: 0x18244C460
	public XmlSchemaObjectEnumerator GetEnumerator() { }

	// RVA: 0x244C370 Offset: 0x244AD70 VA: 0x18244C370
	public int Add(XmlSchemaObject item) { }

	// RVA: 0x244C4E0 Offset: 0x244AEE0 VA: 0x18244C4E0
	public void Insert(int index, XmlSchemaObject item) { }

	// RVA: 0x244C660 Offset: 0x244B060 VA: 0x18244C660
	public void Remove(XmlSchemaObject item) { }

	// RVA: 0x244C590 Offset: 0x244AF90 VA: 0x18244C590 Slot: 21
	protected override void OnInsert(int index, object item) { }

	// RVA: 0x244C5F0 Offset: 0x244AFF0 VA: 0x18244C5F0 Slot: 20
	protected override void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x244C560 Offset: 0x244AF60 VA: 0x18244C560 Slot: 22
	protected override void OnClear() { }

	// RVA: 0x244C5C0 Offset: 0x244AFC0 VA: 0x18244C5C0 Slot: 23
	protected override void OnRemove(int index, object item) { }

	// RVA: 0x244C3E0 Offset: 0x244ADE0 VA: 0x18244C3E0
	internal XmlSchemaObjectCollection Clone() { }

	// RVA: 0x244C340 Offset: 0x244AD40 VA: 0x18244C340
	private void Add(XmlSchemaObjectCollection collToAdd) { }
}
