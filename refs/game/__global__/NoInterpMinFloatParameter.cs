public class NoInterpMinFloatParameter : VolumeParameter<float> // TypeDefIndex: 13910
{
	// Fields
	public float min; // 0x20

	// Properties
	public override float value { get; set; }

	// Methods

	// RVA: 0x54BD70 Offset: 0x54A770 VA: 0x18054BD70 Slot: 14
	public override float get_value() { }

	// RVA: 0x2A57550 Offset: 0x2A55F50 VA: 0x182A57550 Slot: 15
	public override void set_value(float value) { }

	// RVA: 0x2A57B00 Offset: 0x2A56500 VA: 0x182A57B00
	public void .ctor(float value, float min, bool overrideState = False) { }
}
