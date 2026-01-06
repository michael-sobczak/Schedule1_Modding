internal static class AsyncUtils // TypeDefIndex: 11111
{
	// Fields
	public static readonly Task<bool> False; // 0x0
	public static readonly Task<bool> True; // 0x8
	internal static readonly Task CompletedTask; // 0x10

	// Methods

	[Extension]
	// RVA: 0x1D58530 Offset: 0x1D56F30 VA: 0x181D58530
	internal static Task<bool> ToAsync(bool value) { }

	[Extension]
	[NullableContext(2)]
	// RVA: 0x1D58260 Offset: 0x1D56C60 VA: 0x181D58260
	public static Task CancelIfRequestedAsync(CancellationToken cancellationToken) { }

	[Extension]
	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public static Task<T> CancelIfRequestedAsync<T>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE56210 Offset: 0xE54C10 VA: 0x180E56210
	|-AsyncUtils.CancelIfRequestedAsync<Nullable<bool>>
	|
	|-RVA: 0xE56370 Offset: 0xE54D70 VA: 0x180E56370
	|-AsyncUtils.CancelIfRequestedAsync<Nullable<DateTime>>
	|
	|-RVA: 0xE56160 Offset: 0xE54B60 VA: 0x180E56160
	|-AsyncUtils.CancelIfRequestedAsync<Nullable<DateTimeOffset>>
	|
	|-RVA: 0xE560B0 Offset: 0xE54AB0 VA: 0x180E560B0
	|-AsyncUtils.CancelIfRequestedAsync<Nullable<Decimal>>
	|
	|-RVA: 0xE562C0 Offset: 0xE54CC0 VA: 0x180E562C0
	|-AsyncUtils.CancelIfRequestedAsync<Nullable<int>>
	|
	|-RVA: 0xE55F50 Offset: 0xE54950 VA: 0x180E55F50
	|-AsyncUtils.CancelIfRequestedAsync<bool>
	|
	|-RVA: 0xE56420 Offset: 0xE54E20 VA: 0x180E56420
	|-AsyncUtils.CancelIfRequestedAsync<object>
	|
	|-RVA: 0xE56000 Offset: 0xE54A00 VA: 0x180E56000
	|-AsyncUtils.CancelIfRequestedAsync<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1D582F0 Offset: 0x1D56CF0 VA: 0x181D582F0
	public static Task FromCanceled(CancellationToken cancellationToken) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static Task<T> FromCanceled<T>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE56D40 Offset: 0xE55740 VA: 0x180E56D40
	|-AsyncUtils.FromCanceled<Nullable<bool>>
	|
	|-RVA: 0xE570A0 Offset: 0xE55AA0 VA: 0x180E570A0
	|-AsyncUtils.FromCanceled<Nullable<DateTime>>
	|
	|-RVA: 0xE56B90 Offset: 0xE55590 VA: 0x180E56B90
	|-AsyncUtils.FromCanceled<Nullable<DateTimeOffset>>
	|
	|-RVA: 0xE569E0 Offset: 0xE553E0 VA: 0x180E569E0
	|-AsyncUtils.FromCanceled<Nullable<Decimal>>
	|
	|-RVA: 0xE56EF0 Offset: 0xE558F0 VA: 0x180E56EF0
	|-AsyncUtils.FromCanceled<Nullable<int>>
	|
	|-RVA: 0xE564D0 Offset: 0xE54ED0 VA: 0x180E564D0
	|-AsyncUtils.FromCanceled<bool>
	|
	|-RVA: 0xE56830 Offset: 0xE55230 VA: 0x180E56830
	|-AsyncUtils.FromCanceled<int>
	|
	|-RVA: 0xE57250 Offset: 0xE55C50 VA: 0x180E57250
	|-AsyncUtils.FromCanceled<object>
	|
	|-RVA: 0xE56680 Offset: 0xE55080 VA: 0x180E56680
	|-AsyncUtils.FromCanceled<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1D58760 Offset: 0x1D57160 VA: 0x181D58760
	public static Task WriteAsync(TextWriter writer, char value, CancellationToken cancellationToken) { }

	[Extension]
	// RVA: 0x1D585C0 Offset: 0x1D56FC0 VA: 0x181D585C0
	public static Task WriteAsync(TextWriter writer, string value, CancellationToken cancellationToken) { }

	[Extension]
	// RVA: 0x1D58680 Offset: 0x1D57080 VA: 0x181D58680
	public static Task WriteAsync(TextWriter writer, char[] value, int start, int count, CancellationToken cancellationToken) { }

	[Extension]
	// RVA: 0x1D58440 Offset: 0x1D56E40 VA: 0x181D58440
	public static Task<int> ReadAsync(TextReader reader, char[] buffer, int index, int count, CancellationToken cancellationToken) { }

	[Extension]
	// RVA: 0x1D58410 Offset: 0x1D56E10 VA: 0x181D58410
	public static bool IsCompletedSuccessfully(Task task) { }

	// RVA: 0x1D58820 Offset: 0x1D57220 VA: 0x181D58820
	private static void .cctor() { }
}
