internal static class FileSystemEnumerableFactory // TypeDefIndex: 5132
{
	// Fields
	private static readonly char[] s_unixEscapeChars; // 0x0

	// Methods

	// RVA: 0x1C2F060 Offset: 0x1C2DA60 VA: 0x181C2F060
	internal static void NormalizeInputs(ref string directory, ref string expression, EnumerationOptions options) { }

	// RVA: 0x1C2EE10 Offset: 0x1C2D810 VA: 0x181C2EE10
	private static bool MatchesPattern(string expression, ReadOnlySpan<char> name, EnumerationOptions options) { }

	// RVA: 0x1C2FA90 Offset: 0x1C2E490 VA: 0x181C2FA90
	internal static IEnumerable<string> UserFiles(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x1C2F670 Offset: 0x1C2E070 VA: 0x181C2F670
	internal static IEnumerable<string> UserDirectories(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x1C2F880 Offset: 0x1C2E280 VA: 0x181C2F880
	internal static IEnumerable<string> UserEntries(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x1C2E9F0 Offset: 0x1C2D3F0 VA: 0x181C2E9F0
	internal static IEnumerable<FileInfo> FileInfos(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x1C2E7E0 Offset: 0x1C2D1E0 VA: 0x181C2E7E0
	internal static IEnumerable<DirectoryInfo> DirectoryInfos(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x1C2EC00 Offset: 0x1C2D600 VA: 0x181C2EC00
	internal static IEnumerable<FileSystemInfo> FileSystemInfos(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x1C2FCA0 Offset: 0x1C2E6A0 VA: 0x181C2FCA0
	private static void .cctor() { }
}
