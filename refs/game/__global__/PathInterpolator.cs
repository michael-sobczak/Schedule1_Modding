public class PathInterpolator // TypeDefIndex: 13390
{
	// Fields
	private List<Vector3> path; // 0x10
	private float distanceToSegmentStart; // 0x18
	private float currentDistance; // 0x1C
	private float currentSegmentLength; // 0x20
	private float totalDistance; // 0x24
	[CompilerGenerated]
	private int <segmentIndex>k__BackingField; // 0x28

	// Properties
	public virtual Vector3 position { get; }
	public Vector3 endPoint { get; }
	public Vector3 tangent { get; }
	public float remainingDistance { get; set; }
	public float distance { get; set; }
	public int segmentIndex { get; set; }
	public bool valid { get; }

	// Methods

	// RVA: 0xBA7F40 Offset: 0xBA6940 VA: 0x180BA7F40 Slot: 4
	public virtual Vector3 get_position() { }

	// RVA: 0xBA7EB0 Offset: 0xBA68B0 VA: 0x180BA7EB0
	public Vector3 get_endPoint() { }

	// RVA: 0xBA8080 Offset: 0xBA6A80 VA: 0x180BA8080
	public Vector3 get_tangent() { }

	// RVA: 0xBA8070 Offset: 0xBA6A70 VA: 0x180BA8070
	public float get_remainingDistance() { }

	// RVA: 0xBA8200 Offset: 0xBA6C00 VA: 0x180BA8200
	public void set_remainingDistance(float value) { }

	// RVA: 0x498A60 Offset: 0x497460 VA: 0x180498A60
	public float get_distance() { }

	// RVA: 0xBA8130 Offset: 0xBA6B30 VA: 0x180BA8130
	public void set_distance(float value) { }

	[CompilerGenerated]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_segmentIndex() { }

	[CompilerGenerated]
	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	private void set_segmentIndex(int value) { }

	// RVA: 0x82C1F0 Offset: 0x82ABF0 VA: 0x18082C1F0
	public bool get_valid() { }

	// RVA: 0xBA67C0 Offset: 0xBA51C0 VA: 0x180BA67C0
	public void GetRemainingPath(List<Vector3> buffer) { }

	// RVA: 0xBA7BA0 Offset: 0xBA65A0 VA: 0x180BA7BA0
	public void SetPath(List<Vector3> path) { }

	// RVA: 0xBA7820 Offset: 0xBA6220 VA: 0x180BA7820
	public void MoveToSegment(int index, float fractionAlongSegment) { }

	// RVA: 0xBA6F50 Offset: 0xBA5950 VA: 0x180BA6F50
	public void MoveToClosestPoint(Vector3 point) { }

	// RVA: 0xBA7230 Offset: 0xBA5C30 VA: 0x180BA7230
	public void MoveToLocallyClosestPoint(Vector3 point, bool allowForwards = True, bool allowBackwards = True) { }

	// RVA: 0xBA69D0 Offset: 0xBA53D0 VA: 0x180BA69D0
	public void MoveToCircleIntersection2D(Vector3 circleCenter3D, float radius, IMovementPlane transform) { }

	// RVA: 0xBA7AD0 Offset: 0xBA64D0 VA: 0x180BA7AD0 Slot: 5
	protected virtual void PrevSegment() { }

	// RVA: 0xBA7A00 Offset: 0xBA6400 VA: 0x180BA7A00 Slot: 6
	protected virtual void NextSegment() { }

	// RVA: 0xBA7E90 Offset: 0xBA6890 VA: 0x180BA7E90
	public void .ctor() { }
}
