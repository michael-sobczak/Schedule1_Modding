public abstract class EdgegapApiBase // TypeDefIndex: 16883
{
	// Fields
	private readonly HttpClient _httpClient; // 0x10
	[CompilerGenerated]
	private readonly ApiEnvironment <SelectedApiEnvironment>k__BackingField; // 0x18
	[CompilerGenerated]
	private EdgegapWindowMetadata.LogLevel <LogLevel>k__BackingField; // 0x1C

	// Properties
	protected ApiEnvironment SelectedApiEnvironment { get; }
	protected EdgegapWindowMetadata.LogLevel LogLevel { get; set; }
	protected bool IsLogLevelDebug { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	protected ApiEnvironment get_SelectedApiEnvironment() { }

	[CompilerGenerated]
	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	protected EdgegapWindowMetadata.LogLevel get_LogLevel() { }

	[CompilerGenerated]
	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	protected void set_LogLevel(EdgegapWindowMetadata.LogLevel value) { }

	// RVA: 0xCCB4D0 Offset: 0xCC9ED0 VA: 0x180CCB4D0
	protected bool get_IsLogLevelDebug() { }

	// RVA: 0xCCAF40 Offset: 0xCC9940 VA: 0x180CCAF40
	private string GetBaseUrl() { }

	// RVA: 0xCCB240 Offset: 0xCC9C40 VA: 0x180CCB240
	protected void .ctor(ApiEnvironment apiEnvironment, string apiToken, EdgegapWindowMetadata.LogLevel logLevel = 1) { }

	[AsyncStateMachine(typeof(EdgegapApiBase.<PostAsync>d__12))]
	// RVA: 0xCCB100 Offset: 0xCC9B00 VA: 0x180CCB100
	protected Task<HttpResponseMessage> PostAsync(string relativePath = "", string json = "{}") { }

	[AsyncStateMachine(typeof(EdgegapApiBase.<PatchAsync>d__13))]
	// RVA: 0xCCAFC0 Offset: 0xCC99C0 VA: 0x180CCAFC0
	protected Task<HttpResponseMessage> PatchAsync(string relativePath = "", string json = "{}") { }

	[AsyncStateMachine(typeof(EdgegapApiBase.<GetAsync>d__14))]
	// RVA: 0xCCAE00 Offset: 0xCC9800 VA: 0x180CCAE00
	protected Task<HttpResponseMessage> GetAsync(string relativePath = "", string customQuery = "") { }

	[AsyncStateMachine(typeof(EdgegapApiBase.<DeleteAsync>d__15))]
	// RVA: 0xCCABB0 Offset: 0xCC95B0 VA: 0x180CCABB0
	protected Task<HttpResponseMessage> DeleteAsync(string relativePath = "", string customQuery = "") { }

	[AsyncStateMachine(typeof(EdgegapApiBase.<ExecuteRequestAsync>d__16))]
	// RVA: 0xCCACF0 Offset: 0xCC96F0 VA: 0x180CCACF0
	private static Task<HttpResponseMessage> ExecuteRequestAsync(Func<Task<HttpResponseMessage>> requestFunc, CancellationToken cancellationToken) { }

	// RVA: 0xCCAAD0 Offset: 0xCC94D0 VA: 0x180CCAAD0
	private StringContent CreateStringContent(string json = "{}") { }

	// RVA: 0xCCAB60 Offset: 0xCC9560 VA: 0x180CCAB60
	private static HttpResponseMessage CreateUnknown500Err() { }

	// RVA: 0xCCB4E0 Offset: 0xCC9EE0 VA: 0x180CCB4E0
	private string prepareEdgegapUriWithQuery(string relativePath, string customQuery) { }
}
