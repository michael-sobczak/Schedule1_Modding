public static class PhysicsSceneExtensions2D // TypeDefIndex: 18823
{
	// Methods

	[Extension]
	// RVA: 0x2D31100 Offset: 0x2D2FB00 VA: 0x182D31100
	public static PhysicsScene2D GetPhysicsScene2D(Scene scene) { }

	[NativeMethod("GetPhysicsSceneFromUnityScene")]
	[StaticAccessor("GetPhysicsManager2D()", 1)]
	// RVA: 0x2D31290 Offset: 0x2D2FC90 VA: 0x182D31290
	private static PhysicsScene2D GetPhysicsScene_Internal(Scene scene) { }

	// RVA: 0x2D31240 Offset: 0x2D2FC40 VA: 0x182D31240
	private static void GetPhysicsScene_Internal_Injected(ref Scene scene, out PhysicsScene2D ret) { }
}
