public class NoInterpMaxFloatParameter : VolumeParameter<float> // TypeDefIndex: 13912
{
	// Fields
	public float max; // 0x20

	// Properties
	public override float value { get; set; }

	// Methods

	// RVA: 0x54BD70 Offset: 0x54A770 VA: 0x18054BD70 Slot: 14
	public override float get_value() { }

	// RVA: 0x2A56360 Offset: 0x2A54D60 VA: 0x182A56360 Slot: 15
	public override void set_value(float value) { }

	// RVA: 0x2A57A20 Offset: 0x2A56420 VA: 0x182A57A20
	public void .ctor(float value, float max, bool overrideState = False) { }
}
