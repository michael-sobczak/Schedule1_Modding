internal class Mime // TypeDefIndex: 5504
{
	// Fields
	public static Mime Instance; // 0x0
	private string current_file_name; // 0x10
	private string global_result; // 0x18
	private FileStream file_stream; // 0x20
	private byte[] buffer; // 0x28
	private StringDictionary mime_file_cache; // 0x30
	private static object lock_object; // 0x8
	private bool is_zero_file; // 0x38
	private int bytes_read; // 0x3C
	private bool mime_available; // 0x40
	public static NameValueCollection Aliases; // 0x10
	public static NameValueCollection SubClasses; // 0x18
	public static NameValueCollection GlobalPatternsShort; // 0x20
	public static NameValueCollection GlobalPatternsLong; // 0x28
	public static NameValueCollection GlobalLiterals; // 0x30
	public static NameValueCollection GlobalSufPref; // 0x38
	public static ArrayList Matches80Plus; // 0x40
	public static ArrayList MatchesBelow80; // 0x48

	// Properties
	public static bool MimeAvailable { get; }

	// Methods

	// RVA: 0x2397030 Offset: 0x2395A30 VA: 0x182397030
	private void .ctor() { }

	// RVA: 0x2396F70 Offset: 0x2395970 VA: 0x182396F70
	private static void .cctor() { }

	// RVA: 0x2397450 Offset: 0x2395E50 VA: 0x182397450
	public static bool get_MimeAvailable() { }

	// RVA: 0x2395D50 Offset: 0x2394750 VA: 0x182395D50
	public static string GetMimeTypeForFile(string filename) { }

	// RVA: 0x2395CE0 Offset: 0x23946E0 VA: 0x182395CE0
	public static string GetMimeAlias(string mimetype) { }

	// RVA: 0x2395940 Offset: 0x2394340 VA: 0x182395940
	public static void CleanFileCache() { }

	// RVA: 0x23961F0 Offset: 0x2394BF0 VA: 0x1823961F0
	private void StartByFileName(string filename) { }

	// RVA: 0x2395E70 Offset: 0x2394870 VA: 0x182395E70
	private void GoByFileName() { }

	// RVA: 0x2395540 Offset: 0x2393F40 VA: 0x182395540
	private bool CheckMatch80Plus() { }

	// RVA: 0x2395A30 Offset: 0x2394430 VA: 0x182395A30
	private bool FastEndsWidth(string input, string value) { }

	// RVA: 0x2395C60 Offset: 0x2394660 VA: 0x182395C60
	private bool FastStartsWith(string input, string value) { }

	// RVA: 0x2395BE0 Offset: 0x23945E0 VA: 0x182395BE0
	private int FastIndexOf(string input, char value) { }

	// RVA: 0x2395AD0 Offset: 0x23944D0 VA: 0x182395AD0
	private int FastIndexOf(string input, string value) { }

	// RVA: 0x23954B0 Offset: 0x2393EB0 VA: 0x1823954B0
	private void CheckGlobalResult() { }

	// RVA: 0x2394DF0 Offset: 0x23937F0 VA: 0x182394DF0
	private bool CheckGlobalPatterns() { }

	// RVA: 0x2395740 Offset: 0x2394140 VA: 0x182395740
	private bool CheckMatchBelow80() { }

	// RVA: 0x2394CE0 Offset: 0x23936E0 VA: 0x182394CE0
	private void CheckForBinaryOrText() { }

	// RVA: 0x23963E0 Offset: 0x2394DE0 VA: 0x1823963E0
	private bool TestMatch(Match match) { }

	// RVA: 0x23965B0 Offset: 0x2394FB0 VA: 0x1823965B0
	private bool TestMatchlet(Matchlet matchlet) { }

	// RVA: 0x2396070 Offset: 0x2394A70 VA: 0x182396070
	private bool OpenFile() { }
}
