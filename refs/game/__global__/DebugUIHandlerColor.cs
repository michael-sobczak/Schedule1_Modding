public class DebugUIHandlerColor : DebugUIHandlerWidget // TypeDefIndex: 13950
{
	// Fields
	public Text nameLabel; // 0x60
	public UIFoldout valueToggle; // 0x68
	public Image colorImage; // 0x70
	public DebugUIHandlerIndirectFloatField fieldR; // 0x78
	public DebugUIHandlerIndirectFloatField fieldG; // 0x80
	public DebugUIHandlerIndirectFloatField fieldB; // 0x88
	public DebugUIHandlerIndirectFloatField fieldA; // 0x90
	private DebugUI.ColorField m_Field; // 0x98
	private DebugUIHandlerContainer m_Container; // 0xA0

	// Methods

	// RVA: 0x2A4A4D0 Offset: 0x2A48ED0 VA: 0x182A4A4D0 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x2A4A3C0 Offset: 0x2A48DC0 VA: 0x182A4A3C0
	private void SetValue(float x, bool r = False, bool g = False, bool b = False, bool a = False) { }

	// RVA: 0x2A4A9C0 Offset: 0x2A493C0 VA: 0x182A4A9C0
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	// RVA: 0x2A4A2A0 Offset: 0x2A48CA0 VA: 0x182A4A2A0 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x2A477B0 Offset: 0x2A461B0 VA: 0x182A477B0 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x2A477F0 Offset: 0x2A461F0 VA: 0x182A477F0 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x2A47780 Offset: 0x2A46180 VA: 0x182A47780 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x2A47750 Offset: 0x2A46150 VA: 0x182A47750 Slot: 8
	public override void OnAction() { }

	// RVA: 0x2A4B030 Offset: 0x2A49A30 VA: 0x182A4B030
	internal void UpdateColor() { }

	// RVA: 0x2A4A1C0 Offset: 0x2A48BC0 VA: 0x182A4A1C0 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x14E55A0 Offset: 0x14E3FA0 VA: 0x1814E55A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2A4AB00 Offset: 0x2A49500 VA: 0x182A4AB00
	private float <SetWidget>b__9_0() { }

	[CompilerGenerated]
	// RVA: 0x2A4AB60 Offset: 0x2A49560 VA: 0x182A4AB60
	private void <SetWidget>b__9_1(float x) { }

	[CompilerGenerated]
	// RVA: 0x2A4AC30 Offset: 0x2A49630 VA: 0x182A4AC30
	private float <SetWidget>b__9_2() { }

	[CompilerGenerated]
	// RVA: 0x2A4AC90 Offset: 0x2A49690 VA: 0x182A4AC90
	private void <SetWidget>b__9_3(float x) { }

	[CompilerGenerated]
	// RVA: 0x2A4AD60 Offset: 0x2A49760 VA: 0x182A4AD60
	private float <SetWidget>b__9_4() { }

	[CompilerGenerated]
	// RVA: 0x2A4ADC0 Offset: 0x2A497C0 VA: 0x182A4ADC0
	private void <SetWidget>b__9_5(float x) { }

	[CompilerGenerated]
	// RVA: 0x2A4AE90 Offset: 0x2A49890 VA: 0x182A4AE90
	private float <SetWidget>b__9_6() { }

	[CompilerGenerated]
	// RVA: 0x2A4AEF0 Offset: 0x2A498F0 VA: 0x182A4AEF0
	private void <SetWidget>b__9_7(float x) { }

	[CompilerGenerated]
	// RVA: 0x2A4AFC0 Offset: 0x2A499C0 VA: 0x182A4AFC0
	private float <SetupSettings>b__11_0() { }

	[CompilerGenerated]
	// RVA: 0x2A4AFE0 Offset: 0x2A499E0 VA: 0x182A4AFE0
	private float <SetupSettings>b__11_1() { }

	[CompilerGenerated]
	// RVA: 0x2A4B000 Offset: 0x2A49A00 VA: 0x182A4B000
	private float <SetupSettings>b__11_2() { }
}
