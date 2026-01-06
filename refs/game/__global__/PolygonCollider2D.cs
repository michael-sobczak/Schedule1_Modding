public sealed class PolygonCollider2D : Collider2D // TypeDefIndex: 18837
{
	// Properties
	public Vector2[] points { get; set; }
	public int pathCount { get; }

	// Methods

	[NativeMethod("GetPointCount")]
	// RVA: 0x2D31490 Offset: 0x2D2FE90 VA: 0x182D31490
	public int GetTotalPointCount() { }

	[NativeMethod("GetPoints_Binding")]
	// RVA: 0x2D31510 Offset: 0x2D2FF10 VA: 0x182D31510
	public Vector2[] get_points() { }

	[NativeMethod("SetPoints_Binding")]
	// RVA: 0x2D31550 Offset: 0x2D2FF50 VA: 0x182D31550
	public void set_points(Vector2[] value) { }

	// RVA: 0x2D314D0 Offset: 0x2D2FED0 VA: 0x182D314D0
	public int get_pathCount() { }

	// RVA: 0x2D31320 Offset: 0x2D2FD20 VA: 0x182D31320
	public Vector2[] GetPath(int index) { }

	[NativeMethod("GetPath_Binding")]
	// RVA: 0x2D312E0 Offset: 0x2D2FCE0 VA: 0x182D312E0
	private Vector2[] GetPath_Internal(int index) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
