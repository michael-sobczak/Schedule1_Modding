public class DebugUIHandlerFoldout : DebugUIHandlerWidget // TypeDefIndex: 13958
{
	// Fields
	public Text nameLabel; // 0x60
	public UIFoldout valueToggle; // 0x68
	private DebugUI.Foldout m_Field; // 0x70
	private DebugUIHandlerContainer m_Container; // 0x78
	private const float k_FoldoutXOffset = 215;
	private const float k_XOffset = 230;

	// Methods

	// RVA: 0x2A4C690 Offset: 0x2A4B090 VA: 0x182A4C690 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x2A4C580 Offset: 0x2A4AF80 VA: 0x182A4C580 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x2A477B0 Offset: 0x2A461B0 VA: 0x182A477B0 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x2A4C540 Offset: 0x2A4AF40 VA: 0x182A4C540 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x2A4C500 Offset: 0x2A4AF00 VA: 0x182A4C500 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x2A4C4C0 Offset: 0x2A4AEC0 VA: 0x182A4C4C0 Slot: 8
	public override void OnAction() { }

	// RVA: 0x2A4CB70 Offset: 0x2A4B570 VA: 0x182A4CB70
	private void UpdateValue() { }

	// RVA: 0x2A4C3F0 Offset: 0x2A4ADF0 VA: 0x182A4C3F0 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x14E55A0 Offset: 0x14E3FA0 VA: 0x1814E55A0
	public void .ctor() { }
}
