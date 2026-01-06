public class SetupConstants : ScriptableRenderPass // TypeDefIndex: 18265
{
	// Fields
	private static readonly int _EnableDirectionalCaustics; // 0x0
	private static readonly int CausticsProjection; // 0x4
	private static readonly int _WaterSSREnabled; // 0x8
	private static readonly int _WaterDisplacementPrePassAvailable; // 0xC
	private bool m_directionalCaustics; // 0xE0
	private static VisibleLight mainLight; // 0x10
	private Matrix4x4 causticsProjection; // 0xE4
	private StylizedWaterRenderFeature settings; // 0x128
	private ScriptableRenderPassInput requirements; // 0x130

	// Methods

	// RVA: 0x1F6F480 Offset: 0x1F6DE80 VA: 0x181F6F480
	public void .ctor() { }

	// RVA: 0x1F6F370 Offset: 0x1F6DD70 VA: 0x181F6F370
	public void Setup(StylizedWaterRenderFeature renderFeature) { }

	// RVA: 0x1F6ED60 Offset: 0x1F6D760 VA: 0x181F6ED60 Slot: 6
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x1F6EF40 Offset: 0x1F6D940 VA: 0x181F6EF40 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x1F6F2E0 Offset: 0x1F6DCE0 VA: 0x181F6F2E0 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0x1F6EEE0 Offset: 0x1F6D8E0 VA: 0x181F6EEE0
	public void Dispose() { }

	// RVA: 0x1F6F3B0 Offset: 0x1F6DDB0 VA: 0x181F6F3B0
	private static void .cctor() { }
}
