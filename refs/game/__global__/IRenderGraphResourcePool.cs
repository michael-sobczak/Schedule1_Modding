internal abstract class IRenderGraphResourcePool // TypeDefIndex: 13532
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void PurgeUnusedResources(int currentFrameIndex);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Cleanup();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void CheckFrameAllocation(bool onException, int frameIndex);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void LogResources(RenderGraphLogger logger);

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
