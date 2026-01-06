public class VolumetricFog : MonoBehaviour // TypeDefIndex: 9220
{
	// Fields
	public VolumetricFogProfile profile; // 0x20
	[Tooltip("Supports Unity native lights including point and spot lights.")]
	public bool enableNativeLights; // 0x28
	[Tooltip("Multiplier to native lights intensity")]
	public float nativeLightsMultiplier; // 0x2C
	[Tooltip("Enable fast point lights. This option is much faster than native lights. However, if you enable native lights, this option can't be enabled as point lights are already included in the native lights support.")]
	public bool enablePointLights; // 0x30
	[Tooltip("Supports Adaptative Probe Volumes (Unity 2023.1+)")]
	public bool enableAPV; // 0x31
	[Tooltip("Multiplier to native lights intensity")]
	public float apvIntensityMultiplier; // 0x34
	public bool enableVoids; // 0x38
	[Tooltip("Makes this fog volume follow another object automatically")]
	public bool enableFollow; // 0x39
	public Transform followTarget; // 0x40
	public VolumetricFogFollowMode followMode; // 0x48
	public bool followIncludeDistantFog; // 0x4C
	public Vector3 followOffset; // 0x50
	[Tooltip("Fades in/out fog effect when reference controller enters the fog volume.")]
	public bool enableFade; // 0x5C
	[Tooltip("Fog volume blending starts when reference controller is within this fade distance to any volume border.")]
	public float fadeDistance; // 0x60
	[Tooltip("If this option is disabled, the fog disappears when the reference controller exits the volume and appears when the controller enters the volume. Enable this option to fade out the fog volume when the controller enters the volume. ")]
	public bool fadeOut; // 0x64
	[Tooltip("The controller (player or camera) to check if enters the fog volume.")]
	public Transform fadeController; // 0x68
	[Tooltip("Enable sub-volume blending.")]
	public bool enableSubVolumes; // 0x70
	[Tooltip("Allowed subVolumes. If no subvolumes are specified, any subvolume entered by this controller will affect this fog volume.")]
	public List<VolumetricFogSubVolume> subVolumes; // 0x78
	[Tooltip("Customize how this fog volume data is updated and animated")]
	public bool enableUpdateModeOptions; // 0x80
	public VolumetricFogUpdateMode updateMode; // 0x84
	[Tooltip("Camera used to compute visibility of this fog volume. If not set, the system will use the main camera.")]
	public Camera updateModeCamera; // 0x88
	public Bounds updateModeBounds; // 0x90
	[Tooltip("Shows the fog volume boundary in Game View")]
	public bool showBoundary; // 0xA8
	public MeshRenderer meshRenderer; // 0xB0
	private MeshFilter mf; // 0xB8
	private Material fogMat; // 0xC0
	private Material noiseMat; // 0xC8
	private Material turbulenceMat; // 0xD0
	private Shader fogShader; // 0xD8
	private RenderTexture rtNoise; // 0xE0
	private RenderTexture rtTurbulence; // 0xE8
	private float turbAcum; // 0xF0
	private Vector3 windAcum; // 0xF4
	private Vector3 detailNoiseWindAcum; // 0x100
	private Vector3 sunDir; // 0x10C
	private float dayLight; // 0x118
	private float moonLight; // 0x11C
	private List<string> shaderKeywords; // 0x120
	private string[] keywordsArray; // 0x128
	private Texture3D detailTex; // 0x130
	private Texture3D refDetailTex; // 0x138
	private Mesh debugMesh; // 0x140
	private Material fogDebugMat; // 0x148
	private VolumetricFogProfile activeProfile; // 0x150
	private VolumetricFogProfile lerpProfile; // 0x158
	private Vector3 lastControllerPosition; // 0x160
	private float alphaMultiplier; // 0x16C
	private Material distantFogMat; // 0x170
	private bool profileIsInstanced; // 0x178
	private bool requireUpdateMaterial; // 0x179
	private ColorSpace currentAppliedColorSpace; // 0x17C
	private static Texture2D blueNoiseTex; // 0x0
	private Color ambientMultiplied; // 0x180
	public bool forceTerrainCaptureUpdate; // 0x190
	public static readonly List<VolumetricFog> volumetricFogs; // 0x8
	private Bounds cameraFrustumBounds; // 0x194
	private static readonly Vector3[] frustumVertices; // 0x10
	private Vector3 cameraFrustumLastPosition; // 0x1AC
	private Quaternion cameraFrustumLastRotation; // 0x1B8
	public bool enableFogOfWar; // 0x1C8
	public Vector3 fogOfWarCenter; // 0x1CC
	public bool fogOfWarIsLocal; // 0x1D8
	public Vector3 fogOfWarSize; // 0x1DC
	public bool fogOfWarShowCoverage; // 0x1E8
	[Range(32, 2048)]
	public int fogOfWarTextureSize; // 0x1EC
	[Tooltip("Delay before the fog alpha is restored. A value of 0 keeps the fog cleared forever.")]
	[Range(0, 100)]
	public float fogOfWarRestoreDelay; // 0x1F0
	[Range(0, 25)]
	public float fogOfWarRestoreDuration; // 0x1F4
	[Range(0, 1)]
	public float fogOfWarSmoothness; // 0x1F8
	public bool fogOfWarBlur; // 0x1FC
	private const int MAX_SIMULTANEOUS_TRANSITIONS = 10000;
	private bool canDestroyFOWTexture; // 0x1FD
	public bool maskEditorEnabled; // 0x1FE
	public MASK_TEXTURE_BRUSH_MODE maskBrushMode; // 0x200
	public Color maskBrushColor; // 0x204
	[Range(1, 128)]
	public int maskBrushWidth; // 0x214
	[Range(0, 1)]
	public float maskBrushFuzziness; // 0x218
	[Range(0, 1)]
	public float maskBrushOpacity; // 0x21C
	[SerializeField]
	private Texture2D _fogOfWarTexture; // 0x220
	private Color32[] fogOfWarColorBuffer; // 0x228
	private VolumetricFog.FogOfWarTransition[] fowTransitionList; // 0x230
	private int lastTransitionPos; // 0x238
	private Dictionary<int, int> fowTransitionIndices; // 0x240
	private bool requiresTextureUpload; // 0x248
	private Material fowBlur; // 0x250
	private RenderTexture fowBlur1; // 0x258
	private RenderTexture fowBlur2; // 0x260
	private const string SURFACE_CAM_NAME = "SurfaceCam";
	private RenderTexture rt; // 0x268
	private Camera surfaceCam; // 0x270
	private Matrix4x4 camMatrix; // 0x278
	private Vector3 lastCamPos; // 0x2B8
	private LayerMask lastTerrainLayerMask; // 0x2C4
	private UniversalRendererData depthRendererData; // 0x2C8
	private static Matrix4x4 identityMatrix; // 0x18

	// Properties
	public VolumetricFogProfile settings { get; set; }
	public Material material { get; }
	public Vector3 anchoredFogOfWarCenter { get; }
	public Texture2D fogOfWarTexture { get; set; }
	public Color32[] fogOfWarTextureData { get; set; }

	// Methods

	// RVA: 0x2AA6960 Offset: 0x2AA5360 VA: 0x182AA6960
	public VolumetricFogProfile get_settings() { }

	// RVA: 0x2AA6DC0 Offset: 0x2AA57C0 VA: 0x182AA6DC0
	public void set_settings(VolumetricFogProfile value) { }

	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public Material get_material() { }

	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x2A9E400 Offset: 0x2A9CE00 VA: 0x182A9E400
	private static void Init() { }

	// RVA: 0x2AA04C0 Offset: 0x2A9EEC0 VA: 0x182AA04C0
	private void OnEnable() { }

	// RVA: 0x2AA00A0 Offset: 0x2A9EAA0 VA: 0x182AA00A0
	private void OnDisable() { }

	// RVA: 0x2AA0090 Offset: 0x2A9EA90 VA: 0x182AA0090
	private void OnDidApplyAnimationProperties() { }

	// RVA: 0x2AA0870 Offset: 0x2A9F270 VA: 0x182AA0870
	private void OnValidate() { }

	// RVA: 0x2A9FE20 Offset: 0x2A9E820 VA: 0x182A9FE20
	private void OnDestroy() { }

	// RVA: 0x2AA0210 Offset: 0x2A9EC10 VA: 0x182AA0210
	private void OnDrawGizmosSelected() { }

	// RVA: 0x2A9E490 Offset: 0x2A9CE90 VA: 0x182A9E490
	private void LateUpdate() { }

	// RVA: 0x2A9C950 Offset: 0x2A9B350 VA: 0x182A9C950
	private bool CanUpdate() { }

	// RVA: 0x2A9C2F0 Offset: 0x2A9ACF0 VA: 0x182A9C2F0
	private void CalculateFrustumBounds(Camera camera) { }

	// RVA: 0x2A9C5D0 Offset: 0x2A9AFD0 VA: 0x182A9C5D0
	private void CalculateFrustumVertices(Camera cam) { }

	// RVA: 0x2AA5CB0 Offset: 0x2AA46B0 VA: 0x182AA5CB0
	private void UpdateNoise() { }

	// RVA: 0x2AA0090 Offset: 0x2A9EA90 VA: 0x182AA0090
	public void UpdateMaterialProperties() { }

	// RVA: 0x2AA5C90 Offset: 0x2AA4690 VA: 0x182AA5C90
	public void UpdateMaterialProperties(bool forceTerrainCaptureUpdate) { }

	// RVA: 0x2AA5140 Offset: 0x2AA3B40 VA: 0x182AA5140
	public void UpdateMaterialPropertiesNow(bool skipTerrainCapture = False, bool forceTerrainCaptureUpdate = False) { }

	// RVA: 0x2A9D0F0 Offset: 0x2A9BAF0 VA: 0x182A9D0F0
	private void ComputeActiveProfile() { }

	// RVA: 0x2A9D8C0 Offset: 0x2A9C2C0 VA: 0x182A9D8C0
	private float ComputeVolumeFade(Transform transform, float fadeDistance) { }

	// RVA: 0x2A9ACF0 Offset: 0x2A996F0 VA: 0x182A9ACF0
	private void ApplyProfileSettings() { }

	// RVA: 0x2AA48E0 Offset: 0x2AA32E0 VA: 0x182AA48E0
	private void UpdateDistantFogPropertiesNow() { }

	// RVA: 0x2AA4B20 Offset: 0x2AA3520 VA: 0x182AA4B20
	private void UpdateFogOfWarMaterialBoundsProperties() { }

	// RVA: 0x2A9DD70 Offset: 0x2A9C770 VA: 0x182A9DD70
	public static void FindAlphaClippingObjects() { }

	// RVA: 0x2AA68B0 Offset: 0x2AA52B0 VA: 0x182AA68B0
	public Vector3 get_anchoredFogOfWarCenter() { }

	// RVA: 0x9CAEF0 Offset: 0x9C98F0 VA: 0x1809CAEF0
	public Texture2D get_fogOfWarTexture() { }

	// RVA: 0x2AA6B70 Offset: 0x2AA5570 VA: 0x182AA6B70
	public void set_fogOfWarTexture(Texture2D value) { }

	// RVA: 0x2A9DEA0 Offset: 0x2A9C8A0 VA: 0x182A9DEA0
	private void FogOfWarInit() { }

	// RVA: 0x2A9DDB0 Offset: 0x2A9C7B0 VA: 0x182A9DDB0
	private void FogOfWarDestroy() { }

	// RVA: 0x2AA0AA0 Offset: 0x2A9F4A0 VA: 0x182AA0AA0
	public void ReloadFogOfWarTexture() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void EnsureTextureIsReadable(Texture2D tex) { }

	// RVA: 0x2A9E020 Offset: 0x2A9CA20 VA: 0x182A9E020
	private void FogOfWarUpdateTexture() { }

	// RVA: 0x2A9E3D0 Offset: 0x2A9CDD0 VA: 0x182A9E3D0
	private int GetScaledSize(int size, float factor) { }

	// RVA: 0x2AA4D90 Offset: 0x2AA3790 VA: 0x182AA4D90
	public void UpdateFogOfWar(bool forceUpload = False) { }

	// RVA: 0x2AA3560 Offset: 0x2AA1F60 VA: 0x182AA3560
	private void SetFowBlurTexture() { }

	// RVA: 0x2A9DA40 Offset: 0x2A9C440 VA: 0x182A9DA40
	private void CreateFoWBlurRTs() { }

	// RVA: 0x2AA34F0 Offset: 0x2AA1EF0 VA: 0x182AA34F0
	public void SetFogOfWarAlpha(Vector3 worldPosition, float radius, float fogNewAlpha) { }

	// RVA: 0x2AA1B10 Offset: 0x2AA0510 VA: 0x182AA1B10
	public void SetFogOfWarAlpha(Vector3 worldPosition, float radius, float fogNewAlpha, float duration = 0) { }

	// RVA: 0x2AA23B0 Offset: 0x2AA0DB0 VA: 0x182AA23B0
	public void SetFogOfWarAlpha(Vector3 worldPosition, float radius, float fogNewAlpha, float duration = 0, float smoothness = 0) { }

	// RVA: 0x2AA2430 Offset: 0x2AA0E30 VA: 0x182AA2430
	public void SetFogOfWarAlpha(Vector3 worldPosition, float radius, float fogNewAlpha, bool blendAlpha = False, float duration = 0, float smoothness = 0, float restoreDelay = 0, float restoreDuration = 2, float restoreToAlphaValue = 1) { }

	// RVA: 0x2AA1B90 Offset: 0x2AA0590 VA: 0x182AA1B90
	public void SetFogOfWarAlpha(Bounds bounds, float fogNewAlpha, float duration = 0) { }

	// RVA: 0x2AA14E0 Offset: 0x2A9FEE0 VA: 0x182AA14E0
	public void SetFogOfWarAlpha(Bounds bounds, float fogNewAlpha, float duration, float smoothness) { }

	// RVA: 0x2AA1550 Offset: 0x2A9FF50 VA: 0x182AA1550
	public void SetFogOfWarAlpha(Bounds bounds, float fogNewAlpha, bool blendAlpha, float duration = 0, float smoothness = 0, float restoreDelay = 0, float restoreDuration = 2, float restoreToAlpha = 1) { }

	// RVA: 0x2AA1C00 Offset: 0x2AA0600 VA: 0x182AA1C00
	public void SetFogOfWarAlpha(Collider collider, float fogNewAlpha, bool blendAlpha = False, float duration = 0, float smoothness = 0, float restoreDelay = 0, float restoreDuration = 2, float restoreToAlpha = 1) { }

	// RVA: 0x2AA2950 Offset: 0x2AA1350 VA: 0x182AA2950
	public void SetFogOfWarAlpha(GameObject go, float fogNewAlpha, float duration = 0, float restoreDelay = 0, float restoreDuration = 2, float restoreToAlpha = 1) { }

	// RVA: 0x2AA3ED0 Offset: 0x2AA28D0 VA: 0x182AA3ED0
	private float Sign(float p1x, float p1z, float p2x, float p2z, float p3x, float p3z) { }

	// RVA: 0x2AA0980 Offset: 0x2A9F380 VA: 0x182AA0980
	private bool PointInTriangle(float x, float z, float v1x, float v1z, float v2x, float v2z, float v3x, float v3z) { }

	// RVA: 0x2AA0C40 Offset: 0x2A9F640 VA: 0x182AA0C40
	public void ResetFogOfWarAlpha(Vector3 worldPosition, float radius, float alpha = 1) { }

	// RVA: 0x2AA12C0 Offset: 0x2A9FCC0 VA: 0x182AA12C0
	public void ResetFogOfWarAlpha(Bounds bounds, float alpha = 1) { }

	// RVA: 0x2AA0BE0 Offset: 0x2A9F5E0 VA: 0x182AA0BE0
	public void ResetFogOfWarAlpha(Vector3 position, Vector3 size, float alpha = 1) { }

	// RVA: 0x2AA0F90 Offset: 0x2A9F990 VA: 0x182AA0F90
	public void ResetFogOfWarAlpha(Vector3 position, float extentsX, float extentsZ, float alpha = 1) { }

	// RVA: 0x2AA1300 Offset: 0x2A9FD00 VA: 0x182AA1300
	public void ResetFogOfWar(float alpha = 1) { }

	// RVA: 0x76CFB0 Offset: 0x76B9B0 VA: 0x18076CFB0
	public Color32[] get_fogOfWarTextureData() { }

	// RVA: 0x2AA6A50 Offset: 0x2AA5450 VA: 0x182AA6A50
	public void set_fogOfWarTextureData(Color32[] value) { }

	// RVA: 0x2A9A8D0 Offset: 0x2A992D0 VA: 0x182A9A8D0
	private void AddFogOfWarTransitionSlot(int x, int y, byte initialAlpha, byte targetAlpha, float delay, float duration, byte restoreToAlpha, float restoreDelay, float restoreDuration) { }

	// RVA: 0x2A9E210 Offset: 0x2A9CC10 VA: 0x182A9E210
	public float GetFogOfWarAlpha(Vector3 worldPosition) { }

	// RVA: 0x2A9DCD0 Offset: 0x2A9C6D0 VA: 0x182A9DCD0
	private void DisposeSurfaceCapture() { }

	// RVA: 0x2A9CF90 Offset: 0x2A9B990 VA: 0x182A9CF90
	private void CheckSurfaceCapture() { }

	// RVA: 0x2AA3F00 Offset: 0x2AA2900 VA: 0x182AA3F00
	private void SurfaceCaptureSupportCheck() { }

	// RVA: 0x2A9CCA0 Offset: 0x2A9B6A0 VA: 0x182A9CCA0
	private void CheckAndAssignDepthRenderer(UniversalAdditionalCameraData camData) { }

	// RVA: 0x2AA08A0 Offset: 0x2A9F2A0 VA: 0x182AA08A0
	public void PerformHeightmapCapture() { }

	// RVA: 0x2AA3890 Offset: 0x2AA2290 VA: 0x182AA3890
	private void SetupCameraCaptureMatrix() { }

	// RVA: 0x2AA4760 Offset: 0x2AA3160 VA: 0x182AA4760
	private void SurfaceCaptureUpdate() { }

	// RVA: 0x2A9D620 Offset: 0x2A9C020 VA: 0x182A9D620
	private void ComputeSufaceTransform(Matrix4x4 proj, Matrix4x4 view) { }

	// RVA: 0x2AA6720 Offset: 0x2AA5120 VA: 0x182AA6720
	public void .ctor() { }

	// RVA: 0x2AA65F0 Offset: 0x2AA4FF0 VA: 0x182AA65F0
	private static void .cctor() { }
}
