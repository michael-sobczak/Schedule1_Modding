internal class OpacityIdAccelerator : IDisposable // TypeDefIndex: 7113
{
	// Fields
	private NativeArray<JobHandle> m_Jobs; // 0x10
	private int m_NextJobIndex; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x24

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x2DFDE20 Offset: 0x2DFC820 VA: 0x182DFDE20
	public void CreateJob(NativeSlice<Vertex> oldVerts, NativeSlice<Vertex> newVerts, Color32 opacityData, int vertexCount) { }

	// RVA: 0x2DFDD70 Offset: 0x2DFC770 VA: 0x182DFDD70
	public void CompleteJobs() { }

	[CompilerGenerated]
	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x563E00 Offset: 0x562800 VA: 0x180563E00
	private void set_disposed(bool value) { }

	// RVA: 0x2DFDF50 Offset: 0x2DFC950 VA: 0x182DFDF50 Slot: 4
	public void Dispose() { }

	// RVA: 0x2DFDFC0 Offset: 0x2DFC9C0 VA: 0x182DFDFC0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2DFE020 Offset: 0x2DFCA20 VA: 0x182DFE020
	public void .ctor() { }
}
