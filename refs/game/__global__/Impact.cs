public class Impact // TypeDefIndex: 1988
{
	// Fields
	public Vector3 HitPoint; // 0x10
	public Vector3 ImpactForceDirection; // 0x1C
	public float ImpactForce; // 0x28
	public float ImpactDamage; // 0x2C
	public EImpactType ImpactType; // 0x30
	public NetworkObject ImpactSource; // 0x38
	public int ImpactID; // 0x40

	// Methods

	// RVA: 0x79C210 Offset: 0x79AC10 VA: 0x18079C210
	public void .ctor(Vector3 hitPoint, Vector3 impactForceDirection, float impactForce, float impactDamage, EImpactType impactType, NetworkObject impactSource, int impactID = 0) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x79C100 Offset: 0x79AB00 VA: 0x18079C100
	public static bool IsLethal(EImpactType impactType) { }

	// RVA: 0x79C120 Offset: 0x79AB20 VA: 0x18079C120
	public bool IsPlayerImpact(out Player player) { }
}
