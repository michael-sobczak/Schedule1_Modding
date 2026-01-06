public class ToolStripProfessionalRenderer : ToolStripRenderer // TypeDefIndex: 5648
{
	// Fields
	private ProfessionalColorTable color_table; // 0x18
	private bool rounded_edges; // 0x20

	// Properties
	public ProfessionalColorTable ColorTable { get; }
	public bool RoundedEdges { get; }

	// Methods

	// RVA: 0x2250540 Offset: 0x224EF40 VA: 0x182250540
	public void .ctor() { }

	// RVA: 0x22505E0 Offset: 0x224EFE0 VA: 0x1822505E0
	public void .ctor(ProfessionalColorTable professionalColorTable) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public ProfessionalColorTable get_ColorTable() { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_RoundedEdges() { }

	// RVA: 0x224A770 Offset: 0x2249170 VA: 0x18224A770 Slot: 4
	protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e) { }

	// RVA: 0x224A780 Offset: 0x2249180 VA: 0x18224A780 Slot: 5
	protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e) { }

	// RVA: 0x224B880 Offset: 0x224A280 VA: 0x18224B880 Slot: 6
	protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e) { }

	// RVA: 0x224C050 Offset: 0x224AA50 VA: 0x18224C050 Slot: 7
	protected override void OnRenderGrip(ToolStripGripRenderEventArgs e) { }

	// RVA: 0x224C7B0 Offset: 0x224B1B0 VA: 0x18224C7B0 Slot: 8
	protected override void OnRenderImageMargin(ToolStripRenderEventArgs e) { }

	// RVA: 0x224CB30 Offset: 0x224B530 VA: 0x18224CB30 Slot: 10
	protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e) { }

	// RVA: 0x224D060 Offset: 0x224BA60 VA: 0x18224D060 Slot: 11
	protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e) { }

	// RVA: 0x224D070 Offset: 0x224BA70 VA: 0x18224D070 Slot: 12
	protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e) { }

	// RVA: 0x224D080 Offset: 0x224BA80 VA: 0x18224D080 Slot: 13
	protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e) { }

	// RVA: 0x224DDC0 Offset: 0x224C7C0 VA: 0x18224DDC0 Slot: 14
	protected override void OnRenderOverflowButtonBackground(ToolStripItemRenderEventArgs e) { }

	// RVA: 0x224E4E0 Offset: 0x224CEE0 VA: 0x18224E4E0 Slot: 15
	protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e) { }

	// RVA: 0x224EB10 Offset: 0x224D510 VA: 0x18224EB10 Slot: 16
	protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e) { }

	// RVA: 0x224F330 Offset: 0x224DD30 VA: 0x18224F330 Slot: 17
	protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }

	// RVA: 0x22500B0 Offset: 0x224EAB0 VA: 0x1822500B0
	private static void PaintOverflowArrow(ToolStripItemRenderEventArgs e, Rectangle paint_here) { }
}
