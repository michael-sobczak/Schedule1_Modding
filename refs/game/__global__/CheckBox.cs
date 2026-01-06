public class CheckBox : ButtonBase // TypeDefIndex: 5259
{
	// Fields
	internal Appearance appearance; // 0x230
	internal bool auto_check; // 0x234
	internal ContentAlignment check_alignment; // 0x238
	internal CheckState check_state; // 0x23C
	internal bool three_state; // 0x240
	private static object AppearanceChangedEvent; // 0x0
	private static object CheckedChangedEvent; // 0x8
	private static object CheckStateChangedEvent; // 0x10
	private EventHandler DoubleClick; // 0x248

	// Properties
	[Localizable(True)]
	[DefaultValue(0)]
	public Appearance Appearance { get; }
	[DefaultValue(16)]
	[Bindable(True)]
	[Localizable(True)]
	public ContentAlignment CheckAlign { get; }
	[Bindable(True)]
	[RefreshProperties(1)]
	[DefaultValue(False)]
	[SettingsBindable(True)]
	public bool Checked { get; set; }
	[Bindable(True)]
	[RefreshProperties(1)]
	[DefaultValue(0)]
	public CheckState CheckState { get; set; }
	[Localizable(True)]
	[DefaultValue(16)]
	public override ContentAlignment TextAlign { get; set; }
	[DefaultValue(False)]
	public bool ThreeState { get; }
	protected override CreateParams CreateParams { get; }
	protected override Size DefaultSize { get; }

	// Methods

	// RVA: 0x21C9B60 Offset: 0x21C8560 VA: 0x1821C9B60
	public void .ctor() { }

	// RVA: 0x21C9A60 Offset: 0x21C8460 VA: 0x1821C9A60
	private static void .cctor() { }

	// RVA: 0x21C9BD0 Offset: 0x21C85D0 VA: 0x1821C9BD0
	public void add_CheckedChanged(EventHandler value) { }

	// RVA: 0x21C9CC0 Offset: 0x21C86C0 VA: 0x1821C9CC0
	public void remove_CheckedChanged(EventHandler value) { }

	// RVA: 0x21C9250 Offset: 0x21C7C50 VA: 0x1821C9250 Slot: 195
	internal override void Draw(PaintEventArgs pe) { }

	// RVA: 0x21C9520 Offset: 0x21C7F20 VA: 0x1821C9520 Slot: 33
	internal override Size GetPreferredSizeCore(Size proposedSize) { }

	// RVA: 0x21C9610 Offset: 0x21C8010 VA: 0x1821C9610 Slot: 196
	internal override void HaveDoubleClick() { }

	// RVA: 0x21C8B30 Offset: 0x21C7530 VA: 0x1821C8B30
	public Appearance get_Appearance() { }

	// RVA: 0x21C9C60 Offset: 0x21C8660 VA: 0x1821C9C60
	public ContentAlignment get_CheckAlign() { }

	// RVA: 0x21C9C80 Offset: 0x21C8680 VA: 0x1821C9C80
	public bool get_Checked() { }

	// RVA: 0x21C9E40 Offset: 0x21C8840 VA: 0x1821C9E40
	public void set_Checked(bool value) { }

	// RVA: 0x21C9C70 Offset: 0x21C8670 VA: 0x1821C9C70
	public CheckState get_CheckState() { }

	// RVA: 0x21C9D50 Offset: 0x21C8750 VA: 0x1821C9D50
	public void set_CheckState(CheckState value) { }

	// RVA: 0x21C7BF0 Offset: 0x21C65F0 VA: 0x1821C7BF0 Slot: 193
	public override ContentAlignment get_TextAlign() { }

	// RVA: 0x21C9EF0 Offset: 0x21C88F0 VA: 0x1821C9EF0 Slot: 194
	public override void set_TextAlign(ContentAlignment value) { }

	// RVA: 0xA316F0 Offset: 0xA300F0 VA: 0x180A316F0
	public bool get_ThreeState() { }

	// RVA: 0x21C7A40 Offset: 0x21C6440 VA: 0x1821C7A40 Slot: 72
	protected override CreateParams get_CreateParams() { }

	// RVA: 0x21C9C90 Offset: 0x21C8690 VA: 0x1821C9C90 Slot: 76
	protected override Size get_DefaultSize() { }

	// RVA: 0x21C99E0 Offset: 0x21C83E0 VA: 0x1821C99E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21C9780 Offset: 0x21C8180 VA: 0x1821C9780 Slot: 197
	protected virtual void OnCheckedChanged(EventArgs e) { }

	// RVA: 0x21C96A0 Offset: 0x21C80A0 VA: 0x1821C96A0 Slot: 198
	protected virtual void OnCheckStateChanged(EventArgs e) { }

	// RVA: 0x21C9860 Offset: 0x21C8260 VA: 0x1821C9860 Slot: 121
	protected override void OnClick(EventArgs e) { }

	// RVA: 0x21C98D0 Offset: 0x21C82D0 VA: 0x1821C98D0 Slot: 140
	protected override void OnHandleCreated(EventArgs e) { }

	// RVA: 0x21C7290 Offset: 0x21C5C90 VA: 0x1821C7290 Slot: 145
	protected override void OnKeyDown(KeyEventArgs e) { }

	// RVA: 0x21C88D0 Offset: 0x21C72D0 VA: 0x1821C88D0 Slot: 160
	protected override void OnMouseUp(MouseEventArgs mevent) { }

	// RVA: 0x21C98E0 Offset: 0x21C82E0 VA: 0x1821C98E0 Slot: 104
	protected override bool ProcessMnemonic(char charCode) { }
}
