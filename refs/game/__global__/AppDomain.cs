public sealed class AppDomain : MarshalByRefObject // TypeDefIndex: 3830
{
	// Fields
	private IntPtr _mono_app_domain; // 0x18
	private static string _process_guid; // 0x0
	[ThreadStatic]
	private static Dictionary<string, object> type_resolve_in_progress; // 0x80000000
	[ThreadStatic]
	private static Dictionary<string, object> assembly_resolve_in_progress; // 0x80000008
	[ThreadStatic]
	private static Dictionary<string, object> assembly_resolve_in_progress_refonly; // 0x80000010
	private object _evidence; // 0x20
	private object _granted; // 0x28
	private int _principalPolicy; // 0x30
	private static AppDomain default_domain; // 0x8
	[CompilerGenerated]
	private AssemblyLoadEventHandler AssemblyLoad; // 0x38
	[CompilerGenerated]
	private ResolveEventHandler AssemblyResolve; // 0x40
	[CompilerGenerated]
	private EventHandler DomainUnload; // 0x48
	[CompilerGenerated]
	private EventHandler ProcessExit; // 0x50
	[CompilerGenerated]
	private ResolveEventHandler ResourceResolve; // 0x58
	[CompilerGenerated]
	private ResolveEventHandler TypeResolve; // 0x60
	[CompilerGenerated]
	private UnhandledExceptionEventHandler UnhandledException; // 0x68
	[CompilerGenerated]
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; // 0x70
	private object _domain_manager; // 0x78
	[CompilerGenerated]
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; // 0x80
	private object _activation; // 0x88
	private object _applicationIdentity; // 0x90
	private List<string> compatibility_switch; // 0x98

	// Properties
	public static AppDomain CurrentDomain { get; }
	internal static AppDomain DefaultDomain { get; }
	[MonoTODO]
	public bool IsHomogenous { get; }
	[MonoTODO]
	public bool IsFullyTrusted { get; }

	// Methods

	[Intrinsic]
	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	internal static bool IsAppXModel() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void .ctor() { }

	// RVA: 0x1CB9740 Offset: 0x1CB8140 VA: 0x181CB9740
	private string getFriendlyName() { }

	// RVA: 0x1CB99D0 Offset: 0x1CB83D0 VA: 0x181CB99D0
	private static AppDomain getCurDomain() { }

	// RVA: 0x1CB99D0 Offset: 0x1CB83D0 VA: 0x181CB99D0
	public static AppDomain get_CurrentDomain() { }

	// RVA: 0x1CB99F0 Offset: 0x1CB83F0 VA: 0x181CB99F0
	private static AppDomain getRootDomain() { }

	// RVA: 0x1CB9A00 Offset: 0x1CB8400 VA: 0x181CB9A00
	internal static AppDomain get_DefaultDomain() { }

	// RVA: 0x1CB8C20 Offset: 0x1CB7620 VA: 0x181CB8C20
	private Assembly[] GetAssemblies(bool refOnly) { }

	// RVA: 0x1CB8C10 Offset: 0x1CB7610 VA: 0x181CB8C10 Slot: 6
	public Assembly[] GetAssemblies() { }

	// RVA: 0x1CB8C30 Offset: 0x1CB7630 VA: 0x181CB8C30 Slot: 7
	public object GetData(string name) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 5
	public override object InitializeLifetimeService() { }

	// RVA: 0x1CB9290 Offset: 0x1CB7C90 VA: 0x181CB9290
	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark) { }

	// RVA: 0x1CB92A0 Offset: 0x1CB7CA0 VA: 0x181CB92A0
	internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError, ref StackCrawlMark stackMark) { }

	// RVA: 0x1CB94D0 Offset: 0x1CB7ED0 VA: 0x181CB94D0 Slot: 8
	public Assembly Load(string assemblyString) { }

	// RVA: 0x1CB93B0 Offset: 0x1CB7DB0 VA: 0x181CB93B0
	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark) { }

	// RVA: 0x1CB8E20 Offset: 0x1CB7820 VA: 0x181CB8E20
	private static AppDomain InternalSetDomainByID(int domain_id) { }

	// RVA: 0x1CB8E30 Offset: 0x1CB7830 VA: 0x181CB8E30
	private static AppDomain InternalSetDomain(AppDomain context) { }

	// RVA: 0x1CB8E00 Offset: 0x1CB7800 VA: 0x181CB8E00
	internal static void InternalPushDomainRef(AppDomain domain) { }

	// RVA: 0x1CB8DF0 Offset: 0x1CB77F0 VA: 0x181CB8DF0
	internal static void InternalPushDomainRefByID(int domain_id) { }

	// RVA: 0x1CB8DE0 Offset: 0x1CB77E0 VA: 0x181CB8DE0
	internal static void InternalPopDomainRef() { }

	// RVA: 0x1CB8E10 Offset: 0x1CB7810 VA: 0x181CB8E10
	internal static Context InternalSetContext(Context context) { }

	// RVA: 0x1CB8DC0 Offset: 0x1CB77C0 VA: 0x181CB8DC0
	internal static Context InternalGetContext() { }

	// RVA: 0x1CB8DC0 Offset: 0x1CB77C0 VA: 0x181CB8DC0
	internal static Context InternalGetDefaultContext() { }

	// RVA: 0x1CB8DD0 Offset: 0x1CB77D0 VA: 0x181CB8DD0
	internal static string InternalGetProcessGuid(string newguid) { }

	// RVA: 0x1CB8FC0 Offset: 0x1CB79C0 VA: 0x181CB8FC0
	internal static object InvokeInDomain(AppDomain domain, MethodInfo method, object obj, object[] args) { }

	// RVA: 0x1CB8E40 Offset: 0x1CB7840 VA: 0x181CB8E40
	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) { }

	// RVA: 0x1CB8D10 Offset: 0x1CB7710 VA: 0x181CB8D10
	internal static string GetProcessGuid() { }

	// RVA: 0x1A88A80 Offset: 0x1A87480 VA: 0x181A88A80
	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	// RVA: 0x1CB9270 Offset: 0x1CB7C70 VA: 0x181CB9270
	public bool IsFinalizingForUnload() { }

	// RVA: 0x1CB99E0 Offset: 0x1CB83E0 VA: 0x181CB99E0
	private int getDomainID() { }

	// RVA: 0x1CB9740 Offset: 0x1CB8140 VA: 0x181CB9740 Slot: 3
	public override string ToString() { }

	// RVA: 0x1CB8330 Offset: 0x1CB6D30 VA: 0x181CB8330
	private void DoAssemblyLoad(Assembly assembly) { }

	// RVA: 0x1CB83C0 Offset: 0x1CB6DC0 VA: 0x181CB83C0
	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	// RVA: 0x1CB88F0 Offset: 0x1CB72F0 VA: 0x181CB88F0
	internal Assembly DoTypeResolve(string name) { }

	// RVA: 0x1CB8780 Offset: 0x1CB7180 VA: 0x181CB8780
	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	// RVA: 0x1CB8750 Offset: 0x1CB7150 VA: 0x181CB8750
	private void DoDomainUnload() { }

	// RVA: 0x1CB8C40 Offset: 0x1CB7640 VA: 0x181CB8C40
	internal byte[] GetMarshalledDomainObjRef() { }

	// RVA: 0x1CB9600 Offset: 0x1CB8000 VA: 0x181CB9600
	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGenerated]
	// RVA: 0x1CB9750 Offset: 0x1CB8150 VA: 0x181CB9750 Slot: 9
	public void add_AssemblyResolve(ResolveEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1CB9B30 Offset: 0x1CB8530 VA: 0x181CB9B30 Slot: 10
	public void remove_AssemblyResolve(ResolveEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1CB97F0 Offset: 0x1CB81F0 VA: 0x181CB97F0 Slot: 11
	public void add_DomainUnload(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1CB9BD0 Offset: 0x1CB85D0 VA: 0x181CB9BD0 Slot: 12
	public void remove_DomainUnload(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1CB9890 Offset: 0x1CB8290 VA: 0x181CB9890 Slot: 13
	public void add_ProcessExit(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1CB9C70 Offset: 0x1CB8670 VA: 0x181CB9C70 Slot: 14
	public void remove_ProcessExit(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1CB9930 Offset: 0x1CB8330 VA: 0x181CB9930 Slot: 15
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1CB9D10 Offset: 0x1CB8710 VA: 0x181CB9D10 Slot: 16
	public void remove_UnhandledException(UnhandledExceptionEventHandler value) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	public bool get_IsHomogenous() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	public bool get_IsFullyTrusted() { }

	// RVA: 0x1CB9140 Offset: 0x1CB7B40 VA: 0x181CB9140
	public bool IsDefaultAppDomain() { }
}
