internal static class UINumericFieldsUtils // TypeDefIndex: 11881
{
	// Fields
	public static readonly string k_AllowedCharactersForFloat; // 0x0
	public static readonly string k_AllowedCharactersForInt; // 0x8
	public static readonly string k_DoubleFieldFormatString; // 0x10
	public static readonly string k_FloatFieldFormatString; // 0x18
	public static readonly string k_IntFieldFormatString; // 0x20

	// Methods

	// RVA: 0x2CCFE50 Offset: 0x2CCE850 VA: 0x182CCFE50
	public static bool TryConvertStringToDouble(string str, out double value, out ExpressionEvaluator.Expression expr) { }

	// RVA: 0x2CCFFE0 Offset: 0x2CCE9E0 VA: 0x182CCFFE0
	public static bool TryConvertStringToDouble(string str, string initialValueAsString, out double value, out ExpressionEvaluator.Expression expression) { }

	// RVA: 0x2CD00F0 Offset: 0x2CCEAF0 VA: 0x182CD00F0
	public static bool TryConvertStringToFloat(string str, string initialValueAsString, out float value, out ExpressionEvaluator.Expression expression) { }

	// RVA: 0x2CD0450 Offset: 0x2CCEE50 VA: 0x182CD0450
	public static bool TryConvertStringToLong(string str, out long value, out ExpressionEvaluator.Expression expr) { }

	// RVA: 0x2CD0300 Offset: 0x2CCED00 VA: 0x182CD0300
	public static bool TryConvertStringToLong(string str, string initialValueAsString, out long value, out ExpressionEvaluator.Expression expression) { }

	// RVA: 0x2CD0570 Offset: 0x2CCEF70 VA: 0x182CD0570
	public static bool TryConvertStringToULong(string str, out ulong value, out ExpressionEvaluator.Expression expr) { }

	// RVA: 0x2CD05F0 Offset: 0x2CCEFF0 VA: 0x182CD05F0
	public static bool TryConvertStringToULong(string str, string initialValueAsString, out ulong value, out ExpressionEvaluator.Expression expression) { }

	// RVA: 0x2CD0260 Offset: 0x2CCEC60 VA: 0x182CD0260
	public static bool TryConvertStringToInt(string str, string initialValueAsString, out int value, out ExpressionEvaluator.Expression expression) { }

	// RVA: 0x2CD04D0 Offset: 0x2CCEED0 VA: 0x182CD04D0
	public static bool TryConvertStringToUInt(string str, string initialValueAsString, out uint value, out ExpressionEvaluator.Expression expression) { }

	// RVA: 0x2CD0740 Offset: 0x2CCF140 VA: 0x182CD0740
	private static void .cctor() { }
}
