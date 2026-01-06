public class CreatePathLineRenderer : CGModule // TypeDefIndex: 10718
{
	// Fields
	[InputSlotInfo(new[] { typeof(CGPath) }, DisplayName = "Rasterized Path")]
	[HideInInspector]
	public CGModuleInputSlot InPath; // 0xC0
	private LineRenderer mLineRenderer; // 0xC8

	// Properties
	public LineRenderer LineRenderer { get; }

	// Methods

	// RVA: 0x523A90 Offset: 0x522490 VA: 0x180523A90
	public LineRenderer get_LineRenderer() { }

	// RVA: 0x5239A0 Offset: 0x5223A0 VA: 0x1805239A0 Slot: 13
	public override void Reset() { }

	// RVA: 0x523870 Offset: 0x522270 VA: 0x180523870 Slot: 14
	public override void Refresh() { }

	// RVA: 0x523A20 Offset: 0x522420 VA: 0x180523A20
	public void .ctor() { }
}
