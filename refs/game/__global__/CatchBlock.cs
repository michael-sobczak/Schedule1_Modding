public sealed class CatchBlock // TypeDefIndex: 15127
{
	// Fields
	[CompilerGenerated]
	private readonly ParameterExpression <Variable>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Type <Test>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Expression <Filter>k__BackingField; // 0x28

	// Properties
	public ParameterExpression Variable { get; }
	public Type Test { get; }
	public Expression Body { get; }
	public Expression Filter { get; }

	// Methods

	// RVA: 0x1FA6930 Offset: 0x1FA5330 VA: 0x181FA6930
	internal void .ctor(Type test, ParameterExpression variable, Expression body, Expression filter) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public ParameterExpression get_Variable() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Type get_Test() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Expression get_Body() { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Expression get_Filter() { }

	// RVA: 0x1FA67B0 Offset: 0x1FA51B0 VA: 0x181FA67B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FA6890 Offset: 0x1FA5290 VA: 0x181FA6890
	public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body) { }
}
