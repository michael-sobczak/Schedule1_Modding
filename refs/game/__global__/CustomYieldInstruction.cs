public abstract class CustomYieldInstruction : IEnumerator // TypeDefIndex: 11817
{
	// Properties
	public abstract bool keepWaiting { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_keepWaiting();

	// RVA: 0x1102840 Offset: 0x1101240 VA: 0x181102840 Slot: 5
	public object get_Current() { }

	// RVA: 0x493100 Offset: 0x491B00 VA: 0x180493100 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public virtual void Reset() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
