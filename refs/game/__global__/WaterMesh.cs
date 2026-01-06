public class WaterMesh // TypeDefIndex: 18270
{
	// Fields
	public WaterMesh.Shape shape; // 0x10
	[Range(10, 1000)]
	[FormerlySerializedAs("size")]
	public float scale; // 0x14
	[Tooltip("Distance between vertices")]
	[Range(0.15, 10)]
	public float vertexDistance; // 0x18
	public float UVTiling; // 0x1C
	[Tooltip("Shifts the vertices in a random direction. Definitely use this when using flat shading")]
	[Range(0, 1)]
	public float noise; // 0x20
	[Min(0)]
	[Tooltip("The surface is normally flat, yet vertex displacement on the GPU such as waves can give the surface artificial height.

This can cause a Mesh Renderer to be prematurely culled, despite still actually being visible.

This value adds an artificial amount of height to the generate mesh's bounds, to avoid this from happening.")]
	public float boundsPadding; // 0x24
	public Mesh mesh; // 0x28
	private static Vector4 defaultTangent; // 0x0

	// Methods

	// RVA: 0x1F71E80 Offset: 0x1F70880 VA: 0x181F71E80
	public Mesh Rebuild() { }

	// RVA: 0x1F71D60 Offset: 0x1F70760 VA: 0x181F71D60
	public static Mesh Create(WaterMesh.Shape shape, float size, float vertexDistance, float uvTiling = 1, float noise = 0) { }

	// RVA: 0x1F71E50 Offset: 0x1F70850 VA: 0x181F71E50
	private int GetPointIndex(int c, int x) { }

	// RVA: 0x1F70900 Offset: 0x1F6F300 VA: 0x181F70900
	private Mesh CreateCircle() { }

	// RVA: 0x1F71540 Offset: 0x1F6FF40 VA: 0x181F71540
	private Mesh CreatePlane() { }

	// RVA: 0x1F71F30 Offset: 0x1F70930 VA: 0x181F71F30
	public void .ctor() { }

	// RVA: 0x1F71EF0 Offset: 0x1F708F0 VA: 0x181F71EF0
	private static void .cctor() { }
}
