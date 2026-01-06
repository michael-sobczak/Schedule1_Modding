public class AudioTrack : TrackAsset // TypeDefIndex: 17397
{
	// Fields
	[SerializeField]
	private AudioMixerProperties m_TrackProperties; // 0xA0

	// Properties
	public override IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: 0x2C41E10 Offset: 0x2C40810 VA: 0x182C41E10
	public TimelineClip CreateClip(AudioClip clip) { }

	// RVA: 0x2C41590 Offset: 0x2C3FF90 VA: 0x182C41590 Slot: 25
	internal override Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree) { }

	[IteratorStateMachine(typeof(AudioTrack.<get_outputs>d__4))]
	// RVA: 0x2C420C0 Offset: 0x2C40AC0 VA: 0x182C420C0 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x2C41F80 Offset: 0x2C40980 VA: 0x182C41F80
	private void OnValidate() { }

	// RVA: 0x2C42020 Offset: 0x2C40A20 VA: 0x182C42020
	public void .ctor() { }
}
