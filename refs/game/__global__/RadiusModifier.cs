public class RadiusModifier : MonoModifier // TypeDefIndex: 13291
{
	// Fields
	public float radius; // 0x30
	public float detail; // 0x34
	private float[] radi; // 0x38
	private float[] a1; // 0x40
	private float[] a2; // 0x48
	private bool[] dir; // 0x50

	// Properties
	public override int Order { get; }

	// Methods

	// RVA: 0xB72710 Offset: 0xB71110 VA: 0x180B72710 Slot: 15
	public override int get_Order() { }

	// RVA: 0xB72220 Offset: 0xB70C20 VA: 0x180B72220
	private bool CalculateCircleInner(Vector3 p1, Vector3 p2, float r1, float r2, out float a, out float sigma) { }

	// RVA: 0xB72370 Offset: 0xB70D70 VA: 0x180B72370
	private bool CalculateCircleOuter(Vector3 p1, Vector3 p2, float r1, float r2, out float a, out float sigma) { }

	// RVA: 0xB72550 Offset: 0xB70F50 VA: 0x180B72550
	private RadiusModifier.TangentType CalculateTangentType(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4) { }

	// RVA: 0xB724E0 Offset: 0xB70EE0 VA: 0x180B724E0
	private RadiusModifier.TangentType CalculateTangentTypeSimple(Vector3 p1, Vector3 p2, Vector3 p3) { }

	// RVA: 0xB72170 Offset: 0xB70B70 VA: 0x180B72170 Slot: 17
	public override void Apply(Path p) { }

	// RVA: 0xB71020 Offset: 0xB6FA20 VA: 0x180B71020
	public List<Vector3> Apply(List<Vector3> vs) { }

	// RVA: 0xB72630 Offset: 0xB71030 VA: 0x180B72630
	public void .ctor() { }
}
