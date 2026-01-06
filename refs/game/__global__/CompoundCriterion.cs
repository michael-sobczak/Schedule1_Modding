internal class CompoundCriterion : SelectionCriterion // TypeDefIndex: 16602
{
	// Fields
	internal LogicalConjunction Conjunction; // 0x18
	internal SelectionCriterion Left; // 0x20
	private SelectionCriterion _Right; // 0x28

	// Properties
	internal SelectionCriterion Right { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal SelectionCriterion get_Right() { }

	// RVA: 0x1E30520 Offset: 0x1E2EF20 VA: 0x181E30520
	internal void set_Right(SelectionCriterion value) { }

	// RVA: 0x1E30160 Offset: 0x1E2EB60 VA: 0x181E30160 Slot: 6
	internal override bool Evaluate(string filename) { }

	// RVA: 0x1E30340 Offset: 0x1E2ED40 VA: 0x181E30340 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E30270 Offset: 0x1E2EC70 VA: 0x181E30270 Slot: 7
	internal override bool Evaluate(ZipEntry entry) { }
}
