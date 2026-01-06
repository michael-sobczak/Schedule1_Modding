internal sealed class StringSwitchInstruction : Instruction // TypeDefIndex: 15268
{
	// Fields
	private readonly Dictionary<string, int> _cases; // 0x10
	private readonly StrongBox<int> _nullCase; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x4870B0 Offset: 0x485AB0 VA: 0x1804870B0
	internal void .ctor(Dictionary<string, int> cases, StrongBox<int> nullCase) { }

	// RVA: 0x1FBB510 Offset: 0x1FB9F10 VA: 0x181FBB510 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1FBB440 Offset: 0x1FB9E40 VA: 0x181FBB440 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
