public class ClampedIntParameter : IntParameter // TypeDefIndex: 13905
{
	// Fields
	public int min; // 0x20
	public int max; // 0x24

	// Properties
	public override int value { get; set; }

	// Methods

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90 Slot: 14
	public override int get_value() { }

	// RVA: 0x2A47320 Offset: 0x2A45D20 VA: 0x182A47320 Slot: 15
	public override void set_value(int value) { }

	// RVA: 0x2A472B0 Offset: 0x2A45CB0 VA: 0x182A472B0
	public void .ctor(int value, int min, int max, bool overrideState = False) { }
}
