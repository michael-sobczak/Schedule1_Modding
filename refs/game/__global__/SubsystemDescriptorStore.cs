public static class SubsystemDescriptorStore // TypeDefIndex: 19145
{
	// Fields
	private static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors; // 0x0
	private static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors; // 0x8
	private static List<SubsystemDescriptor> s_DeprecatedDescriptors; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2D43D30 Offset: 0x2D42730 VA: 0x182D43D30
	internal static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc) { }

	[RequiredByNativeCode]
	// RVA: 0x2D43BA0 Offset: 0x2D425A0 VA: 0x182D43BA0
	internal static void ClearManagedDescriptors() { }

	// RVA: 0x2D43E90 Offset: 0x2D42890 VA: 0x182D43E90
	private static void ReportSingleSubsystemAnalytics(string id) { }

	// RVA: -1 Offset: -1
	internal static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, List<TBaseTypeInList> storeInList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5AE90 Offset: 0xF59890 VA: 0x180F5AE90
	|-SubsystemDescriptorStore.RegisterDescriptor<object, object>
	|
	|-RVA: 0xF5A8B0 Offset: 0xF592B0 VA: 0x180F5A8B0
	|-SubsystemDescriptorStore.RegisterDescriptor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2D43E20 Offset: 0x2D42820 VA: 0x182D43E20
	internal static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor) { }

	// RVA: 0x2D43ED0 Offset: 0x2D428D0 VA: 0x182D43ED0
	private static void .cctor() { }
}
