public class DeltaControl : Vector2Control // TypeDefIndex: 7772
{
	// Fields
	[CompilerGenerated]
	private AxisControl <up>k__BackingField; // 0x120
	[CompilerGenerated]
	private AxisControl <down>k__BackingField; // 0x128
	[CompilerGenerated]
	private AxisControl <left>k__BackingField; // 0x130
	[CompilerGenerated]
	private AxisControl <right>k__BackingField; // 0x138

	// Properties
	[InputControl(useStateFrom = "y", parameters = "clamp=1,clampMin=0,clampMax=3.402823E+38", synthetic = True, displayName = "Up")]
	[Preserve]
	public AxisControl up { get; set; }
	[Preserve]
	[InputControl(useStateFrom = "y", parameters = "clamp=1,clampMin=-3.402823E+38,clampMax=0,invert", synthetic = True, displayName = "Down")]
	public AxisControl down { get; set; }
	[Preserve]
	[InputControl(useStateFrom = "x", parameters = "clamp=1,clampMin=-3.402823E+38,clampMax=0,invert", synthetic = True, displayName = "Left")]
	public AxisControl left { get; set; }
	[Preserve]
	[InputControl(useStateFrom = "x", parameters = "clamp=1,clampMin=0,clampMax=3.402823E+38", synthetic = True, displayName = "Right")]
	public AxisControl right { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public AxisControl get_up() { }

	[CompilerGenerated]
	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640
	public void set_up(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public AxisControl get_down() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0
	public void set_down(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x65D840 Offset: 0x65C240 VA: 0x18065D840
	public AxisControl get_left() { }

	[CompilerGenerated]
	// RVA: 0x65D8D0 Offset: 0x65C2D0 VA: 0x18065D8D0
	public void set_left(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850
	public AxisControl get_right() { }

	[CompilerGenerated]
	// RVA: 0x65D8F0 Offset: 0x65C2F0 VA: 0x18065D8F0
	public void set_right(AxisControl value) { }

	// RVA: 0x2779950 Offset: 0x2778350 VA: 0x182779950 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x2779A70 Offset: 0x2778470 VA: 0x182779A70
	public void .ctor() { }
}
