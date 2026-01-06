internal static class ZipOutput // TypeDefIndex: 16624
{
	// Methods

	// RVA: 0x1E5A1D0 Offset: 0x1E58BD0 VA: 0x181E5A1D0
	public static bool WriteCentralDirectoryStructure(Stream s, ICollection<ZipEntry> entries, uint numSegments, Zip64Option zip64, string comment, ZipContainer container) { }

	// RVA: 0x1E5A070 Offset: 0x1E58A70 VA: 0x181E5A070
	private static Encoding GetEncoding(ZipContainer container, string t) { }

	// RVA: 0x1E598C0 Offset: 0x1E582C0 VA: 0x181E598C0
	private static byte[] GenCentralDirectoryFooter(long StartOfCentralDirectory, long EndOfCentralDirectory, Zip64Option zip64, int entryCount, string comment, ZipContainer container) { }

	// RVA: 0x1E59DD0 Offset: 0x1E587D0 VA: 0x181E59DD0
	private static byte[] GenZip64EndOfCentralDirectory(long StartOfCentralDirectory, long EndOfCentralDirectory, int entryCount, uint numSegments) { }

	// RVA: 0x1E596E0 Offset: 0x1E580E0 VA: 0x181E596E0
	private static int CountEntries(ICollection<ZipEntry> _entries) { }
}
