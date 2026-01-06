public class AmbientOneShot : MonoBehaviour // TypeDefIndex: 2129
{
	// Fields
	public AudioSourceController Audio; // 0x20
	[Header("Settings")]
	[Range(0, 1)]
	public float Volume; // 0x28
	[Range(0, 1)]
	public float ChancePerHour; // 0x2C
	public int CooldownTime; // 0x30
	public AmbientOneShot.EPlayTime PlayTime; // 0x34
	public float MinDistance; // 0x38
	public float MaxDistance; // 0x3C
	public bool PlayWhileInSewer; // 0x40
	private int timeSinceLastPlay; // 0x44

	// Methods

	// RVA: 0x7F2EA0 Offset: 0x7F18A0 VA: 0x1807F2EA0
	private void Start() { }

	// RVA: 0x7F2D70 Offset: 0x7F1770 VA: 0x1807F2D70
	private void OnDrawGizmosSelected() { }

	// RVA: 0x7F2A30 Offset: 0x7F1430 VA: 0x1807F2A30
	private void MinPass() { }

	// RVA: 0x7F2E50 Offset: 0x7F1850 VA: 0x1807F2E50
	private void Play() { }

	// RVA: 0x7F2FA0 Offset: 0x7F19A0 VA: 0x1807F2FA0
	public void .ctor() { }
}
