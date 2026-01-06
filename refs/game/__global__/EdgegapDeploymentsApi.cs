public class EdgegapDeploymentsApi : EdgegapApiBase // TypeDefIndex: 16896
{
	// Methods

	// RVA: 0xCD7A00 Offset: 0xCD6400 VA: 0x180CD7A00
	public void .ctor(ApiEnvironment apiEnvironment, string apiToken, EdgegapWindowMetadata.LogLevel logLevel = 1) { }

	[AsyncStateMachine(typeof(EdgegapDeploymentsApi.<CreateDeploymentAsync>d__1))]
	// RVA: 0xCD7C90 Offset: 0xCD6690 VA: 0x180CD7C90
	public Task<EdgegapHttpResult<CreateDeploymentResult>> CreateDeploymentAsync(CreateDeploymentRequest request) { }

	[AsyncStateMachine(typeof(EdgegapDeploymentsApi.<GetDeploymentStatusAsync>d__2))]
	// RVA: 0xCD7EE0 Offset: 0xCD68E0 VA: 0x180CD7EE0
	public Task<EdgegapHttpResult<GetDeploymentStatusResult>> GetDeploymentStatusAsync(string requestId) { }

	[AsyncStateMachine(typeof(EdgegapDeploymentsApi.<StopActiveDeploymentAsync>d__3))]
	// RVA: 0xCD7FF0 Offset: 0xCD69F0 VA: 0x180CD7FF0
	public Task<EdgegapHttpResult<StopActiveDeploymentResult>> StopActiveDeploymentAsync(string requestId) { }

	[AsyncStateMachine(typeof(EdgegapDeploymentsApi.<CreateDeploymentAwaitReadyStatusAsync>d__4))]
	// RVA: 0xCD7DA0 Offset: 0xCD67A0 VA: 0x180CD7DA0
	public Task<EdgegapHttpResult<CreateDeploymentResult>> CreateDeploymentAwaitReadyStatusAsync(CreateDeploymentRequest request, TimeSpan pollInterval) { }

	[AsyncStateMachine(typeof(EdgegapDeploymentsApi.<AwaitReadyStatusAsync>d__5))]
	// RVA: 0xCD7A10 Offset: 0xCD6410 VA: 0x180CD7A10
	public Task<EdgegapHttpResult<GetDeploymentStatusResult>> AwaitReadyStatusAsync(string requestId, TimeSpan pollInterval) { }

	[AsyncStateMachine(typeof(EdgegapDeploymentsApi.<AwaitTerminatedDeleteStatusAsync>d__6))]
	// RVA: 0xCD7B50 Offset: 0xCD6550 VA: 0x180CD7B50
	public Task<EdgegapHttpResult<StopActiveDeploymentResult>> AwaitTerminatedDeleteStatusAsync(string requestId, TimeSpan pollInterval) { }
}
