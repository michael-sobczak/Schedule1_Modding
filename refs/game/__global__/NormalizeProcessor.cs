public class NormalizeProcessor : InputProcessor<float> // TypeDefIndex: 7729
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14
	public float zero; // 0x18

	// Methods

	// RVA: 0x287CE70 Offset: 0x287B870 VA: 0x18287CE70 Slot: 7
	public override float Process(float value, InputControl control) { }

	// RVA: 0x287CD80 Offset: 0x287B780 VA: 0x18287CD80
	public static float Normalize(float value, float min, float max, float zero) { }

	// RVA: 0x287CD30 Offset: 0x287B730 VA: 0x18287CD30
	internal static float Denormalize(float value, float min, float max, float zero) { }

	// RVA: 0x287CF60 Offset: 0x287B960 VA: 0x18287CF60 Slot: 3
	public override string ToString() { }

	// RVA: 0x287D020 Offset: 0x287BA20 VA: 0x18287D020
	public void .ctor() { }
}
