public abstract class ToolStripDropDownItem : ToolStripItem // TypeDefIndex: 5621
{
	// Fields
	internal ToolStripDropDown drop_down; // 0x180
	private static object DropDownClosedEvent; // 0x0
	private static object DropDownItemClickedEvent; // 0x8
	private static object DropDownOpenedEvent; // 0x10
	private static object DropDownOpeningEvent; // 0x18

	// Properties
	[TypeConverter(typeof(ReferenceConverter))]
	public ToolStripDropDown DropDown { get; }
	[DesignerSerializationVisibility(2)]
	public ToolStripItemCollection DropDownItems { get; }
	[Browsable(False)]
	public virtual bool HasDropDownItems { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public override bool Pressed { get; }
	protected internal virtual Point DropDownLocation { get; }

	// Methods

	// RVA: 0x222FB80 Offset: 0x222E580 VA: 0x18222FB80
	protected void .ctor(string text, Image image, EventHandler onClick, string name) { }

	// RVA: 0x222FA30 Offset: 0x222E430 VA: 0x18222FA30
	private static void .cctor() { }

	// RVA: 0x222FE20 Offset: 0x222E820 VA: 0x18222FE20
	public ToolStripDropDown get_DropDown() { }

	// RVA: 0x222FC00 Offset: 0x222E600 VA: 0x18222FC00
	public ToolStripItemCollection get_DropDownItems() { }

	// RVA: 0x222FF50 Offset: 0x222E950 VA: 0x18222FF50 Slot: 76
	public virtual bool get_HasDropDownItems() { }

	// RVA: 0x222FFC0 Offset: 0x222E9C0 VA: 0x18222FFC0 Slot: 26
	public override bool get_Pressed() { }

	// RVA: 0x222FC40 Offset: 0x222E640 VA: 0x18222FC40 Slot: 77
	protected internal virtual Point get_DropDownLocation() { }

	// RVA: 0x222EF00 Offset: 0x222D900 VA: 0x18222EF00
	public void HideDropDown() { }

	// RVA: 0x222F8F0 Offset: 0x222E2F0 VA: 0x18222F8F0
	public void ShowDropDown() { }

	// RVA: 0x222E880 Offset: 0x222D280 VA: 0x18222E880 Slot: 78
	protected virtual ToolStripDropDown CreateDefaultDropDown() { }

	// RVA: 0x222E9C0 Offset: 0x222D3C0 VA: 0x18222E9C0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x222EFF0 Offset: 0x222D9F0 VA: 0x18222EFF0 Slot: 42
	protected override void OnBoundsChanged() { }

	// RVA: 0x222F090 Offset: 0x222DA90 VA: 0x18222F090 Slot: 79
	protected internal virtual void OnDropDownClosed(EventArgs e) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 80
	protected virtual void OnDropDownHide(EventArgs e) { }

	// RVA: 0x222F160 Offset: 0x222DB60 VA: 0x18222F160 Slot: 81
	protected internal virtual void OnDropDownItemClicked(ToolStripItemClickedEventArgs e) { }

	// RVA: 0x222F240 Offset: 0x222DC40 VA: 0x18222F240 Slot: 82
	protected internal virtual void OnDropDownOpened(EventArgs e) { }

	// RVA: 0x222F320 Offset: 0x222DD20 VA: 0x18222F320 Slot: 83
	protected virtual void OnDropDownShow(EventArgs e) { }

	// RVA: 0x222F400 Offset: 0x222DE00 VA: 0x18222F400 Slot: 46
	protected override void OnFontChanged(EventArgs e) { }

	// RVA: 0x222F460 Offset: 0x222DE60 VA: 0x18222F460 Slot: 61
	protected override void OnRightToLeftChanged(EventArgs e) { }

	// RVA: 0x222F540 Offset: 0x222DF40 VA: 0x18222F540 Slot: 64
	protected internal override bool ProcessCmdKey(ref Message m, Keys keyData) { }

	// RVA: 0x222F750 Offset: 0x222E150 VA: 0x18222F750 Slot: 65
	protected internal override bool ProcessDialogKey(Keys keyData) { }

	// RVA: 0x222E8F0 Offset: 0x222D2F0 VA: 0x18222E8F0 Slot: 71
	internal override void Dismiss(ToolStripDropDownCloseReason reason) { }

	// RVA: 0x222EDE0 Offset: 0x222D7E0 VA: 0x18222EDE0 Slot: 73
	internal override void HandleClick(EventArgs e) { }

	// RVA: 0x222EE00 Offset: 0x222D800 VA: 0x18222EE00
	internal void HideDropDown(ToolStripDropDownCloseReason reason) { }

	// RVA: 0x222EDA0 Offset: 0x222D7A0 VA: 0x18222EDA0
	private void DropDown_ItemAdded(object sender, ToolStripItemEventArgs e) { }
}
