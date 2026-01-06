public sealed class GeometryUtility // TypeDefIndex: 11625
{
	// Methods

	// RVA: 0x2C8A8E0 Offset: 0x2C892E0 VA: 0x182C8A8E0
	public static Plane[] CalculateFrustumPlanes(Camera camera) { }

	// RVA: 0x2C8AB20 Offset: 0x2C89520 VA: 0x182C8AB20
	public static void CalculateFrustumPlanes(Camera camera, Plane[] planes) { }

	// RVA: 0x2C8AD30 Offset: 0x2C89730 VA: 0x182C8AD30
	public static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes) { }

	// RVA: 0x2C8AF40 Offset: 0x2C89940 VA: 0x182C8AF40
	public static bool TestPlanesAABB(Plane[] planes, Bounds bounds) { }

	[NativeName("ExtractPlanes")]
	// RVA: 0x2C8AEA0 Offset: 0x2C898A0 VA: 0x182C8AEA0
	private static void Internal_ExtractPlanes([Out] Plane[] planes, Matrix4x4 worldToProjectionMatrix) { }

	// RVA: 0x2C8AEF0 Offset: 0x2C898F0 VA: 0x182C8AEF0
	private static bool TestPlanesAABB_Injected(Plane[] planes, ref Bounds bounds) { }

	// RVA: 0x2C8AE50 Offset: 0x2C89850 VA: 0x182C8AE50
	private static void Internal_ExtractPlanes_Injected([Out] Plane[] planes, ref Matrix4x4 worldToProjectionMatrix) { }
}
