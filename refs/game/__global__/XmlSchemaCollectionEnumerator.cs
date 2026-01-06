public sealed class XmlSchemaCollectionEnumerator : IEnumerator // TypeDefIndex: 8420
{
	// Fields
	private IDictionaryEnumerator enumerator; // 0x10

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public XmlSchema Current { get; }
	internal XmlSchemaCollectionNode CurrentNode { get; }

	// Methods

	// RVA: 0x2445C40 Offset: 0x2444640 VA: 0x182445C40
	internal void .ctor(Hashtable collection) { }

	// RVA: 0x2445BE0 Offset: 0x24445E0 VA: 0x182445BE0 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x2445B90 Offset: 0x2444590 VA: 0x182445B90 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x2445B40 Offset: 0x2444540 VA: 0x182445B40
	public bool MoveNext() { }

	// RVA: 0x2445C30 Offset: 0x2444630 VA: 0x182445C30 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2445D20 Offset: 0x2444720 VA: 0x182445D20
	public XmlSchema get_Current() { }

	// RVA: 0x2445CA0 Offset: 0x24446A0 VA: 0x182445CA0
	internal XmlSchemaCollectionNode get_CurrentNode() { }
}
