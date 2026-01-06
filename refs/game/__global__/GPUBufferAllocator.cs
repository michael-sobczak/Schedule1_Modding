internal class GPUBufferAllocator // TypeDefIndex: 7089
{
	// Fields
	private BestFitAllocator m_Low; // 0x10
	private BestFitAllocator m_High; // 0x18

	// Properties
	public bool isEmpty { get; }

	// Methods

	// RVA: 0x2DFB130 Offset: 0x2DF9B30 VA: 0x182DFB130
	public void .ctor(uint maxSize) { }

	// RVA: 0x2DFAE70 Offset: 0x2DF9870 VA: 0x182DFAE70
	public Alloc Allocate(uint size, bool shortLived) { }

	// RVA: 0x2DFB080 Offset: 0x2DF9A80 VA: 0x182DFB080
	public void Free(Alloc alloc) { }

	// RVA: 0x2DFB1E0 Offset: 0x2DF9BE0 VA: 0x182DFB1E0
	public bool get_isEmpty() { }

	// RVA: 0x2DFB100 Offset: 0x2DF9B00 VA: 0x182DFB100
	private bool HighLowCollide() { }
}
