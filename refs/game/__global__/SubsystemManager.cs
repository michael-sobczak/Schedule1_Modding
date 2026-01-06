public static class SubsystemManager // TypeDefIndex: 19144
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action beforeReloadSubsystems; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action afterReloadSubsystems; // 0x8
	private static List<IntegratedSubsystem> s_IntegratedSubsystems; // 0x10
	private static List<SubsystemWithProvider> s_StandaloneSubsystems; // 0x18
	private static List<Subsystem> s_DeprecatedSubsystems; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action reloadSubsytemsStarted; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action reloadSubsytemsCompleted; // 0x30

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2D445B0 Offset: 0x2D42FB0 VA: 0x182D445B0
	private static void ReloadSubsystemsStarted() { }

	[RequiredByNativeCode]
	// RVA: 0x2D444C0 Offset: 0x2D42EC0 VA: 0x182D444C0
	private static void ReloadSubsystemsCompleted() { }

	[RequiredByNativeCode]
	// RVA: 0x2D443B0 Offset: 0x2D42DB0 VA: 0x182D443B0
	private static void InitializeIntegratedSubsystem(IntPtr ptr, IntegratedSubsystem subsystem) { }

	[RequiredByNativeCode]
	// RVA: 0x2D44020 Offset: 0x2D42A20 VA: 0x182D44020
	private static void ClearSubsystems() { }

	// RVA: 0x2D446A0 Offset: 0x2D430A0 VA: 0x182D446A0
	private static void StaticConstructScriptingClassMap() { }

	// RVA: 0x2D446D0 Offset: 0x2D430D0 VA: 0x182D446D0
	private static void .cctor() { }

	// RVA: -1 Offset: -1
	public static void GetSubsystems<T>(List<T> subsystems) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5B970 Offset: 0xF5A370 VA: 0x180F5B970
	|-SubsystemManager.GetSubsystems<object>
	|
	|-RVA: 0xF5B890 Offset: 0xF5A290 VA: 0x180F5B890
	|-SubsystemManager.GetSubsystems<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void AddSubsystemSubset<TBaseTypeInList, TQueryType>(List<TBaseTypeInList> copyFrom, List<TQueryType> copyTo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5B500 Offset: 0xF59F00 VA: 0x180F5B500
	|-SubsystemManager.AddSubsystemSubset<object, object>
	|
	|-RVA: 0xF5B0C0 Offset: 0xF59AC0 VA: 0x180F5B0C0
	|-SubsystemManager.AddSubsystemSubset<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2D44240 Offset: 0x2D42C40 VA: 0x182D44240
	internal static IntegratedSubsystem GetIntegratedSubsystemByPtr(IntPtr ptr) { }

	// RVA: -1 Offset: -1
	public static void GetInstances<T>(List<T> subsystems) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5B760 Offset: 0xF5A160 VA: 0x180F5B760
	|-SubsystemManager.GetInstances<object>
	|
	|-RVA: 0xF5B6F0 Offset: 0xF5A0F0 VA: 0x180F5B6F0
	|-SubsystemManager.GetInstances<__Il2CppFullySharedGenericType>
	*/
}
