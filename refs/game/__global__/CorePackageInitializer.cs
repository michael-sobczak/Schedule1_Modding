internal class CorePackageInitializer : IInitializablePackageV2, IInitializablePackage, IDiagnosticsComponentProvider // TypeDefIndex: 19132
{
	// Fields
	[CompilerGenerated]
	private ActionScheduler <ActionScheduler>k__BackingField; // 0x10
	[CompilerGenerated]
	private InstallationId <InstallationId>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProjectConfiguration <ProjectConfig>k__BackingField; // 0x20
	[CompilerGenerated]
	private Environments <Environments>k__BackingField; // 0x28
	[CompilerGenerated]
	private ExternalUserId <ExternalUserId>k__BackingField; // 0x30
	[CompilerGenerated]
	private ICloudProjectId <CloudProjectId>k__BackingField; // 0x38
	[CompilerGenerated]
	private IDiagnosticsFactory <DiagnosticsFactory>k__BackingField; // 0x40
	[CompilerGenerated]
	private IMetricsFactory <MetricsFactory>k__BackingField; // 0x48
	[CompilerGenerated]
	private UnityThreadUtilsInternal <UnityThreadUtils>k__BackingField; // 0x50
	private CoreRegistry m_Registry; // 0x58
	private readonly IJsonSerializer m_Serializer; // 0x60
	private InitializationOptions m_CurrentInitializationOptions; // 0x68

	// Properties
	internal ActionScheduler ActionScheduler { get; set; }
	internal InstallationId InstallationId { get; set; }
	internal ProjectConfiguration ProjectConfig { get; set; }
	internal Environments Environments { get; set; }
	internal ExternalUserId ExternalUserId { get; set; }
	internal ICloudProjectId CloudProjectId { get; set; }
	internal IDiagnosticsFactory DiagnosticsFactory { get; set; }
	internal IMetricsFactory MetricsFactory { get; set; }
	internal UnityThreadUtilsInternal UnityThreadUtils { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal ActionScheduler get_ActionScheduler() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_ActionScheduler(ActionScheduler value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal InstallationId get_InstallationId() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_InstallationId(InstallationId value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal ProjectConfiguration get_ProjectConfig() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_ProjectConfig(ProjectConfiguration value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal Environments get_Environments() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_Environments(Environments value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal ExternalUserId get_ExternalUserId() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	private void set_ExternalUserId(ExternalUserId value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	internal ICloudProjectId get_CloudProjectId() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_CloudProjectId(ICloudProjectId value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal IDiagnosticsFactory get_DiagnosticsFactory() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	private void set_DiagnosticsFactory(IDiagnosticsFactory value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	internal IMetricsFactory get_MetricsFactory() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	private void set_MetricsFactory(IMetricsFactory value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	internal UnityThreadUtilsInternal get_UnityThreadUtils() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	private void set_UnityThreadUtils(UnityThreadUtilsInternal value) { }

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x2BA49C0 Offset: 0x2BA33C0 VA: 0x182BA49C0
	private static void InitializeOnLoad() { }

	// RVA: 0x2BA4DE0 Offset: 0x2BA37E0 VA: 0x182BA4DE0 Slot: 4
	public void Register(CorePackageRegistry registry) { }

	// RVA: 0x2BA5190 Offset: 0x2BA3B90 VA: 0x182BA5190
	public void .ctor(IJsonSerializer serializer) { }

	// RVA: 0x2BA4920 Offset: 0x2BA3320 VA: 0x182BA4920 Slot: 6
	public Task Initialize(CoreRegistry registry) { }

	// RVA: 0x2BA4920 Offset: 0x2BA3320 VA: 0x182BA4920 Slot: 5
	public Task InitializeInstanceAsync(CoreRegistry registry) { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<InitializeComponents>d__47))]
	// RVA: 0x2BA4570 Offset: 0x2BA2F70 VA: 0x182BA4570
	private Task InitializeComponents() { }

	// RVA: 0x2BA4410 Offset: 0x2BA2E10 VA: 0x182BA4410
	private bool HaveInitOptionsChanged() { }

	// RVA: 0x2BA40E0 Offset: 0x2BA2AE0 VA: 0x182BA40E0
	private void FreeOptionsDependantComponents() { }

	// RVA: 0x2BA48A0 Offset: 0x2BA32A0 VA: 0x182BA48A0
	internal void InitializeInstallationId() { }

	// RVA: 0x2BA4480 Offset: 0x2BA2E80 VA: 0x182BA4480
	internal void InitializeActionScheduler() { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<InitializeProjectConfigAsync>d__52))]
	// RVA: 0x2BA4C80 Offset: 0x2BA3680 VA: 0x182BA4C80
	internal Task InitializeProjectConfigAsync(InitializationOptions options) { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<GenerateProjectConfigurationAsync>d__53))]
	// RVA: 0x2BA4140 Offset: 0x2BA2B40 VA: 0x182BA4140
	internal Task<ProjectConfiguration> GenerateProjectConfigurationAsync(InitializationOptions options) { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<GetSerializedConfigOrEmptyAsync>d__54))]
	// RVA: 0x2BA4250 Offset: 0x2BA2C50 VA: 0x182BA4250
	internal static Task<SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync() { }

	// RVA: 0x2BA4790 Offset: 0x2BA3190 VA: 0x182BA4790
	internal void InitializeExternalUserId(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x2BA46B0 Offset: 0x2BA30B0 VA: 0x182BA46B0
	internal void InitializeEnvironments(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x2BA4950 Offset: 0x2BA3350 VA: 0x182BA4950
	internal void InitializeMetrics() { }

	// RVA: 0x2BA4640 Offset: 0x2BA3040 VA: 0x182BA4640
	internal void InitializeDiagnostics() { }

	// RVA: 0x2BA4500 Offset: 0x2BA2F00 VA: 0x182BA4500
	internal void InitializeCloudProjectId(ICloudProjectId cloudProjectId) { }

	// RVA: 0x2BA4D70 Offset: 0x2BA3770 VA: 0x182BA4D70
	internal void InitializeUnityThreadUtils() { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<CreateDiagnosticsComponents>d__61))]
	// RVA: 0x2BA3FF0 Offset: 0x2BA29F0 VA: 0x182BA3FF0 Slot: 7
	public Task<IDiagnosticsFactory> CreateDiagnosticsComponents() { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<GetSerializedProjectConfigurationAsync>d__63))]
	// RVA: 0x2BA4320 Offset: 0x2BA2D20 VA: 0x182BA4320 Slot: 8
	public Task<string> GetSerializedProjectConfigurationAsync() { }

	[CompilerGenerated]
	// RVA: 0x2BA5000 Offset: 0x2BA3A00 VA: 0x182BA5000
	private void <InitializeComponents>g__RegisterProvidedComponents|47_0() { }

	[CompilerGenerated]
	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	internal static bool <InitializeComponents>g__SendFailedInitDiagnostic|47_1(Exception reason) { }
}
