internal static class MonoCustomAttrs // TypeDefIndex: 3862
{
	// Fields
	private static Assembly corlib; // 0x0
	[ThreadStatic]
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; // 0x80000000
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; // 0x8

	// Methods

	// RVA: 0x1CC49F0 Offset: 0x1CC33F0 VA: 0x181CC49F0
	private static bool IsUserCattrProvider(object obj) { }

	// RVA: 0x1CC30D0 Offset: 0x1CC1AD0 VA: 0x181CC30D0
	internal static Attribute[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	// RVA: 0x1CC4460 Offset: 0x1CC2E60 VA: 0x181CC4460
	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x1CC42D0 Offset: 0x1CC2CD0 VA: 0x181CC42D0
	private static object[] GetPseudoCustomAttributes(Type type) { }

	// RVA: 0x1CC1ED0 Offset: 0x1CC08D0 VA: 0x181CC1ED0
	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x1CC30E0 Offset: 0x1CC1AE0 VA: 0x181CC30E0
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x1CC3C30 Offset: 0x1CC2630 VA: 0x181CC3C30
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	// RVA: 0x1CC2220 Offset: 0x1CC0C20 VA: 0x181CC2220
	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	// RVA: 0x1CC2F90 Offset: 0x1CC1990 VA: 0x181CC2F90
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, bool inherit = False) { }

	// RVA: 0x1CC2230 Offset: 0x1CC0C30 VA: 0x181CC2230
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x1CC20B0 Offset: 0x1CC0AB0 VA: 0x181CC20B0
	internal static IList<CustomAttributeData> GetCustomAttributesDataBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x1CC3DC0 Offset: 0x1CC27C0 VA: 0x181CC3DC0
	internal static CustomAttributeData[] GetPseudoCustomAttributesData(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x1CC4070 Offset: 0x1CC2A70 VA: 0x181CC4070
	private static CustomAttributeData[] GetPseudoCustomAttributesData(Type type) { }

	// RVA: 0x1CC4720 Offset: 0x1CC3120 VA: 0x181CC4720
	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x1CC4710 Offset: 0x1CC3110 VA: 0x181CC4710
	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	// RVA: 0x1CC16D0 Offset: 0x1CC00D0 VA: 0x181CC16D0
	private static PropertyInfo GetBasePropertyDefinition(RuntimePropertyInfo property) { }

	// RVA: 0x1CC1490 Offset: 0x1CBFE90 VA: 0x181CC1490
	private static EventInfo GetBaseEventDefinition(RuntimeEventInfo evt) { }

	// RVA: 0x1CC1A40 Offset: 0x1CC0440 VA: 0x181CC1A40
	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	// RVA: 0x1CC4C00 Offset: 0x1CC3600 VA: 0x181CC4C00
	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

	// RVA: 0x1CC4E70 Offset: 0x1CC3870 VA: 0x181CC4E70
	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	// RVA: 0x1CC5000 Offset: 0x1CC3A00 VA: 0x181CC5000
	private static void .cctor() { }
}
