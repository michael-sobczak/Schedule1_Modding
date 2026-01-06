internal class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction // TypeDefIndex: 15248
{
	// Fields
	private readonly ByRefUpdater[] _byrefArgs; // 0x20

	// Properties
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1FA5CD0 Offset: 0x1FA46D0 VA: 0x181FA5CD0
	internal void .ctor(MethodInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x1FA5D30 Offset: 0x1FA4730 VA: 0x181FA5D30 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FA5740 Offset: 0x1FA4140 VA: 0x181FA5740 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }
}
