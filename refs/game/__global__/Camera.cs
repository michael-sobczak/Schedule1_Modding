public sealed class Camera : Behaviour // TypeDefIndex: 11604
{
	// Fields
	public const float kMinAperture = 0.7;
	public const float kMaxAperture = 32;
	public const int kMinBladeCount = 3;
	public const int kMaxBladeCount = 11;
	public static Camera.CameraCallback onPreCull; // 0x0
	public static Camera.CameraCallback onPreRender; // 0x8
	public static Camera.CameraCallback onPostRender; // 0x10

	// Properties
	[NativeProperty("Near")]
	public float nearClipPlane { get; set; }
	[NativeProperty("Far")]
	public float farClipPlane { get; set; }
	[NativeProperty("VerticalFieldOfView")]
	public float fieldOfView { get; set; }
	public RenderingPath renderingPath { set; }
	public RenderingPath actualRenderingPath { get; }
	public bool allowHDR { get; set; }
	public bool allowMSAA { get; set; }
	public bool allowDynamicResolution { get; }
	[NativeProperty("ForceIntoRT")]
	public bool forceIntoRenderTexture { set; }
	public float orthographicSize { get; set; }
	public bool orthographic { get; set; }
	public OpaqueSortMode opaqueSortMode { get; }
	public float depth { get; set; }
	public float aspect { get; set; }
	public int cullingMask { get; set; }
	public int eventMask { get; }
	public bool layerCullSpherical { set; }
	public CameraType cameraType { get; set; }
	public float[] layerCullDistances { set; }
	public bool useOcclusionCulling { set; }
	public Color backgroundColor { get; set; }
	public CameraClearFlags clearFlags { get; set; }
	public DepthTextureMode depthTextureMode { get; set; }
	public bool usePhysicalProperties { get; set; }
	public float focusDistance { get; set; }
	public float focalLength { set; }
	public Vector2 sensorSize { get; set; }
	public Vector2 lensShift { get; set; }
	public Camera.GateFitMode gateFit { get; set; }
	[NativeProperty("NormalizedViewportRect")]
	public Rect rect { get; set; }
	[NativeProperty("ScreenViewportRect")]
	public Rect pixelRect { get; set; }
	public int pixelWidth { get; }
	public int pixelHeight { get; }
	public int scaledPixelWidth { get; }
	public int scaledPixelHeight { get; }
	public RenderTexture targetTexture { get; set; }
	public RenderTexture activeTexture { get; }
	public int targetDisplay { get; }
	public Matrix4x4 cameraToWorldMatrix { get; }
	public Matrix4x4 worldToCameraMatrix { get; set; }
	public Matrix4x4 projectionMatrix { get; set; }
	public Matrix4x4 nonJitteredProjectionMatrix { set; }
	[NativeProperty("UseJitteredProjectionMatrixForTransparent")]
	public bool useJitteredProjectionMatrixForTransparentRendering { set; }
	public static Camera main { get; }
	public static Camera current { get; }
	public bool stereoEnabled { get; }
	public StereoTargetEyeMask stereoTargetEye { get; set; }
	public Camera.MonoOrStereoscopicEye stereoActiveEye { get; }
	public static int allCamerasCount { get; }
	public static Camera[] allCameras { get; }
	[NativeConditional("UNITY_EDITOR")]
	public Camera.SceneViewFilterMode sceneViewFilterMode { get; }

	// Methods

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2C837B0 Offset: 0x2C821B0 VA: 0x182C837B0
	public float get_nearClipPlane() { }

	// RVA: 0x2C844A0 Offset: 0x2C82EA0 VA: 0x182C844A0
	public void set_nearClipPlane(float value) { }

	// RVA: 0x2C835E0 Offset: 0x2C81FE0 VA: 0x182C835E0
	public float get_farClipPlane() { }

	// RVA: 0x2C84150 Offset: 0x2C82B50 VA: 0x182C84150
	public void set_farClipPlane(float value) { }

	// RVA: 0x2C83620 Offset: 0x2C82020 VA: 0x182C83620
	public float get_fieldOfView() { }

	// RVA: 0x2C841A0 Offset: 0x2C82BA0 VA: 0x182C841A0
	public void set_fieldOfView(float value) { }

	// RVA: 0x2C84810 Offset: 0x2C83210 VA: 0x182C84810
	public void set_renderingPath(RenderingPath value) { }

	[NativeName("CalculateRenderingPath")]
	// RVA: 0x2C83110 Offset: 0x2C81B10 VA: 0x182C83110
	public RenderingPath get_actualRenderingPath() { }

	// RVA: 0x2C83220 Offset: 0x2C81C20 VA: 0x182C83220
	public bool get_allowHDR() { }

	// RVA: 0x2C83E70 Offset: 0x2C82870 VA: 0x182C83E70
	public void set_allowHDR(bool value) { }

	// RVA: 0x2C83260 Offset: 0x2C81C60 VA: 0x182C83260
	public bool get_allowMSAA() { }

	// RVA: 0x2C83EC0 Offset: 0x2C828C0 VA: 0x182C83EC0
	public void set_allowMSAA(bool value) { }

	// RVA: 0x2C831E0 Offset: 0x2C81BE0 VA: 0x182C831E0
	public bool get_allowDynamicResolution() { }

	// RVA: 0x2C84290 Offset: 0x2C82C90 VA: 0x182C84290
	public void set_forceIntoRenderTexture(bool value) { }

	// RVA: 0x2C83830 Offset: 0x2C82230 VA: 0x182C83830
	public float get_orthographicSize() { }

	// RVA: 0x2C84590 Offset: 0x2C82F90 VA: 0x182C84590
	public void set_orthographicSize(float value) { }

	// RVA: 0x2C83870 Offset: 0x2C82270 VA: 0x182C83870
	public bool get_orthographic() { }

	// RVA: 0x2C845E0 Offset: 0x2C82FE0 VA: 0x182C845E0
	public void set_orthographic(bool value) { }

	// RVA: 0x2C837F0 Offset: 0x2C821F0 VA: 0x182C837F0
	public OpaqueSortMode get_opaqueSortMode() { }

	// RVA: 0x2C83560 Offset: 0x2C81F60 VA: 0x182C83560
	public float get_depth() { }

	// RVA: 0x2C84100 Offset: 0x2C82B00 VA: 0x182C84100
	public void set_depth(float value) { }

	// RVA: 0x2C832A0 Offset: 0x2C81CA0 VA: 0x182C832A0
	public float get_aspect() { }

	// RVA: 0x2C83F10 Offset: 0x2C82910 VA: 0x182C83F10
	public void set_aspect(float value) { }

	// RVA: 0x2C834B0 Offset: 0x2C81EB0 VA: 0x182C834B0
	public int get_cullingMask() { }

	// RVA: 0x2C84080 Offset: 0x2C82A80 VA: 0x182C84080
	public void set_cullingMask(int value) { }

	// RVA: 0x2C835A0 Offset: 0x2C81FA0 VA: 0x182C835A0
	public int get_eventMask() { }

	// RVA: 0x2C843C0 Offset: 0x2C82DC0 VA: 0x182C843C0
	public void set_layerCullSpherical(bool value) { }

	// RVA: 0x2C83430 Offset: 0x2C81E30 VA: 0x182C83430
	public CameraType get_cameraType() { }

	// RVA: 0x2C84000 Offset: 0x2C82A00 VA: 0x182C84000
	public void set_cameraType(CameraType value) { }

	[FreeFunction("CameraScripting::SetLayerCullDistances", HasExplicitThis = True)]
	// RVA: 0x2C82810 Offset: 0x2C81210 VA: 0x182C82810
	private void SetLayerCullDistances(float[] d) { }

	// RVA: 0x2C84320 Offset: 0x2C82D20 VA: 0x182C84320
	public void set_layerCullDistances(float[] value) { }

	// RVA: 0x2C849C0 Offset: 0x2C833C0 VA: 0x182C849C0
	public void set_useOcclusionCulling(bool value) { }

	// RVA: 0x2C83330 Offset: 0x2C81D30 VA: 0x182C83330
	public Color get_backgroundColor() { }

	// RVA: 0x2C83FB0 Offset: 0x2C829B0 VA: 0x182C83FB0
	public void set_backgroundColor(Color value) { }

	// RVA: 0x2C83470 Offset: 0x2C81E70 VA: 0x182C83470
	public CameraClearFlags get_clearFlags() { }

	// RVA: 0x2C84040 Offset: 0x2C82A40 VA: 0x182C84040
	public void set_clearFlags(CameraClearFlags value) { }

	// RVA: 0x2C83520 Offset: 0x2C81F20 VA: 0x182C83520
	public DepthTextureMode get_depthTextureMode() { }

	// RVA: 0x2C840C0 Offset: 0x2C82AC0 VA: 0x182C840C0
	public void set_depthTextureMode(DepthTextureMode value) { }

	// RVA: 0x2C83D80 Offset: 0x2C82780 VA: 0x182C83D80
	public bool get_usePhysicalProperties() { }

	// RVA: 0x2C84A10 Offset: 0x2C83410 VA: 0x182C84A10
	public void set_usePhysicalProperties(bool value) { }

	// RVA: 0x2C83660 Offset: 0x2C82060 VA: 0x182C83660
	public float get_focusDistance() { }

	// RVA: 0x2C84240 Offset: 0x2C82C40 VA: 0x182C84240
	public void set_focusDistance(float value) { }

	// RVA: 0x2C841F0 Offset: 0x2C82BF0 VA: 0x182C841F0
	public void set_focalLength(float value) { }

	// RVA: 0x2C83BF0 Offset: 0x2C825F0 VA: 0x182C83BF0
	public Vector2 get_sensorSize() { }

	// RVA: 0x2C848A0 Offset: 0x2C832A0 VA: 0x182C848A0
	public void set_sensorSize(Vector2 value) { }

	// RVA: 0x2C83730 Offset: 0x2C82130 VA: 0x182C83730
	public Vector2 get_lensShift() { }

	// RVA: 0x2C84460 Offset: 0x2C82E60 VA: 0x182C84460
	public void set_lensShift(Vector2 value) { }

	// RVA: 0x2C836A0 Offset: 0x2C820A0 VA: 0x182C836A0
	public Camera.GateFitMode get_gateFit() { }

	// RVA: 0x2C842E0 Offset: 0x2C82CE0 VA: 0x182C842E0
	public void set_gateFit(Camera.GateFitMode value) { }

	// RVA: 0x2C83AD0 Offset: 0x2C824D0 VA: 0x182C83AD0
	public Rect get_rect() { }

	// RVA: 0x2C847C0 Offset: 0x2C831C0 VA: 0x182C847C0
	public void set_rect(Rect value) { }

	// RVA: 0x2C83940 Offset: 0x2C82340 VA: 0x182C83940
	public Rect get_pixelRect() { }

	// RVA: 0x2C84680 Offset: 0x2C83080 VA: 0x182C84680
	public void set_pixelRect(Rect value) { }

	[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
	// RVA: 0x2C83990 Offset: 0x2C82390 VA: 0x182C83990
	public int get_pixelWidth() { }

	[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
	// RVA: 0x2C838B0 Offset: 0x2C822B0 VA: 0x182C838B0
	public int get_pixelHeight() { }

	[FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = True)]
	// RVA: 0x2C83B60 Offset: 0x2C82560 VA: 0x182C83B60
	public int get_scaledPixelWidth() { }

	[FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = True)]
	// RVA: 0x2C83B20 Offset: 0x2C82520 VA: 0x182C83B20
	public int get_scaledPixelHeight() { }

	// RVA: 0x2C83D40 Offset: 0x2C82740 VA: 0x182C83D40
	public RenderTexture get_targetTexture() { }

	// RVA: 0x2C84920 Offset: 0x2C83320 VA: 0x182C84920
	public void set_targetTexture(RenderTexture value) { }

	[NativeName("GetCurrentTargetTexture")]
	// RVA: 0x2C830D0 Offset: 0x2C81AD0 VA: 0x182C830D0
	public RenderTexture get_activeTexture() { }

	// RVA: 0x2C83D00 Offset: 0x2C82700 VA: 0x182C83D00
	public int get_targetDisplay() { }

	// RVA: 0x2C833D0 Offset: 0x2C81DD0 VA: 0x182C833D0
	public Matrix4x4 get_cameraToWorldMatrix() { }

	// RVA: 0x2C83E10 Offset: 0x2C82810 VA: 0x182C83E10
	public Matrix4x4 get_worldToCameraMatrix() { }

	// RVA: 0x2C84AB0 Offset: 0x2C834B0 VA: 0x182C84AB0
	public void set_worldToCameraMatrix(Matrix4x4 value) { }

	// RVA: 0x2C83A20 Offset: 0x2C82420 VA: 0x182C83A20
	public Matrix4x4 get_projectionMatrix() { }

	// RVA: 0x2C84720 Offset: 0x2C83120 VA: 0x182C84720
	public void set_projectionMatrix(Matrix4x4 value) { }

	// RVA: 0x2C84540 Offset: 0x2C82F40 VA: 0x182C84540
	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	// RVA: 0x2C84970 Offset: 0x2C83370 VA: 0x182C84970
	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	// RVA: 0x2C82360 Offset: 0x2C80D60 VA: 0x182C82360
	public void ResetWorldToCameraMatrix() { }

	// RVA: 0x2C822E0 Offset: 0x2C80CE0 VA: 0x182C822E0
	public void ResetProjectionMatrix() { }

	[FreeFunction("CameraScripting::CalculateObliqueMatrix", HasExplicitThis = True)]
	// RVA: 0x2C81AC0 Offset: 0x2C804C0 VA: 0x182C81AC0
	public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane) { }

	// RVA: 0x2C82EF0 Offset: 0x2C818F0 VA: 0x182C82EF0
	public Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2C83060 Offset: 0x2C81A60 VA: 0x182C83060
	public Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2C82D80 Offset: 0x2C81780 VA: 0x182C82D80
	public Vector3 ViewportToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2C82710 Offset: 0x2C81110 VA: 0x182C82710
	public Vector3 ScreenToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2C82E60 Offset: 0x2C81860 VA: 0x182C82E60
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0x2C82FD0 Offset: 0x2C819D0 VA: 0x182C82FD0
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	// RVA: 0x2C82CF0 Offset: 0x2C816F0 VA: 0x182C82CF0
	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	// RVA: 0x2C82780 Offset: 0x2C81180 VA: 0x182C82780
	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	// RVA: 0x2C82640 Offset: 0x2C81040 VA: 0x182C82640
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0x2C82AB0 Offset: 0x2C814B0 VA: 0x182C82AB0
	private Ray ViewportPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2C82BD0 Offset: 0x2C815D0 VA: 0x182C82BD0
	public Ray ViewportPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2C82B20 Offset: 0x2C81520 VA: 0x182C82B20
	public Ray ViewportPointToRay(Vector3 pos) { }

	// RVA: 0x2C82570 Offset: 0x2C80F70 VA: 0x182C82570
	private Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2C824C0 Offset: 0x2C80EC0 VA: 0x182C824C0
	public Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2C82410 Offset: 0x2C80E10 VA: 0x182C82410
	public Ray ScreenPointToRay(Vector3 pos) { }

	[NativeName("FieldOfViewToFocalLength_Safe")]
	// RVA: 0x2C81BC0 Offset: 0x2C805C0 VA: 0x182C81BC0
	public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize) { }

	[FreeFunction("FindMainCamera")]
	// RVA: 0x2C83780 Offset: 0x2C82180 VA: 0x182C83780
	public static Camera get_main() { }

	[FreeFunction("GetCurrentCameraPPtr")]
	// RVA: 0x2C834F0 Offset: 0x2C81EF0 VA: 0x182C834F0
	public static Camera get_current() { }

	[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
	// RVA: 0x2C83C80 Offset: 0x2C82680 VA: 0x182C83C80
	public bool get_stereoEnabled() { }

	// RVA: 0x2C83CC0 Offset: 0x2C826C0 VA: 0x182C83CC0
	public StereoTargetEyeMask get_stereoTargetEye() { }

	// RVA: 0x2C848E0 Offset: 0x2C832E0 VA: 0x182C848E0
	public void set_stereoTargetEye(StereoTargetEyeMask value) { }

	[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = True)]
	// RVA: 0x2C83C40 Offset: 0x2C82640 VA: 0x182C83C40
	public Camera.MonoOrStereoscopicEye get_stereoActiveEye() { }

	// RVA: 0x2C81F80 Offset: 0x2C80980 VA: 0x182C81F80
	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x2C81B80 Offset: 0x2C80580 VA: 0x182C81B80
	public void CopyStereoDeviceProjectionMatrixToNonJittered(Camera.StereoscopicEye eye) { }

	[FreeFunction("CameraScripting::GetStereoProjectionMatrix", HasExplicitThis = True)]
	// RVA: 0x2C82040 Offset: 0x2C80A40 VA: 0x182C82040
	public Matrix4x4 GetStereoProjectionMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x2C828B0 Offset: 0x2C812B0 VA: 0x182C828B0
	public void SetStereoProjectionMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x2C82320 Offset: 0x2C80D20 VA: 0x182C82320
	public void ResetStereoProjectionMatrices() { }

	// RVA: 0x2C82950 Offset: 0x2C81350 VA: 0x182C82950
	public void SetStereoViewMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix) { }

	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	// RVA: 0x2C81D30 Offset: 0x2C80730 VA: 0x182C81D30
	private static int GetAllCamerasCount() { }

	[FreeFunction("CameraScripting::GetAllCameras")]
	// RVA: 0x2C81D60 Offset: 0x2C80760 VA: 0x182C81D60
	private static int GetAllCamerasImpl([Out] Camera[] cam) { }

	// RVA: 0x2C81D30 Offset: 0x2C80730 VA: 0x182C81D30
	public static int get_allCamerasCount() { }

	// RVA: 0x2C83150 Offset: 0x2C81B50 VA: 0x182C83150
	public static Camera[] get_allCameras() { }

	// RVA: 0x2C81DA0 Offset: 0x2C807A0 VA: 0x182C81DA0
	public static int GetAllCameras(Camera[] cameras) { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x2C81EF0 Offset: 0x2C808F0 VA: 0x182C81EF0
	private int GetFilterMode() { }

	// RVA: 0x2C81EF0 Offset: 0x2C808F0 VA: 0x182C81EF0
	public Camera.SceneViewFilterMode get_sceneViewFilterMode() { }

	[FreeFunction("CameraScripting::Render", HasExplicitThis = True)]
	// RVA: 0x2C822A0 Offset: 0x2C80CA0 VA: 0x182C822A0
	public void Render() { }

	[FreeFunction("CameraScripting::RenderWithShader", HasExplicitThis = True)]
	// RVA: 0x2C82240 Offset: 0x2C80C40 VA: 0x182C82240
	public void RenderWithShader(Shader shader, string replacementTag) { }

	[FreeFunction("CameraScripting::SetupCurrent")]
	// RVA: 0x2C829A0 Offset: 0x2C813A0 VA: 0x182C829A0
	public static void SetupCurrent(Camera cur) { }

	[FreeFunction("CameraScripting::CopyFrom", HasExplicitThis = True)]
	// RVA: 0x2C81B30 Offset: 0x2C80530 VA: 0x182C81B30
	public void CopyFrom(Camera other) { }

	[NativeName("AddCommandBuffer")]
	// RVA: 0x2C818D0 Offset: 0x2C802D0 VA: 0x182C818D0
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	[NativeName("RemoveCommandBuffer")]
	// RVA: 0x2C820B0 Offset: 0x2C80AB0 VA: 0x182C820B0
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x2C81920 Offset: 0x2C80320 VA: 0x182C81920
	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x2C82100 Offset: 0x2C80B00 VA: 0x182C82100
	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[RequiredByNativeCode]
	// RVA: 0x2C81C70 Offset: 0x2C80670 VA: 0x182C81C70
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCode]
	// RVA: 0x2C81CD0 Offset: 0x2C806D0 VA: 0x182C81CD0
	private static void FireOnPreRender(Camera cam) { }

	[RequiredByNativeCode]
	// RVA: 0x2C81C10 Offset: 0x2C80610 VA: 0x182C81C10
	private static void FireOnPostRender(Camera cam) { }

	// RVA: 0x2C829E0 Offset: 0x2C813E0 VA: 0x182C829E0
	public bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters) { }

	[FreeFunction("ScriptableRenderPipeline_Bindings::GetCullingParameters_Internal")]
	[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
	// RVA: 0x2C81E80 Offset: 0x2C80880 VA: 0x182C81E80
	private static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

	// RVA: 0x2C832E0 Offset: 0x2C81CE0 VA: 0x182C832E0
	private void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x2C83F60 Offset: 0x2C82960 VA: 0x182C83F60
	private void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x2C83BA0 Offset: 0x2C825A0 VA: 0x182C83BA0
	private void get_sensorSize_Injected(out Vector2 ret) { }

	// RVA: 0x2C84850 Offset: 0x2C83250 VA: 0x182C84850
	private void set_sensorSize_Injected(ref Vector2 value) { }

	// RVA: 0x2C836E0 Offset: 0x2C820E0 VA: 0x182C836E0
	private void get_lensShift_Injected(out Vector2 ret) { }

	// RVA: 0x2C84410 Offset: 0x2C82E10 VA: 0x182C84410
	private void set_lensShift_Injected(ref Vector2 value) { }

	// RVA: 0x2C83A80 Offset: 0x2C82480 VA: 0x182C83A80
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x2C84770 Offset: 0x2C83170 VA: 0x182C84770
	private void set_rect_Injected(ref Rect value) { }

	// RVA: 0x2C838F0 Offset: 0x2C822F0 VA: 0x182C838F0
	private void get_pixelRect_Injected(out Rect ret) { }

	// RVA: 0x2C84630 Offset: 0x2C83030 VA: 0x182C84630
	private void set_pixelRect_Injected(ref Rect value) { }

	// RVA: 0x2C83380 Offset: 0x2C81D80 VA: 0x182C83380
	private void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2C83DC0 Offset: 0x2C827C0 VA: 0x182C83DC0
	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2C84A60 Offset: 0x2C83460 VA: 0x182C84A60
	private void set_worldToCameraMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x2C839D0 Offset: 0x2C823D0 VA: 0x182C839D0
	private void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2C846D0 Offset: 0x2C830D0 VA: 0x182C846D0
	private void set_projectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x2C844F0 Offset: 0x2C82EF0 VA: 0x182C844F0
	private void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x2C81A60 Offset: 0x2C80460 VA: 0x182C81A60
	private void CalculateObliqueMatrix_Injected(ref Vector4 clipPlane, out Matrix4x4 ret) { }

	// RVA: 0x2C82DF0 Offset: 0x2C817F0 VA: 0x182C82DF0
	private void WorldToScreenPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2C82F60 Offset: 0x2C81960 VA: 0x182C82F60
	private void WorldToViewportPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2C82C80 Offset: 0x2C81680 VA: 0x182C82C80
	private void ViewportToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2C826A0 Offset: 0x2C810A0 VA: 0x182C826A0
	private void ScreenToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2C825E0 Offset: 0x2C80FE0 VA: 0x182C825E0
	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x2C82A40 Offset: 0x2C81440 VA: 0x182C82A40
	private void ViewportPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x2C823A0 Offset: 0x2C80DA0 VA: 0x182C823A0
	private void ScreenPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x2C81F30 Offset: 0x2C80930 VA: 0x182C81F30
	private void GetStereoNonJitteredProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x2C81FF0 Offset: 0x2C809F0 VA: 0x182C81FF0
	private void GetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x2C82860 Offset: 0x2C81260 VA: 0x182C82860
	private void SetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix) { }

	// RVA: 0x2C82900 Offset: 0x2C81300 VA: 0x182C82900
	private void SetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix) { }
}
