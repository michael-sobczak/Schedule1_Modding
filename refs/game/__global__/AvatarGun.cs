public class AvatarGun : AvatarRangedWeapon // TypeDefIndex: 3155
{
	// Fields
	[Header("References")]
	public Animation Anim; // 0x100
	public ParticleSystem ShellParticles; // 0x108
	public ParticleSystem SmokeParticles; // 0x110
	public Transform FlashObject; // 0x118
	[Header("Prefabs")]
	public GameObject RayPrefab; // 0x120
	private Coroutine flashRoutine; // 0x128

	// Methods

	// RVA: 0x9AEEA0 Offset: 0x9AD8A0 VA: 0x1809AEEA0 Slot: 12
	protected override void Shoot(Vector3 endPoint) { }

	[IteratorStateMachine(typeof(AvatarGun.<Flash>d__7))]
	// RVA: 0x9AEE10 Offset: 0x9AD810 VA: 0x1809AEE10
	private IEnumerator Flash(Vector3 endPoint) { }

	// RVA: 0x9AF130 Offset: 0x9ADB30 VA: 0x1809AF130
	public void .ctor() { }
}
