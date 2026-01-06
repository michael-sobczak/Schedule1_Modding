public class Vector2Composite : InputBindingComposite<Vector2> // TypeDefIndex: 7867
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
	[Obsolete("Use Mode.DigitalNormalized with 'mode' instead")]
	public bool normalize; // 0x20
	public Vector2Composite.Mode mode; // 0x24

	// Methods

	// RVA: 0x2796AD0 Offset: 0x27954D0 VA: 0x182796AD0 Slot: 10
	public override Vector2 ReadValue(ref InputBindingCompositeContext context) { }

	// RVA: 0x2796A40 Offset: 0x2795440 VA: 0x182796A40 Slot: 8
	public override float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	// RVA: 0x2796C50 Offset: 0x2795650 VA: 0x182796C50
	public void .ctor() { }
}
