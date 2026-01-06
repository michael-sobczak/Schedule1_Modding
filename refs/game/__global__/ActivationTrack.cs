public class ActivationTrack : TrackAsset // TypeDefIndex: 17355
{
	// Fields
	[SerializeField]
	private ActivationTrack.PostPlaybackState m_PostPlaybackState; // 0xA0
	private ActivationMixerPlayable m_ActivationMixer; // 0xA8

	// Properties
	public ActivationTrack.PostPlaybackState postPlaybackState { get; set; }

	// Methods

	// RVA: 0x2C3AF20 Offset: 0x2C39920 VA: 0x182C3AF20 Slot: 33
	internal override bool CanCompileClips() { }

	// RVA: 0x5B3AE0 Offset: 0x5B24E0 VA: 0x1805B3AE0
	public ActivationTrack.PostPlaybackState get_postPlaybackState() { }

	// RVA: 0x2C3B2A0 Offset: 0x2C39CA0 VA: 0x182C3B2A0
	public void set_postPlaybackState(ActivationTrack.PostPlaybackState value) { }

	// RVA: 0x2C3AFB0 Offset: 0x2C399B0 VA: 0x182C3AFB0 Slot: 24
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	// RVA: 0x2C3B220 Offset: 0x2C39C20 VA: 0x182C3B220
	internal void UpdateTrackMode() { }

	// RVA: 0x2C3B100 Offset: 0x2C39B00 VA: 0x182C3B100 Slot: 29
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x2C3B1D0 Offset: 0x2C39BD0 VA: 0x182C3B1D0 Slot: 30
	protected override void OnCreateClip(TimelineClip clip) { }

	// RVA: 0x2C3B240 Offset: 0x2C39C40 VA: 0x182C3B240
	public void .ctor() { }
}
