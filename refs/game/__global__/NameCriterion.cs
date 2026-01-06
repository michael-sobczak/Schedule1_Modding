internal class NameCriterion : SelectionCriterion // TypeDefIndex: 16600
{
	// Fields
	private Regex _re; // 0x18
	private string _regexString; // 0x20
	internal ComparisonOperator Operator; // 0x28
	private string _MatchingFileSpec; // 0x30

	// Properties
	internal virtual string MatchingFileSpec { set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1E343C0 Offset: 0x1E32DC0 VA: 0x181E343C0 Slot: 8
	internal virtual void set_MatchingFileSpec(string value) { }

	// RVA: 0x1E341E0 Offset: 0x1E32BE0 VA: 0x181E341E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E341D0 Offset: 0x1E32BD0 VA: 0x181E341D0 Slot: 6
	internal override bool Evaluate(string filename) { }

	// RVA: 0x1E34320 Offset: 0x1E32D20 VA: 0x181E34320
	private bool _Evaluate(string fullpath) { }

	// RVA: 0x1E34150 Offset: 0x1E32B50 VA: 0x181E34150 Slot: 7
	internal override bool Evaluate(ZipEntry entry) { }
}
