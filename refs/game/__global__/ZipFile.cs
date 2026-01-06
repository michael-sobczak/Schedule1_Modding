public static class ZipFile // TypeDefIndex: 19234
{
	// Methods

	// RVA: 0x217E190 Offset: 0x217CB90 VA: 0x18217E190
	public static ZipArchive Open(string archiveFileName, ZipArchiveMode mode, Encoding entryNameEncoding) { }

	// RVA: 0x217D3D0 Offset: 0x217BDD0 VA: 0x18217D3D0
	public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory) { }

	// RVA: 0x217DF00 Offset: 0x217C900 VA: 0x18217DF00
	public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName) { }

	// RVA: 0x217E050 Offset: 0x217CA50 VA: 0x18217E050
	public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, Encoding entryNameEncoding) { }

	// RVA: 0x217DF20 Offset: 0x217C920 VA: 0x18217DF20
	public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, Encoding entryNameEncoding, bool overwrite) { }

	// RVA: 0x217D470 Offset: 0x217BE70 VA: 0x18217D470
	private static void DoCreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, Nullable<CompressionLevel> compressionLevel, bool includeBaseDirectory, Encoding entryNameEncoding) { }

	// RVA: 0x217DB70 Offset: 0x217C570 VA: 0x18217DB70
	private static string EntryFromPath(string entry, int offset, int length, ref char[] buffer, bool appendPathSeparator = False) { }

	// RVA: 0x217DA80 Offset: 0x217C480 VA: 0x18217DA80
	private static void EnsureCapacity(ref char[] buffer, int min) { }

	// RVA: 0x217E070 Offset: 0x217CA70 VA: 0x18217E070
	private static bool IsDirEmpty(DirectoryInfo possiblyEmptyDir) { }
}
