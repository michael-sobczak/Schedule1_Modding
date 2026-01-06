public class AmplifyImpostor : MonoBehaviour // TypeDefIndex: 18775
{
	// Fields
	public const string PresetBiRP = "e4786beb7716da54dbb02a632681cc37";
	public const string ShaderBiRP = "e82933f4c0eb9ba42aab0739f48efe21";
	public const string ShaderOctaBiRP = "572f9be5706148142b8da6e9de53acdb";
	public const string PresetHDRP = "47b6b3dcefe0eaf4997acf89caf8c75e";
	public const string ShaderHDRP = "175c951fec709c44fa2f26b8ab78b8dd";
	public const string ShaderOctaHDRP = "56236dc63ad9b7949b63a27f0ad180b3";
	public const string PresetURP = "0403878495ffa3c4e9d4bcb3eac9b559";
	public const string ShaderOctaURP = "83dd8de9a5c14874884f9012def4fdcc";
	public const string ShaderURP = "da79d698f4bf0164e910ad798d07efdf";
	public const string DilateGUID = "57c23892d43bc9f458360024c5985405";
	public const string PackerGUID = "31bd3cd74692f384a916d9d7ea87710d";
	public static readonly int _DetailNormalMap_PID; // 0x0
	[SerializeField]
	private AmplifyImpostorAsset m_data; // 0x20
	[SerializeField]
	private Transform m_rootTransform; // 0x28
	[SerializeField]
	private LODGroup m_lodGroup; // 0x30
	[SerializeField]
	private Renderer[] m_renderers; // 0x38
	public LODReplacement m_lodReplacement; // 0x40
	[SerializeField]
	public RenderPipelineInUse m_renderPipelineInUse; // 0x44
	public int m_insertIndex; // 0x48
	[SerializeField]
	public GameObject m_lastImpostor; // 0x50
	[SerializeField]
	public string m_folderPath; // 0x58
	public string m_impostorName; // 0x60
	[SerializeField]
	public CutMode m_cutMode; // 0x68
	private const float StartXRotation = -90;
	private const float StartYRotation = 90;
	private const int MinAlphaResolution = 256;
	private RenderTexture[] m_rtGBuffers; // 0x70
	private RenderTexture[] m_alphaGBuffers; // 0x78
	private RenderTexture m_trueDepth; // 0x80
	public Texture2D m_alphaTex; // 0x88
	private float m_xyFitSize; // 0x90
	private float m_depthFitSize; // 0x94
	private Vector2 m_pixelOffset; // 0x98
	private Bounds m_originalBound; // 0xA0
	private Vector3 m_oriPos; // 0xB8
	private Quaternion m_oriRot; // 0xC4
	private Vector3 m_oriSca; // 0xD4
	private const int BlockSize = 65536;

	// Properties
	public AmplifyImpostorAsset Data { get; set; }
	public Transform RootTransform { get; set; }
	public LODGroup LodGroup { get; set; }
	public Renderer[] Renderers { get; set; }

	// Methods

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public AmplifyImpostorAsset get_Data() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Data(AmplifyImpostorAsset value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Transform get_RootTransform() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_RootTransform(Transform value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public LODGroup get_LodGroup() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_LodGroup(LODGroup value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public Renderer[] get_Renderers() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_Renderers(Renderer[] value) { }

	// RVA: 0x44E0C0 Offset: 0x44CAC0 VA: 0x18044E0C0
	private void GenerateTextures(List<TextureOutput> outputList, bool standardRendering) { }

	// RVA: 0x44D480 Offset: 0x44BE80 VA: 0x18044D480
	private void GenerateAlphaTextures(List<TextureOutput> outputList) { }

	// RVA: 0x44D3F0 Offset: 0x44BDF0 VA: 0x18044D3F0
	private void ClearBuffers() { }

	// RVA: 0x44D360 Offset: 0x44BD60 VA: 0x18044D360
	private void ClearAlphaBuffers() { }

	// RVA: 0x44EFF0 Offset: 0x44D9F0 VA: 0x18044EFF0
	public void RenderImpostor(ImpostorType impostorType, int targetAmount, bool impostorMaps = True, bool combinedAlphas = False, bool useMinResolution = False, Shader customShader) { }

	// RVA: 0x44E750 Offset: 0x44D150 VA: 0x18044E750
	private Matrix4x4 GetCameraRotationMatrix(ImpostorType impostorType, int hframes, int vframes, int x, int y) { }

	// RVA: 0x44EEF0 Offset: 0x44D8F0 VA: 0x18044EEF0
	private Vector3 OctahedronToVector(Vector2 oct) { }

	// RVA: 0x44EE00 Offset: 0x44D800 VA: 0x18044EE00
	private Vector3 OctahedronToVector(float x, float y) { }

	// RVA: 0x44ED70 Offset: 0x44D770 VA: 0x18044ED70
	private Vector3 HemiOctahedronToVector(float x, float y) { }

	// RVA: 0x44D6C0 Offset: 0x44C0C0 VA: 0x18044D6C0
	public void GenerateAutomaticMesh(AmplifyImpostorAsset data) { }

	// RVA: 0x44DC30 Offset: 0x44C630 VA: 0x18044DC30
	public Mesh GenerateMesh(Vector2[] points, Vector3 offset, float width = 1, float height = 1, bool invertY = True) { }

	// RVA: 0x451240 Offset: 0x44FC40 VA: 0x180451240
	public void .ctor() { }

	// RVA: 0x4511F0 Offset: 0x44FBF0 VA: 0x1804511F0
	private static void .cctor() { }
}
