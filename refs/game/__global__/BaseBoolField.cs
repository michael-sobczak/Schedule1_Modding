public abstract class BaseBoolField : BaseField<bool> // TypeDefIndex: 6210
{
	// Fields
	protected Label m_Label; // 0x448
	protected readonly VisualElement m_CheckMark; // 0x450
	internal Clickable m_Clickable; // 0x458
	private string m_OriginalText; // 0x460

	// Properties
	public string text { get; set; }

	// Methods

	// RVA: 0x2DA9E10 Offset: 0x2DA8810 VA: 0x182DA9E10
	public void .ctor(string label) { }

	// RVA: 0x2DA9900 Offset: 0x2DA8300 VA: 0x182DA9900
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x2DAA140 Offset: 0x2DA8B40 VA: 0x182DAA140
	public string get_text() { }

	// RVA: 0x2DAA170 Offset: 0x2DA8B70 VA: 0x182DAA170
	public void set_text(string value) { }

	// RVA: 0x2DA9670 Offset: 0x2DA8070 VA: 0x182DA9670 Slot: 119
	protected virtual void InitLabel() { }

	// RVA: 0x2DA9A30 Offset: 0x2DA8430 VA: 0x182DA9A30 Slot: 118
	public override void SetValueWithoutNotify(bool newValue) { }

	// RVA: 0x2DA9710 Offset: 0x2DA8110 VA: 0x182DA9710
	private void OnClickEvent(EventBase evt) { }

	// RVA: 0x2DA9B20 Offset: 0x2DA8520 VA: 0x182DA9B20 Slot: 120
	protected virtual void ToggleValue() { }

	// RVA: 0x2DA9C50 Offset: 0x2DA8650 VA: 0x182DA9C50 Slot: 117
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x2DA9940 Offset: 0x2DA8340 VA: 0x182DA9940 Slot: 115
	internal override void RegisterEditingCallbacks() { }

	// RVA: 0x2DA9B60 Offset: 0x2DA8560 VA: 0x182DA9B60 Slot: 116
	internal override void UnregisterEditingCallbacks() { }
}
