public struct AsyncTaskMethodBuilder // TypeDefIndex: 4627
{
	// Fields
	private static readonly Task<VoidTaskResult> s_cachedCompleted; // 0x0
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; // 0x0

	// Properties
	public Task Task { get; }

	// Methods

	// RVA: 0xFD3B50 Offset: 0xFD2550 VA: 0x180FD3B50
	public static AsyncTaskMethodBuilder Create() { }

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC4EC0 Offset: 0xDC38C0 VA: 0x180DC4EC0
	|-AsyncTaskMethodBuilder.Start<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE53C10 Offset: 0xE52610 VA: 0x180E53C10
	|-AsyncTaskMethodBuilder.Start<AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0xE527D0 Offset: 0xE511D0 VA: 0x180E527D0
	|-AsyncTaskMethodBuilder.Start<Base64Encoder.<EncodeAsync>d__13>
	|
	|-RVA: 0xE51810 Offset: 0xE50210 VA: 0x180E51810
	|-AsyncTaskMethodBuilder.Start<ButtonShaker.<ApplyShakeAsync>d__4>
	|
	|-RVA: 0xE55E90 Offset: 0xE54890 VA: 0x180E55E90
	|-AsyncTaskMethodBuilder.Start<ButtonShaker.<shakeOnce>d__5>
	|
	|-RVA: 0xE54450 Offset: 0xE52E50 VA: 0x180E54450
	|-AsyncTaskMethodBuilder.Start<CoreDiagnostics.<SendCoreDiagnosticsAsync>d__24>
	|
	|-RVA: 0xE52F50 Offset: 0xE51950 VA: 0x180E52F50
	|-AsyncTaskMethodBuilder.Start<CorePackageInitializer.<InitializeComponents>d__47>
	|
	|-RVA: 0xE53010 Offset: 0xE51A10 VA: 0x180E53010
	|-AsyncTaskMethodBuilder.Start<CorePackageInitializer.<InitializeProjectConfigAsync>d__52>
	|
	|-RVA: 0xE54D50 Offset: 0xE53750 VA: 0x180E54D50
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncCore>d__49>
	|
	|-RVA: 0xE54ED0 Offset: 0xE538D0 VA: 0x180E54ED0
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0xE54C90 Offset: 0xE53690 VA: 0x180E54C90
	|-AsyncTaskMethodBuilder.Start<DeflateManagedStream.<WriteAsyncCore>d__47>
	|
	|-RVA: 0xE53550 Offset: 0xE51F50 VA: 0x180E53550
	|-AsyncTaskMethodBuilder.Start<HttpContent.<LoadIntoBufferAsync>d__17>
	|
	|-RVA: 0xE55950 Offset: 0xE54350 VA: 0x180E55950
	|-AsyncTaskMethodBuilder.Start<JArray.<WriteToAsync>d__0>
	|
	|-RVA: 0xE55890 Offset: 0xE54290 VA: 0x180E55890
	|-AsyncTaskMethodBuilder.Start<JConstructor.<WriteToAsync>d__0>
	|
	|-RVA: 0xE53E50 Offset: 0xE52850 VA: 0x180E53E50
	|-AsyncTaskMethodBuilder.Start<JContainer.<ReadContentFromAsync>d__1>
	|
	|-RVA: 0xE54210 Offset: 0xE52C10 VA: 0x180E54210
	|-AsyncTaskMethodBuilder.Start<JContainer.<ReadTokenFromAsync>d__0>
	|
	|-RVA: 0xE54BD0 Offset: 0xE535D0 VA: 0x180E54BD0
	|-AsyncTaskMethodBuilder.Start<JObject.<<WriteToAsync>g__AwaitProperties|0_0>d>
	|
	|-RVA: 0xE55A10 Offset: 0xE54410 VA: 0x180E55A10
	|-AsyncTaskMethodBuilder.Start<JProperty.<WriteToAsync>d__1>
	|
	|-RVA: 0xE551D0 Offset: 0xE53BD0 VA: 0x180E551D0
	|-AsyncTaskMethodBuilder.Start<JavaScriptUtils.<WriteCharAsync>d__14>
	|
	|-RVA: 0xE554D0 Offset: 0xE53ED0 VA: 0x180E554D0
	|-AsyncTaskMethodBuilder.Start<JavaScriptUtils.<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16>
	|
	|-RVA: 0xE55590 Offset: 0xE53F90 VA: 0x180E55590
	|-AsyncTaskMethodBuilder.Start<JavaScriptUtils.<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13>
	|
	|-RVA: 0xE542D0 Offset: 0xE52CD0 VA: 0x180E542D0
	|-AsyncTaskMethodBuilder.Start<JsonReader.<ReaderReadAndAssertAsync>d__2>
	|
	|-RVA: 0xE545D0 Offset: 0xE52FD0 VA: 0x180E545D0
	|-AsyncTaskMethodBuilder.Start<JsonReader.<SkipAsync>d__1>
	|
	|-RVA: 0xE52650 Offset: 0xE51050 VA: 0x180E52650
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<EatWhitespaceAsync>d__17>
	|
	|-RVA: 0xE52B90 Offset: 0xE51590 VA: 0x180E52B90
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<HandleNullAsync>d__35>
	|
	|-RVA: 0xE53610 Offset: 0xE52010 VA: 0x180E53610
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<MatchAndSetAsync>d__21>
	|
	|-RVA: 0xE536D0 Offset: 0xE520D0 VA: 0x180E536D0
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ParseCommentAsync>d__16>
	|
	|-RVA: 0xE53790 Offset: 0xE52190 VA: 0x180E53790
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ParseConstructorAsync>d__25>
	|
	|-RVA: 0xE53850 Offset: 0xE52250 VA: 0x180E53850
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ParseNumberAsync>d__29>
	|
	|-RVA: 0xE53910 Offset: 0xE52310 VA: 0x180E53910
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ParseStringAsync>d__18>
	|
	|-RVA: 0xE539D0 Offset: 0xE523D0 VA: 0x180E539D0
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ParseUnquotedPropertyAsync>d__33>
	|
	|-RVA: 0xE53B50 Offset: 0xE52550 VA: 0x180E53B50
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ProcessCarriageReturnAsync>d__11>
	|
	|-RVA: 0xE53F10 Offset: 0xE52910 VA: 0x180E53F10
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ReadFinishedAsync>d__36>
	|
	|-RVA: 0xE53FD0 Offset: 0xE529D0 VA: 0x180E53FD0
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ReadIntoWrappedTypeObjectAsync>d__43>
	|
	|-RVA: 0xE54090 Offset: 0xE52A90 VA: 0x180E54090
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ReadNumberIntoBufferAsync>d__32>
	|
	|-RVA: 0xE54150 Offset: 0xE52B50 VA: 0x180E54150
	|-AsyncTaskMethodBuilder.Start<JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|
	|-RVA: 0xE51990 Offset: 0xE50390 VA: 0x180E51990
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<CloseBufferAndWriterAsync>d__9>
	|
	|-RVA: 0xE51BD0 Offset: 0xE505D0 VA: 0x180E51BD0
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoCloseAsync>d__8>
	|
	|-RVA: 0xE51C90 Offset: 0xE50690 VA: 0x180E51C90
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteCommentAsync>d__115>
	|
	|-RVA: 0xE51D50 Offset: 0xE50750 VA: 0x180E51D50
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWritePropertyNameAsync>d__30>
	|
	|-RVA: 0xE51E10 Offset: 0xE50810 VA: 0x180E51E10
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWritePropertyNameAsync>d__32>
	|
	|-RVA: 0xE51ED0 Offset: 0xE508D0 VA: 0x180E51ED0
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteRawValueAsync>d__121>
	|
	|-RVA: 0xE51F90 Offset: 0xE50990 VA: 0x180E51F90
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteStartArrayAsync>d__35>
	|
	|-RVA: 0xE52050 Offset: 0xE50A50 VA: 0x180E52050
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteStartConstructorAsync>d__40>
	|
	|-RVA: 0xE52110 Offset: 0xE50B10 VA: 0x180E52110
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteStartObjectAsync>d__38>
	|
	|-RVA: 0xE521D0 Offset: 0xE50BD0 VA: 0x180E521D0
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteUndefinedAsync>d__43>
	|
	|-RVA: 0xE52290 Offset: 0xE50C90 VA: 0x180E52290
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteValueAsync>d__60>
	|
	|-RVA: 0xE52350 Offset: 0xE50D50 VA: 0x180E52350
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteValueAsync>d__64>
	|
	|-RVA: 0xE52410 Offset: 0xE50E10 VA: 0x180E52410
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteValueAsync>d__78>
	|
	|-RVA: 0xE524D0 Offset: 0xE50ED0 VA: 0x180E524D0
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteValueAsync>d__97>
	|
	|-RVA: 0xE52590 Offset: 0xE50F90 VA: 0x180E52590
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<DoWriteValueAsync>d__99>
	|
	|-RVA: 0xE55650 Offset: 0xE54050 VA: 0x180E55650
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<WriteIndentAsync>d__13>
	|
	|-RVA: 0xE55710 Offset: 0xE54110 VA: 0x180E55710
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<WriteIntegerValueAsync>d__24>
	|
	|-RVA: 0xE55C50 Offset: 0xE54650 VA: 0x180E55C50
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<WriteValueInternalAsync>d__15>
	|
	|-RVA: 0xE55D10 Offset: 0xE54710 VA: 0x180E55D10
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<WriteValueNonNullAsync>d__54>
	|
	|-RVA: 0xE55DD0 Offset: 0xE547D0 VA: 0x180E55DD0
	|-AsyncTaskMethodBuilder.Start<JsonTextWriter.<WriteValueNotNullAsync>d__110>
	|
	|-RVA: 0xE548D0 Offset: 0xE532D0 VA: 0x180E548D0
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<<InternalWriteEndAsync>g__AwaitEnd|11_2>d>
	|
	|-RVA: 0xE54990 Offset: 0xE53390 VA: 0x180E54990
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<<InternalWriteEndAsync>g__AwaitIndent|11_1>d>
	|
	|-RVA: 0xE54A50 Offset: 0xE53450 VA: 0x180E54A50
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<<InternalWriteEndAsync>g__AwaitProperty|11_0>d>
	|
	|-RVA: 0xE54B10 Offset: 0xE53510 VA: 0x180E54B10
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d>
	|
	|-RVA: 0xE518D0 Offset: 0xE502D0 VA: 0x180E518D0
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<AutoCompleteAsync>d__1>
	|
	|-RVA: 0xE53490 Offset: 0xE51E90 VA: 0x180E53490
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<InternalWriteStartAsync>d__20>
	|
	|-RVA: 0xE55410 Offset: 0xE53E10 VA: 0x180E55410
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<WriteConstructorDateAsync>d__32>
	|
	|-RVA: 0xE55AD0 Offset: 0xE544D0 VA: 0x180E55AD0
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<WriteTokenAsync>d__30>
	|
	|-RVA: 0xE55B90 Offset: 0xE54590 VA: 0x180E55B90
	|-AsyncTaskMethodBuilder.Start<JsonWriter.<WriteTokenSyncReadingAsync>d__31>
	|
	|-RVA: 0xE533D0 Offset: 0xE51DD0 VA: 0x180E533D0
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0xE53A90 Offset: 0xE52490 VA: 0x180E53A90
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<ProcessAuthentication>d__48>
	|
	|-RVA: 0xE52890 Offset: 0xE51290 VA: 0x180E52890
	|-AsyncTaskMethodBuilder.Start<MonoChunkStream.<FinishReading>d__8>
	|
	|-RVA: 0xE52C50 Offset: 0xE51650 VA: 0x180E52C50
	|-AsyncTaskMethodBuilder.Start<PollManager.<InitAppTicket>d__30>
	|
	|-RVA: 0xE54390 Offset: 0xE52D90 VA: 0x180E54390
	|-AsyncTaskMethodBuilder.Start<ServicePointScheduler.<RunScheduler>d__32>
	|
	|-RVA: 0xE51B10 Offset: 0xE50510 VA: 0x180E51B10
	|-AsyncTaskMethodBuilder.Start<Stream.<CopyToAsyncInternal>d__28>
	|
	|-RVA: 0xE52950 Offset: 0xE51350 VA: 0x180E52950
	|-AsyncTaskMethodBuilder.Start<Stream.<FinishWriteAsync>d__57>
	|
	|-RVA: 0xE52AD0 Offset: 0xE514D0 VA: 0x180E52AD0
	|-AsyncTaskMethodBuilder.Start<StreamWriter.<FlushAsyncInternal>d__74>
	|
	|-RVA: 0xE54F90 Offset: 0xE53990 VA: 0x180E54F90
	|-AsyncTaskMethodBuilder.Start<StreamWriter.<WriteAsyncInternal>d__57>
	|
	|-RVA: 0xE55050 Offset: 0xE53A50 VA: 0x180E55050
	|-AsyncTaskMethodBuilder.Start<StreamWriter.<WriteAsyncInternal>d__59>
	|
	|-RVA: 0xE55110 Offset: 0xE53B10 VA: 0x180E55110
	|-AsyncTaskMethodBuilder.Start<StreamWriter.<WriteAsyncInternal>d__62>
	|
	|-RVA: 0xE53190 Offset: 0xE51B90 VA: 0x180E53190
	|-AsyncTaskMethodBuilder.Start<Ua2CoreInitializeCallback.<Initialize>d__1>
	|
	|-RVA: 0xE52DD0 Offset: 0xE517D0 VA: 0x180E52DD0
	|-AsyncTaskMethodBuilder.Start<UnityServices.<InitializeAsync>d__26>
	|
	|-RVA: 0xE52710 Offset: 0xE51110 VA: 0x180E52710
	|-AsyncTaskMethodBuilder.Start<UnityServicesInternal.<EnableInitializationAsync>d__36>
	|
	|-RVA: 0xE52E90 Offset: 0xE51890 VA: 0x180E52E90
	|-AsyncTaskMethodBuilder.Start<UnityServicesInternal.<InitializeAsync>d__27>
	|
	|-RVA: 0xE530D0 Offset: 0xE51AD0 VA: 0x180E530D0
	|-AsyncTaskMethodBuilder.Start<UnityServicesInternal.<InitializeServicesAsync>d__33>
	|
	|-RVA: 0xE51A50 Offset: 0xE50450 VA: 0x180E51A50
	|-AsyncTaskMethodBuilder.Start<WebConnection.<Connect>d__16>
	|
	|-RVA: 0xE53310 Offset: 0xE51D10 VA: 0x180E53310
	|-AsyncTaskMethodBuilder.Start<WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0xE52A10 Offset: 0xE51410 VA: 0x180E52A10
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<FinishWriting>d__31>
	|
	|-RVA: 0xE53250 Offset: 0xE51C50 VA: 0x180E53250
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0xE53CD0 Offset: 0xE526D0 VA: 0x180E53CD0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<ProcessWrite>d__34>
	|
	|-RVA: 0xE54510 Offset: 0xE52F10 VA: 0x180E54510
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<SetHeadersAsync>d__37>
	|
	|-RVA: 0xE54E10 Offset: 0xE53810 VA: 0x180E54E10
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0xE55290 Offset: 0xE53C90 VA: 0x180E55290
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0xE55350 Offset: 0xE53D50 VA: 0x180E55350
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteChunkTrailer_inner>d__39>
	|
	|-RVA: 0xE557D0 Offset: 0xE541D0 VA: 0x180E557D0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0xE52D10 Offset: 0xE51710 VA: 0x180E52D10
	|-AsyncTaskMethodBuilder.Start<WebResponseStream.<InitReadAsync>d__52>
	|
	|-RVA: 0xE53D90 Offset: 0xE52790 VA: 0x180E53D90
	|-AsyncTaskMethodBuilder.Start<WebResponseStream.<ReadAllAsync>d__48>
	|
	|-RVA: 0xE54690 Offset: 0xE53090 VA: 0x180E54690
	|-AsyncTaskMethodBuilder.Start<CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__InitializePackageAsync|2>d>
	|
	|-RVA: 0xE54750 Offset: 0xE53150 VA: 0x180E54750
	|-AsyncTaskMethodBuilder.Start<CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d>
	|
	|-RVA: 0xE54810 Offset: 0xE53210 VA: 0x180E54810
	|-AsyncTaskMethodBuilder.Start<UnityServicesInternal.<>c__DisplayClass33_0.<<InitializeServicesAsync>g__InitializePackagesAsync|1>d>
	*/

	// RVA: 0x1B5F700 Offset: 0x1B5E100 VA: 0x181B5F700
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE50580 Offset: 0xE4EF80 VA: 0x180E50580
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<MatchAndSetAsync>d__21>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MonoChunkStream.<FinishReading>d__8>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0xE504F0 Offset: 0xE4EEF0 VA: 0x180E504F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>, WebConnectionTunnel.<Initialize>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonWriter.<WriteConstructorDateAsync>d__32>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, ServicePointScheduler.<RunScheduler>d__32>
	|
	|-RVA: 0xE50460 Offset: 0xE4EE60 VA: 0x180E50460
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JContainer.<ReadContentFromAsync>d__1>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseConstructorAsync>d__25>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParseConstructorAsync>d__25>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAllAsync>d__48>
	|
	|-RVA: 0xE50C40 Offset: 0xE4F640 VA: 0x180E50C40
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JContainer.<ReadTokenFromAsync>d__0>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ParseCommentAsync>d__16>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonWriter.<WriteTokenAsync>d__30>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParseCommentAsync>d__16>
	|
	|-RVA: 0xE50DF0 Offset: 0xE4F7F0 VA: 0x180E50DF0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonReader.<ReaderReadAndAssertAsync>d__2>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ProcessCarriageReturnAsync>d__11>
	|
	|-RVA: 0xE50CD0 Offset: 0xE4F6D0 VA: 0x180E50CD0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonReader.<SkipAsync>d__1>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ParseUnquotedPropertyAsync>d__33>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ReadNumberIntoBufferAsync>d__32>
	|
	|-RVA: 0xE503D0 Offset: 0xE4EDD0 VA: 0x180E503D0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<HandleNullAsync>d__35>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ReadFinishedAsync>d__36>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonWriter.<WriteTokenSyncReadingAsync>d__31>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<EatWhitespaceAsync>d__17>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<InitReadAsync>d__52>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__48>
	|
	|-RVA: 0xE50D60 Offset: 0xE4F760 VA: 0x180E50D60
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<char>, JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|
	|-RVA: 0xE50FA0 Offset: 0xE4F9A0 VA: 0x180E50FA0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, Stream.<CopyToAsyncInternal>d__28>
	|
	|-RVA: 0xE511E0 Offset: 0xE4FBE0 VA: 0x180E511E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CorePackageInitializer.<InitializeProjectConfigAsync>d__52>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, UnityServices.<InitializeAsync>d__26>
	|
	|-RVA: 0xE51150 Offset: 0xE4FB50 VA: 0x180E51150
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, PollManager.<InitAppTicket>d__30>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, UnityServicesInternal.<>c__DisplayClass33_0.<<InitializeServicesAsync>g__InitializePackagesAsync|1>d>
	|
	|-RVA: 0xE51270 Offset: 0xE4FC70 VA: 0x180E51270
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, UnityServicesInternal.<InitializeAsync>d__27>
	|
	|-RVA: 0xE51030 Offset: 0xE4FA30 VA: 0x180E51030
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ForceAsyncAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0xE51300 Offset: 0xE4FD00 VA: 0x180E51300
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, ButtonShaker.<ApplyShakeAsync>d__4>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServicesInternal.<InitializeAsync>d__27>
	|
	|-RVA: 0xE51420 Offset: 0xE4FE20 VA: 0x180E51420
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, ButtonShaker.<shakeOnce>d__5>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServices.<InitializeAsync>d__26>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServicesInternal.<InitializeServicesAsync>d__33>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__InitializePackageAsync|2>d>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d>
	|
	|-RVA: 0xE51540 Offset: 0xE4FF40 VA: 0x180E51540
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CoreDiagnostics.<SendCoreDiagnosticsAsync>d__24>
	|
	|-RVA: 0xE51390 Offset: 0xE4FD90 VA: 0x180E51390
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CorePackageInitializer.<InitializeComponents>d__47>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Ua2CoreInitializeCallback.<Initialize>d__1>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServicesInternal.<EnableInitializationAsync>d__36>
	|
	|-RVA: 0xE51660 Offset: 0xE50060 VA: 0x180E51660
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0xE514B0 Offset: 0xE4FEB0 VA: 0x180E514B0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0xE515D0 Offset: 0xE4FFD0 VA: 0x180E515D0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0xE516F0 Offset: 0xE500F0 VA: 0x180E516F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0xE51780 Offset: 0xE50180 VA: 0x180E51780
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, CryptoStream.<WriteAsyncCore>d__49>
	|
	|-RVA: 0xE510C0 Offset: 0xE4FAC0 VA: 0x180E510C0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE508E0 Offset: 0xE4F2E0 VA: 0x180E508E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Base64Encoder.<EncodeAsync>d__13>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JArray.<WriteToAsync>d__0>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JConstructor.<WriteToAsync>d__0>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JProperty.<WriteToAsync>d__1>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteIntegerValueAsync>d__24>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<<InternalWriteEndAsync>g__AwaitIndent|11_1>d>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoChunkStream.<FinishReading>d__8>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<ProcessWrite>d__34>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0xE50850 Offset: 0xE4F250 VA: 0x180E50850
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, DeflateManagedStream.<WriteAsyncCore>d__47>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JavaScriptUtils.<WriteCharAsync>d__14>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<EatWhitespaceAsync>d__17>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<HandleNullAsync>d__35>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseNumberAsync>d__29>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadFinishedAsync>d__36>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWritePropertyNameAsync>d__30>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWritePropertyNameAsync>d__32>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteRawValueAsync>d__121>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__64>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__78>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__97>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteValueInternalAsync>d__15>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteValueNotNullAsync>d__110>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<<InternalWriteEndAsync>g__AwaitEnd|11_2>d>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<<InternalWriteEndAsync>g__AwaitProperty|11_0>d>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<InternalWriteStartAsync>d__20>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0xE50610 Offset: 0xE4F010 VA: 0x180E50610
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<LoadIntoBufferAsync>d__17>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadIntoWrappedTypeObjectAsync>d__43>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoCloseAsync>d__8>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<AutoCompleteAsync>d__1>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Stream.<FinishWriteAsync>d__57>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<FinishWriting>d__31>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer_inner>d__39>
	|
	|-RVA: 0xE50A90 Offset: 0xE4F490 VA: 0x180E50A90
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JContainer.<ReadContentFromAsync>d__1>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseConstructorAsync>d__25>
	|
	|-RVA: 0xE50A00 Offset: 0xE4F400 VA: 0x180E50A00
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JContainer.<ReadTokenFromAsync>d__0>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseCommentAsync>d__16>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<WriteTokenAsync>d__30>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<WriteAsyncInternal>d__57>
	|
	|-RVA: 0xE50730 Offset: 0xE4F130 VA: 0x180E50730
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JObject.<<WriteToAsync>g__AwaitProperties|0_0>d>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<WriteConstructorDateAsync>d__32>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<Connect>d__16>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnectionTunnel.<Initialize>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0xE50BB0 Offset: 0xE4F5B0 VA: 0x180E50BB0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JavaScriptUtils.<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<WriteAsyncInternal>d__62>
	|
	|-RVA: 0xE50B20 Offset: 0xE4F520 VA: 0x180E50B20
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JavaScriptUtils.<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<WriteAsyncInternal>d__59>
	|
	|-RVA: 0xE507C0 Offset: 0xE4F1C0 VA: 0x180E507C0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ParseStringAsync>d__18>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteCommentAsync>d__115>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteStartArrayAsync>d__35>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteStartConstructorAsync>d__40>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteStartObjectAsync>d__38>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteUndefinedAsync>d__43>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__60>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<DoWriteValueAsync>d__99>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteIndentAsync>d__13>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<WriteValueNonNullAsync>d__54>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonWriter.<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<Initialize>d__36>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<SetHeadersAsync>d__37>
	|
	|-RVA: 0xE50970 Offset: 0xE4F370 VA: 0x180E50970
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextReader.<ReadStringIntoBufferAsync>d__9>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<FlushAsyncInternal>d__74>
	|
	|-RVA: 0xE506A0 Offset: 0xE4F0A0 VA: 0x180E506A0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonTextWriter.<CloseBufferAndWriterAsync>d__9>
	|
	|-RVA: 0xE50E80 Offset: 0xE4F880 VA: 0x180E50E80
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, Stream.<CopyToAsyncInternal>d__28>
	|
	|-RVA: 0xE50F10 Offset: 0xE4F910 VA: 0x180E50F10
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, StreamWriter.<FlushAsyncInternal>d__74>
	*/

	// RVA: 0x1B5F7F0 Offset: 0x1B5E1F0 VA: 0x181B5F7F0
	public Task get_Task() { }

	// RVA: 0x1B5F660 Offset: 0x1B5E060 VA: 0x181B5F660
	public void SetResult() { }

	// RVA: 0x1B5F5F0 Offset: 0x1B5DFF0 VA: 0x181B5F5F0
	public void SetException(Exception exception) { }

	// RVA: 0x1B5F770 Offset: 0x1B5E170 VA: 0x181B5F770
	private static void .cctor() { }
}
