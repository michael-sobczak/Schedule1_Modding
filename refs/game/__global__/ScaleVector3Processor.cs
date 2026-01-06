public class ScaleVector3Processor : InputProcessor<Vector3> // TypeDefIndex: 7734
{
	// Fields
	[Tooltip("Scale factor to multiply the incoming Vector3's X component by.")]
	public float x; // 0x10
	[Tooltip("Scale factor to multiply the incoming Vector3's Y component by.")]
	public float y; // 0x14
	[Tooltip("Scale factor to multiply the incoming Vector3's Z component by.")]
	public float z; // 0x18

	// Methods

	// RVA: 0x287FAB0 Offset: 0x287E4B0 VA: 0x18287FAB0 Slot: 7
	public override Vector3 Process(Vector3 value, InputControl control) { }

	// RVA: 0x287FAF0 Offset: 0x287E4F0 VA: 0x18287FAF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x287FBB0 Offset: 0x287E5B0 VA: 0x18287FBB0
	public void .ctor() { }
}
