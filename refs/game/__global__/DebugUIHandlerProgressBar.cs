public class DebugUIHandlerProgressBar : DebugUIHandlerWidget // TypeDefIndex: 13972
{
	// Fields
	public Text nameLabel; // 0x60
	public Text valueLabel; // 0x68
	public RectTransform progressBarRect; // 0x70
	private DebugUI.ProgressBarValue m_Value; // 0x78
	private float m_Timer; // 0x80

	// Methods

	// RVA: 0x2A4EFA0 Offset: 0x2A4D9A0 VA: 0x182A4EFA0 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x2A4EFB0 Offset: 0x2A4D9B0 VA: 0x182A4EFB0 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x2A48010 Offset: 0x2A46A10 VA: 0x182A48010 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x2A477B0 Offset: 0x2A461B0 VA: 0x182A477B0 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x2A4F1B0 Offset: 0x2A4DBB0 VA: 0x182A4F1B0
	private void Update() { }

	// RVA: 0x2A4F050 Offset: 0x2A4DA50 VA: 0x182A4F050
	private void UpdateValue() { }

	// RVA: 0x14E55A0 Offset: 0x14E3FA0 VA: 0x1814E55A0
	public void .ctor() { }
}
