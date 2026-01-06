public class ImpactSoundEntity : MonoBehaviour // TypeDefIndex: 2148
{
	// Fields
	public const float MIN_IMPACT_MOMENTUM = 4;
	public const float COOLDOWN = 0.25;
	public ImpactSoundEntity.EMaterial Material; // 0x20
	private float lastImpactTime; // 0x24
	private Rigidbody rb; // 0x28

	// Methods

	// RVA: 0x813840 Offset: 0x812240 VA: 0x180813840
	public void Awake() { }

	// RVA: 0x813C70 Offset: 0x812670 VA: 0x180813C70
	private void OnImpacted(Impact impact) { }

	// RVA: 0x8139C0 Offset: 0x8123C0 VA: 0x1808139C0
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
