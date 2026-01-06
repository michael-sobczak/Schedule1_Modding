public sealed class FogComponent : PostProcessingComponentCommandBuffer<FogModel> // TypeDefIndex: 132
{
	// Fields
	private const string k_ShaderString = "Hidden/Post FX/Fog";

	// Properties
	public override bool active { get; }

	// Methods

	// RVA: 0x5734A0 Offset: 0x571EA0 VA: 0x1805734A0 Slot: 5
	public override bool get_active() { }

	// RVA: 0x572F60 Offset: 0x571960 VA: 0x180572F60 Slot: 11
	public override string GetName() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x572F50 Offset: 0x571950 VA: 0x180572F50 Slot: 10
	public override CameraEvent GetCameraEvent() { }

	// RVA: 0x572F90 Offset: 0x571990 VA: 0x180572F90 Slot: 12
	public override void PopulateCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x573460 Offset: 0x571E60 VA: 0x180573460
	public void .ctor() { }
}
