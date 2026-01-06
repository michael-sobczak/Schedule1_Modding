public class DTSweepContext : TriangulationContext // TypeDefIndex: 18656
{
	// Fields
	private readonly float ALPHA; // 0x40
	public AdvancingFront Front; // 0x48
	public DTSweepBasin Basin; // 0x50
	public DTSweepEdgeEvent EdgeEvent; // 0x58
	private DTSweepPointComparator _comparator; // 0x60
	[CompilerGenerated]
	private TriangulationPoint <Head>k__BackingField; // 0x68
	[CompilerGenerated]
	private TriangulationPoint <Tail>k__BackingField; // 0x70

	// Properties
	public TriangulationPoint Head { get; set; }
	public TriangulationPoint Tail { get; set; }
	public override bool IsDebugEnabled { get; set; }
	public override TriangulationAlgorithm Algorithm { get; }

	// Methods

	// RVA: 0x1E7BE50 Offset: 0x1E7A850 VA: 0x181E7BE50
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public TriangulationPoint get_Head() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_Head(TriangulationPoint value) { }

	[CompilerGenerated]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public TriangulationPoint get_Tail() { }

	[CompilerGenerated]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void set_Tail(TriangulationPoint value) { }

	// RVA: 0x495E90 Offset: 0x494890 VA: 0x180495E90 Slot: 8
	public override bool get_IsDebugEnabled() { }

	// RVA: 0x1E7BFE0 Offset: 0x1E7A9E0 VA: 0x181E7BFE0 Slot: 9
	protected override void set_IsDebugEnabled(bool value) { }

	// RVA: 0x1E7BDF0 Offset: 0x1E7A7F0 VA: 0x181E7BDF0
	public void RemoveFromList(DelaunayTriangle triangle) { }

	// RVA: 0x1E7B980 Offset: 0x1E7A380 VA: 0x181E7B980
	public void MeshClean(DelaunayTriangle triangle) { }

	// RVA: 0x1E7B870 Offset: 0x1E7A270 VA: 0x181E7B870
	private void MeshCleanReq(DelaunayTriangle triangle) { }

	// RVA: 0x1E7B1C0 Offset: 0x1E79BC0 VA: 0x181E7B1C0 Slot: 7
	public override void Clear() { }

	// RVA: 0x1E7B1A0 Offset: 0x1E79BA0 VA: 0x181E7B1A0
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x1E7B1A0 Offset: 0x1E79BA0 VA: 0x181E7B1A0
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x1E7B6F0 Offset: 0x1E7A0F0 VA: 0x181E7B6F0
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x1E7B290 Offset: 0x1E79C90 VA: 0x181E7B290
	public void CreateAdvancingFront() { }

	// RVA: 0x1E7B790 Offset: 0x1E7A190 VA: 0x181E7B790
	public void MapTriangleToNodes(DelaunayTriangle t) { }

	// RVA: 0x1E7BA00 Offset: 0x1E7A400 VA: 0x181E7BA00 Slot: 5
	public override void PrepareTriangulation(Triangulatable t) { }

	// RVA: 0x1E7B5E0 Offset: 0x1E79FE0 VA: 0x181E7B5E0
	public void FinalizeTriangulation() { }

	// RVA: 0x1E7B990 Offset: 0x1E7A390 VA: 0x181E7B990 Slot: 6
	public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 4
	public override TriangulationAlgorithm get_Algorithm() { }
}
