public static class JsonConvert // TypeDefIndex: 10988
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField; // 0x0
	public static readonly string True; // 0x8
	public static readonly string False; // 0x10
	public static readonly string Null; // 0x18
	public static readonly string Undefined; // 0x20
	public static readonly string PositiveInfinity; // 0x28
	public static readonly string NegativeInfinity; // 0x30
	public static readonly string NaN; // 0x38

	// Properties
	[Nullable(new[] { 2, 1 })]
	public static Func<JsonSerializerSettings> DefaultSettings { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D0D910 Offset: 0x1D0C310 VA: 0x181D0D910
	public static Func<JsonSerializerSettings> get_DefaultSettings() { }

	[CompilerGenerated]
	// RVA: 0x1D0D960 Offset: 0x1D0C360 VA: 0x181D0D960
	public static void set_DefaultSettings(Func<JsonSerializerSettings> value) { }

	// RVA: 0x1D0D3A0 Offset: 0x1D0BDA0 VA: 0x181D0D3A0
	public static string ToString(DateTime value) { }

	// RVA: 0x1D0CB70 Offset: 0x1D0B570 VA: 0x181D0CB70
	public static string ToString(DateTime value, DateFormatHandling format, DateTimeZoneHandling timeZoneHandling) { }

	// RVA: 0x1D0D400 Offset: 0x1D0BE00 VA: 0x181D0D400
	public static string ToString(DateTimeOffset value) { }

	// RVA: 0x1D0C780 Offset: 0x1D0B180 VA: 0x181D0C780
	public static string ToString(DateTimeOffset value, DateFormatHandling format) { }

	// RVA: 0x1D0CAE0 Offset: 0x1D0B4E0 VA: 0x181D0CAE0
	public static string ToString(bool value) { }

	// RVA: 0x1D0B290 Offset: 0x1D09C90 VA: 0x181D0B290
	public static string ToString(char value) { }

	// RVA: 0x1D0D6C0 Offset: 0x1D0C0C0 VA: 0x181D0D6C0
	public static string ToString(Enum value) { }

	// RVA: 0x1D0B310 Offset: 0x1D09D10 VA: 0x181D0B310
	public static string ToString(int value) { }

	// RVA: 0x1D0CD50 Offset: 0x1D0B750 VA: 0x181D0CD50
	public static string ToString(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D0CDB0 Offset: 0x1D0B7B0 VA: 0x181D0CDB0
	public static string ToString(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D0CE10 Offset: 0x1D0B810 VA: 0x181D0CE10
	public static string ToString(uint value) { }

	// RVA: 0x1D0D280 Offset: 0x1D0BC80 VA: 0x181D0D280
	public static string ToString(long value) { }

	// RVA: 0x1D0AF90 Offset: 0x1D09990 VA: 0x181D0AF90
	private static string ToStringInternal(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D0B230 Offset: 0x1D09C30 VA: 0x181D0B230
	public static string ToString(ulong value) { }

	// RVA: 0x1D0CA20 Offset: 0x1D0B420 VA: 0x181D0CA20
	public static string ToString(float value) { }

	// RVA: 0x1D0D120 Offset: 0x1D0BB20 VA: 0x181D0D120
	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0x1D09CA0 Offset: 0x1D086A0 VA: 0x181D09CA0
	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0x1D0D2E0 Offset: 0x1D0BCE0 VA: 0x181D0D2E0
	public static string ToString(double value) { }

	// RVA: 0x1D0D530 Offset: 0x1D0BF30 VA: 0x181D0D530
	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0x1D09B70 Offset: 0x1D08570 VA: 0x181D09B70
	private static string EnsureDecimalPlace(double value, string text) { }

	// RVA: 0x1D09C40 Offset: 0x1D08640 VA: 0x181D09C40
	private static string EnsureDecimalPlace(string text) { }

	// RVA: 0x1D0C720 Offset: 0x1D0B120 VA: 0x181D0C720
	public static string ToString(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D0D220 Offset: 0x1D0BC20 VA: 0x181D0D220
	public static string ToString(sbyte value) { }

	// RVA: 0x1D0B020 Offset: 0x1D09A20 VA: 0x181D0B020
	public static string ToString(Decimal value) { }

	// RVA: 0x1D0B120 Offset: 0x1D09B20 VA: 0x181D0B120
	public static string ToString(Guid value) { }

	// RVA: 0x1D0D460 Offset: 0x1D0BE60 VA: 0x181D0D460
	internal static string ToString(Guid value, char quoteChar) { }

	// RVA: 0x1D0CFF0 Offset: 0x1D0B9F0 VA: 0x181D0CFF0
	public static string ToString(TimeSpan value) { }

	// RVA: 0x1D0D630 Offset: 0x1D0C030 VA: 0x181D0D630
	internal static string ToString(TimeSpan value, char quoteChar) { }

	// RVA: 0x1D0CE70 Offset: 0x1D0B870 VA: 0x181D0CE70
	public static string ToString(Uri value) { }

	// RVA: 0x1D0C6A0 Offset: 0x1D0B0A0 VA: 0x181D0C6A0
	internal static string ToString(Uri value, char quoteChar) { }

	// RVA: 0x1D0C960 Offset: 0x1D0B360 VA: 0x181D0C960
	public static string ToString(string value) { }

	// RVA: 0x1D0C5A0 Offset: 0x1D0AFA0 VA: 0x181D0C5A0
	public static string ToString(string value, char delimiter) { }

	// RVA: 0x1D0C4C0 Offset: 0x1D0AEC0 VA: 0x181D0C4C0
	public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0x1D0B370 Offset: 0x1D09D70 VA: 0x181D0B370
	public static string ToString(object value) { }

	[DebuggerStepThrough]
	// RVA: 0x1D0A400 Offset: 0x1D08E00 VA: 0x181D0A400
	public static string SerializeObject(object value) { }

	[DebuggerStepThrough]
	// RVA: 0x1D0A4A0 Offset: 0x1D08EA0 VA: 0x181D0A4A0
	public static string SerializeObject(object value, Formatting formatting) { }

	[DebuggerStepThrough]
	// RVA: 0x1D0A2F0 Offset: 0x1D08CF0 VA: 0x181D0A2F0
	public static string SerializeObject(object value, JsonConverter[] converters) { }

	[DebuggerStepThrough]
	// RVA: 0x1D0A620 Offset: 0x1D09020 VA: 0x181D0A620
	public static string SerializeObject(object value, Formatting formatting, JsonConverter[] converters) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: 0x1D0A7D0 Offset: 0x1D091D0 VA: 0x181D0A7D0
	public static string SerializeObject(object value, JsonSerializerSettings settings) { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x1D0A260 Offset: 0x1D08C60 VA: 0x181D0A260
	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x1D0A5A0 Offset: 0x1D08FA0 VA: 0x181D0A5A0
	public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: 0x1D0A700 Offset: 0x1D09100 VA: 0x181D0A700
	public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings) { }

	// RVA: 0x1D0A050 Offset: 0x1D08A50 VA: 0x181D0A050
	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	[DebuggerStepThrough]
	// RVA: 0x1D09180 Offset: 0x1D07B80 VA: 0x181D09180
	public static object DeserializeObject(string value) { }

	[DebuggerStepThrough]
	// RVA: 0x1D08F60 Offset: 0x1D07960 VA: 0x181D08F60
	public static object DeserializeObject(string value, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	// RVA: 0x1D091D0 Offset: 0x1D07BD0 VA: 0x181D091D0
	public static object DeserializeObject(string value, Type type) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public static T DeserializeObject<T>(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE60D0 Offset: 0xEE4AD0 VA: 0x180EE60D0
	|-JsonConvert.DeserializeObject<object>
	|
	|-RVA: 0xEE5EC0 Offset: 0xEE48C0 VA: 0x180EE5EC0
	|-JsonConvert.DeserializeObject<__Il2CppFullySharedGenericType>
	*/

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5CB0 Offset: 0xEE46B0 VA: 0x180EE5CB0
	|-JsonConvert.DeserializeAnonymousType<__Il2CppFullySharedGenericType>
	*/

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject, JsonSerializerSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5BC0 Offset: 0xEE45C0 VA: 0x180EE5BC0
	|-JsonConvert.DeserializeAnonymousType<__Il2CppFullySharedGenericType>
	*/

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public static T DeserializeObject<T>(string value, JsonConverter[] converters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5D90 Offset: 0xEE4790 VA: 0x180EE5D90
	|-JsonConvert.DeserializeObject<__Il2CppFullySharedGenericType>
	*/

	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public static T DeserializeObject<T>(string value, JsonSerializerSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6200 Offset: 0xEE4C00 VA: 0x180EE6200
	|-JsonConvert.DeserializeObject<object>
	|
	|-RVA: 0xEE5FA0 Offset: 0xEE49A0 VA: 0x180EE5FA0
	|-JsonConvert.DeserializeObject<__Il2CppFullySharedGenericType>
	*/

	[DebuggerStepThrough]
	// RVA: 0x1D08E90 Offset: 0x1D07890 VA: 0x181D08E90
	public static object DeserializeObject(string value, Type type, JsonConverter[] converters) { }

	[NullableContext(2)]
	// RVA: 0x1D08FC0 Offset: 0x1D079C0 VA: 0x181D08FC0
	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	// RVA: 0x1D09FF0 Offset: 0x1D089F0 VA: 0x181D09FF0
	public static void PopulateObject(string value, object target) { }

	// RVA: 0x1D09DF0 Offset: 0x1D087F0 VA: 0x181D09DF0
	public static void PopulateObject(string value, object target, JsonSerializerSettings settings) { }

	// RVA: 0x1D0AC40 Offset: 0x1D09640 VA: 0x181D0AC40
	public static string SerializeXmlNode(XmlNode node) { }

	// RVA: 0x1D0AE80 Offset: 0x1D09880 VA: 0x181D0AE80
	public static string SerializeXmlNode(XmlNode node, Formatting formatting) { }

	// RVA: 0x1D0AD70 Offset: 0x1D09770 VA: 0x181D0AD70
	public static string SerializeXmlNode(XmlNode node, Formatting formatting, bool omitRootObject) { }

	// RVA: 0x1D09A90 Offset: 0x1D08490 VA: 0x181D09A90
	public static XmlDocument DeserializeXmlNode(string value) { }

	[NullableContext(2)]
	// RVA: 0x1D09B10 Offset: 0x1D08510 VA: 0x181D09B10
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName) { }

	[NullableContext(2)]
	// RVA: 0x1D096D0 Offset: 0x1D080D0 VA: 0x181D096D0
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute) { }

	[NullableContext(2)]
	// RVA: 0x1D098C0 Offset: 0x1D082C0 VA: 0x181D098C0
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters) { }

	// RVA: 0x1D0A890 Offset: 0x1D09290 VA: 0x181D0A890
	public static string SerializeXNode(XObject node) { }

	// RVA: 0x1D0AB00 Offset: 0x1D09500 VA: 0x181D0AB00
	public static string SerializeXNode(XObject node, Formatting formatting) { }

	// RVA: 0x1D0A9F0 Offset: 0x1D093F0 VA: 0x181D0A9F0
	public static string SerializeXNode(XObject node, Formatting formatting, bool omitRootObject) { }

	// RVA: 0x1D09650 Offset: 0x1D08050 VA: 0x181D09650
	public static XDocument DeserializeXNode(string value) { }

	[NullableContext(2)]
	// RVA: 0x1D09420 Offset: 0x1D07E20 VA: 0x181D09420
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName) { }

	[NullableContext(2)]
	// RVA: 0x1D09230 Offset: 0x1D07C30 VA: 0x181D09230
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute) { }

	[NullableContext(2)]
	// RVA: 0x1D09480 Offset: 0x1D07E80 VA: 0x181D09480
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters) { }

	// RVA: 0x1D0D710 Offset: 0x1D0C110 VA: 0x181D0D710
	private static void .cctor() { }
}
