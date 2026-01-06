public class AxisComposite : InputBindingComposite<float> // TypeDefIndex: 7857
{
	// Fields
	[InputControl(layout = "Axis")]
	public int negative; // 0x10
	[InputControl(layout = "Axis")]
	public int positive; // 0x14
	[Tooltip("Value to return when the negative side is fully actuated.")]
	public float minValue; // 0x18
	[Tooltip("Value to return when the positive side is fully actuated.")]
	public float maxValue; // 0x1C
	[Tooltip("If both the positive and negative side are actuated, decides what value to return. 'Neither' (default) means that the resulting value is the midpoint between min and max. 'Positive' means that max will be returned. 'Negative' means that min will be returned.")]
	public AxisComposite.WhichSideWins whichSideWins; // 0x20

	// Properties
	public float midPoint { get; }

	// Methods

	// RVA: 0x278CC90 Offset: 0x278B690 VA: 0x18278CC90
	public float get_midPoint() { }

	// RVA: 0x278CB20 Offset: 0x278B520 VA: 0x18278CB20 Slot: 10
	public override float ReadValue(ref InputBindingCompositeContext context) { }

	// RVA: 0x278CA80 Offset: 0x278B480 VA: 0x18278CA80 Slot: 8
	public override float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	// RVA: 0x278CC40 Offset: 0x278B640 VA: 0x18278CC40
	public void .ctor() { }
}
