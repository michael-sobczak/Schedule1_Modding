public class CGData : IDisposable // TypeDefIndex: 10611
{
	// Fields
	private bool disposed; // 0x10
	public string Name; // 0x18

	// Properties
	public virtual int Count { get; }

	// Methods

	// RVA: 0x4D8620 Offset: 0x4D7020 VA: 0x1804D8620 Slot: 5
	protected virtual bool Dispose(bool disposing) { }

	// RVA: 0x4D85B0 Offset: 0x4D6FB0 VA: 0x1804D85B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x4D8670 Offset: 0x4D7070 VA: 0x1804D8670 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public virtual int get_Count() { }

	// RVA: 0x4D76B0 Offset: 0x4D60B0 VA: 0x1804D76B0
	public static bool op_Implicit(CGData a) { }

	// RVA: -1 Offset: -1 Slot: 7
	public virtual T Clone<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B3E0 Offset: 0xE59DE0 VA: 0x180E5B3E0
	|-CGData.Clone<object>
	*/

	// RVA: 0x4D86E0 Offset: 0x4D70E0 VA: 0x1804D86E0
	protected int getGenericFIndex(SubArray<float> FMapArray, float fValue, out float frag) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
