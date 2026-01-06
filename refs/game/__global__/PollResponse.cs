public class PollResponse // TypeDefIndex: 768
{
	// Fields
	public PollData[] polls; // 0x10
	public int active; // 0x18
	public int confirmed; // 0x1C

	// Methods

	// RVA: 0x5925F0 Offset: 0x590FF0 VA: 0x1805925F0
	public PollData GetActive() { }

	// RVA: 0x592680 Offset: 0x591080 VA: 0x180592680
	public PollData GetConfirmed() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x592710 Offset: 0x591110 VA: 0x180592710
	private bool <GetActive>b__3_0(PollData x) { }

	[CompilerGenerated]
	// RVA: 0x592730 Offset: 0x591130 VA: 0x180592730
	private bool <GetConfirmed>b__4_0(PollData x) { }
}
