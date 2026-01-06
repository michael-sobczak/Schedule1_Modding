public sealed class CompositeCollider2D : Collider2D // TypeDefIndex: 18838
{
	// Properties
	public int pathCount { get; }
	public int pointCount { get; }

	// Methods

	// RVA: 0x2D2E030 Offset: 0x2D2CA30 VA: 0x182D2E030
	public int get_pathCount() { }

	// RVA: 0x2D2E070 Offset: 0x2D2CA70 VA: 0x182D2E070
	public int get_pointCount() { }

	// RVA: 0x2D2DEA0 Offset: 0x2D2C8A0 VA: 0x182D2DEA0
	public int GetPath(int index, Vector2[] points) { }

	[NativeMethod("GetPathArray_Binding")]
	// RVA: 0x2D2DE50 Offset: 0x2D2C850 VA: 0x182D2DE50
	private int GetPathArray_Internal(int index, Vector2[] points) { }
}
