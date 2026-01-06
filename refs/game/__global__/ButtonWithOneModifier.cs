public class ButtonWithOneModifier : InputBindingComposite<float> // TypeDefIndex: 7859
{
	// Fields
	[InputControl(layout = "Button")]
	public int modifier; // 0x10
	[InputControl(layout = "Button")]
	public int button; // 0x14
	[Tooltip("Obsolete please use modifiers Order. If enabled, this will override the Input Consumption setting, allowing the modifier keys to be pressed after the button and the composite will still trigger.")]
	[Obsolete("Use ModifiersOrder.Unordered with 'modifiersOrder' instead")]
	public bool overrideModifiersNeedToBePressedFirst; // 0x18
	[Tooltip("By default it follows the Input Consumption setting to determine if the modifers keys need to be pressed first.")]
	public ButtonWithOneModifier.ModifiersOrder modifiersOrder; // 0x1C

	// Methods

	// RVA: 0x278CE70 Offset: 0x278B870 VA: 0x18278CE70 Slot: 10
	public override float ReadValue(ref InputBindingCompositeContext context) { }

	// RVA: 0x278CE00 Offset: 0x278B800 VA: 0x18278CE00
	private bool ModifierIsPressed(ref InputBindingCompositeContext context) { }

	// RVA: 0x2250F60 Offset: 0x224F960 VA: 0x182250F60 Slot: 8
	public override float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	// RVA: 0x278CD80 Offset: 0x278B780 VA: 0x18278CD80 Slot: 9
	protected override void FinishSetup(ref InputBindingCompositeContext context) { }

	// RVA: 0x278CF20 Offset: 0x278B920 VA: 0x18278CF20
	public void .ctor() { }
}
