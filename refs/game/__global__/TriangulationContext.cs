public abstract class TriangulationContext // TypeDefIndex: 18667
{
	// Fields
	public readonly List<DelaunayTriangle> Triangles; // 0x10
	public readonly List<TriangulationPoint> Points; // 0x18
	[CompilerGenerated]
	private TriangulationDebugContext <DebugContext>k__BackingField; // 0x20
	[CompilerGenerated]
	private TriangulationMode <TriangulationMode>k__BackingField; // 0x28
	[CompilerGenerated]
	private Triangulatable <Triangulatable>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <StepCount>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsDebugEnabled>k__BackingField; // 0x3C

	// Properties
	public TriangulationDebugContext DebugContext { get; set; }
	public TriangulationMode TriangulationMode { get; set; }
	public Triangulatable Triangulatable { get; set; }
	public int StepCount { get; set; }
	public abstract TriangulationAlgorithm Algorithm { get; }
	public virtual bool IsDebugEnabled { get; set; }
	public DTSweepDebugContext DTDebugContext { get; }

	// Methods

	// RVA: 0x1E859D0 Offset: 0x1E843D0 VA: 0x181E859D0
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public TriangulationDebugContext get_DebugContext() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_DebugContext(TriangulationDebugContext value) { }

	[CompilerGenerated]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public TriangulationMode get_TriangulationMode() { }

	[CompilerGenerated]
	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	protected void set_TriangulationMode(TriangulationMode value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public Triangulatable get_Triangulatable() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	private void set_Triangulatable(Triangulatable value) { }

	[CompilerGenerated]
	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public int get_StepCount() { }

	[CompilerGenerated]
	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	private void set_StepCount(int value) { }

	// RVA: 0x1E858E0 Offset: 0x1E842E0 VA: 0x181E858E0
	public void Done() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract TriangulationAlgorithm get_Algorithm();

	// RVA: 0x1E858F0 Offset: 0x1E842F0 VA: 0x181E858F0 Slot: 5
	public virtual void PrepareTriangulation(Triangulatable t) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b);

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Update(string message) { }

	// RVA: 0x1E85860 Offset: 0x1E84260 VA: 0x181E85860 Slot: 7
	public virtual void Clear() { }

	[CompilerGenerated]
	// RVA: 0x495E90 Offset: 0x494890 VA: 0x180495E90 Slot: 8
	public virtual bool get_IsDebugEnabled() { }

	[CompilerGenerated]
	// RVA: 0x66B060 Offset: 0x669A60 VA: 0x18066B060 Slot: 9
	protected virtual void set_IsDebugEnabled(bool value) { }

	// RVA: 0x1E85AA0 Offset: 0x1E844A0 VA: 0x181E85AA0
	public DTSweepDebugContext get_DTDebugContext() { }
}
