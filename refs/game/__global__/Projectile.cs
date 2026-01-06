public class Projectile : MonoBehaviour // TypeDefIndex: 18188
{
	// Fields
	[Tooltip("If above 0f projectiles are stored with a delay rather than when off screen.")]
	[Range(0, 5)]
	public float DestroyDelay; // 0x20
	public float MoveRate; // 0x24
	private ProjectileSpawner _spawner; // 0x28
	private MeshRenderer[] _renderers; // 0x30
	private Vector3 _moveDirection; // 0x38
	private bool _exitingPlayMode; // 0x44

	// Methods

	// RVA: 0xDA92B0 Offset: 0xDA7CB0 VA: 0x180DA92B0
	private void Awake() { }

	// RVA: 0xDA9370 Offset: 0xDA7D70 VA: 0x180DA9370
	private void OnBecameInvisible() { }

	// RVA: 0xDA9410 Offset: 0xDA7E10 VA: 0x180DA9410
	private void OnEnable() { }

	// RVA: 0xDA9600 Offset: 0xDA8000 VA: 0x180DA9600
	private void Update() { }

	// RVA: 0xDA9700 Offset: 0xDA8100 VA: 0x180DA9700
	public void .ctor() { }
}
