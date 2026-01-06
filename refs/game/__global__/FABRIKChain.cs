public class FABRIKChain // TypeDefIndex: 14088
{
	// Fields
	public FABRIK ik; // 0x10
	[Range(0, 1)]
	public float pull; // 0x18
	[Range(0, 1)]
	public float pin; // 0x1C
	public int[] children; // 0x20

	// Methods

	// RVA: 0x1EAE930 Offset: 0x1EAD330 VA: 0x181EAE930
	public bool IsValid(ref string message) { }

	// RVA: 0x1EAE900 Offset: 0x1EAD300 VA: 0x181EAE900
	public void Initiate() { }

	// RVA: 0x1EAEA10 Offset: 0x1EAD410 VA: 0x181EAEA10
	public void Stage1(FABRIKChain[] chain) { }

	// RVA: 0x1EAEB70 Offset: 0x1EAD570 VA: 0x181EAEB70
	public void Stage2(Vector3 rootPosition, FABRIKChain[] chain) { }

	// RVA: 0x1EAE630 Offset: 0x1EAD030 VA: 0x181EAE630
	private Vector3 GetCentroid(FABRIKChain[] chain) { }

	// RVA: 0x1EAECE0 Offset: 0x1EAD6E0 VA: 0x181EAECE0
	public void .ctor() { }
}
