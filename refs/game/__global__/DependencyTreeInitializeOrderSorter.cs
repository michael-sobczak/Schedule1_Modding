internal struct DependencyTreeInitializeOrderSorter // TypeDefIndex: 17854
{
	// Fields
	public readonly DependencyTree Tree; // 0x0
	public readonly ICollection<int> Target; // 0x8
	private Dictionary<int, DependencyTreeInitializeOrderSorter.ExplorationMark> m_PackageTypeHashExplorationHistory; // 0x10

	// Methods

	// RVA: 0x2B9E800 Offset: 0x2B9D200 VA: 0x182B9E800
	public void .ctor(DependencyTree tree, ICollection<int> target) { }

	// RVA: 0x2B9E030 Offset: 0x2B9CA30 VA: 0x182B9E030
	public void SortRegisteredPackagesIntoTarget() { }

	// RVA: 0x2B9DD20 Offset: 0x2B9C720 VA: 0x182B9DD20
	private void RemoveUnprovidedOptionalDependenciesFromTree() { }

	// RVA: 0x2B9DE50 Offset: 0x2B9C850 VA: 0x182B9DE50
	private void RemoveUnprovidedOptionalDependencies(IList<int> dependencyTypeHashes) { }

	// RVA: 0x2B9E530 Offset: 0x2B9CF30 VA: 0x182B9E530
	private void SortTreeThrough(int packageTypeHash) { }

	// RVA: 0x2B9E360 Offset: 0x2B9CD60 VA: 0x182B9E360
	private void SortTreeThrough(IEnumerable<int> dependencyTypeHashes) { }

	// RVA: 0x2B9DCB0 Offset: 0x2B9C6B0 VA: 0x182B9DCB0
	private void MarkPackage(int packageTypeHash, DependencyTreeInitializeOrderSorter.ExplorationMark mark) { }

	// RVA: 0x2B9DC60 Offset: 0x2B9C660 VA: 0x182B9DC60
	private IReadOnlyCollection<int> GetPackageTypeHashes() { }

	// RVA: 0x2B9DB60 Offset: 0x2B9C560 VA: 0x182B9DB60
	private int GetPackageTypeHashFor(int componentTypeHash) { }

	// RVA: 0x2B9DA60 Offset: 0x2B9C460 VA: 0x182B9DA60
	private IEnumerable<int> GetDependencyTypeHashesFor(int packageTypeHash) { }
}
