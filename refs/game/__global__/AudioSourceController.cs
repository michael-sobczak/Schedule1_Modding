public class AudioSourceController : MonoBehaviour // TypeDefIndex: 2133
{
	// Fields
	public bool DEBUG; // 0x20
	[CompilerGenerated]
	private float <Volume>k__BackingField; // 0x24
	public AudioSource AudioSource; // 0x28
	[Header("Settings")]
	public EAudioType AudioType; // 0x30
	[Range(0, 1)]
	public float DefaultVolume; // 0x34
	public bool RandomizePitch; // 0x38
	public float MinPitch; // 0x3C
	public float MaxPitch; // 0x40
	[SerializeField]
	[Range(0, 2)]
	private float VolumeMultiplier; // 0x44
	[SerializeField]
	[Range(0, 2)]
	private float PitchMultiplier; // 0x48
	private float basePitch; // 0x4C

	// Properties
	public float Volume { get; set; }
	public bool isPlaying { get; }
	public float volumeMultiplier { get; set; }
	public float pitchMultiplier { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x494450 Offset: 0x492E50 VA: 0x180494450
	public float get_Volume() { }

	[CompilerGenerated]
	// RVA: 0x4944A0 Offset: 0x492EA0 VA: 0x1804944A0
	protected void set_Volume(float value) { }

	// RVA: 0x80F1F0 Offset: 0x80DBF0 VA: 0x18080F1F0
	public bool get_isPlaying() { }

	// RVA: 0x49D270 Offset: 0x49BC70 VA: 0x18049D270
	public float get_volumeMultiplier() { }

	// RVA: 0x80F220 Offset: 0x80DC20 VA: 0x18080F220
	public void set_volumeMultiplier(float value) { }

	// RVA: 0x495E80 Offset: 0x494880 VA: 0x180495E80
	public float get_pitchMultiplier() { }

	// RVA: 0x80F210 Offset: 0x80DC10 VA: 0x18080F210
	public void set_pitchMultiplier(float value) { }

	// RVA: 0x80E7C0 Offset: 0x80D1C0 VA: 0x18080E7C0
	private void Awake() { }

	[IteratorStateMachine(typeof(AudioSourceController.<Start>d__23))]
	// RVA: 0x80F0F0 Offset: 0x80DAF0 VA: 0x18080F0F0
	private IEnumerator Start() { }

	// RVA: 0x80EDF0 Offset: 0x80D7F0 VA: 0x18080EDF0
	private void OnDestroy() { }

	// RVA: 0x80EF50 Offset: 0x80D950 VA: 0x18080EF50
	private void OnValidate() { }

	// RVA: 0x80EFE0 Offset: 0x80D9E0 VA: 0x18080EFE0
	private void Pause() { }

	// RVA: 0x80F180 Offset: 0x80DB80 VA: 0x18080F180
	private void Unpause() { }

	// RVA: 0x80F0E0 Offset: 0x80DAE0 VA: 0x18080F0E0
	public void SetVolume(float volume) { }

	// RVA: 0x80E430 Offset: 0x80CE30 VA: 0x18080E430
	public void ApplyVolume() { }

	// RVA: 0x80E3B0 Offset: 0x80CDB0 VA: 0x18080E3B0
	public void ApplyPitch() { }

	// RVA: 0x80F090 Offset: 0x80DA90 VA: 0x18080F090 Slot: 4
	public virtual void Play() { }

	// RVA: 0x80F000 Offset: 0x80DA00 VA: 0x18080F000 Slot: 5
	public virtual void PlayOneShot() { }

	// RVA: 0x80EB60 Offset: 0x80D560 VA: 0x18080EB60
	public void DuplicateAndPlayOneShot() { }

	// RVA: 0x80EB80 Offset: 0x80D580 VA: 0x18080EB80 Slot: 6
	public virtual void DuplicateAndPlayOneShot(Transform parent) { }

	// RVA: 0x80F160 Offset: 0x80DB60 VA: 0x18080F160
	public void Stop() { }

	// RVA: 0x80F1B0 Offset: 0x80DBB0 VA: 0x18080F1B0
	public void .ctor() { }
}
