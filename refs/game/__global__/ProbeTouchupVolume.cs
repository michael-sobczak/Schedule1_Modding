public class ProbeTouchupVolume : MonoBehaviour // TypeDefIndex: 13746
{
	// Fields
	[Range(0.0001, 2)]
	public float intensityScale; // 0x20
	public bool invalidateProbes; // 0x24
	public bool overrideDilationThreshold; // 0x25
	[Range(0, 0.99)]
	public float overriddenDilationThreshold; // 0x28
	public Vector3 size; // 0x2C

	// Methods

	// RVA: 0x2A21220 Offset: 0x2A1FC20 VA: 0x182A21220
	public void .ctor() { }
}
