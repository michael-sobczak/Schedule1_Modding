public class DebugUIHandlerVector4 : DebugUIHandlerWidget // TypeDefIndex: 13983
{
	// Fields
	public Text nameLabel; // 0x60
	public UIFoldout valueToggle; // 0x68
	public DebugUIHandlerIndirectFloatField fieldX; // 0x70
	public DebugUIHandlerIndirectFloatField fieldY; // 0x78
	public DebugUIHandlerIndirectFloatField fieldZ; // 0x80
	public DebugUIHandlerIndirectFloatField fieldW; // 0x88
	private DebugUI.Vector4Field m_Field; // 0x90
	private DebugUIHandlerContainer m_Container; // 0x98

	// Methods

	// RVA: 0x2A52FB0 Offset: 0x2A519B0 VA: 0x182A52FB0 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x2A52EA0 Offset: 0x2A518A0 VA: 0x182A52EA0
	private void SetValue(float v, bool x = False, bool y = False, bool z = False, bool w = False) { }

	// RVA: 0x2A53420 Offset: 0x2A51E20 VA: 0x182A53420
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	// RVA: 0x2A52D80 Offset: 0x2A51780 VA: 0x182A52D80 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x2A477B0 Offset: 0x2A461B0 VA: 0x182A477B0 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x2A477F0 Offset: 0x2A461F0 VA: 0x182A477F0 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x2A47780 Offset: 0x2A46180 VA: 0x182A47780 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x2A47750 Offset: 0x2A46150 VA: 0x182A47750 Slot: 8
	public override void OnAction() { }

	// RVA: 0x2A52CA0 Offset: 0x2A516A0 VA: 0x182A52CA0 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x14E55A0 Offset: 0x14E3FA0 VA: 0x1814E55A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2A53560 Offset: 0x2A51F60 VA: 0x182A53560
	private float <SetWidget>b__8_0() { }

	[CompilerGenerated]
	// RVA: 0x2A535C0 Offset: 0x2A51FC0 VA: 0x182A535C0
	private void <SetWidget>b__8_1(float x) { }

	[CompilerGenerated]
	// RVA: 0x2A53680 Offset: 0x2A52080 VA: 0x182A53680
	private float <SetWidget>b__8_2() { }

	[CompilerGenerated]
	// RVA: 0x2A536E0 Offset: 0x2A520E0 VA: 0x182A536E0
	private void <SetWidget>b__8_3(float x) { }

	[CompilerGenerated]
	// RVA: 0x2A537A0 Offset: 0x2A521A0 VA: 0x182A537A0
	private float <SetWidget>b__8_4() { }

	[CompilerGenerated]
	// RVA: 0x2A53800 Offset: 0x2A52200 VA: 0x182A53800
	private void <SetWidget>b__8_5(float x) { }

	[CompilerGenerated]
	// RVA: 0x2A538C0 Offset: 0x2A522C0 VA: 0x182A538C0
	private float <SetWidget>b__8_6() { }

	[CompilerGenerated]
	// RVA: 0x2A53920 Offset: 0x2A52320 VA: 0x182A53920
	private void <SetWidget>b__8_7(float x) { }

	[CompilerGenerated]
	// RVA: 0x2A539E0 Offset: 0x2A523E0 VA: 0x182A539E0
	private float <SetupSettings>b__10_0() { }

	[CompilerGenerated]
	// RVA: 0x2A53A00 Offset: 0x2A52400 VA: 0x182A53A00
	private float <SetupSettings>b__10_1() { }

	[CompilerGenerated]
	// RVA: 0x2A53A20 Offset: 0x2A52420 VA: 0x182A53A20
	private float <SetupSettings>b__10_2() { }
}
