internal abstract class ByRefUpdater // TypeDefIndex: 15419
{
	// Fields
	public readonly int ArgumentIndex; // 0x10

	// Methods

	// RVA: 0x445F80 Offset: 0x444980 VA: 0x180445F80
	public void .ctor(int argumentIndex) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Update(InterpretedFrame frame, object value);

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}
