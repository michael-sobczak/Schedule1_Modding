public class NoInterpMinIntParameter : VolumeParameter<int> // TypeDefIndex: 13902
{
	// Fields
	public int min; // 0x20

	// Properties
	public override int value { get; set; }

	// Methods

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90 Slot: 14
	public override int get_value() { }

	// RVA: 0x2A57560 Offset: 0x2A55F60 VA: 0x182A57560 Slot: 15
	public override void set_value(int value) { }

	// RVA: 0x2A57B70 Offset: 0x2A56570 VA: 0x182A57B70
	public void .ctor(int value, int min, bool overrideState = False) { }
}
