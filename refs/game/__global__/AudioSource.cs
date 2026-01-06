public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 18957
{
	// Properties
	public float volume { set; }
	public float pitch { get; set; }
	[NativeProperty("SecPosition")]
	public float time { get; set; }
	[NativeProperty("AudioClip")]
	public AudioClip clip { get; set; }
	public AudioMixerGroup outputAudioMixerGroup { set; }
	public bool isPlaying { get; }
	public bool loop { set; }
	public bool playOnAwake { set; }

	// Methods

	// RVA: 0x2C7C430 Offset: 0x2C7AE30 VA: 0x182C7C430
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x2C7C820 Offset: 0x2C7B220 VA: 0x182C7C820
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x2C7C520 Offset: 0x2C7AF20 VA: 0x182C7C520
	private static void PlayHelper(AudioSource source, ulong delay) { }

	// RVA: 0x2C7C790 Offset: 0x2C7B190 VA: 0x182C7C790
	private void Play(double delay) { }

	// RVA: 0x2C7C570 Offset: 0x2C7AF70 VA: 0x182C7C570
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x2C7C8B0 Offset: 0x2C7B2B0 VA: 0x182C7C8B0
	private void Stop(bool stopOneShots) { }

	// RVA: 0x2C7CB90 Offset: 0x2C7B590 VA: 0x182C7CB90
	public void set_volume(float value) { }

	// RVA: 0x2C7C430 Offset: 0x2C7AE30 VA: 0x182C7C430
	public float get_pitch() { }

	// RVA: 0x2C7C820 Offset: 0x2C7B220 VA: 0x182C7C820
	public void set_pitch(float value) { }

	// RVA: 0x2C7C9C0 Offset: 0x2C7B3C0 VA: 0x182C7C9C0
	public float get_time() { }

	// RVA: 0x2C7CB40 Offset: 0x2C7B540 VA: 0x182C7CB40
	public void set_time(float value) { }

	// RVA: 0x2C7C940 Offset: 0x2C7B340 VA: 0x182C7C940
	public AudioClip get_clip() { }

	// RVA: 0x2C7CA00 Offset: 0x2C7B400 VA: 0x182C7CA00
	public void set_clip(AudioClip value) { }

	// RVA: 0x2C7CAA0 Offset: 0x2C7B4A0 VA: 0x182C7CAA0
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[ExcludeFromDocs]
	// RVA: 0x2C7C7E0 Offset: 0x2C7B1E0 VA: 0x182C7C7E0
	public void Play() { }

	// RVA: 0x2C7C4B0 Offset: 0x2C7AEB0 VA: 0x182C7C4B0
	public void PlayDelayed(float delay) { }

	[ExcludeFromDocs]
	// RVA: 0x2C7C5D0 Offset: 0x2C7AFD0 VA: 0x182C7C5D0
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x2C7C6B0 Offset: 0x2C7B0B0 VA: 0x182C7C6B0
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x2C7C870 Offset: 0x2C7B270 VA: 0x182C7C870
	public void Stop() { }

	// RVA: 0x2C7C470 Offset: 0x2C7AE70 VA: 0x182C7C470
	public void Pause() { }

	// RVA: 0x2C7C900 Offset: 0x2C7B300 VA: 0x182C7C900
	public void UnPause() { }

	[NativeName("IsPlayingScripting")]
	// RVA: 0x2C7C980 Offset: 0x2C7B380 VA: 0x182C7C980
	public bool get_isPlaying() { }

	// RVA: 0x2C7CA50 Offset: 0x2C7B450 VA: 0x182C7CA50
	public void set_loop(bool value) { }

	// RVA: 0x2C7CAF0 Offset: 0x2C7B4F0 VA: 0x182C7CAF0
	public void set_playOnAwake(bool value) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
