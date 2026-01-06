public class PointSet : Triangulatable // TypeDefIndex: 18663
{
	// Fields
	[CompilerGenerated]
	private IList<TriangulationPoint> <Points>k__BackingField; // 0x10
	[CompilerGenerated]
	private IList<DelaunayTriangle> <Triangles>k__BackingField; // 0x18

	// Properties
	public IList<TriangulationPoint> Points { get; set; }
	public IList<DelaunayTriangle> Triangles { get; set; }
	public virtual TriangulationMode TriangulationMode { get; }

	// Methods

	// RVA: 0x1E83A90 Offset: 0x1E82490 VA: 0x181E83A90
	public void .ctor(List<TriangulationPoint> points) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 5
	public IList<TriangulationPoint> get_Points() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_Points(IList<TriangulationPoint> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 6
	public IList<DelaunayTriangle> get_Triangles() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_Triangles(IList<DelaunayTriangle> value) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 11
	public virtual TriangulationMode get_TriangulationMode() { }

	// RVA: 0x1E83670 Offset: 0x1E82070 VA: 0x181E83670 Slot: 7
	public void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0x1E836D0 Offset: 0x1E820D0 VA: 0x181E836D0 Slot: 8
	public void AddTriangles(IEnumerable<DelaunayTriangle> list) { }

	// RVA: 0x1E83930 Offset: 0x1E82330 VA: 0x181E83930 Slot: 9
	public void ClearTriangles() { }

	// RVA: 0x1E83980 Offset: 0x1E82380 VA: 0x181E83980 Slot: 12
	public virtual void Prepare(TriangulationContext tcx) { }
}
