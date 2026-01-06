public class SimpleSmoothModifier : MonoModifier // TypeDefIndex: 13296
{
	// Fields
	public SimpleSmoothModifier.SmoothType smoothType; // 0x30
	[Tooltip("The number of times to subdivide (divide in half) the path segments. [0...inf] (recommended [1...10])")]
	public int subdivisions; // 0x34
	[Tooltip("Number of times to apply smoothing")]
	public int iterations; // 0x38
	[Range(0, 1)]
	[Tooltip("Determines how much smoothing to apply in each smooth iteration. 0.5 usually produces the nicest looking curves")]
	public float strength; // 0x3C
	[Tooltip("Toggle to divide all lines in equal length segments")]
	public bool uniformLength; // 0x40
	[Tooltip("The length of each segment in the smoothed path. A high value yields rough paths and low value yields very smooth paths, but is slower")]
	public float maxSegmentLength; // 0x44
	[Tooltip("Length factor of the bezier curves' tangents")]
	public float bezierTangentLength; // 0x48
	[Tooltip("Offset to apply in each smoothing iteration when using Offset Simple")]
	public float offset; // 0x4C
	[Tooltip("How much to smooth the path. A higher value will give a smoother path, but might take the character far off the optimal path.")]
	public float factor; // 0x50

	// Properties
	public override int Order { get; }

	// Methods

	// RVA: 0xB791E0 Offset: 0xB77BE0 VA: 0x180B791E0 Slot: 15
	public override int get_Order() { }

	// RVA: 0xB77010 Offset: 0xB75A10 VA: 0x180B77010 Slot: 17
	public override void Apply(Path p) { }

	// RVA: 0xB77160 Offset: 0xB75B60 VA: 0x180B77160
	public List<Vector3> CurvedNonuniform(List<Vector3> path) { }

	// RVA: 0xB77920 Offset: 0xB76320 VA: 0x180B77920
	public static Vector3 GetPointOnCubic(Vector3 a, Vector3 b, Vector3 tan1, Vector3 tan2, float t) { }

	// RVA: 0xB77FC0 Offset: 0xB769C0 VA: 0x180B77FC0
	public List<Vector3> SmoothOffsetSimple(List<Vector3> path) { }

	// RVA: 0xB789E0 Offset: 0xB773E0 VA: 0x180B789E0
	public List<Vector3> SmoothSimple(List<Vector3> path) { }

	// RVA: 0xB77AC0 Offset: 0xB764C0 VA: 0x180B77AC0
	public List<Vector3> SmoothBezier(List<Vector3> path) { }

	// RVA: 0xB791A0 Offset: 0xB77BA0 VA: 0x180B791A0
	public void .ctor() { }
}
