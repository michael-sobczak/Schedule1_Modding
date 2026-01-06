public class DebugUIHandlerVector2 : DebugUIHandlerWidget // TypeDefIndex: 13981
{
	// Fields
	public Text nameLabel; // 0x60
	public UIFoldout valueToggle; // 0x68
	public DebugUIHandlerIndirectFloatField fieldX; // 0x70
	public DebugUIHandlerIndirectFloatField fieldY; // 0x78
	private DebugUI.Vector2Field m_Field; // 0x80
	private DebugUIHandlerContainer m_Container; // 0x88

	// Methods

	// RVA: 0x2A51B80 Offset: 0x2A50580 VA: 0x182A51B80 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x2A51AC0 Offset: 0x2A504C0 VA: 0x182A51AC0
	private void SetValue(float v, bool x = False, bool y = False) { }

	// RVA: 0x2A51E00 Offset: 0x2A50800 VA: 0x182A51E00
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	// RVA: 0x2A519A0 Offset: 0x2A503A0 VA: 0x182A519A0 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x2A477B0 Offset: 0x2A461B0 VA: 0x182A477B0 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x2A477F0 Offset: 0x2A461F0 VA: 0x182A477F0 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x2A47780 Offset: 0x2A46180 VA: 0x182A47780 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x2A47750 Offset: 0x2A46150 VA: 0x182A47750 Slot: 8
	public override void OnAction() { }

	// RVA: 0x2A518C0 Offset: 0x2A502C0 VA: 0x182A518C0 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x14E55A0 Offset: 0x14E3FA0 VA: 0x1814E55A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2A51F40 Offset: 0x2A50940 VA: 0x182A51F40
	private float <SetWidget>b__6_0() { }

	[CompilerGenerated]
	// RVA: 0x2A51FA0 Offset: 0x2A509A0 VA: 0x182A51FA0
	private void <SetWidget>b__6_1(float x) { }

	[CompilerGenerated]
	// RVA: 0x2A52030 Offset: 0x2A50A30 VA: 0x182A52030
	private float <SetWidget>b__6_2() { }

	[CompilerGenerated]
	// RVA: 0x2A52090 Offset: 0x2A50A90 VA: 0x182A52090
	private void <SetWidget>b__6_3(float x) { }

	[CompilerGenerated]
	// RVA: 0x2A52120 Offset: 0x2A50B20 VA: 0x182A52120
	private float <SetupSettings>b__8_0() { }

	[CompilerGenerated]
	// RVA: 0x2A52140 Offset: 0x2A50B40 VA: 0x182A52140
	private float <SetupSettings>b__8_1() { }

	[CompilerGenerated]
	// RVA: 0x2A52160 Offset: 0x2A50B60 VA: 0x182A52160
	private float <SetupSettings>b__8_2() { }
}
