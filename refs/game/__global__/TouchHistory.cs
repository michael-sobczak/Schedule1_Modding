public struct TouchHistory : IReadOnlyList<Touch>, IEnumerable<Touch>, IEnumerable, IReadOnlyCollection<Touch> // TypeDefIndex: 7577
{
	// Fields
	private readonly InputStateHistory<TouchState> m_History; // 0x0
	private readonly Finger m_Finger; // 0x8
	private readonly int m_Count; // 0x10
	private readonly int m_StartIndex; // 0x14
	private readonly uint m_Version; // 0x18

	// Properties
	public int Count { get; }
	public Touch Item { get; }

	// Methods

	// RVA: 0x2866290 Offset: 0x2864C90 VA: 0x182866290
	internal void .ctor(Finger finger, InputStateHistory<TouchState> history, int startIndex = -1, int count = -1) { }

	// RVA: 0x2866200 Offset: 0x2864C00 VA: 0x182866200 Slot: 6
	public IEnumerator<Touch> GetEnumerator() { }

	// RVA: 0x2866280 Offset: 0x2864C80 VA: 0x182866280 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 5
	public int get_Count() { }

	// RVA: 0x2866310 Offset: 0x2864D10 VA: 0x182866310 Slot: 4
	public Touch get_Item(int index) { }

	// RVA: 0x2866140 Offset: 0x2864B40 VA: 0x182866140
	internal void CheckValid() { }
}
