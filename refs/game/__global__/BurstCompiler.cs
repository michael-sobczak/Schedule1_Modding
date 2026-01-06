public static class BurstCompiler // TypeDefIndex: 16289
{
	// Fields
	[ThreadStatic]
	private static BurstCompiler.CommandBuilder _cmdBuilder; // 0x80000000
	internal static bool _IsEnabled; // 0x0
	public static readonly BurstCompilerOptions Options; // 0x8
	internal static Action OnCompileILPPMethod2; // 0x10
	private static readonly MethodInfo DummyMethodInfo; // 0x18

	// Properties
	public static bool IsEnabled { get; }

	// Methods

	// RVA: 0x26DA280 Offset: 0x26D8C80 VA: 0x1826DA280
	public static bool IsLoadAdditionalLibrarySupported() { }

	// RVA: 0x26D92F0 Offset: 0x26D7CF0 VA: 0x1826D92F0
	private static BurstCompiler.CommandBuilder BeginCompilerCommand(string cmd) { }

	// RVA: 0x26DAE40 Offset: 0x26D9840 VA: 0x1826DAE40
	public static bool get_IsEnabled() { }

	// RVA: 0x26DA790 Offset: 0x26D9190 VA: 0x1826DA790
	public static void SetExecutionMode(BurstExecutionEnvironment mode) { }

	// RVA: 0x26D9E90 Offset: 0x26D8890 VA: 0x1826D9E90
	public static BurstExecutionEnvironment GetExecutionMode() { }

	// RVA: -1 Offset: -1
	internal static T CompileDelegate<T>(T delegateMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5AD70 Offset: 0xE59770 VA: 0x180E5AD70
	|-BurstCompiler.CompileDelegate<object>
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void VerifyDelegateIsNotMulticast<T>(T delegateMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5AFC0 Offset: 0xE599C0 VA: 0x180E5AFC0
	|-BurstCompiler.VerifyDelegateIsNotMulticast<object>
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void VerifyDelegateHasCorrectUnmanagedFunctionPointerAttribute<T>(T delegateMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5AED0 Offset: 0xE598D0 VA: 0x180E5AED0
	|-BurstCompiler.VerifyDelegateHasCorrectUnmanagedFunctionPointerAttribute<object>
	*/

	[Obsolete("This method will be removed in a future version of Burst")]
	// RVA: 0x26D9600 Offset: 0x26D8000 VA: 0x1826D9600
	public static IntPtr CompileILPPMethod(RuntimeMethodHandle burstMethodHandle, RuntimeMethodHandle managedMethodHandle, RuntimeTypeHandle delegateTypeHandle) { }

	// RVA: 0x26D9460 Offset: 0x26D7E60 VA: 0x1826D9460
	public static IntPtr CompileILPPMethod2(RuntimeMethodHandle burstMethodHandle) { }

	[Obsolete("This method will be removed in a future version of Burst")]
	// RVA: 0x26D9FE0 Offset: 0x26D89E0 VA: 0x1826D9FE0
	public static void* GetILPPMethodFunctionPointer(IntPtr ilppMethod) { }

	// RVA: 0x26D9EA0 Offset: 0x26D88A0 VA: 0x1826D9EA0
	public static void* GetILPPMethodFunctionPointer2(IntPtr ilppMethod, RuntimeMethodHandle managedMethodHandle, RuntimeTypeHandle delegateTypeHandle) { }

	[Obsolete("This method will be removed in a future version of Burst")]
	// RVA: 0x26D9640 Offset: 0x26D8040 VA: 0x1826D9640
	public static void* CompileUnsafeStaticMethod(RuntimeMethodHandle handle) { }

	// RVA: -1 Offset: -1
	public static FunctionPointer<T> CompileFunctionPointer<T>(T delegateMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5AE70 Offset: 0xE59870 VA: 0x180E5AE70
	|-BurstCompiler.CompileFunctionPointer<object>
	*/

	// RVA: 0x26D9D40 Offset: 0x26D8740 VA: 0x1826D9D40
	private static void* Compile(object delegateObj, bool isFunctionPointer) { }

	// RVA: 0x26D9680 Offset: 0x26D8080 VA: 0x1826D9680
	private static void* Compile(object delegateObj, MethodInfo methodInfo, bool isFunctionPointer, bool isILPostProcessing) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void Shutdown() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void Cancel() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	internal static bool IsCurrentCompilationDone() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void Enable() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void Disable() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	internal static bool IsHostEditorArm() { }

	// RVA: 0x26DA7A0 Offset: 0x26D91A0 VA: 0x1826DA7A0
	internal static void TriggerUnsafeStaticMethodRecompilation() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void TriggerRecompilation() { }

	// RVA: 0x26DAB40 Offset: 0x26D9540 VA: 0x1826DAB40
	internal static void UnloadAdditionalLibraries() { }

	// RVA: 0x26DA020 Offset: 0x26D8A20 VA: 0x1826DA020
	internal static void InitialiseDebuggerHooks() { }

	// RVA: 0x26DA200 Offset: 0x26D8C00 VA: 0x1826DA200
	internal static bool IsApiAvailable(string apiName) { }

	// RVA: 0x26DA2E0 Offset: 0x26D8CE0 VA: 0x1826DA2E0
	internal static int RequestSetProtocolVersion(int version) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void Initialize(string[] assemblyFolders, string[] ignoreAssemblies) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void NotifyCompilationStarted(string[] assemblyFolders, string[] ignoreAssemblies) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void NotifyAssemblyCompilationNotRequired(string assemblyName) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void NotifyAssemblyCompilationFinished(string assemblyName, string[] defines) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void NotifyCompilationFinished() { }

	// RVA: 0x26D92C0 Offset: 0x26D7CC0 VA: 0x1826D92C0
	internal static string AotCompilation(string[] assemblyFolders, string[] assemblyRoots, string options) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void SetProfilerCallbacks() { }

	// RVA: 0x26DA6E0 Offset: 0x26D90E0 VA: 0x1826DA6E0
	private static string SendRawCommandToCompiler(string command) { }

	// RVA: 0x26DA420 Offset: 0x26D8E20 VA: 0x1826DA420
	private static string SendCommandToCompiler(string commandName, string commandArgs) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void DummyMethod() { }

	// RVA: 0x26DAC20 Offset: 0x26D9620 VA: 0x1826DAC20
	private static void .cctor() { }
}
