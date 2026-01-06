public static class StackTraceUtility // TypeDefIndex: 11844
{
	// Fields
	private static string projectFolder; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2CC95E0 Offset: 0x2CC7FE0 VA: 0x182CC95E0
	internal static void SetProjectFolder(string folder) { }

	[RequiredByNativeCode]
	// RVA: 0x2CC90B0 Offset: 0x2CC7AB0 VA: 0x182CC90B0
	public static string ExtractStackTrace() { }

	[RequiredByNativeCode]
	// RVA: 0x2CC91F0 Offset: 0x2CC7BF0 VA: 0x182CC91F0
	internal static void ExtractStringFromExceptionInternal(object exceptiono, out string message, out string stackTrace) { }

	// RVA: 0x2CC8910 Offset: 0x2CC7310 VA: 0x182CC8910
	internal static string ExtractFormattedStackTrace(StackTrace stackTrace) { }

	// RVA: 0x2CC9700 Offset: 0x2CC8100 VA: 0x182CC9700
	private static void .cctor() { }
}
