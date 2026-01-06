internal static class DependencyInjector // TypeDefIndex: 3459
{
	// Fields
	private static object locker; // 0x0
	private static ISystemDependencyProvider systemDependency; // 0x8

	// Properties
	internal static ISystemDependencyProvider SystemProvider { get; }

	// Methods

	// RVA: 0x1A85230 Offset: 0x1A83C30 VA: 0x181A85230
	internal static ISystemDependencyProvider get_SystemProvider() { }

	// RVA: 0x1A85020 Offset: 0x1A83A20 VA: 0x181A85020
	internal static void Register(ISystemDependencyProvider provider) { }

	// RVA: 0x1A84EE0 Offset: 0x1A838E0 VA: 0x181A84EE0
	private static ISystemDependencyProvider ReflectionLoad() { }

	// RVA: 0x1A851B0 Offset: 0x1A83BB0 VA: 0x181A851B0
	private static void .cctor() { }
}
