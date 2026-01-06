internal static class StringHelpers // TypeDefIndex: 7851
{
	// Methods

	[Extension]
	// RVA: 0x27932E0 Offset: 0x2791CE0 VA: 0x1827932E0
	public static string Escape(string str, string chars = "\n\t\r\\\"", string replacements = "ntr\\\"") { }

	[Extension]
	// RVA: 0x2793F70 Offset: 0x2792970 VA: 0x182793F70
	public static string Unescape(string str, string chars = "ntr\\\"", string replacements = "\n\t\r\\\"") { }

	[Extension]
	// RVA: 0x2793240 Offset: 0x2791C40 VA: 0x182793240
	public static bool Contains(string str, char ch) { }

	[Extension]
	// RVA: 0x2793210 Offset: 0x2791C10 VA: 0x182793210
	public static bool Contains(string str, string text, StringComparison comparison) { }

	[Extension]
	// RVA: 0x27937D0 Offset: 0x27921D0 VA: 0x1827937D0
	public static string GetPlural(string str) { }

	// RVA: 0x2793A20 Offset: 0x2792420 VA: 0x182793A20
	public static string NicifyMemorySize(long numBytes) { }

	// RVA: 0x2793640 Offset: 0x2792040 VA: 0x182793640
	public static bool FromNicifiedMemorySize(string text, out long result, long defaultMultiplier = 1) { }

	[Extension]
	// RVA: 0x2793270 Offset: 0x2791C70 VA: 0x182793270
	public static int CountOccurrences(string str, char ch) { }

	[IteratorStateMachine(typeof(StringHelpers.<Tokenize>d__8))]
	[Extension]
	// RVA: 0x2793EF0 Offset: 0x27928F0 VA: 0x182793EF0
	public static IEnumerable<Substring> Tokenize(string str) { }

	[Extension]
	[IteratorStateMachine(typeof(StringHelpers.<Split>d__9))]
	// RVA: 0x2793E60 Offset: 0x2792860 VA: 0x182793E60
	public static IEnumerable<string> Split(string str, Func<char, bool> predicate) { }

	// RVA: -1 Offset: -1
	public static string Join<TValue>(string separator, TValue[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF53B00 Offset: 0xF52500 VA: 0x180F53B00
	|-StringHelpers.Join<object>
	|
	|-RVA: 0xF53340 Offset: 0xF51D40 VA: 0x180F53340
	|-StringHelpers.Join<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static string Join<TValue>(IEnumerable<TValue> values, string separator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF537D0 Offset: 0xF521D0 VA: 0x180F537D0
	|-StringHelpers.Join<object>
	|
	|-RVA: 0xF53390 Offset: 0xF51D90 VA: 0x180F53390
	|-StringHelpers.Join<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static string MakeUniqueName<TExisting>(string baseName, IEnumerable<TExisting> existingSet, Func<TExisting, string> getNameFunc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF54400 Offset: 0xF52E00 VA: 0x180F54400
	|-StringHelpers.MakeUniqueName<object>
	|
	|-RVA: 0xF53F80 Offset: 0xF52980 VA: 0x180F53F80
	|-StringHelpers.MakeUniqueName<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF53B50 Offset: 0xF52550 VA: 0x180F53B50
	|-StringHelpers.MakeUniqueName<InputControlLayout.ControlItem>
	*/

	// RVA: 0x2792F80 Offset: 0x2791980 VA: 0x182792F80
	public static bool CharacterSeparatedListsHaveAtLeastOneCommonElement(string firstList, string secondList, char separator) { }

	// RVA: 0x2793BC0 Offset: 0x27925C0 VA: 0x182793BC0
	public static int ParseInt(string str, int pos) { }

	// RVA: 0x2794380 Offset: 0x2792D80 VA: 0x182794380
	public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters) { }

	// RVA: 0x27941C0 Offset: 0x2792BC0 VA: 0x1827941C0
	public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters, ref uint offset) { }

	// RVA: 0x2793D60 Offset: 0x2792760 VA: 0x182793D60
	public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize) { }

	// RVA: 0x2793C50 Offset: 0x2792650 VA: 0x182793C50
	public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize, ref uint offset) { }

	[Extension]
	// RVA: 0x27939A0 Offset: 0x27923A0 VA: 0x1827939A0
	public static bool IsPrintable(char ch) { }

	[Extension]
	// RVA: 0x27940D0 Offset: 0x2792AD0 VA: 0x1827940D0
	public static string WithAllWhitespaceStripped(string str) { }

	[Extension]
	// RVA: 0x2793950 Offset: 0x2792350 VA: 0x182793950
	public static bool InvariantEqualsIgnoreCase(string left, string right) { }

	// RVA: 0x2793440 Offset: 0x2791E40 VA: 0x182793440
	public static string ExpandTemplateString(string template, Func<string, string> mapFunc) { }
}
