internal class UpscalePass : ScriptableRenderPass // TypeDefIndex: 8712
{
	// Fields
	private static readonly ProfilingSampler m_ProfilingScope; // 0x0
	private RTHandle m_Source; // 0xE0
	private RTHandle m_UpscaleHandle; // 0xE8
	private static Material m_BlitMaterial; // 0x8

	// Methods

	// RVA: 0x2A8DD90 Offset: 0x2A8C790 VA: 0x182A8DD90
	public void .ctor(RenderPassEvent evt, Material blitMaterial) { }

	// RVA: 0x2A8DB90 Offset: 0x2A8C590 VA: 0x182A8DB90
	public void Setup(RTHandle colorTargetHandle, int width, int height, FilterMode mode, ref RenderingData renderingData, out RTHandle upscaleHandle) { }

	// RVA: 0x55E850 Offset: 0x55D250 VA: 0x18055E850
	public void Dispose() { }

	// RVA: 0x2A8D9D0 Offset: 0x2A8C3D0 VA: 0x182A8D9D0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2A8DD00 Offset: 0x2A8C700 VA: 0x182A8DD00
	private static void .cctor() { }
}
