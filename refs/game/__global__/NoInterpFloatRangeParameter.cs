public class NoInterpFloatRangeParameter : VolumeParameter<Vector2> // TypeDefIndex: 13916
{
	// Fields
	public float min; // 0x20
	public float max; // 0x24

	// Properties
	public override Vector2 value { get; set; }

	// Methods

	// RVA: 0x13C4BB0 Offset: 0x13C35B0 VA: 0x1813C4BB0 Slot: 14
	public override Vector2 get_value() { }

	// RVA: 0x2A53B30 Offset: 0x2A52530 VA: 0x182A53B30 Slot: 15
	public override void set_value(Vector2 value) { }

	// RVA: 0x2A57940 Offset: 0x2A56340 VA: 0x182A57940
	public void .ctor(Vector2 value, float min, float max, bool overrideState = False) { }
}
