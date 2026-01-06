public struct CoreRegistration // TypeDefIndex: 17843
{
	// Fields
	private readonly IPackageRegistry m_Registry; // 0x0
	private readonly int m_PackageHash; // 0x8

	// Methods

	// RVA: 0xD900B0 Offset: 0xD8EAB0 VA: 0x180D900B0
	internal void .ctor(IPackageRegistry registry, int packageHash) { }

	// RVA: -1 Offset: -1
	public CoreRegistration DependsOn<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6B340 Offset: 0xE69D40 VA: 0x180E6B340
	|-CoreRegistration.DependsOn<object>
	|-CoreRegistration.DependsOn<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public CoreRegistration OptionallyDependsOn<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6B340 Offset: 0xE69D40 VA: 0x180E6B340
	|-CoreRegistration.OptionallyDependsOn<object>
	|-CoreRegistration.OptionallyDependsOn<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public CoreRegistration ProvidesComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6B340 Offset: 0xE69D40 VA: 0x180E6B340
	|-CoreRegistration.ProvidesComponent<object>
	|-CoreRegistration.ProvidesComponent<__Il2CppFullySharedGenericType>
	*/
}
