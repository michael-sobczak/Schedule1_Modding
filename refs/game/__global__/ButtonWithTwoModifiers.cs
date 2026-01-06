public class ButtonWithTwoModifiers : InputBindingComposite<float> // TypeDefIndex: 7861
{
	// Fields
	[InputControl(layout = "Button")]
	public int modifier1; // 0x10
	[InputControl(layout = "Button")]
	public int modifier2; // 0x14
	[InputControl(layout = "Button")]
	public int button; // 0x18
	[Tooltip("Obsolete please use modifiers Order. If enabled, this will override the Input Consumption setting, allowing the modifier keys to be pressed after the button and the composite will still trigger.")]
	[Obsolete("Use ModifiersOrder.Unordered with 'modifiersOrder' instead")]
	public bool overrideModifiersNeedToBePressedFirst; // 0x1C
	[Tooltip("By default it follows the Input Consumption setting to determine if the modifers keys need to be pressed first.")]
	public ButtonWithTwoModifiers.ModifiersOrder modifiersOrder; // 0x20

	// Methods

	// RVA: 0x278D0A0 Offset: 0x278BAA0 VA: 0x18278D0A0 Slot: 10
	public override float ReadValue(ref InputBindingCompositeContext context) { }

	// RVA: 0x278CFE0 Offset: 0x278B9E0 VA: 0x18278CFE0
	private bool ModifiersArePressed(ref InputBindingCompositeContext context) { }

	// RVA: 0x2250F60 Offset: 0x224F960 VA: 0x182250F60 Slot: 8
	public override float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	// RVA: 0x278CF60 Offset: 0x278B960 VA: 0x18278CF60 Slot: 9
	protected override void FinishSetup(ref InputBindingCompositeContext context) { }

	// RVA: 0x278D180 Offset: 0x278BB80 VA: 0x18278D180
	public void .ctor() { }
}
