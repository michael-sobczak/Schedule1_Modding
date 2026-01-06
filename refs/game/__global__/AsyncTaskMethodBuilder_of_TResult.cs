public struct AsyncTaskMethodBuilder<TResult> // TypeDefIndex: 4628
{
	// Fields
	internal static readonly Task<TResult> s_defaultResultTask; // 0x0
	private AsyncMethodBuilderCore m_coreState; // 0x0
	private Task<TResult> m_task; // 0x0

	// Properties
	public Task<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFD3B50 Offset: 0xFD2550 VA: 0x180FD3B50
	|-AsyncTaskMethodBuilder<Nullable<bool>>.Create
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.Create
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.Create
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.Create
	|-AsyncTaskMethodBuilder<Nullable<double>>.Create
	|-AsyncTaskMethodBuilder<Nullable<int>>.Create
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.Create
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.Create
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.Create
	|-AsyncTaskMethodBuilder<bool>.Create
	|-AsyncTaskMethodBuilder<char>.Create
	|-AsyncTaskMethodBuilder<int>.Create
	|-AsyncTaskMethodBuilder<object>.Create
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.Create
	|-AsyncTaskMethodBuilder<VoidTaskResult>.Create
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.Create
	*/

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDB8AA0 Offset: 0xDB74A0 VA: 0x180DB8AA0
	|-AsyncTaskMethodBuilder<Nullable<bool>>.Start<JsonTextReader.<DoReadAsBooleanAsync>d__40>
	|
	|-RVA: 0xDB8C20 Offset: 0xDB7620 VA: 0x180DB8C20
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.Start<JsonTextReader.<DoReadAsDateTimeAsync>d__45>
	|
	|-RVA: 0xDB8CE0 Offset: 0xDB76E0 VA: 0x180DB8CE0
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.Start<JsonTextReader.<DoReadAsDateTimeOffsetAsync>d__47>
	|
	|-RVA: 0xDB8DA0 Offset: 0xDB77A0 VA: 0x180DB8DA0
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.Start<JsonTextReader.<DoReadAsDecimalAsync>d__49>
	|
	|-RVA: 0xDB8E60 Offset: 0xDB7860 VA: 0x180DB8E60
	|-AsyncTaskMethodBuilder<Nullable<double>>.Start<JsonTextReader.<DoReadAsDoubleAsync>d__51>
	|
	|-RVA: 0xDB9EE0 Offset: 0xDB88E0 VA: 0x180DB9EE0
	|-AsyncTaskMethodBuilder<Nullable<int>>.Start<AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0xDB8F20 Offset: 0xDB7920 VA: 0x180DB8F20
	|-AsyncTaskMethodBuilder<Nullable<int>>.Start<JsonTextReader.<DoReadAsInt32Async>d__53>
	|
	|-RVA: 0xDBC820 Offset: 0xDBB220 VA: 0x180DBC820
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.Start<WebCompletionSource.<WaitForCompletion>d__15<ValueTuple<bool, object>>>
	|
	|-RVA: 0xDBBB60 Offset: 0xDBA560 VA: 0x180DBBB60
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.Start<WebConnectionTunnel.<ReadHeaders>d__43>
	|
	|-RVA: 0xDB99A0 Offset: 0xDB83A0 VA: 0x180DB99A0
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.Start<HttpWebRequest.<GetResponseFromData>d__244>
	|
	|-RVA: 0xDBA4E0 Offset: 0xDB8EE0 VA: 0x180DBA4E0
	|-AsyncTaskMethodBuilder<bool>.Start<JsonReader.<MoveToContentFromNonContentAsync>d__14>
	|
	|-RVA: 0xDBB0E0 Offset: 0xDB9AE0 VA: 0x180DBB0E0
	|-AsyncTaskMethodBuilder<bool>.Start<JsonReader.<ReadAndMoveToContentAsync>d__12>
	|
	|-RVA: 0xDB90A0 Offset: 0xDB7AA0 VA: 0x180DB90A0
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<DoReadAsync>d__3>
	|
	|-RVA: 0xDBA360 Offset: 0xDB8D60 VA: 0x180DBA360
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<MatchValueAsync>d__19>
	|
	|-RVA: 0xDBA420 Offset: 0xDB8E20 VA: 0x180DBA420
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<MatchValueWithTrailingSeparatorAsync>d__20>
	|
	|-RVA: 0xDBA8A0 Offset: 0xDB92A0 VA: 0x180DBA8A0
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<ParseObjectAsync>d__15>
	|
	|-RVA: 0xDBA960 Offset: 0xDB9360 VA: 0x180DBA960
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<ParsePostValueAsync>d__4>
	|
	|-RVA: 0xDBAA20 Offset: 0xDB9420 VA: 0x180DBAA20
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<ParsePropertyAsync>d__31>
	|
	|-RVA: 0xDBABA0 Offset: 0xDB95A0 VA: 0x180DBABA0
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<ParseValueAsync>d__8>
	|
	|-RVA: 0xDBB860 Offset: 0xDBA260 VA: 0x180DBB860
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<ReadCharsAsync>d__14>
	|
	|-RVA: 0xDBBAA0 Offset: 0xDBA4A0 VA: 0x180DBBAA0
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<ReadFromFinishedAsync>d__5>
	|
	|-RVA: 0xDBBC20 Offset: 0xDBA620 VA: 0x180DBBC20
	|-AsyncTaskMethodBuilder<bool>.Start<JsonTextReader.<ReadNullCharAsync>d__34>
	|
	|-RVA: 0xDBC8E0 Offset: 0xDBB2E0 VA: 0x180DBC8E0
	|-AsyncTaskMethodBuilder<bool>.Start<SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32>
	|
	|-RVA: 0xDBC6A0 Offset: 0xDBB0A0 VA: 0x180DBC6A0
	|-AsyncTaskMethodBuilder<bool>.Start<ServicePointScheduler.<WaitAsync>d__46>
	|
	|-RVA: 0xDB8920 Offset: 0xDB7320 VA: 0x180DB8920
	|-AsyncTaskMethodBuilder<bool>.Start<WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0xDBAAE0 Offset: 0xDB94E0 VA: 0x180DBAAE0
	|-AsyncTaskMethodBuilder<char>.Start<JsonTextReader.<ParseUnicodeAsync>d__12>
	|
	|-RVA: 0xDBBF20 Offset: 0xDBA920 VA: 0x180DBBF20
	|-AsyncTaskMethodBuilder<int>.Start<HttpWebRequest.<RunWithTimeoutWorker>d__241<int>>
	|
	|-RVA: 0xDBADE0 Offset: 0xDB97E0 VA: 0x180DBADE0
	|-AsyncTaskMethodBuilder<int>.Start<BufferedReadStream.<ProcessReadAsync>d__2>
	|
	|-RVA: 0xDBB3E0 Offset: 0xDB9DE0 VA: 0x180DBB3E0
	|-AsyncTaskMethodBuilder<int>.Start<CryptoStream.<ReadAsyncCore>d__42>
	|
	|-RVA: 0xDBB4A0 Offset: 0xDB9EA0 VA: 0x180DBB4A0
	|-AsyncTaskMethodBuilder<int>.Start<CryptoStream.<ReadAsyncInternal>d__37>
	|
	|-RVA: 0xDBB320 Offset: 0xDB9D20 VA: 0x180DBB320
	|-AsyncTaskMethodBuilder<int>.Start<DeflateManagedStream.<ReadAsyncCore>d__40>
	|
	|-RVA: 0xDBAEA0 Offset: 0xDB98A0 VA: 0x180DBAEA0
	|-AsyncTaskMethodBuilder<int>.Start<FixedSizeReadStream.<ProcessReadAsync>d__5>
	|
	|-RVA: 0xDBB920 Offset: 0xDBA320 VA: 0x180DBB920
	|-AsyncTaskMethodBuilder<int>.Start<JsonTextReader.<ReadDataAsync>d__7>
	|
	|-RVA: 0xDB9FA0 Offset: 0xDB89A0 VA: 0x180DB9FA0
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0xDBC220 Offset: 0xDBAC20 VA: 0x180DBC220
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<StartOperation>d__57>
	|
	|-RVA: 0xDBAF60 Offset: 0xDB9960 VA: 0x180DBAF60
	|-AsyncTaskMethodBuilder<int>.Start<MonoChunkStream.<ProcessReadAsync>d__7>
	|
	|-RVA: 0xDBC460 Offset: 0xDBAE60 VA: 0x180DBC460
	|-AsyncTaskMethodBuilder<int>.Start<Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0xDBB560 Offset: 0xDB9F60 VA: 0x180DBB560
	|-AsyncTaskMethodBuilder<int>.Start<StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0xDBB7A0 Offset: 0xDBA1A0 VA: 0x180DBB7A0
	|-AsyncTaskMethodBuilder<int>.Start<StreamReader.<ReadBufferAsync>d__69>
	|
	|-RVA: 0xDBB620 Offset: 0xDBA020 VA: 0x180DBB620
	|-AsyncTaskMethodBuilder<int>.Start<WebReadStream.<ReadAsync>d__28>
	|
	|-RVA: 0xDBB6E0 Offset: 0xDBA0E0 VA: 0x180DBB6E0
	|-AsyncTaskMethodBuilder<int>.Start<WebResponseStream.<ReadAsync>d__40>
	|
	|-RVA: 0xDBBE60 Offset: 0xDBA860 VA: 0x180DBBE60
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<RunWithTimeoutWorker>d__241<object>>
	|
	|-RVA: 0xDBC760 Offset: 0xDBB160 VA: 0x180DBC760
	|-AsyncTaskMethodBuilder<object>.Start<WebCompletionSource.<WaitForCompletion>d__15<object>>
	|
	|-RVA: 0xDBC160 Offset: 0xDBAB60 VA: 0x180DBC160
	|-AsyncTaskMethodBuilder<object>.Start<AsyncProtocolRequest.<StartOperation>d__23>
	|
	|-RVA: 0xDB9760 Offset: 0xDB8160 VA: 0x180DB9760
	|-AsyncTaskMethodBuilder<object>.Start<CoreDiagnostics.<GetOrCreateDiagnosticsAsync>d__26>
	|
	|-RVA: 0xDB87A0 Offset: 0xDB71A0 VA: 0x180DB87A0
	|-AsyncTaskMethodBuilder<object>.Start<CorePackageInitializer.<CreateDiagnosticsComponents>d__61>
	|
	|-RVA: 0xDB9220 Offset: 0xDB7C20 VA: 0x180DB9220
	|-AsyncTaskMethodBuilder<object>.Start<CorePackageInitializer.<GenerateProjectConfigurationAsync>d__53>
	|
	|-RVA: 0xDB9B20 Offset: 0xDB8520 VA: 0x180DB9B20
	|-AsyncTaskMethodBuilder<object>.Start<CorePackageInitializer.<GetSerializedProjectConfigurationAsync>d__63>
	|
	|-RVA: 0xDB9E20 Offset: 0xDB8820 VA: 0x180DB9E20
	|-AsyncTaskMethodBuilder<object>.Start<CoreRegistryInitializer.<InitializeRegistryAsync>d__3>
	|
	|-RVA: 0xDB89E0 Offset: 0xDB73E0 VA: 0x180DB89E0
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapApiBase.<DeleteAsync>d__15>
	|
	|-RVA: 0xDB9160 Offset: 0xDB7B60 VA: 0x180DB9160
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapApiBase.<ExecuteRequestAsync>d__16>
	|
	|-RVA: 0xDB93A0 Offset: 0xDB7DA0 VA: 0x180DB93A0
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapApiBase.<GetAsync>d__14>
	|
	|-RVA: 0xDBAC60 Offset: 0xDB9660 VA: 0x180DBAC60
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapApiBase.<PatchAsync>d__13>
	|
	|-RVA: 0xDBAD20 Offset: 0xDB9720 VA: 0x180DBAD20
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapApiBase.<PostAsync>d__12>
	|
	|-RVA: 0xDB83E0 Offset: 0xDB6DE0 VA: 0x180DB83E0
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapAppApi.<CreateApp>d__1>
	|
	|-RVA: 0xDB84A0 Offset: 0xDB6EA0 VA: 0x180DB84A0
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapAppApi.<CreateAppVersion>d__4>
	|
	|-RVA: 0xDB92E0 Offset: 0xDB7CE0 VA: 0x180DB92E0
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapAppApi.<GetApp>d__2>
	|
	|-RVA: 0xDBC520 Offset: 0xDBAF20 VA: 0x180DBC520
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapAppApi.<UpdateAppVersion>d__3>
	|
	|-RVA: 0xDBC5E0 Offset: 0xDBAFE0 VA: 0x180DBC5E0
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapAppApi.<UpsertAppVersion>d__5>
	|
	|-RVA: 0xDB8260 Offset: 0xDB6C60 VA: 0x180DB8260
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapDeploymentsApi.<AwaitReadyStatusAsync>d__5>
	|
	|-RVA: 0xDB8320 Offset: 0xDB6D20 VA: 0x180DB8320
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapDeploymentsApi.<AwaitTerminatedDeleteStatusAsync>d__6>
	|
	|-RVA: 0xDB8620 Offset: 0xDB7020 VA: 0x180DB8620
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapDeploymentsApi.<CreateDeploymentAsync>d__1>
	|
	|-RVA: 0xDB86E0 Offset: 0xDB70E0 VA: 0x180DB86E0
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapDeploymentsApi.<CreateDeploymentAwaitReadyStatusAsync>d__4>
	|
	|-RVA: 0xDB9520 Offset: 0xDB7F20 VA: 0x180DB9520
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapDeploymentsApi.<GetDeploymentStatusAsync>d__2>
	|
	|-RVA: 0xDBC2E0 Offset: 0xDBACE0 VA: 0x180DBC2E0
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapDeploymentsApi.<StopActiveDeploymentAsync>d__3>
	|
	|-RVA: 0xDB9BE0 Offset: 0xDB85E0 VA: 0x180DB9BE0
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapIpApi.<GetYourPublicIp>d__1>
	|
	|-RVA: 0xDB9820 Offset: 0xDB8220 VA: 0x180DB9820
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapWizardApi.<GetRegistryCredentials>d__2>
	|
	|-RVA: 0xDB9D60 Offset: 0xDB8760 VA: 0x180DB9D60
	|-AsyncTaskMethodBuilder<object>.Start<EdgegapWizardApi.<InitQuickStart>d__1>
	|
	|-RVA: 0xDBC0A0 Offset: 0xDBAAA0 VA: 0x180DBC0A0
	|-AsyncTaskMethodBuilder<object>.Start<HttpClient.<SendAsyncWorker>d__47>
	|
	|-RVA: 0xDBB260 Offset: 0xDB9C60 VA: 0x180DBB260
	|-AsyncTaskMethodBuilder<object>.Start<HttpContent.<ReadAsStringAsync>d__20>
	|
	|-RVA: 0xDBC3A0 Offset: 0xDBADA0 VA: 0x180DBC3A0
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<<GetRewriteHandler>b__271_0>d>
	|
	|-RVA: 0xDBA5A0 Offset: 0xDB8FA0 VA: 0x180DBA5A0
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<MyGetResponseAsync>d__243>
	|
	|-RVA: 0xDBA120 Offset: 0xDB8B20 VA: 0x180DBA120
	|-AsyncTaskMethodBuilder<object>.Start<JArray.<LoadAsync>d__2>
	|
	|-RVA: 0xDBA060 Offset: 0xDB8A60 VA: 0x180DBA060
	|-AsyncTaskMethodBuilder<object>.Start<JConstructor.<LoadAsync>d__2>
	|
	|-RVA: 0xDBA1E0 Offset: 0xDB8BE0 VA: 0x180DBA1E0
	|-AsyncTaskMethodBuilder<object>.Start<JObject.<LoadAsync>d__2>
	|
	|-RVA: 0xDBA2A0 Offset: 0xDB8CA0 VA: 0x180DBA2A0
	|-AsyncTaskMethodBuilder<object>.Start<JProperty.<LoadAsync>d__4>
	|
	|-RVA: 0xDB8560 Offset: 0xDB6F60 VA: 0x180DB8560
	|-AsyncTaskMethodBuilder<object>.Start<JRaw.<CreateAsync>d__0>
	|
	|-RVA: 0xDBB9E0 Offset: 0xDBA3E0 VA: 0x180DBB9E0
	|-AsyncTaskMethodBuilder<object>.Start<JToken.<ReadFromAsync>d__3>
	|
	|-RVA: 0xDBB1A0 Offset: 0xDB9BA0 VA: 0x180DBB1A0
	|-AsyncTaskMethodBuilder<object>.Start<JsonReader.<ReadArrayIntoByteArrayAsync>d__5>
	|
	|-RVA: 0xDB8B60 Offset: 0xDB7560 VA: 0x180DB8B60
	|-AsyncTaskMethodBuilder<object>.Start<JsonTextReader.<DoReadAsBytesAsync>d__42>
	|
	|-RVA: 0xDB8FE0 Offset: 0xDB79E0 VA: 0x180DB8FE0
	|-AsyncTaskMethodBuilder<object>.Start<JsonTextReader.<DoReadAsStringAsync>d__55>
	|
	|-RVA: 0xDBA660 Offset: 0xDB9060 VA: 0x180DBA660
	|-AsyncTaskMethodBuilder<object>.Start<JsonTextReader.<ParseNumberNaNAsync>d__26>
	|
	|-RVA: 0xDBA720 Offset: 0xDB9120 VA: 0x180DBA720
	|-AsyncTaskMethodBuilder<object>.Start<JsonTextReader.<ParseNumberNegativeInfinityAsync>d__28>
	|
	|-RVA: 0xDBA7E0 Offset: 0xDB91E0 VA: 0x180DBA7E0
	|-AsyncTaskMethodBuilder<object>.Start<JsonTextReader.<ParseNumberPositiveInfinityAsync>d__27>
	|
	|-RVA: 0xDBBCE0 Offset: 0xDBA6E0 VA: 0x180DBBCE0
	|-AsyncTaskMethodBuilder<object>.Start<JsonTextReader.<ReadNumberValueAsync>d__38>
	|
	|-RVA: 0xDBBDA0 Offset: 0xDBA7A0 VA: 0x180DBBDA0
	|-AsyncTaskMethodBuilder<object>.Start<JsonTextReader.<ReadStringValueAsync>d__37>
	|
	|-RVA: 0xDB8860 Offset: 0xDB7260 VA: 0x180DB8860
	|-AsyncTaskMethodBuilder<object>.Start<MonoTlsStream.<CreateStream>d__18>
	|
	|-RVA: 0xDBBFE0 Offset: 0xDBA9E0 VA: 0x180DBBFE0
	|-AsyncTaskMethodBuilder<object>.Start<MonoWebRequestHandler.<SendAsync>d__99>
	|
	|-RVA: 0xDB9CA0 Offset: 0xDB86A0 VA: 0x180DB9CA0
	|-AsyncTaskMethodBuilder<object>.Start<WebConnection.<InitConnection>d__19>
	|
	|-RVA: 0xDB98E0 Offset: 0xDB82E0 VA: 0x180DB98E0
	|-AsyncTaskMethodBuilder<object>.Start<WebOperation.<GetRequestStream>d__50>
	|
	|-RVA: 0xDBB020 Offset: 0xDB9A20 VA: 0x180DBB020
	|-AsyncTaskMethodBuilder<object>.Start<WebResponseStream.<ReadAllAsyncInner>d__47>
	|
	|-RVA: 0xDB96A0 Offset: 0xDB80A0 VA: 0x180DB96A0
	|-AsyncTaskMethodBuilder<object>.Start<XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-RVA: 0xDB95E0 Offset: 0xDB7FE0 VA: 0x180DB95E0
	|-AsyncTaskMethodBuilder<object>.Start<XmlUrlResolver.<GetEntityAsync>d__15>
	|
	|-RVA: 0xDB9A60 Offset: 0xDB8460 VA: 0x180DB9A60
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.Start<CorePackageInitializer.<GetSerializedConfigOrEmptyAsync>d__54>
	|
	|-RVA: 0xDB9460 Offset: 0xDB7E60 VA: 0x180DB9460
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.Start<StreamingAssetsConfigurationLoader.<GetConfigAsync>d__2>
	|
	|-RVA: 0xDC4EC0 Offset: 0xDC38C0 VA: 0x180DC4EC0
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.Start<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AFC10 Offset: 0x12AE610 VA: 0x1812AFC10
	|-AsyncTaskMethodBuilder<Nullable<bool>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<double>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetStateMachine
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetStateMachine
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetStateMachine
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetStateMachine
	|-AsyncTaskMethodBuilder<bool>.SetStateMachine
	|-AsyncTaskMethodBuilder<char>.SetStateMachine
	|-AsyncTaskMethodBuilder<int>.SetStateMachine
	|-AsyncTaskMethodBuilder<object>.SetStateMachine
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.SetStateMachine
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetStateMachine
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDB4060 Offset: 0xDB2A60 VA: 0x180DB4060
	|-AsyncTaskMethodBuilder<Nullable<bool>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<DoReadAsBooleanAsync>d__40>
	|
	|-RVA: 0xDAFBD0 Offset: 0xDAE5D0 VA: 0x180DAFBD0
	|-AsyncTaskMethodBuilder<Nullable<bool>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<DoReadAsBooleanAsync>d__40>
	|
	|-RVA: 0xDACC50 Offset: 0xDAB650 VA: 0x180DACC50
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<DoReadAsDateTimeAsync>d__45>
	|
	|-RVA: 0xDACE30 Offset: 0xDAB830 VA: 0x180DACE30
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<DoReadAsDateTimeOffsetAsync>d__47>
	|
	|-RVA: 0xDAD010 Offset: 0xDABA10 VA: 0x180DAD010
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<DoReadAsDecimalAsync>d__49>
	|
	|-RVA: 0xDAD1F0 Offset: 0xDABBF0 VA: 0x180DAD1F0
	|-AsyncTaskMethodBuilder<Nullable<double>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<DoReadAsDoubleAsync>d__51>
	|
	|-RVA: 0xDB2630 Offset: 0xDB1030 VA: 0x180DB2630
	|-AsyncTaskMethodBuilder<Nullable<int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0xDAD3D0 Offset: 0xDABDD0 VA: 0x180DAD3D0
	|-AsyncTaskMethodBuilder<Nullable<int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<DoReadAsInt32Async>d__53>
	|
	|-RVA: 0xDAF3F0 Offset: 0xDADDF0 VA: 0x180DAF3F0
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebCompletionSource.<WaitForCompletion>d__15<ValueTuple<bool, object>>>
	|
	|-RVA: 0xDB3A40 Offset: 0xDB2440 VA: 0x180DB3A40
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebConnectionTunnel.<ReadHeaders>d__43>
	|
	|-RVA: 0xDADD60 Offset: 0xDAC760 VA: 0x180DADD60
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpWebRequest.<GetResponseFromData>d__244>
	|
	|-RVA: 0xDB03E0 Offset: 0xDAEDE0 VA: 0x180DB03E0
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<GetResponseFromData>d__244>
	|
	|-RVA: 0xDB3C50 Offset: 0xDB2650 VA: 0x180DB3C50
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonReader.<MoveToContentFromNonContentAsync>d__14>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonReader.<ReadAndMoveToContentAsync>d__12>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ReadNullCharAsync>d__34>
	|
	|-RVA: 0xDB4270 Offset: 0xDB2C70 VA: 0x180DB4270
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<DoReadAsync>d__3>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<MatchValueAsync>d__19>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<MatchValueWithTrailingSeparatorAsync>d__20>
	|
	|-RVA: 0xDB2C20 Offset: 0xDB1620 VA: 0x180DB2C20
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseObjectAsync>d__15>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParseObjectAsync>d__15>
	|
	|-RVA: 0xDAE1A0 Offset: 0xDACBA0 VA: 0x180DAE1A0
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseValueAsync>d__8>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParseValueAsync>d__8>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<ParseValueAsync>d__8>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32>
	|
	|-RVA: 0xDAF200 Offset: 0xDADC00 VA: 0x180DAF200
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ReadFromFinishedAsync>d__5>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ReadCharsAsync>d__14>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, ServicePointScheduler.<WaitAsync>d__46>
	|
	|-RVA: 0xDB2E20 Offset: 0xDB1820 VA: 0x180DB2E20
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParsePostValueAsync>d__4>
	|
	|-RVA: 0xDAC830 Offset: 0xDAB230 VA: 0x180DAC830
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0xDB0C00 Offset: 0xDAF600 VA: 0x180DB0C00
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseObjectAsync>d__15>
	|
	|-RVA: 0xDB0E00 Offset: 0xDAF800 VA: 0x180DB0E00
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParsePostValueAsync>d__4>
	|
	|-RVA: 0xDB1000 Offset: 0xDAFA00 VA: 0x180DB1000
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParsePropertyAsync>d__31>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadFromFinishedAsync>d__5>
	|
	|-RVA: 0xDB11F0 Offset: 0xDAFBF0 VA: 0x180DB11F0
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseValueAsync>d__8>
	|
	|-RVA: 0xDAF9C0 Offset: 0xDAE3C0 VA: 0x180DAF9C0
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0xDB4650 Offset: 0xDB3050 VA: 0x180DB4650
	|-AsyncTaskMethodBuilder<char>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseUnicodeAsync>d__12>
	|
	|-RVA: 0xDB3210 Offset: 0xDB1C10 VA: 0x180DB3210
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, HttpWebRequest.<RunWithTimeoutWorker>d__241<int>>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, BufferedReadStream.<ProcessReadAsync>d__2>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, DeflateManagedStream.<ReadAsyncCore>d__40>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, FixedSizeReadStream.<ProcessReadAsync>d__5>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MonoChunkStream.<ProcessReadAsync>d__7>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0xDB2820 Offset: 0xDB1220 VA: 0x180DB2820
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ReadDataAsync>d__7>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0xDB3610 Offset: 0xDB2010 VA: 0x180DB3610
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0xDB3840 Offset: 0xDB2240 VA: 0x180DB3840
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebReadStream.<ReadAsync>d__28>
	|
	|-RVA: 0xDAE7B0 Offset: 0xDAD1B0 VA: 0x180DAE7B0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<ReadAsync>d__40>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAsync>d__40>
	|
	|-RVA: 0xDAF010 Offset: 0xDADA10 VA: 0x180DAF010
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<StartOperation>d__57>
	|
	|-RVA: 0xDB4C20 Offset: 0xDB3620 VA: 0x180DB4C20
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0xDB4E50 Offset: 0xDB3850 VA: 0x180DB4E50
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, StreamReader.<ReadBufferAsync>d__69>
	|
	|-RVA: 0xDB6720 Offset: 0xDB5120 VA: 0x180DB6720
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CryptoStream.<ReadAsyncInternal>d__37>
	|
	|-RVA: 0xDB7E00 Offset: 0xDB6800 VA: 0x180DB7E00
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ValueTaskAwaiter<int>, CryptoStream.<ReadAsyncCore>d__42>
	|
	|-RVA: 0xDB5040 Offset: 0xDB3A40 VA: 0x180DB5040
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ForceAsyncAwaiter, CryptoStream.<ReadAsyncInternal>d__37>
	|
	|-RVA: 0xDB15E0 Offset: 0xDAFFE0 VA: 0x180DB15E0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebReadStream.<ReadAsync>d__28>
	|
	|-RVA: 0xDADF70 Offset: 0xDAC970 VA: 0x180DADF70
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>, HttpWebRequest.<MyGetResponseAsync>d__243>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpWebRequest.<MyGetResponseAsync>d__243>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MonoWebRequestHandler.<SendAsync>d__99>
	|
	|-RVA: 0xDB3410 Offset: 0xDB1E10 VA: 0x180DB3410
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, HttpWebRequest.<RunWithTimeoutWorker>d__241<object>>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<ReadAllAsyncInner>d__47>
	|
	|-RVA: 0xDAD980 Offset: 0xDAC380 VA: 0x180DAD980
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JArray.<LoadAsync>d__2>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JConstructor.<LoadAsync>d__2>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JObject.<LoadAsync>d__2>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JProperty.<LoadAsync>d__4>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, WebConnection.<InitConnection>d__19>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-RVA: 0xDAE9D0 Offset: 0xDAD3D0 VA: 0x180DAE9D0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JToken.<ReadFromAsync>d__3>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JToken.<ReadFromAsync>d__3>
	|
	|-RVA: 0xDAD790 Offset: 0xDAC190 VA: 0x180DAD790
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonReader.<ReadArrayIntoByteArrayAsync>d__5>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlUrlResolver.<GetEntityAsync>d__15>
	|
	|-RVA: 0xDACA40 Offset: 0xDAB440 VA: 0x180DACA40
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<DoReadAsBytesAsync>d__42>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ReadStringValueAsync>d__37>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpClient.<SendAsyncWorker>d__47>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<DoReadAsBytesAsync>d__42>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<ReadStringValueAsync>d__37>
	|
	|-RVA: 0xDB4460 Offset: 0xDB2E60 VA: 0x180DB4460
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseNumberNaNAsync>d__26>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseNumberNegativeInfinityAsync>d__28>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseNumberPositiveInfinityAsync>d__27>
	|
	|-RVA: 0xDAEC00 Offset: 0xDAD600 VA: 0x180DAEC00
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ReadNumberValueAsync>d__38>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<ReadNumberValueAsync>d__38>
	|
	|-RVA: 0xDADB80 Offset: 0xDAC580 VA: 0x180DADB80
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebCompletionSource.<WaitForCompletion>d__15<object>>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebOperation.<GetRequestStream>d__50>
	|
	|-RVA: 0xDAD5B0 Offset: 0xDABFB0 VA: 0x180DAD5B0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, JsonTextReader.<DoReadAsStringAsync>d__55>
	|
	|-RVA: 0xDB5BC0 Offset: 0xDB45C0 VA: 0x180DB5BC0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CoreDiagnostics.<GetOrCreateDiagnosticsAsync>d__26>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapIpApi.<GetYourPublicIp>d__1>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapWizardApi.<GetRegistryCredentials>d__2>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapWizardApi.<InitQuickStart>d__1>
	|
	|-RVA: 0xDB5810 Offset: 0xDB4210 VA: 0x180DB5810
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapApiBase.<DeleteAsync>d__15>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapApiBase.<GetAsync>d__14>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapApiBase.<PatchAsync>d__13>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapApiBase.<PostAsync>d__12>
	|
	|-RVA: 0xDB5630 Offset: 0xDB4030 VA: 0x180DB5630
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapApiBase.<ExecuteRequestAsync>d__16>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapAppApi.<CreateApp>d__1>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapAppApi.<CreateAppVersion>d__4>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapAppApi.<GetApp>d__2>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapAppApi.<UpdateAppVersion>d__3>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapAppApi.<UpsertAppVersion>d__5>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapDeploymentsApi.<CreateDeploymentAsync>d__1>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapDeploymentsApi.<GetDeploymentStatusAsync>d__2>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapDeploymentsApi.<StopActiveDeploymentAsync>d__3>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<SerializableProjectConfiguration>, CorePackageInitializer.<GenerateProjectConfigurationAsync>d__53>
	|
	|-RVA: 0xDB5440 Offset: 0xDB3E40 VA: 0x180DB5440
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapDeploymentsApi.<AwaitReadyStatusAsync>d__5>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapDeploymentsApi.<AwaitTerminatedDeleteStatusAsync>d__6>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, EdgegapDeploymentsApi.<CreateDeploymentAwaitReadyStatusAsync>d__4>
	|
	|-RVA: 0xDB6320 Offset: 0xDB4D20 VA: 0x180DB6320
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, HttpWebRequest.<MyGetResponseAsync>d__243>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, MonoWebRequestHandler.<SendAsync>d__99>
	|
	|-RVA: 0xDB6CF0 Offset: 0xDB56F0 VA: 0x180DB6CF0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, CorePackageInitializer.<CreateDiagnosticsComponents>d__61>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, CorePackageInitializer.<GetSerializedProjectConfigurationAsync>d__63>
	|
	|-RVA: 0xDB7270 Offset: 0xDB5C70 VA: 0x180DB7270
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, CoreRegistryInitializer.<InitializeRegistryAsync>d__3>
	|
	|-RVA: 0xDB6B00 Offset: 0xDB5500 VA: 0x180DB6B00
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, EdgegapDeploymentsApi.<AwaitReadyStatusAsync>d__5>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, EdgegapDeploymentsApi.<AwaitTerminatedDeleteStatusAsync>d__6>
	|
	|-RVA: 0xDB1E10 Offset: 0xDB0810 VA: 0x180DB1E10
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<StartOperation>d__23>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<<GetRewriteHandler>b__271_0>d>
	|
	|-RVA: 0xDAFDE0 Offset: 0xDAE7E0 VA: 0x180DAFDE0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpClient.<SendAsyncWorker>d__47>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<DoReadAsBytesAsync>d__42>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadStringValueAsync>d__37>
	|
	|-RVA: 0xDB1400 Offset: 0xDAFE00 VA: 0x180DB1400
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<ReadAsStringAsync>d__20>
	|
	|-RVA: 0xDB09D0 Offset: 0xDAF3D0 VA: 0x180DB09D0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<MyGetResponseAsync>d__243>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoWebRequestHandler.<SendAsync>d__99>
	|
	|-RVA: 0xDB05F0 Offset: 0xDAEFF0 VA: 0x180DB05F0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JArray.<LoadAsync>d__2>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JConstructor.<LoadAsync>d__2>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JObject.<LoadAsync>d__2>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JProperty.<LoadAsync>d__4>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<InitConnection>d__19>
	|
	|-RVA: 0xDAF7D0 Offset: 0xDAE1D0 VA: 0x180DAF7D0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JRaw.<CreateAsync>d__0>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoTlsStream.<CreateStream>d__18>
	|
	|-RVA: 0xDB19F0 Offset: 0xDB03F0 VA: 0x180DB19F0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadNumberValueAsync>d__38>
	|
	|-RVA: 0xDB59F0 Offset: 0xDB43F0 VA: 0x180DB59F0
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, StreamingAssetsConfigurationLoader.<GetConfigAsync>d__2>
	|
	|-RVA: 0xDB6550 Offset: 0xDB4F50 VA: 0x180DB6550
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.AwaitUnsafeOnCompleted<TaskAwaiter<SerializableProjectConfiguration>, CorePackageInitializer.<GetSerializedConfigOrEmptyAsync>d__54>
	|
	|-RVA: 0xDAF5D0 Offset: 0xDADFD0 VA: 0x180DAF5D0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<MatchAndSetAsync>d__21>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MonoChunkStream.<FinishReading>d__8>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0xDAEE10 Offset: 0xDAD810 VA: 0x180DAEE10
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>, WebConnectionTunnel.<Initialize>d__42>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonWriter.<WriteConstructorDateAsync>d__32>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, ServicePointScheduler.<RunScheduler>d__32>
	|
	|-RVA: 0xDAE5A0 Offset: 0xDACFA0 VA: 0x180DAE5A0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JContainer.<ReadContentFromAsync>d__1>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseConstructorAsync>d__25>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParseConstructorAsync>d__25>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAllAsync>d__48>
	|
	|-RVA: 0xDB2A10 Offset: 0xDB1410 VA: 0x180DB2A10
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JContainer.<ReadTokenFromAsync>d__0>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseCommentAsync>d__16>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonWriter.<WriteTokenAsync>d__30>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParseCommentAsync>d__16>
	|
	|-RVA: 0xDB4830 Offset: 0xDB3230 VA: 0x180DB4830
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonReader.<ReaderReadAndAssertAsync>d__2>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ProcessCarriageReturnAsync>d__11>
	|
	|-RVA: 0xDB3020 Offset: 0xDB1A20 VA: 0x180DB3020
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonReader.<SkipAsync>d__1>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParseUnquotedPropertyAsync>d__33>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ReadNumberIntoBufferAsync>d__32>
	|
	|-RVA: 0xDAE3B0 Offset: 0xDACDB0 VA: 0x180DAE3B0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<HandleNullAsync>d__35>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ReadFinishedAsync>d__36>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonWriter.<WriteTokenSyncReadingAsync>d__31>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<EatWhitespaceAsync>d__17>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<InitReadAsync>d__52>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__48>
	|
	|-RVA: 0xDB3E30 Offset: 0xDB2830 VA: 0x180DB3E30
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<char>, JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|
	|-RVA: 0xDB4A10 Offset: 0xDB3410 VA: 0x180DB4A10
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, Stream.<CopyToAsyncInternal>d__28>
	|
	|-RVA: 0xDB5F60 Offset: 0xDB4960 VA: 0x180DB5F60
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CorePackageInitializer.<InitializeProjectConfigAsync>d__52>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, UnityServices.<InitializeAsync>d__26>
	|
	|-RVA: 0xDB5D90 Offset: 0xDB4790 VA: 0x180DB5D90
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, PollManager.<InitAppTicket>d__30>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, UnityServicesInternal.<>c__DisplayClass33_0.<<InitializeServicesAsync>g__InitializePackagesAsync|1>d>
	|
	|-RVA: 0xDB6140 Offset: 0xDB4B40 VA: 0x180DB6140
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, UnityServicesInternal.<InitializeAsync>d__27>
	|
	|-RVA: 0xDB5240 Offset: 0xDB3C40 VA: 0x180DB5240
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ForceAsyncAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0xDB6920 Offset: 0xDB5320 VA: 0x180DB6920
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, ButtonShaker.<ApplyShakeAsync>d__4>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServicesInternal.<InitializeAsync>d__27>
	|
	|-RVA: 0xDB7090 Offset: 0xDB5A90 VA: 0x180DB7090
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, ButtonShaker.<shakeOnce>d__5>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServices.<InitializeAsync>d__26>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServicesInternal.<InitializeServicesAsync>d__33>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__InitializePackageAsync|2>d>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d>
	|
	|-RVA: 0xDB7640 Offset: 0xDB6040 VA: 0x180DB7640
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, CoreDiagnostics.<SendCoreDiagnosticsAsync>d__24>
	|
	|-RVA: 0xDB6EC0 Offset: 0xDB58C0 VA: 0x180DB6EC0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, CorePackageInitializer.<InitializeComponents>d__47>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Ua2CoreInitializeCallback.<Initialize>d__1>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServicesInternal.<EnableInitializationAsync>d__36>
	|
	|-RVA: 0xDB7A10 Offset: 0xDB6410 VA: 0x180DB7A10
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0xDB7450 Offset: 0xDB5E50 VA: 0x180DB7450
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0xDB7810 Offset: 0xDB6210 VA: 0x180DB7810
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0xDB7C10 Offset: 0xDB6610 VA: 0x180DB7C10
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0xDB8020 Offset: 0xDB6A20 VA: 0x180DB8020
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, CryptoStream.<WriteAsyncCore>d__49>
	|
	|-RVA: 0xDB01E0 Offset: 0xDAEBE0 VA: 0x180DB01E0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Base64Encoder.<EncodeAsync>d__13>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JArray.<WriteToAsync>d__0>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JConstructor.<WriteToAsync>d__0>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JProperty.<WriteToAsync>d__1>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteIntegerValueAsync>d__24>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<<InternalWriteEndAsync>g__AwaitIndent|11_1>d>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoChunkStream.<FinishReading>d__8>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<ProcessWrite>d__34>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0xDAFFF0 Offset: 0xDAE9F0 VA: 0x180DAFFF0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, DeflateManagedStream.<WriteAsyncCore>d__47>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JavaScriptUtils.<WriteCharAsync>d__14>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<EatWhitespaceAsync>d__17>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<HandleNullAsync>d__35>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseNumberAsync>d__29>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadFinishedAsync>d__36>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWritePropertyNameAsync>d__30>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWritePropertyNameAsync>d__32>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteRawValueAsync>d__121>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__64>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__78>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__97>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteValueInternalAsync>d__15>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteValueNotNullAsync>d__110>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<<InternalWriteEndAsync>g__AwaitEnd|11_2>d>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<<InternalWriteEndAsync>g__AwaitProperty|11_0>d>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<InternalWriteStartAsync>d__20>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0xDB07F0 Offset: 0xDAF1F0 VA: 0x180DB07F0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<LoadIntoBufferAsync>d__17>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadIntoWrappedTypeObjectAsync>d__43>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoCloseAsync>d__8>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<AutoCompleteAsync>d__1>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Stream.<FinishWriteAsync>d__57>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<FinishWriting>d__31>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer_inner>d__39>
	|
	|-RVA: 0xDB17E0 Offset: 0xDB01E0 VA: 0x180DB17E0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JContainer.<ReadContentFromAsync>d__1>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseConstructorAsync>d__25>
	|
	|-RVA: 0xDB1C00 Offset: 0xDB0600 VA: 0x180DB1C00
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JContainer.<ReadTokenFromAsync>d__0>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseCommentAsync>d__16>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<WriteTokenAsync>d__30>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<WriteAsyncInternal>d__57>
	|
	|-RVA: 0xDB1FF0 Offset: 0xDB09F0 VA: 0x180DB1FF0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JObject.<<WriteToAsync>g__AwaitProperties|0_0>d>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<WriteConstructorDateAsync>d__32>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<Connect>d__16>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnectionTunnel.<Initialize>d__42>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0xDB21F0 Offset: 0xDB0BF0 VA: 0x180DB21F0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JavaScriptUtils.<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<WriteAsyncInternal>d__62>
	|
	|-RVA: 0xDB2410 Offset: 0xDB0E10 VA: 0x180DB2410
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JavaScriptUtils.<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<WriteAsyncInternal>d__59>
	|
	|-RVA: 0xDC43C0 Offset: 0xDC2DC0 VA: 0x180DC43C0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseStringAsync>d__18>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteCommentAsync>d__115>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteStartArrayAsync>d__35>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteStartConstructorAsync>d__40>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteStartObjectAsync>d__38>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteUndefinedAsync>d__43>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__60>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__99>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteIndentAsync>d__13>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteValueNonNullAsync>d__54>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<Initialize>d__36>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<SetHeadersAsync>d__37>
	|
	|-RVA: 0xDC45B0 Offset: 0xDC2FB0 VA: 0x180DC45B0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<FlushAsyncInternal>d__74>
	|
	|-RVA: 0xDC41E0 Offset: 0xDC2BE0 VA: 0x180DC41E0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<CloseBufferAndWriterAsync>d__9>
	|
	|-RVA: 0xDC47E0 Offset: 0xDC31E0 VA: 0x180DC47E0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, Stream.<CopyToAsyncInternal>d__28>
	|
	|-RVA: 0xDC49F0 Offset: 0xDC33F0 VA: 0x180DC49F0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, StreamWriter.<FlushAsyncInternal>d__74>
	|
	|-RVA: 0xDC4C20 Offset: 0xDC3620 VA: 0x180DC4C20
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B12A0 Offset: 0x12AFCA0 VA: 0x1812B12A0
	|-AsyncTaskMethodBuilder<Nullable<bool>>.get_Task
	|
	|-RVA: 0x12B1640 Offset: 0x12B0040 VA: 0x1812B1640
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.get_Task
	|
	|-RVA: 0x12B17A0 Offset: 0x12B01A0 VA: 0x1812B17A0
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.get_Task
	|
	|-RVA: 0x12B0DD0 Offset: 0x12AF7D0 VA: 0x1812B0DD0
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.get_Task
	|
	|-RVA: 0x12B11F0 Offset: 0x12AFBF0 VA: 0x1812B11F0
	|-AsyncTaskMethodBuilder<Nullable<double>>.get_Task
	|
	|-RVA: 0x12B1590 Offset: 0x12AFF90 VA: 0x1812B1590
	|-AsyncTaskMethodBuilder<Nullable<int>>.get_Task
	|
	|-RVA: 0x12B1090 Offset: 0x12AFA90 VA: 0x1812B1090
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.get_Task
	|
	|-RVA: 0x12B0F30 Offset: 0x12AF930 VA: 0x1812B0F30
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.get_Task
	|
	|-RVA: 0x12B0FE0 Offset: 0x12AF9E0 VA: 0x1812B0FE0
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.get_Task
	|
	|-RVA: 0x12B0D20 Offset: 0x12AF720 VA: 0x1812B0D20
	|-AsyncTaskMethodBuilder<bool>.get_Task
	|
	|-RVA: 0x12B1140 Offset: 0x12AFB40 VA: 0x1812B1140
	|-AsyncTaskMethodBuilder<char>.get_Task
	|
	|-RVA: 0x12B0E80 Offset: 0x12AF880 VA: 0x1812B0E80
	|-AsyncTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0x12B16F0 Offset: 0x12B00F0 VA: 0x1812B16F0
	|-AsyncTaskMethodBuilder<object>.get_Task
	|
	|-RVA: 0x12B1430 Offset: 0x12AFE30 VA: 0x1812B1430
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.get_Task
	|
	|-RVA: 0x12B14E0 Offset: 0x12AFEE0 VA: 0x1812B14E0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.get_Task
	|
	|-RVA: 0x12B1350 Offset: 0x12AFD50 VA: 0x1812B1350
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12ACF10 Offset: 0x12AB910 VA: 0x1812ACF10
	|-AsyncTaskMethodBuilder<Nullable<bool>>.SetResult
	|
	|-RVA: 0x12ADEA0 Offset: 0x12AC8A0 VA: 0x1812ADEA0
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.SetResult
	|
	|-RVA: 0x12AD710 Offset: 0x12AC110 VA: 0x1812AD710
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.SetResult
	|
	|-RVA: 0x12AEBA0 Offset: 0x12AD5A0 VA: 0x1812AEBA0
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.SetResult
	|
	|-RVA: 0x12AE9B0 Offset: 0x12AD3B0 VA: 0x1812AE9B0
	|-AsyncTaskMethodBuilder<Nullable<double>>.SetResult
	|
	|-RVA: 0x12AE410 Offset: 0x12ACE10 VA: 0x1812AE410
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0x12AEE70 Offset: 0x12AD870 VA: 0x1812AEE70
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetResult
	|
	|-RVA: 0x12AE5F0 Offset: 0x12ACFF0 VA: 0x1812AE5F0
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetResult
	|
	|-RVA: 0x12AD510 Offset: 0x12ABF10 VA: 0x1812AD510
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetResult
	|
	|-RVA: 0x12AFA30 Offset: 0x12AE430 VA: 0x1812AFA30
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0x12AF590 Offset: 0x12ADF90 VA: 0x1812AF590
	|-AsyncTaskMethodBuilder<char>.SetResult
	|
	|-RVA: 0x12AF060 Offset: 0x12ADA60 VA: 0x1812AF060
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x12AD1C0 Offset: 0x12ABBC0 VA: 0x1812AD1C0
	|-AsyncTaskMethodBuilder<object>.SetResult
	|
	|-RVA: 0x12AF770 Offset: 0x12AE170 VA: 0x1812AF770
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.SetResult
	|
	|-RVA: 0x12ADC00 Offset: 0x12AC600 VA: 0x1812ADC00
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	|
	|-RVA: 0x12AF230 Offset: 0x12ADC30 VA: 0x1812AF230
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	internal void SetResult(Task<TResult> completedTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AD9D0 Offset: 0x12AC3D0 VA: 0x1812AD9D0
	|-AsyncTaskMethodBuilder<Nullable<bool>>.SetResult
	|
	|-RVA: 0x12AE1F0 Offset: 0x12ACBF0 VA: 0x1812AE1F0
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.SetResult
	|
	|-RVA: 0x12AD0F0 Offset: 0x12ABAF0 VA: 0x1812AD0F0
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.SetResult
	|
	|-RVA: 0x12AF960 Offset: 0x12AE360 VA: 0x1812AF960
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.SetResult
	|
	|-RVA: 0x12ADA90 Offset: 0x12AC490 VA: 0x1812ADA90
	|-AsyncTaskMethodBuilder<Nullable<double>>.SetResult
	|
	|-RVA: 0x12AE140 Offset: 0x12ACB40 VA: 0x1812AE140
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0x12AD910 Offset: 0x12AC310 VA: 0x1812AD910
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetResult
	|
	|-RVA: 0x12AEDA0 Offset: 0x12AD7A0 VA: 0x1812AEDA0
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetResult
	|
	|-RVA: 0x12ADDE0 Offset: 0x12AC7E0 VA: 0x1812ADDE0
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetResult
	|
	|-RVA: 0x12AD460 Offset: 0x12ABE60 VA: 0x1812AD460
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0x12AE360 Offset: 0x12ACD60 VA: 0x1812AE360
	|-AsyncTaskMethodBuilder<char>.SetResult
	|
	|-RVA: 0x12ADB50 Offset: 0x12AC550 VA: 0x1812ADB50
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x12AE090 Offset: 0x12ACA90 VA: 0x1812AE090
	|-AsyncTaskMethodBuilder<object>.SetResult
	|
	|-RVA: 0x12AD3A0 Offset: 0x12ABDA0 VA: 0x1812AD3A0
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.SetResult
	|
	|-RVA: 0x12AE2B0 Offset: 0x12ACCB0 VA: 0x1812AE2B0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	|
	|-RVA: 0x12AE7F0 Offset: 0x12AD1F0 VA: 0x1812AE7F0
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AB770 Offset: 0x12AA170 VA: 0x1812AB770
	|-AsyncTaskMethodBuilder<Nullable<bool>>.SetException
	|
	|-RVA: 0x12AB3E0 Offset: 0x12A9DE0 VA: 0x1812AB3E0
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.SetException
	|
	|-RVA: 0x12ACD60 Offset: 0x12AB760 VA: 0x1812ACD60
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.SetException
	|
	|-RVA: 0x12AC340 Offset: 0x12AAD40 VA: 0x1812AC340
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.SetException
	|
	|-RVA: 0x12AC190 Offset: 0x12AAB90 VA: 0x1812AC190
	|-AsyncTaskMethodBuilder<Nullable<double>>.SetException
	|
	|-RVA: 0x12ABAD0 Offset: 0x12AA4D0 VA: 0x1812ABAD0
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetException
	|
	|-RVA: 0x12ABFE0 Offset: 0x12AA9E0 VA: 0x1812ABFE0
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetException
	|
	|-RVA: 0x12ACA00 Offset: 0x12AB400 VA: 0x1812ACA00
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetException
	|
	|-RVA: 0x12AB920 Offset: 0x12AA320 VA: 0x1812AB920
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetException
	|
	|-RVA: 0x12AC6A0 Offset: 0x12AB0A0 VA: 0x1812AC6A0
	|-AsyncTaskMethodBuilder<bool>.SetException
	|
	|-RVA: 0x12ABE30 Offset: 0x12AA830 VA: 0x1812ABE30
	|-AsyncTaskMethodBuilder<char>.SetException
	|
	|-RVA: 0x12AC4F0 Offset: 0x12AAEF0 VA: 0x1812AC4F0
	|-AsyncTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0x12AC850 Offset: 0x12AB250 VA: 0x1812AC850
	|-AsyncTaskMethodBuilder<object>.SetException
	|
	|-RVA: 0x12ACBB0 Offset: 0x12AB5B0 VA: 0x1812ACBB0
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.SetException
	|
	|-RVA: 0x12ABC80 Offset: 0x12AA680 VA: 0x1812ABC80
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetException
	|
	|-RVA: 0x12AB590 Offset: 0x12A9F90 VA: 0x1812AB590
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetException
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> GetTaskForResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A57C0 Offset: 0x12A41C0 VA: 0x1812A57C0
	|-AsyncTaskMethodBuilder<Nullable<bool>>.GetTaskForResult
	|
	|-RVA: 0x12A3C80 Offset: 0x12A2680 VA: 0x1812A3C80
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>.GetTaskForResult
	|
	|-RVA: 0x12A1420 Offset: 0x129FE20 VA: 0x1812A1420
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>.GetTaskForResult
	|
	|-RVA: 0x12A5A30 Offset: 0x12A4430 VA: 0x1812A5A30
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>.GetTaskForResult
	|
	|-RVA: 0x12A06B0 Offset: 0x129F0B0 VA: 0x1812A06B0
	|-AsyncTaskMethodBuilder<Nullable<double>>.GetTaskForResult
	|
	|-RVA: 0x12A6830 Offset: 0x12A5230 VA: 0x1812A6830
	|-AsyncTaskMethodBuilder<Nullable<int>>.GetTaskForResult
	|
	|-RVA: 0x12A2F30 Offset: 0x12A1930 VA: 0x1812A2F30
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.GetTaskForResult
	|
	|-RVA: 0x12A49F0 Offset: 0x12A33F0 VA: 0x1812A49F0
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.GetTaskForResult
	|
	|-RVA: 0x12A9910 Offset: 0x12A8310 VA: 0x1812A9910
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.GetTaskForResult
	|
	|-RVA: 0x12AA6C0 Offset: 0x12A90C0 VA: 0x1812AA6C0
	|-AsyncTaskMethodBuilder<bool>.GetTaskForResult
	|
	|-RVA: 0x129F990 Offset: 0x129E390 VA: 0x18129F990
	|-AsyncTaskMethodBuilder<char>.GetTaskForResult
	|
	|-RVA: 0x12A7EB0 Offset: 0x12A68B0 VA: 0x1812A7EB0
	|-AsyncTaskMethodBuilder<int>.GetTaskForResult
	|
	|-RVA: 0x12A7C40 Offset: 0x12A6640 VA: 0x1812A7C40
	|-AsyncTaskMethodBuilder<object>.GetTaskForResult
	|
	|-RVA: 0x12A8BC0 Offset: 0x12A75C0 VA: 0x1812A8BC0
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.GetTaskForResult
	|
	|-RVA: 0x12A2220 Offset: 0x12A0C20 VA: 0x1812A2220
	|-AsyncTaskMethodBuilder<VoidTaskResult>.GetTaskForResult
	|
	|-RVA: 0x12A6AA0 Offset: 0x12A54A0 VA: 0x1812A6AA0
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.GetTaskForResult
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B0430 Offset: 0x12AEE30 VA: 0x1812B0430
	|-AsyncTaskMethodBuilder<Nullable<bool>>..cctor
	|
	|-RVA: 0x12B0120 Offset: 0x12AEB20 VA: 0x1812B0120
	|-AsyncTaskMethodBuilder<Nullable<DateTime>>..cctor
	|
	|-RVA: 0x12B0320 Offset: 0x12AED20 VA: 0x1812B0320
	|-AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>..cctor
	|
	|-RVA: 0x12B0B20 Offset: 0x12AF520 VA: 0x1812B0B20
	|-AsyncTaskMethodBuilder<Nullable<Decimal>>..cctor
	|
	|-RVA: 0x12B0A10 Offset: 0x12AF410 VA: 0x1812B0A10
	|-AsyncTaskMethodBuilder<Nullable<double>>..cctor
	|
	|-RVA: 0x12B0520 Offset: 0x12AEF20 VA: 0x1812B0520
	|-AsyncTaskMethodBuilder<Nullable<int>>..cctor
	|
	|-RVA: 0x12AFD20 Offset: 0x12AE720 VA: 0x1812AFD20
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>..cctor
	|
	|-RVA: 0x12B0010 Offset: 0x12AEA10 VA: 0x1812B0010
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>..cctor
	|
	|-RVA: 0x12AFC20 Offset: 0x12AE620 VA: 0x1812AFC20
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>..cctor
	|
	|-RVA: 0x12B0C30 Offset: 0x12AF630 VA: 0x1812B0C30
	|-AsyncTaskMethodBuilder<bool>..cctor
	|
	|-RVA: 0x12AFE30 Offset: 0x12AE830 VA: 0x1812AFE30
	|-AsyncTaskMethodBuilder<char>..cctor
	|
	|-RVA: 0x12AFF20 Offset: 0x12AE920 VA: 0x1812AFF20
	|-AsyncTaskMethodBuilder<int>..cctor
	|
	|-RVA: 0x12B0920 Offset: 0x12AF320 VA: 0x1812B0920
	|-AsyncTaskMethodBuilder<object>..cctor
	|
	|-RVA: 0x12B0610 Offset: 0x12AF010 VA: 0x1812B0610
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>..cctor
	|
	|-RVA: 0x12B0230 Offset: 0x12AEC30 VA: 0x1812B0230
	|-AsyncTaskMethodBuilder<VoidTaskResult>..cctor
	|
	|-RVA: 0x12B0720 Offset: 0x12AF120 VA: 0x1812B0720
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>..cctor
	*/
}
