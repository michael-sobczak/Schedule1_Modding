public sealed class BurstCompilerOptions // TypeDefIndex: 16291
{
	// Fields
	private const string DisableCompilationArg = "--burst-disable-compilation";
	private const string ForceSynchronousCompilationArg = "--burst-force-sync-compilation";
	internal const string DefaultLibraryName = "lib_burst_generated";
	internal const string BurstInitializeName = "burst.initialize";
	internal const string BurstInitializeExternalsName = "burst.initialize.externals";
	internal const string BurstInitializeStaticsName = "burst.initialize.statics";
	internal const string OptionBurstcSwitch = "+burstc";
	internal const string OptionGroup = "group";
	internal const string OptionPlatform = "platform=";
	internal const string OptionBackend = "backend=";
	internal const string OptionGlobalSafetyChecksSetting = "global-safety-checks-setting=";
	internal const string OptionDisableSafetyChecks = "disable-safety-checks";
	internal const string OptionDisableOpt = "disable-opt";
	internal const string OptionFastMath = "fastmath";
	internal const string OptionTarget = "target=";
	internal const string OptionOptLevel = "opt-level=";
	internal const string OptionLogTimings = "log-timings";
	internal const string OptionOptForSize = "opt-for-size";
	internal const string OptionFloatPrecision = "float-precision=";
	internal const string OptionFloatMode = "float-mode=";
	internal const string OptionBranchProtection = "branch-protection=";
	internal const string OptionDisableWarnings = "disable-warnings=";
	internal const string OptionAssemblyDefines = "assembly-defines=";
	internal const string OptionDump = "dump=";
	internal const string OptionFormat = "format=";
	internal const string OptionDebugTrap = "debugtrap";
	internal const string OptionDisableVectors = "disable-vectors";
	internal const string OptionDebug = "debug=";
	internal const string OptionDebugMode = "debugMode";
	internal const string OptionStaticLinkage = "generate-static-linkage-methods";
	internal const string OptionJobMarshalling = "generate-job-marshalling-methods";
	internal const string OptionTempDirectory = "temp-folder=";
	internal const string OptionEnableDirectExternalLinking = "enable-direct-external-linking";
	internal const string OptionLinkerOptions = "linker-options=";
	internal const string OptionEnableAutoLayoutFallbackCheck = "enable-autolayout-fallback-check";
	internal const string OptionGenerateLinkXml = "generate-link-xml=";
	internal const string OptionMetaDataGeneration = "meta-data-generation=";
	internal const string OptionDisableStringInterpolationInExceptionMessages = "disable-string-interpolation-in-exception-messages";
	internal const string OptionPlatformConfiguration = "platform-configuration=";
	internal const string OptionStackProtector = "stack-protector=";
	internal const string OptionStackProtectorBufferSize = "stack-protector-buffer-size=";
	internal const string OptionCacheDirectory = "cache-directory=";
	internal const string OptionJitDisableFunctionCaching = "disable-function-caching";
	internal const string OptionJitDisableAssemblyCaching = "disable-assembly-caching";
	internal const string OptionJitEnableAssemblyCachingLogs = "enable-assembly-caching-logs";
	internal const string OptionJitEnableSynchronousCompilation = "enable-synchronous-compilation";
	internal const string OptionJitCompilationPriority = "compilation-priority=";
	internal const string OptionJitIsForFunctionPointer = "is-for-function-pointer";
	internal const string OptionJitManagedFunctionPointer = "managed-function-pointer=";
	internal const string OptionJitManagedDelegateHandle = "managed-delegate-handle=";
	internal const string OptionEnableInterpreter = "enable-interpreter";
	internal const string OptionAotAssemblyFolder = "assembly-folder=";
	internal const string OptionRootAssembly = "root-assembly=";
	internal const string OptionIncludeRootAssemblyReferences = "include-root-assembly-references=";
	internal const string OptionAotMethod = "method=";
	internal const string OptionAotType = "type=";
	internal const string OptionAotAssembly = "assembly=";
	internal const string OptionAotOutputPath = "output=";
	internal const string OptionAotKeepIntermediateFiles = "keep-intermediate-files";
	internal const string OptionAotNoLink = "nolink";
	internal const string OptionAotOnlyStaticMethods = "only-static-methods";
	internal const string OptionMethodPrefix = "method-prefix=";
	internal const string OptionAotNoNativeToolchain = "no-native-toolchain";
	internal const string OptionAotEmitLlvmObjects = "emit-llvm-objects";
	internal const string OptionAotKeyFolder = "key-folder=";
	internal const string OptionAotDecodeFolder = "decode-folder=";
	internal const string OptionVerbose = "verbose";
	internal const string OptionValidateExternalToolChain = "validate-external-tool-chain";
	internal const string OptionCompilerThreads = "threads=";
	internal const string OptionChunkSize = "chunk-size=";
	internal const string OptionPrintLogOnMissingPInvokeCallbackAttribute = "print-monopinvokecallbackmissing-message";
	internal const string OptionOutputMode = "output-mode=";
	internal const string OptionAlwaysCreateOutput = "always-create-output=";
	internal const string OptionAotPdbSearchPaths = "pdb-search-paths=";
	internal const string OptionSafetyChecks = "safety-checks";
	internal const string OptionLibraryOutputMode = "library-output-mode=";
	internal const string OptionCompilationId = "compilation-id=";
	internal const string OptionTargetFramework = "target-framework=";
	internal const string OptionDiscardAssemblies = "discard-assemblies=";
	internal const string OptionSaveExtraContext = "save-extra-context";
	internal const string CompilerCommandShutdown = "$shutdown";
	internal const string CompilerCommandCancel = "$cancel";
	internal const string CompilerCommandEnableCompiler = "$enable_compiler";
	internal const string CompilerCommandDisableCompiler = "$disable_compiler";
	internal const string CompilerCommandSetDefaultOptions = "$set_default_options";
	internal const string CompilerCommandTriggerSetupRecompilation = "$trigger_setup_recompilation";
	internal const string CompilerCommandIsCurrentCompilationDone = "$is_current_compilation_done";
	internal const string CompilerCommandTriggerRecompilation = "$trigger_recompilation";
	internal const string CompilerCommandInitialize = "$initialize";
	internal const string CompilerCommandDomainReload = "$domain_reload";
	internal const string CompilerCommandVersionNotification = "$version";
	internal const string CompilerCommandGetTargetCpuFromHost = "$get_target_cpu_from_host";
	internal const string CompilerCommandSetProfileCallbacks = "$set_profile_callbacks";
	internal const string CompilerCommandUnloadBurstNatives = "$unload_burst_natives";
	internal const string CompilerCommandIsNativeApiAvailable = "$is_native_api_available";
	internal const string CompilerCommandILPPCompilation = "$ilpp_compilation";
	internal const string CompilerCommandIsArmTestEnv = "$is_arm_test_env";
	internal const string CompilerCommandNotifyAssemblyCompilationNotRequired = "$notify_assembly_compilation_not_required";
	internal const string CompilerCommandNotifyAssemblyCompilationFinished = "$notify_assembly_compilation_finished";
	internal const string CompilerCommandNotifyCompilationStarted = "$notify_compilation_started";
	internal const string CompilerCommandNotifyCompilationFinished = "$notify_compilation_finished";
	internal const string CompilerCommandAotCompilation = "$aot_compilation";
	internal const string CompilerCommandRequestInitialiseDebuggerCommmand = "$request_debug_command";
	internal const string CompilerCommandInitialiseDebuggerCommmand = "$load_debugger_interface";
	internal const string CompilerCommandRequestSetProtocolVersionEditor = "$request_set_protocol_version_editor";
	internal const string CompilerCommandSetProtocolVersionBurst = "$set_protocol_version_burst";
	internal static readonly bool ForceDisableBurstCompilation; // 0x0
	private static readonly bool ForceBurstCompilationSynchronously; // 0x1
	internal static readonly bool IsSecondaryUnityProcess; // 0x2
	private bool _enableBurstCompilation; // 0x10
	private bool _enableBurstCompileSynchronously; // 0x11
	private bool _enableBurstSafetyChecks; // 0x12
	private bool _enableBurstTimings; // 0x13
	private bool _enableBurstDebug; // 0x14
	private bool _forceEnableBurstSafetyChecks; // 0x15
	[CompilerGenerated]
	private readonly bool <IsGlobal>k__BackingField; // 0x16
	[CompilerGenerated]
	private Action <OptionsChanged>k__BackingField; // 0x18

	// Properties
	private bool IsGlobal { get; }
	public bool IsEnabled { get; }
	public bool EnableBurstCompilation { get; set; }
	public bool EnableBurstCompileSynchronously { get; set; }
	public bool EnableBurstSafetyChecks { get; set; }
	public bool ForceEnableBurstSafetyChecks { get; set; }
	public bool EnableBurstDebug { get; set; }
	[Obsolete("This property is no longer used and will be removed in a future major release")]
	public bool DisableOptimizations { get; set; }
	[Obsolete("This property is no longer used and will be removed in a future major release. Use the [BurstCompile(FloatMode = FloatMode.Fast)] on the method directly to enable this feature")]
	public bool EnableFastMath { get; set; }
	internal bool EnableBurstTimings { get; set; }
	internal bool RequiresSynchronousCompilation { get; }
	internal Action OptionsChanged { get; set; }

	// Methods

	// RVA: 0x26D87A0 Offset: 0x26D71A0 VA: 0x1826D87A0
	internal static string SerialiseCompilationOptionsSafe(string[] roots, string[] folders, string options) { }

	// RVA: 0x26D6A90 Offset: 0x26D5490 VA: 0x1826D6A90
	internal static ValueTuple<string[], string[], string> DeserialiseCompilationOptionsSafe(string from) { }

	// RVA: 0x26D8E70 Offset: 0x26D7870 VA: 0x1826D8E70
	private void .ctor() { }

	// RVA: 0x26D8F90 Offset: 0x26D7990 VA: 0x1826D8F90
	internal void .ctor(bool isGlobal) { }

	[CompilerGenerated]
	// RVA: 0x26D9060 Offset: 0x26D7A60 VA: 0x1826D9060
	private bool get_IsGlobal() { }

	// RVA: 0x26D8FF0 Offset: 0x26D79F0 VA: 0x1826D8FF0
	public bool get_IsEnabled() { }

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_EnableBurstCompilation() { }

	// RVA: 0x26D90E0 Offset: 0x26D7AE0 VA: 0x1826D90E0
	public void set_EnableBurstCompilation(bool value) { }

	// RVA: 0x498A50 Offset: 0x497450 VA: 0x180498A50
	public bool get_EnableBurstCompileSynchronously() { }

	// RVA: 0x26D91D0 Offset: 0x26D7BD0 VA: 0x1826D91D0
	public void set_EnableBurstCompileSynchronously(bool value) { }

	// RVA: 0x4B9D00 Offset: 0x4B8700 VA: 0x1804B9D00
	public bool get_EnableBurstSafetyChecks() { }

	// RVA: 0x26D9230 Offset: 0x26D7C30 VA: 0x1826D9230
	public void set_EnableBurstSafetyChecks(bool value) { }

	// RVA: 0x1BBB9B0 Offset: 0x1BBA3B0 VA: 0x181BBB9B0
	public bool get_ForceEnableBurstSafetyChecks() { }

	// RVA: 0x26D9290 Offset: 0x26D7C90 VA: 0x1826D9290
	public void set_ForceEnableBurstSafetyChecks(bool value) { }

	// RVA: 0x60D730 Offset: 0x60C130 VA: 0x18060D730
	public bool get_EnableBurstDebug() { }

	// RVA: 0x26D9200 Offset: 0x26D7C00 VA: 0x1826D9200
	public void set_EnableBurstDebug(bool value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public bool get_DisableOptimizations() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void set_DisableOptimizations(bool value) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	public bool get_EnableFastMath() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void set_EnableFastMath(bool value) { }

	// RVA: 0xFDF650 Offset: 0xFDE050 VA: 0x180FDF650
	internal bool get_EnableBurstTimings() { }

	// RVA: 0x26D9260 Offset: 0x26D7C60 VA: 0x1826D9260
	internal void set_EnableBurstTimings(bool value) { }

	// RVA: 0x26D9070 Offset: 0x26D7A70 VA: 0x1826D9070
	internal bool get_RequiresSynchronousCompilation() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal Action get_OptionsChanged() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void set_OptionsChanged(Action value) { }

	// RVA: 0x26D6790 Offset: 0x26D5190 VA: 0x1826D6790
	internal BurstCompilerOptions Clone() { }

	// RVA: 0x26D8880 Offset: 0x26D7280 VA: 0x1826D8880
	private static bool TryGetAttribute(MemberInfo member, out BurstCompileAttribute attribute) { }

	// RVA: 0x26D8920 Offset: 0x26D7320 VA: 0x1826D8920
	private static bool TryGetAttribute(Assembly assembly, out BurstCompileAttribute attribute) { }

	// RVA: 0x26D6B50 Offset: 0x26D5550 VA: 0x1826D6B50
	private static BurstCompileAttribute GetBurstCompileAttribute(MemberInfo memberInfo) { }

	// RVA: 0x26D8510 Offset: 0x26D6F10 VA: 0x1826D8510
	internal static bool HasBurstCompileAttribute(MemberInfo member) { }

	// RVA: 0x26D8640 Offset: 0x26D7040 VA: 0x1826D8640
	internal static void MergeAttributes(ref BurstCompileAttribute memberAttribute, in BurstCompileAttribute assemblyAttribute) { }

	// RVA: 0x26D89B0 Offset: 0x26D73B0 VA: 0x1826D89B0
	internal bool TryGetOptions(MemberInfo member, out string flagsOut, bool isForILPostProcessing = False, bool isForCompilerClient = False) { }

	// RVA: 0x26D6EF0 Offset: 0x26D58F0 VA: 0x1826D6EF0
	internal string GetOptions(BurstCompileAttribute attr, bool isForILPostProcessing = False, bool isForCompilerClient = False) { }

	// RVA: 0x26D6740 Offset: 0x26D5140 VA: 0x1826D6740
	private static void AddOption(StringBuilder builder, string option) { }

	// RVA: 0x26D6E00 Offset: 0x26D5800 VA: 0x1826D6E00
	internal static string GetOption(string optionName, object value) { }

	// RVA: 0x10EDAF0 Offset: 0x10EC4F0 VA: 0x1810EDAF0
	private void OnOptionsChanged() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void MaybeTriggerRecompilation() { }

	// RVA: 0x26D8D10 Offset: 0x26D7710 VA: 0x1826D8D10
	private static void .cctor() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	private static bool CheckIsSecondaryUnityProcess() { }
}
