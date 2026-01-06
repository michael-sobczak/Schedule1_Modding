public class DebugUIHandlerBitField : DebugUIHandlerWidget // TypeDefIndex: 13944
{
	// Fields
	public Text nameLabel; // 0x60
	public UIFoldout valueToggle; // 0x68
	public List<DebugUIHandlerIndirectToggle> toggles; // 0x70
	private DebugUI.BitField m_Field; // 0x78
	private DebugUIHandlerContainer m_Container; // 0x80

	// Methods

	// RVA: 0x2A47C10 Offset: 0x2A46610 VA: 0x182A47C10 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x2A475C0 Offset: 0x2A45FC0 VA: 0x182A475C0
	private bool GetValue(int index) { }

	// RVA: 0x2A47940 Offset: 0x2A46340 VA: 0x182A47940
	private void SetValue(int index, bool value) { }

	// RVA: 0x2A47820 Offset: 0x2A46220 VA: 0x182A47820 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x2A477B0 Offset: 0x2A461B0 VA: 0x182A477B0 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x2A477F0 Offset: 0x2A461F0 VA: 0x182A477F0 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x2A47780 Offset: 0x2A46180 VA: 0x182A47780 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x2A47750 Offset: 0x2A46150 VA: 0x182A47750 Slot: 8
	public override void OnAction() { }

	// RVA: 0x2A47670 Offset: 0x2A46070 VA: 0x182A47670 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x14E55A0 Offset: 0x14E3FA0 VA: 0x1814E55A0
	public void .ctor() { }
}
