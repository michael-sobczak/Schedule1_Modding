internal class ComputeBufferPool : RenderGraphResourcePool<ComputeBuffer> // TypeDefIndex: 13531
{
	// Methods

	// RVA: 0x29C7770 Offset: 0x29C6170 VA: 0x1829C7770 Slot: 8
	protected override void ReleaseInternalResource(ComputeBuffer res) { }

	// RVA: 0x29C72E0 Offset: 0x29C5CE0 VA: 0x1829C72E0 Slot: 9
	protected override string GetResourceName(ComputeBuffer res) { }

	// RVA: 0x29C7310 Offset: 0x29C5D10 VA: 0x1829C7310 Slot: 10
	protected override long GetResourceSize(ComputeBuffer res) { }

	// RVA: 0x29C7350 Offset: 0x29C5D50 VA: 0x1829C7350 Slot: 11
	protected override string GetResourceTypeName() { }

	// RVA: 0xCF2FE0 Offset: 0xCF19E0 VA: 0x180CF2FE0 Slot: 12
	protected override int GetSortIndex(ComputeBuffer res) { }

	// RVA: 0x29C7380 Offset: 0x29C5D80 VA: 0x1829C7380 Slot: 4
	public override void PurgeUnusedResources(int currentFrameIndex) { }

	// RVA: 0x29C7790 Offset: 0x29C6190 VA: 0x1829C7790
	public void .ctor() { }
}
