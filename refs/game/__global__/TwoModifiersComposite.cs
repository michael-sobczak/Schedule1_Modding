public class TwoModifiersComposite : InputBindingComposite // TypeDefIndex: 7865
{
	// Fields
	[InputControl(layout = "Button")]
	public int modifier1; // 0x10
	[InputControl(layout = "Button")]
	public int modifier2; // 0x14
	[InputControl]
	public int binding; // 0x18
	[Obsolete("Use ModifiersOrder.Unordered with 'modifiersOrder' instead")]
	[Tooltip("Obsolete please use modifiers Order. If enabled, this will override the Input Consumption setting, allowing the modifier keys to be pressed after the button and the composite will still trigger.")]
	public bool overrideModifiersNeedToBePressedFirst; // 0x1C
	[Tooltip("By default it follows the Input Consumption setting to determine if the modifers keys need to be pressed first.")]
	public TwoModifiersComposite.ModifiersOrder modifiersOrder; // 0x20
	private int m_ValueSizeInBytes; // 0x24
	private Type m_ValueType; // 0x28
	private bool m_BindingIsButton; // 0x30

	// Properties
	public override Type valueType { get; }
	public override int valueSizeInBytes { get; }

	// Methods

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 4
	public override Type get_valueType() { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40 Slot: 5
	public override int get_valueSizeInBytes() { }

	// RVA: 0x2794D70 Offset: 0x2793770 VA: 0x182794D70 Slot: 8
	public override float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	// RVA: 0x2794F90 Offset: 0x2793990 VA: 0x182794F90 Slot: 6
	public override void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize) { }

	// RVA: 0x2794E70 Offset: 0x2793870 VA: 0x182794E70
	private bool ModifiersArePressed(ref InputBindingCompositeContext context) { }

	// RVA: 0x2794DC0 Offset: 0x27937C0 VA: 0x182794DC0 Slot: 9
	protected override void FinishSetup(ref InputBindingCompositeContext context) { }

	// RVA: 0x2794F30 Offset: 0x2793930 VA: 0x182794F30 Slot: 7
	public override object ReadValueAsObject(ref InputBindingCompositeContext context) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }
}
