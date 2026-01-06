public static class RemotingServices // TypeDefIndex: 4288
{
	// Fields
	private static Hashtable uri_hash; // 0x0
	private static BinaryFormatter _serializationFormatter; // 0x8
	private static BinaryFormatter _deserializationFormatter; // 0x10
	private static string app_id; // 0x18
	private static readonly object app_id_lock; // 0x20
	private static int next_id; // 0x28
	private static readonly MethodInfo FieldSetterMethod; // 0x30
	private static readonly MethodInfo FieldGetterMethod; // 0x38

	// Methods

	// RVA: 0x1B1AC70 Offset: 0x1B19670 VA: 0x181B1AC70
	private static void .cctor() { }

	// RVA: 0x1B19AD0 Offset: 0x1B184D0 VA: 0x181B19AD0
	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	// RVA: 0x1B19330 Offset: 0x1B17D30 VA: 0x181B19330
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	// RVA: 0x1B19B70 Offset: 0x1B18570 VA: 0x181B19B70
	public static bool IsTransparentProxy(object proxy) { }

	// RVA: 0x1B19340 Offset: 0x1B17D40 VA: 0x181B19340
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisible(True)]
	// RVA: 0x1B16960 Offset: 0x1B15360 VA: 0x181B16960
	public static object Connect(Type classToProxy, string url) { }

	[ComVisible(True)]
	// RVA: 0x1B16870 Offset: 0x1B15270 VA: 0x181B16870
	public static object Connect(Type classToProxy, string url, object data) { }

	// RVA: 0x1B19290 Offset: 0x1B17C90 VA: 0x181B19290
	public static Type GetServerTypeForUri(string URI) { }

	// RVA: 0x1B1A700 Offset: 0x1B19100 VA: 0x181B1A700
	public static object Unmarshal(ObjRef objectRef) { }

	// RVA: 0x1B1A750 Offset: 0x1B19150 VA: 0x181B1A750
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	// RVA: 0x1B19C30 Offset: 0x1B18630 VA: 0x181B19C30
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	// RVA: 0x1B19BB0 Offset: 0x1B185B0 VA: 0x181B19BB0
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	// RVA: 0x1B19C80 Offset: 0x1B18680 VA: 0x181B19C80
	private static string NewUri() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1B191D0 Offset: 0x1B17BD0 VA: 0x181B191D0
	public static RealProxy GetRealProxy(object proxy) { }

	// RVA: 0x1B183F0 Offset: 0x1B16DF0 VA: 0x181B183F0
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	// RVA: 0x1B185F0 Offset: 0x1B16FF0 VA: 0x181B185F0
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	// RVA: 0x1B17840 Offset: 0x1B16240 VA: 0x181B17840
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	// RVA: 0x1B18860 Offset: 0x1B17260 VA: 0x181B18860
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B19AE0 Offset: 0x1B184E0 VA: 0x181B19AE0
	public static bool IsOneWay(MethodBase method) { }

	// RVA: 0x1B17040 Offset: 0x1B15A40 VA: 0x181B17040
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	// RVA: 0x1B16CC0 Offset: 0x1B156C0 VA: 0x181B16CC0
	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	// RVA: 0x1B16F10 Offset: 0x1B15910 VA: 0x181B16F10
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	// RVA: 0x1B16AF0 Offset: 0x1B154F0 VA: 0x181B16AF0
	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	// RVA: 0x1B17D60 Offset: 0x1B16760 VA: 0x181B17D60
	internal static Identity GetIdentityForUri(string uri) { }

	// RVA: 0x1B1A210 Offset: 0x1B18C10 VA: 0x181B1A210
	private static string RemoveAppNameFromUri(string uri) { }

	// RVA: 0x1B18910 Offset: 0x1B17310 VA: 0x181B18910
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	// RVA: 0x1B17980 Offset: 0x1B16380 VA: 0x181B17980
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	// RVA: 0x1B17150 Offset: 0x1B15B50 VA: 0x181B17150
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	// RVA: 0x1B16A40 Offset: 0x1B15440 VA: 0x181B16A40
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	// RVA: 0x1B17250 Offset: 0x1B15C50 VA: 0x181B17250
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x1B1A000 Offset: 0x1B18A00 VA: 0x181B1A000
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	// RVA: 0x1B190D0 Offset: 0x1B17AD0 VA: 0x181B190D0
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	// RVA: 0x1B19220 Offset: 0x1B17C20 VA: 0x181B19220
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	// RVA: 0x1B1A310 Offset: 0x1B18D10 VA: 0x181B1A310
	internal static byte[] SerializeCallData(object obj) { }

	// RVA: 0x1B17380 Offset: 0x1B15D80 VA: 0x181B17380
	internal static object DeserializeCallData(byte[] array) { }

	// RVA: 0x1B1A550 Offset: 0x1B18F50 VA: 0x181B1A550
	internal static byte[] SerializeExceptionData(Exception ex) { }

	// RVA: 0x1B17AB0 Offset: 0x1B164B0 VA: 0x181B17AB0
	internal static object GetDomainProxy(AppDomain domain) { }

	// RVA: 0x1B19FC0 Offset: 0x1B189C0 VA: 0x181B19FC0
	private static void RegisterInternalChannels() { }

	// RVA: 0x1B175F0 Offset: 0x1B15FF0 VA: 0x181B175F0
	internal static void DisposeIdentity(Identity ident) { }

	// RVA: 0x1B180B0 Offset: 0x1B16AB0 VA: 0x181B180B0
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	// RVA: 0x1B1A640 Offset: 0x1B19040 VA: 0x181B1A640
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	// RVA: 0x1B1AAD0 Offset: 0x1B194D0 VA: 0x181B1AAD0
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	// RVA: 0x1B187F0 Offset: 0x1B171F0 VA: 0x181B187F0
	private static string GetNormalizedUri(string uri) { }
}
