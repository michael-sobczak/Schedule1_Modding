internal class TypeCriterion : SelectionCriterion // TypeDefIndex: 16601
{
	// Fields
	private char ObjectType; // 0x18
	internal ComparisonOperator Operator; // 0x1C

	// Properties
	internal string AttributeString { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1E37830 Offset: 0x1E36230 VA: 0x181E37830
	internal string get_AttributeString() { }

	// RVA: 0x1E37880 Offset: 0x1E36280 VA: 0x181E37880
	internal void set_AttributeString(string value) { }

	// RVA: 0x1E376D0 Offset: 0x1E360D0 VA: 0x181E376D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E37640 Offset: 0x1E36040 VA: 0x181E37640 Slot: 6
	internal override bool Evaluate(string filename) { }

	// RVA: 0x1E37680 Offset: 0x1E36080 VA: 0x181E37680 Slot: 7
	internal override bool Evaluate(ZipEntry entry) { }
}
