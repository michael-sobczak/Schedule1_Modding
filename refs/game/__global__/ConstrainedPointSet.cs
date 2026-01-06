public class ConstrainedPointSet : PointSet // TypeDefIndex: 18662
{
	// Fields
	[CompilerGenerated]
	private int[] <EdgeIndex>k__BackingField; // 0x20

	// Properties
	public int[] EdgeIndex { get; set; }
	public override TriangulationMode TriangulationMode { get; }

	// Methods

	// RVA: 0x1E7AF60 Offset: 0x1E79960 VA: 0x181E7AF60
	public void .ctor(List<TriangulationPoint> points, int[] index) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public int[] get_EdgeIndex() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_EdgeIndex(int[] value) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 11
	public override TriangulationMode get_TriangulationMode() { }

	// RVA: 0x1E7AC60 Offset: 0x1E79660 VA: 0x181E7AC60 Slot: 12
	public override void Prepare(TriangulationContext tcx) { }
}
