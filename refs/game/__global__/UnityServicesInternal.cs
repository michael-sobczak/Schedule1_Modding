internal class UnityServicesInternal : IUnityServices // TypeDefIndex: 17881
{
	// Fields
	internal const string InitSuccessEventInvocationError = "Exception in services initialization success event handler: ";
	internal const string InitFailureEventInvocationError = "Exception in services initialization failure event handler: ";
	[CompilerGenerated]
	private Action Initialized; // 0x10
	[CompilerGenerated]
	private Action<Exception> InitializeFailed; // 0x18
	[CompilerGenerated]
	private ServicesInitializationState <State>k__BackingField; // 0x20
	internal bool CanInitialize; // 0x24
	private TaskCompletionSource<object> m_Initialization; // 0x28
	[CompilerGenerated]
	private readonly CoreRegistry <Registry>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly CoreMetrics <Metrics>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly CoreDiagnostics <Diagnostics>k__BackingField; // 0x40

	// Properties
	public ServicesInitializationState State { get; set; }
	public InitializationOptions Options { get; set; }
	[NotNull]
	internal CoreRegistry Registry { get; }
	[NotNull]
	internal CoreMetrics Metrics { get; }
	[NotNull]
	internal CoreDiagnostics Diagnostics { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2BA3B40 Offset: 0x2BA2540 VA: 0x182BA3B40 Slot: 4
	public void add_Initialized(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2BA3C90 Offset: 0x2BA2690 VA: 0x182BA3C90 Slot: 5
	public void remove_Initialized(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2BA3A90 Offset: 0x2BA2490 VA: 0x182BA3A90 Slot: 6
	public void add_InitializeFailed(Action<Exception> value) { }

	[CompilerGenerated]
	// RVA: 0x2BA3BE0 Offset: 0x2BA25E0 VA: 0x182BA3BE0 Slot: 7
	public void remove_InitializeFailed(Action<Exception> value) { }

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 8
	public ServicesInitializationState get_State() { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	private void set_State(ServicesInitializationState value) { }

	// RVA: 0x24FAD80 Offset: 0x24F9780 VA: 0x1824FAD80
	public InitializationOptions get_Options() { }

	// RVA: 0x2BA3D30 Offset: 0x2BA2730 VA: 0x182BA3D30
	internal void set_Options(InitializationOptions value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal CoreRegistry get_Registry() { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	internal CoreMetrics get_Metrics() { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal CoreDiagnostics get_Diagnostics() { }

	// RVA: 0x2BA3A20 Offset: 0x2BA2420 VA: 0x182BA3A20
	public void .ctor(CoreRegistry registry, CoreMetrics coreMetrics, CoreDiagnostics coreDiagnostics) { }

	[AsyncStateMachine(typeof(UnityServicesInternal.<InitializeAsync>d__27))]
	// RVA: 0x2BA35D0 Offset: 0x2BA1FD0 VA: 0x182BA35D0 Slot: 9
	public Task InitializeAsync(InitializationOptions options) { }

	// RVA: 0x24FAD10 Offset: 0x24F9710 VA: 0x1824FAD10 Slot: 10
	public string GetIdentifier() { }

	// RVA: 0x2BA3930 Offset: 0x2BA2330 VA: 0x182BA3930
	private void TriggerInitializeSuccess() { }

	// RVA: 0x2BA38C0 Offset: 0x2BA22C0 VA: 0x182BA38C0
	private void TriggerInitializeFailed(Exception initException) { }

	// RVA: -1 Offset: -1 Slot: 11
	public T GetService<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF665B0 Offset: 0xF64FB0 VA: 0x180F665B0
	|-UnityServicesInternal.GetService<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2BA35C0 Offset: 0x2BA1FC0 VA: 0x182BA35C0
	private bool HasRequestedInitialization() { }

	[AsyncStateMachine(typeof(UnityServicesInternal.<InitializeServicesAsync>d__33))]
	// RVA: 0x2BA36D0 Offset: 0x2BA20D0 VA: 0x182BA36D0
	private Task InitializeServicesAsync() { }

	// RVA: 0x2BA37A0 Offset: 0x2BA21A0 VA: 0x182BA37A0
	internal void SendInitializationMetrics(List<PackageInitializationInfo> packageInitInfos) { }

	// RVA: 0x2BA35B0 Offset: 0x2BA1FB0 VA: 0x182BA35B0
	internal void EnableInitialization() { }

	[AsyncStateMachine(typeof(UnityServicesInternal.<EnableInitializationAsync>d__36))]
	// RVA: 0x2BA34E0 Offset: 0x2BA1EE0 VA: 0x182BA34E0
	internal Task EnableInitializationAsync() { }

	[CompilerGenerated]
	// RVA: 0x2BA39A0 Offset: 0x2BA23A0 VA: 0x182BA39A0
	private bool <InitializeAsync>g__HasInitializationFailed|27_0() { }
}
