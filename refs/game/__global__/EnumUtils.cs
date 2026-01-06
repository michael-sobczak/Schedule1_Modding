internal static class EnumUtils // TypeDefIndex: 11158
{
	// Fields
	private const char EnumSeparatorChar = '\x2c';
	private const string EnumSeparatorString = ", ";
	[Nullable(new[] { 1, 0, 1, 2, 1 })]
	private static readonly ThreadSafeStore<StructMultiKey<Type, NamingStrategy>, EnumInfo> ValuesAndNamesPerEnum; // 0x0
	private static CamelCaseNamingStrategy _camelCaseNamingStrategy; // 0x8

	// Methods

	// RVA: 0x1D654A0 Offset: 0x1D63EA0 VA: 0x181D654A0
	private static EnumInfo InitializeValuesAndNames(StructMultiKey<Type, NamingStrategy> key) { }

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	public static IList<T> GetFlagsValues<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE83B60 Offset: 0xE82560 VA: 0x180E83B60
	|-EnumUtils.GetFlagsValues<Int32Enum>
	|
	|-RVA: 0xE83530 Offset: 0xE81F30 VA: 0x180E83530
	|-EnumUtils.GetFlagsValues<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x1D66980 Offset: 0x1D65380 VA: 0x181D66980
	public static bool TryToString(Type enumType, object value, bool camelCase, out string name) { }

	// RVA: 0x1D667D0 Offset: 0x1D651D0 VA: 0x181D667D0
	public static bool TryToString(Type enumType, object value, NamingStrategy namingStrategy, out string name) { }

	// RVA: 0x1D65A00 Offset: 0x1D64400 VA: 0x181D65A00
	private static string InternalFlagsFormat(EnumInfo entry, ulong result) { }

	// RVA: 0x1D653E0 Offset: 0x1D63DE0 VA: 0x181D653E0
	public static EnumInfo GetEnumValuesAndNames(Type enumType) { }

	// RVA: 0x1D66440 Offset: 0x1D64E40 VA: 0x181D66440
	private static ulong ToUInt64(object value) { }

	// RVA: 0x1D65C80 Offset: 0x1D64680 VA: 0x181D65C80
	public static object ParseEnum(Type enumType, NamingStrategy namingStrategy, string value, bool disallowNumber) { }

	// RVA: 0x1D65BA0 Offset: 0x1D645A0 VA: 0x181D65BA0
	private static Nullable<int> MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0x1D652E0 Offset: 0x1D63CE0 VA: 0x181D652E0
	private static Nullable<int> FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0x1D66B90 Offset: 0x1D65590 VA: 0x181D66B90
	private static void .cctor() { }
}
