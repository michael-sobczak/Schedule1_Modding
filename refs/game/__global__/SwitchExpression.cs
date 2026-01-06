public sealed class SwitchExpression : Expression // TypeDefIndex: 15205
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <SwitchValue>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<SwitchCase> <Cases>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Expression <DefaultBody>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly MethodInfo <Comparison>k__BackingField; // 0x28

	// Properties
	public Expression SwitchValue { get; }
	public ReadOnlyCollection<SwitchCase> Cases { get; }
	public Expression DefaultBody { get; }
	public MethodInfo Comparison { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Expression get_SwitchValue() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public ReadOnlyCollection<SwitchCase> get_Cases() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Expression get_DefaultBody() { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public MethodInfo get_Comparison() { }
}
