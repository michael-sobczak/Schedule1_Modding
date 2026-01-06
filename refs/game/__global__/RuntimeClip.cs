internal class RuntimeClip : RuntimeClipBase // TypeDefIndex: 17409
{
	// Fields
	private TimelineClip m_Clip; // 0x18
	private Playable m_Playable; // 0x20
	private Playable m_ParentMixer; // 0x30

	// Properties
	public override double start { get; }
	public override double duration { get; }
	public TimelineClip clip { get; }
	public Playable mixer { get; }
	public Playable playable { get; }
	public override bool enable { set; }

	// Methods

	// RVA: 0x2C49AC0 Offset: 0x2C484C0 VA: 0x182C49AC0 Slot: 11
	public override double get_start() { }

	// RVA: 0x2C49AA0 Offset: 0x2C484A0 VA: 0x182C49AA0 Slot: 12
	public override double get_duration() { }

	// RVA: 0x2C49A10 Offset: 0x2C48410 VA: 0x182C49A10
	public void .ctor(TimelineClip clip, Playable clipPlayable, Playable parentMixer) { }

	// RVA: 0x2C49390 Offset: 0x2C47D90 VA: 0x182C49390
	private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public TimelineClip get_clip() { }

	// RVA: 0x6FC320 Offset: 0x6FAD20 VA: 0x1806FC320
	public Playable get_mixer() { }

	// RVA: 0x4976D0 Offset: 0x4960D0 VA: 0x1804976D0
	public Playable get_playable() { }

	// RVA: 0x2C49AF0 Offset: 0x2C484F0 VA: 0x182C49AF0 Slot: 8
	public override void set_enable(bool value) { }

	// RVA: 0x2C499B0 Offset: 0x2C483B0 VA: 0x182C499B0
	public void SetTime(double time) { }

	// RVA: 0x2C49950 Offset: 0x2C48350 VA: 0x182C49950
	public void SetDuration(double duration) { }

	// RVA: 0x2C495F0 Offset: 0x2C47FF0 VA: 0x182C495F0 Slot: 9
	public override void EvaluateAt(double localTime, FrameData frameData) { }

	// RVA: 0x2C49420 Offset: 0x2C47E20 VA: 0x182C49420 Slot: 10
	public override void DisableAt(double localTime, double rootDuration, FrameData frameData) { }
}
