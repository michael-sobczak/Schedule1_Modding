public class OculusHMDExtended : OculusHMD // TypeDefIndex: 7246
{
	// Fields
	[CompilerGenerated]
	private ButtonControl <back>k__BackingField; // 0x248
	[CompilerGenerated]
	private Vector2Control <touchpad>k__BackingField; // 0x250

	// Properties
	[InputControl]
	public ButtonControl back { get; set; }
	[InputControl]
	public Vector2Control touchpad { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8793A0 Offset: 0x877DA0 VA: 0x1808793A0
	public ButtonControl get_back() { }

	[CompilerGenerated]
	// RVA: 0x9D8790 Offset: 0x9D7190 VA: 0x1809D8790
	protected void set_back(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x640BD0 Offset: 0x63F5D0 VA: 0x180640BD0
	public Vector2Control get_touchpad() { }

	[CompilerGenerated]
	// RVA: 0x6412E0 Offset: 0x63FCE0 VA: 0x1806412E0
	protected void set_touchpad(Vector2Control value) { }

	// RVA: 0x275A670 Offset: 0x2759070 VA: 0x18275A670 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x2749890 Offset: 0x2748290 VA: 0x182749890
	public void .ctor() { }
}
