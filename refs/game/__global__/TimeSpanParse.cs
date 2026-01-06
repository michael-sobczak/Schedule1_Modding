internal static class TimeSpanParse // TypeDefIndex: 4825
{
	// Methods

	// RVA: 0x1BB0930 Offset: 0x1BAF330 VA: 0x181BB0930
	internal static long Pow10(int pow) { }

	// RVA: 0x1BB5C30 Offset: 0x1BB4630 VA: 0x181BB5C30
	private static bool TryTimeToTicks(bool positive, TimeSpanParse.TimeSpanToken days, TimeSpanParse.TimeSpanToken hours, TimeSpanParse.TimeSpanToken minutes, TimeSpanParse.TimeSpanToken seconds, TimeSpanParse.TimeSpanToken fraction, out long result) { }

	// RVA: 0x1BB08F0 Offset: 0x1BAF2F0 VA: 0x181BB08F0
	internal static TimeSpan Parse(ReadOnlySpan<char> input, IFormatProvider formatProvider) { }

	// RVA: 0x1BB4980 Offset: 0x1BB3380 VA: 0x181BB4980
	private static bool TryParseTimeSpan(ReadOnlySpan<char> input, TimeSpanParse.TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1BB0A20 Offset: 0x1BAF420 VA: 0x181BB0A20
	private static bool ProcessTerminalState(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1BB0B80 Offset: 0x1BAF580 VA: 0x181BB0B80
	private static bool ProcessTerminal_DHMSF(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1BB12F0 Offset: 0x1BAFCF0 VA: 0x181BB12F0
	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1BB2EB0 Offset: 0x1BB18B0 VA: 0x181BB2EB0
	private static bool ProcessTerminal_HM_S_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1BB4620 Offset: 0x1BB3020 VA: 0x181BB4620
	private static bool ProcessTerminal_HM(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1BB0FC0 Offset: 0x1BAF9C0 VA: 0x181BB0FC0
	private static bool ProcessTerminal_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }
}
