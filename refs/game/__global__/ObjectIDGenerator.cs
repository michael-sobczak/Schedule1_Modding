public class ObjectIDGenerator // TypeDefIndex: 4433
{
	// Fields
	internal int m_currentCount; // 0x10
	internal int m_currentSize; // 0x14
	internal long[] m_ids; // 0x18
	internal object[] m_objs; // 0x20
	private static readonly int[] sizes; // 0x0

	// Methods

	// RVA: 0x1B3A590 Offset: 0x1B38F90 VA: 0x181B3A590
	public void .ctor() { }

	// RVA: 0x1B39EA0 Offset: 0x1B388A0 VA: 0x181B39EA0
	private int FindElement(object obj, out bool found) { }

	// RVA: 0x1B39F70 Offset: 0x1B38970 VA: 0x181B39F70 Slot: 4
	public virtual long GetId(object obj, out bool firstTime) { }

	// RVA: 0x1B3A110 Offset: 0x1B38B10 VA: 0x181B3A110 Slot: 5
	public virtual long HasId(object obj, out bool firstTime) { }

	// RVA: 0x1B3A1F0 Offset: 0x1B38BF0 VA: 0x181B3A1F0
	private void Rehash() { }

	// RVA: 0x1B3A500 Offset: 0x1B38F00 VA: 0x181B3A500
	private static void .cctor() { }
}
