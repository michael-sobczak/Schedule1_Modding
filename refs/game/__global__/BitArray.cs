public sealed class BitArray : ICollection, IEnumerable, ICloneable // TypeDefIndex: 4924
{
	// Fields
	private int[] m_array; // 0x10
	private int m_length; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public bool Item { get; set; }
	public int Length { get; set; }
	public int Count { get; }
	public object SyncRoot { get; }
	public bool IsSynchronized { get; }

	// Methods

	// RVA: 0x1BF5420 Offset: 0x1BF3E20 VA: 0x181BF5420
	public void .ctor(int length) { }

	// RVA: 0x1BF52A0 Offset: 0x1BF3CA0 VA: 0x181BF52A0
	public void .ctor(int length, bool defaultValue) { }

	// RVA: 0x1BF55A0 Offset: 0x1BF3FA0 VA: 0x181BF55A0
	public void .ctor(BitArray bits) { }

	// RVA: 0x1BF56A0 Offset: 0x1BF40A0 VA: 0x181BF56A0
	public bool get_Item(int index) { }

	// RVA: 0x1BF5720 Offset: 0x1BF4120 VA: 0x181BF5720
	public void set_Item(int index, bool value) { }

	// RVA: 0x1BF4FF0 Offset: 0x1BF39F0 VA: 0x181BF4FF0
	public bool Get(int index) { }

	// RVA: 0x1BF5170 Offset: 0x1BF3B70 VA: 0x181BF5170
	public void Set(int index, bool value) { }

	// RVA: 0x1BF50F0 Offset: 0x1BF3AF0 VA: 0x181BF50F0
	public void SetAll(bool value) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_Length() { }

	// RVA: 0x1BF5850 Offset: 0x1BF4250 VA: 0x181BF5850
	public void set_Length(int value) { }

	// RVA: 0x1BF4950 Offset: 0x1BF3350 VA: 0x181BF4950 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90 Slot: 5
	public int get_Count() { }

	// RVA: 0x1BF56B0 Offset: 0x1BF40B0 VA: 0x181BF56B0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x1BF4820 Offset: 0x1BF3220 VA: 0x181BF4820 Slot: 9
	public object Clone() { }

	// RVA: 0x1BF4F70 Offset: 0x1BF3970 VA: 0x181BF4F70 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1BF4F50 Offset: 0x1BF3950 VA: 0x181BF4F50
	private static int GetArrayLength(int n, int div) { }
}
