internal class LongList // TypeDefIndex: 4438
{
	// Fields
	private long[] m_values; // 0x10
	private int m_count; // 0x18
	private int m_totalItems; // 0x1C
	private int m_currentItem; // 0x20

	// Properties
	internal int Count { get; }
	internal long Current { get; }

	// Methods

	// RVA: 0x1B497C0 Offset: 0x1B481C0 VA: 0x181B497C0
	internal void .ctor() { }

	// RVA: 0x1B49820 Offset: 0x1B48220 VA: 0x181B49820
	internal void .ctor(int startingSize) { }

	// RVA: 0x1B49590 Offset: 0x1B47F90 VA: 0x181B49590
	internal void Add(long value) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	internal int get_Count() { }

	// RVA: 0x1663D60 Offset: 0x1662760 VA: 0x181663D60
	internal void StartEnumeration() { }

	// RVA: 0x1B496F0 Offset: 0x1B480F0 VA: 0x181B496F0
	internal bool MoveNext() { }

	// RVA: 0x1B49890 Offset: 0x1B48290 VA: 0x181B49890
	internal long get_Current() { }

	// RVA: 0x1B49740 Offset: 0x1B48140 VA: 0x181B49740
	internal bool RemoveElement(long value) { }

	// RVA: 0x1B49660 Offset: 0x1B48060 VA: 0x181B49660
	private void EnlargeArray() { }
}
