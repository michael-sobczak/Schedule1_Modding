public class CheckpointInstance // TypeDefIndex: 1279
{
	// Fields
	public const float MIN_ACTIVATION_DISTANCE = 50;
	public CheckpointManager.ECheckpointLocation Location; // 0x10
	public int Members; // 0x14
	public int StartTime; // 0x18
	public int EndTime; // 0x1C
	[Range(1, 10)]
	public int IntensityRequirement; // 0x20
	public bool OnlyIfCurfewEnabled; // 0x24
	private RoadCheckpoint checkPoint; // 0x28
	[CompilerGenerated]
	private RoadCheckpoint <activeCheckpoint>k__BackingField; // 0x30

	// Properties
	public RoadCheckpoint activeCheckpoint { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public RoadCheckpoint get_activeCheckpoint() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_activeCheckpoint(RoadCheckpoint value) { }

	// RVA: 0x60C6D0 Offset: 0x60B0D0 VA: 0x18060C6D0
	public void Evaluate() { }

	// RVA: 0x60C440 Offset: 0x60AE40 VA: 0x18060C440
	public void EnableCheckpoint() { }

	// RVA: 0x60C250 Offset: 0x60AC50 VA: 0x18060C250
	private bool DistanceRequirementsMet() { }

	// RVA: 0x60C8C0 Offset: 0x60B2C0 VA: 0x18060C8C0
	private void MinPass() { }

	// RVA: 0x60C030 Offset: 0x60AA30 VA: 0x18060C030
	public void DisableCheckpoint() { }

	// RVA: 0x60C970 Offset: 0x60B370 VA: 0x18060C970
	public void .ctor() { }
}
