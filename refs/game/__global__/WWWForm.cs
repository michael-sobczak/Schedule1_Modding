public class WWWForm // TypeDefIndex: 18704
{
	// Fields
	private List<byte[]> formData; // 0x10
	private List<string> fieldNames; // 0x18
	private List<string> fileNames; // 0x20
	private List<string> types; // 0x28
	private byte[] boundary; // 0x30
	private bool containsFiles; // 0x38
	private static byte[] dDash; // 0x0
	private static byte[] crlf; // 0x8
	private static byte[] contentTypeHeader; // 0x10
	private static byte[] dispositionHeader; // 0x18
	private static byte[] endQuote; // 0x20
	private static byte[] fileNameField; // 0x28
	private static byte[] ampersand; // 0x30
	private static byte[] equal; // 0x38

	// Properties
	internal static Encoding DefaultEncoding { get; }
	public Dictionary<string, string> headers { get; }
	public byte[] data { get; }

	// Methods

	// RVA: 0x2F5A9B0 Offset: 0x2F593B0 VA: 0x182F5A9B0
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x2F5A7F0 Offset: 0x2F591F0 VA: 0x182F5A7F0
	public void .ctor() { }

	// RVA: 0x2F5A440 Offset: 0x2F58E40 VA: 0x182F5A440
	public void AddField(string fieldName, string value) { }

	// RVA: 0x2F5A1C0 Offset: 0x2F58BC0 VA: 0x182F5A1C0
	public void AddField(string fieldName, string value, Encoding e) { }

	[ExcludeFromDocs]
	// RVA: 0x2F59E70 Offset: 0x2F58870 VA: 0x182F59E70
	public void AddBinaryData(string fieldName, byte[] contents) { }

	[ExcludeFromDocs]
	// RVA: 0x2F59E50 Offset: 0x2F58850 VA: 0x182F59E50
	public void AddBinaryData(string fieldName, byte[] contents, string fileName) { }

	// RVA: 0x2F59E90 Offset: 0x2F58890 VA: 0x182F59E90
	public void AddBinaryData(string fieldName, byte[] contents, string fileName, string mimeType) { }

	// RVA: 0x2F5B970 Offset: 0x2F5A370 VA: 0x182F5B970
	public Dictionary<string, string> get_headers() { }

	// RVA: 0x2F5A9C0 Offset: 0x2F593C0 VA: 0x182F5A9C0
	public byte[] get_data() { }

	// RVA: 0x2F5A490 Offset: 0x2F58E90 VA: 0x182F5A490
	private static void .cctor() { }
}
