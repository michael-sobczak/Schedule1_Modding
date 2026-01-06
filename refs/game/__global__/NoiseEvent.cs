public class NoiseEvent // TypeDefIndex: 1141
{
	// Fields
	public Vector3 origin; // 0x10
	public float range; // 0x1C
	public ENoiseType type; // 0x20
	public GameObject source; // 0x28
	[CompilerGenerated]
	private bool <OriginInSewer>k__BackingField; // 0x30

	// Properties
	public bool OriginInSewer { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_OriginInSewer() { }

	[CompilerGenerated]
	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	private void set_OriginInSewer(bool value) { }

	// RVA: 0x5E6EC0 Offset: 0x5E58C0 VA: 0x1805E6EC0
	public void .ctor(Vector3 _origin, float _range, ENoiseType _type, GameObject _source) { }
}
