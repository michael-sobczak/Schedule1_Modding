public class TreeNodeCollection : ICollection, IEnumerable, IList // TypeDefIndex: 5664
{
	// Fields
	private static readonly int OrigSize; // 0x0
	private TreeNode owner; // 0x10
	private int count; // 0x18
	private TreeNode[] nodes; // 0x20

	// Properties
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }
	[Browsable(False)]
	public int Count { get; }
	public bool IsReadOnly { get; }
	public virtual TreeNode Item { get; set; }

	// Methods

	// RVA: 0x225B4C0 Offset: 0x2259EC0 VA: 0x18225B4C0
	internal void .ctor(TreeNode owner) { }

	// RVA: 0x225B480 Offset: 0x2259E80 VA: 0x18225B480
	private static void .cctor() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 15
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xD53E50 Offset: 0xD52850 VA: 0x180D53E50 Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x225B360 Offset: 0x2259D60 VA: 0x18225B360 Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x225AFC0 Offset: 0x22599C0 VA: 0x18225AFC0 Slot: 11
	private int System.Collections.IList.Add(object node) { }

	// RVA: 0x225B050 Offset: 0x2259A50 VA: 0x18225B050 Slot: 12
	private bool System.Collections.IList.Contains(object node) { }

	// RVA: 0x225B110 Offset: 0x2259B10 VA: 0x18225B110 Slot: 16
	private int System.Collections.IList.IndexOf(object node) { }

	// RVA: 0x225B1B0 Offset: 0x2259BB0 VA: 0x18225B1B0 Slot: 17
	private void System.Collections.IList.Insert(int index, object node) { }

	// RVA: 0x225B250 Offset: 0x2259C50 VA: 0x18225B250 Slot: 18
	private void System.Collections.IList.Remove(object node) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90 Slot: 5
	public int get_Count() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 14
	public bool get_IsReadOnly() { }

	// RVA: 0x225B560 Offset: 0x2259F60 VA: 0x18225B560 Slot: 20
	public virtual TreeNode get_Item(int index) { }

	// RVA: 0x225B5F0 Offset: 0x2259FF0 VA: 0x18225B5F0 Slot: 21
	public virtual void set_Item(int index, TreeNode value) { }

	// RVA: 0x225A1A0 Offset: 0x2258BA0 VA: 0x18225A1A0 Slot: 22
	public virtual int Add(TreeNode node) { }

	// RVA: 0x225A360 Offset: 0x2258D60 VA: 0x18225A360 Slot: 23
	public virtual void Clear() { }

	// RVA: 0x225A4E0 Offset: 0x2258EE0 VA: 0x18225A4E0
	public bool Contains(TreeNode node) { }

	// RVA: 0x225A540 Offset: 0x2258F40 VA: 0x18225A540 Slot: 4
	public void CopyTo(Array dest, int index) { }

	// RVA: 0x225A570 Offset: 0x2258F70 VA: 0x18225A570 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x225A700 Offset: 0x2259100 VA: 0x18225A700
	public int IndexOf(TreeNode node) { }

	// RVA: 0x225A750 Offset: 0x2259150 VA: 0x18225A750 Slot: 24
	public virtual void Insert(int index, TreeNode node) { }

	// RVA: 0x225AC50 Offset: 0x2259650 VA: 0x18225AC50
	public void Remove(TreeNode node) { }

	// RVA: 0x225AC40 Offset: 0x2259640 VA: 0x18225AC40 Slot: 25
	public virtual void RemoveAt(int index) { }

	// RVA: 0x225A830 Offset: 0x2259230 VA: 0x18225A830
	private void RemoveAt(int index, bool update) { }

	// RVA: 0x225A5E0 Offset: 0x2258FE0 VA: 0x18225A5E0
	private TreeNode GetPrevNode(TreeNode node) { }

	// RVA: 0x225AD00 Offset: 0x2259700 VA: 0x18225AD00
	private void SetupNode(TreeNode node) { }

	// RVA: 0x2259EE0 Offset: 0x22588E0 VA: 0x182259EE0
	private int AddSorted(TreeNode node) { }

	// RVA: 0x225A670 Offset: 0x2259070 VA: 0x18225A670
	private void Grow() { }

	// RVA: 0x225AEF0 Offset: 0x22598F0 VA: 0x18225AEF0
	private void Shrink() { }
}
