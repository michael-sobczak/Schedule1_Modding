internal struct LayerBatch // TypeDefIndex: 8715
{
	// Fields
	public int startLayerID; // 0x0
	public int endLayerValue; // 0x4
	public SortingLayerRange layerRange; // 0x8
	public LightStats lightStats; // 0xC
	[FixedBuffer(typeof(int), 4)]
	private LayerBatch.<renderTargetIds>e__FixedBuffer renderTargetIds; // 0x20
	[FixedBuffer(typeof(bool), 4)]
	private LayerBatch.<renderTargetUsed>e__FixedBuffer renderTargetUsed; // 0x30

	// Methods

	// RVA: 0x2A7ADE0 Offset: 0x2A797E0 VA: 0x182A7ADE0
	public void InitRTIds(int index) { }

	// RVA: 0x2A7AD30 Offset: 0x2A79730 VA: 0x182A7AD30
	public RenderTargetIdentifier GetRTId(CommandBuffer cmd, RenderTextureDescriptor desc, int index) { }

	// RVA: 0x2A7AEB0 Offset: 0x2A798B0 VA: 0x182A7AEB0
	public void ReleaseRT(CommandBuffer cmd) { }
}
