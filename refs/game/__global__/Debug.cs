public class Debug // TypeDefIndex: 11613
{
	// Fields
	internal static readonly ILogger s_DefaultLogger; // 0x0
	internal static ILogger s_Logger; // 0x8

	// Properties
	public static ILogger unityLogger { get; }
	public static bool isDebugBuild { get; }

	// Methods

	// RVA: 0x2C871E0 Offset: 0x2C85BE0 VA: 0x182C871E0
	public static ILogger get_unityLogger() { }

	[ExcludeFromDocs]
	// RVA: 0x2C85970 Offset: 0x2C84370 VA: 0x182C85970
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }

	[ExcludeFromDocs]
	// RVA: 0x2C85A70 Offset: 0x2C84470 VA: 0x182C85A70
	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	[ExcludeFromDocs]
	// RVA: 0x2C85B60 Offset: 0x2C84560 VA: 0x182C85B60
	public static void DrawLine(Vector3 start, Vector3 end) { }

	[FreeFunction("DebugDrawLine", IsThreadSafe = True)]
	// RVA: 0x2C858D0 Offset: 0x2C842D0 VA: 0x182C858D0
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	[ExcludeFromDocs]
	// RVA: 0x2C85C60 Offset: 0x2C84660 VA: 0x182C85C60
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration) { }

	[ExcludeFromDocs]
	// RVA: 0x2C85E90 Offset: 0x2C84890 VA: 0x182C85E90
	public static void DrawRay(Vector3 start, Vector3 dir, Color color) { }

	// RVA: 0x2C85D20 Offset: 0x2C84720 VA: 0x182C85D20
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

	[ThreadSafe]
	// RVA: 0x2C85F40 Offset: 0x2C84940 VA: 0x182C85F40
	public static int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder) { }

	// RVA: 0x2C86FE0 Offset: 0x2C859E0 VA: 0x182C86FE0
	public static void Log(object message) { }

	// RVA: 0x2C86F10 Offset: 0x2C85910 VA: 0x182C86F10
	public static void Log(object message, Object context) { }

	// RVA: 0x2C86A20 Offset: 0x2C85420 VA: 0x182C86A20
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x2C86AF0 Offset: 0x2C854F0 VA: 0x182C86AF0
	public static void LogFormat(Object context, string format, object[] args) { }

	// RVA: 0x2C86750 Offset: 0x2C85150 VA: 0x182C86750
	public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, object[] args) { }

	// RVA: 0x2C86510 Offset: 0x2C84F10 VA: 0x182C86510
	public static void LogError(object message) { }

	// RVA: 0x2C86440 Offset: 0x2C84E40 VA: 0x182C86440
	public static void LogError(object message, Object context) { }

	// RVA: 0x2C86370 Offset: 0x2C84D70 VA: 0x182C86370
	public static void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x2C86290 Offset: 0x2C84C90 VA: 0x182C86290
	public static void LogErrorFormat(Object context, string format, object[] args) { }

	// RVA: 0x2C865D0 Offset: 0x2C84FD0 VA: 0x182C865D0
	public static void LogException(Exception exception) { }

	// RVA: 0x2C86690 Offset: 0x2C85090 VA: 0x182C86690
	public static void LogException(Exception exception, Object context) { }

	// RVA: 0x2C86E50 Offset: 0x2C85850 VA: 0x182C86E50
	public static void LogWarning(object message) { }

	// RVA: 0x2C86D80 Offset: 0x2C85780 VA: 0x182C86D80
	public static void LogWarning(object message, Object context) { }

	// RVA: 0x2C86BD0 Offset: 0x2C855D0 VA: 0x182C86BD0
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x2C86CA0 Offset: 0x2C856A0 VA: 0x182C86CA0
	public static void LogWarningFormat(Object context, string format, object[] args) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x2C85420 Offset: 0x2C83E20 VA: 0x182C85420
	public static void Assert(bool condition) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x2C85500 Offset: 0x2C83F00 VA: 0x182C85500
	public static void Assert(bool condition, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x2C861D0 Offset: 0x2C84BD0 VA: 0x182C861D0
	public static void LogAssertion(object message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x2C86100 Offset: 0x2C84B00 VA: 0x182C86100
	public static void LogAssertionFormat(string format, object[] args) { }

	// RVA: 0x2C871B0 Offset: 0x2C85BB0 VA: 0x182C871B0
	public static bool get_isDebugBuild() { }

	[RequiredByNativeCode]
	// RVA: 0x2C855D0 Offset: 0x2C83FD0 VA: 0x182C855D0
	internal static bool CallOverridenDebugHandler(Exception exception, Object obj) { }

	[RequiredByNativeCode]
	// RVA: 0x2C85F90 Offset: 0x2C84990 VA: 0x182C85F90
	internal static bool IsLoggingEnabled() { }

	// RVA: 0x2C870A0 Offset: 0x2C85AA0 VA: 0x182C870A0
	private static void .cctor() { }

	// RVA: 0x2C85860 Offset: 0x2C84260 VA: 0x182C85860
	private static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest) { }
}
