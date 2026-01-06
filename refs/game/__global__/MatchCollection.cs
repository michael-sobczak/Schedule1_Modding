public class MatchCollection : IList<Match>, ICollection<Match>, IEnumerable<Match>, IEnumerable, IReadOnlyList<Match>, IReadOnlyCollection<Match>, IList, ICollection // TypeDefIndex: 9549
{
	// Fields
	private readonly Regex _regex; // 0x10
	private readonly List<Match> _matches; // 0x18
	private bool _done; // 0x20
	private readonly string _input; // 0x28
	private readonly int _beginning; // 0x30
	private readonly int _length; // 0x34
	private int _startat; // 0x38
	private int _prevlen; // 0x3C

	// Properties
	public bool IsReadOnly { get; }
	public int Count { get; }
	public virtual Match Item { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Item { get; set; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x2617290 Offset: 0x2615C90 VA: 0x182617290
	internal void .ctor(Regex regex, string input, int beginning, int length, int startat) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0x26173F0 Offset: 0x2615DF0 VA: 0x1826173F0 Slot: 32
	public int get_Count() { }

	// RVA: 0x2617450 Offset: 0x2615E50 VA: 0x182617450 Slot: 35
	public virtual Match get_Item(int i) { }

	// RVA: 0x26168B0 Offset: 0x26152B0 VA: 0x1826168B0 Slot: 17
	public IEnumerator GetEnumerator() { }

	// RVA: 0x2616C10 Offset: 0x2615610 VA: 0x182616C10 Slot: 16
	private IEnumerator<Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator() { }

	// RVA: 0x2616920 Offset: 0x2615320 VA: 0x182616920
	private Match GetMatch(int i) { }

	// RVA: 0x2616890 Offset: 0x2615290 VA: 0x182616890
	private void EnsureInitialized() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 34
	public bool get_IsSynchronized() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 33
	public object get_SyncRoot() { }

	// RVA: 0x26167B0 Offset: 0x26151B0 VA: 0x1826167B0 Slot: 31
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x2616730 Offset: 0x2615130 VA: 0x182616730 Slot: 14
	public void CopyTo(Match[] array, int arrayIndex) { }

	// RVA: 0x2616C80 Offset: 0x2615680 VA: 0x182616C80 Slot: 6
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(Match item) { }

	// RVA: 0x2616CF0 Offset: 0x26156F0 VA: 0x182616CF0 Slot: 7
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, Match item) { }

	// RVA: 0x2616D40 Offset: 0x2615740 VA: 0x182616D40 Slot: 8
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index) { }

	// RVA: 0x2616D90 Offset: 0x2615790 VA: 0x182616D90 Slot: 4
	private Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(int index) { }

	// RVA: 0x2616DB0 Offset: 0x26157B0 VA: 0x182616DB0 Slot: 5
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(int index, Match value) { }

	// RVA: 0x2616AB0 Offset: 0x26154B0 VA: 0x182616AB0 Slot: 11
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(Match item) { }

	// RVA: 0x2616B00 Offset: 0x2615500 VA: 0x182616B00 Slot: 12
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear() { }

	// RVA: 0x2616B50 Offset: 0x2615550 VA: 0x182616B50 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(Match item) { }

	// RVA: 0x2616BC0 Offset: 0x26155C0 VA: 0x182616BC0 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(Match item) { }

	// RVA: 0x2616E00 Offset: 0x2615800 VA: 0x182616E00 Slot: 22
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x2616E50 Offset: 0x2615850 VA: 0x182616E50 Slot: 24
	private void System.Collections.IList.Clear() { }

	// RVA: 0x2616EA0 Offset: 0x26158A0 VA: 0x182616EA0 Slot: 23
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x2616FE0 Offset: 0x26159E0 VA: 0x182616FE0 Slot: 27
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x2617120 Offset: 0x2615B20 VA: 0x182617120 Slot: 28
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 26
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x26171C0 Offset: 0x2615BC0 VA: 0x1826171C0 Slot: 29
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x2617170 Offset: 0x2615B70 VA: 0x182617170 Slot: 30
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x2616D90 Offset: 0x2615790 VA: 0x182616D90 Slot: 20
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x2617210 Offset: 0x2615C10 VA: 0x182617210 Slot: 21
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x2617260 Offset: 0x2615C60 VA: 0x182617260
	internal void .ctor() { }
}
