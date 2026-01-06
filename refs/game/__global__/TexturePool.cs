internal class TexturePool : RenderGraphResourcePool<RTHandle> // TypeDefIndex: 13551
{
	// Methods

	// RVA: 0x29F7DC0 Offset: 0x29F67C0 VA: 0x1829F7DC0 Slot: 8
	protected override void ReleaseInternalResource(RTHandle res) { }

	// RVA: 0x29F7920 Offset: 0x29F6320 VA: 0x1829F7920 Slot: 9
	protected override string GetResourceName(RTHandle res) { }

	// RVA: 0x29F7950 Offset: 0x29F6350 VA: 0x1829F7950 Slot: 10
	protected override long GetResourceSize(RTHandle res) { }

	// RVA: 0x29F7980 Offset: 0x29F6380 VA: 0x1829F7980 Slot: 11
	protected override string GetResourceTypeName() { }

	// RVA: 0x29F79B0 Offset: 0x29F63B0 VA: 0x1829F79B0 Slot: 12
	protected override int GetSortIndex(RTHandle res) { }

	// RVA: 0x29F79D0 Offset: 0x29F63D0 VA: 0x1829F79D0 Slot: 4
	public override void PurgeUnusedResources(int currentFrameIndex) { }

	// RVA: 0x29F7DE0 Offset: 0x29F67E0 VA: 0x1829F7DE0
	public void .ctor() { }
}
