internal sealed class DynamicProxyMetaObject<T> : DynamicMetaObject // TypeDefIndex: 11149
{
	// Fields
	private readonly DynamicProxy<T> _proxy; // 0x0

	// Properties
	private static Expression[] NoArgs { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Expression expression, T value, DynamicProxy<T> proxy) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1640560 Offset: 0x163EF60 VA: 0x181640560
	|-DynamicProxyMetaObject<object>..ctor
	|
	|-RVA: 0x1640630 Offset: 0x163F030 VA: 0x181640630
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private bool IsOverridden(string method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16403C0 Offset: 0x163EDC0 VA: 0x1816403C0
	|-DynamicProxyMetaObject<object>.IsOverridden
	|
	|-RVA: 0x1640490 Offset: 0x163EE90 VA: 0x181640490
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.IsOverridden
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override DynamicMetaObject BindGetMember(GetMemberBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163BEA0 Offset: 0x163A8A0 VA: 0x18163BEA0
	|-DynamicProxyMetaObject<object>.BindGetMember
	|
	|-RVA: 0x163C080 Offset: 0x163AA80 VA: 0x18163C080
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindGetMember
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163CFF0 Offset: 0x163B9F0 VA: 0x18163CFF0
	|-DynamicProxyMetaObject<object>.BindSetMember
	|
	|-RVA: 0x163D220 Offset: 0x163BC20 VA: 0x18163D220
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindSetMember
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163B930 Offset: 0x163A330 VA: 0x18163B930
	|-DynamicProxyMetaObject<object>.BindDeleteMember
	|
	|-RVA: 0x163B780 Offset: 0x163A180 VA: 0x18163B780
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindDeleteMember
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override DynamicMetaObject BindConvert(ConvertBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163ACA0 Offset: 0x16396A0 VA: 0x18163ACA0
	|-DynamicProxyMetaObject<object>.BindConvert
	|
	|-RVA: 0x163AE80 Offset: 0x1639880 VA: 0x18163AE80
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindConvert
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163C550 Offset: 0x163AF50 VA: 0x18163C550
	|-DynamicProxyMetaObject<object>.BindInvokeMember
	|
	|-RVA: 0x163C230 Offset: 0x163AC30 VA: 0x18163C230
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindInvokeMember
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163B030 Offset: 0x1639A30 VA: 0x18163B030
	|-DynamicProxyMetaObject<object>.BindCreateInstance
	|
	|-RVA: 0x163B220 Offset: 0x1639C20 VA: 0x18163B220
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindCreateInstance
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163CA20 Offset: 0x163B420 VA: 0x18163CA20
	|-DynamicProxyMetaObject<object>.BindInvoke
	|
	|-RVA: 0x163C850 Offset: 0x163B250 VA: 0x18163C850
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163AA30 Offset: 0x1639430 VA: 0x18163AA30
	|-DynamicProxyMetaObject<object>.BindBinaryOperation
	|
	|-RVA: 0x163A7E0 Offset: 0x16391E0 VA: 0x18163A7E0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindBinaryOperation
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163D610 Offset: 0x163C010 VA: 0x18163D610
	|-DynamicProxyMetaObject<object>.BindUnaryOperation
	|
	|-RVA: 0x163D460 Offset: 0x163BE60 VA: 0x18163D460
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindUnaryOperation
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163BAE0 Offset: 0x163A4E0 VA: 0x18163BAE0
	|-DynamicProxyMetaObject<object>.BindGetIndex
	|
	|-RVA: 0x163BCD0 Offset: 0x163A6D0 VA: 0x18163BCD0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindGetIndex
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163CC10 Offset: 0x163B610 VA: 0x18163CC10
	|-DynamicProxyMetaObject<object>.BindSetIndex
	|
	|-RVA: 0x163CE00 Offset: 0x163B800 VA: 0x18163CE00
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindSetIndex
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163B3F0 Offset: 0x1639DF0 VA: 0x18163B3F0
	|-DynamicProxyMetaObject<object>.BindDeleteIndex
	|
	|-RVA: 0x163B5B0 Offset: 0x1639FB0 VA: 0x18163B5B0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindDeleteIndex
	*/

	// RVA: -1 Offset: -1
	private static Expression[] get_NoArgs() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16407C0 Offset: 0x163F1C0 VA: 0x1816407C0
	|-DynamicProxyMetaObject<object>.get_NoArgs
	|
	|-RVA: 0x1640790 Offset: 0x163F190 VA: 0x181640790
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.get_NoArgs
	*/

	// RVA: -1 Offset: -1
	private static IEnumerable<Expression> GetArgs(DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163FE60 Offset: 0x163E860 VA: 0x18163FE60
	|-DynamicProxyMetaObject<object>.GetArgs
	|
	|-RVA: 0x163FC20 Offset: 0x163E620 VA: 0x18163FC20
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetArgs
	*/

	// RVA: -1 Offset: -1
	private static Expression[] GetArgArray(DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163F710 Offset: 0x163E110 VA: 0x18163F710
	|-DynamicProxyMetaObject<object>.GetArgArray
	|
	|-RVA: 0x163FAA0 Offset: 0x163E4A0 VA: 0x18163FAA0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetArgArray
	*/

	// RVA: -1 Offset: -1
	private static Expression[] GetArgArray(DynamicMetaObject[] args, DynamicMetaObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163F870 Offset: 0x163E270 VA: 0x18163F870
	|-DynamicProxyMetaObject<object>.GetArgArray
	|
	|-RVA: 0x163F4C0 Offset: 0x163DEC0 VA: 0x18163F4C0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetArgArray
	*/

	// RVA: -1 Offset: -1
	private static ConstantExpression Constant(DynamicMetaObjectBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163F380 Offset: 0x163DD80 VA: 0x18163F380
	|-DynamicProxyMetaObject<object>.Constant
	|
	|-RVA: 0x163F420 Offset: 0x163DE20 VA: 0x18163F420
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.Constant
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicProxyMetaObject.Fallback<T> fallback, DynamicProxyMetaObject.Fallback<T> fallbackInvoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163F2F0 Offset: 0x163DCF0 VA: 0x18163F2F0
	|-DynamicProxyMetaObject<object>.CallMethodWithResult
	|
	|-RVA: 0x163F240 Offset: 0x163DC40 VA: 0x18163F240
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.CallMethodWithResult
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicMetaObject fallbackResult, DynamicProxyMetaObject.Fallback<T> fallbackInvoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163D7F0 Offset: 0x163C1F0 VA: 0x18163D7F0
	|-DynamicProxyMetaObject<object>.BuildCallMethodWithResult
	|
	|-RVA: 0x163DDB0 Offset: 0x163C7B0 VA: 0x18163DDB0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BuildCallMethodWithResult
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicProxyMetaObject.Fallback<T> fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163ED90 Offset: 0x163D790 VA: 0x18163ED90
	|-DynamicProxyMetaObject<object>.CallMethodReturnLast
	|
	|-RVA: 0x163E930 Offset: 0x163D330 VA: 0x18163E930
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.CallMethodReturnLast
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodNoResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, DynamicProxyMetaObject.Fallback<T> fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x163E320 Offset: 0x163CD20 VA: 0x18163E320
	|-DynamicProxyMetaObject<object>.CallMethodNoResult
	|
	|-RVA: 0x163E650 Offset: 0x163D050 VA: 0x18163E650
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.CallMethodNoResult
	*/

	// RVA: -1 Offset: -1
	private BindingRestrictions GetRestrictions() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1640300 Offset: 0x163ED00 VA: 0x181640300
	|-DynamicProxyMetaObject<object>.GetRestrictions
	|
	|-RVA: 0x1640240 Offset: 0x163EC40 VA: 0x181640240
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetRestrictions
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public override IEnumerable<string> GetDynamicMemberNames() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16401A0 Offset: 0x163EBA0 VA: 0x1816401A0
	|-DynamicProxyMetaObject<object>.GetDynamicMemberNames
	|
	|-RVA: 0x16400A0 Offset: 0x163EAA0 VA: 0x1816400A0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetDynamicMemberNames
	*/
}
