internal class RuntimeMethodInfo : MethodInfo, ISerializable // TypeDefIndex: 4758
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override ParameterInfo ReturnParameter { get; }
	public override Type ReturnType { get; }
	public override int MetadataToken { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsGenericMethodDefinition { get; }
	public override bool IsGenericMethod { get; }
	public override bool ContainsGenericParameters { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x1B95850 Offset: 0x1B94250 VA: 0x181B95850 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x1B96220 Offset: 0x1B94C20 VA: 0x181B96220
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x1B94130 Offset: 0x1B92B30 VA: 0x181B94130 Slot: 36
	internal override string FormatNameAndSig(bool serialization) { }

	// RVA: 0x1B940F0 Offset: 0x1B92AF0 VA: 0x181B940F0 Slot: 44
	public override Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x1B94110 Offset: 0x1B92B10 VA: 0x181B94110 Slot: 45
	public override Delegate CreateDelegate(Type delegateType, object target) { }

	// RVA: 0x1B96080 Offset: 0x1B94A80 VA: 0x181B96080 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B95850 Offset: 0x1B94250 VA: 0x181B95850
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x1B951E0 Offset: 0x1B93BE0 VA: 0x181B951E0 Slot: 47
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B95FE0 Offset: 0x1B949E0 VA: 0x181B95FE0
	internal string SerializationToString() { }

	// RVA: 0x1B951C0 Offset: 0x1B93BC0 VA: 0x181B951C0
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	// RVA: 0x1B951D0 Offset: 0x1B93BD0 VA: 0x181B951D0
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	// RVA: 0x1B951A0 Offset: 0x1B93BA0 VA: 0x181B951A0
	internal static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle) { }

	// RVA: 0x1B951B0 Offset: 0x1B93BB0 VA: 0x181B951B0
	private static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x1B962E0 Offset: 0x1B94CE0 VA: 0x181B962E0
	internal static string get_name(MethodBase method) { }

	// RVA: 0x1B962D0 Offset: 0x1B94CD0 VA: 0x181B962D0
	internal static RuntimeMethodInfo get_base_method(RuntimeMethodInfo method, bool definition) { }

	// RVA: 0x1B92620 Offset: 0x1B91020 VA: 0x181B92620
	internal static int get_metadata_token(RuntimeMethodInfo method) { }

	// RVA: 0x1B94440 Offset: 0x1B92E40 VA: 0x181B94440 Slot: 43
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x1B94450 Offset: 0x1B92E50 VA: 0x181B94450
	internal MethodInfo GetBaseMethod() { }

	// RVA: 0x1B8E330 Offset: 0x1B8CD30 VA: 0x181B8E330 Slot: 39
	public override ParameterInfo get_ReturnParameter() { }

	// RVA: 0x1B962A0 Offset: 0x1B94CA0 VA: 0x181B962A0 Slot: 40
	public override Type get_ReturnType() { }

	// RVA: 0x1B92620 Offset: 0x1B91020 VA: 0x181B92620 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x1B91DC0 Offset: 0x1B907C0 VA: 0x181B91DC0 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x1B953F0 Offset: 0x1B93DF0 VA: 0x181B953F0 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x1B91FA0 Offset: 0x1B909A0 VA: 0x181B91FA0 Slot: 34
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x1B953C0 Offset: 0x1B93DC0 VA: 0x181B953C0 Slot: 35
	internal override int GetParametersCount() { }

	// RVA: 0x1B958E0 Offset: 0x1B942E0 VA: 0x181B958E0
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x1B958F0 Offset: 0x1B942F0 VA: 0x181B958F0 Slot: 31
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x1B93D70 Offset: 0x1B92770 VA: 0x181B93D70
	internal static void ConvertValues(Binder binder, object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 32
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x1B92570 Offset: 0x1B90F70 VA: 0x181B92570 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x1B92580 Offset: 0x1B90F80 VA: 0x181B92580 Slot: 19
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1B925F0 Offset: 0x1B90FF0 VA: 0x181B925F0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x1B92630 Offset: 0x1B91030 VA: 0x181B92630 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1B95BE0 Offset: 0x1B945E0 VA: 0x181B95BE0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1B944D0 Offset: 0x1B92ED0 VA: 0x181B944D0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B94460 Offset: 0x1B92E60 VA: 0x181B94460 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B953B0 Offset: 0x1B93DB0 VA: 0x181B953B0
	internal void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName) { }

	// RVA: 0x1B956A0 Offset: 0x1B940A0 VA: 0x181B956A0
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x1B95480 Offset: 0x1B93E80 VA: 0x181B95480
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	// RVA: 0x1B94530 Offset: 0x1B92F30 VA: 0x181B94530
	private CustomAttributeData GetDllImportAttributeData() { }

	// RVA: 0x1B95C60 Offset: 0x1B94660 VA: 0x181B95C60 Slot: 42
	public override MethodInfo MakeGenericMethod(Type[] methodInstantiation) { }

	// RVA: 0x1B95C50 Offset: 0x1B94650 VA: 0x181B95C50
	private MethodInfo MakeGenericMethod_impl(Type[] types) { }

	// RVA: 0x1B95120 Offset: 0x1B93B20 VA: 0x181B95120 Slot: 28
	public override Type[] GetGenericArguments() { }

	// RVA: 0x1B95130 Offset: 0x1B93B30 VA: 0x181B95130
	private MethodInfo GetGenericMethodDefinition_impl() { }

	// RVA: 0x1B95140 Offset: 0x1B93B40 VA: 0x181B95140 Slot: 41
	public override MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x1B96200 Offset: 0x1B94C00 VA: 0x181B96200 Slot: 27
	public override bool get_IsGenericMethodDefinition() { }

	// RVA: 0x1B96210 Offset: 0x1B94C10 VA: 0x181B96210 Slot: 26
	public override bool get_IsGenericMethod() { }

	// RVA: 0x1B96110 Offset: 0x1B94B10 VA: 0x181B96110 Slot: 29
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50
	private static int get_core_clr_security_level() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 33
	public override bool get_IsSecurityCritical() { }
}
