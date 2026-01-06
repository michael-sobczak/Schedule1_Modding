public sealed class WaveformMonitor : Monitor // TypeDefIndex: 17015
{
	// Fields
	public float exposure; // 0x20
	public int height; // 0x24
	private ComputeBuffer m_Data; // 0x28
	private const int k_ThreadGroupSize = 256;
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;

	// Methods

	// RVA: 0x29C2760 Offset: 0x29C1160 VA: 0x1829C2760 Slot: 7
	internal override void OnDisable() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 5
	internal override bool NeedsHalfRes() { }

	// RVA: 0x29C3800 Offset: 0x29C2200 VA: 0x1829C3800 Slot: 4
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	// RVA: 0x29C2F80 Offset: 0x29C1980 VA: 0x1829C2F80 Slot: 8
	internal override void Render(PostProcessRenderContext context) { }

	// RVA: 0x29C3870 Offset: 0x29C2270 VA: 0x1829C3870
	public void .ctor() { }
}
