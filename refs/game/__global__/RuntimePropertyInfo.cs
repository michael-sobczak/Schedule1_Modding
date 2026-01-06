internal class RuntimePropertyInfo : PropertyInfo, ISerializable // TypeDefIndex: 4767
{
	// Fields
	internal IntPtr klass; // 0x10
	internal IntPtr prop; // 0x18
	private MonoPropertyInfo info; // 0x20
	private PInfo cached; // 0x50
	private RuntimePropertyInfo.GetterAdapter cached_getter; // 0x58

	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x1B98D00 Offset: 0x1B97700 VA: 0x181B98D00
	internal static void get_property_info(RuntimePropertyInfo prop, ref MonoPropertyInfo info, PInfo req_info) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x1B98540 Offset: 0x1B96F40 VA: 0x181B98540 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x1B98000 Offset: 0x1B96A00 VA: 0x181B98000
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x1B98C40 Offset: 0x1B97640 VA: 0x181B98C40
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x1B98540 Offset: 0x1B96F40 VA: 0x181B98540
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x1B98AA0 Offset: 0x1B974A0 VA: 0x181B98AA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B97C60 Offset: 0x1B96660 VA: 0x181B97C60
	private string FormatNameAndSig(bool serialization) { }

	// RVA: 0x1B98300 Offset: 0x1B96D00 VA: 0x181B98300 Slot: 29
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B98850 Offset: 0x1B97250 VA: 0x181B98850
	internal string SerializationToString() { }

	// RVA: 0x1B97C20 Offset: 0x1B96620 VA: 0x181B97C20
	private void CachePropertyInfo(PInfo flags) { }

	// RVA: 0x1B98AB0 Offset: 0x1B974B0 VA: 0x181B98AB0 Slot: 18
	public override bool get_CanRead() { }

	// RVA: 0x1B98AE0 Offset: 0x1B974E0 VA: 0x181B98AE0 Slot: 19
	public override bool get_CanWrite() { }

	// RVA: 0x1B98B90 Offset: 0x1B97590 VA: 0x181B98B90 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x1B98CC0 Offset: 0x1B976C0 VA: 0x181B98CC0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1B98B10 Offset: 0x1B97510 VA: 0x181B98B10 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x1B98B50 Offset: 0x1B97550 VA: 0x181B98B50 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1B98080 Offset: 0x1B96A80 VA: 0x181B98080 Slot: 22
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x1B980F0 Offset: 0x1B96AF0 VA: 0x181B980F0 Slot: 17
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x1B985D0 Offset: 0x1B96FD0 VA: 0x181B985D0 Slot: 24
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x1B987F0 Offset: 0x1B971F0 VA: 0x181B987F0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1B97F50 Offset: 0x1B96950 VA: 0x181B97F50 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B97FA0 Offset: 0x1B969A0 VA: 0x181B97FA0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1
	private static object GetterAdapterFrame<T, R>(RuntimePropertyInfo.Getter<T, R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF49500 Offset: 0xF47F00 VA: 0x180F49500
	|-RuntimePropertyInfo.GetterAdapterFrame<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static object StaticGetterAdapterFrame<R>(RuntimePropertyInfo.StaticGetter<R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF49630 Offset: 0xF48030 VA: 0x180F49630
	|-RuntimePropertyInfo.StaticGetterAdapterFrame<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1B8F120 Offset: 0x1B8DB20 VA: 0x181B8F120 Slot: 25
	public override object GetValue(object obj, object[] index) { }

	// RVA: 0x1B98640 Offset: 0x1B97040 VA: 0x181B98640 Slot: 26
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x1B98860 Offset: 0x1B97260 VA: 0x181B98860 Slot: 28
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x1B92620 Offset: 0x1B91020 VA: 0x181B92620 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x1B92620 Offset: 0x1B91020 VA: 0x181B92620
	internal static int get_metadata_token(RuntimePropertyInfo monoProperty) { }

	// RVA: 0x1B98D10 Offset: 0x1B97710 VA: 0x181B98D10
	private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x1B98470 Offset: 0x1B96E70 VA: 0x181B98470
	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
