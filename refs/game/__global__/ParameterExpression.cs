public class ParameterExpression : Expression // TypeDefIndex: 15196
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10

	// Properties
	public override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public string Name { get; }
	public bool IsByRef { get; }

	// Methods

	// RVA: 0x1FBA9E0 Offset: 0x1FB93E0 VA: 0x181FBA9E0
	internal void .ctor(string name) { }

	// RVA: 0x1FBA260 Offset: 0x1FB8C60 VA: 0x181FBA260
	internal static ParameterExpression Make(Type type, string name, bool isByRef) { }

	// RVA: 0x1FBAA60 Offset: 0x1FB9460 VA: 0x181FBAA60 Slot: 5
	public override Type get_Type() { }

	// RVA: 0x1FBAA50 Offset: 0x1FB9450 VA: 0x181FBAA50 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Name() { }

	// RVA: 0x6FDC50 Offset: 0x6FC650 VA: 0x1806FDC50
	public bool get_IsByRef() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 10
	internal virtual bool GetIsByRef() { }

	// RVA: 0x1FBA230 Offset: 0x1FB8C30 VA: 0x181FBA230 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }
}
