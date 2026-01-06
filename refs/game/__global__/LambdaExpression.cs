public abstract class LambdaExpression : Expression, IParameterProvider // TypeDefIndex: 15158
{
	// Fields
	private readonly Expression _body; // 0x10

	// Properties
	public sealed override Type Type { get; }
	internal abstract Type TypeCore { get; }
	internal abstract Type PublicType { get; }
	public sealed override ExpressionType NodeType { get; }
	public string Name { get; }
	internal virtual string NameCore { get; }
	public Expression Body { get; }
	public Type ReturnType { get; }
	public bool TailCall { get; }
	internal virtual bool TailCallCore { get; }
	[ExcludeFromCodeCoverage]
	private int System.Linq.Expressions.IParameterProvider.ParameterCount { get; }
	[ExcludeFromCodeCoverage]
	internal virtual int ParameterCount { get; }

	// Methods

	// RVA: 0x1FB7A80 Offset: 0x1FB6480 VA: 0x181FB7A80
	internal void .ctor(Expression body) { }

	// RVA: 0xD3C090 Offset: 0xD3AA90 VA: 0x180D3C090 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract Type get_TypeCore();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract Type get_PublicType();

	// RVA: 0x578D50 Offset: 0x577750 VA: 0x180578D50 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1FB7AF0 Offset: 0x1FB64F0 VA: 0x181FB7AF0
	public string get_Name() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 14
	internal virtual string get_NameCore() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Expression get_Body() { }

	// RVA: 0x1FB7B40 Offset: 0x1FB6540 VA: 0x181FB7B40
	public Type get_ReturnType() { }

	// RVA: 0x4DD630 Offset: 0x4DC030 VA: 0x1804DD630
	public bool get_TailCall() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 15
	internal virtual bool get_TailCallCore() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1FB7A60 Offset: 0x1FB6460 VA: 0x181FB7A60 Slot: 10
	private ParameterExpression System.Linq.Expressions.IParameterProvider.GetParameter(int index) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1FB7A30 Offset: 0x1FB6430 VA: 0x181FB7A30 Slot: 16
	internal virtual ParameterExpression GetParameter(int index) { }

	// RVA: 0xBF3280 Offset: 0xBF1C80 VA: 0x180BF3280 Slot: 11
	private int System.Linq.Expressions.IParameterProvider.get_ParameterCount() { }

	// RVA: 0x1FB7B10 Offset: 0x1FB6510 VA: 0x181FB7B10 Slot: 17
	internal virtual int get_ParameterCount() { }
}
