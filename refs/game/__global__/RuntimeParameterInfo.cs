internal class RuntimeParameterInfo : ParameterInfo // TypeDefIndex: 4761
{
	// Fields
	internal MarshalAsAttribute marshalAs; // 0x40

	// Properties
	public override object DefaultValue { get; }

	// Methods

	// RVA: 0x1B97640 Offset: 0x1B96040 VA: 0x181B97640
	internal void .ctor(string name, Type type, int position, int attrs, object defaultValue, MemberInfo member, MarshalAsAttribute marshalAs) { }

	// RVA: 0x1B966C0 Offset: 0x1B950C0 VA: 0x181B966C0
	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x1B97770 Offset: 0x1B96170 VA: 0x181B97770
	internal void .ctor(ParameterInfo pinfo, MemberInfo member) { }

	// RVA: 0x1B976E0 Offset: 0x1B960E0 VA: 0x181B976E0
	internal void .ctor(Type type, MemberInfo member, MarshalAsAttribute marshalAs) { }

	// RVA: 0x1B978F0 Offset: 0x1B962F0 VA: 0x181B978F0 Slot: 13
	public override object get_DefaultValue() { }

	// RVA: 0x1B96910 Offset: 0x1B95310 VA: 0x181B96910 Slot: 15
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B968B0 Offset: 0x1B952B0 VA: 0x181B968B0 Slot: 16
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B96960 Offset: 0x1B95360 VA: 0x181B96960
	internal object GetDefaultValueImpl(ParameterInfo pinfo) { }

	// RVA: 0x1B97360 Offset: 0x1B95D60 VA: 0x181B97360 Slot: 14
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1B97040 Offset: 0x1B95A40 VA: 0x181B97040
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x1B96A20 Offset: 0x1B95420 VA: 0x181B96A20
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	// RVA: 0x1B973D0 Offset: 0x1B95DD0 VA: 0x181B973D0
	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }

	// RVA: 0x1B97580 Offset: 0x1B95F80 VA: 0x181B97580
	internal static ParameterInfo New(Type type, MemberInfo member, MarshalAsAttribute marshalAs) { }
}
