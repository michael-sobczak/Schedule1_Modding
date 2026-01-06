public class GrabScreenFeature : ScriptableRendererFeature // TypeDefIndex: 5
{
	// Fields
	private GrabScreenFeature.GrabPass grabPass; // 0x20
	private GrabScreenFeature.RenderPass renderPass; // 0x28
	[SerializeField]
	private GrabScreenFeature.Settings settings; // 0x30

	// Methods

	// RVA: 0x55EC10 Offset: 0x55D610 VA: 0x18055EC10 Slot: 5
	public override void Create() { }

	// RVA: 0x55EBC0 Offset: 0x55D5C0 VA: 0x18055EBC0 Slot: 7
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	// RVA: 0x55ED10 Offset: 0x55D710 VA: 0x18055ED10 Slot: 11
	protected override void Dispose(bool disposing) { }

	// RVA: 0x55ED30 Offset: 0x55D730 VA: 0x18055ED30
	public void .ctor() { }
}
