public class AdvancingFrontNode // TypeDefIndex: 18652
{
	// Fields
	public AdvancingFrontNode Next; // 0x10
	public AdvancingFrontNode Prev; // 0x18
	public double Value; // 0x20
	public TriangulationPoint Point; // 0x28
	public DelaunayTriangle Triangle; // 0x30

	// Properties
	public bool HasNext { get; }
	public bool HasPrev { get; }

	// Methods

	// RVA: 0x1E7A890 Offset: 0x1E79290 VA: 0x181E7A890
	public void .ctor(TriangulationPoint point) { }

	// RVA: 0x1E7A8E0 Offset: 0x1E792E0 VA: 0x181E7A8E0
	public bool get_HasNext() { }

	// RVA: 0x1E56BC0 Offset: 0x1E555C0 VA: 0x181E56BC0
	public bool get_HasPrev() { }
}
