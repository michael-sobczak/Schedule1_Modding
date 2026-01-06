public class MethodCallExpression : Expression, IArgumentProvider // TypeDefIndex: 15178
{
	// Fields
	[CompilerGenerated]
	private readonly MethodInfo <Method>k__BackingField; // 0x10

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }
	public MethodInfo Method { get; }
	public Expression Object { get; }
	[ExcludeFromCodeCoverage]
	public virtual int ArgumentCount { get; }

	// Methods

	// RVA: 0x1FB85C0 Offset: 0x1FB6FC0 VA: 0x181FB85C0
	internal void .ctor(MethodInfo method) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 12
	internal virtual Expression GetInstance() { }

	// RVA: 0x681E20 Offset: 0x680820 VA: 0x180681E20 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1BFEC90 Offset: 0x1BFD690 VA: 0x181BFEC90 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public MethodInfo get_Method() { }

	// RVA: 0xD3C090 Offset: 0xD3AA90 VA: 0x180D3C090
	public Expression get_Object() { }

	// RVA: 0x1E36A70 Offset: 0x1E35470 VA: 0x181E36A70 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1FB9400 Offset: 0x1FB7E00 VA: 0x181FB9400 Slot: 13
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1FB93D0 Offset: 0x1FB7DD0 VA: 0x181FB93D0 Slot: 14
	public virtual Expression GetArgument(int index) { }

	// RVA: 0x1FB9430 Offset: 0x1FB7E30 VA: 0x181FB9430 Slot: 15
	public virtual int get_ArgumentCount() { }
}
