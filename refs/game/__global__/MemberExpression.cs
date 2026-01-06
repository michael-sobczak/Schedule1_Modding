public class MemberExpression : Expression // TypeDefIndex: 15172
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; // 0x10

	// Properties
	public MemberInfo Member { get; }
	public Expression Expression { get; }
	public sealed override ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x6FDC50 Offset: 0x6FC650 VA: 0x1806FDC50
	public MemberInfo get_Member() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Expression get_Expression() { }

	// RVA: 0x1FB84B0 Offset: 0x1FB6EB0 VA: 0x181FB84B0
	internal void .ctor(Expression expression) { }

	// RVA: 0x1FB8370 Offset: 0x1FB6D70 VA: 0x181FB8370
	internal static PropertyExpression Make(Expression expression, PropertyInfo property) { }

	// RVA: 0x1FB82C0 Offset: 0x1FB6CC0 VA: 0x181FB82C0
	internal static FieldExpression Make(Expression expression, FieldInfo field) { }

	// RVA: 0x1BF2250 Offset: 0x1BF0C50 VA: 0x181BF2250 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1FB8290 Offset: 0x1FB6C90 VA: 0x181FB8290 Slot: 10
	internal virtual MemberInfo GetMember() { }

	// RVA: 0x1FB8260 Offset: 0x1FB6C60 VA: 0x181FB8260 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1FB8420 Offset: 0x1FB6E20 VA: 0x181FB8420
	public MemberExpression Update(Expression expression) { }
}
