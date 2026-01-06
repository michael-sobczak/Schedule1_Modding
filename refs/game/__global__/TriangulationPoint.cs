public class TriangulationPoint // TypeDefIndex: 18670
{
	// Fields
	public double X; // 0x10
	public double Y; // 0x18
	[CompilerGenerated]
	private List<DTSweepConstraint> <Edges>k__BackingField; // 0x20

	// Properties
	public List<DTSweepConstraint> Edges { get; set; }
	public float Xf { get; set; }
	public float Yf { get; set; }
	public bool HasEdges { get; }

	// Methods

	// RVA: 0x1E84340 Offset: 0x1E82D40 VA: 0x181E84340
	public void .ctor(double x, double y) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public List<DTSweepConstraint> get_Edges() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_Edges(List<DTSweepConstraint> value) { }

	// RVA: 0x1E85C20 Offset: 0x1E84620 VA: 0x181E85C20 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A4D9F0 Offset: 0x1A4C3F0 VA: 0x181A4D9F0
	public float get_Xf() { }

	// RVA: 0x1A4DA30 Offset: 0x1A4C430 VA: 0x181A4DA30
	public void set_Xf(float value) { }

	// RVA: 0x1E85EA0 Offset: 0x1E848A0 VA: 0x181E85EA0
	public float get_Yf() { }

	// RVA: 0x1E85EB0 Offset: 0x1E848B0 VA: 0x181E85EB0
	public void set_Yf(float value) { }

	// RVA: 0x1E85B20 Offset: 0x1E84520 VA: 0x181E85B20
	public void AddEdge(DTSweepConstraint e) { }

	// RVA: 0x1E85E90 Offset: 0x1E84890 VA: 0x181E85E90
	public bool get_HasEdges() { }
}
