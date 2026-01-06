public class CaptureCollection : IList<Capture>, ICollection<Capture>, IEnumerable<Capture>, IEnumerable, IReadOnlyList<Capture>, IReadOnlyCollection<Capture>, IList, ICollection // TypeDefIndex: 9541
{
	// Fields
	private readonly Group _group; // 0x10
	private readonly int _capcount; // 0x18
	private Capture[] _captures; // 0x20

	// Properties
	public bool IsReadOnly { get; }
	public int Count { get; }
	public Capture Item { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Item { get; set; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90 Slot: 32
	public int get_Count() { }

	// RVA: 0x2612EE0 Offset: 0x26118E0 VA: 0x182612EE0 Slot: 18
	public Capture get_Item(int i) { }

	// RVA: 0x2612B60 Offset: 0x2611560 VA: 0x182612B60 Slot: 17
	public IEnumerator GetEnumerator() { }

	// RVA: 0x2612D20 Offset: 0x2611720 VA: 0x182612D20 Slot: 16
	private IEnumerator<Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator() { }

	// RVA: 0x2612910 Offset: 0x2611310 VA: 0x182612910
	private Capture GetCapture(int i) { }

	// RVA: 0x2612770 Offset: 0x2611170 VA: 0x182612770
	internal void ForceInitialized() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 34
	public bool get_IsSynchronized() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 33
	public object get_SyncRoot() { }

	// RVA: 0x26126B0 Offset: 0x26110B0 VA: 0x1826126B0 Slot: 31
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x26124E0 Offset: 0x2610EE0 VA: 0x1826124E0 Slot: 14
	public void CopyTo(Capture[] array, int arrayIndex) { }

	// RVA: 0x2612D90 Offset: 0x2611790 VA: 0x182612D90 Slot: 6
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(Capture item) { }

	// RVA: 0x2612E40 Offset: 0x2611840 VA: 0x182612E40 Slot: 7
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(int index, Capture item) { }

	// RVA: 0x2612E90 Offset: 0x2611890 VA: 0x182612E90 Slot: 8
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(int index) { }

	// RVA: 0x2612EE0 Offset: 0x26118E0 VA: 0x182612EE0 Slot: 4
	private Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(int index) { }

	// RVA: 0x2612EF0 Offset: 0x26118F0 VA: 0x182612EF0 Slot: 5
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(int index, Capture value) { }

	// RVA: 0x2612BD0 Offset: 0x26115D0 VA: 0x182612BD0 Slot: 11
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(Capture item) { }

	// RVA: 0x2612C20 Offset: 0x2611620 VA: 0x182612C20 Slot: 12
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear() { }

	// RVA: 0x2612C70 Offset: 0x2611670 VA: 0x182612C70 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(Capture item) { }

	// RVA: 0x2612CD0 Offset: 0x26116D0 VA: 0x182612CD0 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(Capture item) { }

	// RVA: 0x2612F40 Offset: 0x2611940 VA: 0x182612F40 Slot: 22
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x2612F90 Offset: 0x2611990 VA: 0x182612F90 Slot: 24
	private void System.Collections.IList.Clear() { }

	// RVA: 0x2612FE0 Offset: 0x26119E0 VA: 0x182612FE0 Slot: 23
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x2613120 Offset: 0x2611B20 VA: 0x182613120 Slot: 27
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x26131F0 Offset: 0x2611BF0 VA: 0x1826131F0 Slot: 28
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 26
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x2613290 Offset: 0x2611C90 VA: 0x182613290 Slot: 29
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x2613240 Offset: 0x2611C40 VA: 0x182613240 Slot: 30
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x2612EE0 Offset: 0x26118E0 VA: 0x182612EE0 Slot: 20
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x26132E0 Offset: 0x2611CE0 VA: 0x1826132E0 Slot: 21
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x2613330 Offset: 0x2611D30 VA: 0x182613330
	internal void .ctor() { }
}
