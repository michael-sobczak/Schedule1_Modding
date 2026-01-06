internal sealed class IndexMethodByRefUpdater : ByRefUpdater // TypeDefIndex: 15424
{
	// Fields
	private readonly MethodInfo _indexer; // 0x18
	private readonly Nullable<LocalDefinition> _obj; // 0x20
	private readonly LocalDefinition[] _args; // 0x38

	// Methods

	// RVA: 0x1FED440 Offset: 0x1FEBE40 VA: 0x181FED440
	public void .ctor(Nullable<LocalDefinition> obj, LocalDefinition[] args, MethodInfo indexer, int argumentIndex) { }

	// RVA: 0x1FED1E0 Offset: 0x1FEBBE0 VA: 0x181FED1E0 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x1FED000 Offset: 0x1FEBA00 VA: 0x181FED000 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}
