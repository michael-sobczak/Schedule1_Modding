public sealed class PropertyBuilder : PropertyInfo // TypeDefIndex: 4781
{
	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x1B8EF60 Offset: 0x1B8D960 VA: 0x181B8EF60 Slot: 18
	public override bool get_CanRead() { }

	// RVA: 0x1B8EFA0 Offset: 0x1B8D9A0 VA: 0x181B8EFA0 Slot: 19
	public override bool get_CanWrite() { }

	// RVA: 0x1B8EFE0 Offset: 0x1B8D9E0 VA: 0x181B8EFE0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x1B8F020 Offset: 0x1B8DA20 VA: 0x181B8F020 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1B8F060 Offset: 0x1B8DA60 VA: 0x181B8F060 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x1B8F0A0 Offset: 0x1B8DAA0 VA: 0x181B8F0A0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1B8EDA0 Offset: 0x1B8D7A0 VA: 0x181B8EDA0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B8ED60 Offset: 0x1B8D760 VA: 0x181B8ED60 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B8EDE0 Offset: 0x1B8D7E0 VA: 0x181B8EDE0 Slot: 22
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x1B8EE20 Offset: 0x1B8D820 VA: 0x181B8EE20 Slot: 17
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x1B8EE60 Offset: 0x1B8D860 VA: 0x181B8EE60 Slot: 24
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x1B8EEA0 Offset: 0x1B8D8A0 VA: 0x181B8EEA0 Slot: 26
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x1B8EEE0 Offset: 0x1B8D8E0 VA: 0x181B8EEE0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1B8EF20 Offset: 0x1B8D920 VA: 0x181B8EF20 Slot: 28
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }
}
