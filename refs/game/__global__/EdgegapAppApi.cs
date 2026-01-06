public class EdgegapAppApi : EdgegapApiBase // TypeDefIndex: 16889
{
	// Methods

	// RVA: 0xCD7A00 Offset: 0xCD6400 VA: 0x180CD7A00
	public void .ctor(ApiEnvironment apiEnvironment, string apiToken, EdgegapWindowMetadata.LogLevel logLevel = 1) { }

	[AsyncStateMachine(typeof(EdgegapAppApi.<CreateApp>d__1))]
	// RVA: 0xCD75C0 Offset: 0xCD5FC0 VA: 0x180CD75C0
	public Task<EdgegapHttpResult<GetCreateAppResult>> CreateApp(CreateAppRequest request) { }

	[AsyncStateMachine(typeof(EdgegapAppApi.<GetApp>d__2))]
	// RVA: 0xCD76D0 Offset: 0xCD60D0 VA: 0x180CD76D0
	public Task<EdgegapHttpResult<GetCreateAppResult>> GetApp(string appName) { }

	[AsyncStateMachine(typeof(EdgegapAppApi.<UpdateAppVersion>d__3))]
	// RVA: 0xCD77E0 Offset: 0xCD61E0 VA: 0x180CD77E0
	public Task<EdgegapHttpResult<UpsertAppVersionResult>> UpdateAppVersion(UpdateAppVersionRequest request) { }

	[AsyncStateMachine(typeof(EdgegapAppApi.<CreateAppVersion>d__4))]
	// RVA: 0xCD74B0 Offset: 0xCD5EB0 VA: 0x180CD74B0
	public Task<EdgegapHttpResult<UpsertAppVersionResult>> CreateAppVersion(CreateAppVersionRequest request) { }

	[AsyncStateMachine(typeof(EdgegapAppApi.<UpsertAppVersion>d__5))]
	// RVA: 0xCD78F0 Offset: 0xCD62F0 VA: 0x180CD78F0
	public Task<EdgegapHttpResult<UpsertAppVersionResult>> UpsertAppVersion(UpdateAppVersionRequest request) { }
}
