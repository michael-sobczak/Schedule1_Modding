public class FloatRangeParameter : VolumeParameter<Vector2> // TypeDefIndex: 13915
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

	// RVA: 0x2A53AB0 Offset: 0x2A524B0 VA: 0x182A53AB0
	public void .ctor(Vector2 value, float min, float max, bool overrideState = False) { }

	// RVA: 0x29C2480 Offset: 0x29C0E80 VA: 0x1829C2480 Slot: 16
	public override void Interp(Vector2 from, Vector2 to, float t) { }
}
