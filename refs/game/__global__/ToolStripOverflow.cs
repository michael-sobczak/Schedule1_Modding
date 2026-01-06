public class ToolStripOverflow : ToolStripDropDown, IDisposable, IComponent // TypeDefIndex: 5645
{
	// Fields
	private LayoutEngine layout_engine; // 0x368

	// Properties
	public override ToolStripItemCollection Items { get; }
	public override LayoutEngine LayoutEngine { get; }
	protected internal override ToolStripItemCollection DisplayedItems { get; }
	internal ToolStrip ParentToolStrip { get; }

	// Methods

	// RVA: 0x224A5D0 Offset: 0x2248FD0 VA: 0x18224A5D0
	public void .ctor(ToolStripItem parentItem) { }

	// RVA: 0x81F1E0 Offset: 0x81DBE0 VA: 0x18081F1E0 Slot: 199
	public override ToolStripItemCollection get_Items() { }

	// RVA: 0x224A640 Offset: 0x2249040 VA: 0x18224A640 Slot: 67
	public override LayoutEngine get_LayoutEngine() { }

	// RVA: 0x640F10 Offset: 0x63F910 VA: 0x180640F10 Slot: 204
	protected internal override ToolStripItemCollection get_DisplayedItems() { }

	// RVA: 0x2249B20 Offset: 0x2248520 VA: 0x182249B20 Slot: 82
	public override Size GetPreferredSize(Size constrainingSize) { }

	[MonoInternalNote("This should stack in rows of ~3, but for now 1 column will work.")]
	// RVA: 0x2249B30 Offset: 0x2248530 VA: 0x182249B30 Slot: 148
	protected override void OnLayout(LayoutEventArgs e) { }

	// RVA: 0x224A2E0 Offset: 0x2248CE0 VA: 0x18224A2E0 Slot: 215
	protected override void SetDisplayedItems() { }

	// RVA: 0x224A6C0 Offset: 0x22490C0 VA: 0x18224A6C0
	internal ToolStrip get_ParentToolStrip() { }
}
