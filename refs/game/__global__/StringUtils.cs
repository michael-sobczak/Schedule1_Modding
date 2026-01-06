internal static class StringUtils // TypeDefIndex: 11204
{
	// Fields
	public const string CarriageReturnLineFeed = "\r\n";
	public const string Empty = "";
	public const char CarriageReturn = '\xd';
	public const char LineFeed = '\xa';
	public const char Tab = '\x9';

	// Methods

	[NullableContext(2)]
	// RVA: 0x1D94CC0 Offset: 0x1D936C0 VA: 0x181D94CC0
	public static bool IsNullOrEmpty(string value) { }

	[Extension]
	// RVA: 0x1D94940 Offset: 0x1D93340 VA: 0x181D94940
	public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	[Extension]
	// RVA: 0x1D94A70 Offset: 0x1D93470 VA: 0x181D94A70
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	[Extension]
	// RVA: 0x1D94760 Offset: 0x1D93160 VA: 0x181D94760
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	[Extension]
	[NullableContext(2)]
	// RVA: 0x1D94530 Offset: 0x1D92F30 VA: 0x181D94530
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	[Extension]
	// RVA: 0x1D94480 Offset: 0x1D92E80 VA: 0x181D94480
	private static string FormatWith(string format, IFormatProvider provider, object[] args) { }

	// RVA: 0x1D94CD0 Offset: 0x1D936D0 VA: 0x181D94CD0
	public static bool IsWhiteSpace(string s) { }

	// RVA: 0x1D94380 Offset: 0x1D92D80 VA: 0x181D94380
	public static StringWriter CreateStringWriter(int capacity) { }

	// RVA: 0x1D95010 Offset: 0x1D93A10 VA: 0x181D95010
	public static void ToCharAsUnicode(char c, char[] buffer) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource ForgivingCaseSensitiveFind<TSource>(IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF54A40 Offset: 0xF53440 VA: 0x180F54A40
	|-StringUtils.ForgivingCaseSensitiveFind<object>
	|
	|-RVA: 0xF547B0 Offset: 0xF531B0 VA: 0x180F547B0
	|-StringUtils.ForgivingCaseSensitiveFind<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1D94E20 Offset: 0x1D93820 VA: 0x181D94E20
	public static string ToCamelCase(string s) { }

	// RVA: 0x1D950D0 Offset: 0x1D93AD0 VA: 0x181D950D0
	private static char ToLower(char c) { }

	// RVA: 0x1D95440 Offset: 0x1D93E40 VA: 0x181D95440
	public static string ToSnakeCase(string s) { }

	// RVA: 0x1D950C0 Offset: 0x1D93AC0 VA: 0x181D950C0
	public static string ToKebabCase(string s) { }

	// RVA: 0x1D95160 Offset: 0x1D93B60 VA: 0x181D95160
	private static string ToSeparatedCase(string s, char separator) { }

	// RVA: 0x1D94C20 Offset: 0x1D93620 VA: 0x181D94C20
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x1D94C70 Offset: 0x1D93670 VA: 0x181D94C70
	public static bool IsLowSurrogate(char c) { }

	// RVA: 0x1D94C00 Offset: 0x1D93600 VA: 0x181D94C00
	public static int IndexOf(string s, char c) { }

	// RVA: 0x1D94DC0 Offset: 0x1D937C0 VA: 0x181D94DC0
	public static string Replace(string s, string oldValue, string newValue) { }

	[Extension]
	// RVA: 0x1D94DE0 Offset: 0x1D937E0 VA: 0x181D94DE0
	public static bool StartsWith(string source, char value) { }

	[Extension]
	// RVA: 0x1D94440 Offset: 0x1D92E40 VA: 0x181D94440
	public static bool EndsWith(string source, char value) { }

	[Extension]
	// RVA: 0x1D95450 Offset: 0x1D93E50 VA: 0x181D95450
	public static string Trim(string s, int start, int length) { }
}
