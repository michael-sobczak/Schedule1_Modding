public class HttpEncoder // TypeDefIndex: 16932
{
	// Fields
	private static char[] hexChars; // 0x0
	private static object entitiesLock; // 0x8
	private static SortedDictionary<string, char> entities; // 0x10
	private static HttpEncoder defaultEncoder; // 0x18
	private static HttpEncoder currentEncoder; // 0x20

	// Properties
	private static IDictionary<string, char> Entities { get; }
	public static HttpEncoder Current { get; set; }
	public static HttpEncoder Default { get; }

	// Methods

	// RVA: 0xCDE490 Offset: 0xCDCE90 VA: 0x180CDE490
	private static IDictionary<string, char> get_Entities() { }

	// RVA: 0xCDE3F0 Offset: 0xCDCDF0 VA: 0x180CDE3F0
	public static HttpEncoder get_Current() { }

	// RVA: 0xCDE5D0 Offset: 0xCDCFD0 VA: 0x180CDE5D0
	public static void set_Current(HttpEncoder value) { }

	// RVA: 0xCDE440 Offset: 0xCDCE40 VA: 0x180CDE440
	public static HttpEncoder get_Default() { }

	// RVA: 0xCD8790 Offset: 0xCD7190 VA: 0x180CD8790 Slot: 4
	protected internal virtual void HeaderNameValueEncode(string headerName, string headerValue, out string encodedHeaderName, out string encodedHeaderValue) { }

	// RVA: 0xCDD8E0 Offset: 0xCDC2E0 VA: 0x180CDD8E0
	private static void StringBuilderAppend(string s, ref StringBuilder sb) { }

	// RVA: 0xCD8600 Offset: 0xCD7000 VA: 0x180CD8600
	private static string EncodeHeaderString(string input) { }

	// RVA: 0xCD8860 Offset: 0xCD7260 VA: 0x180CD8860 Slot: 5
	protected internal virtual void HtmlAttributeEncode(string value, TextWriter output) { }

	// RVA: 0xCD9370 Offset: 0xCD7D70 VA: 0x180CD9370 Slot: 6
	protected internal virtual void HtmlDecode(string value, TextWriter output) { }

	// RVA: 0xCD97D0 Offset: 0xCD81D0 VA: 0x180CD97D0 Slot: 7
	protected internal virtual void HtmlEncode(string value, TextWriter output) { }

	// RVA: 0xCDDED0 Offset: 0xCDC8D0 VA: 0x180CDDED0 Slot: 8
	protected internal virtual byte[] UrlEncode(byte[] bytes, int offset, int count) { }

	// RVA: 0xCDE160 Offset: 0xCDCB60 VA: 0x180CDE160 Slot: 9
	protected internal virtual string UrlPathEncode(string value) { }

	// RVA: 0xCDDCA0 Offset: 0xCDC6A0 VA: 0x180CDDCA0
	internal static byte[] UrlEncodeToBytes(byte[] bytes, int offset, int count) { }

	// RVA: 0xCD9430 Offset: 0xCD7E30 VA: 0x180CD9430
	internal static string HtmlEncode(string s) { }

	// RVA: 0xCD8930 Offset: 0xCD7330 VA: 0x180CD8930
	internal static string HtmlAttributeEncode(string s) { }

	// RVA: 0xCD8B30 Offset: 0xCD7530 VA: 0x180CD8B30
	internal static string HtmlDecode(string s) { }

	// RVA: 0xCDD8B0 Offset: 0xCDC2B0 VA: 0x180CDD8B0
	internal static bool NotEncoded(char c) { }

	// RVA: 0xCDD970 Offset: 0xCDC370 VA: 0x180CDD970
	internal static void UrlEncodeChar(char c, Stream result, bool isUnicode) { }

	// RVA: 0xCDDF40 Offset: 0xCDC940 VA: 0x180CDDF40
	internal static void UrlPathEncodeChar(char c, Stream result) { }

	// RVA: 0xCD9890 Offset: 0xCD8290 VA: 0x180CD9890
	private static void InitEntities() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0xCDE2A0 Offset: 0xCDCCA0 VA: 0x180CDE2A0
	private static void .cctor() { }
}
