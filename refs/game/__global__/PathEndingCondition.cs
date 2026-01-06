public abstract class PathEndingCondition // TypeDefIndex: 13323
{
	// Fields
	protected Path path; // 0x10

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0xB8A4D0 Offset: 0xB88ED0 VA: 0x180B8A4D0
	public void .ctor(Path p) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool TargetFound(PathNode node);
}
