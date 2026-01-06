public class OculusTrackingReference : TrackedDevice // TypeDefIndex: 7244
{
	// Fields
	[CompilerGenerated]
	private IntegerControl <trackingState>k__BackingField; // 0x1B0
	[CompilerGenerated]
	private ButtonControl <isTracked>k__BackingField; // 0x1B8

	// Properties
	[InputControl(aliases = new[] { "trackingReferenceTrackingState" })]
	public IntegerControl trackingState { get; set; }
	[InputControl(aliases = new[] { "trackingReferenceIsTracked" })]
	public ButtonControl isTracked { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xBF2630 Offset: 0xBF1030 VA: 0x180BF2630
	public IntegerControl get_trackingState() { }

	[CompilerGenerated]
	// RVA: 0xBF26E0 Offset: 0xBF10E0 VA: 0x180BF26E0
	protected void set_trackingState(IntegerControl value) { }

	[CompilerGenerated]
	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970
	public ButtonControl get_isTracked() { }

	[CompilerGenerated]
	// RVA: 0x67EAC0 Offset: 0x67D4C0 VA: 0x18067EAC0
	protected void set_isTracked(ButtonControl value) { }

	// RVA: 0x275AF60 Offset: 0x2759960 VA: 0x18275AF60 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x274A080 Offset: 0x2748A80 VA: 0x18274A080
	public void .ctor() { }
}
