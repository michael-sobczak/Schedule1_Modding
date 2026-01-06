internal class JobMerger : IDisposable // TypeDefIndex: 7103
{
	// Fields
	private NativeArray<JobHandle> m_Jobs; // 0x10
	private int m_JobCount; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x24

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x2DFCF80 Offset: 0x2DFB980 VA: 0x182DFCF80
	public void .ctor(int capacity) { }

	// RVA: 0x2DFCD70 Offset: 0x2DFB770 VA: 0x182DFCD70
	public void Add(JobHandle job) { }

	// RVA: 0x2DFCED0 Offset: 0x2DFB8D0 VA: 0x182DFCED0
	public JobHandle MergeAndReset() { }

	[CompilerGenerated]
	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x563E00 Offset: 0x562800 VA: 0x180563E00
	private void set_disposed(bool value) { }

	// RVA: 0x2DFCE50 Offset: 0x2DFB850 VA: 0x182DFCE50 Slot: 4
	public void Dispose() { }

	// RVA: 0x2DFCDF0 Offset: 0x2DFB7F0 VA: 0x182DFCDF0
	protected void Dispose(bool disposing) { }
}
