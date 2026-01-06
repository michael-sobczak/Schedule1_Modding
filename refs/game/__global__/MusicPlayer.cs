public class MusicPlayer : PersistentSingleton<MusicPlayer> // TypeDefIndex: 2152
{
	// Fields
	public static float TimeSinceLastAmbientTrack; // 0x0
	public List<MusicTrack> Tracks; // 0x28
	public AudioMixerGroup MusicMixer; // 0x30
	public AudioMixerSnapshot DefaultSnapshot; // 0x38
	public AudioMixerSnapshot DistortedSnapshot; // 0x40
	private MusicTrack _currentTrack; // 0x48

	// Properties
	public bool IsPlaying { get; }

	// Methods

	// RVA: 0x820BC0 Offset: 0x81F5C0 VA: 0x180820BC0
	public bool get_IsPlaying() { }

	// RVA: 0x81FFA0 Offset: 0x81E9A0 VA: 0x18081FFA0
	public void OnValidate() { }

	// RVA: 0x8202D0 Offset: 0x81ECD0 VA: 0x1808202D0 Slot: 4
	protected override void Start() { }

	// RVA: 0x820A70 Offset: 0x81F470 VA: 0x180820A70
	private void Update() { }

	// RVA: 0x820110 Offset: 0x81EB10 VA: 0x180820110
	public void SetMusicDistorted(bool distorted, float transition = 5) { }

	// RVA: 0x820140 Offset: 0x81EB40 VA: 0x180820140
	public void SetTrackEnabled(string trackName, bool enabled) { }

	// RVA: 0x8205E0 Offset: 0x81EFE0 VA: 0x1808205E0
	public void StopTrack(string trackName) { }

	// RVA: 0x8204D0 Offset: 0x81EED0 VA: 0x1808204D0
	public void StopAndDisableTracks() { }

	// RVA: 0x8207A0 Offset: 0x81F1A0 VA: 0x1808207A0
	private void UpdateTracks() { }

	// RVA: 0x820B30 Offset: 0x81F530 VA: 0x180820B30
	public void .ctor() { }

	// RVA: 0x820AF0 Offset: 0x81F4F0 VA: 0x180820AF0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x820770 Offset: 0x81F170 VA: 0x180820770
	private void <Start>b__9_0() { }
}
