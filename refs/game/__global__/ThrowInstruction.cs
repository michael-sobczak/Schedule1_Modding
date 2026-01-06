internal sealed class ThrowInstruction : Instruction // TypeDefIndex: 15266
{
	// Fields
	internal static readonly ThrowInstruction Throw; // 0x0
	internal static readonly ThrowInstruction VoidThrow; // 0x8
	internal static readonly ThrowInstruction Rethrow; // 0x10
	internal static readonly ThrowInstruction VoidRethrow; // 0x18
	private readonly bool _hasResult; // 0x10
	private readonly bool _rethrow; // 0x11

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x1FBD800 Offset: 0x1FBC200 VA: 0x181FBD800
	private void .ctor(bool hasResult, bool isRethrow) { }

	// RVA: 0x1FBD840 Offset: 0x1FBC240 VA: 0x181FBD840 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FA9230 Offset: 0x1FA7C30 VA: 0x181FA9230 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1FBD4E0 Offset: 0x1FBBEE0 VA: 0x181FBD4E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FBD600 Offset: 0x1FBC000 VA: 0x181FBD600
	private static Exception WrapThrownObject(object thrown) { }

	// RVA: 0x1FBD6B0 Offset: 0x1FBC0B0 VA: 0x181FBD6B0
	private static void .cctor() { }
}
