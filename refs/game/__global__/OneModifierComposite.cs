public class OneModifierComposite : InputBindingComposite // TypeDefIndex: 7863
{
	// Fields
	[InputControl(layout = "Button")]
	public int modifier; // 0x10
	[InputControl]
	public int binding; // 0x14
	[Tooltip("Obsolete please use modifiers Order. If enabled, this will override the Input Consumption setting, allowing the modifier keys to be pressed after the button and the composite will still trigger.")]
	[Obsolete("Use ModifiersOrder.Unordered with 'modifiersOrder' instead")]
	public bool overrideModifiersNeedToBePressedFirst; // 0x18
	[Tooltip("By default it follows the Input Consumption setting to determine if the modifers keys need to be pressed first.")]
	public OneModifierComposite.ModifiersOrder modifiersOrder; // 0x1C
	private int m_ValueSizeInBytes; // 0x20
	private Type m_ValueType; // 0x28
	private bool m_BindingIsButton; // 0x30

	// Properties
	public override Type valueType { get; }
	public override int valueSizeInBytes { get; }

	// Methods

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 4
	public override Type get_valueType() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 5
	public override int get_valueSizeInBytes() { }

	// RVA: 0x2790240 Offset: 0x278EC40 VA: 0x182790240 Slot: 8
	public override float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	// RVA: 0x2790440 Offset: 0x278EE40 VA: 0x182790440 Slot: 6
	public override void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize) { }

	// RVA: 0x2790380 Offset: 0x278ED80 VA: 0x182790380
	private bool ModifierIsPressed(ref InputBindingCompositeContext context) { }

	// RVA: 0x27902D0 Offset: 0x278ECD0 VA: 0x1827902D0 Slot: 9
	protected override void FinishSetup(ref InputBindingCompositeContext context) { }

	// RVA: 0x27903F0 Offset: 0x278EDF0 VA: 0x1827903F0 Slot: 7
	public override object ReadValueAsObject(ref InputBindingCompositeContext context) { }

	// RVA: 0x278FDE0 Offset: 0x278E7E0 VA: 0x18278FDE0
	internal static void DetermineValueTypeAndSize(ref InputBindingCompositeContext context, int part, out Type valueType, out int valueSizeInBytes, out bool isButton) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }
}
