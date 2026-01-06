internal class CoreRegistryInitializer // TypeDefIndex: 17849
{
	// Fields
	[NotNull]
	private readonly CoreRegistry m_Registry; // 0x10
	[NotNull]
	private readonly List<int> m_SortedPackageTypeHashes; // 0x18

	// Methods

	// RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	public void .ctor(CoreRegistry registry, List<int> sortedPackageTypeHashes) { }

	[AsyncStateMachine(typeof(CoreRegistryInitializer.<InitializeRegistryAsync>d__3))]
	// RVA: 0x2B9BF00 Offset: 0x2B9A900 VA: 0x182B9BF00
	public Task<List<PackageInitializationInfo>> InitializeRegistryAsync() { }
}
