internal static class SharedUtilities // TypeDefIndex: 16608
{
	// Fields
	private static Regex doubleDotRegex1; // 0x0
	private static Encoding ibm437; // 0x8
	private static Encoding utf8; // 0x10

	// Methods

	// RVA: 0x1E36D00 Offset: 0x1E35700 VA: 0x181E36D00
	private static void .cctor() { }

	// RVA: 0x1E35AD0 Offset: 0x1E344D0 VA: 0x181E35AD0
	public static long GetFileLength(string fileName) { }

	[Conditional("NETCF")]
	// RVA: 0x1E36B30 Offset: 0x1E35530 VA: 0x181E36B30
	public static void Workaround_Ladybug318918(Stream s) { }

	// RVA: 0x1E368B0 Offset: 0x1E352B0 VA: 0x181E368B0
	private static string SimplifyFwdSlashPath(string path) { }

	// RVA: 0x1E35DB0 Offset: 0x1E347B0 VA: 0x181E35DB0
	public static string NormalizePathForUseInZipFile(string pathName) { }

	// RVA: 0x1E36A70 Offset: 0x1E35470 VA: 0x181E36A70
	internal static byte[] StringToByteArray(string value, Encoding encoding) { }

	// RVA: 0x1E369F0 Offset: 0x1E353F0 VA: 0x181E369F0
	internal static byte[] StringToByteArray(string value) { }

	// RVA: 0x1E36AA0 Offset: 0x1E354A0 VA: 0x181E36AA0
	internal static string Utf8StringFromBuffer(byte[] buf) { }

	// RVA: 0x1E369A0 Offset: 0x1E353A0 VA: 0x181E369A0
	internal static string StringFromBuffer(byte[] buf, Encoding encoding) { }

	// RVA: 0x1E367F0 Offset: 0x1E351F0 VA: 0x181E367F0
	internal static int ReadSignature(Stream s) { }

	// RVA: 0x1E36600 Offset: 0x1E35000 VA: 0x181E36600
	internal static int ReadEntrySignature(Stream s) { }

	// RVA: 0x1E36790 Offset: 0x1E35190 VA: 0x181E36790
	internal static int ReadInt(Stream s) { }

	// RVA: 0x1E36BB0 Offset: 0x1E355B0 VA: 0x181E36BB0
	private static int _ReadFourBytes(Stream s, string message) { }

	// RVA: 0x1E35700 Offset: 0x1E34100 VA: 0x181E35700
	internal static long FindSignature(Stream stream, int SignatureToFind) { }

	// RVA: 0x1E35160 Offset: 0x1E33B60 VA: 0x181E35160
	internal static DateTime AdjustTime_Reverse(DateTime time) { }

	// RVA: 0x1E35FC0 Offset: 0x1E349C0 VA: 0x181E35FC0
	internal static DateTime PackedToDateTime(int packedDateTime) { }

	// RVA: 0x1E35600 Offset: 0x1E34000 VA: 0x181E35600
	internal static int DateTimeToPacked(DateTime time) { }

	// RVA: 0x1E35320 Offset: 0x1E33D20 VA: 0x181E35320
	public static void CreateAndOpenUniqueTempFile(string dir, out Stream fs, out string filename) { }

	// RVA: 0x1E35C10 Offset: 0x1E34610 VA: 0x181E35C10
	public static string InternalGetTempFileName() { }

	// RVA: 0x1E35990 Offset: 0x1E34390 VA: 0x181E35990
	internal static string GenerateRandomStringImpl(int length, int delta) { }

	// RVA: 0x1E36860 Offset: 0x1E35260 VA: 0x181E36860
	internal static int ReadWithRetry(Stream s, byte[] buffer, int offset, int count, string FileName) { }

	// RVA: 0x1E36B60 Offset: 0x1E35560 VA: 0x181E36B60
	private static uint _HRForException(Exception ex1) { }
}
