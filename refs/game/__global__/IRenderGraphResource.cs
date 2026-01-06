internal class IRenderGraphResource // TypeDefIndex: 13544
{
	// Fields
	public bool imported; // 0x10
	public bool shared; // 0x11
	public bool sharedExplicitRelease; // 0x12
	public bool requestFallBack; // 0x13
	public uint writeCount; // 0x14
	public int cachedHash; // 0x18
	public int transientPassIndex; // 0x1C
	public int sharedResourceLastFrameUsed; // 0x20
	protected IRenderGraphResourcePool m_Pool; // 0x28

	// Methods

	// RVA: 0x29C7E70 Offset: 0x29C6870 VA: 0x1829C7E70 Slot: 4
	public virtual void Reset(IRenderGraphResourcePool pool) { }

	// RVA: 0x29C7E10 Offset: 0x29C6810 VA: 0x1829C7E10 Slot: 5
	public virtual string GetName() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 6
	public virtual bool IsCreated() { }

	// RVA: 0x29C7E40 Offset: 0x29C6840 VA: 0x1829C7E40 Slot: 7
	public virtual void IncrementWriteCount() { }

	// RVA: 0x29C7E50 Offset: 0x29C6850 VA: 0x1829C7E50 Slot: 8
	public virtual bool NeedsFallBack() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	public virtual void CreatePooledGraphicsResource() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	public virtual void CreateGraphicsResource(string name = "") { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	public virtual void ReleasePooledGraphicsResource(int frameIndex) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	public virtual void ReleaseGraphicsResource() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 13
	public virtual void LogCreation(RenderGraphLogger logger) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 14
	public virtual void LogRelease(RenderGraphLogger logger) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 15
	public virtual int GetSortIndex() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
