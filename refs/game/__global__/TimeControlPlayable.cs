public class TimeControlPlayable : PlayableBehaviour // TypeDefIndex: 17436
{
	// Fields
	private ITimeControl m_timeControl; // 0x10
	private bool m_started; // 0x18

	// Methods

	// RVA: 0x2C5B3A0 Offset: 0x2C59DA0 VA: 0x182C5B3A0
	public static ScriptPlayable<TimeControlPlayable> Create(PlayableGraph graph, ITimeControl timeControl) { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void Initialize(ITimeControl timeControl) { }

	// RVA: 0x2C5B570 Offset: 0x2C59F70 VA: 0x182C5B570 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x2C5B510 Offset: 0x2C59F10 VA: 0x182C5B510 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x2C5B4B0 Offset: 0x2C59EB0 VA: 0x182C5B4B0 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }
}
