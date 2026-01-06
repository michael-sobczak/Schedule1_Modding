public class Expression<TDelegate> : LambdaExpression // TypeDefIndex: 15159
{
	// Properties
	internal sealed override Type TypeCore { get; }
	internal override Type PublicType { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Expression body) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AF250 Offset: 0x17ADC50 VA: 0x1817AF250
	|-Expression<object>..ctor
	|-Expression<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	internal sealed override Type get_TypeCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AF380 Offset: 0x17ADD80 VA: 0x1817AF380
	|-Expression<object>.get_TypeCore
	|
	|-RVA: 0x17AF320 Offset: 0x17ADD20 VA: 0x1817AF320
	|-Expression<__Il2CppFullySharedGenericType>.get_TypeCore
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override Type get_PublicType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AF260 Offset: 0x17ADC60 VA: 0x1817AF260
	|-Expression<object>.get_PublicType
	|
	|-RVA: 0x17AF2C0 Offset: 0x17ADCC0 VA: 0x1817AF2C0
	|-Expression<__Il2CppFullySharedGenericType>.get_PublicType
	*/

	// RVA: -1 Offset: -1
	public TDelegate Compile() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AF030 Offset: 0x17ADA30 VA: 0x1817AF030
	|-Expression<object>.Compile
	|
	|-RVA: 0x17AEF70 Offset: 0x17AD970 VA: 0x1817AEF70
	|-Expression<__Il2CppFullySharedGenericType>.Compile
	*/

	// RVA: -1 Offset: -1
	public TDelegate Compile(bool preferInterpretation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AEEA0 Offset: 0x17AD8A0 VA: 0x1817AEEA0
	|-Expression<object>.Compile
	|
	|-RVA: 0x17AF110 Offset: 0x17ADB10 VA: 0x1817AF110
	|-Expression<__Il2CppFullySharedGenericType>.Compile
	*/

	[ExcludeFromCodeCoverage]
	// RVA: -1 Offset: -1 Slot: 18
	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AF230 Offset: 0x17ADC30 VA: 0x1817AF230
	|-Expression<object>.Rewrite
	|-Expression<__Il2CppFullySharedGenericType>.Rewrite
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AEE40 Offset: 0x17AD840 VA: 0x1817AEE40
	|-Expression<object>.Accept
	|-Expression<__Il2CppFullySharedGenericType>.Accept
	*/
}
