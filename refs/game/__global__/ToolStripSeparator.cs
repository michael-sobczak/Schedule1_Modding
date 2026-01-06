public class ToolStripSeparator : ToolStripItem // TypeDefIndex: 5652
{
	// Properties
	[EditorBrowsable(1)]
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public override Image BackgroundImage { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	[EditorBrowsable(1)]
	public override ImageLayout BackgroundImageLayout { get; }
	public override bool CanSelect { get; }
	[DesignerSerializationVisibility(0)]
	[EditorBrowsable(1)]
	[Browsable(False)]
	public override bool Enabled { get; set; }
	[Browsable(False)]
	[EditorBrowsable(1)]
	[DesignerSerializationVisibility(0)]
	public override Font Font { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	[EditorBrowsable(1)]
	public override Image Image { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	[EditorBrowsable(1)]
	public override string Text { get; set; }
	[Browsable(False)]
	[EditorBrowsable(1)]
	[DefaultValue(1)]
	public override ToolStripTextDirection TextDirection { get; }
	protected internal override Padding DefaultMargin { get; }
	protected override Size DefaultSize { get; }
	internal override ToolStripTextDirection DefaultTextDirection { get; }

	// Methods

	// RVA: 0x2253C30 Offset: 0x2252630 VA: 0x182253C30
	public void .ctor() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 15
	public override Image get_BackgroundImage() { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30 Slot: 16
	public override ImageLayout get_BackgroundImageLayout() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 18
	public override bool get_CanSelect() { }

	// RVA: 0x2249400 Offset: 0x2247E00 VA: 0x182249400 Slot: 20
	public override bool get_Enabled() { }

	// RVA: 0x2249800 Offset: 0x2248200 VA: 0x182249800 Slot: 21
	public override void set_Enabled(bool value) { }

	// RVA: 0x2253CB0 Offset: 0x22526B0 VA: 0x182253CB0 Slot: 22
	public override Font get_Font() { }

	// RVA: 0x2253CC0 Offset: 0x22526C0 VA: 0x182253CC0 Slot: 24
	public override Image get_Image() { }

	// RVA: 0x2253CE0 Offset: 0x22526E0 VA: 0x182253CE0 Slot: 25
	public override void set_Image(Image value) { }

	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910 Slot: 31
	public override string get_Text() { }

	// RVA: 0x2253CF0 Offset: 0x22526F0 VA: 0x182253CF0 Slot: 32
	public override void set_Text(string value) { }

	// RVA: 0x2253CD0 Offset: 0x22526D0 VA: 0x182253CD0 Slot: 34
	public override ToolStripTextDirection get_TextDirection() { }

	// RVA: 0x2239370 Offset: 0x2237D70 VA: 0x182239370 Slot: 37
	protected internal override Padding get_DefaultMargin() { }

	// RVA: 0x2253C80 Offset: 0x2252680 VA: 0x182253C80 Slot: 39
	protected override Size get_DefaultSize() { }

	// RVA: 0x2253AA0 Offset: 0x22524A0 VA: 0x182253AA0 Slot: 40
	public override Size GetPreferredSize(Size constrainingSize) { }

	[EditorBrowsable(1)]
	// RVA: 0x1AF9390 Offset: 0x1AF7D90 VA: 0x181AF9390 Slot: 46
	protected override void OnFontChanged(EventArgs e) { }

	// RVA: 0x2253AD0 Offset: 0x22524D0 VA: 0x182253AD0 Slot: 57
	protected override void OnPaint(PaintEventArgs e) { }

	// RVA: 0x2249090 Offset: 0x2247A90 VA: 0x182249090 Slot: 67
	protected internal override void SetBounds(Rectangle rect) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 70
	internal override ToolStripTextDirection get_DefaultTextDirection() { }
}
