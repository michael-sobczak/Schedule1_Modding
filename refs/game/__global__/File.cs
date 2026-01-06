public static class File // TypeDefIndex: 5081
{
	// Methods

	// RVA: 0x1C31CD0 Offset: 0x1C306D0 VA: 0x181C31CD0
	public static StreamReader OpenText(string path) { }

	// RVA: 0x1C30BB0 Offset: 0x1C2F5B0 VA: 0x181C30BB0
	public static void Copy(string sourceFileName, string destFileName, bool overwrite) { }

	// RVA: 0x1C30DC0 Offset: 0x1C2F7C0 VA: 0x181C30DC0
	public static void Delete(string path) { }

	// RVA: 0x1C30EA0 Offset: 0x1C2F8A0 VA: 0x181C30EA0
	public static bool Exists(string path) { }

	// RVA: 0x1C31E00 Offset: 0x1C30800 VA: 0x181C31E00
	public static FileStream Open(string path, FileMode mode) { }

	// RVA: 0x1C31EA0 Offset: 0x1C308A0 VA: 0x181C31EA0
	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share) { }

	// RVA: 0x1C30FC0 Offset: 0x1C2F9C0 VA: 0x181C30FC0
	public static DateTime GetCreationTime(string path) { }

	// RVA: 0x1C310A0 Offset: 0x1C2FAA0 VA: 0x181C310A0
	public static DateTime GetLastAccessTime(string path) { }

	// RVA: 0x1C329A0 Offset: 0x1C313A0 VA: 0x181C329A0
	public static void SetLastWriteTime(string path, DateTime lastWriteTime) { }

	// RVA: 0x1C31180 Offset: 0x1C2FB80 VA: 0x181C31180
	public static DateTime GetLastWriteTime(string path) { }

	// RVA: 0x1C327D0 Offset: 0x1C311D0 VA: 0x181C327D0
	public static void SetAttributes(string path, FileAttributes fileAttributes) { }

	// RVA: 0x1C31C50 Offset: 0x1C30650 VA: 0x181C31C50
	public static FileStream OpenRead(string path) { }

	// RVA: 0x1C31D80 Offset: 0x1C30780 VA: 0x181C31D80
	public static FileStream OpenWrite(string path) { }

	// RVA: 0x1C326F0 Offset: 0x1C310F0 VA: 0x181C326F0
	public static string ReadAllText(string path) { }

	// RVA: 0x1C31450 Offset: 0x1C2FE50 VA: 0x181C31450
	private static string InternalReadAllText(string path, Encoding encoding) { }

	// RVA: 0x1C32D20 Offset: 0x1C31720 VA: 0x181C32D20
	public static void WriteAllText(string path, string contents) { }

	// RVA: 0x1C323B0 Offset: 0x1C30DB0 VA: 0x181C323B0
	public static byte[] ReadAllBytes(string path) { }

	// RVA: 0x1C31F40 Offset: 0x1C30940 VA: 0x181C31F40
	private static byte[] ReadAllBytesUnknownLength(FileStream fs) { }

	// RVA: 0x1C32A80 Offset: 0x1C31480 VA: 0x181C32A80
	public static void WriteAllBytes(string path, byte[] bytes) { }

	// RVA: 0x1C31560 Offset: 0x1C2FF60 VA: 0x181C31560
	private static void InternalWriteAllBytes(string path, byte[] bytes) { }

	// RVA: 0x1C32610 Offset: 0x1C31010 VA: 0x181C32610
	public static string[] ReadAllLines(string path) { }

	// RVA: 0x1C31260 Offset: 0x1C2FC60 VA: 0x181C31260
	private static string[] InternalReadAllLines(string path, Encoding encoding) { }

	// RVA: 0x1C32BB0 Offset: 0x1C315B0 VA: 0x181C32BB0
	public static void WriteAllLines(string path, string[] contents) { }

	// RVA: 0x1C32BB0 Offset: 0x1C315B0 VA: 0x181C32BB0
	public static void WriteAllLines(string path, IEnumerable<string> contents) { }

	// RVA: 0x1C316B0 Offset: 0x1C300B0 VA: 0x181C316B0
	private static void InternalWriteAllLines(TextWriter writer, IEnumerable<string> contents) { }

	// RVA: 0x1C319D0 Offset: 0x1C303D0 VA: 0x181C319D0
	public static void Move(string sourceFileName, string destFileName) { }
}
