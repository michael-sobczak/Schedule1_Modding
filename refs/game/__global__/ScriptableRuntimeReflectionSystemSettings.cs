public static class ScriptableRuntimeReflectionSystemSettings // TypeDefIndex: 12340
{
	// Fields
	private static ScriptableRuntimeReflectionSystemWrapper s_Instance; // 0x0

	// Properties
	private static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system { set; }
	private static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2CFC390 Offset: 0x2CFAD90 VA: 0x182CFC390
	private static void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(IScriptableRuntimeReflectionSystem value) { }

	[RequiredByNativeCode]
	// RVA: 0x2CFC340 Offset: 0x2CFAD40 VA: 0x182CFC340
	private static ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance() { }

	[StaticAccessor("ScriptableRuntimeReflectionSystem", 2)]
	[RuntimeInitializeOnLoadMethod(0)]
	// RVA: 0x2CFC290 Offset: 0x2CFAC90 VA: 0x182CFC290
	private static void ScriptingDirtyReflectionSystemInstance() { }

	// RVA: 0x2CFC2C0 Offset: 0x2CFACC0 VA: 0x182CFC2C0
	private static void .cctor() { }
}
