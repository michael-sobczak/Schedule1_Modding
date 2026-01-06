public static class PhysicsSceneExtensions // TypeDefIndex: 18484
{
	// Methods

	[Extension]
	// RVA: 0x2D34000 Offset: 0x2D32A00 VA: 0x182D34000
	public static PhysicsScene GetPhysicsScene(Scene scene) { }

	[StaticAccessor("GetPhysicsManager()", 0)]
	[NativeMethod("GetPhysicsSceneFromUnityScene")]
	// RVA: 0x2D33FB0 Offset: 0x2D329B0 VA: 0x182D33FB0
	private static PhysicsScene GetPhysicsScene_Internal(Scene scene) { }

	// RVA: 0x2D33F60 Offset: 0x2D32960 VA: 0x182D33F60
	private static void GetPhysicsScene_Internal_Injected(ref Scene scene, out PhysicsScene ret) { }
}
