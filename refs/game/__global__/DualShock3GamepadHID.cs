public class DualShock3GamepadHID : DualShockGamepad // TypeDefIndex: 7587
{
	// Fields
	[CompilerGenerated]
	private ButtonControl <leftTriggerButton>k__BackingField; // 0x288
	[CompilerGenerated]
	private ButtonControl <rightTriggerButton>k__BackingField; // 0x290
	[CompilerGenerated]
	private ButtonControl <playStationButton>k__BackingField; // 0x298

	// Properties
	public ButtonControl leftTriggerButton { get; set; }
	public ButtonControl rightTriggerButton { get; set; }
	public ButtonControl playStationButton { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x860AD0 Offset: 0x85F4D0 VA: 0x180860AD0
	public ButtonControl get_leftTriggerButton() { }

	[CompilerGenerated]
	// RVA: 0xA141E0 Offset: 0xA12BE0 VA: 0x180A141E0
	protected void set_leftTriggerButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x860A10 Offset: 0x85F410 VA: 0x180860A10
	public ButtonControl get_rightTriggerButton() { }

	[CompilerGenerated]
	// RVA: 0xA14220 Offset: 0xA12C20 VA: 0x180A14220
	protected void set_rightTriggerButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x8793C0 Offset: 0x877DC0 VA: 0x1808793C0
	public ButtonControl get_playStationButton() { }

	[CompilerGenerated]
	// RVA: 0x879420 Offset: 0x877E20 VA: 0x180879420
	protected void set_playStationButton(ButtonControl value) { }

	// RVA: 0x28561D0 Offset: 0x2854BD0 VA: 0x1828561D0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
