internal static class UnityServicesInitializer // TypeDefIndex: 17875
{
	// Methods

	[RuntimeInitializeOnLoadMethod(2)]
	// RVA: 0x2BA2F90 Offset: 0x2BA1990 VA: 0x182BA2F90
	private static void CreateStaticInstance() { }

	[RuntimeInitializeOnLoadMethod(0)]
	[AsyncStateMachine(typeof(UnityServicesInitializer.<EnableServicesInitializationAsync>d__1))]
	// RVA: 0x2BA3460 Offset: 0x2BA1E60 VA: 0x182BA3460
	private static void EnableServicesInitializationAsync() { }

	// RVA: 0x2BA2E20 Offset: 0x2BA1820 VA: 0x182BA2E20
	internal static IUnityServices CreateInstance(string servicesId) { }
}
