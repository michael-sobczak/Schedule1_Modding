public class RenderObjects : ScriptableRendererFeature // TypeDefIndex: 8660
{
	// Fields
	public RenderObjects.RenderObjectsSettings settings; // 0x20
	private RenderObjectsPass renderObjectsPass; // 0x28

	// Methods

	// RVA: 0x2A76570 Offset: 0x2A74F70 VA: 0x182A76570 Slot: 5
	public override void Create() { }

	// RVA: 0x2A764E0 Offset: 0x2A74EE0 VA: 0x182A764E0 Slot: 7
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	internal override bool SupportsNativeRenderPass() { }

	// RVA: 0x2A769A0 Offset: 0x2A753A0 VA: 0x182A769A0
	public void .ctor() { }
}
