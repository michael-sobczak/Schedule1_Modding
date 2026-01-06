public abstract class BindingRestrictions // TypeDefIndex: 15621
{
	// Fields
	public static readonly BindingRestrictions Empty; // 0x0

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract Expression GetExpression();

	// RVA: 0x1FE3F70 Offset: 0x1FE2970 VA: 0x181FE3F70
	public BindingRestrictions Merge(BindingRestrictions restrictions) { }

	// RVA: 0x1FE3E80 Offset: 0x1FE2880 VA: 0x181FE3E80
	public static BindingRestrictions GetTypeRestriction(Expression expression, Type type) { }

	// RVA: 0x1FE3B60 Offset: 0x1FE2560 VA: 0x181FE3B60
	internal static BindingRestrictions GetTypeRestriction(DynamicMetaObject obj) { }

	// RVA: 0x1FE3A90 Offset: 0x1FE2490 VA: 0x181FE3A90
	public static BindingRestrictions GetInstanceRestriction(Expression expression, object instance) { }

	// RVA: 0x1C842D0 Offset: 0x1C82CD0 VA: 0x181C842D0
	public Expression ToExpression() { }

	// RVA: 0x1FE40C0 Offset: 0x1FE2AC0 VA: 0x181FE40C0
	private static void .cctor() { }
}
