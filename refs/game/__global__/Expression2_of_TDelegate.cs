internal sealed class Expression2<TDelegate> : Expression<TDelegate> // TypeDefIndex: 15163
{
	// Fields
	private object _par0; // 0x0
	private readonly ParameterExpression _par1; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, ParameterExpression par0, ParameterExpression par1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE3F0 Offset: 0x17ACDF0 VA: 0x1817AE3F0
	|-Expression2<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0
	|-Expression2<__Il2CppFullySharedGenericType>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE190 Offset: 0x17ACB90 VA: 0x1817AE190
	|-Expression2<__Il2CppFullySharedGenericType>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE230 Offset: 0x17ACC30 VA: 0x1817AE230
	|-Expression2<__Il2CppFullySharedGenericType>.Rewrite
	*/
}
