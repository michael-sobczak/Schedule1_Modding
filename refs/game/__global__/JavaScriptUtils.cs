internal static class JavaScriptUtils // TypeDefIndex: 11173
{
	// Fields
	internal static readonly bool[] SingleQuoteCharEscapeFlags; // 0x0
	internal static readonly bool[] DoubleQuoteCharEscapeFlags; // 0x8
	internal static readonly bool[] HtmlCharEscapeFlags; // 0x10
	private const int UnicodeTextLength = 6;
	private const string EscapedUnicodeText = "!";

	// Methods

	// RVA: 0x1D6B0D0 Offset: 0x1D69AD0 VA: 0x181D6B0D0
	private static void .cctor() { }

	// RVA: 0x1D691A0 Offset: 0x1D67BA0 VA: 0x181D691A0
	public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar) { }

	// RVA: 0x1D69270 Offset: 0x1D67C70 VA: 0x181D69270
	public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags) { }

	[NullableContext(2)]
	// RVA: 0x1D6A8A0 Offset: 0x1D692A0 VA: 0x181D6A8A0
	public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer) { }

	// RVA: 0x1D69300 Offset: 0x1D67D00 VA: 0x181D69300
	public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0x1D690F0 Offset: 0x1D67AF0 VA: 0x181D690F0
	private static int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0x1D69E70 Offset: 0x1D68870 VA: 0x181D69E70
	public static Task WriteEscapedJavaScriptStringAsync(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x1D6A260 Offset: 0x1D68C60 VA: 0x181D6A260
	private static Task WriteEscapedJavaScriptStringWithDelimitersAsync(TextWriter writer, string s, char delimiter, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JavaScriptUtils.<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13))]
	// RVA: 0x1D6A0E0 Offset: 0x1D68AE0 VA: 0x181D6A0E0
	private static Task WriteEscapedJavaScriptStringWithDelimitersAsync(Task task, TextWriter writer, string s, char delimiter, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JavaScriptUtils.<WriteCharAsync>d__14))]
	// RVA: 0x1D69BD0 Offset: 0x1D685D0 VA: 0x181D69BD0
	public static Task WriteCharAsync(Task task, TextWriter writer, char c, CancellationToken cancellationToken) { }

	// RVA: 0x1D6A610 Offset: 0x1D69010 VA: 0x181D6A610
	private static Task WriteEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JavaScriptUtils.<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16))]
	// RVA: 0x1D69D00 Offset: 0x1D68700 VA: 0x181D69D00
	private static Task WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, int lastWritePosition, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x1D69730 Offset: 0x1D68130 VA: 0x181D69730
	public static bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, out string errorMessage) { }

	// RVA: 0x1D69540 Offset: 0x1D67F40 VA: 0x181D69540
	private static bool TryGetDateConstructorValue(JsonReader reader, out Nullable<long> integer, out string errorMessage) { }
}
