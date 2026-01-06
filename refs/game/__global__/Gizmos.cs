public sealed class Gizmos // TypeDefIndex: 11634
{
	// Properties
	public static Color color { get; set; }
	public static Matrix4x4 matrix { get; set; }

	// Methods

	[NativeThrows]
	// RVA: 0x2C8B160 Offset: 0x2C89B60 VA: 0x182C8B160
	public static void DrawLine(Vector3 from, Vector3 to) { }

	[NativeThrows]
	// RVA: 0x2C8B790 Offset: 0x2C8A190 VA: 0x182C8B790
	public static void DrawWireSphere(Vector3 center, float radius) { }

	[NativeThrows]
	// RVA: 0x2C8B500 Offset: 0x2C89F00 VA: 0x182C8B500
	public static void DrawSphere(Vector3 center, float radius) { }

	[NativeThrows]
	// RVA: 0x2C8B5A0 Offset: 0x2C89FA0 VA: 0x182C8B5A0
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	[NativeThrows]
	// RVA: 0x2C8AFE0 Offset: 0x2C899E0 VA: 0x182C8AFE0
	public static void DrawCube(Vector3 center, Vector3 size) { }

	[NativeThrows]
	// RVA: 0x2C8B330 Offset: 0x2C89D30 VA: 0x182C8B330
	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[NativeThrows]
	// RVA: 0x2C8B650 Offset: 0x2C8A050 VA: 0x182C8B650
	public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[NativeThrows]
	// RVA: 0x2C8B0A0 Offset: 0x2C89AA0 VA: 0x182C8B0A0
	public static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint) { }

	// RVA: 0x2C8B820 Offset: 0x2C8A220 VA: 0x182C8B820
	public static Color get_color() { }

	// RVA: 0x2C8B930 Offset: 0x2C8A330 VA: 0x182C8B930
	public static void set_color(Color value) { }

	// RVA: 0x2C8B8A0 Offset: 0x2C8A2A0 VA: 0x182C8B8A0
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x2C8B9B0 Offset: 0x2C8A3B0 VA: 0x182C8B9B0
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x2C8B420 Offset: 0x2C89E20 VA: 0x182C8B420
	public static void DrawRay(Vector3 from, Vector3 direction) { }

	[ExcludeFromDocs]
	// RVA: 0x2C8B210 Offset: 0x2C89C10 VA: 0x182C8B210
	public static void DrawMesh(Mesh mesh) { }

	// RVA: 0x2C8B3A0 Offset: 0x2C89DA0 VA: 0x182C8B3A0
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x2C8B6C0 Offset: 0x2C8A0C0 VA: 0x182C8B6C0
	public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x2C8B110 Offset: 0x2C89B10 VA: 0x182C8B110
	private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to) { }

	// RVA: 0x2C8B740 Offset: 0x2C8A140 VA: 0x182C8B740
	private static void DrawWireSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x2C8B4B0 Offset: 0x2C89EB0 VA: 0x182C8B4B0
	private static void DrawSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x2C8B550 Offset: 0x2C89F50 VA: 0x182C8B550
	private static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x2C8AF90 Offset: 0x2C89990 VA: 0x182C8AF90
	private static void DrawCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x2C8B1B0 Offset: 0x2C89BB0 VA: 0x182C8B1B0
	private static void DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale) { }

	// RVA: 0x2C8B5F0 Offset: 0x2C89FF0 VA: 0x182C8B5F0
	private static void DrawWireMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale) { }

	// RVA: 0x2C8B030 Offset: 0x2C89A30 VA: 0x182C8B030
	private static void DrawIcon_Injected(ref Vector3 center, string name, bool allowScaling, ref Color tint) { }

	// RVA: 0x2C8B7E0 Offset: 0x2C8A1E0 VA: 0x182C8B7E0
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x2C8B8F0 Offset: 0x2C8A2F0 VA: 0x182C8B8F0
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x2C8B860 Offset: 0x2C8A260 VA: 0x182C8B860
	private static void get_matrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2C8B970 Offset: 0x2C8A370 VA: 0x182C8B970
	private static void set_matrix_Injected(ref Matrix4x4 value) { }
}
