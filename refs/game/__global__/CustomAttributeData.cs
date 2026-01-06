public class CustomAttributeData // TypeDefIndex: 4748
{
	// Fields
	private ConstructorInfo ctorInfo; // 0x10
	private IList<CustomAttributeTypedArgument> ctorArgs; // 0x18
	private IList<CustomAttributeNamedArgument> namedArgs; // 0x20
	private CustomAttributeData.LazyCAttrData lazyData; // 0x28

	// Properties
	[ComVisible(True)]
	public virtual ConstructorInfo Constructor { get; }
	[ComVisible(True)]
	public virtual IList<CustomAttributeTypedArgument> ConstructorArguments { get; }
	public virtual IList<CustomAttributeNamedArgument> NamedArguments { get; }
	public Type AttributeType { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x1B86AD0 Offset: 0x1B854D0 VA: 0x181B86AD0
	internal void .ctor(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length) { }

	// RVA: 0x1B86BA0 Offset: 0x1B855A0 VA: 0x181B86BA0
	internal void .ctor(ConstructorInfo ctorInfo) { }

	// RVA: 0x43EE90 Offset: 0x43D890 VA: 0x18043EE90
	internal void .ctor(ConstructorInfo ctorInfo, IList<CustomAttributeTypedArgument> ctorArgs, IList<CustomAttributeNamedArgument> namedArgs) { }

	// RVA: 0x1B86370 Offset: 0x1B84D70 VA: 0x181B86370
	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs) { }

	// RVA: 0x1B86380 Offset: 0x1B84D80 VA: 0x181B86380
	private void ResolveArguments() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 4
	public virtual ConstructorInfo get_Constructor() { }

	// RVA: 0x1B86C50 Offset: 0x1B85650 VA: 0x181B86C50 Slot: 5
	public virtual IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	// RVA: 0x1B86C70 Offset: 0x1B85670 VA: 0x181B86C70 Slot: 6
	public virtual IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	// RVA: 0x1B85EA0 Offset: 0x1B848A0 VA: 0x181B85EA0
	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	// RVA: 0x1B85E50 Offset: 0x1B84850 VA: 0x181B85E50
	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	// RVA: 0x1B85D60 Offset: 0x1B84760 VA: 0x181B85D60
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	// RVA: 0x1B85DB0 Offset: 0x1B847B0 VA: 0x181B85DB0
	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	// RVA: 0x1B85E00 Offset: 0x1B84800 VA: 0x181B85E00
	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	// RVA: 0x1B56580 Offset: 0x1B54F80 VA: 0x181B56580
	public Type get_AttributeType() { }

	// RVA: 0x1B864D0 Offset: 0x1B84ED0 VA: 0x181B864D0 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	private static T[] UnboxValues<T>(object[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6F6E0 Offset: 0xE6E0E0 VA: 0x180E6F6E0
	|-CustomAttributeData.UnboxValues<CustomAttributeNamedArgument>
	|
	|-RVA: 0xE6F830 Offset: 0xE6E230 VA: 0x180E6F830
	|-CustomAttributeData.UnboxValues<CustomAttributeTypedArgument>
	|
	|-RVA: 0xE6F960 Offset: 0xE6E360 VA: 0x180E6F960
	|-CustomAttributeData.UnboxValues<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1B857E0 Offset: 0x1B841E0 VA: 0x181B857E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B85EF0 Offset: 0x1B848F0 VA: 0x181B85EF0 Slot: 2
	public override int GetHashCode() { }
}
