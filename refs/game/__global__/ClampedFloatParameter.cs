public class ClampedFloatParameter : FloatParameter // TypeDefIndex: 13913
{
	// Fields
	public float min; // 0x20
	public float max; // 0x24

	// Properties
	public override float value { get; set; }

	// Methods

	// RVA: 0x54BD70 Offset: 0x54A770 VA: 0x18054BD70 Slot: 14
	public override float get_value() { }

	// RVA: 0x2A47290 Offset: 0x2A45C90 VA: 0x182A47290 Slot: 15
	public override void set_value(float value) { }

	// RVA: 0x2A47210 Offset: 0x2A45C10 VA: 0x182A47210
	public void .ctor(float value, float min, float max, bool overrideState = False) { }
}
