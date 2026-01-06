public interface IDiagnosticsFactory : IServiceComponent // TypeDefIndex: 17794
{
	// Properties
	public abstract IReadOnlyDictionary<string, string> CommonTags { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IReadOnlyDictionary<string, string> get_CommonTags();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDiagnostics Create(string packageName);
}
