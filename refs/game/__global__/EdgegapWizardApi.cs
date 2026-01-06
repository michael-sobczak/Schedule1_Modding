public class EdgegapWizardApi : EdgegapApiBase // TypeDefIndex: 16901
{
	// Methods

	// RVA: 0xCD7A00 Offset: 0xCD6400 VA: 0x180CD7A00
	public void .ctor(ApiEnvironment apiEnvironment, string apiToken, EdgegapWindowMetadata.LogLevel logLevel = 1) { }

	[AsyncStateMachine(typeof(EdgegapWizardApi.<InitQuickStart>d__1))]
	// RVA: 0xCD84E0 Offset: 0xCD6EE0 VA: 0x180CD84E0
	public Task<EdgegapHttpResult> InitQuickStart() { }

	[AsyncStateMachine(typeof(EdgegapWizardApi.<GetRegistryCredentials>d__2))]
	// RVA: 0xCD83F0 Offset: 0xCD6DF0 VA: 0x180CD83F0
	public Task<EdgegapHttpResult<GetRegistryCredentialsResult>> GetRegistryCredentials() { }
}
