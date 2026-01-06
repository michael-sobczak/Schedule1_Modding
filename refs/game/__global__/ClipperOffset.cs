internal class ClipperOffset // TypeDefIndex: 8687
{
	// Fields
	private List<List<IntPoint>> m_destPolys; // 0x10
	private List<IntPoint> m_srcPoly; // 0x18
	private List<IntPoint> m_destPoly; // 0x20
	private List<DoublePoint> m_normals; // 0x28
	private double m_delta; // 0x30
	private double m_sinA; // 0x38
	private double m_sin; // 0x40
	private double m_cos; // 0x48
	private double m_StepsPerRad; // 0x50
	private IntPoint m_lowest; // 0x58
	private PolyNode m_polyNodes; // 0x88
	[CompilerGenerated]
	private double <ArcTolerance>k__BackingField; // 0x90
	private const double two_pi = 6.283185307179586;
	private const double def_arc_tolerance = 0.25;

	// Properties
	public double ArcTolerance { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x143EED0 Offset: 0x143D8D0 VA: 0x18143EED0
	public double get_ArcTolerance() { }

	[CompilerGenerated]
	// RVA: 0x1277B60 Offset: 0x1276560 VA: 0x181277B60
	public void set_ArcTolerance(double value) { }

	// RVA: 0x2A7AC60 Offset: 0x2A79660 VA: 0x182A7AC60
	public void .ctor(double arcTolerance = 0.25) { }

	// RVA: 0x2A77500 Offset: 0x2A75F00 VA: 0x182A77500
	public void Clear() { }

	// RVA: 0xC3E650 Offset: 0xC3D050 VA: 0x180C3E650
	internal static long Round(double value) { }

	// RVA: 0x2A76E30 Offset: 0x2A75830 VA: 0x182A76E30
	public void AddPath(List<IntPoint> path, JoinType joinType, EndType endType) { }

	// RVA: 0x2A773C0 Offset: 0x2A75DC0 VA: 0x182A773C0
	public void AddPaths(List<List<IntPoint>> paths, JoinType joinType, EndType endType) { }

	// RVA: 0x2A7A020 Offset: 0x2A78A20 VA: 0x182A7A020
	private void FixOrientations() { }

	// RVA: 0x2A7A200 Offset: 0x2A78C00 VA: 0x182A7A200
	internal static DoublePoint GetUnitNormal(IntPoint pt1, IntPoint pt2) { }

	// RVA: 0x2A778B0 Offset: 0x2A762B0 VA: 0x182A778B0
	private void DoOffset(double delta) { }

	// RVA: 0x2A79B10 Offset: 0x2A78510 VA: 0x182A79B10
	public void Execute(ref List<List<IntPoint>> solution, double delta, int inputSize) { }

	// RVA: 0x2A79490 Offset: 0x2A77E90 VA: 0x182A79490
	public void Execute(ref PolyTree solution, double delta) { }

	// RVA: 0x2A7A310 Offset: 0x2A78D10 VA: 0x182A7A310
	private void OffsetPoint(int j, ref int k, JoinType jointype) { }

	// RVA: 0x2A78DD0 Offset: 0x2A777D0 VA: 0x182A78DD0
	internal void DoSquare(int j, int k) { }

	// RVA: 0x2A77570 Offset: 0x2A75F70 VA: 0x182A77570
	internal void DoMiter(int j, int k, double r) { }

	// RVA: 0x2A78800 Offset: 0x2A77200 VA: 0x182A78800
	internal void DoRound(int j, int k) { }
}
