internal static class EnumDataUtility // TypeDefIndex: 11823
{
	// Fields
	private static readonly Dictionary<ValueTuple<EnumDataUtility.CachedType, Type>, EnumData> s_EnumData; // 0x0

	// Methods

	// RVA: 0x2CBC790 Offset: 0x2CBB190 VA: 0x182CBC790
	public static EnumData GetCachedEnumData(Type enumType, EnumDataUtility.CachedType cachedType = 1, Func<string, string> nicifyName) { }

	// RVA: 0x2CBD8E0 Offset: 0x2CBC2E0 VA: 0x182CBD8E0
	internal static void HandleInspectorOrderAttribute(Type enumType, ref EnumData enumData) { }

	// RVA: 0x2CBC240 Offset: 0x2CBAC40 VA: 0x182CBC240
	private static bool CheckObsoleteAddition(FieldInfo field, EnumDataUtility.CachedType cachedType) { }

	// RVA: 0x2CBC660 Offset: 0x2CBB060 VA: 0x182CBC660
	private static string EnumTooltipFromEnumField(FieldInfo field) { }

	// RVA: 0x2CBC380 Offset: 0x2CBAD80 VA: 0x182CBC380
	private static string EnumNameFromEnumField(FieldInfo field, Func<string, string> nicifyName) { }

	// RVA: 0x2CBDF00 Offset: 0x2CBC900 VA: 0x182CBDF00
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2CBDE90 Offset: 0x2CBC890 VA: 0x182CBDE90
	internal static string <EnumNameFromEnumField>g__NicifyName|8_0(ref EnumDataUtility.<>c__DisplayClass8_0 ) { }
}
