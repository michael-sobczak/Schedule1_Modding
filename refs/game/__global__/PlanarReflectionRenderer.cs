public class PlanarReflectionRenderer : MonoBehaviour // TypeDefIndex: 18264
{
	// Fields
	public static List<PlanarReflectionRenderer> Instances; // 0x0
	public Dictionary<Camera, Camera> reflectionCameras; // 0x20
	[Tooltip("If enabled, the reflection plane will be based on this transform's up vector (green arrow).

Otherwise the world's upwards direction is assumed")]
	public bool rotatable; // 0x28
	[Tooltip("Set the layers that should be rendered into the reflection. The "Water" layer is always excluded")]
	public LayerMask cullingMask; // 0x2C
	[Tooltip("The renderer used by the reflection camera. It's recommend to create a separate renderer, so any custom render features aren't executed for the reflection")]
	public int rendererIndex; // 0x30
	[Min(0)]
	public float offset; // 0x34
	[Tooltip("When disabled, the skybox reflection comes from a Reflection Probe. This has the benefit of being omni-directional rather than flat/planar. Enabled this to render the skybox into the planar reflection anyway.

Note that enabling this will override Screen Space Reflections completely!")]
	public bool includeSkybox; // 0x38
	[Tooltip("Render Unity's default scene fog in the reflection. Note that this doesn't strictly work correctly on large triangles, as it is incompatible with oblique camera projections.

This does not include to post-processing fog effects!")]
	public bool enableFog; // 0x39
	public bool renderShadows; // 0x3A
	[Tooltip("Objects beyond this range aren't rendered into the reflection. Note that this may causes popping for large/tall objects.")]
	public float renderRange; // 0x3C
	[Tooltip("A multiplier for the rendering resolution, based on the current screen resolution. The render scale, as configured in the pipeline settings is multiplied over this.")]
	[Range(0.25, 1)]
	public float renderScale; // 0x40
	[Tooltip("Do not render LOD objects lower than this value. Example: With a value of 1, LOD0 for LOD Groups will not be used")]
	[Range(0, 4)]
	public int maximumLODLevel; // 0x44
	[SerializeField]
	public List<WaterObject> waterObjects; // 0x48
	[Tooltip("If enabled, the center of the rendering bounds (that wraps around the water objects) moves with the Transform position

You must however ensure you are only moving on the XZ axis")]
	public bool moveWithTransform; // 0x50
	[HideInInspector]
	public Bounds bounds; // 0x54
	private float m_renderScale; // 0x6C
	private float m_renderRange; // 0x70
	[CompilerGenerated]
	private static bool <AllowReflections>k__BackingField; // 0x8
	private static readonly int _PlanarReflectionsEnabledID; // 0xC
	private static readonly int _PlanarReflectionID; // 0x10
	public bool isRendering; // 0x74
	private Camera m_reflectionCamera; // 0x78
	private static UniversalAdditionalCameraData m_cameraData; // 0x18
	private static readonly Plane[] frustrumPlanes; // 0x20
	private static Vector4 reflectionPlane; // 0x28
	private static Matrix4x4 reflectionBase; // 0x38
	private static Vector3 oldCamPos; // 0x78
	private static Matrix4x4 worldToCamera; // 0x84
	private static Matrix4x4 viewMatrix; // 0xC4
	private static Matrix4x4 projectionMatrix; // 0x104
	private static Vector4 clipPlane; // 0x144
	private static readonly float[] layerCullDistances; // 0x158

	// Properties
	public static bool AllowReflections { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F6EC90 Offset: 0x1F6D690 VA: 0x181F6EC90
	public static bool get_AllowReflections() { }

	[CompilerGenerated]
	// RVA: 0x1F6ECE0 Offset: 0x1F6D6E0 VA: 0x181F6ECE0
	private static void set_AllowReflections(bool value) { }

	// RVA: 0x1F6D190 Offset: 0x1F6BB90 VA: 0x181F6D190
	private void Reset() { }

	// RVA: 0x1F6C7C0 Offset: 0x1F6B1C0 VA: 0x181F6C7C0
	private void OnEnable() { }

	// RVA: 0x1F6C670 Offset: 0x1F6B070 VA: 0x181F6C670
	private void OnDisable() { }

	// RVA: 0x1F6C5F0 Offset: 0x1F6AFF0 VA: 0x181F6C5F0
	public void InitializeValues() { }

	// RVA: 0x1F6B3B0 Offset: 0x1F69DB0 VA: 0x181F6B3B0
	public void ApplyToAllWaterInstances() { }

	// RVA: 0x1F6D200 Offset: 0x1F6BC00 VA: 0x181F6D200
	public static void SetQuality(bool enableReflections, float renderScale = -1, float renderRange = -1, int maxLodLevel = -1) { }

	// RVA: 0x1F6C450 Offset: 0x1F6AE50 VA: 0x181F6C450
	public void EnableReflections() { }

	// RVA: 0x1F6C120 Offset: 0x1F6AB20 VA: 0x181F6C120
	public void DisableReflections() { }

	// RVA: 0x1F6C700 Offset: 0x1F6B100 VA: 0x181F6C700
	private void OnDrawGizmosSelected() { }

	// RVA: 0x1F6B500 Offset: 0x1F69F00 VA: 0x181F6B500
	public Bounds CalculateBounds() { }

	// RVA: 0x1F6CFD0 Offset: 0x1F6B9D0 VA: 0x181F6CFD0
	public void RecalculateBounds() { }

	// RVA: 0x1F6C600 Offset: 0x1F6B000 VA: 0x181F6C600
	public static bool InvalidContext(Camera camera) { }

	// RVA: 0x1F6C8B0 Offset: 0x1F6B2B0 VA: 0x181F6C8B0
	private void OnWillRenderCamera(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x1F6D130 Offset: 0x1F6BB30 VA: 0x181F6D130
	private void RenderReflection(ScriptableRenderContext context, Camera target) { }

	// RVA: 0x1F6D1F0 Offset: 0x1F6BBF0 VA: 0x181F6D1F0
	private void SetFogState(bool value) { }

	// RVA: 0x1F6C560 Offset: 0x1F6AF60 VA: 0x181F6C560
	private float GetRenderScale() { }

	// RVA: 0x1F6D420 Offset: 0x1F6BE20 VA: 0x181F6D420
	public void SetRendererIndex(int index) { }

	// RVA: 0x1F6D830 Offset: 0x1F6C230 VA: 0x181F6D830
	public void ToggleShadows(bool state) { }

	// RVA: 0x1F6B230 Offset: 0x1F69C30 VA: 0x181F6B230
	public void AddWaterObject(WaterObject waterObject) { }

	// RVA: 0x1F6D000 Offset: 0x1F6BA00 VA: 0x181F6D000
	public void RemoveWaterObject(WaterObject waterObject) { }

	// RVA: 0x1F6C3C0 Offset: 0x1F6ADC0 VA: 0x181F6C3C0
	public void EnableMaterialReflectionSampling() { }

	// RVA: 0x1F6D650 Offset: 0x1F6C050 VA: 0x181F6D650
	public void ToggleMaterialReflectionSampling(bool state) { }

	// RVA: 0x1F6D750 Offset: 0x1F6C150 VA: 0x181F6D750
	private void ToggleMaterialReflectionSampling(WaterObject waterObject, bool state) { }

	// RVA: 0x1F6BBF0 Offset: 0x1F6A5F0 VA: 0x181F6BBF0
	private void CreateReflectionCamera(Camera source) { }

	// RVA: 0x1F6BE50 Offset: 0x1F6A850 VA: 0x181F6BE50
	private void CreateRenderTexture(Camera targetCamera, Camera source) { }

	// RVA: 0x1F6E840 Offset: 0x1F6D240 VA: 0x181F6E840
	public bool WaterObjectsVisible(Camera targetCamera) { }

	// RVA: 0x1F6E6A0 Offset: 0x1F6D0A0 VA: 0x181F6E6A0
	private void UpdateWaterProperties(Camera cam) { }

	// RVA: 0x1F6DB20 Offset: 0x1F6C520 VA: 0x181F6DB20
	private void UpdateCameraProperties(Camera source, Camera reflectionCam) { }

	// RVA: 0x1F6DBA0 Offset: 0x1F6C5A0 VA: 0x181F6DBA0
	private void UpdatePerspective(Camera source, Camera reflectionCam) { }

	// RVA: 0x1F6B960 Offset: 0x1F6A360 VA: 0x181F6B960
	private void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane) { }

	// RVA: 0x1F6BA90 Offset: 0x1F6A490 VA: 0x181F6BA90
	private Vector4 CameraSpacePlane(Matrix4x4 worldToCameraMatrix, Vector3 pos, Vector3 normal, float sideSign) { }

	// RVA: 0x1F6DA50 Offset: 0x1F6C450 VA: 0x181F6DA50
	public RenderTexture TryGetReflectionTexture(Camera targetCamera) { }

	// RVA: 0x1F6EBA0 Offset: 0x1F6D5A0 VA: 0x181F6EBA0
	public void .ctor() { }

	// RVA: 0x1F6EA10 Offset: 0x1F6D410 VA: 0x181F6EA10
	private static void .cctor() { }
}
