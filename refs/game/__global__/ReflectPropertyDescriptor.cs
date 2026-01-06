internal sealed class ReflectPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 9791
{
	// Fields
	private static readonly Type[] argsNone; // 0x0
	private static readonly object noValue; // 0x8
	private static TraceSwitch PropDescCreateSwitch; // 0x10
	private static TraceSwitch PropDescUsageSwitch; // 0x18
	private static readonly int BitDefaultValueQueried; // 0x20
	private static readonly int BitGetQueried; // 0x24
	private static readonly int BitSetQueried; // 0x28
	private static readonly int BitShouldSerializeQueried; // 0x2C
	private static readonly int BitResetQueried; // 0x30
	private static readonly int BitChangedQueried; // 0x34
	private static readonly int BitIPropChangedQueried; // 0x38
	private static readonly int BitReadOnlyChecked; // 0x3C
	private static readonly int BitAmbientValueQueried; // 0x40
	private static readonly int BitSetOnDemand; // 0x44
	private BitVector32 state; // 0x88
	private Type componentClass; // 0x90
	private Type type; // 0x98
	private object defaultValue; // 0xA0
	private object ambientValue; // 0xA8
	private PropertyInfo propInfo; // 0xB0
	private MethodInfo getMethod; // 0xB8
	private MethodInfo setMethod; // 0xC0
	private MethodInfo shouldSerializeMethod; // 0xC8
	private MethodInfo resetMethod; // 0xD0
	private EventDescriptor realChangedEvent; // 0xD8
	private Type receiverType; // 0xE0

	// Properties
	private object AmbientValue { get; }
	public override Type ComponentType { get; }
	private object DefaultValue { get; }
	private MethodInfo GetMethodValue { get; }
	private bool IsExtender { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	private MethodInfo ResetMethodValue { get; }
	private MethodInfo SetMethodValue { get; }
	private MethodInfo ShouldSerializeMethodValue { get; }

	// Methods

	// RVA: 0x26754E0 Offset: 0x2673EE0 VA: 0x1826754E0
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x2675840 Offset: 0x2674240 VA: 0x182675840
	public void .ctor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x2675740 Offset: 0x2674140 VA: 0x182675740
	public void .ctor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x2674FA0 Offset: 0x26739A0 VA: 0x182674FA0
	public void .ctor(Type componentClass, PropertyDescriptor oldReflectPropertyDescriptor, Attribute[] attributes) { }

	// RVA: 0x26759B0 Offset: 0x26743B0 VA: 0x1826759B0
	private object get_AmbientValue() { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x2675B70 Offset: 0x2674570 VA: 0x182675B70
	private object get_DefaultValue() { }

	// RVA: 0x2675E90 Offset: 0x2674890 VA: 0x182675E90
	private MethodInfo get_GetMethodValue() { }

	// RVA: 0x26763E0 Offset: 0x2674DE0 VA: 0x1826763E0
	private bool get_IsExtender() { }

	// RVA: 0x2676440 Offset: 0x2674E40 VA: 0x182676440 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x2676550 Offset: 0x2674F50 VA: 0x182676550
	private MethodInfo get_ResetMethodValue() { }

	// RVA: 0x26767C0 Offset: 0x26751C0 VA: 0x1826767C0
	private MethodInfo get_SetMethodValue() { }

	// RVA: 0x2676E60 Offset: 0x2675860 VA: 0x182676E60
	private MethodInfo get_ShouldSerializeMethodValue() { }

	// RVA: 0x2672520 Offset: 0x2670F20 VA: 0x182672520
	internal bool ExtenderCanResetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	internal Type ExtenderGetReceiverType() { }

	// RVA: 0x1B8D1E0 Offset: 0x1B8BBE0 VA: 0x181B8D1E0
	internal Type ExtenderGetType(IExtenderProvider provider) { }

	// RVA: 0x2672760 Offset: 0x2671160 VA: 0x182672760
	internal object ExtenderGetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x26728C0 Offset: 0x26712C0 VA: 0x1826728C0
	internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc) { }

	// RVA: 0x2672CA0 Offset: 0x26716A0 VA: 0x182672CA0
	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	// RVA: 0x2673010 Offset: 0x2671A10 VA: 0x182673010
	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	// RVA: 0x26722B0 Offset: 0x2670CB0 VA: 0x1826722B0 Slot: 17
	public override bool CanResetValue(object component) { }

	// RVA: 0x26733C0 Offset: 0x2671DC0 VA: 0x1826733C0 Slot: 11
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x2673E00 Offset: 0x2672800 VA: 0x182673E00 Slot: 18
	public override object GetValue(object component) { }

	// RVA: 0x2674120 Offset: 0x2672B20 VA: 0x182674120 Slot: 19
	protected override void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x2674230 Offset: 0x2672C30 VA: 0x182674230 Slot: 20
	public override void ResetValue(object component) { }

	// RVA: 0x2674540 Offset: 0x2672F40 VA: 0x182674540 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x26749E0 Offset: 0x26733E0 VA: 0x1826749E0 Slot: 22
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x2674C70 Offset: 0x2673670 VA: 0x182674C70
	private static void .cctor() { }
}
