internal class ByRefNewInstruction : NewInstruction // TypeDefIndex: 15491
{
	// Fields
	private readonly ByRefUpdater[] _byrefArgs; // 0x20

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1FA5CD0 Offset: 0x1FA46D0 VA: 0x181FA5CD0
	internal void .ctor(ConstructorInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x1FE43B0 Offset: 0x1FE2DB0 VA: 0x181FE43B0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1FE41B0 Offset: 0x1FE2BB0 VA: 0x181FE41B0 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }
}
