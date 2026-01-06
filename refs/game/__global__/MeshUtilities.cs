internal static class MeshUtilities // TypeDefIndex: 17066
{
	// Fields
	private static Dictionary<PrimitiveType, Mesh> s_Primitives; // 0x0
	private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives; // 0x8

	// Methods

	// RVA: 0x29AC600 Offset: 0x29AB000 VA: 0x1829AC600
	private static void .cctor() { }

	// RVA: 0x29AC1D0 Offset: 0x29AABD0 VA: 0x1829AC1D0
	internal static Mesh GetColliderMesh(Collider collider) { }

	// RVA: 0x29AC480 Offset: 0x29AAE80 VA: 0x1829AC480
	internal static Mesh GetPrimitive(PrimitiveType primitiveType) { }

	// RVA: 0x29AC130 Offset: 0x29AAB30 VA: 0x1829AC130
	private static Mesh GetBuiltinMesh(PrimitiveType primitiveType) { }
}
