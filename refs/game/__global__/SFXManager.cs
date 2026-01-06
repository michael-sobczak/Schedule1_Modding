public class SFXManager : Singleton<SFXManager> // TypeDefIndex: 2159
{
	// Fields
	public const float MAX_PLAYER_DISTANCE = 40;
	public const float SQR_MAX_PLAYER_DISTANCE = 1600;
	public List<SFXManager.ImpactType> ImpactTypes; // 0x28
	[SerializeField]
	private List<AudioSourceController> soundPool; // 0x30
	private List<AudioSourceController> soundsInUse; // 0x38

	// Methods

	// RVA: 0x8223D0 Offset: 0x820DD0 VA: 0x1808223D0
	public void PlayImpactSound(ImpactSoundEntity.EMaterial material, Vector3 position, float momentum) { }

	// RVA: 0x822210 Offset: 0x820C10 VA: 0x180822210
	private void FixedUpdate() { }

	// RVA: 0x822320 Offset: 0x820D20 VA: 0x180822320
	private AudioSourceController GetSource() { }

	// RVA: 0x8229B0 Offset: 0x8213B0 VA: 0x1808229B0
	public void .ctor() { }
}
