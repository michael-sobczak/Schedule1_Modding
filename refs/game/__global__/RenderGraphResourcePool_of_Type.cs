internal abstract class RenderGraphResourcePool<Type> : IRenderGraphResourcePool // TypeDefIndex: 13535
{
	// Fields
	[TupleElementNames(new[] { "resource", "frameIndex" })]
	protected Dictionary<int, SortedList<int, ValueTuple<Type, int>>> m_ResourcePool; // 0x0
	protected List<int> m_RemoveList; // 0x0
	private List<ValueTuple<int, Type>> m_FrameAllocatedResources; // 0x0
	protected static int s_CurrentFrameIndex; // 0x0
	private const int kStaleResourceLifetime = 10;

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void ReleaseInternalResource(Type res);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RenderGraphResourcePool<object>.ReleaseInternalResource
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract string GetResourceName(Type res);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RenderGraphResourcePool<object>.GetResourceName
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract long GetResourceSize(Type res);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RenderGraphResourcePool<object>.GetResourceSize
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract string GetResourceTypeName();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RenderGraphResourcePool<object>.GetResourceTypeName
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract int GetSortIndex(Type res);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RenderGraphResourcePool<object>.GetSortIndex
	*/

	// RVA: -1 Offset: -1
	public void ReleaseResource(int hash, Type resource, int currentFrameIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A6EB0 Offset: 0x11A58B0 VA: 0x1811A6EB0
	|-RenderGraphResourcePool<object>.ReleaseResource
	*/

	// RVA: -1 Offset: -1
	public bool TryGetResource(int hashCode, out Type resource) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A7030 Offset: 0x11A5A30 VA: 0x1811A7030
	|-RenderGraphResourcePool<object>.TryGetResource
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void Cleanup() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A6190 Offset: 0x11A4B90 VA: 0x1811A6190
	|-RenderGraphResourcePool<object>.Cleanup
	*/

	// RVA: -1 Offset: -1
	public void RegisterFrameAllocation(int hash, Type value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A6DD0 Offset: 0x11A57D0 VA: 0x1811A6DD0
	|-RenderGraphResourcePool<object>.RegisterFrameAllocation
	*/

	// RVA: -1 Offset: -1
	public void UnregisterFrameAllocation(int hash, Type value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A71C0 Offset: 0x11A5BC0 VA: 0x1811A71C0
	|-RenderGraphResourcePool<object>.UnregisterFrameAllocation
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void CheckFrameAllocation(bool onException, int frameIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A5EB0 Offset: 0x11A48B0 VA: 0x1811A5EB0
	|-RenderGraphResourcePool<object>.CheckFrameAllocation
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void LogResources(RenderGraphLogger logger) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A6470 Offset: 0x11A4E70 VA: 0x1811A6470
	|-RenderGraphResourcePool<object>.LogResources
	*/

	// RVA: -1 Offset: -1
	protected static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A7020 Offset: 0x11A5A20 VA: 0x1811A7020
	|-RenderGraphResourcePool<object>.ShouldReleaseResource
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A7240 Offset: 0x11A5C40 VA: 0x1811A7240
	|-RenderGraphResourcePool<object>..ctor
	*/
}
