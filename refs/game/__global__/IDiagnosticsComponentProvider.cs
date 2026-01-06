internal interface IDiagnosticsComponentProvider // TypeDefIndex: 17793
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task<IDiagnosticsFactory> CreateDiagnosticsComponents();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Task<string> GetSerializedProjectConfigurationAsync();
}
