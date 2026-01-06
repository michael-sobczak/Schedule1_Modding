public class PostProcessingBehaviour : MonoBehaviour // TypeDefIndex: 211
{
	// Fields
	public PostProcessingProfile profile; // 0x20
	public Func<Vector2, Matrix4x4> jitteredMatrixFunc; // 0x28
	private Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>> m_CommandBuffers; // 0x30
	private List<PostProcessingComponentBase> m_Components; // 0x38
	private Dictionary<PostProcessingComponentBase, bool> m_ComponentStates; // 0x40
	private MaterialFactory m_MaterialFactory; // 0x48
	private RenderTextureFactory m_RenderTextureFactory; // 0x50
	private PostProcessingContext m_Context; // 0x58
	private Camera m_Camera; // 0x60
	private PostProcessingProfile m_PreviousProfile; // 0x68
	private bool m_RenderingInSceneView; // 0x70
	private BuiltinDebugViewsComponent m_DebugViews; // 0x78
	private AmbientOcclusionComponent m_AmbientOcclusion; // 0x80
	private ScreenSpaceReflectionComponent m_ScreenSpaceReflection; // 0x88
	private FogComponent m_FogComponent; // 0x90
	private MotionBlurComponent m_MotionBlur; // 0x98
	private TaaComponent m_Taa; // 0xA0
	private EyeAdaptationComponent m_EyeAdaptation; // 0xA8
	private DepthOfFieldComponent m_DepthOfField; // 0xB0
	private BloomComponent m_Bloom; // 0xB8
	private ChromaticAberrationComponent m_ChromaticAberration; // 0xC0
	private ColorGradingComponent m_ColorGrading; // 0xC8
	private UserLutComponent m_UserLut; // 0xD0
	private GrainComponent m_Grain; // 0xD8
	private VignetteComponent m_Vignette; // 0xE0
	private DitheringComponent m_Dithering; // 0xE8
	private FxaaComponent m_Fxaa; // 0xF0
	private List<PostProcessingComponentBase> m_ComponentsToEnable; // 0xF8
	private List<PostProcessingComponentBase> m_ComponentsToDisable; // 0x100

	// Methods

	// RVA: 0x69D110 Offset: 0x69BB10 VA: 0x18069D110
	private void OnEnable() { }

	// RVA: 0x69DE70 Offset: 0x69C870 VA: 0x18069DE70
	private void OnPreCull() { }

	// RVA: 0x69E580 Offset: 0x69CF80 VA: 0x18069E580
	private void OnPreRender() { }

	// RVA: 0x69DD60 Offset: 0x69C760 VA: 0x18069DD60
	private void OnPostRender() { }

	// RVA: 0x69E690 Offset: 0x69D090 VA: 0x18069E690
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x69DA50 Offset: 0x69C450 VA: 0x18069DA50
	private void OnGUI() { }

	// RVA: 0x69CD30 Offset: 0x69B730 VA: 0x18069CD30
	private void OnDisable() { }

	// RVA: 0x69EDC0 Offset: 0x69D7C0 VA: 0x18069EDC0
	public void ResetTemporalEffects() { }

	// RVA: 0x69C840 Offset: 0x69B240 VA: 0x18069C840
	private void CheckObservers() { }

	// RVA: 0x69CBF0 Offset: 0x69B5F0 VA: 0x18069CBF0
	private void DisableComponents() { }

	// RVA: -1 Offset: -1
	private CommandBuffer AddCommandBuffer<T>(CameraEvent evt, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF26540 Offset: 0xF24F40 VA: 0x180F26540
	|-PostProcessingBehaviour.AddCommandBuffer<object>
	*/

	// RVA: -1 Offset: -1
	private void RemoveCommandBuffer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF26870 Offset: 0xF25270 VA: 0x180F26870
	|-PostProcessingBehaviour.RemoveCommandBuffer<object>
	*/

	// RVA: -1 Offset: -1
	private CommandBuffer GetCommandBuffer<T>(CameraEvent evt, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF26760 Offset: 0xF25160 VA: 0x180F26760
	|-PostProcessingBehaviour.GetCommandBuffer<object>
	*/

	// RVA: -1 Offset: -1
	private void TryExecuteCommandBuffer<T>(PostProcessingComponentCommandBuffer<T> component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF26980 Offset: 0xF25380 VA: 0x180F26980
	|-PostProcessingBehaviour.TryExecuteCommandBuffer<object>
	*/

	// RVA: -1 Offset: -1
	private bool TryPrepareUberImageEffect<T>(PostProcessingComponentRenderTexture<T> component, Material material) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF26B50 Offset: 0xF25550 VA: 0x180F26B50
	|-PostProcessingBehaviour.TryPrepareUberImageEffect<object>
	*/

	// RVA: -1 Offset: -1
	private T AddComponent<T>(T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF266A0 Offset: 0xF250A0 VA: 0x180F266A0
	|-PostProcessingBehaviour.AddComponent<object>
	*/

	// RVA: 0x69EE10 Offset: 0x69D810 VA: 0x18069EE10
	public void .ctor() { }
}
