internal class ResourceManager // TypeDefIndex: 18251
{
	// Fields
	private static List<Object> _objectsToDestroy; // 0x0
	private static Dictionary<PrimitiveType, Mesh> _meshLookup; // 0x8

	// Methods

	// RVA: 0x2F68110 Offset: 0x2F66B10 VA: 0x182F68110
	public static Mesh GetPrimitiveMesh(PrimitiveType type) { }

	// RVA: 0x2F67FE0 Offset: 0x2F669E0 VA: 0x182F67FE0
	public static void Destroy(Object obj) { }

	// RVA: 0x2F67E00 Offset: 0x2F66800 VA: 0x182F67E00
	internal static void DestroyPending() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x2F683D0 Offset: 0x2F66DD0 VA: 0x182F683D0
	private static void .cctor() { }
}
