internal static class ParameterizedStrings // TypeDefIndex: 3876
{
	// Fields
	[ThreadStatic]
	private static ParameterizedStrings.LowLevelStack _cachedStack; // 0x80000000

	// Methods

	// RVA: 0x1CC6C00 Offset: 0x1CC5600 VA: 0x181CC6C00
	public static string Evaluate(string format, ParameterizedStrings.FormatParam[] args) { }

	// RVA: 0x1CC5F00 Offset: 0x1CC4900 VA: 0x181CC5F00
	private static string EvaluateInternal(string format, ref int pos, ParameterizedStrings.FormatParam[] args, ParameterizedStrings.LowLevelStack stack, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars) { }

	// RVA: 0x1BC4790 Offset: 0x1BC3190 VA: 0x181BC4790
	private static bool AsBool(int i) { }

	// RVA: 0xDA30B0 Offset: 0xDA1AB0 VA: 0x180DA30B0
	private static int AsInt(bool b) { }

	// RVA: 0x1CC71C0 Offset: 0x1CC5BC0 VA: 0x181CC71C0
	private static string StringFromAsciiBytes(byte[] buffer, int offset, int length) { }

	// RVA: 0x1CC72A0 Offset: 0x1CC5CA0 VA: 0x181CC72A0
	private static extern int snprintf(byte* str, IntPtr size, string format, string arg1) { }

	// RVA: 0x1CC7380 Offset: 0x1CC5D80 VA: 0x181CC7380
	private static extern int snprintf(byte* str, IntPtr size, string format, int arg1) { }

	// RVA: 0x1CC6DE0 Offset: 0x1CC57E0 VA: 0x181CC6DE0
	private static string FormatPrintF(string format, object arg) { }

	// RVA: 0x1CC70B0 Offset: 0x1CC5AB0 VA: 0x181CC70B0
	private static ParameterizedStrings.FormatParam[] GetDynamicOrStaticVariables(char c, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars, out int index) { }
}
