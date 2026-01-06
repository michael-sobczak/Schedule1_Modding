public class NoInterpMaxIntParameter : VolumeParameter<int> // TypeDefIndex: 13904
{
	// Fields
	public int max; // 0x20

	// Properties
	public override int value { get; set; }

	// Methods

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90 Slot: 14
	public override int get_value() { }

	// RVA: 0x2A563E0 Offset: 0x2A54DE0 VA: 0x182A563E0 Slot: 15
	public override void set_value(int value) { }

	// RVA: 0x2A57A90 Offset: 0x2A56490 VA: 0x182A57A90
	public void .ctor(int value, int max, bool overrideState = False) { }
}
