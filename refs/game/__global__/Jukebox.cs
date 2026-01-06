public class Jukebox : GridItem // TypeDefIndex: 3211
{
	// Fields
	public const float MUSIC_FADE_MULTIPLIER = 0.4;
	public const int TRACK_COUNT = 27;
	private Jukebox.JukeboxState _jukeboxState; // 0x210
	[Header("References")]
	public Jukebox.Track[] TrackList; // 0x218
	public GameObject[] VolumeIndicatorBars; // 0x220
	public AudioSourceController AudioSourceController; // 0x228
	public Action onStateChanged; // 0x230
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.JukeboxAssembly-CSharp.dll_Excuted; // 0x238
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.JukeboxAssembly-CSharp.dll_Excuted; // 0x239

	// Properties
	public int CurrentVolume { get; }
	public float NormalizedVolume { get; }
	public bool IsPlaying { get; }
	public float CurrentTrackTime { get; }
	private int[] TrackOrder { get; }
	public int CurrentTrackOrderIndex { get; }
	public bool Shuffle { get; }
	public Jukebox.ERepeatMode RepeatMode { get; }
	public bool Sync { get; }
	public Jukebox.Track currentTrack { get; }
	private AudioClip currentClip { get; }

	// Methods

	// RVA: 0x9D06E0 Offset: 0x9CF0E0 VA: 0x1809D06E0
	public int get_CurrentVolume() { }

	// RVA: 0x9D0720 Offset: 0x9CF120 VA: 0x1809D0720
	public float get_NormalizedVolume() { }

	// RVA: 0x9D0700 Offset: 0x9CF100 VA: 0x1809D0700
	public bool get_IsPlaying() { }

	// RVA: 0x9D06C0 Offset: 0x9CF0C0 VA: 0x1809D06C0
	public float get_CurrentTrackTime() { }

	// RVA: 0x9D07B0 Offset: 0x9CF1B0 VA: 0x1809D07B0
	private int[] get_TrackOrder() { }

	// RVA: 0x9D06A0 Offset: 0x9CF0A0 VA: 0x1809D06A0
	public int get_CurrentTrackOrderIndex() { }

	// RVA: 0x9D0770 Offset: 0x9CF170 VA: 0x1809D0770
	public bool get_Shuffle() { }

	// RVA: 0x9D0750 Offset: 0x9CF150 VA: 0x1809D0750
	public Jukebox.ERepeatMode get_RepeatMode() { }

	// RVA: 0x9D0790 Offset: 0x9CF190 VA: 0x1809D0790
	public bool get_Sync() { }

	// RVA: 0x9D0800 Offset: 0x9CF200 VA: 0x1809D0800
	public Jukebox.Track get_currentTrack() { }

	// RVA: 0x9D07D0 Offset: 0x9CF1D0 VA: 0x1809D07D0
	private AudioClip get_currentClip() { }

	// RVA: 0x9CE520 Offset: 0x9CCF20 VA: 0x1809CE520 Slot: 47
	public override void Awake() { }

	// RVA: 0x9CE650 Offset: 0x9CD050 VA: 0x1809CE650
	private void FixedUpdate() { }

	// RVA: 0x9CEBB0 Offset: 0x9CD5B0 VA: 0x1809CEBB0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x9CE620 Offset: 0x9CD020 VA: 0x1809CE620
	public void ChangeVolume(int change) { }

	// RVA: 0x9CFF90 Offset: 0x9CE990 VA: 0x1809CFF90
	public void SetVolume(int volume, bool replicate) { }

	// RVA: 0x9CE1A0 Offset: 0x9CCBA0 VA: 0x1809CE1A0
	private void ApplyVolume() { }

	[Button]
	// RVA: 0x9D00A0 Offset: 0x9CEAA0 VA: 0x1809D00A0
	public void TogglePlay() { }

	[Button]
	// RVA: 0x9CE570 Offset: 0x9CCF70 VA: 0x1809CE570
	public void Back() { }

	[Button]
	// RVA: 0x9CEB10 Offset: 0x9CD510 VA: 0x1809CEB10
	public void Next() { }

	// RVA: 0x9CE880 Offset: 0x9CD280 VA: 0x1809CE880
	private int GetPreviousTrackOrderIndex() { }

	// RVA: 0x9CE840 Offset: 0x9CD240 VA: 0x1809CE840
	private int GetNextTrackOrderIndex() { }

	[Button]
	// RVA: 0x9D01B0 Offset: 0x9CEBB0 VA: 0x1809D01B0
	public void ToggleShuffle() { }

	[Button]
	// RVA: 0x9D0120 Offset: 0x9CEB20 VA: 0x1809D0120
	public void ToggleRepeatMode() { }

	[Button]
	// RVA: 0x9D0480 Offset: 0x9CEE80 VA: 0x1809D0480
	public void ToggleSync() { }

	// RVA: 0x9CEC10 Offset: 0x9CD610 VA: 0x1809CEC10
	public void PlayTrack(int trackID) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x9CF6E0 Offset: 0x9CE0E0 VA: 0x1809CF6E0
	public void SendJukeboxState(Jukebox.JukeboxState state, bool setTrackTime, bool setSync) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x9CF870 Offset: 0x9CE270 VA: 0x1809CF870
	public void SetJukeboxState(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync) { }

	// RVA: 0x9CFB30 Offset: 0x9CE530 VA: 0x1809CFB30
	public void SetJukeboxState(Jukebox.JukeboxState state, bool setTrackTime) { }

	// RVA: 0x9CE8C0 Offset: 0x9CD2C0 VA: 0x1809CE8C0
	private Jukebox.Track GetTrack(int orderIndex) { }

	// RVA: 0x9D04E0 Offset: 0x9CEEE0 VA: 0x1809D04E0
	private bool ValidateQueue(int[] queue) { }

	// RVA: 0x9CEE20 Offset: 0x9CD820 VA: 0x1809CEE20
	private void ReplicateStateToOtherClients(bool setTrackTime) { }

	// RVA: 0x9CEE50 Offset: 0x9CD850 VA: 0x1809CEE50
	private void ReplicateStateToOtherJukeboxes(bool setTrackTime) { }

	// RVA: 0x9CE740 Offset: 0x9CD140 VA: 0x1809CE740 Slot: 61
	public override BuildableItemData GetBaseData() { }

	// RVA: 0x9CC3C0 Offset: 0x9CADC0 VA: 0x1809CC3C0
	public void .ctor() { }

	// RVA: 0x9CE9E0 Offset: 0x9CD3E0 VA: 0x1809CE9E0 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0x9CE9C0 Offset: 0x9CD3C0 VA: 0x1809CE9C0 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x9CF410 Offset: 0x9CDE10 VA: 0x1809CF410
	private void RpcWriter___Server_SendJukeboxState_1728100027(Jukebox.JukeboxState state, bool setTrackTime, bool setSync) { }

	// RVA: 0x9CEFF0 Offset: 0x9CD9F0 VA: 0x1809CEFF0
	public void RpcLogic___SendJukeboxState_1728100027(Jukebox.JukeboxState state, bool setTrackTime, bool setSync) { }

	// RVA: 0x9CF0F0 Offset: 0x9CDAF0 VA: 0x1809CF0F0
	private void RpcReader___Server_SendJukeboxState_1728100027(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x9CF290 Offset: 0x9CDC90 VA: 0x1809CF290
	private void RpcWriter___Observers_SetJukeboxState_2499833112(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync) { }

	// RVA: 0x9CF020 Offset: 0x9CDA20 VA: 0x1809CF020
	public void RpcLogic___SetJukeboxState_2499833112(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync) { }

	// RVA: 0x9CF040 Offset: 0x9CDA40 VA: 0x1809CF040
	private void RpcReader___Observers_SetJukeboxState_2499833112(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9CF570 Offset: 0x9CDF70 VA: 0x1809CF570
	private void RpcWriter___Target_SetJukeboxState_2499833112(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync) { }

	// RVA: 0x9CF1E0 Offset: 0x9CDBE0 VA: 0x1809CF1E0
	private void RpcReader___Target_SetJukeboxState_2499833112(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9CE290 Offset: 0x9CCC90 VA: 0x1809CE290 Slot: 71
	protected override void Awake_UserLogic_ScheduleOne.ObjectScripts.Jukebox_Assembly-CSharp.dll() { }
}
