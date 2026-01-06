public class AudioPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 17395
{
	// Fields
	[SerializeField]
	private AudioClip m_Clip; // 0x18
	[SerializeField]
	private bool m_Loop; // 0x20
	[SerializeField]
	[HideInInspector]
	private float m_bufferingTime; // 0x24
	[SerializeField]
	private AudioClipProperties m_ClipProperties; // 0x28

	// Properties
	internal float bufferingTime { get; set; }
	public AudioClip clip { get; set; }
	public bool loop { get; set; }
	public override double duration { get; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	public ClipCaps clipCaps { get; }

	// Methods

	// RVA: 0x494450 Offset: 0x492E50 VA: 0x180494450
	internal float get_bufferingTime() { }

	// RVA: 0x4944A0 Offset: 0x492EA0 VA: 0x1804944A0
	internal void set_bufferingTime(float value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public AudioClip get_clip() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_clip(AudioClip value) { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_loop() { }

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_loop(bool value) { }

	// RVA: 0x2C41450 Offset: 0x2C3FE50 VA: 0x182C41450 Slot: 7
	public override double get_duration() { }

	[IteratorStateMachine(typeof(AudioPlayableAsset.<get_outputs>d__16))]
	// RVA: 0x2C41510 Offset: 0x2C3FF10 VA: 0x182C41510 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x2C41230 Offset: 0x2C3FC30 VA: 0x182C41230 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0x2C41440 Offset: 0x2C3FE40 VA: 0x182C41440 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x2C413C0 Offset: 0x2C3FDC0 VA: 0x182C413C0
	public void .ctor() { }
}
