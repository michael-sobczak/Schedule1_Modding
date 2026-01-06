internal class JobManager : IDisposable // TypeDefIndex: 7099
{
	// Fields
	private NativePagedList<NudgeJobData> m_NudgeJobs; // 0x10
	private NativePagedList<ConvertMeshJobData> m_ConvertMeshJobs; // 0x18
	private NativePagedList<CopyClosingMeshJobData> m_CopyClosingMeshJobs; // 0x20
	private JobMerger m_JobMerger; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x30

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x2DFBED0 Offset: 0x2DFA8D0 VA: 0x182DFBED0
	public void Add(ref NudgeJobData job) { }

	// RVA: 0x2DFBE70 Offset: 0x2DFA870 VA: 0x182DFBE70
	public void Add(ref ConvertMeshJobData job) { }

	// RVA: 0x2DFBE10 Offset: 0x2DFA810 VA: 0x182DFBE10
	public void Add(ref CopyClosingMeshJobData job) { }

	// RVA: 0x2DFC5B0 Offset: 0x2DFAFB0 VA: 0x182DFC5B0
	public void CompleteNudgeJobs() { }

	// RVA: 0x2DFC270 Offset: 0x2DFAC70 VA: 0x182DFC270
	public void CompleteConvertMeshJobs() { }

	// RVA: 0x2DFBF30 Offset: 0x2DFA930 VA: 0x182DFBF30
	public void CompleteClosingMeshJobs() { }

	[CompilerGenerated]
	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	private void set_disposed(bool value) { }

	// RVA: 0x2DFCA30 Offset: 0x2DFB430 VA: 0x182DFCA30 Slot: 4
	public void Dispose() { }

	// RVA: 0x2DFC8F0 Offset: 0x2DFB2F0 VA: 0x182DFC8F0
	protected void Dispose(bool disposing) { }

	// RVA: 0x2DFCBA0 Offset: 0x2DFB5A0 VA: 0x182DFCBA0
	public void .ctor() { }
}
