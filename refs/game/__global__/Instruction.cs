internal abstract class Instruction // TypeDefIndex: 15362
{
	// Properties
	public virtual int ConsumedStack { get; }
	public virtual int ProducedStack { get; }
	public virtual int ConsumedContinuations { get; }
	public virtual int ProducedContinuations { get; }
	public int StackBalance { get; }
	public int ContinuationsBalance { get; }
	public abstract string InstructionName { get; }

	// Methods

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 4
	public virtual int get_ConsumedStack() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 5
	public virtual int get_ProducedStack() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public virtual int get_ConsumedContinuations() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 7
	public virtual int get_ProducedContinuations() { }

	// RVA: 0x1FCB280 Offset: 0x1FC9C80 VA: 0x181FCB280
	public int get_StackBalance() { }

	// RVA: 0x1FCB230 Offset: 0x1FC9C30 VA: 0x181FCB230
	public int get_ContinuationsBalance() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int Run(InterpretedFrame frame);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_InstructionName();

	// RVA: 0x1FCB1D0 Offset: 0x1FC9BD0 VA: 0x181FCB1D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C05F80 Offset: 0x1C04980 VA: 0x181C05F80 Slot: 10
	public virtual string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x1FCB1B0 Offset: 0x1FC9BB0 VA: 0x181FCB1B0
	protected static void NullCheck(object o) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
