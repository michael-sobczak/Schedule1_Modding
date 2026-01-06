internal sealed class LoadFieldInstruction : FieldInstruction // TypeDefIndex: 15326
{
	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(FieldInfo field) { }

	// RVA: 0x1FE2630 Offset: 0x1FE1030 VA: 0x181FE2630 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FE2540 Offset: 0x1FE0F40 VA: 0x181FE2540 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
