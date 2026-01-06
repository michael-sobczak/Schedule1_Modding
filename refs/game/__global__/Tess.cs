public class Tess // TypeDefIndex: 10800
{
	// Fields
	private LTMesh _mesh; // 0x10
	private Vec3 _normal; // 0x18
	private Vec3 _sUnit; // 0x24
	private Vec3 _tUnit; // 0x30
	private float _bminX; // 0x3C
	private float _bminY; // 0x40
	private float _bmaxX; // 0x44
	private float _bmaxY; // 0x48
	private WindingRule _windingRule; // 0x4C
	private Dict<Tess.ActiveRegion> _dict; // 0x50
	private PriorityQueue<MeshUtils.Vertex> _pq; // 0x58
	private MeshUtils.Vertex _event; // 0x60
	private CombineCallback _combineCallback; // 0x68
	private ContourVertex[] _vertices; // 0x70
	private int _vertexCount; // 0x78
	private Nullable<SubArray<int>> elementsList; // 0x80
	private int _elementCount; // 0x98
	public float SUnitX; // 0x9C
	public float SUnitY; // 0xA0
	public float SentinelCoord; // 0xA4
	public bool NoEmptyPolygons; // 0xA8
	public bool UsePooling; // 0xA9

	// Properties
	public Vec3 Normal { get; set; }
	public ContourVertex[] Vertices { get; }
	public int VertexCount { get; }
	[Obsolete("Use ElementsArray instead")]
	public int[] Elements { get; }
	[Obsolete("Use ElementsArray instead")]
	public IList<int> ElementsList { get; }
	public Nullable<SubArray<int>> ElementsArray { get; }
	public int ElementCount { get; }

	// Methods

	// RVA: 0x552380 Offset: 0x550D80 VA: 0x180552380
	private Tess.ActiveRegion RegionBelow(Tess.ActiveRegion reg) { }

	// RVA: 0x552350 Offset: 0x550D50 VA: 0x180552350
	private Tess.ActiveRegion RegionAbove(Tess.ActiveRegion reg) { }

	// RVA: 0x550710 Offset: 0x54F110 VA: 0x180550710
	private bool EdgeLeq(Tess.ActiveRegion reg1, Tess.ActiveRegion reg2) { }

	// RVA: 0x550510 Offset: 0x54EF10 VA: 0x180550510
	private void DeleteRegion(Tess.ActiveRegion reg) { }

	// RVA: 0x550AC0 Offset: 0x54F4C0 VA: 0x180550AC0
	private void FixUpperEdge(Tess.ActiveRegion reg, MeshUtils.Edge newEdge) { }

	// RVA: 0x552E10 Offset: 0x551810 VA: 0x180552E10
	private Tess.ActiveRegion TopLeftRegion(Tess.ActiveRegion reg) { }

	// RVA: 0x552F50 Offset: 0x551950 VA: 0x180552F50
	private Tess.ActiveRegion TopRightRegion(Tess.ActiveRegion reg) { }

	// RVA: 0x54D320 Offset: 0x54BD20 VA: 0x18054D320
	private Tess.ActiveRegion AddRegionBelow(Tess.ActiveRegion regAbove, MeshUtils.Edge eNewUp) { }

	// RVA: 0x54FC80 Offset: 0x54E680 VA: 0x18054FC80
	private void ComputeWinding(Tess.ActiveRegion reg) { }

	// RVA: 0x550A20 Offset: 0x54F420 VA: 0x180550A20
	private void FinishRegion(Tess.ActiveRegion reg) { }

	// RVA: 0x550880 Offset: 0x54F280 VA: 0x180550880
	private MeshUtils.Edge FinishLeftRegions(Tess.ActiveRegion regFirst, Tess.ActiveRegion regLast) { }

	// RVA: 0x54D410 Offset: 0x54BE10 VA: 0x18054D410
	private void AddRightEdges(Tess.ActiveRegion regUp, MeshUtils.Edge eFirst, MeshUtils.Edge eLast, MeshUtils.Edge eTopLeft, bool cleanUp) { }

	// RVA: 0x552740 Offset: 0x551140 VA: 0x180552740
	private void SpliceMergeVertices(MeshUtils.Edge e1, MeshUtils.Edge e2) { }

	// RVA: 0x552FC0 Offset: 0x5519C0 VA: 0x180552FC0
	private void VertexWeights(MeshUtils.Vertex isect, MeshUtils.Vertex org, MeshUtils.Vertex dst, out float w0, out float w1) { }

	// RVA: 0x550B30 Offset: 0x54F530 VA: 0x180550B30
	private void GetIntersectData(MeshUtils.Vertex isect, MeshUtils.Vertex orgUp, MeshUtils.Vertex dstUp, MeshUtils.Vertex orgLo, MeshUtils.Vertex dstLo) { }

	// RVA: 0x54E2D0 Offset: 0x54CCD0 VA: 0x18054E2D0
	private bool CheckForRightSplice(Tess.ActiveRegion regUp) { }

	// RVA: 0x54E0D0 Offset: 0x54CAD0 VA: 0x18054E0D0
	private bool CheckForLeftSplice(Tess.ActiveRegion regUp) { }

	// RVA: 0x54D870 Offset: 0x54C270 VA: 0x18054D870
	private bool CheckForIntersect(Tess.ActiveRegion regUp) { }

	// RVA: 0x5530C0 Offset: 0x551AC0 VA: 0x1805530C0
	private void WalkDirtyRegions(Tess.ActiveRegion regUp) { }

	// RVA: 0x550270 Offset: 0x54EC70 VA: 0x180550270
	private void ConnectRightVertex(Tess.ActiveRegion regUp, MeshUtils.Edge eBottomLeft) { }

	// RVA: 0x54FCE0 Offset: 0x54E6E0 VA: 0x18054FCE0
	private void ConnectLeftDegenerate(Tess.ActiveRegion regUp, MeshUtils.Vertex vEvent) { }

	// RVA: 0x54FE60 Offset: 0x54E860 VA: 0x18054FE60
	private void ConnectLeftVertex(MeshUtils.Vertex vEvent) { }

	// RVA: 0x552760 Offset: 0x551160 VA: 0x180552760
	private void SweepEvent(MeshUtils.Vertex vEvent) { }

	// RVA: 0x54D710 Offset: 0x54C110 VA: 0x18054D710
	private void AddSentinel(float smin, float smax, float t) { }

	// RVA: 0x551050 Offset: 0x54FA50 VA: 0x180551050
	private void InitEdgeDict() { }

	// RVA: 0x550600 Offset: 0x54F000 VA: 0x180550600
	private void DoneEdgeDict() { }

	// RVA: 0x5523B0 Offset: 0x550DB0 VA: 0x1805523B0
	private void RemoveDegenerateEdges() { }

	// RVA: 0x551150 Offset: 0x54FB50 VA: 0x180551150
	private void InitPriorityQ() { }

	// RVA: 0x5506F0 Offset: 0x54F0F0 VA: 0x1805506F0
	private void DonePriorityQ() { }

	// RVA: 0x552520 Offset: 0x550F20 VA: 0x180552520
	private void RemoveDegenerateFaces() { }

	// RVA: 0x54E640 Offset: 0x54D040 VA: 0x18054E640
	protected void ComputeInterior() { }

	// RVA: 0x4D8950 Offset: 0x4D7350 VA: 0x1804D8950
	public Vec3 get_Normal() { }

	// RVA: 0x4D8970 Offset: 0x4D7370 VA: 0x1804D8970
	public void set_Normal(Vec3 value) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public ContourVertex[] get_Vertices() { }

	// RVA: 0x553640 Offset: 0x552040 VA: 0x180553640
	public int get_VertexCount() { }

	// RVA: 0x553590 Offset: 0x551F90 VA: 0x180553590
	public int[] get_Elements() { }

	// RVA: 0x553590 Offset: 0x551F90 VA: 0x180553590
	public IList<int> get_ElementsList() { }

	// RVA: 0x553570 Offset: 0x551F70 VA: 0x180553570
	public Nullable<SubArray<int>> get_ElementsArray() { }

	// RVA: 0x4B62D0 Offset: 0x4B4CD0 VA: 0x1804B62D0
	public int get_ElementCount() { }

	// RVA: 0x5534A0 Offset: 0x551EA0 VA: 0x1805534A0
	public void .ctor() { }

	// RVA: 0x54F3D0 Offset: 0x54DDD0 VA: 0x18054F3D0
	private void ComputeNormal(ref Vec3 norm) { }

	// RVA: 0x54E510 Offset: 0x54CF10 VA: 0x18054E510
	private void CheckOrientation() { }

	// RVA: 0x551EE0 Offset: 0x5508E0 VA: 0x180551EE0
	private void ProjectPolygon() { }

	// RVA: 0x5528F0 Offset: 0x5512F0 VA: 0x1805528F0
	private void TessellateMonoRegion(MeshUtils.Face face) { }

	// RVA: 0x552880 Offset: 0x551280 VA: 0x180552880
	private void TessellateInterior() { }

	// RVA: 0x550590 Offset: 0x54EF90 VA: 0x180550590
	private void DiscardExterior() { }

	// RVA: 0x5525C0 Offset: 0x550FC0 VA: 0x1805525C0
	private void SetWindingNumber(int value, bool keepOnlyBoundary) { }

	// RVA: 0x550FF0 Offset: 0x54F9F0 VA: 0x180550FF0
	private int GetNeighbourFace(MeshUtils.Edge edge) { }

	// RVA: 0x5517D0 Offset: 0x5501D0 VA: 0x1805517D0
	private void OutputPolymesh(ElementType elementType, int polySize) { }

	// RVA: 0x551350 Offset: 0x54FD50 VA: 0x180551350
	private void OutputContours() { }

	// RVA: 0x5526B0 Offset: 0x5510B0 VA: 0x1805526B0
	private float SignedArea(ContourVertex[] vertices) { }

	// RVA: 0x54D310 Offset: 0x54BD10 VA: 0x18054D310
	public void AddContour(ContourVertex[] vertices) { }

	// RVA: 0x54D0B0 Offset: 0x54BAB0 VA: 0x18054D0B0
	public void AddContour(ContourVertex[] vertices, ContourOrientation forceOrientation) { }

	// RVA: 0x552BA0 Offset: 0x5515A0 VA: 0x180552BA0
	public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize) { }

	// RVA: 0x552BC0 Offset: 0x5515C0 VA: 0x180552BC0
	public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize, CombineCallback combineCallback) { }
}
