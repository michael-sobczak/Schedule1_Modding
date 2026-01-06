internal static class BurstCompilerService // TypeDefIndex: 11567
{
	// Methods

	[ThreadSafe]
	// RVA: 0x2C816F0 Offset: 0x2C800F0 VA: 0x182C816F0
	public static string GetDisassembly(MethodInfo m, string compilerOptions) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2C81630 Offset: 0x2C80030 VA: 0x182C81630
	public static int CompileAsyncDelegateMethod(object delegateMethod, string compilerOptions) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2C81680 Offset: 0x2C80080 VA: 0x182C81680
	public static void* GetAsyncCompiledAsyncDelegateMethod(int userID) { }

	[ThreadSafe]
	// RVA: 0x2C81740 Offset: 0x2C80140 VA: 0x182C81740
	public static void* GetOrCreateSharedMemory(ref Hash128 key, uint size_of, uint alignment) { }

	[ThreadSafe]
	// RVA: 0x2C81890 Offset: 0x2C80290 VA: 0x182C81890
	public static void SetCurrentExecutionMode(uint environment) { }

	[ThreadSafe]
	// RVA: 0x2C816C0 Offset: 0x2C800C0 VA: 0x182C816C0
	public static uint GetCurrentExecutionMode() { }

	[FreeFunction("DefaultBurstLogCallback", True)]
	// RVA: 0x2C817D0 Offset: 0x2C801D0 VA: 0x182C817D0
	public static void Log(void* userData, BurstCompilerService.BurstLogType logType, byte* message, byte* filename, int lineNumber) { }

	[FreeFunction("DefaultBurstRuntimeLogCallback", True)]
	// RVA: 0x2C81830 Offset: 0x2C80230 VA: 0x182C81830
	public static void RuntimeLog(void* userData, BurstCompilerService.BurstLogType logType, byte* message, byte* filename, int lineNumber) { }

	// RVA: 0x2C81790 Offset: 0x2C80190 VA: 0x182C81790
	public static bool LoadBurstLibrary(string fullPathToLibBurstGenerated) { }
}
