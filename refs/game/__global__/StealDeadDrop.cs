public class StealDeadDrop : CartelActivity // TypeDefIndex: 2073
{
	// Fields
	public const int MIN_TIME_SINCE_CONTENTS_CHANGED = 360;
	public ItemDefinition[] ItemsToLeave; // 0x40

	// Methods

	// RVA: 0x7F1280 Offset: 0x7EFC80 VA: 0x1807F1280 Slot: 8
	public override bool IsRegionValidForActivity(EMapRegion region) { }

	// RVA: 0x7F0CE0 Offset: 0x7EF6E0 VA: 0x1807F0CE0 Slot: 4
	public override void Activate(EMapRegion region) { }

	// RVA: 0x7F0E60 Offset: 0x7EF860 VA: 0x1807F0E60
	private static DeadDrop GetRandomDropToStealFrom(EMapRegion region) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
