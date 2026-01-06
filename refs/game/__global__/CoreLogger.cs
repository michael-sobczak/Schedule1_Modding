internal static class CoreLogger // TypeDefIndex: 17837
{
	// Fields
	internal const string Tag = "[ServicesCore]";
	internal const string VerboseLoggingDefine = "ENABLE_UNITY_SERVICES_CORE_VERBOSE_LOGGING";
	private const string k_TelemetryLoggingDefine = "ENABLE_UNITY_SERVICES_CORE_TELEMETRY_LOGGING";

	// Methods

	// RVA: 0x2B9BB10 Offset: 0x2B9A510 VA: 0x182B9BB10
	public static void Log(object message) { }

	// RVA: 0x2B9BA40 Offset: 0x2B9A440 VA: 0x182B9BA40
	public static void LogWarning(object message) { }

	// RVA: 0x2B9B700 Offset: 0x2B9A100 VA: 0x182B9B700
	public static void LogError(object message) { }

	// RVA: 0x2B9B7D0 Offset: 0x2B9A1D0 VA: 0x182B9B7D0
	public static void LogException(Exception exception) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x2B9B630 Offset: 0x2B9A030 VA: 0x182B9B630
	public static void LogAssertion(object message) { }

	[Conditional("ENABLE_UNITY_SERVICES_CORE_VERBOSE_LOGGING")]
	// RVA: 0x2B9B970 Offset: 0x2B9A370 VA: 0x182B9B970
	public static void LogVerbose(object message) { }

	[Conditional("ENABLE_UNITY_SERVICES_CORE_TELEMETRY_LOGGING")]
	// RVA: 0x2B9B8A0 Offset: 0x2B9A2A0 VA: 0x182B9B8A0
	public static void LogTelemetry(object message) { }
}
