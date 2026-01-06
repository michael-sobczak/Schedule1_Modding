public class AxisDeadzoneProcessor : InputProcessor<float> // TypeDefIndex: 7722
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Properties
	private float minOrDefault { get; }
	private float maxOrDefault { get; }

	// Methods

	// RVA: 0x286A780 Offset: 0x2869180 VA: 0x18286A780
	private float get_minOrDefault() { }

	// RVA: 0x286A710 Offset: 0x2869110 VA: 0x18286A710
	private float get_maxOrDefault() { }

	// RVA: 0x286A440 Offset: 0x2868E40 VA: 0x18286A440 Slot: 7
	public override float Process(float value, InputControl control) { }

	// RVA: 0x286A590 Offset: 0x2868F90 VA: 0x18286A590 Slot: 3
	public override string ToString() { }

	// RVA: 0x286A6D0 Offset: 0x28690D0 VA: 0x18286A6D0
	public void .ctor() { }
}
