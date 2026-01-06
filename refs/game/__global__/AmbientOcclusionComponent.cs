public sealed class AmbientOcclusionComponent : PostProcessingComponentCommandBuffer<AmbientOcclusionModel> // TypeDefIndex: 114
{
	// Fields
	private const string k_BlitShaderString = "Hidden/Post FX/Blit";
	private const string k_ShaderString = "Hidden/Post FX/Ambient Occlusion";
	private readonly RenderTargetIdentifier[] m_MRT; // 0x20

	// Properties
	private AmbientOcclusionComponent.OcclusionSource occlusionSource { get; }
	private bool ambientOnlySupported { get; }
	public override bool active { get; }

	// Methods

	// RVA: 0x56BC10 Offset: 0x56A610 VA: 0x18056BC10
	private AmbientOcclusionComponent.OcclusionSource get_occlusionSource() { }

	// RVA: 0x56BB80 Offset: 0x56A580 VA: 0x18056BB80
	private bool get_ambientOnlySupported() { }

	// RVA: 0x56BB10 Offset: 0x56A510 VA: 0x18056BB10 Slot: 5
	public override bool get_active() { }

	// RVA: 0x56AF10 Offset: 0x569910 VA: 0x18056AF10 Slot: 4
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x56AF50 Offset: 0x569950 VA: 0x18056AF50 Slot: 11
	public override string GetName() { }

	// RVA: 0x56AEA0 Offset: 0x5698A0 VA: 0x18056AEA0 Slot: 10
	public override CameraEvent GetCameraEvent() { }

	// RVA: 0x56AF80 Offset: 0x569980 VA: 0x18056AF80 Slot: 12
	public override void PopulateCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x56BA20 Offset: 0x56A420 VA: 0x18056BA20
	public void .ctor() { }
}
