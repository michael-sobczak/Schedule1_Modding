public static class BlitUtility // TypeDefIndex: 10811
{
	// Fields
	private static readonly int MainTexHash; // 0x0
	private static Vector4[] normals; // 0x8
	private static Vector4[] tempVertecies; // 0x10
	private static VertexAttributeDescriptor[] vertexParams; // 0x18
	private static ushort[] indecies; // 0x20
	private static BlitUtility.Vertex[] vertices; // 0x28
	private static Matrix4x4[] matrices; // 0x30
	private static int itemsToDraw; // 0x38
	private static Nullable<bool> supportsInstancing; // 0x3C

	// Properties
	private static bool SupportsInstancing { get; }

	// Methods

	// RVA: 0x5407C0 Offset: 0x53F1C0 VA: 0x1805407C0
	private static bool get_SupportsInstancing() { }

	// RVA: 0x5401D0 Offset: 0x53EBD0 VA: 0x1805401D0
	private static void UpdateBounds(Renderer renderer, OutlineTarget target) { }

	// RVA: 0x53D630 Offset: 0x53C030 VA: 0x18053D630
	public static void PrepareForRendering(OutlineParameters parameters) { }

	// RVA: 0x53F010 Offset: 0x53DA10 VA: 0x18053F010
	private static Nullable<BlitUtility.MeshSetupResult> SetupForInstancing(OutlineParameters parameters) { }

	// RVA: 0x53D9D0 Offset: 0x53C3D0 VA: 0x18053D9D0
	private static Nullable<BlitUtility.MeshSetupResult> SetupForBruteForce(OutlineParameters parameters) { }

	// RVA: 0x53D140 Offset: 0x53BB40 VA: 0x18053D140
	public static void Blit(OutlineParameters parameters, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier destinationDepth, Material material, CommandBuffer targetBuffer, int pass = -1, Nullable<Rect> viewport) { }

	// RVA: 0x53D3F0 Offset: 0x53BDF0 VA: 0x18053D3F0
	public static void Draw(OutlineParameters parameters, RenderTargetIdentifier target, RenderTargetIdentifier depth, Material material, Nullable<Rect> viewport) { }

	// RVA: 0x540390 Offset: 0x53ED90 VA: 0x180540390
	private static void .cctor() { }
}
