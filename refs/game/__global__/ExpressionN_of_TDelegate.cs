internal class ExpressionN<TDelegate> : Expression<TDelegate> // TypeDefIndex: 15165
{
	// Fields
	private IReadOnlyList<ParameterExpression> _parameters; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, IReadOnlyList<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE150 Offset: 0x17ACB50 VA: 0x1817AE150
	|-ExpressionN<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AEDF0 Offset: 0x17AD7F0 VA: 0x1817AEDF0
	|-ExpressionN<__Il2CppFullySharedGenericType>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AEC70 Offset: 0x17AD670 VA: 0x1817AEC70
	|-ExpressionN<__Il2CppFullySharedGenericType>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AED20 Offset: 0x17AD720 VA: 0x1817AED20
	|-ExpressionN<__Il2CppFullySharedGenericType>.Rewrite
	*/
}
