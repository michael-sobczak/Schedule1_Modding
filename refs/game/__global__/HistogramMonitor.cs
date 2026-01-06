public sealed class HistogramMonitor : Monitor // TypeDefIndex: 17010
{
	// Fields
	public int width; // 0x20
	public int height; // 0x24
	public HistogramMonitor.Channel channel; // 0x28
	private ComputeBuffer m_Data; // 0x30
	private const int k_NumBins = 256;
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;

	// Methods

	// RVA: 0x29AAD80 Offset: 0x29A9780 VA: 0x1829AAD80 Slot: 7
	internal override void OnDisable() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 5
	internal override bool NeedsHalfRes() { }

	// RVA: 0x29AB480 Offset: 0x29A9E80 VA: 0x1829AB480 Slot: 4
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	// RVA: 0x29AAE00 Offset: 0x29A9800 VA: 0x1829AAE00 Slot: 8
	internal override void Render(PostProcessRenderContext context) { }

	// RVA: 0x29AB4F0 Offset: 0x29A9EF0 VA: 0x1829AB4F0
	public void .ctor() { }
}
