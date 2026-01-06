public class AmbientTrack : MonoBehaviour // TypeDefIndex: 2130
{
	// Fields
	public const float MIN_TIME_BETWEEN_AMBIENT_TRACKS = 540;
	public static AmbientTrack LastPlayedTrack; // 0x0
	public static bool TrackQueued; // 0x8
	public List<MusicTrack> Tracks; // 0x20
	public int MinTime; // 0x28
	public int MaxTime; // 0x2C
	public float Chance; // 0x30
	private int startTime; // 0x34
	private bool playTrack; // 0x38
	private bool trackRandomized; // 0x39

	// Methods

	// RVA: 0x7F2FD0 Offset: 0x7F19D0 VA: 0x1807F2FD0
	private void Awake() { }

	[Button]
	// RVA: 0x7F3360 Offset: 0x7F1D60 VA: 0x1807F3360
	public void ForcePlay() { }

	// RVA: 0x7F3500 Offset: 0x7F1F00 VA: 0x1807F3500
	public void Stop() { }

	// RVA: 0x7F3590 Offset: 0x7F1F90 VA: 0x1807F3590
	private void Update() { }

	// RVA: 0x7F30F0 Offset: 0x7F1AF0 VA: 0x1807F30F0 Slot: 4
	protected virtual bool CanStartAmbientTrack() { }

	// RVA: 0x7F3B60 Offset: 0x7F2560 VA: 0x1807F3B60
	public void .ctor() { }
}
