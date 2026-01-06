public class FlowLayoutSettings : LayoutSettings // TypeDefIndex: 5368
{
	// Fields
	private FlowDirection flow_direction; // 0x10
	private bool wrap_contents; // 0x14
	private Dictionary<object, bool> flow_breaks; // 0x18
	private Control owner; // 0x20

	// Properties
	[DefaultValue(0)]
	public FlowDirection FlowDirection { get; }
	[DefaultValue(True)]
	public bool WrapContents { get; }

	// Methods

	// RVA: 0x2326340 Offset: 0x2324D40 VA: 0x182326340
	internal void .ctor() { }

	// RVA: 0x2326350 Offset: 0x2324D50 VA: 0x182326350
	internal void .ctor(Control owner) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public FlowDirection get_FlowDirection() { }

	// RVA: 0x60D730 Offset: 0x60C130 VA: 0x18060D730
	public bool get_WrapContents() { }

	// RVA: 0x23262D0 Offset: 0x2324CD0 VA: 0x1823262D0
	public bool GetFlowBreak(object child) { }
}
