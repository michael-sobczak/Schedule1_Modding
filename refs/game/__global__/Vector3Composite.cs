public class Vector3Composite : InputBindingComposite<Vector3> // TypeDefIndex: 7869
{
	// Fields
	[InputControl(layout = "Axis")]
	public int up; // 0x10
	[InputControl(layout = "Axis")]
	public int down; // 0x14
	[InputControl(layout = "Axis")]
	public int left; // 0x18
	[InputControl(layout = "Axis")]
	public int right; // 0x1C
	[InputControl(layout = "Axis")]
	public int forward; // 0x20
	[InputControl(layout = "Axis")]
	public int backward; // 0x24
	public Vector3Composite.Mode mode; // 0x28

	// Methods

	// RVA: 0x2796D50 Offset: 0x2795750 VA: 0x182796D50 Slot: 10
	public override Vector3 ReadValue(ref InputBindingCompositeContext context) { }

	// RVA: 0x2796C90 Offset: 0x2795690 VA: 0x182796C90 Slot: 8
	public override float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	// RVA: 0x2797050 Offset: 0x2795A50 VA: 0x182797050
	public void .ctor() { }
}
