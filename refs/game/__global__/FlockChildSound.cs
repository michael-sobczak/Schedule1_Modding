public class FlockChildSound : MonoBehaviour // TypeDefIndex: 75
{
	// Fields
	public AudioSourceController controller; // 0x20
	public AudioClip[] _idleSounds; // 0x28
	public float _idleSoundRandomChance; // 0x30
	public AudioClip[] _flightSounds; // 0x38
	public float _flightSoundRandomChance; // 0x40
	public AudioClip[] _scareSounds; // 0x48
	public float _pitchMin; // 0x50
	public float _pitchMax; // 0x54
	public float _volumeMin; // 0x58
	public float _volumeMax; // 0x5C
	private FlockChild _flockChild; // 0x60
	private AudioSource _audio; // 0x68
	private bool _hasLanded; // 0x70

	// Methods

	// RVA: 0x559250 Offset: 0x557C50 VA: 0x180559250
	public void Start() { }

	// RVA: 0x558FD0 Offset: 0x5579D0 VA: 0x180558FD0
	public void PlayRandomSound() { }

	// RVA: 0x559120 Offset: 0x557B20 VA: 0x180559120
	public void ScareSound() { }

	// RVA: 0x559350 Offset: 0x557D50 VA: 0x180559350
	public void .ctor() { }
}
