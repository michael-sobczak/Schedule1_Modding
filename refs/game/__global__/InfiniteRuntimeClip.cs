internal class InfiniteRuntimeClip : RuntimeElement // TypeDefIndex: 17404
{
	// Fields
	private Playable m_Playable; // 0x18
	private static readonly long kIntervalEnd; // 0x0

	// Properties
	public override long intervalStart { get; }
	public override long intervalEnd { get; }
	public override bool enable { set; }

	// Methods

	// RVA: 0x2C48190 Offset: 0x2C46B90 VA: 0x182C48190
	public void .ctor(Playable playable) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public override long get_intervalStart() { }

	// RVA: 0x2C481C0 Offset: 0x2C46BC0 VA: 0x182C481C0 Slot: 7
	public override long get_intervalEnd() { }

	// RVA: 0x2C48210 Offset: 0x2C46C10 VA: 0x182C48210 Slot: 8
	public override void set_enable(bool value) { }

	// RVA: 0x2C48050 Offset: 0x2C46A50 VA: 0x182C48050 Slot: 9
	public override void EvaluateAt(double localTime, FrameData frameData) { }

	// RVA: 0x2C47FE0 Offset: 0x2C469E0 VA: 0x182C47FE0 Slot: 10
	public override void DisableAt(double localTime, double rootDuration, FrameData frameData) { }

	// RVA: 0x2C480B0 Offset: 0x2C46AB0 VA: 0x182C480B0
	private static void .cctor() { }
}
