public class DebugRasterizedPath : CGModule // TypeDefIndex: 10719
{
	// Fields
	[HideInInspector]
	[InputSlotInfo(new[] { typeof(CGPath) }, DisplayName = "Rasterized Path")]
	public CGModuleInputSlot InPath; // 0xC0
	[Tooltip("Display the normal at each one of the path's points")]
	public bool ShowNormals; // 0xC8
	[Tooltip("Display the orientation at each one of the path's points")]
	public bool ShowOrientation; // 0xC9

	// Methods

	// RVA: 0x523B30 Offset: 0x522530 VA: 0x180523B30 Slot: 13
	public override void Reset() { }

	// RVA: 0x523B50 Offset: 0x522550 VA: 0x180523B50
	public void .ctor() { }
}
