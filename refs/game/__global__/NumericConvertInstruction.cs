internal abstract class NumericConvertInstruction : Instruction // TypeDefIndex: 15531
{
	// Fields
	internal readonly TypeCode _from; // 0x10
	internal readonly TypeCode _to; // 0x14
	private readonly bool _isLiftedToNull; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1FE68A0 Offset: 0x1FE52A0 VA: 0x181FE68A0
	protected void .ctor(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1FF8F90 Offset: 0x1FF7990 VA: 0x181FF8F90 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract object Convert(object obj);

	// RVA: 0x1FF9230 Offset: 0x1FF7C30 VA: 0x181FF9230 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FF9090 Offset: 0x1FF7A90 VA: 0x181FF9090 Slot: 3
	public override string ToString() { }
}
