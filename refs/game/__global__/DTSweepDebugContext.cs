public class DTSweepDebugContext : TriangulationDebugContext // TypeDefIndex: 18657
{
	// Fields
	private DelaunayTriangle _primaryTriangle; // 0x18
	private DelaunayTriangle _secondaryTriangle; // 0x20
	private TriangulationPoint _activePoint; // 0x28
	private AdvancingFrontNode _activeNode; // 0x30
	private DTSweepConstraint _activeConstraint; // 0x38

	// Properties
	public DelaunayTriangle PrimaryTriangle { get; set; }
	public DelaunayTriangle SecondaryTriangle { get; set; }
	public TriangulationPoint ActivePoint { get; set; }
	public AdvancingFrontNode ActiveNode { get; set; }
	public DTSweepConstraint ActiveConstraint { get; set; }
	public bool IsDebugContext { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(DTSweepContext tcx) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public DelaunayTriangle get_PrimaryTriangle() { }

	// RVA: 0x1E7C2B0 Offset: 0x1E7ACB0 VA: 0x181E7C2B0
	public void set_PrimaryTriangle(DelaunayTriangle value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public DelaunayTriangle get_SecondaryTriangle() { }

	// RVA: 0x1E7C310 Offset: 0x1E7AD10 VA: 0x181E7C310
	public void set_SecondaryTriangle(DelaunayTriangle value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public TriangulationPoint get_ActivePoint() { }

	// RVA: 0x1E7C250 Offset: 0x1E7AC50 VA: 0x181E7C250
	public void set_ActivePoint(TriangulationPoint value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public AdvancingFrontNode get_ActiveNode() { }

	// RVA: 0x1E7C1F0 Offset: 0x1E7ABF0 VA: 0x181E7C1F0
	public void set_ActiveNode(AdvancingFrontNode value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public DTSweepConstraint get_ActiveConstraint() { }

	// RVA: 0x1E7C190 Offset: 0x1E7AB90 VA: 0x181E7C190
	public void set_ActiveConstraint(DTSweepConstraint value) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	public bool get_IsDebugContext() { }

	// RVA: 0x1E7C070 Offset: 0x1E7AA70 VA: 0x181E7C070 Slot: 4
	public override void Clear() { }
}
