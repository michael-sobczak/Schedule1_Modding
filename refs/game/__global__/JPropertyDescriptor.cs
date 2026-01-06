public class JPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 11338
{
	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	protected override int NameHashCode { get; }

	// Methods

	// RVA: 0x1DBC270 Offset: 0x1DBAC70 VA: 0x181DBC270
	public void .ctor(string name) { }

	// RVA: 0x1DBC030 Offset: 0x1DBAA30 VA: 0x181DBC030
	private static JObject CastInstance(object instance) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 17
	public override bool CanResetValue(object component) { }

	[NullableContext(2)]
	// RVA: 0x1DBC0B0 Offset: 0x1DBAAB0 VA: 0x181DBC0B0 Slot: 18
	public override object GetValue(object component) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 20
	public override void ResetValue(object component) { }

	[NullableContext(2)]
	// RVA: 0x1DBC150 Offset: 0x1DBAB50 VA: 0x181DBC150 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 22
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x1DBC280 Offset: 0x1DBAC80 VA: 0x181DBC280 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x1DBC2E0 Offset: 0x1DBACE0 VA: 0x181DBC2E0 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 8
	protected override int get_NameHashCode() { }
}
