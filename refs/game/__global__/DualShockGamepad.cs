public class DualShockGamepad : Gamepad, IDualShockHaptics, IDualMotorRumble, IHaptics // TypeDefIndex: 7579
{
	// Fields
	[CompilerGenerated]
	private ButtonControl <touchpadButton>k__BackingField; // 0x210
	[CompilerGenerated]
	private ButtonControl <optionsButton>k__BackingField; // 0x218
	[CompilerGenerated]
	private ButtonControl <shareButton>k__BackingField; // 0x220
	[CompilerGenerated]
	private ButtonControl <L1>k__BackingField; // 0x228
	[CompilerGenerated]
	private ButtonControl <R1>k__BackingField; // 0x230
	[CompilerGenerated]
	private ButtonControl <L2>k__BackingField; // 0x238
	[CompilerGenerated]
	private ButtonControl <R2>k__BackingField; // 0x240
	[CompilerGenerated]
	private ButtonControl <L3>k__BackingField; // 0x248
	[CompilerGenerated]
	private ButtonControl <R3>k__BackingField; // 0x250
	[CompilerGenerated]
	private static DualShockGamepad <current>k__BackingField; // 0x0
	[CompilerGenerated]
	private HID.HIDDeviceDescriptor <hidDescriptor>k__BackingField; // 0x258

	// Properties
	[InputControl]
	[InputControl(name = "buttonWest", displayName = "Square", shortDisplayName = "Square")]
	[InputControl(name = "buttonNorth", displayName = "Triangle", shortDisplayName = "Triangle")]
	[InputControl(name = "buttonEast", displayName = "Circle", shortDisplayName = "Circle")]
	[InputControl(name = "buttonSouth", displayName = "Cross", shortDisplayName = "Cross")]
	public ButtonControl touchpadButton { get; set; }
	[InputControl(name = "start", displayName = "Options")]
	public ButtonControl optionsButton { get; set; }
	[InputControl(name = "select", displayName = "Share")]
	public ButtonControl shareButton { get; set; }
	[InputControl(name = "leftShoulder", displayName = "L1", shortDisplayName = "L1")]
	public ButtonControl L1 { get; set; }
	[InputControl(name = "rightShoulder", displayName = "R1", shortDisplayName = "R1")]
	public ButtonControl R1 { get; set; }
	[InputControl(name = "leftTrigger", displayName = "L2", shortDisplayName = "L2")]
	public ButtonControl L2 { get; set; }
	[InputControl(name = "rightTrigger", displayName = "R2", shortDisplayName = "R2")]
	public ButtonControl R2 { get; set; }
	[InputControl(name = "leftStickPress", displayName = "L3", shortDisplayName = "L3")]
	public ButtonControl L3 { get; set; }
	[InputControl(name = "rightStickPress", displayName = "R3", shortDisplayName = "R3")]
	public ButtonControl R3 { get; set; }
	public static DualShockGamepad current { get; set; }
	internal HID.HIDDeviceDescriptor hidDescriptor { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80
	public ButtonControl get_touchpadButton() { }

	[CompilerGenerated]
	// RVA: 0x9CAFC0 Offset: 0x9C99C0 VA: 0x1809CAFC0
	protected void set_touchpadButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70
	public ButtonControl get_optionsButton() { }

	[CompilerGenerated]
	// RVA: 0x6413A0 Offset: 0x63FDA0 VA: 0x1806413A0
	protected void set_optionsButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x9CAEF0 Offset: 0x9C98F0 VA: 0x1809CAEF0
	public ButtonControl get_shareButton() { }

	[CompilerGenerated]
	// RVA: 0xA2FF00 Offset: 0xA2E900 VA: 0x180A2FF00
	protected void set_shareButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x76CFB0 Offset: 0x76B9B0 VA: 0x18076CFB0
	public ButtonControl get_L1() { }

	[CompilerGenerated]
	// RVA: 0x76CFC0 Offset: 0x76B9C0 VA: 0x18076CFC0
	protected void set_L1(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x640F00 Offset: 0x63F900 VA: 0x180640F00
	public ButtonControl get_R1() { }

	[CompilerGenerated]
	// RVA: 0x6415D0 Offset: 0x63FFD0 VA: 0x1806415D0
	protected void set_R1(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x8A7560 Offset: 0x8A5F60 VA: 0x1808A7560
	public ButtonControl get_L2() { }

	[CompilerGenerated]
	// RVA: 0x8A78E0 Offset: 0x8A62E0 VA: 0x1808A78E0
	protected void set_L2(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x640C70 Offset: 0x63F670 VA: 0x180640C70
	public ButtonControl get_R2() { }

	[CompilerGenerated]
	// RVA: 0x860C80 Offset: 0x85F680 VA: 0x180860C80
	protected void set_R2(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x8793A0 Offset: 0x877DA0 VA: 0x1808793A0
	public ButtonControl get_L3() { }

	[CompilerGenerated]
	// RVA: 0x9D8790 Offset: 0x9D7190 VA: 0x1809D8790
	protected void set_L3(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x640BD0 Offset: 0x63F5D0 VA: 0x180640BD0
	public ButtonControl get_R3() { }

	[CompilerGenerated]
	// RVA: 0x6412E0 Offset: 0x63FCE0 VA: 0x1806412E0
	protected void set_R3(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x2857780 Offset: 0x2856180 VA: 0x182857780
	public static DualShockGamepad get_current() { }

	[CompilerGenerated]
	// RVA: 0x28577F0 Offset: 0x28561F0 VA: 0x1828577F0
	private static void set_current(DualShockGamepad value) { }

	[CompilerGenerated]
	// RVA: 0x28577C0 Offset: 0x28561C0 VA: 0x1828577C0
	internal HID.HIDDeviceDescriptor get_hidDescriptor() { }

	[CompilerGenerated]
	// RVA: 0x2857850 Offset: 0x2856250 VA: 0x182857850
	private void set_hidDescriptor(HID.HIDDeviceDescriptor value) { }

	// RVA: 0x2857690 Offset: 0x2856090 VA: 0x182857690 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x28576F0 Offset: 0x28560F0 VA: 0x1828576F0 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x28574D0 Offset: 0x2855ED0 VA: 0x1828574D0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 31
	public virtual void SetLightBarColor(Color color) { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
