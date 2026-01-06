public class CGPath : CGShape // TypeDefIndex: 10649
{
	// Fields
	private SubArray<Vector3> directions; // 0x98

	// Properties
	public SubArray<Vector3> Directions { get; set; }
	[UsedImplicitly]
	[Obsolete("Use Directions instead")]
	public Vector3[] Direction { get; set; }

	// Methods

	// RVA: 0x4F6260 Offset: 0x4F4C60 VA: 0x1804F6260
	public SubArray<Vector3> get_Directions() { }

	// RVA: 0x4F63A0 Offset: 0x4F4DA0 VA: 0x1804F63A0
	public void set_Directions(SubArray<Vector3> value) { }

	// RVA: 0x4F61B0 Offset: 0x4F4BB0 VA: 0x1804F61B0
	public Vector3[] get_Direction() { }

	// RVA: 0x4F6270 Offset: 0x4F4C70 VA: 0x1804F6270
	public void set_Direction(Vector3[] value) { }

	// RVA: 0x4F5F40 Offset: 0x4F4940 VA: 0x1804F5F40
	public void .ctor() { }

	// RVA: 0x4F6040 Offset: 0x4F4A40 VA: 0x1804F6040
	public void .ctor(CGPath source) { }

	// RVA: 0x4F59F0 Offset: 0x4F43F0 VA: 0x1804F59F0 Slot: 5
	protected override bool Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 7
	public override T Clone<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5C940 Offset: 0xE5B340 VA: 0x180E5C940
	|-CGPath.Clone<object>
	*/

	// RVA: 0x4F58E0 Offset: 0x4F42E0 VA: 0x1804F58E0
	public static void Copy(CGPath dest, CGPath source) { }

	// RVA: 0x4F5CE0 Offset: 0x4F46E0 VA: 0x1804F5CE0
	public void Interpolate(float f, out Vector3 position, out Vector3 direction, out Vector3 up) { }

	[UsedImplicitly]
	[Obsolete("Method is no more used by Curvy and will get removed. Copy its content if you still need it")]
	// RVA: 0x4F5C10 Offset: 0x4F4610 VA: 0x1804F5C10
	public void Interpolate(float f, float angleF, out Vector3 pos, out Vector3 dir, out Vector3 up) { }

	// RVA: 0x4F5AF0 Offset: 0x4F44F0 VA: 0x1804F5AF0
	public Vector3 InterpolateDirection(float f) { }
}
