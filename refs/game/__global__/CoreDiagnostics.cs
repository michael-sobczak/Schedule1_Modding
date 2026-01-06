internal class CoreDiagnostics // TypeDefIndex: 17872
{
	// Fields
	internal const string CorePackageName = "com.unity.services.core";
	internal const string CircularDependencyDiagnosticName = "circular_dependency";
	internal const string CorePackageInitDiagnosticName = "core_package_init";
	internal const string OperateServicesInitDiagnosticName = "operate_services_init";
	internal const string ProjectConfigTagName = "project_config";
	[CompilerGenerated]
	private static CoreDiagnostics <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly IDictionary<string, string> <CoreTags>k__BackingField; // 0x10
	[CompilerGenerated]
	private IDiagnosticsComponentProvider <DiagnosticsComponentProvider>k__BackingField; // 0x18
	[CompilerGenerated]
	private IDiagnostics <Diagnostics>k__BackingField; // 0x20

	// Properties
	public static CoreDiagnostics Instance { get; set; }
	public IDictionary<string, string> CoreTags { get; }
	internal IDiagnosticsComponentProvider DiagnosticsComponentProvider { get; set; }
	internal IDiagnostics Diagnostics { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2B9B590 Offset: 0x2B99F90 VA: 0x182B9B590
	public static CoreDiagnostics get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x2B9B5D0 Offset: 0x2B99FD0 VA: 0x182B9B5D0
	internal static void set_Instance(CoreDiagnostics value) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public IDictionary<string, string> get_CoreTags() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal IDiagnosticsComponentProvider get_DiagnosticsComponentProvider() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void set_DiagnosticsComponentProvider(IDiagnosticsComponentProvider value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal IDiagnostics get_Diagnostics() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	internal void set_Diagnostics(IDiagnostics value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void SetProjectConfiguration(string serializedProjectConfig) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void SendCircularDependencyDiagnostics(Exception exception) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void SendCorePackageInitDiagnostics(Exception exception) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void SendOperateServicesInitDiagnostics(Exception exception) { }

	[AsyncStateMachine(typeof(CoreDiagnostics.<SendCoreDiagnosticsAsync>d__24))]
	// RVA: 0x2B9B460 Offset: 0x2B99E60 VA: 0x182B9B460
	internal Task SendCoreDiagnosticsAsync(string diagnosticName, Exception exception) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void OnSendFailed(Task failedSendTask) { }

	[AsyncStateMachine(typeof(CoreDiagnostics.<GetOrCreateDiagnosticsAsync>d__26))]
	// RVA: 0x2B9B370 Offset: 0x2B99D70 VA: 0x182B9B370
	internal Task<IDiagnostics> GetOrCreateDiagnosticsAsync() { }

	// RVA: 0x2B9B510 Offset: 0x2B99F10 VA: 0x182B9B510
	public void .ctor() { }
}
