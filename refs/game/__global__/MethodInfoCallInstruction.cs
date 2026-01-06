internal class MethodInfoCallInstruction : CallInstruction // TypeDefIndex: 15247
{
	// Fields
	protected readonly MethodInfo _target; // 0x10
	protected readonly int _argumentCount; // 0x18

	// Properties
	public override int ArgumentCount { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90 Slot: 11
	public override int get_ArgumentCount() { }

	// RVA: 0x1B60630 Offset: 0x1B5F030 VA: 0x181B60630
	internal void .ctor(MethodInfo target, int argumentCount) { }

	// RVA: 0x1FB9950 Offset: 0x1FB8350 VA: 0x181FB9950 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1FB9600 Offset: 0x1FB8000 VA: 0x181FB9600 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1FB9460 Offset: 0x1FB7E60 VA: 0x181FB9460
	protected object[] GetArgs(InterpretedFrame frame, int first, int skip) { }

	// RVA: 0x1FB98D0 Offset: 0x1FB82D0 VA: 0x181FB98D0 Slot: 3
	public override string ToString() { }
}
