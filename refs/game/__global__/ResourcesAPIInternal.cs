internal static class ResourcesAPIInternal // TypeDefIndex: 11788
{
	// Methods

	[TypeInferenceRule(2)]
	[FreeFunction("Resources_Bindings::FindObjectsOfTypeAll")]
	// RVA: 0x2CC6380 Offset: 0x2CC4D80 VA: 0x182CC6380
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	[FreeFunction("GetShaderNameRegistry().FindShader")]
	// RVA: 0x2CC63C0 Offset: 0x2CC4DC0 VA: 0x182CC63C0
	public static Shader FindShaderByName(string name) { }

	[TypeInferenceRule(1)]
	[NativeThrows]
	[FreeFunction("Resources_Bindings::Load")]
	// RVA: 0x2CC6450 Offset: 0x2CC4E50 VA: 0x182CC6450
	public static Object Load(string path, Type systemTypeInstance) { }

	[NativeThrows]
	[FreeFunction("Resources_Bindings::LoadAll")]
	// RVA: 0x2CC6400 Offset: 0x2CC4E00 VA: 0x182CC6400
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }
}
