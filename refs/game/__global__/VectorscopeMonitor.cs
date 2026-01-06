public sealed class VectorscopeMonitor : Monitor // TypeDefIndex: 17014
{
	// Fields
	public int size; // 0x20
	public float exposure; // 0x24
	private ComputeBuffer m_Data; // 0x28
	private const int k_ThreadGroupSizeX = 16;
	private const int k_ThreadGroupSizeY = 16;

	// Methods

	// RVA: 0x29C2760 Offset: 0x29C1160 VA: 0x1829C2760 Slot: 7
	internal override void OnDisable() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 5
	internal override bool NeedsHalfRes() { }

	// RVA: 0x29C2EF0 Offset: 0x29C18F0 VA: 0x1829C2EF0 Slot: 4
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

	// RVA: 0x29C27E0 Offset: 0x29C11E0 VA: 0x1829C27E0 Slot: 8
	internal override void Render(PostProcessRenderContext context) { }

	// RVA: 0x29C2F60 Offset: 0x29C1960 VA: 0x1829C2F60
	public void .ctor() { }
}
