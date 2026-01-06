public class DisplacementPrePass : ScriptableRenderPass // TypeDefIndex: 18263
{
	// Fields
	private const string profilerTag = "Water Displacement Prepass";
	private static readonly ProfilingSampler profilerSampler; // 0x0
	public const string KEYWORD = "WATER_DISPLACEMENT_PASS";
	public const float VOID_THRESHOLD = -1000;
	private Color targetClearColor; // 0xE0
	private FilteringSettings m_FilteringSettings; // 0xF0
	private RenderStateBlock m_RenderStateBlock; // 0x108
	private readonly List<ShaderTagId> m_ShaderTagIdList; // 0x178
	private static readonly Quaternion viewRotation; // 0x8
	private static readonly Vector3 viewScale; // 0x18
	private static Rect viewportRect; // 0x24
	private const string BufferName = "_WaterDisplacementBuffer";
	private static readonly int _WaterDisplacementBuffer; // 0x34
	private const string CoordsName = "_WaterDisplacementCoords";
	private static readonly int _WaterDisplacementCoords; // 0x38
	private RTHandle renderTarget; // 0x180
	private static Vector3 centerPosition; // 0x3C
	private static Vector4 rendererCoords; // 0x48
	[CompilerGenerated]
	private static Matrix4x4 <projection>k__BackingField; // 0x58
	[CompilerGenerated]
	private static Matrix4x4 <view>k__BackingField; // 0x98
	private int resolution; // 0x188
	private int m_resolution; // 0x18C
	private float orthoSize; // 0x190
	private DisplacementPrePass.Settings settings; // 0x198

	// Properties
	private static Matrix4x4 projection { get; set; }
	private static Matrix4x4 view { get; set; }

	// Methods

	// RVA: 0x1F68D20 Offset: 0x1F67720 VA: 0x181F68D20
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F69120 Offset: 0x1F67B20 VA: 0x181F69120
	private static void set_projection(Matrix4x4 value) { }

	[CompilerGenerated]
	// RVA: 0x1F69020 Offset: 0x1F67A20 VA: 0x181F69020
	private static Matrix4x4 get_projection() { }

	[CompilerGenerated]
	// RVA: 0x1F691A0 Offset: 0x1F67BA0 VA: 0x181F691A0
	private static void set_view(Matrix4x4 value) { }

	[CompilerGenerated]
	// RVA: 0x1F690A0 Offset: 0x1F67AA0 VA: 0x181F690A0
	private static Matrix4x4 get_view() { }

	// RVA: 0x1F68A40 Offset: 0x1F67440 VA: 0x181F68A40
	public void Setup(DisplacementPrePass.Settings settings) { }

	// RVA: 0x1F68B10 Offset: 0x1F67510 VA: 0x181F68B10
	private static Vector3 StabilizeProjection(Vector3 pos, float texelSize) { }

	// RVA: 0x1F68280 Offset: 0x1F66C80 VA: 0x181F68280
	private void SetupProjection(CommandBuffer cmd, Camera camera) { }

	// RVA: 0x1F67C90 Offset: 0x1F66690 VA: 0x181F67C90 Slot: 6
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x1F67FA0 Offset: 0x1F669A0 VA: 0x181F67FA0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x1F67ED0 Offset: 0x1F668D0 VA: 0x181F67ED0
	public void Dispose() { }

	// RVA: 0x1F68BD0 Offset: 0x1F675D0 VA: 0x181F68BD0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1F63C60 Offset: 0x1F62660 VA: 0x181F63C60
	internal static float <StabilizeProjection>g__Snap|33_0(float coord, float cellSize) { }
}
