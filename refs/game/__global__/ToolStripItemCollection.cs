public class ToolStripItemCollection : ArrangedElementCollection, ICollection, IEnumerable, IList // TypeDefIndex: 5630
{
	// Fields
	private ToolStrip owner; // 0x18
	private bool internal_created; // 0x20

	// Properties
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }
	public override bool IsReadOnly { get; }
	public virtual ToolStripItem Item { get; }

	// Methods

	// RVA: 0x2234DC0 Offset: 0x22337C0 VA: 0x182234DC0
	internal void .ctor(ToolStrip owner, ToolStripItem[] value, bool internalcreated) { }

	// RVA: 0x2234AE0 Offset: 0x22334E0 VA: 0x182234AE0 Slot: 11
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0xB29930 Offset: 0xB28330 VA: 0x180B29930 Slot: 13
	private void System.Collections.IList.Clear() { }

	// RVA: 0x2234B60 Offset: 0x2233560 VA: 0x182234B60 Slot: 12
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x2234BE0 Offset: 0x22335E0 VA: 0x182234BE0 Slot: 16
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x2234C60 Offset: 0x2233660 VA: 0x182234C60 Slot: 17
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x2234D70 Offset: 0x2233770 VA: 0x182234D70 Slot: 15
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x2234CF0 Offset: 0x22336F0 VA: 0x182234CF0 Slot: 18
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x2234820 Offset: 0x2233220 VA: 0x182234820 Slot: 19
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xB1E190 Offset: 0xB1CB90 VA: 0x180B1E190 Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x2234D80 Offset: 0x2233780 VA: 0x182234D80 Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x2234EF0 Offset: 0x22338F0 VA: 0x182234EF0 Slot: 21
	public override bool get_IsReadOnly() { }

	// RVA: 0x2234F00 Offset: 0x2233900 VA: 0x182234F00 Slot: 23
	public virtual ToolStripItem get_Item(int index) { }

	// RVA: 0x2234180 Offset: 0x2232B80 VA: 0x182234180
	public ToolStripItem Add(string text) { }

	// RVA: 0x22341E0 Offset: 0x2232BE0 VA: 0x1822341E0
	public int Add(ToolStripItem value) { }

	// RVA: 0x22343E0 Offset: 0x2232DE0 VA: 0x1822343E0
	public ToolStripItem Add(string text, Image image, EventHandler onClick) { }

	// RVA: 0x2234440 Offset: 0x2232E40 VA: 0x182234440 Slot: 24
	public virtual void Clear() { }

	// RVA: 0x22344D0 Offset: 0x2232ED0 VA: 0x1822344D0
	public bool Contains(ToolStripItem value) { }

	// RVA: 0x22344E0 Offset: 0x2232EE0 VA: 0x1822344E0
	public void CopyTo(ToolStripItem[] array, int index) { }

	// RVA: 0x22344F0 Offset: 0x2232EF0 VA: 0x1822344F0
	public int IndexOf(ToolStripItem value) { }

	// RVA: 0x22345C0 Offset: 0x2232FC0 VA: 0x1822345C0
	public void Insert(int index, ToolStripItem value) { }

	// RVA: 0x2234980 Offset: 0x2233380 VA: 0x182234980
	public void Remove(ToolStripItem value) { }

	// RVA: 0x2234820 Offset: 0x2233220 VA: 0x182234820 Slot: 25
	public void RemoveAt(int index) { }

	// RVA: 0x2234110 Offset: 0x2232B10 VA: 0x182234110
	internal int AddNoOwnerOrLayout(ToolStripItem value) { }

	// RVA: 0x2234500 Offset: 0x2232F00 VA: 0x182234500
	internal void InsertNoOwnerOrLayout(int index, ToolStripItem value) { }

	// RVA: 0x2234910 Offset: 0x2233310 VA: 0x182234910
	internal void RemoveNoOwnerOrLayout(ToolStripItem value) { }
}
