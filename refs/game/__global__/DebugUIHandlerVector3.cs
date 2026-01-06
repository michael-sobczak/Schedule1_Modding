public class DebugUIHandlerVector3 : DebugUIHandlerWidget // TypeDefIndex: 13982
{
	// Fields
	public Text nameLabel; // 0x60
	public UIFoldout valueToggle; // 0x68
	public DebugUIHandlerIndirectFloatField fieldX; // 0x70
	public DebugUIHandlerIndirectFloatField fieldY; // 0x78
	public DebugUIHandlerIndirectFloatField fieldZ; // 0x80
	private DebugUI.Vector3Field m_Field; // 0x88
	private DebugUIHandlerContainer m_Container; // 0x90

	// Methods

	// RVA: 0x2A52470 Offset: 0x2A50E70 VA: 0x182A52470 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x2A52390 Offset: 0x2A50D90 VA: 0x182A52390
	private void SetValue(float v, bool x = False, bool y = False, bool z = False) { }

	// RVA: 0x2A527F0 Offset: 0x2A511F0 VA: 0x182A527F0
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	// RVA: 0x2A52270 Offset: 0x2A50C70 VA: 0x182A52270 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x2A477B0 Offset: 0x2A461B0 VA: 0x182A477B0 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x2A477F0 Offset: 0x2A461F0 VA: 0x182A477F0 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x2A47780 Offset: 0x2A46180 VA: 0x182A47780 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x2A47750 Offset: 0x2A46150 VA: 0x182A47750 Slot: 8
	public override void OnAction() { }

	// RVA: 0x2A52190 Offset: 0x2A50B90 VA: 0x182A52190 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x14E55A0 Offset: 0x14E3FA0 VA: 0x1814E55A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2A52930 Offset: 0x2A51330 VA: 0x182A52930
	private float <SetWidget>b__7_0() { }

	[CompilerGenerated]
	// RVA: 0x2A52990 Offset: 0x2A51390 VA: 0x182A52990
	private void <SetWidget>b__7_1(float v) { }

	[CompilerGenerated]
	// RVA: 0x2A52A30 Offset: 0x2A51430 VA: 0x182A52A30
	private float <SetWidget>b__7_2() { }

	[CompilerGenerated]
	// RVA: 0x2A52A90 Offset: 0x2A51490 VA: 0x182A52A90
	private void <SetWidget>b__7_3(float v) { }

	[CompilerGenerated]
	// RVA: 0x2A52B30 Offset: 0x2A51530 VA: 0x182A52B30
	private float <SetWidget>b__7_4() { }

	[CompilerGenerated]
	// RVA: 0x2A52B90 Offset: 0x2A51590 VA: 0x182A52B90
	private void <SetWidget>b__7_5(float v) { }

	[CompilerGenerated]
	// RVA: 0x2A52C30 Offset: 0x2A51630 VA: 0x182A52C30
	private float <SetupSettings>b__9_0() { }

	[CompilerGenerated]
	// RVA: 0x2A52C50 Offset: 0x2A51650 VA: 0x182A52C50
	private float <SetupSettings>b__9_1() { }

	[CompilerGenerated]
	// RVA: 0x2A52C70 Offset: 0x2A51670 VA: 0x182A52C70
	private float <SetupSettings>b__9_2() { }
}
