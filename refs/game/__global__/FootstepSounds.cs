public class FootstepSounds : MonoBehaviour // TypeDefIndex: 2145
{
	// Fields
	public const float COOLDOWN_TIME = 0.15;
	[CompilerGenerated]
	private float <VolumeMultiplier>k__BackingField; // 0x20
	[Range(0, 4)]
	public float BaseVolumeMultiplier; // 0x24
	public List<AudioSourceController> sources; // 0x28
	public List<FootstepSounds.FootstepSoundGroup> soundGroups; // 0x30
	private Dictionary<EMaterialType, FootstepSounds.FootstepSoundGroup> materialFootstepSounds; // 0x38
	private float lastStepTime; // 0x40

	// Properties
	public float VolumeMultiplier { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4975C0 Offset: 0x495FC0 VA: 0x1804975C0
	public float get_VolumeMultiplier() { }

	[CompilerGenerated]
	// RVA: 0x49CD70 Offset: 0x49B770 VA: 0x18049CD70
	public void set_VolumeMultiplier(float value) { }

	// RVA: 0x810E40 Offset: 0x80F840 VA: 0x180810E40
	private void Awake() { }

	// RVA: 0x810F80 Offset: 0x80F980 VA: 0x180810F80
	private void Start() { }

	// RVA: 0x811670 Offset: 0x810070 VA: 0x180811670
	public void Step(EMaterialType materialType, float hardness) { }

	// RVA: 0x810E60 Offset: 0x80F860 VA: 0x180810E60
	public AudioSourceController GetFreeSource() { }

	// RVA: 0x811A60 Offset: 0x810460 VA: 0x180811A60
	public void .ctor() { }
}
