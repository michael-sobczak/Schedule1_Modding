public static class ZipFileExtensions // TypeDefIndex: 19235
{
	// Methods

	[Extension]
	// RVA: 0x217CBF0 Offset: 0x217B5F0 VA: 0x18217CBF0
	public static void ExtractToDirectory(ZipArchive source, string destinationDirectoryName, bool overwrite) { }

	// RVA: 0x217C7D0 Offset: 0x217B1D0 VA: 0x18217C7D0
	internal static ZipArchiveEntry DoCreateEntryFromFile(ZipArchive destination, string sourceFileName, string entryName, Nullable<CompressionLevel> compressionLevel) { }

	[Extension]
	// RVA: 0x217D130 Offset: 0x217BB30 VA: 0x18217D130
	public static void ExtractToFile(ZipArchiveEntry source, string destinationFileName, bool overwrite) { }
}
