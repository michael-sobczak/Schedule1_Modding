public class AttributeCollection : ICollection, IEnumerable // TypeDefIndex: 9683
{
	// Fields
	public static readonly AttributeCollection Empty; // 0x0
	private static Hashtable s_defaultAttributes; // 0x8
	private readonly Attribute[] _attributes; // 0x10
	private static readonly object s_internalSyncObject; // 0x10
	private AttributeCollection.AttributeEntry[] _foundAttributeTypes; // 0x18
	private int _index; // 0x20

	// Properties
	protected virtual Attribute[] Attributes { get; }
	public int Count { get; }
	public virtual Attribute Item { get; }
	public virtual Attribute Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }

	// Methods

	// RVA: 0x2641360 Offset: 0x263FD60 VA: 0x182641360
	public void .ctor(Attribute[] attributes) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 9
	protected virtual Attribute[] get_Attributes() { }

	// RVA: 0x26411A0 Offset: 0x263FBA0 VA: 0x1826411A0
	public int get_Count() { }

	// RVA: 0x2641460 Offset: 0x263FE60 VA: 0x182641460 Slot: 10
	public virtual Attribute get_Item(int index) { }

	// RVA: 0x26414A0 Offset: 0x263FEA0 VA: 0x1826414A0 Slot: 11
	public virtual Attribute get_Item(Type attributeType) { }

	// RVA: 0x2640B50 Offset: 0x263F550 VA: 0x182640B50
	public bool Contains(Attribute attribute) { }

	// RVA: 0x2640C60 Offset: 0x263F660 VA: 0x182640C60
	protected Attribute GetDefaultAttribute(Type attributeType) { }

	// RVA: 0x2641170 Offset: 0x263FB70 VA: 0x182641170
	public IEnumerator GetEnumerator() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x26411A0 Offset: 0x263FBA0 VA: 0x1826411A0 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x2641170 Offset: 0x263FB70 VA: 0x182641170 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2640BD0 Offset: 0x263F5D0 VA: 0x182640BD0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x26411D0 Offset: 0x263FBD0 VA: 0x1826411D0
	private static void .cctor() { }
}
