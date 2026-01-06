public class RadioButton : BaseBoolField, IGroupBoxOption // TypeDefIndex: 6392
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10
	public static readonly string checkmarkBackgroundUssClassName; // 0x18
	public static readonly string checkmarkUssClassName; // 0x20
	public static readonly string textUssClassName; // 0x28
	private VisualElement m_CheckmarkBackground; // 0x468

	// Properties
	public override bool value { get; set; }

	// Methods

	// RVA: 0x2E6A970 Offset: 0x2E69370 VA: 0x182E6A970 Slot: 107
	public override bool get_value() { }

	// RVA: 0x2E6A9B0 Offset: 0x2E693B0 VA: 0x182E6A9B0 Slot: 108
	public override void set_value(bool value) { }

	// RVA: 0x2E6A690 Offset: 0x2E69090 VA: 0x182E6A690
	public void .ctor() { }

	// RVA: 0x2E6A6A0 Offset: 0x2E690A0 VA: 0x182E6A6A0
	public void .ctor(string label) { }

	// RVA: 0x2E6A160 Offset: 0x2E68B60 VA: 0x182E6A160
	private void OnOptionAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x2E6A1C0 Offset: 0x2E68BC0 VA: 0x182E6A1C0
	private void OnOptionDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x2E6A0E0 Offset: 0x2E68AE0 VA: 0x182E6A0E0 Slot: 119
	protected override void InitLabel() { }

	// RVA: 0x2E6A240 Offset: 0x2E68C40 VA: 0x182E6A240 Slot: 120
	protected override void ToggleValue() { }

	// RVA: 0x2E6A290 Offset: 0x2E68C90 VA: 0x182E6A290 Slot: 121
	private void UnityEngine.UIElements.IGroupBoxOption.SetSelected(bool selected) { }

	// RVA: 0x2E6A220 Offset: 0x2E68C20 VA: 0x182E6A220 Slot: 118
	public override void SetValueWithoutNotify(bool newValue) { }

	// RVA: 0x2E6A2B0 Offset: 0x2E68CB0 VA: 0x182E6A2B0
	private void UpdateCheckmark() { }

	// RVA: 0x2E6A3D0 Offset: 0x2E68DD0 VA: 0x182E6A3D0 Slot: 117
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x2E6A470 Offset: 0x2E68E70 VA: 0x182E6A470
	private static void .cctor() { }
}
