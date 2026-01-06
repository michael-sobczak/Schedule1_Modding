internal class RuntimeFieldInfo : RtFieldInfo, ISerializable // TypeDefIndex: 4756
{
	// Fields
	internal IntPtr klass; // 0x10
	internal RuntimeFieldHandle fhandle; // 0x18
	private string name; // 0x20
	private Type type; // 0x28
	private FieldAttributes attrs; // 0x30

	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override FieldAttributes Attributes { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type FieldType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x1B93400 Offset: 0x1B91E00 VA: 0x181B93400 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x1B931F0 Offset: 0x1B91BF0 VA: 0x181B931F0
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x1B93CE0 Offset: 0x1B926E0 VA: 0x181B93CE0
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x1B93400 Offset: 0x1B91E00 VA: 0x181B93400
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x1B93280 Offset: 0x1B91C80 VA: 0x181B93280 Slot: 34
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B93490 Offset: 0x1B91E90 VA: 0x181B93490 Slot: 31
	internal override object UnsafeGetValue(object obj) { }

	// RVA: 0x1B92EC0 Offset: 0x1B918C0 VA: 0x181B92EC0 Slot: 33
	internal override void CheckConsistency(object target) { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x1B93BE0 Offset: 0x1B925E0 VA: 0x181B93BE0 Slot: 32
	internal override void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x1B936E0 Offset: 0x1B920E0 VA: 0x181B936E0 Slot: 28
	public override void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90 Slot: 16
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 24
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x1B936D0 Offset: 0x1B920D0 VA: 0x181B936D0
	private Type ResolveType() { }

	// RVA: 0x1B93C60 Offset: 0x1B92660 VA: 0x181B93C60 Slot: 17
	public override Type get_FieldType() { }

	// RVA: 0x1B933E0 Offset: 0x1B91DE0 VA: 0x181B933E0
	private Type GetParentType(bool declaring) { }

	// RVA: 0x1B93D60 Offset: 0x1B92760 VA: 0x181B93D60 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1B93C50 Offset: 0x1B92650 VA: 0x181B93C50 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1B93660 Offset: 0x1B92060 VA: 0x181B93660 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1B93120 Offset: 0x1B91B20 VA: 0x181B93120 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B93180 Offset: 0x1B91B80 VA: 0x181B93180 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B93270 Offset: 0x1B91C70 VA: 0x181B93270 Slot: 30
	internal override int GetFieldOffset() { }

	// RVA: 0x1B93490 Offset: 0x1B91E90 VA: 0x181B93490
	private object GetValueInternal(object obj) { }

	// RVA: 0x1B934A0 Offset: 0x1B91EA0 VA: 0x181B934A0 Slot: 25
	public override object GetValue(object obj) { }

	// RVA: 0x1B93B80 Offset: 0x1B92580 VA: 0x181B93B80 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B93870 Offset: 0x1B92270 VA: 0x181B93870
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x1B93880 Offset: 0x1B92280 VA: 0x181B93880 Slot: 27
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x1B933F0 Offset: 0x1B91DF0 VA: 0x181B933F0 Slot: 29
	public override object GetRawConstantValue() { }

	// RVA: 0x1B93080 Offset: 0x1B91A80 VA: 0x181B93080
	private void CheckGeneric() { }

	// RVA: 0x1B92620 Offset: 0x1B91020 VA: 0x181B92620 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x1B92620 Offset: 0x1B91020 VA: 0x181B92620
	internal static int get_metadata_token(RuntimeFieldInfo monoField) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
