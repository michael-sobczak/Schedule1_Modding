internal static class TimeSpanFormat // TypeDefIndex: 4817
{
	// Fields
	internal static readonly TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals; // 0x0
	internal static readonly TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals; // 0x28

	// Methods

	// RVA: 0x1BAF540 Offset: 0x1BADF40 VA: 0x181BAF540
	private static void AppendNonNegativeInt32(StringBuilder sb, int n, int digits) { }

	// RVA: 0x1BB0650 Offset: 0x1BAF050 VA: 0x181BB0650
	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider) { }

	// RVA: 0x1BB0720 Offset: 0x1BAF120 VA: 0x181BB0720
	internal static bool TryFormat(TimeSpan value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider formatProvider) { }

	// RVA: 0x1BB0350 Offset: 0x1BAED50 VA: 0x181BB0350
	private static StringBuilder FormatToBuilder(TimeSpan value, ReadOnlySpan<char> format, IFormatProvider formatProvider) { }

	// RVA: 0x1BAFE00 Offset: 0x1BAE800 VA: 0x181BAFE00
	private static StringBuilder FormatStandard(TimeSpan value, bool isInvariant, ReadOnlySpan<char> format, TimeSpanFormat.Pattern pattern) { }

	// RVA: 0x1BAF630 Offset: 0x1BAE030 VA: 0x181BAF630
	private static StringBuilder FormatCustomized(TimeSpan value, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, StringBuilder result) { }

	// RVA: 0x1BB0830 Offset: 0x1BAF230 VA: 0x181BB0830
	private static void .cctor() { }
}
