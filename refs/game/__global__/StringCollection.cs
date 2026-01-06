public class StringCollection : IList, ICollection, IEnumerable // TypeDefIndex: 9858
{
	// Fields
	private readonly ArrayList data; // 0x10

	// Properties
	public string Item { get; set; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x26B4E70 Offset: 0x26B3870 VA: 0x1826B4E70
	public string get_Item(int index) { }

	// RVA: 0x21C3E20 Offset: 0x21C2820 VA: 0x1821C3E20
	public void set_Item(int index, string value) { }

	// RVA: 0x1BF73E0 Offset: 0x1BF5DE0 VA: 0x181BF73E0 Slot: 16
	public int get_Count() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x226C4A0 Offset: 0x226AEA0 VA: 0x18226C4A0
	public int Add(string value) { }

	// RVA: 0x20C7760 Offset: 0x20C6160 VA: 0x1820C7760 Slot: 8
	public void Clear() { }

	// RVA: 0x1BF6D30 Offset: 0x1BF5730 VA: 0x181BF6D30
	public bool Contains(string value) { }

	// RVA: 0x1BF6B90 Offset: 0x1BF5590 VA: 0x181BF6B90
	public void CopyTo(string[] array, int index) { }

	// RVA: 0x26B4B30 Offset: 0x26B3530 VA: 0x1826B4B30
	public StringEnumerator GetEnumerator() { }

	// RVA: 0x1BF6D60 Offset: 0x1BF5760 VA: 0x181BF6D60
	public int IndexOf(string value) { }

	// RVA: 0x22B0F30 Offset: 0x22AF930 VA: 0x1822B0F30
	public void Insert(int index, string value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x22B0F60 Offset: 0x22AF960 VA: 0x1822B0F60
	public void Remove(string value) { }

	// RVA: 0x22B1040 Offset: 0x22AFA40 VA: 0x1822B1040 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x1BF6BF0 Offset: 0x1BF55F0 VA: 0x181BF6BF0 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x26B4E70 Offset: 0x26B3870 VA: 0x1826B4E70 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x26B4EF0 Offset: 0x26B38F0 VA: 0x1826B4EF0 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x26B4BE0 Offset: 0x26B35E0 VA: 0x1826B4BE0 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x26B4C60 Offset: 0x26B3660 VA: 0x1826B4C60 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x26B4CE0 Offset: 0x26B36E0 VA: 0x1826B4CE0 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x26B4D60 Offset: 0x26B3760 VA: 0x1826B4D60 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x26B4DF0 Offset: 0x26B37F0 VA: 0x1826B4DF0 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1BF6B90 Offset: 0x1BF5590 VA: 0x181BF6B90 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1A67B80 Offset: 0x1A66580 VA: 0x181A67B80 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x26B4F80 Offset: 0x26B3980 VA: 0x1826B4F80
	public void .ctor() { }
}
