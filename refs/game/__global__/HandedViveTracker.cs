public class HandedViveTracker : ViveTracker // TypeDefIndex: 7240
{
	// Fields
	[CompilerGenerated]
	private AxisControl <grip>k__BackingField; // 0x1C0
	[CompilerGenerated]
	private ButtonControl <gripPressed>k__BackingField; // 0x1C8
	[CompilerGenerated]
	private ButtonControl <primary>k__BackingField; // 0x1D0
	[CompilerGenerated]
	private ButtonControl <trackpadPressed>k__BackingField; // 0x1D8
	[CompilerGenerated]
	private ButtonControl <triggerPressed>k__BackingField; // 0x1E0

	// Properties
	[InputControl]
	public AxisControl grip { get; set; }
	[InputControl]
	public ButtonControl gripPressed { get; set; }
	[InputControl]
	public ButtonControl primary { get; set; }
	[InputControl(aliases = new[] { "JoystickOrPadPressed" })]
	public ButtonControl trackpadPressed { get; set; }
	[InputControl]
	public ButtonControl triggerPressed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x67E980 Offset: 0x67D380 VA: 0x18067E980
	public AxisControl get_grip() { }

	[CompilerGenerated]
	// RVA: 0x67EAE0 Offset: 0x67D4E0 VA: 0x18067EAE0
	protected void set_grip(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x726430 Offset: 0x724E30 VA: 0x180726430
	public ButtonControl get_gripPressed() { }

	[CompilerGenerated]
	// RVA: 0x7264F0 Offset: 0x724EF0 VA: 0x1807264F0
	protected void set_gripPressed(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x68E6E0 Offset: 0x68D0E0 VA: 0x18068E6E0
	public ButtonControl get_primary() { }

	[CompilerGenerated]
	// RVA: 0x68E700 Offset: 0x68D100 VA: 0x18068E700
	protected void set_primary(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6855A0 Offset: 0x683FA0 VA: 0x1806855A0
	public ButtonControl get_trackpadPressed() { }

	[CompilerGenerated]
	// RVA: 0x6855B0 Offset: 0x683FB0 VA: 0x1806855B0
	protected void set_trackpadPressed(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x688E20 Offset: 0x687820 VA: 0x180688E20
	public ButtonControl get_triggerPressed() { }

	[CompilerGenerated]
	// RVA: 0x718BD0 Offset: 0x7175D0 VA: 0x180718BD0
	protected void set_triggerPressed(ButtonControl value) { }

	// RVA: 0x2749E90 Offset: 0x2748890 VA: 0x182749E90 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x274A080 Offset: 0x2748A80 VA: 0x18274A080
	public void .ctor() { }
}
