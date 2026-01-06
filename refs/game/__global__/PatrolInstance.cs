public class PatrolInstance // TypeDefIndex: 1306
{
	// Fields
	public FootPatrolRoute Route; // 0x10
	public int Members; // 0x18
	public int StartTime; // 0x1C
	public int EndTime; // 0x20
	[Range(1, 10)]
	public int IntensityRequirement; // 0x24
	public bool OnlyIfCurfewEnabled; // 0x28
	[CompilerGenerated]
	private PatrolGroup <ActiveGroup>k__BackingField; // 0x30

	// Properties
	public PatrolGroup ActiveGroup { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public PatrolGroup get_ActiveGroup() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_ActiveGroup(PatrolGroup value) { }

	// RVA: 0x61CFF0 Offset: 0x61B9F0 VA: 0x18061CFF0
	public void Evaluate() { }

	// RVA: 0x61D2A0 Offset: 0x61BCA0 VA: 0x18061D2A0
	public void StartPatrol() { }

	// RVA: 0x61D0F0 Offset: 0x61BAF0 VA: 0x18061D0F0
	private void MinPass() { }

	// RVA: 0x61CEC0 Offset: 0x61B8C0 VA: 0x18061CEC0
	public void EndPatrol() { }

	// RVA: 0x61D4E0 Offset: 0x61BEE0 VA: 0x18061D4E0
	public void .ctor() { }
}
