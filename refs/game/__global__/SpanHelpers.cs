internal static class SpanHelpers // TypeDefIndex: 3723
{
	// Methods

	// RVA: 0x1C87340 Offset: 0x1C85D40 VA: 0x181C87340
	public static int IndexOfAny(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength) { }

	// RVA: 0x1C877A0 Offset: 0x1C861A0 VA: 0x181C877A0
	public static int IndexOf(ref byte searchSpace, byte value, int length) { }

	// RVA: 0x1C88510 Offset: 0x1C86F10 VA: 0x181C88510
	public static bool SequenceEqual(ref byte first, ref byte second, ulong length) { }

	// RVA: 0x1C880F0 Offset: 0x1C86AF0 VA: 0x181C880F0
	public static int SequenceCompareTo(ref char first, int firstLength, ref char second, int secondLength) { }

	// RVA: 0x1C873C0 Offset: 0x1C85DC0 VA: 0x181C873C0
	public static int IndexOf(ref char searchSpace, char value, int length) { }

	// RVA: 0x1C87A40 Offset: 0x1C86440 VA: 0x181C87A40
	public static int LastIndexOf(ref char searchSpace, char value, int length) { }

	// RVA: 0x1C87E40 Offset: 0x1C86840 VA: 0x181C87E40
	private static int LocateFirstFoundChar(Vector<ushort> match) { }

	// RVA: 0x1C87E20 Offset: 0x1C86820 VA: 0x181C87E20
	private static int LocateFirstFoundChar(ulong match) { }

	// RVA: 0x1C87F90 Offset: 0x1C86990 VA: 0x181C87F90
	private static int LocateLastFoundChar(Vector<ushort> match) { }

	// RVA: 0x1C880D0 Offset: 0x1C86AD0 VA: 0x181C880D0
	private static int LocateLastFoundChar(ulong match) { }

	// RVA: -1 Offset: -1
	public static int IndexOf<T>(ref T searchSpace, T value, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4EE70 Offset: 0xF4D870 VA: 0x180F4EE70
	|-SpanHelpers.IndexOf<char>
	|
	|-RVA: 0xF4F300 Offset: 0xF4DD00 VA: 0x180F4F300
	|-SpanHelpers.IndexOf<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int IndexOfAny<T>(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4EC40 Offset: 0xF4D640 VA: 0x180F4EC40
	|-SpanHelpers.IndexOfAny<char>
	|
	|-RVA: 0xF4ECF0 Offset: 0xF4D6F0 VA: 0x180F4ECF0
	|-SpanHelpers.IndexOfAny<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool SequenceEqual<T>(ref T first, ref T second, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF50140 Offset: 0xF4EB40 VA: 0x180F50140
	|-SpanHelpers.SequenceEqual<char>
	|
	|-RVA: 0xF50670 Offset: 0xF4F070 VA: 0x180F50670
	|-SpanHelpers.SequenceEqual<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1C86DF0 Offset: 0x1C857F0 VA: 0x181C86DF0
	public static bool EndsWithCultureHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo) { }

	// RVA: 0x1C87020 Offset: 0x1C85A20 VA: 0x181C87020
	public static bool EndsWithCultureIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo) { }

	// RVA: 0x1C87240 Offset: 0x1C85C40 VA: 0x181C87240
	public static bool EndsWithOrdinalIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value) { }

	// RVA: 0x1C86B90 Offset: 0x1C85590 VA: 0x181C86B90
	public static void ClearWithoutReferences(ref byte b, ulong byteLength) { }

	// RVA: 0x1C86A60 Offset: 0x1C85460 VA: 0x181C86A60
	public static void ClearWithReferences(ref IntPtr ip, ulong pointerSizeLength) { }
}
