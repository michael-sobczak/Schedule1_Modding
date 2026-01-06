public class PlanarReflections : MonoBehaviour // TypeDefIndex: 18812
{
	// Fields
	[Range(0.01, 1)]
	public float renderScale; // 0x20
	public LayerMask reflectionLayer; // 0x24
	public bool reflectSkybox; // 0x28
	public GameObject reflectionTarget; // 0x30
	[Range(-2, 3)]
	public float reflectionPlaneOffset; // 0x38
	private static Camera _reflectionCamera; // 0x0
	private UniversalAdditionalCameraData cameraData; // 0x40
	private static RenderTexture _reflectionTexture; // 0x8
	private RenderTextureDescriptor previousDescriptor; // 0x48
	private readonly int _planarReflectionTextureId; // 0x7C
	[CompilerGenerated]
	private static Action<ScriptableRenderContext, Camera> BeginPlanarReflections; // 0x10
	public bool hideReflectionCamera; // 0x80

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F76A50 Offset: 0x1F75450 VA: 0x181F76A50
	public static void add_BeginPlanarReflections(Action<ScriptableRenderContext, Camera> value) { }

	[CompilerGenerated]
	// RVA: 0x1F76B30 Offset: 0x1F75530 VA: 0x181F76B30
	public static void remove_BeginPlanarReflections(Action<ScriptableRenderContext, Camera> value) { }

	// RVA: 0x1F75D20 Offset: 0x1F74720 VA: 0x181F75D20
	private void OnEnable() { }

	// RVA: 0x1F75C80 Offset: 0x1F74680 VA: 0x181F75C80
	private void OnDisable() { }

	// RVA: 0x1F75BE0 Offset: 0x1F745E0 VA: 0x181F75BE0
	private void OnDestroy() { }

	// RVA: 0x1F75040 Offset: 0x1F73A40 VA: 0x181F75040
	private void CleanUp() { }

	// RVA: 0x1F75DE0 Offset: 0x1F747E0 VA: 0x181F75DE0
	private void SafeDestroyObject(Object obj) { }

	// RVA: 0x1F75FC0 Offset: 0x1F749C0 VA: 0x181F75FC0
	private void UpdateReflectionCamera(Camera realCamera) { }

	// RVA: 0x1F75E80 Offset: 0x1F74880 VA: 0x181F75E80
	private void UpdateCamera(Camera src, Camera dest) { }

	// RVA: 0x1F75900 Offset: 0x1F74300 VA: 0x181F75900
	private Camera InitializeReflectionCamera() { }

	// RVA: 0x1F74E00 Offset: 0x1F73800 VA: 0x181F74E00
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign) { }

	// RVA: 0x1F756E0 Offset: 0x1F740E0 VA: 0x181F756E0
	private RenderTextureDescriptor GetDescriptor(Camera camera, float pipelineRenderScale) { }

	// RVA: 0x1F751D0 Offset: 0x1F73BD0 VA: 0x181F751D0
	private void CreateReflectionTexture(Camera camera) { }

	// RVA: 0x1F75460 Offset: 0x1F73E60 VA: 0x181F75460
	private void DoPlanarReflections(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x1F74CE0 Offset: 0x1F736E0 VA: 0x181F74CE0
	public static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMatrix, Vector4 plane) { }

	// RVA: 0x1F75DC0 Offset: 0x1F747C0 VA: 0x181F75DC0
	public static Vector3 ReflectPosition(Vector3 pos) { }

	// RVA: 0x7B3900 Offset: 0x7B2300 VA: 0x1807B3900
	public static bool Compare(Vector2 a, Vector2 b) { }

	// RVA: 0x1F769F0 Offset: 0x1F753F0 VA: 0x181F769F0
	public void .ctor() { }
}
