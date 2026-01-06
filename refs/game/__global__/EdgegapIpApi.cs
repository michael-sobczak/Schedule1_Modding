public class EdgegapIpApi : EdgegapApiBase // TypeDefIndex: 16898
{
	// Methods

	// RVA: 0xCD7A00 Offset: 0xCD6400 VA: 0x180CD7A00
	public void .ctor(ApiEnvironment apiEnvironment, string apiToken, EdgegapWindowMetadata.LogLevel logLevel = 1) { }

	[AsyncStateMachine(typeof(EdgegapIpApi.<GetYourPublicIp>d__1))]
	// RVA: 0xCD8300 Offset: 0xCD6D00 VA: 0x180CD8300
	public Task<EdgegapHttpResult<GetYourPublicIpResult>> GetYourPublicIp() { }
}
