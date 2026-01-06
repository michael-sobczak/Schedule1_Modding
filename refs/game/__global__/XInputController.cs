public class XInputController : Gamepad // TypeDefIndex: 7491
{
	// Fields
	[CompilerGenerated]
	private ButtonControl <menu>k__BackingField; // 0x210
	[CompilerGenerated]
	private ButtonControl <view>k__BackingField; // 0x218
	private bool m_HaveParsedCapabilities; // 0x220
	private XInputController.DeviceSubType m_SubType; // 0x224
	private XInputController.DeviceFlags m_Flags; // 0x228

	// Properties
	[InputControl(name = "buttonSouth", displayName = "A")]
	[InputControl(name = "select", displayName = "View", alias = "view")]
	[InputControl(name = "buttonEast", displayName = "B")]
	[InputControl(name = "rightShoulder", displayName = "Right Bumper", shortDisplayName = "RB")]
	[InputControl(name = "start", displayName = "Menu", alias = "menu")]
	[InputControl(name = "buttonWest", displayName = "X")]
	[InputControl(name = "buttonNorth", displayName = "Y")]
	[InputControl(name = "leftShoulder", displayName = "Left Bumper", shortDisplayName = "LB")]
	[InputControl(name = "leftTrigger", shortDisplayName = "LT")]
	[InputControl(name = "rightTrigger", shortDisplayName = "RT")]
	public ButtonControl menu { get; set; }
	public ButtonControl view { get; set; }
	public XInputController.DeviceSubType subType { get; }
	public XInputController.DeviceFlags flags { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80
	public ButtonControl get_menu() { }

	[CompilerGenerated]
	// RVA: 0x9CAFC0 Offset: 0x9C99C0 VA: 0x1809CAFC0
	protected void set_menu(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70
	public ButtonControl get_view() { }

	[CompilerGenerated]
	// RVA: 0x6413A0 Offset: 0x63FDA0 VA: 0x1806413A0
	protected void set_view(ButtonControl value) { }

	// RVA: 0x283B150 Offset: 0x2839B50 VA: 0x18283B150
	public XInputController.DeviceSubType get_subType() { }

	// RVA: 0x283B110 Offset: 0x2839B10 VA: 0x18283B110
	public XInputController.DeviceFlags get_flags() { }

	// RVA: 0x283B030 Offset: 0x2839A30 VA: 0x18283B030 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x283B080 Offset: 0x2839A80 VA: 0x18283B080
	private void ParseCapabilities() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
