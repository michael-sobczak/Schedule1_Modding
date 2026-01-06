public class RadioButtonGroup : BaseField<int>, IGroupBox // TypeDefIndex: 6395
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string containerUssClassName; // 0x8
	private List<RadioButton> m_RadioButtons; // 0x448
	private EventCallback<ChangeEvent<bool>> m_RadioButtonValueChangedCallback; // 0x450
	private VisualElement m_RadioButtonContainer; // 0x458

	// Properties
	public IEnumerable<string> choices { set; }
	public override VisualElement contentContainer { get; }

	// Methods

	// RVA: 0x2E73890 Offset: 0x2E72290 VA: 0x182E73890
	public void set_choices(IEnumerable<string> value) { }

	// RVA: 0x2E73870 Offset: 0x2E72270 VA: 0x182E73870 Slot: 99
	public override VisualElement get_contentContainer() { }

	// RVA: 0x2E73860 Offset: 0x2E72260 VA: 0x182E73860
	public void .ctor() { }

	// RVA: 0x2E735E0 Offset: 0x2E71FE0 VA: 0x182E735E0
	public void .ctor(string label, List<string> radioButtonChoices) { }

	// RVA: 0x2E72EA0 Offset: 0x2E718A0 VA: 0x182E72EA0
	private void RadioButtonValueChangedCallback(ChangeEvent<bool> evt) { }

	// RVA: 0x2E72FB0 Offset: 0x2E719B0 VA: 0x182E72FB0 Slot: 118
	public override void SetValueWithoutNotify(int newValue) { }

	// RVA: 0x2E73340 Offset: 0x2E71D40 VA: 0x182E73340
	private void UpdateRadioButtons() { }

	// RVA: 0x2E73000 Offset: 0x2E71A00 VA: 0x182E73000 Slot: 119
	private void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	// RVA: 0x2E731C0 Offset: 0x2E71BC0 VA: 0x182E731C0 Slot: 120
	private void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	// RVA: 0x2E73520 Offset: 0x2E71F20 VA: 0x182E73520
	private static void .cctor() { }
}
