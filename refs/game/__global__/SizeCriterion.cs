internal class SizeCriterion : SelectionCriterion // TypeDefIndex: 16598
{
	// Fields
	internal ComparisonOperator Operator; // 0x18
	internal long Size; // 0x20

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1E36EC0 Offset: 0x1E358C0 VA: 0x181E36EC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E36E10 Offset: 0x1E35810 VA: 0x181E36E10 Slot: 6
	internal override bool Evaluate(string filename) { }

	// RVA: 0x1E36FF0 Offset: 0x1E359F0 VA: 0x181E36FF0
	private bool _Evaluate(long Length) { }

	// RVA: 0x1E36E90 Offset: 0x1E35890 VA: 0x181E36E90 Slot: 7
	internal override bool Evaluate(ZipEntry entry) { }
}
