internal class TimeCriterion : SelectionCriterion // TypeDefIndex: 16599
{
	// Fields
	internal ComparisonOperator Operator; // 0x18
	internal WhichTime Which; // 0x1C
	internal DateTime Time; // 0x20

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1E372C0 Offset: 0x1E35CC0 VA: 0x181E372C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E37180 Offset: 0x1E35B80 VA: 0x181E37180 Slot: 6
	internal override bool Evaluate(string filename) { }

	// RVA: 0x1E37460 Offset: 0x1E35E60 VA: 0x181E37460
	private bool _Evaluate(DateTime x) { }

	// RVA: 0x1E370D0 Offset: 0x1E35AD0 VA: 0x181E370D0 Slot: 7
	internal override bool Evaluate(ZipEntry entry) { }
}
