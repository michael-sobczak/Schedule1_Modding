public class WaitForSecondsRealtime : CustomYieldInstruction // TypeDefIndex: 11860
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private float <waitTime>k__BackingField; // 0x10
	private float m_WaitUntilTime; // 0x14

	// Properties
	public float waitTime { get; set; }
	public override bool keepWaiting { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4747B0 Offset: 0x4731B0 VA: 0x1804747B0
	public float get_waitTime() { }

	[CompilerGenerated]
	// RVA: 0x4944E0 Offset: 0x492EE0 VA: 0x1804944E0
	public void set_waitTime(float value) { }

	// RVA: 0x2CD3F50 Offset: 0x2CD2950 VA: 0x182CD3F50 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x2CD3F20 Offset: 0x2CD2920 VA: 0x182CD3F20
	public void .ctor(float time) { }

	// RVA: 0x2CD3F10 Offset: 0x2CD2910 VA: 0x182CD3F10 Slot: 8
	public override void Reset() { }
}
