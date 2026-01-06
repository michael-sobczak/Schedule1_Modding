public static class RuntimePreviewGenerator // TypeDefIndex: 19053
{
	// Fields
	private const int PREVIEW_LAYER = 20;
	private static Vector3 PREVIEW_POSITION; // 0x0
	private static Camera renderCamera; // 0x10
	private static readonly RuntimePreviewGenerator.CameraSetup cameraSetup; // 0x18
	private static readonly Vector3[] boundingBoxPoints; // 0x20
	private static readonly Vector3[] localBoundsMinMax; // 0x28
	private static readonly List<Renderer> renderersList; // 0x30
	private static readonly List<int> layersList; // 0x38
	private static Camera m_internalCamera; // 0x40
	public static Vector3 CamPos; // 0x48
	public static Quaternion CamRot; // 0x54
	private static Camera m_previewRenderCamera; // 0x68
	private static Vector3 m_previewDirection; // 0x70
	private static float m_padding; // 0x7C
	private static Color m_backgroundColor; // 0x80
	private static bool m_orthographicMode; // 0x90
	private static bool m_useLocalBounds; // 0x91
	private static float m_renderSupersampling; // 0x94
	private static bool m_markTextureNonReadable; // 0x98

	// Properties
	private static Camera InternalCamera { get; }
	public static Camera PreviewRenderCamera { get; set; }
	public static Vector3 PreviewDirection { get; set; }
	public static float Padding { get; set; }
	public static Color BackgroundColor { get; set; }
	public static bool OrthographicMode { get; set; }
	public static bool UseLocalBounds { get; set; }
	public static float RenderSupersampling { get; set; }
	public static bool MarkTextureNonReadable { get; set; }

	// Methods

	// RVA: 0x1F5DCA0 Offset: 0x1F5C6A0 VA: 0x181F5DCA0
	private static Camera get_InternalCamera() { }

	// RVA: 0x1F5E020 Offset: 0x1F5CA20 VA: 0x181F5E020
	public static Camera get_PreviewRenderCamera() { }

	// RVA: 0x1F5E360 Offset: 0x1F5CD60 VA: 0x181F5E360
	public static void set_PreviewRenderCamera(Camera value) { }

	// RVA: 0x1F5DFB0 Offset: 0x1F5C9B0 VA: 0x181F5DFB0
	public static Vector3 get_PreviewDirection() { }

	// RVA: 0x1F5E2D0 Offset: 0x1F5CCD0 VA: 0x181F5E2D0
	public static void set_PreviewDirection(Vector3 value) { }

	// RVA: 0x1F5DF60 Offset: 0x1F5C960 VA: 0x181F5DF60
	public static float get_Padding() { }

	// RVA: 0x1F5E250 Offset: 0x1F5CC50 VA: 0x181F5E250
	public static void set_Padding(float value) { }

	// RVA: 0x1F5DC40 Offset: 0x1F5C640 VA: 0x181F5DC40
	public static Color get_BackgroundColor() { }

	// RVA: 0x1F5E130 Offset: 0x1F5CB30 VA: 0x181F5E130
	public static void set_BackgroundColor(Color value) { }

	// RVA: 0x1F5DF00 Offset: 0x1F5C900 VA: 0x181F5DF00
	public static bool get_OrthographicMode() { }

	// RVA: 0x1F5E1F0 Offset: 0x1F5CBF0 VA: 0x181F5E1F0
	public static void set_OrthographicMode(bool value) { }

	// RVA: 0x1F5E0D0 Offset: 0x1F5CAD0 VA: 0x181F5E0D0
	public static bool get_UseLocalBounds() { }

	// RVA: 0x1F5E450 Offset: 0x1F5CE50 VA: 0x181F5E450
	public static void set_UseLocalBounds(bool value) { }

	// RVA: 0x1F5E070 Offset: 0x1F5CA70 VA: 0x181F5E070
	public static float get_RenderSupersampling() { }

	// RVA: 0x1F5E3D0 Offset: 0x1F5CDD0 VA: 0x181F5E3D0
	public static void set_RenderSupersampling(float value) { }

	// RVA: 0x1F5DEA0 Offset: 0x1F5C8A0 VA: 0x181F5DEA0
	public static bool get_MarkTextureNonReadable() { }

	// RVA: 0x1F5E190 Offset: 0x1F5CB90 VA: 0x181F5E190
	public static void set_MarkTextureNonReadable(bool value) { }

	// RVA: 0x1F5BA60 Offset: 0x1F5A460 VA: 0x181F5BA60
	public static Texture2D GenerateMaterialPreview(Material material, PrimitiveType previewPrimitive, int width = 64, int height = 64) { }

	// RVA: 0x1F5B9C0 Offset: 0x1F5A3C0 VA: 0x181F5B9C0
	public static Texture2D GenerateMaterialPreviewWithShader(Material material, PrimitiveType previewPrimitive, Shader shader, string replacementTag, int width = 64, int height = 64) { }

	// RVA: 0x1F5B670 Offset: 0x1F5A070 VA: 0x181F5B670
	public static void GenerateMaterialPreviewAsync(Action<Texture2D> callback, Material material, PrimitiveType previewPrimitive, int width = 64, int height = 64) { }

	// RVA: 0x1F5B920 Offset: 0x1F5A320 VA: 0x181F5B920
	public static void GenerateMaterialPreviewWithShaderAsync(Action<Texture2D> callback, Material material, PrimitiveType previewPrimitive, Shader shader, string replacementTag, int width = 64, int height = 64) { }

	// RVA: 0x1F5B700 Offset: 0x1F5A100 VA: 0x181F5B700
	private static Texture2D GenerateMaterialPreviewInternal(Material material, PrimitiveType previewPrimitive, Shader shader, string replacementTag, int width, int height, Action<Texture2D> asyncCallback) { }

	// RVA: 0x1F5CDC0 Offset: 0x1F5B7C0 VA: 0x181F5CDC0
	public static Texture2D GenerateModelPreview(Transform model, int width = 64, int height = 64, bool shouldCloneModel = False, bool shouldIgnoreParticleSystems = True) { }

	// RVA: 0x1F5CD10 Offset: 0x1F5B710 VA: 0x181F5CD10
	public static Texture2D GenerateModelPreviewWithShader(Transform model, Shader shader, string replacementTag, int width = 64, int height = 64, bool shouldCloneModel = False, bool shouldIgnoreParticleSystems = True) { }

	// RVA: 0x1F5BAF0 Offset: 0x1F5A4F0 VA: 0x181F5BAF0
	public static void GenerateModelPreviewAsync(Action<Texture2D> callback, Transform model, int width = 64, int height = 64, bool shouldCloneModel = False, bool shouldIgnoreParticleSystems = True) { }

	// RVA: 0x1F5CC60 Offset: 0x1F5B660 VA: 0x181F5CC60
	public static void GenerateModelPreviewWithShaderAsync(Action<Texture2D> callback, Transform model, Shader shader, string replacementTag, int width = 64, int height = 64, bool shouldCloneModel = False, bool shouldIgnoreParticleSystems = True) { }

	// RVA: 0x1F5BB90 Offset: 0x1F5A590 VA: 0x181F5BB90
	private static Texture2D GenerateModelPreviewInternal(Transform model, Shader shader, string replacementTag, int width, int height, bool shouldCloneModel, bool shouldIgnoreParticleSystems, Action<Texture2D> asyncCallback) { }

	// RVA: 0x1F59A60 Offset: 0x1F58460 VA: 0x181F59A60
	public static bool CalculateBounds(Transform target, bool shouldIgnoreParticleSystems, Quaternion cameraRotation, out Bounds bounds) { }

	// RVA: 0x1F5A280 Offset: 0x1F58C80 VA: 0x181F5A280
	public static void CalculateCameraPosition(Camera camera, Bounds bounds, float padding = 0) { }

	// RVA: 0x1F5D1C0 Offset: 0x1F5BBC0 VA: 0x181F5D1C0
	private static bool IsOutermostPointInDirection(int pointIndex, Vector3 direction) { }

	// RVA: 0x1F5CFB0 Offset: 0x1F5B9B0 VA: 0x181F5CFB0
	private static Ray GetPlanesIntersection(Plane p1, Plane p2) { }

	// RVA: 0x1F5B460 Offset: 0x1F59E60 VA: 0x181F5B460
	private static void FindClosestPointsOnTwoLines(Ray line1, Ray line2, out Vector3 closestPointLine1, out Vector3 closestPointLine2) { }

	// RVA: 0x1F5D650 Offset: 0x1F5C050 VA: 0x181F5D650
	private static void SetupCamera() { }

	// RVA: 0x1F5D3A0 Offset: 0x1F5BDA0 VA: 0x181F5D3A0
	private static bool IsStatic(Transform obj) { }

	// RVA: 0x1F5D590 Offset: 0x1F5BF90 VA: 0x181F5D590
	private static void SetLayerRecursively(Transform obj) { }

	// RVA: 0x1F5CE60 Offset: 0x1F5B860 VA: 0x181F5CE60
	private static void GetLayerRecursively(Transform obj) { }

	// RVA: 0x1F5D470 Offset: 0x1F5BE70 VA: 0x181F5D470
	private static void SetLayerRecursively(Transform obj, ref int index) { }

	// RVA: 0x1F5D980 Offset: 0x1F5C380 VA: 0x181F5D980
	private static void .cctor() { }
}
