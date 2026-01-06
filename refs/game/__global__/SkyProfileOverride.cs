public class SkyProfileOverride : MonoBehaviour // TypeDefIndex: 465
{
	// Fields
	public SkyProfile SkyProfile; // 0x20
	[Range(0, 1)]
	public float Strength; // 0x28
	[Header("Masks")]
	public bool AffectAmbientLight; // 0x2C
	public bool AffectFog; // 0x2D
	public bool AffectSunLight; // 0x2E

	// Methods

	// RVA: 0x9E49E0 Offset: 0x9E33E0 VA: 0x1809E49E0
	public void Apply(SkyProfileOutput output, float timeOfDay) { }

	// RVA: 0x9E4FD0 Offset: 0x9E39D0 VA: 0x1809E4FD0
	public void .ctor() { }
}
