public class WMRHMD : XRHMD // TypeDefIndex: 7250
{
	// Fields
	[CompilerGenerated]
	private ButtonControl <userPresence>k__BackingField; // 0x1E0

	// Properties
	[InputControl(name = "devicePosition", layout = "Vector3", aliases = new[] { "HeadPosition" })]
	[InputControl(name = "deviceRotation", layout = "Quaternion", aliases = new[] { "HeadRotation" })]
	[InputControl]
	public ButtonControl userPresence { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x688E20 Offset: 0x687820 VA: 0x180688E20
	public ButtonControl get_userPresence() { }

	[CompilerGenerated]
	// RVA: 0x718BD0 Offset: 0x7175D0 VA: 0x180718BD0
	protected void set_userPresence(ButtonControl value) { }

	// RVA: 0x27627C0 Offset: 0x27611C0 VA: 0x1827627C0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x2749890 Offset: 0x2748290 VA: 0x182749890
	public void .ctor() { }
}
