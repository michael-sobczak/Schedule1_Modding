internal class ScheduleRuntimeClip : RuntimeClipBase // TypeDefIndex: 17412
{
	// Fields
	private TimelineClip m_Clip; // 0x18
	private Playable m_Playable; // 0x20
	private Playable m_ParentMixer; // 0x30
	private double m_StartDelay; // 0x40
	private double m_FinishTail; // 0x48
	private bool m_Started; // 0x50

	// Properties
	public override double start { get; }
	public override double duration { get; }
	public TimelineClip clip { get; }
	public Playable mixer { get; }
	public Playable playable { get; }
	public override bool enable { set; }

	// Methods

	// RVA: 0x2C4A1C0 Offset: 0x2C48BC0 VA: 0x182C4A1C0 Slot: 11
	public override double get_start() { }

	// RVA: 0x2C4A170 Offset: 0x2C48B70 VA: 0x182C4A170 Slot: 12
	public override double get_duration() { }

	// RVA: 0x2C4A060 Offset: 0x2C48A60 VA: 0x182C4A060
	public void SetTime(double time) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public TimelineClip get_clip() { }

	// RVA: 0x6FC320 Offset: 0x6FAD20 VA: 0x1806FC320
	public Playable get_mixer() { }

	// RVA: 0x4976D0 Offset: 0x4960D0 VA: 0x1804976D0
	public Playable get_playable() { }

	// RVA: 0x2C4A0C0 Offset: 0x2C48AC0 VA: 0x182C4A0C0
	public void .ctor(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay = 0.2, double finishTail = 0.1) { }

	// RVA: 0x2C49C80 Offset: 0x2C48680 VA: 0x182C49C80
	private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay, double finishTail) { }

	// RVA: 0x2C4A240 Offset: 0x2C48C40 VA: 0x182C4A240 Slot: 8
	public override void set_enable(bool value) { }

	// RVA: 0x2C49D40 Offset: 0x2C48740 VA: 0x182C49D40 Slot: 9
	public override void EvaluateAt(double localTime, FrameData frameData) { }

	// RVA: 0x2C49D20 Offset: 0x2C48720 VA: 0x182C49D20 Slot: 10
	public override void DisableAt(double localTime, double rootDuration, FrameData frameData) { }
}
