public class HBAORendererFeature : ScriptableRendererFeature // TypeDefIndex: 18532
{
	// Fields
	[SerializeField]
	[HideInInspector]
	private Shader shader; // 0x20
	private HBAORendererFeature.HBAORenderPass m_HBAORenderPass; // 0x28

	// Methods

	// RVA: 0x1A44DA0 Offset: 0x1A437A0 VA: 0x181A44DA0
	private void OnDisable() { }

	// RVA: 0x1A44AC0 Offset: 0x1A434C0 VA: 0x181A44AC0 Slot: 5
	public override void Create() { }

	// RVA: 0x1A44D60 Offset: 0x1A43760 VA: 0x181A44D60 Slot: 11
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1A44910 Offset: 0x1A43310 VA: 0x181A44910 Slot: 7
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	// RVA: 0xCBFB10 Offset: 0xCBE510 VA: 0x180CBFB10
	public void .ctor() { }
}
