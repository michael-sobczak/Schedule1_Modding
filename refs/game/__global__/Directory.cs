public static class Directory // TypeDefIndex: 5078
{
	// Methods

	// RVA: 0x1C280D0 Offset: 0x1C26AD0 VA: 0x181C280D0
	public static DirectoryInfo CreateDirectory(string path) { }

	// RVA: 0x1C283D0 Offset: 0x1C26DD0 VA: 0x181C283D0
	public static bool Exists(string path) { }

	// RVA: 0x1C28900 Offset: 0x1C27300 VA: 0x181C28900
	public static string[] GetFiles(string path) { }

	// RVA: 0x1C28820 Offset: 0x1C27220 VA: 0x181C28820
	public static string[] GetFiles(string path, string searchPattern) { }

	// RVA: 0x1C289F0 Offset: 0x1C273F0 VA: 0x181C289F0
	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x1C28AA0 Offset: 0x1C274A0 VA: 0x181C28AA0
	public static string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	// RVA: 0x1C28490 Offset: 0x1C26E90 VA: 0x181C28490
	public static string[] GetDirectories(string path) { }

	// RVA: 0x1C285F0 Offset: 0x1C26FF0 VA: 0x181C285F0
	public static string[] GetDirectories(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x1C28580 Offset: 0x1C26F80 VA: 0x181C28580
	public static string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	// RVA: 0x1C28BB0 Offset: 0x1C275B0 VA: 0x181C28BB0
	internal static IEnumerable<string> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options) { }

	// RVA: 0x1C28320 Offset: 0x1C26D20 VA: 0x181C28320
	public static IEnumerable<string> EnumerateFileSystemEntries(string path) { }

	// RVA: 0x1C28300 Offset: 0x1C26D00 VA: 0x181C28300
	public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	// RVA: 0x1C286A0 Offset: 0x1C270A0 VA: 0x181C286A0
	public static string GetDirectoryRoot(string path) { }

	// RVA: 0x1C28DF0 Offset: 0x1C277F0 VA: 0x181C28DF0
	internal static string InternalGetDirectoryRoot(string path) { }

	// RVA: 0x1C28480 Offset: 0x1C26E80 VA: 0x181C28480
	public static string GetCurrentDirectory() { }

	// RVA: 0x1C28EA0 Offset: 0x1C278A0 VA: 0x181C28EA0
	public static void Move(string sourceDirName, string destDirName) { }

	// RVA: 0x1C28260 Offset: 0x1C26C60 VA: 0x181C28260
	public static void Delete(string path, bool recursive) { }

	// RVA: 0x1C28B10 Offset: 0x1C27510 VA: 0x181C28B10
	public static string[] GetLogicalDrives() { }

	// RVA: 0x1C28B20 Offset: 0x1C27520 VA: 0x181C28B20
	internal static string InsecureGetCurrentDirectory() { }
}
