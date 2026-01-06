public class NewArrayExpression : Expression // TypeDefIndex: 15192
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<Expression> <Expressions>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public ReadOnlyCollection<Expression> Expressions { get; }

	// Methods

	// RVA: 0x1FB9DB0 Offset: 0x1FB87B0 VA: 0x181FB9DB0
	internal void .ctor(Type type, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x1FB9BC0 Offset: 0x1FB85C0 VA: 0x181FB9BC0
	internal static NewArrayExpression Make(ExpressionType nodeType, Type type, ReadOnlyCollection<Expression> expressions) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public ReadOnlyCollection<Expression> get_Expressions() { }

	// RVA: 0x1FB9B90 Offset: 0x1FB8590 VA: 0x181FB9B90 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1FB9C40 Offset: 0x1FB8640 VA: 0x181FB9C40
	public NewArrayExpression Update(IEnumerable<Expression> expressions) { }
}
