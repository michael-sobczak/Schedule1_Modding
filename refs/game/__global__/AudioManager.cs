public class AudioManager : PersistentSingleton<AudioManager> // TypeDefIndex: 2131
{
	// Fields
	private const float MinWorldMusicVolumeMulitplier = 0;
	private const float MusicFadeTime = 4;
	private const float MinGameVolume = 0.0001;
	private const float MaxGameVolume = 1;
	private const float GameVolumeLerpSpeed = 2;
	[Range(0, 2)]
	[SerializeField]
	protected float masterVolume; // 0x28
	[SerializeField]
	[Range(0, 2)]
	protected float ambientVolume; // 0x2C
	[Range(0, 2)]
	[SerializeField]
	protected float footstepsVolume; // 0x30
	[SerializeField]
	[Range(0, 2)]
	protected float fxVolume; // 0x34
	[Range(0, 2)]
	[SerializeField]
	protected float uiVolume; // 0x38
	[SerializeField]
	[Range(0, 2)]
	protected float musicVolume; // 0x3C
	[Range(0, 2)]
	[SerializeField]
	protected float voiceVolume; // 0x40
	public UnityEvent onSettingsChanged; // 0x48
	[Header("Generic Door Sounds")]
	public AudioSourceController DoorOpen; // 0x50
	public AudioSourceController DoorClose; // 0x58
	[Header("Mixers")]
	public AudioMixerGroup MainGameMixer; // 0x60
	public AudioMixerGroup MenuMixer; // 0x68
	public AudioMixerGroup MusicMixer; // 0x70
	private float currentGameVolume; // 0x78
	[CompilerGenerated]
	private float <WorldMusicVolumeMultiplier>k__BackingField; // 0x7C
	public AudioMixerSnapshot DefaultSnapshot; // 0x80
	public AudioMixerSnapshot DistortedSnapshot; // 0x88

	// Properties
	public float MasterVolume { get; }
	public float AmbientVolume { get; }
	public float UnscaledAmbientVolume { get; }
	public float FootstepsVolume { get; }
	public float UnscaledFootstepsVolume { get; }
	public float FXVolume { get; }
	public float UnscaledFXVolume { get; }
	public float UIVolume { get; }
	public float UnscaledUIVolume { get; }
	public float MusicVolume { get; }
	public float UnscaledMusicVolume { get; }
	public float VoiceVolume { get; }
	public float UnscaledVoiceVolume { get; }
	public float WorldMusicVolumeMultiplier { get; set; }

	// Methods

	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0
	public float get_MasterVolume() { }

	// RVA: 0x80E310 Offset: 0x80CD10 VA: 0x18080E310
	public float get_AmbientVolume() { }

	// RVA: 0x4971C0 Offset: 0x495BC0 VA: 0x1804971C0
	public float get_UnscaledAmbientVolume() { }

	// RVA: 0x80E330 Offset: 0x80CD30 VA: 0x18080E330
	public float get_FootstepsVolume() { }

	// RVA: 0x497260 Offset: 0x495C60 VA: 0x180497260
	public float get_UnscaledFootstepsVolume() { }

	// RVA: 0x80E320 Offset: 0x80CD20 VA: 0x18080E320
	public float get_FXVolume() { }

	// RVA: 0x497250 Offset: 0x495C50 VA: 0x180497250
	public float get_UnscaledFXVolume() { }

	// RVA: 0x80E360 Offset: 0x80CD60 VA: 0x18080E360
	public float get_UIVolume() { }

	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0
	public float get_UnscaledUIVolume() { }

	// RVA: 0x80E340 Offset: 0x80CD40 VA: 0x18080E340
	public float get_MusicVolume() { }

	// RVA: 0x4E2CC0 Offset: 0x4E16C0 VA: 0x1804E2CC0
	public float get_UnscaledMusicVolume() { }

	// RVA: 0x80E370 Offset: 0x80CD70 VA: 0x18080E370
	public float get_VoiceVolume() { }

	// RVA: 0x495F60 Offset: 0x494960 VA: 0x180495F60
	public float get_UnscaledVoiceVolume() { }

	[CompilerGenerated]
	// RVA: 0x80E390 Offset: 0x80CD90 VA: 0x18080E390
	public float get_WorldMusicVolumeMultiplier() { }

	[CompilerGenerated]
	// RVA: 0x80E3A0 Offset: 0x80CDA0 VA: 0x18080E3A0
	private void set_WorldMusicVolumeMultiplier(float value) { }

	// RVA: 0x80DAE0 Offset: 0x80C4E0 VA: 0x18080DAE0
	public float GetScaledMusicVolumeMultiplier(float min) { }

	// RVA: 0x80D9A0 Offset: 0x80C3A0 VA: 0x18080D9A0 Slot: 5
	protected override void Awake() { }

	// RVA: 0x80DD90 Offset: 0x80C790 VA: 0x18080DD90 Slot: 4
	protected override void Start() { }

	// RVA: 0x80DF70 Offset: 0x80C970 VA: 0x18080DF70
	protected void Update() { }

	// RVA: 0x80DC00 Offset: 0x80C600 VA: 0x18080DC00
	public void SetDistorted(bool distorted, float transition = 5) { }

	// RVA: 0x80DC40 Offset: 0x80C640 VA: 0x18080DC40
	private void SetGameVolume(float value) { }

	// RVA: 0x80E200 Offset: 0x80CC00 VA: 0x18080E200
	private float ValueToVolume(float value) { }

	// RVA: 0x80DB20 Offset: 0x80C520 VA: 0x18080DB20
	public float GetVolume(EAudioType audioType, bool scaled = True) { }

	// RVA: 0x54B820 Offset: 0x54A220 VA: 0x18054B820
	public void SetMasterVolume(float volume) { }

	// RVA: 0x80DD30 Offset: 0x80C730 VA: 0x18080DD30
	public void SetVolume(EAudioType type, float volume) { }

	// RVA: 0x80E250 Offset: 0x80CC50 VA: 0x18080E250
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x80DF40 Offset: 0x80C940 VA: 0x18080DF40
	private void <Start>b__53_0() { }
}
