public class Context // TypeDefIndex: 4315
{
	// Fields
	private int domain_id; // 0x10
	private int context_id; // 0x14
	private UIntPtr static_data; // 0x18
	private UIntPtr data; // 0x20
	[ContextStatic]
	private static object[] local_slots; // 0x0
	private static IMessageSink default_server_context_sink; // 0x8
	private IMessageSink server_context_sink_chain; // 0x28
	private IMessageSink client_context_sink_chain; // 0x30
	private List<IContextProperty> context_properties; // 0x38
	private static int global_count; // 0x10
	private LocalDataStoreHolder _localDataStore; // 0x40
	private static LocalDataStoreMgr _localDataStoreMgr; // 0x18
	private static DynamicPropertyCollection global_dynamic_properties; // 0x20
	private DynamicPropertyCollection context_dynamic_properties; // 0x48
	private ContextCallbackObject callback_object; // 0x50

	// Properties
	public static Context DefaultContext { get; }
	public virtual int ContextID { get; }
	public virtual IContextProperty[] ContextProperties { get; }
	internal bool IsDefaultContext { get; }
	internal bool NeedsContextSink { get; }
	internal static bool HasGlobalDynamicSinks { get; }
	internal bool HasDynamicSinks { get; }
	internal bool HasExitSinks { get; }
	private LocalDataStore MyLocalStore { get; }

	// Methods

	// RVA: 0x1B0C260 Offset: 0x1B0AC60 VA: 0x181B0C260
	private static void RegisterContext(Context ctx) { }

	// RVA: 0x1B0C470 Offset: 0x1B0AE70 VA: 0x181B0C470
	private static void ReleaseContext(Context ctx) { }

	// RVA: 0x1B0C990 Offset: 0x1B0B390 VA: 0x181B0C990
	public void .ctor() { }

	// RVA: 0x1B0B6E0 Offset: 0x1B0A0E0 VA: 0x181B0B6E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1B0CA70 Offset: 0x1B0B470 VA: 0x181B0CA70
	public static Context get_DefaultContext() { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70 Slot: 4
	public virtual int get_ContextID() { }

	// RVA: 0x1B0CA10 Offset: 0x1B0B410 VA: 0x181B0CA10 Slot: 5
	public virtual IContextProperty[] get_ContextProperties() { }

	// RVA: 0x1B0CCF0 Offset: 0x1B0B6F0 VA: 0x181B0CCF0
	internal bool get_IsDefaultContext() { }

	// RVA: 0x1B0CE80 Offset: 0x1B0B880 VA: 0x181B0CE80
	internal bool get_NeedsContextSink() { }

	// RVA: 0x1B0C270 Offset: 0x1B0AC70 VA: 0x181B0C270
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1B0C710 Offset: 0x1B0B110 VA: 0x181B0C710
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1B0BB60 Offset: 0x1B0A560 VA: 0x181B0BB60
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1B0C140 Offset: 0x1B0AB40 VA: 0x181B0C140
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1B0CC40 Offset: 0x1B0B640 VA: 0x181B0CC40
	internal static bool get_HasGlobalDynamicSinks() { }

	// RVA: 0x1B0C0A0 Offset: 0x1B0AAA0 VA: 0x181B0C0A0
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1B0CA80 Offset: 0x1B0B480 VA: 0x181B0CA80
	internal bool get_HasDynamicSinks() { }

	// RVA: 0x1B0CAD0 Offset: 0x1B0B4D0 VA: 0x181B0CAD0
	internal bool get_HasExitSinks() { }

	// RVA: 0x1B0BD80 Offset: 0x1B0A780 VA: 0x181B0BD80 Slot: 6
	public virtual IContextProperty GetProperty(string name) { }

	// RVA: 0x1B0C4D0 Offset: 0x1B0AED0 VA: 0x181B0C4D0 Slot: 7
	public virtual void SetProperty(IContextProperty prop) { }

	// RVA: 0x1B0B7E0 Offset: 0x1B0A1E0 VA: 0x181B0B7E0 Slot: 8
	public virtual void Freeze() { }

	// RVA: 0x1B0C6C0 Offset: 0x1B0B0C0 VA: 0x181B0C6C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B0BEF0 Offset: 0x1B0A8F0 VA: 0x181B0BEF0
	internal IMessageSink GetServerContextSinkChain() { }

	// RVA: 0x1B0B990 Offset: 0x1B0A390 VA: 0x181B0B990
	internal IMessageSink GetClientContextSinkChain() { }

	// RVA: 0x1B0B440 Offset: 0x1B09E40 VA: 0x181B0B440
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x1B0ABF0 Offset: 0x1B095F0 VA: 0x181B0ABF0
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	// RVA: 0x1B0C6B0 Offset: 0x1B0B0B0 VA: 0x181B0C6B0
	internal static Context SwitchToContext(Context newContext) { }

	// RVA: 0x1B0AD80 Offset: 0x1B09780 VA: 0x181B0AD80
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	// RVA: 0x1B0B5B0 Offset: 0x1B09FB0 VA: 0x181B0B5B0
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x1B0CD00 Offset: 0x1B0B700 VA: 0x181B0CD00
	private LocalDataStore get_MyLocalStore() { }

	// RVA: 0x1B0AB20 Offset: 0x1B09520 VA: 0x181B0AB20
	public static LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x1B0AB80 Offset: 0x1B09580 VA: 0x181B0AB80
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x1B0B770 Offset: 0x1B0A170 VA: 0x181B0B770
	public static void FreeNamedDataSlot(string name) { }

	// RVA: 0x1B0BD10 Offset: 0x1B0A710 VA: 0x181B0BD10
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x1B0BB20 Offset: 0x1B0A520 VA: 0x181B0BB20
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x1B0C480 Offset: 0x1B0AE80 VA: 0x181B0C480
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1B0C910 Offset: 0x1B0B310 VA: 0x181B0C910
	private static void .cctor() { }
}
