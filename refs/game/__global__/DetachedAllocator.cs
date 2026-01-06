internal class DetachedAllocator : IDisposable // TypeDefIndex: 7075
{
	// Fields
	private TempAllocator<Vertex> m_VertsPool; // 0x10
	private TempAllocator<ushort> m_IndexPool; // 0x18
	private List<MeshWriteData> m_MeshWriteDataPool; // 0x20
	private int m_MeshWriteDataCount; // 0x28
	private bool m_Disposed; // 0x2C

	// Methods

	// RVA: 0x2DFA8F0 Offset: 0x2DF92F0 VA: 0x182DFA8F0
	public void .ctor() { }

	// RVA: 0x2DFA7B0 Offset: 0x2DF91B0 VA: 0x182DFA7B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2DFA860 Offset: 0x2DF9260 VA: 0x182DFA860
	protected void Dispose(bool disposing) { }
}
