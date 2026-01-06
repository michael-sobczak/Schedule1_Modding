internal class FormWindowManager : InternalWindowManager // TypeDefIndex: 5380
{
	// Fields
	private bool pending_activation; // 0x68

	// Properties
	internal override Rectangle MaximizedBounds { get; }

	// Methods

	// RVA: 0x2340DE0 Offset: 0x233F7E0 VA: 0x182340DE0
	public void .ctor(Form form) { }

	// RVA: 0x2340B50 Offset: 0x233F550 VA: 0x182340B50
	private void HandleCaptureChanged(object sender, EventArgs e) { }

	// RVA: 0x2340D50 Offset: 0x233F750 VA: 0x182340D50 Slot: 15
	public override void PointToClient(ref int x, ref int y) { }

	// RVA: 0x2340B90 Offset: 0x233F590 VA: 0x182340B90 Slot: 25
	protected override bool HandleNCLButtonDown(ref Message m) { }

	// RVA: 0x2340BA0 Offset: 0x233F5A0 VA: 0x182340BA0 Slot: 27
	protected override void HandleTitleBarDoubleClick(int x, int y) { }

	// RVA: 0x2340FA0 Offset: 0x233F9A0 VA: 0x182340FA0 Slot: 4
	internal override Rectangle get_MaximizedBounds() { }
}
