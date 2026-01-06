internal sealed class Expression3<TDelegate> : Expression<TDelegate> // TypeDefIndex: 15164
{
	// Fields
	private object _par0; // 0x0
	private readonly ParameterExpression _par1; // 0x0
	private readonly ParameterExpression _par2; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, ParameterExpression par0, ParameterExpression par1, ParameterExpression par2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE700 Offset: 0x17AD100 VA: 0x1817AE700
	|-Expression3<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x583670 Offset: 0x582070 VA: 0x180583670
	|-Expression3<__Il2CppFullySharedGenericType>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE450 Offset: 0x17ACE50 VA: 0x1817AE450
	|-Expression3<__Il2CppFullySharedGenericType>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AE500 Offset: 0x17ACF00 VA: 0x1817AE500
	|-Expression3<__Il2CppFullySharedGenericType>.Rewrite
	*/
}
