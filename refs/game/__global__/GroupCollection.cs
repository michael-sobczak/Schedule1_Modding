public class GroupCollection : IList<Group>, ICollection<Group>, IEnumerable<Group>, IEnumerable, IReadOnlyList<Group>, IReadOnlyCollection<Group>, IList, ICollection // TypeDefIndex: 9545
{
	// Fields
	private readonly Match _match; // 0x10
	private readonly Hashtable _captureMap; // 0x18
	private Group[] _groups; // 0x20

	// Properties
	public bool IsReadOnly { get; }
	public int Count { get; }
	public Group Item { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Item { get; set; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	internal void .ctor(Match match, Hashtable caps) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0x2615C20 Offset: 0x2614620 VA: 0x182615C20 Slot: 32
	public int get_Count() { }

	// RVA: 0x26157A0 Offset: 0x26141A0 VA: 0x1826157A0 Slot: 18
	public Group get_Item(int groupnum) { }

	// RVA: 0x2614B10 Offset: 0x2613510 VA: 0x182614B10 Slot: 17
	public IEnumerator GetEnumerator() { }

	// RVA: 0x26155C0 Offset: 0x2613FC0 VA: 0x1826155C0 Slot: 16
	private IEnumerator<Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator() { }

	// RVA: 0x2614F80 Offset: 0x2613980 VA: 0x182614F80
	private Group GetGroup(int groupnum) { }

	// RVA: 0x2614B80 Offset: 0x2613580 VA: 0x182614B80
	private Group GetGroupImpl(int groupnum) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 34
	public bool get_IsSynchronized() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 33
	public object get_SyncRoot() { }

	// RVA: 0x2614840 Offset: 0x2613240 VA: 0x182614840 Slot: 31
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x2614920 Offset: 0x2613320 VA: 0x182614920 Slot: 14
	public void CopyTo(Group[] array, int arrayIndex) { }

	// RVA: 0x2615630 Offset: 0x2614030 VA: 0x182615630 Slot: 6
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(Group item) { }

	// RVA: 0x2615700 Offset: 0x2614100 VA: 0x182615700 Slot: 7
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, Group item) { }

	// RVA: 0x2615750 Offset: 0x2614150 VA: 0x182615750 Slot: 8
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index) { }

	// RVA: 0x26157A0 Offset: 0x26141A0 VA: 0x1826157A0 Slot: 4
	private Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index) { }

	// RVA: 0x26157B0 Offset: 0x26141B0 VA: 0x1826157B0 Slot: 5
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, Group value) { }

	// RVA: 0x2615470 Offset: 0x2613E70 VA: 0x182615470 Slot: 11
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(Group item) { }

	// RVA: 0x26154C0 Offset: 0x2613EC0 VA: 0x1826154C0 Slot: 12
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear() { }

	// RVA: 0x2615510 Offset: 0x2613F10 VA: 0x182615510 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(Group item) { }

	// RVA: 0x2615570 Offset: 0x2613F70 VA: 0x182615570 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(Group item) { }

	// RVA: 0x2615800 Offset: 0x2614200 VA: 0x182615800 Slot: 22
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x2615850 Offset: 0x2614250 VA: 0x182615850 Slot: 24
	private void System.Collections.IList.Clear() { }

	// RVA: 0x26158A0 Offset: 0x26142A0 VA: 0x1826158A0 Slot: 23
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x26159E0 Offset: 0x26143E0 VA: 0x1826159E0 Slot: 27
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x2615AB0 Offset: 0x26144B0 VA: 0x182615AB0 Slot: 28
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 26
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x2615B50 Offset: 0x2614550 VA: 0x182615B50 Slot: 29
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x2615B00 Offset: 0x2614500 VA: 0x182615B00 Slot: 30
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x26157A0 Offset: 0x26141A0 VA: 0x1826157A0 Slot: 20
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x2615BA0 Offset: 0x26145A0 VA: 0x182615BA0 Slot: 21
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x2615BF0 Offset: 0x26145F0 VA: 0x182615BF0
	internal void .ctor() { }
}
