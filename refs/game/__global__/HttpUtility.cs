public sealed class HttpUtility // TypeDefIndex: 16934
{
	// Methods

	// RVA: 0xCDF600 Offset: 0xCDE000 VA: 0x180CDF600
	private static void WriteCharBytes(IList buf, char ch, Encoding e) { }

	// RVA: 0xCDEF80 Offset: 0xCDD980 VA: 0x180CDEF80
	public static string UrlDecode(string s, Encoding e) { }

	// RVA: 0xCDE920 Offset: 0xCDD320 VA: 0x180CDE920
	private static int GetInt(byte b) { }

	// RVA: 0xCDE870 Offset: 0xCDD270 VA: 0x180CDE870
	private static int GetChar(string str, int offset, int length) { }

	// RVA: 0xCDF5D0 Offset: 0xCDDFD0 VA: 0x180CDF5D0
	public static string UrlEncode(string str) { }

	// RVA: 0xCDF330 Offset: 0xCDDD30 VA: 0x180CDF330
	public static string UrlEncode(string s, Encoding Enc) { }

	// RVA: 0xCDF250 Offset: 0xCDDC50 VA: 0x180CDF250
	public static byte[] UrlEncodeToBytes(byte[] bytes, int offset, int count) { }

	// RVA: 0xCDE950 Offset: 0xCDD350 VA: 0x180CDE950
	public static string HtmlDecode(string s) { }

	// RVA: 0xCDEC60 Offset: 0xCDD660 VA: 0x180CDEC60
	public static NameValueCollection ParseQueryString(string query) { }

	// RVA: 0xCDEDF0 Offset: 0xCDD7F0 VA: 0x180CDEDF0
	public static NameValueCollection ParseQueryString(string query, Encoding encoding) { }

	// RVA: 0xCDEAD0 Offset: 0xCDD4D0 VA: 0x180CDEAD0
	internal static void ParseQueryString(string query, Encoding encoding, NameValueCollection result) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
