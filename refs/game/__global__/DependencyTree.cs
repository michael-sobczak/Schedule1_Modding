internal class DependencyTree // TypeDefIndex: 17850
{
	// Fields
	public readonly Dictionary<int, IInitializablePackage> PackageTypeHashToInstance; // 0x10
	public readonly Dictionary<int, int> ComponentTypeHashToPackageTypeHash; // 0x18
	public readonly Dictionary<int, List<int>> PackageTypeHashToComponentTypeHashDependencies; // 0x20
	public readonly Dictionary<int, IServiceComponent> ComponentTypeHashToInstance; // 0x28

	// Methods

	// RVA: 0x2B9EA90 Offset: 0x2B9D490 VA: 0x182B9EA90
	internal void .ctor() { }

	// RVA: 0x1CD3000 Offset: 0x1CD1A00 VA: 0x181CD3000
	internal void .ctor(Dictionary<int, IInitializablePackage> packageToInstance, Dictionary<int, int> componentToPackage, Dictionary<int, List<int>> packageToComponentDependencies, Dictionary<int, IServiceComponent> componentToInstance) { }
}
