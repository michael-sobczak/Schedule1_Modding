internal sealed class FieldByRefUpdater : ByRefUpdater // TypeDefIndex: 15422
{
	// Fields
	private readonly Nullable<LocalDefinition> _object; // 0x18
	private readonly FieldInfo _field; // 0x30

	// Methods

	// RVA: 0x1FEC9A0 Offset: 0x1FEB3A0 VA: 0x181FEC9A0
	public void .ctor(Nullable<LocalDefinition> obj, FieldInfo field, int argumentIndex) { }

	// RVA: 0x1FEC900 Offset: 0x1FEB300 VA: 0x181FEC900 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x1FEC860 Offset: 0x1FEB260 VA: 0x181FEC860 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}
