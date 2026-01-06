internal static class ConvertUtils // TypeDefIndex: 11125
{
	// Fields
	private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap; // 0x0
	private static readonly TypeInformation[] PrimitiveTypeCodes; // 0x8
	[Nullable(new[] { 1, 0, 1, 1, 2, 2, 2 })]
	private static readonly ThreadSafeStore<StructMultiKey<Type, Type>, Func<object, object>> CastConverters; // 0x10

	// Methods

	// RVA: 0x1D5D9C0 Offset: 0x1D5C3C0 VA: 0x181D5D9C0
	public static PrimitiveTypeCode GetTypeCode(Type t) { }

	// RVA: 0x1D5DA20 Offset: 0x1D5C420 VA: 0x181D5DA20
	public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum) { }

	// RVA: 0x1D5DCA0 Offset: 0x1D5C6A0 VA: 0x181D5DCA0
	public static TypeInformation GetTypeInformation(IConvertible convertable) { }

	// RVA: 0x1D5E070 Offset: 0x1D5CA70 VA: 0x181D5E070
	public static bool IsConvertible(Type t) { }

	// RVA: 0x1D5E210 Offset: 0x1D5CC10 VA: 0x181D5E210
	public static TimeSpan ParseTimeSpan(string input) { }

	[NullableContext(2)]
	// RVA: 0x1D5C710 Offset: 0x1D5B110 VA: 0x181D5C710
	private static Func<object, object> CreateCastConverter(StructMultiKey<Type, Type> t) { }

	// RVA: 0x1D5E2A0 Offset: 0x1D5CCA0 VA: 0x181D5E2A0
	internal static BigInteger ToBigInteger(object value) { }

	// RVA: 0x1D5D520 Offset: 0x1D5BF20 VA: 0x181D5D520
	public static object FromBigInteger(BigInteger i, Type targetType) { }

	// RVA: 0x1D5C470 Offset: 0x1D5AE70 VA: 0x181D5C470
	public static object Convert(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0x1D5F2E0 Offset: 0x1D5DCE0 VA: 0x181D5F2E0
	private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x1D5E770 Offset: 0x1D5D170 VA: 0x181D5E770
	private static ConvertUtils.ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x1D5C300 Offset: 0x1D5AD00 VA: 0x181D5C300
	public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0x1D5D2E0 Offset: 0x1D5BCE0 VA: 0x181D5D2E0
	private static object EnsureTypeAssignable(object value, Type initialType, Type targetType) { }

	// RVA: 0x1D5F440 Offset: 0x1D5DE40 VA: 0x181D5F440
	public static bool VersionTryParse(string input, out Version result) { }

	// RVA: 0x1D5E100 Offset: 0x1D5CB00 VA: 0x181D5E100
	public static bool IsInteger(object value) { }

	// RVA: 0x1D5DD40 Offset: 0x1D5C740 VA: 0x181D5DD40
	public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value) { }

	// RVA: 0x1D5DEE0 Offset: 0x1D5C8E0 VA: 0x181D5DEE0
	public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value) { }

	// RVA: 0x1D5C990 Offset: 0x1D5B390 VA: 0x181D5C990
	public static ParseResult DecimalTryParse(char[] chars, int start, int length, out Decimal value) { }

	// RVA: 0x1D5E720 Offset: 0x1D5D120 VA: 0x181D5E720
	public static bool TryConvertGuid(string s, out Guid g) { }

	// RVA: 0x1D5F390 Offset: 0x1D5DD90 VA: 0x181D5F390
	public static bool TryHexTextToInt(char[] text, int start, int end, out int value) { }

	// RVA: 0x1D5F450 Offset: 0x1D5DE50 VA: 0x181D5F450
	private static void .cctor() { }
}
