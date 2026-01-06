public abstract class DynamicMetaObjectBinder : CallSiteBinder // TypeDefIndex: 15627
{
	// Properties
	public virtual Type ReturnType { get; }
	internal virtual bool IsStandardBinder { get; }

	// Methods

	// RVA: 0x1FE8EC0 Offset: 0x1FE78C0 VA: 0x181FE8EC0
	protected void .ctor() { }

	// RVA: 0x1FE8F10 Offset: 0x1FE7910 VA: 0x181FE8F10 Slot: 6
	public virtual Type get_ReturnType() { }

	// RVA: 0x1FE83D0 Offset: 0x1FE6DD0 VA: 0x181FE83D0 Slot: 4
	public sealed override Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel) { }

	// RVA: 0x1FE8C60 Offset: 0x1FE7660 VA: 0x181FE8C60
	private static DynamicMetaObject[] CreateArgumentMetaObjects(object[] args, ReadOnlyCollection<ParameterExpression> parameters) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args);

	// RVA: 0x1FE8E00 Offset: 0x1FE7800 VA: 0x181FE8E00
	public Expression GetUpdateExpression(Type type) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	internal virtual bool get_IsStandardBinder() { }
}
