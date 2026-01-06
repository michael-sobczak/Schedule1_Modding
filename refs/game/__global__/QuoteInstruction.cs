internal sealed class QuoteInstruction : Instruction // TypeDefIndex: 15592
{
	// Fields
	private readonly Expression _operand; // 0x10
	private readonly Dictionary<ParameterExpression, LocalVariable> _hoistedVariables; // 0x18

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x4870B0 Offset: 0x485AB0 VA: 0x1804870B0
	public void .ctor(Expression operand, Dictionary<ParameterExpression, LocalVariable> hoistedVariables) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FFA7F0 Offset: 0x1FF91F0 VA: 0x181FFA7F0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FFA6B0 Offset: 0x1FF90B0 VA: 0x181FFA6B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
