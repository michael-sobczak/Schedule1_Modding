public class DynamicMetaObject // TypeDefIndex: 15626
{
	// Fields
	public static readonly DynamicMetaObject[] EmptyMetaObjects; // 0x0
	private static readonly object s_noValueSentinel; // 0x8
	private readonly object _value; // 0x10
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly BindingRestrictions <Restrictions>k__BackingField; // 0x20

	// Properties
	public Expression Expression { get; }
	public BindingRestrictions Restrictions { get; }
	public object Value { get; }
	public bool HasValue { get; }
	public Type RuntimeType { get; }
	public Type LimitType { get; }

	// Methods

	// RVA: 0x1FE99E0 Offset: 0x1FE83E0 VA: 0x181FE99E0
	public void .ctor(Expression expression, BindingRestrictions restrictions) { }

	// RVA: 0x1FE98E0 Offset: 0x1FE82E0 VA: 0x181FE98E0
	public void .ctor(Expression expression, BindingRestrictions restrictions, object value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Expression get_Expression() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public BindingRestrictions get_Restrictions() { }

	// RVA: 0x1FE9CD0 Offset: 0x1FE86D0 VA: 0x181FE9CD0
	public object get_Value() { }

	// RVA: 0x1FE9AC0 Offset: 0x1FE84C0 VA: 0x181FE9AC0
	public bool get_HasValue() { }

	// RVA: 0x1FE9C00 Offset: 0x1FE8600 VA: 0x181FE9C00
	public Type get_RuntimeType() { }

	// RVA: 0x1FE9B20 Offset: 0x1FE8520 VA: 0x181FE9B20
	public Type get_LimitType() { }

	// RVA: 0x1FE9000 Offset: 0x1FE7A00 VA: 0x181FE9000 Slot: 4
	public virtual DynamicMetaObject BindConvert(ConvertBinder binder) { }

	// RVA: 0x1FE9280 Offset: 0x1FE7C80 VA: 0x181FE9280 Slot: 5
	public virtual DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	// RVA: 0x1FE9480 Offset: 0x1FE7E80 VA: 0x181FE9480 Slot: 6
	public virtual DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	// RVA: 0x1FE9190 Offset: 0x1FE7B90 VA: 0x181FE9190 Slot: 7
	public virtual DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

	// RVA: 0x1FE9200 Offset: 0x1FE7C00 VA: 0x181FE9200 Slot: 8
	public virtual DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x1FE93F0 Offset: 0x1FE7DF0 VA: 0x181FE93F0 Slot: 9
	public virtual DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	// RVA: 0x1FE9100 Offset: 0x1FE7B00 VA: 0x181FE9100 Slot: 10
	public virtual DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x1FE92F0 Offset: 0x1FE7CF0 VA: 0x181FE92F0 Slot: 11
	public virtual DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x1FE9370 Offset: 0x1FE7D70 VA: 0x181FE9370 Slot: 12
	public virtual DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x1FE9070 Offset: 0x1FE7A70 VA: 0x181FE9070 Slot: 13
	public virtual DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x1FE9500 Offset: 0x1FE7F00 VA: 0x181FE9500 Slot: 14
	public virtual DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }

	// RVA: 0x1FE8F70 Offset: 0x1FE7970 VA: 0x181FE8F70 Slot: 15
	public virtual DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }

	// RVA: 0x1FE97F0 Offset: 0x1FE81F0 VA: 0x181FE97F0 Slot: 16
	public virtual IEnumerable<string> GetDynamicMemberNames() { }

	// RVA: 0x1FE9570 Offset: 0x1FE7F70 VA: 0x181FE9570
	public static DynamicMetaObject Create(object value, Expression expression) { }

	// RVA: 0x1FE9820 Offset: 0x1FE8220 VA: 0x181FE9820
	private static void .cctor() { }
}
