public static class UnityServices // TypeDefIndex: 19104
{
	// Fields
	[CompilerGenerated]
	private static IUnityServices <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private static TaskCompletionSource<object> <InstantiationCompletion>k__BackingField; // 0x8
	internal static ExternalUserIdProperty ExternalUserIdProperty; // 0x10
	[CompilerGenerated]
	private static readonly Dictionary<string, IUnityServices> <s_Services>k__BackingField; // 0x18

	// Properties
	public static IUnityServices Instance { get; set; }
	public static IReadOnlyDictionary<string, IUnityServices> Services { get; }
	internal static TaskCompletionSource<object> InstantiationCompletion { get; set; }
	private static Dictionary<string, IUnityServices> s_Services { get; }
	public static ServicesInitializationState State { get; }
	public static string ExternalUserId { get; set; }

	// Methods

	// RVA: 0x2B99580 Offset: 0x2B97F80 VA: 0x182B99580
	public static void add_Initialized(Action value) { }

	// RVA: 0x2B99C20 Offset: 0x2B98620 VA: 0x182B99C20
	public static void remove_Initialized(Action value) { }

	// RVA: 0x2B99470 Offset: 0x2B97E70 VA: 0x182B99470
	public static void add_InitializeFailed(Action<Exception> value) { }

	// RVA: 0x2B99B10 Offset: 0x2B98510 VA: 0x182B99B10
	public static void remove_InitializeFailed(Action<Exception> value) { }

	[CompilerGenerated]
	// RVA: 0x2B996F0 Offset: 0x2B980F0 VA: 0x182B996F0
	public static IUnityServices get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x2B99DD0 Offset: 0x2B987D0 VA: 0x182B99DD0
	public static void set_Instance(IUnityServices value) { }

	// RVA: 0x2B99790 Offset: 0x2B98190 VA: 0x182B99790
	public static IReadOnlyDictionary<string, IUnityServices> get_Services() { }

	[CompilerGenerated]
	// RVA: 0x2B99740 Offset: 0x2B98140 VA: 0x182B99740
	internal static TaskCompletionSource<object> get_InstantiationCompletion() { }

	[CompilerGenerated]
	// RVA: 0x2B99E40 Offset: 0x2B98840 VA: 0x182B99E40
	internal static void set_InstantiationCompletion(TaskCompletionSource<object> value) { }

	[CompilerGenerated]
	// RVA: 0x2B99AC0 Offset: 0x2B984C0 VA: 0x182B99AC0
	private static Dictionary<string, IUnityServices> get_s_Services() { }

	// RVA: 0x2B99820 Offset: 0x2B98220 VA: 0x182B99820
	public static ServicesInitializationState get_State() { }

	// RVA: 0x2B99690 Offset: 0x2B98090 VA: 0x182B99690
	public static string get_ExternalUserId() { }

	// RVA: 0x2B99D30 Offset: 0x2B98730 VA: 0x182B99D30
	public static void set_ExternalUserId(string value) { }

	// RVA: 0x2B99210 Offset: 0x2B97C10 VA: 0x182B99210
	public static Task InitializeAsync() { }

	[PreserveDependency("EnableServicesInitializationAsync()", "Unity.Services.Core.Internal.UnityServicesInitializer", "Unity.Services.Core.Internal")]
	[PreserveDependency("CreateStaticInstance()", "Unity.Services.Core.Internal.UnityServicesInitializer", "Unity.Services.Core.Internal")]
	[PreserveDependency("Register()", "Unity.Services.Core.Registration.CorePackageInitializer", "Unity.Services.Core.Registration")]
	[AsyncStateMachine(typeof(UnityServices.<InitializeAsync>d__26))]
	[PreserveDependency("CaptureUnityThreadInfo()", "Unity.Services.Core.UnityThreadUtils", "Unity.Services.Core")]
	// RVA: 0x2B99140 Offset: 0x2B97B40 VA: 0x182B99140
	public static Task InitializeAsync(InitializationOptions options) { }

	// RVA: 0x2B98DF0 Offset: 0x2B977F0 VA: 0x182B98DF0
	public static IUnityServices CreateServices() { }

	// RVA: 0x2B98E70 Offset: 0x2B97870 VA: 0x182B98E70
	public static IUnityServices CreateServices(string servicesId) { }

	// RVA: 0x2B98D50 Offset: 0x2B97750 VA: 0x182B98D50
	internal static void ClearServices() { }

	// RVA: 0x2B99390 Offset: 0x2B97D90 VA: 0x182B99390
	private static void .cctor() { }
}
