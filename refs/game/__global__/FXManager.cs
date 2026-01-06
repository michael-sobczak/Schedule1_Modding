public class FXManager : Singleton<FXManager> // TypeDefIndex: 3387
{
	// Fields
	public AudioClip[] PunchImpactsClips; // 0x28
	public AudioClip[] SlashImpactClips; // 0x30
	[Header("References")]
	public AudioSourceController[] ImpactSources; // 0x38
	[Header("Particle Prefabs")]
	public GameObject PunchParticlePrefab; // 0x40
	[Header("Trails")]
	public TrailRenderer BulletTrail; // 0x48

	// Methods

	// RVA: 0xA654E0 Offset: 0xA63EE0 VA: 0x180A654E0 Slot: 4
	protected override void Start() { }

	// RVA: 0xA64B80 Offset: 0xA63580 VA: 0x180A64B80
	public void CreateImpactFX(Impact impact, IDamageable target) { }

	// RVA: 0xA647C0 Offset: 0xA631C0 VA: 0x180A647C0
	public void CreateBulletTrail(Vector3 start, Vector3 dir, float speed, float range, LayerMask mask) { }

	// RVA: 0xA651F0 Offset: 0xA63BF0 VA: 0x180A651F0
	private void PlayImpact(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0xA65430 Offset: 0xA63E30 VA: 0x180A65430
	private void PlayParticles(GameObject prefab, Vector3 position, Quaternion rotation) { }

	// RVA: 0xA64F70 Offset: 0xA63970 VA: 0x180A64F70
	private AudioClip GetImpactSound(Impact impact, IDamageable target) { }

	// RVA: 0xA64EC0 Offset: 0xA638C0 VA: 0x180A64EC0
	private GameObject GetImpactParticles(Impact impact, IDamageable target) { }

	// RVA: 0xA650D0 Offset: 0xA63AD0 VA: 0x180A650D0
	private AudioSourceController GetSource() { }

	// RVA: 0xA65090 Offset: 0xA63A90 VA: 0x180A65090
	private static AudioClip GetRandomClip(AudioClip[] clips) { }

	// RVA: 0xA65520 Offset: 0xA63F20 VA: 0x180A65520
	public void .ctor() { }
}
