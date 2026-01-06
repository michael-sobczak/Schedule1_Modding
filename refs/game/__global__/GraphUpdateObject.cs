public class GraphUpdateObject // TypeDefIndex: 13120
{
	// Fields
	public Bounds bounds; // 0x10
	public bool updatePhysics; // 0x28
	public bool resetPenaltyOnPhysics; // 0x29
	public bool updateErosion; // 0x2A
	public NNConstraint nnConstraint; // 0x30
	public int addPenalty; // 0x38
	public bool modifyWalkability; // 0x3C
	public bool setWalkability; // 0x3D
	public bool modifyTag; // 0x3E
	public int setTag; // 0x40
	public bool trackChangedNodes; // 0x44
	public List<GraphNode> changedNodes; // 0x48
	private List<uint> backupData; // 0x50
	private List<Int3> backupPositionData; // 0x58
	public GraphUpdateShape shape; // 0x60
	internal int internalStage; // 0x68
	internal const int STAGE_CREATED = -1;
	internal const int STAGE_PENDING = -2;
	internal const int STAGE_ABORTED = -3;
	internal const int STAGE_APPLIED = 0;

	// Properties
	[Obsolete("Not necessary anymore")]
	public bool requiresFloodFill { set; }
	public GraphUpdateStage stage { get; }

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void set_requiresFloodFill(bool value) { }

	// RVA: 0xB0BCE0 Offset: 0xB0A6E0 VA: 0x180B0BCE0
	public GraphUpdateStage get_stage() { }

	// RVA: 0xB0B980 Offset: 0xB0A380 VA: 0x180B0B980 Slot: 4
	public virtual void WillUpdateNode(GraphNode node) { }

	// RVA: 0xB0B5B0 Offset: 0xB09FB0 VA: 0x180B0B5B0 Slot: 5
	public virtual void RevertFromBackup() { }

	// RVA: 0xB0B4E0 Offset: 0xB09EE0 VA: 0x180B0B4E0 Slot: 6
	public virtual void Apply(GraphNode node) { }

	// RVA: 0xB0BC40 Offset: 0xB0A640 VA: 0x180B0BC40
	public void .ctor() { }

	// RVA: 0xB0BC80 Offset: 0xB0A680 VA: 0x180B0BC80
	public void .ctor(Bounds b) { }
}
