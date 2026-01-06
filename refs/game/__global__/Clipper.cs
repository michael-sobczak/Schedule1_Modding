public class Clipper : ClipperBase // TypeDefIndex: 18147
{
	// Fields
	public const int ioReverseSolution = 1;
	public const int ioStrictlySimple = 2;
	public const int ioPreserveCollinear = 4;
	private List<OutRec> m_PolyOuts; // 0x30
	private ClipType m_ClipType; // 0x38
	private Scanbeam m_Scanbeam; // 0x40
	private TEdge m_ActiveEdges; // 0x48
	private TEdge m_SortedEdges; // 0x50
	private IntersectNode m_IntersectNodes; // 0x58
	private bool m_ExecuteLocked; // 0x60
	private PolyFillType m_ClipFillType; // 0x64
	private PolyFillType m_SubjFillType; // 0x68
	private List<Join> m_Joins; // 0x70
	private List<Join> m_GhostJoins; // 0x78
	private bool m_UsingPolyTree; // 0x80
	[CompilerGenerated]
	private bool <ReverseSolution>k__BackingField; // 0x81
	[CompilerGenerated]
	private bool <StrictlySimple>k__BackingField; // 0x82
	[CompilerGenerated]
	private static Action<List<IntPoint>> <>f__am$cacheE; // 0x0
	[CompilerGenerated]
	private static Action<List<IntPoint>> <>f__am$cacheF; // 0x8

	// Properties
	public bool ReverseSolution { get; set; }
	public bool StrictlySimple { get; set; }

	// Methods

	// RVA: 0x1E2C280 Offset: 0x1E2AC80 VA: 0x181E2C280
	public void .ctor(int InitOptions = 0) { }

	// RVA: 0x1E223C0 Offset: 0x1E20DC0 VA: 0x181E223C0 Slot: 4
	public override void Clear() { }

	// RVA: 0x1E22BF0 Offset: 0x1E215F0 VA: 0x181E22BF0
	private void DisposeScanbeamList() { }

	// RVA: 0x1E2A950 Offset: 0x1E29350 VA: 0x181E2A950 Slot: 5
	protected override void Reset() { }

	[CompilerGenerated]
	// RVA: 0x1D85F50 Offset: 0x1D84950 VA: 0x181D85F50
	public bool get_ReverseSolution() { }

	[CompilerGenerated]
	// RVA: 0x1D86120 Offset: 0x1D84B20 VA: 0x181D86120
	public void set_ReverseSolution(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1D32B60 Offset: 0x1D31560 VA: 0x181D32B60
	public bool get_StrictlySimple() { }

	[CompilerGenerated]
	// RVA: 0x1D32D10 Offset: 0x1D31710 VA: 0x181D32D10
	public void set_StrictlySimple(bool value) { }

	// RVA: 0x1E252A0 Offset: 0x1E23CA0 VA: 0x181E252A0
	private void InsertScanbeam(long Y) { }

	// RVA: 0x1E23800 Offset: 0x1E22200 VA: 0x181E23800
	public bool Execute(ClipType clipType, List<List<IntPoint>> solution, PolyFillType subjFillType, PolyFillType clipFillType) { }

	// RVA: 0x1E23990 Offset: 0x1E22390 VA: 0x181E23990
	public bool Execute(ClipType clipType, PolyTree polytree, PolyFillType subjFillType, PolyFillType clipFillType) { }

	// RVA: 0x1E237E0 Offset: 0x1E221E0 VA: 0x181E237E0
	public bool Execute(ClipType clipType, List<List<IntPoint>> solution) { }

	// RVA: 0x1E23920 Offset: 0x1E22320 VA: 0x181E23920
	public bool Execute(ClipType clipType, PolyTree polytree) { }

	// RVA: 0xC36470 Offset: 0xC34E70 VA: 0x180C36470
	internal void FixHoleLinkage(OutRec outRec) { }

	// RVA: 0x1E234D0 Offset: 0x1E21ED0 VA: 0x181E234D0
	private bool ExecuteInternal() { }

	// RVA: 0x1E29740 Offset: 0x1E28140 VA: 0x181E29740
	private long PopScanbeam() { }

	// RVA: 0x1E22920 Offset: 0x1E21320 VA: 0x181E22920
	private void DisposeAllPolyPts() { }

	// RVA: 0x1E22B30 Offset: 0x1E21530 VA: 0x181E22B30
	private void DisposeOutRec(int index) { }

	// RVA: 0x1E22AE0 Offset: 0x1E214E0 VA: 0x181E22AE0
	private void DisposeOutPts(OutPt pp) { }

	// RVA: 0x1E20000 Offset: 0x1E1EA00 VA: 0x181E20000
	private void AddJoin(OutPt Op1, OutPt Op2, IntPoint OffPt) { }

	// RVA: 0x1E1FF00 Offset: 0x1E1E900 VA: 0x181E1FF00
	private void AddGhostJoin(OutPt Op, IntPoint OffPt) { }

	// RVA: 0x1E24CE0 Offset: 0x1E236E0 VA: 0x181E24CE0
	private void InsertLocalMinimaIntoAEL(long botY) { }

	// RVA: 0x1E249F0 Offset: 0x1E233F0 VA: 0x181E249F0
	private void InsertEdgeIntoAEL(TEdge edge, TEdge startEdge) { }

	// RVA: 0x1E23370 Offset: 0x1E21D70 VA: 0x181E23370
	private bool E2InsertsBeforeE1(TEdge e1, TEdge e2) { }

	// RVA: 0x1E25F70 Offset: 0x1E24970 VA: 0x181E25F70
	private bool IsEvenOddFillType(TEdge edge) { }

	// RVA: 0x1E25F40 Offset: 0x1E24940 VA: 0x181E25F40
	private bool IsEvenOddAltFillType(TEdge edge) { }

	// RVA: 0x1E25DA0 Offset: 0x1E247A0 VA: 0x181E25DA0
	private bool IsContributing(TEdge edge) { }

	// RVA: 0x1E2AE70 Offset: 0x1E29870 VA: 0x181E2AE70
	private void SetWindingCount(TEdge edge) { }

	// RVA: 0x1E1FE10 Offset: 0x1E1E810 VA: 0x181E1FE10
	private void AddEdgeToSEL(TEdge edge) { }

	// RVA: 0x1E225E0 Offset: 0x1E20FE0 VA: 0x181E225E0
	private void CopyAELToSEL() { }

	// RVA: 0x1E2B900 Offset: 0x1E2A300 VA: 0x181E2B900
	private void SwapPositionsInAEL(TEdge edge1, TEdge edge2) { }

	// RVA: 0x1E2BC10 Offset: 0x1E2A610 VA: 0x181E2BC10
	private void SwapPositionsInSEL(TEdge edge1, TEdge edge2) { }

	// RVA: 0x1E20120 Offset: 0x1E1EB20 VA: 0x181E20120
	private void AddLocalMaxPoly(TEdge e1, TEdge e2, IntPoint pt) { }

	// RVA: 0x1E201C0 Offset: 0x1E1EBC0 VA: 0x181E201C0
	private OutPt AddLocalMinPoly(TEdge e1, TEdge e2, IntPoint pt) { }

	// RVA: 0x1E22650 Offset: 0x1E21050 VA: 0x181E22650
	private OutRec CreateOutRec() { }

	// RVA: 0x1E203E0 Offset: 0x1E1EDE0 VA: 0x181E203E0
	private OutPt AddOutPt(TEdge e, IntPoint pt) { }

	// RVA: 0x1E2B8F0 Offset: 0x1E2A2F0 VA: 0x181E2B8F0
	internal void SwapPoints(ref IntPoint pt1, ref IntPoint pt2) { }

	// RVA: 0x1E24920 Offset: 0x1E23320 VA: 0x181E24920
	private bool HorzSegmentsOverlap(IntPoint Pt1a, IntPoint Pt1b, IntPoint Pt2a, IntPoint Pt2b) { }

	// RVA: 0x1E25170 Offset: 0x1E23B70 VA: 0x181E25170
	private OutPt InsertPolyPtBetween(OutPt p1, OutPt p2, IntPoint pt) { }

	// RVA: 0x1E2ADA0 Offset: 0x1E297A0 VA: 0x181E2ADA0
	private void SetHoleState(TEdge e, OutRec outRec) { }

	// RVA: 0xC37220 Offset: 0xC35C20 VA: 0x180C37220
	private double GetDx(IntPoint pt1, IntPoint pt2) { }

	// RVA: 0x1E23A10 Offset: 0x1E22410 VA: 0x181E23A10
	private bool FirstIsBottomPt(OutPt btmPt1, OutPt btmPt2) { }

	// RVA: 0x1E24370 Offset: 0x1E22D70 VA: 0x181E24370
	private OutPt GetBottomPt(OutPt pp) { }

	// RVA: 0x1E24460 Offset: 0x1E22E60 VA: 0x181E24460
	private OutRec GetLowermostRec(OutRec outRec1, OutRec outRec2) { }

	// RVA: 0xC3BC10 Offset: 0xC3A610 VA: 0x180C3BC10
	private bool Param1RightOfParam2(OutRec outRec1, OutRec outRec2) { }

	// RVA: 0x1E24640 Offset: 0x1E23040 VA: 0x181E24640
	private OutRec GetOutRec(int idx) { }

	// RVA: 0x1E20840 Offset: 0x1E1F240 VA: 0x181E20840
	private void AppendPolygon(TEdge e1, TEdge e2) { }

	// RVA: 0xC3E5E0 Offset: 0xC3CFE0 VA: 0x180C3E5E0
	private void ReversePolyPtLinks(OutPt pp) { }

	// RVA: 0xC3F190 Offset: 0xC3DB90 VA: 0x180C3F190
	private static void SwapSides(TEdge edge1, TEdge edge2) { }

	// RVA: 0xC3EE50 Offset: 0xC3D850 VA: 0x180C3EE50
	private static void SwapPolyIndexes(TEdge edge1, TEdge edge2) { }

	// RVA: 0x1E25410 Offset: 0x1E23E10 VA: 0x181E25410
	private void IntersectEdges(TEdge e1, TEdge e2, IntPoint pt, bool protect = False) { }

	// RVA: 0x1E227A0 Offset: 0x1E211A0 VA: 0x181E227A0
	private void DeleteFromAEL(TEdge e) { }

	// RVA: 0x1E22860 Offset: 0x1E21260 VA: 0x181E22860
	private void DeleteFromSEL(TEdge e) { }

	// RVA: 0x1E2C050 Offset: 0x1E2AA50 VA: 0x181E2C050
	private void UpdateEdgeIntoAEL(ref TEdge e) { }

	// RVA: 0x1E2A500 Offset: 0x1E28F00 VA: 0x181E2A500
	private void ProcessHorizontals(bool isTopOfScanbeam) { }

	// RVA: 0xC37260 Offset: 0xC35C60 VA: 0x180C37260
	private void GetHorzDirection(TEdge HorzEdge, out Direction Dir, out long Left, out long Right) { }

	// RVA: 0x1E29780 Offset: 0x1E28180 VA: 0x181E29780
	private void PrepareHorzJoins(TEdge horzEdge, bool isTopOfScanbeam) { }

	// RVA: 0x1E29E30 Offset: 0x1E28830 VA: 0x181E29E30
	private void ProcessHorizontal(TEdge horzEdge, bool isTopOfScanbeam) { }

	// RVA: 0x1E24610 Offset: 0x1E23010 VA: 0x181E24610
	private TEdge GetNextInAEL(TEdge e, Direction Direction) { }

	// RVA: 0x1E26010 Offset: 0x1E24A10 VA: 0x181E26010
	private bool IsMinima(TEdge e) { }

	// RVA: 0x1E25FE0 Offset: 0x1E249E0 VA: 0x181E25FE0
	private bool IsMaxima(TEdge e, double Y) { }

	// RVA: 0x1E25FA0 Offset: 0x1E249A0 VA: 0x181E25FA0
	private bool IsIntermediate(TEdge e, double Y) { }

	// RVA: 0x1E24550 Offset: 0x1E22F50 VA: 0x181E24550
	private TEdge GetMaximaPair(TEdge e) { }

	// RVA: 0x1E2A6D0 Offset: 0x1E290D0 VA: 0x181E2A6D0
	private bool ProcessIntersections(long botY, long topY) { }

	// RVA: 0x1E21350 Offset: 0x1E1FD50 VA: 0x181E21350
	private void BuildIntersectList(long botY, long topY) { }

	// RVA: 0x1E23480 Offset: 0x1E21E80 VA: 0x181E23480
	private bool EdgesAdjacent(IntersectNode inode) { }

	// RVA: 0x1E23F60 Offset: 0x1E22960 VA: 0x181E23F60
	private bool FixupIntersectionOrder() { }

	// RVA: 0x1E2A600 Offset: 0x1E29000 VA: 0x181E2A600
	private void ProcessIntersectList() { }

	// RVA: 0x1E2AD70 Offset: 0x1E29770 VA: 0x181E2AD70
	internal static long Round(double value) { }

	// RVA: 0x1E2BF20 Offset: 0x1E2A920 VA: 0x181E2BF20
	private static long TopX(TEdge edge, long currentY) { }

	// RVA: 0x1E24BA0 Offset: 0x1E235A0 VA: 0x181E24BA0
	private void InsertIntersectNode(TEdge e1, TEdge e2, IntPoint pt) { }

	// RVA: 0x1E2B840 Offset: 0x1E2A240 VA: 0x181E2B840
	private void SwapIntersectNodes(IntersectNode int1, IntersectNode int2) { }

	// RVA: 0x1E259E0 Offset: 0x1E243E0 VA: 0x181E259E0
	private bool IntersectPoint(TEdge edge1, TEdge edge2, out IntPoint ip) { }

	// RVA: 0x1E22A70 Offset: 0x1E21470 VA: 0x181E22A70
	private void DisposeIntersectNodes() { }

	// RVA: 0x1E29990 Offset: 0x1E28390 VA: 0x181E29990
	private void ProcessEdgesAtTopOfScanbeam(long topY) { }

	// RVA: 0x1E22CA0 Offset: 0x1E216A0 VA: 0x181E22CA0
	private void DoMaxima(TEdge e) { }

	// RVA: 0x1E2AB90 Offset: 0x1E29590 VA: 0x181E2AB90
	public static void ReversePaths(List<List<IntPoint>> polys) { }

	// RVA: 0x1E293B0 Offset: 0x1E27DB0 VA: 0x181E293B0
	public static bool Orientation(List<IntPoint> poly) { }

	// RVA: 0xC3BC60 Offset: 0xC3A660 VA: 0x180C3BC60
	private int PointCount(OutPt pts) { }

	// RVA: 0x1E21A80 Offset: 0x1E20480 VA: 0x181E21A80
	private void BuildResult(List<List<IntPoint>> polyg) { }

	// RVA: 0x1E216D0 Offset: 0x1E200D0 VA: 0x181E216D0
	private void BuildResult2(PolyTree polytree) { }

	// RVA: 0x1E24090 Offset: 0x1E22A90 VA: 0x181E24090
	private void FixupOutPolygon(OutRec outRec) { }

	// RVA: 0x1E23230 Offset: 0x1E21C30 VA: 0x181E23230
	private OutPt DupOutPt(OutPt outPt, bool InsertAfter) { }

	// RVA: 0x1E246F0 Offset: 0x1E230F0 VA: 0x181E246F0
	private bool GetOverlap(long a1, long a2, long b1, long b2, out long Left, out long Right) { }

	// RVA: 0x1E26D70 Offset: 0x1E25770 VA: 0x181E26D70
	private bool JoinHorz(OutPt op1, OutPt op1b, OutPt op2, OutPt op2b, IntPoint Pt, bool DiscardLeft) { }

	// RVA: 0x1E27170 Offset: 0x1E25B70 VA: 0x181E27170
	private bool JoinPoints(Join j, out OutPt p1, out OutPt p2) { }

	// RVA: 0x1E29410 Offset: 0x1E27E10 VA: 0x181E29410
	private bool Poly2ContainsPoly1(OutPt outPt1, OutPt outPt2, bool UseFullRange) { }

	// RVA: 0x1E23D30 Offset: 0x1E22730 VA: 0x181E23D30
	private void FixupFirstLefts1(OutRec OldOutRec, OutRec NewOutRec) { }

	// RVA: 0x1E23E30 Offset: 0x1E22830 VA: 0x181E23E30
	private void FixupFirstLefts2(OutRec OldOutRec, OutRec NewOutRec) { }

	// RVA: 0x1E26050 Offset: 0x1E24A50 VA: 0x181E26050
	private void JoinCommonEdges() { }

	// RVA: 0xC3F3E0 Offset: 0xC3DDE0 VA: 0x180C3F3E0
	private void UpdateOutPtIdxs(OutRec outrec) { }

	// RVA: 0x1E22FA0 Offset: 0x1E219A0 VA: 0x181E22FA0
	private void DoSimplePolygons() { }

	// RVA: 0x1E21180 Offset: 0x1E1FB80 VA: 0x181E21180
	public static double Area(List<IntPoint> poly) { }

	// RVA: 0x1E21110 Offset: 0x1E1FB10 VA: 0x181E21110
	private double Area(OutRec outRec) { }

	// RVA: 0x1E24820 Offset: 0x1E23220 VA: 0x181E24820
	internal static DoublePoint GetUnitNormal(IntPoint pt1, IntPoint pt2) { }

	// RVA: 0x1E2C030 Offset: 0x1E2AA30 VA: 0x181E2C030
	internal static bool UpdateBotPt(IntPoint pt, ref IntPoint botPt) { }

	// RVA: 0x1E2B4C0 Offset: 0x1E29EC0 VA: 0x181E2B4C0
	internal static bool StripDupsAndGetBotPt(List<IntPoint> in_path, List<IntPoint> out_path, bool closed, out IntPoint botPt) { }

	// RVA: 0x1E28DD0 Offset: 0x1E277D0 VA: 0x181E28DD0
	public static List<List<IntPoint>> OffsetPaths(List<List<IntPoint>> polys, double delta, JoinType jointype, EndType endtype, double MiterLimit) { }

	// RVA: 0x1E29200 Offset: 0x1E27C00 VA: 0x181E29200
	public static List<List<IntPoint>> OffsetPolygons(List<List<IntPoint>> poly, double delta, JoinType jointype, double MiterLimit, bool AutoFix) { }

	// RVA: 0x1E29220 Offset: 0x1E27C20 VA: 0x181E29220
	public static List<List<IntPoint>> OffsetPolygons(List<List<IntPoint>> poly, double delta, JoinType jointype, double MiterLimit) { }

	// RVA: 0x1E291D0 Offset: 0x1E27BD0 VA: 0x181E291D0
	public static List<List<IntPoint>> OffsetPolygons(List<List<IntPoint>> polys, double delta, JoinType jointype) { }

	// RVA: 0x1E291A0 Offset: 0x1E27BA0 VA: 0x181E291A0
	public static List<List<IntPoint>> OffsetPolygons(List<List<IntPoint>> polys, double delta) { }

	// RVA: 0x1E2AC80 Offset: 0x1E29680 VA: 0x181E2AC80
	public static void ReversePolygons(List<List<IntPoint>> polys) { }

	// RVA: 0x1E29680 Offset: 0x1E28080 VA: 0x181E29680
	public static void PolyTreeToPolygons(PolyTree polytree, List<List<IntPoint>> polys) { }

	// RVA: 0x1E2B100 Offset: 0x1E29B00 VA: 0x181E2B100
	public static List<List<IntPoint>> SimplifyPolygon(List<IntPoint> poly, PolyFillType fillType = 0) { }

	// RVA: 0x1E2B1F0 Offset: 0x1E29BF0 VA: 0x181E2B1F0
	public static List<List<IntPoint>> SimplifyPolygons(List<List<IntPoint>> polys, PolyFillType fillType = 0) { }

	// RVA: 0x1E22C60 Offset: 0x1E21660 VA: 0x181E22C60
	private static double DistanceSqrd(IntPoint pt1, IntPoint pt2) { }

	// RVA: 0x1E224F0 Offset: 0x1E20EF0 VA: 0x181E224F0
	private static DoublePoint ClosestPointOnLine(IntPoint pt, IntPoint linePt1, IntPoint linePt2) { }

	// RVA: 0x1E2B2E0 Offset: 0x1E29CE0 VA: 0x181E2B2E0
	private static bool SlopesNearCollinear(IntPoint pt1, IntPoint pt2, IntPoint pt3, double distSqrd) { }

	// RVA: 0x1E293D0 Offset: 0x1E27DD0 VA: 0x181E293D0
	private static bool PointsAreClose(IntPoint pt1, IntPoint pt2, double distSqrd) { }

	// RVA: 0x1E21CD0 Offset: 0x1E206D0 VA: 0x181E21CD0
	public static List<IntPoint> CleanPolygon(List<IntPoint> path, double distance = 1.415) { }

	// RVA: 0x1E28380 Offset: 0x1E26D80 VA: 0x181E28380
	internal static List<List<IntPoint>> Minkowki(List<IntPoint> poly, List<IntPoint> path, bool IsSum, bool IsClosed) { }

	// RVA: 0x1E28360 Offset: 0x1E26D60 VA: 0x181E28360
	public static List<List<IntPoint>> MinkowkiSum(List<IntPoint> poly, List<IntPoint> path, bool IsClosed) { }

	// RVA: 0x1E28340 Offset: 0x1E26D40 VA: 0x181E28340
	public static List<List<IntPoint>> MinkowkiDiff(List<IntPoint> poly, List<IntPoint> path, bool IsClosed) { }

	// RVA: 0x1E22270 Offset: 0x1E20C70 VA: 0x181E22270
	public static List<List<IntPoint>> CleanPolygons(List<List<IntPoint>> polys, double distance = 1.415) { }

	// RVA: 0x1E295B0 Offset: 0x1E27FB0 VA: 0x181E295B0
	public static List<List<IntPoint>> PolyTreeToPaths(PolyTree polytree) { }

	// RVA: 0x1E206B0 Offset: 0x1E1F0B0 VA: 0x181E206B0
	internal static void AddPolyNodeToPaths(PolyNode polynode, Clipper.NodeType nt, List<List<IntPoint>> paths) { }

	// RVA: 0x1E29240 Offset: 0x1E27C40 VA: 0x181E29240
	public static List<List<IntPoint>> OpenPathsFromPolyTree(PolyTree polytree) { }

	// RVA: 0x1E22420 Offset: 0x1E20E20 VA: 0x181E22420
	public static List<List<IntPoint>> ClosedPathsFromPolyTree(PolyTree polytree) { }

	[CompilerGenerated]
	// RVA: 0x1E2BF90 Offset: 0x1E2A990 VA: 0x181E2BF90
	private static void <ReversePaths>m__0(List<IntPoint> poly) { }

	[CompilerGenerated]
	// RVA: 0x1E2BFE0 Offset: 0x1E2A9E0 VA: 0x181E2BFE0
	private static void <ReversePolygons>m__1(List<IntPoint> poly) { }
}
