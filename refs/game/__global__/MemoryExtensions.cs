public static class MemoryExtensions // TypeDefIndex: 3689
{
	// Methods

	[Extension]
	// RVA: 0x1C698D0 Offset: 0x1C682D0 VA: 0x181C698D0
	internal static bool EqualsOrdinal(ReadOnlySpan<char> span, ReadOnlySpan<char> value) { }

	[Extension]
	// RVA: 0x1C69820 Offset: 0x1C68220 VA: 0x181C69820
	internal static bool EqualsOrdinalIgnoreCase(ReadOnlySpan<char> span, ReadOnlySpan<char> value) { }

	[Extension]
	// RVA: 0x1C693B0 Offset: 0x1C67DB0 VA: 0x181C693B0
	internal static bool Contains(ReadOnlySpan<char> source, char value) { }

	[Extension]
	// RVA: 0x1C69960 Offset: 0x1C68360 VA: 0x181C69960
	public static int ToUpperInvariant(ReadOnlySpan<char> source, Span<char> destination) { }

	[Extension]
	// RVA: 0x1C69430 Offset: 0x1C67E30 VA: 0x181C69430
	public static bool EndsWith(ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static Span<T> AsSpan<T>(T[] array, int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFE560 Offset: 0xEFCF60 VA: 0x180EFE560
	|-MemoryExtensions.AsSpan<byte>
	|
	|-RVA: 0xEFE780 Offset: 0xEFD180 VA: 0x180EFE780
	|-MemoryExtensions.AsSpan<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1C691D0 Offset: 0x1C67BD0 VA: 0x181C691D0
	public static ReadOnlySpan<char> AsSpan(string text) { }

	[Extension]
	// RVA: 0x1C69310 Offset: 0x1C67D10 VA: 0x181C69310
	public static ReadOnlySpan<char> AsSpan(string text, int start) { }

	[Extension]
	// RVA: 0x1C69250 Offset: 0x1C67C50 VA: 0x181C69250
	public static ReadOnlySpan<char> AsSpan(string text, int start, int length) { }

	[Extension]
	// RVA: 0x1C69D60 Offset: 0x1C68760 VA: 0x181C69D60
	public static ReadOnlySpan<char> Trim(ReadOnlySpan<char> span) { }

	[Extension]
	// RVA: 0x1C69C30 Offset: 0x1C68630 VA: 0x181C69C30
	public static ReadOnlySpan<char> TrimStart(ReadOnlySpan<char> span) { }

	[Extension]
	// RVA: 0x1C69B20 Offset: 0x1C68520 VA: 0x181C69B20
	public static ReadOnlySpan<char> TrimEnd(ReadOnlySpan<char> span) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOf<T>(ReadOnlySpan<T> span, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFEFD0 Offset: 0xEFD9D0 VA: 0x180EFEFD0
	|-MemoryExtensions.IndexOf<char>
	|
	|-RVA: 0xEFF120 Offset: 0xEFDB20 VA: 0x180EFF120
	|-MemoryExtensions.IndexOf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOfAny<T>(ReadOnlySpan<T> span, ReadOnlySpan<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFED30 Offset: 0xEFD730 VA: 0x180EFED30
	|-MemoryExtensions.IndexOfAny<char>
	|
	|-RVA: 0xEFEE20 Offset: 0xEFD820 VA: 0x180EFEE20
	|-MemoryExtensions.IndexOfAny<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<T>(ReadOnlySpan<T> span, ReadOnlySpan<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFF3C0 Offset: 0xEFDDC0 VA: 0x180EFF3C0
	|-MemoryExtensions.SequenceEqual<char>
	|
	|-RVA: 0xEFF470 Offset: 0xEFDE70 VA: 0x180EFF470
	|-MemoryExtensions.SequenceEqual<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool StartsWith<T>(ReadOnlySpan<T> span, ReadOnlySpan<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFF670 Offset: 0xEFE070 VA: 0x180EFF670
	|-MemoryExtensions.StartsWith<char>
	|
	|-RVA: 0xEFF720 Offset: 0xEFE120 VA: 0x180EFF720
	|-MemoryExtensions.StartsWith<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool EndsWith<T>(ReadOnlySpan<T> span, ReadOnlySpan<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFEA40 Offset: 0xEFD440 VA: 0x180EFEA40
	|-MemoryExtensions.EndsWith<char>
	|
	|-RVA: 0xEFEB00 Offset: 0xEFD500 VA: 0x180EFEB00
	|-MemoryExtensions.EndsWith<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Span<T> AsSpan<T>(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFE5E0 Offset: 0xEFCFE0 VA: 0x180EFE5E0
	|-MemoryExtensions.AsSpan<byte>
	|
	|-RVA: 0xEFE670 Offset: 0xEFD070 VA: 0x180EFE670
	|-MemoryExtensions.AsSpan<char>
	|
	|-RVA: 0xEFE700 Offset: 0xEFD100 VA: 0x180EFE700
	|-MemoryExtensions.AsSpan<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void CopyTo<T>(T[] source, Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFE920 Offset: 0xEFD320 VA: 0x180EFE920
	|-MemoryExtensions.CopyTo<byte>
	|
	|-RVA: 0xEFE9B0 Offset: 0xEFD3B0 VA: 0x180EFE9B0
	|-MemoryExtensions.CopyTo<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static bool IsTypeComparableAsBytes<T>(out ulong size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDA160 Offset: 0xED8B60 VA: 0x180EDA160
	|-MemoryExtensions.IsTypeComparableAsBytes<char>
	|-MemoryExtensions.IsTypeComparableAsBytes<__Il2CppFullySharedGenericType>
	*/
}
