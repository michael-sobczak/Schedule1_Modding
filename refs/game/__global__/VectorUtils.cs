public static class VectorUtils // TypeDefIndex: 10334
{
	// Fields
	private static Material s_ExpandEdgesMat; // 0x0
	public static readonly float Epsilon; // 0x8

	// Methods

	// RVA: 0x4783E0 Offset: 0x476DE0 VA: 0x1804783E0
	internal static BezierPathSegment[] BuildEllipsePath(Vector2 p0, Vector2 p1, float rotation, float rx, float ry, bool largeArc, bool sweep) { }

	// RVA: 0x479AC0 Offset: 0x4784C0 VA: 0x180479AC0
	private static void ComputeEllipseParameters(Vector2 p0, Vector2 p1, float phi, float rx, float ry, bool fa, bool fs, out Vector2 c, out float theta1, out float sweepTheta, out float adjustedRx, out float adjustedRy) { }

	// RVA: 0x47A810 Offset: 0x479210 VA: 0x18047A810
	private static void EnsureRadiiAreLargeEnough(Vector2 p, ref float rx, ref float ry) { }

	// RVA: 0x478810 Offset: 0x477210 VA: 0x180478810
	public static BezierContour BuildRectangleContour(Rect rect, Vector2 radiusTL, Vector2 radiusTR, Vector2 radiusBR, Vector2 radiusBL) { }

	// RVA: 0x47BEC0 Offset: 0x47A8C0 VA: 0x18047BEC0
	private static void FlipYAxis(IList<Vector2> vertices) { }

	// RVA: 0x476790 Offset: 0x475190 VA: 0x180476790
	internal static void AdjustWinding(Vector2[] vertices, ushort[] indices, VectorUtils.WindingDir dir) { }

	// RVA: 0x47B720 Offset: 0x47A120 VA: 0x18047B720
	private static void FlipRangeIfNecessary(List<Vector2> vertices, List<ushort> indices, int indexStart, int indexEnd, bool flipYAxis) { }

	// RVA: 0x480F60 Offset: 0x47F960 VA: 0x180480F60
	internal static void RenderFromArrays(Vector2[] vertices, ushort[] indices, Vector2[] uvs, Color[] colors, Vector2[] settings, Texture2D texture, Material mat, bool clear = True) { }

	// RVA: 0x481640 Offset: 0x480040 VA: 0x180481640
	public static void RenderSprite(Sprite sprite, Material mat, bool clear = True) { }

	// RVA: 0x4811A0 Offset: 0x47FBA0 VA: 0x1804811A0
	public static Texture2D RenderSpriteToTexture2D(Sprite sprite, int width, int height, Material mat, int antiAliasing = 1, bool expandEdges = False) { }

	// RVA: 0x47E100 Offset: 0x47CB00 VA: 0x18047E100
	internal static Vector2 GetPivot(VectorUtils.Alignment alignment, Vector2 customPivot, Rect bbox, bool flipYAxis) { }

	// RVA: 0x4835A0 Offset: 0x481FA0 VA: 0x1804835A0
	public static void TessellatePath(BezierContour contour, PathProperties pathProps, VectorUtils.TessellationOptions tessellateOptions, out Vector2[] vertices, out ushort[] indices) { }

	// RVA: 0x485150 Offset: 0x483B50 VA: 0x180485150
	private static Vector2[] TraceShape(BezierContour contour, Stroke stroke, VectorUtils.TessellationOptions tessellateOptions) { }

	// RVA: 0x4860E0 Offset: 0x484AE0 VA: 0x1804860E0
	private static bool TryGetMoreRemainingUnits(ref float unitsRemaining, PathDistanceForwardIterator pathIt, float startingLength, float distance, float stepDistance) { }

	// RVA: 0x47E2C0 Offset: 0x47CCC0 VA: 0x18047E2C0
	private static void HandleNewSegmentJoining(PathDistanceForwardIterator pathIt, PathPatternIterator patternIt, VectorUtils.JoiningInfo[] joiningInfo, float halfThickness, float[] segmentLengths) { }

	// RVA: 0x483090 Offset: 0x481A90 VA: 0x180483090
	private static void SkipRange(float distance, PathDistanceForwardIterator pathIt, PathPatternIterator patternIt, PathProperties pathProps, VectorUtils.JoiningInfo[] joiningInfo, float[] segmentLengths) { }

	// RVA: 0x483BB0 Offset: 0x4825B0 VA: 0x180483BB0
	private static void TessellateRange(float distance, PathDistanceForwardIterator pathIt, PathPatternIterator patternIt, PathProperties pathProps, VectorUtils.TessellationOptions tessellateOptions, VectorUtils.JoiningInfo[] joiningInfo, float[] segmentLengths, float totalLength, int rangeIndex, List<Vector2> verts, List<ushort> inds) { }

	// RVA: 0x4762F0 Offset: 0x474CF0 VA: 0x1804762F0
	private static void AddSegment(BezierSegment segment, float toT, float halfThickness, VectorUtils.JoiningInfo[] joinInfo, float segmentLengthSoFar, List<Vector2> verts, List<ushort> inds) { }

	// RVA: 0x47C140 Offset: 0x47AB40 VA: 0x18047C140
	private static VectorUtils.JoiningInfo ForeseeJoining(BezierSegment end, BezierSegment start, float halfThickness, float endSegmentLength) { }

	// RVA: 0x47EC60 Offset: 0x47D660 VA: 0x18047EC60
	private static Vector2[] LineBezierThicknessIntersect(BezierSegment seg, float thickness, Vector2 lineFrom, Vector2 lineTo, out float distanceToIntersection, out Vector2 intersection) { }

	// RVA: 0x480AB0 Offset: 0x47F4B0 VA: 0x180480AB0
	private static bool PointOnLineIsWithinSegment(Vector2 lineFrom, Vector2 lineTo, Vector2 point) { }

	// RVA: 0x47CC30 Offset: 0x47B630 VA: 0x18047CC30
	private static void GenerateJoining(VectorUtils.JoiningInfo joinInfo, PathCorner corner, float halfThickness, float tippedCornerLimit, VectorUtils.TessellationOptions tessellateOptions, List<Vector2> verts, List<ushort> inds) { }

	// RVA: 0x47D6A0 Offset: 0x47C0A0 VA: 0x18047D6A0
	private static void GenerateTip(BezierSegment segment, bool atStart, float t, PathEnding ending, float halfThickness, VectorUtils.TessellationOptions tessellateOptions, List<Vector2> verts, List<ushort> inds) { }

	// RVA: 0x4796C0 Offset: 0x4780C0 VA: 0x1804796C0
	private static int CalculateArcSteps(float radius, float fromAngle, float toAngle, VectorUtils.TessellationOptions tessellateOptions) { }

	// RVA: 0x485010 Offset: 0x483A10 VA: 0x180485010
	public static void TessellateRect(Rect rect, out Vector2[] vertices, out ushort[] indices) { }

	// RVA: 0x4843A0 Offset: 0x482DA0 VA: 0x1804843A0
	public static void TessellateRectBorder(Rect rect, float halfThickness, out Vector2[] vertices, out ushort[] indices) { }

	// RVA: 0x477420 Offset: 0x475E20 VA: 0x180477420
	public static BezierPathSegment[] BezierSegmentToPath(BezierSegment segment) { }

	// RVA: 0x477510 Offset: 0x475F10 VA: 0x180477510
	public static BezierPathSegment[] BezierSegmentsToPath(BezierSegment[] segments) { }

	// RVA: 0x480900 Offset: 0x47F300 VA: 0x180480900
	public static BezierSegment PathSegmentAtIndex(IList<BezierPathSegment> path, int index) { }

	// RVA: 0x4807D0 Offset: 0x47F1D0 VA: 0x1804807D0
	public static bool PathEndsPerfectlyMatch(IList<BezierPathSegment> path) { }

	// RVA: 0x4800E0 Offset: 0x47EAE0 VA: 0x1804800E0
	public static void MakeRectangleShape(Shape rectShape, Rect rect) { }

	// RVA: 0x47FFB0 Offset: 0x47E9B0 VA: 0x18047FFB0
	public static void MakeRectangleShape(Shape rectShape, Rect rect, Vector2 radiusTL, Vector2 radiusTR, Vector2 radiusBR, Vector2 radiusBL) { }

	// RVA: 0x47FCF0 Offset: 0x47E6F0 VA: 0x18047FCF0
	public static void MakeEllipseShape(Shape ellipseShape, Vector2 pos, float radiusX, float radiusY) { }

	// RVA: 0x47FBF0 Offset: 0x47E5F0 VA: 0x18047FBF0
	public static void MakeCircleShape(Shape circleShape, Vector2 pos, float radius) { }

	// RVA: 0x477920 Offset: 0x476320 VA: 0x180477920
	public static Rect Bounds(BezierPathSegment[] path) { }

	// RVA: 0x4780F0 Offset: 0x476AF0 VA: 0x1804780F0
	public static Rect Bounds(IEnumerable<Vector2> vertices) { }

	// RVA: 0x47FDD0 Offset: 0x47E7D0 VA: 0x18047FDD0
	public static BezierSegment MakeLine(Vector2 from, Vector2 to) { }

	// RVA: 0x480CC0 Offset: 0x47F6C0 VA: 0x180480CC0
	public static BezierSegment QuadraticToCubic(Vector2 p0, Vector2 p1, Vector2 p2) { }

	// RVA: 0x47FE70 Offset: 0x47E870 VA: 0x18047FE70
	public static BezierPathSegment[] MakePathLine(Vector2 from, Vector2 to) { }

	// RVA: 0x47EFD0 Offset: 0x47D9D0 VA: 0x18047EFD0
	internal static BezierSegment MakeArcQuarter(Vector2 center, float startAngleRads, float sweepAngleRads) { }

	// RVA: 0x47F210 Offset: 0x47DC10 VA: 0x18047F210
	public static BezierPathSegment[] MakeArc(Vector2 center, float startAngleRads, float sweepAngleRads, float radius) { }

	// RVA: 0x480C50 Offset: 0x47F650 VA: 0x180480C50
	internal static int QuadrantAtAngle(float angle) { }

	// RVA: 0x477060 Offset: 0x475A60 VA: 0x180477060
	internal static BezierSegment ArcSegmentForQuadrant(int quadrant) { }

	// RVA: 0x47BC10 Offset: 0x47A610 VA: 0x18047BC10
	public static BezierSegment FlipSegment(BezierSegment segment) { }

	// RVA: 0x477CC0 Offset: 0x4766C0 VA: 0x180477CC0
	public static void Bounds(BezierSegment segment, out Vector2 min, out Vector2 max) { }

	// RVA: 0x47B0A0 Offset: 0x479AA0 VA: 0x18047B0A0
	public static Vector2 Eval(BezierSegment segment, float t) { }

	// RVA: 0x47AD90 Offset: 0x479790 VA: 0x18047AD90
	public static Vector2 EvalTangent(BezierSegment segment, float t) { }

	// RVA: 0x47AD00 Offset: 0x479700 VA: 0x18047AD00
	public static Vector2 EvalNormal(BezierSegment segment, float t) { }

	// RVA: 0x47A950 Offset: 0x479350 VA: 0x18047A950
	public static Vector2 EvalFull(BezierSegment segment, float t, out Vector2 tangent) { }

	// RVA: 0x47A8A0 Offset: 0x4792A0 VA: 0x18047A8A0
	public static Vector2 EvalFull(BezierSegment segment, float t, out Vector2 tangent, out Vector2 normal) { }

	// RVA: 0x482DB0 Offset: 0x4817B0 VA: 0x180482DB0
	public static float[] SegmentsLengths(IList<BezierPathSegment> segments, bool closed, float precision = 0.001) { }

	// RVA: 0x482A10 Offset: 0x481410 VA: 0x180482A10
	public static float SegmentsLength(IList<BezierPathSegment> segments, bool closed, float precision = 0.001) { }

	// RVA: 0x482510 Offset: 0x480F10 VA: 0x180482510
	public static float SegmentLength(BezierSegment segment, float precision = 0.001) { }

	// RVA: 0x4822E0 Offset: 0x480CE0 VA: 0x1804822E0
	internal static float SegmentLengthIterative(BezierSegment segment, int steps = 10) { }

	// RVA: 0x47E760 Offset: 0x47D160 VA: 0x18047E760
	internal static bool HasLargeCoordinates(BezierSegment segment) { }

	// RVA: 0x4761A0 Offset: 0x474BA0 VA: 0x1804761A0
	private static float AdaptiveQuadraticApproxSplitPoint(BezierSegment segment, float precision) { }

	// RVA: 0x4802A0 Offset: 0x47ECA0 VA: 0x1804802A0
	private static float MidPointQuadraticApproxLength(BezierSegment segment) { }

	// RVA: 0x4832F0 Offset: 0x481CF0 VA: 0x1804832F0
	public static void SplitSegment(BezierSegment segment, float t, out BezierSegment b1, out BezierSegment b2) { }

	// RVA: 0x485E50 Offset: 0x484850 VA: 0x180485E50
	public static BezierSegment TransformSegment(BezierSegment segment, Vector2 translation, float rotation, Vector2 scaling) { }

	// RVA: 0x485C70 Offset: 0x484670 VA: 0x180485C70
	public static BezierSegment TransformSegment(BezierSegment segment, Matrix2D matrix) { }

	// RVA: 0x485910 Offset: 0x484310 VA: 0x180485910
	public static BezierPathSegment[] TransformBezierPath(BezierPathSegment[] path, Vector2 translation, float rotation, Vector2 scaling) { }

	// RVA: 0x4856A0 Offset: 0x4840A0 VA: 0x1804856A0
	public static BezierPathSegment[] TransformBezierPath(BezierPathSegment[] path, Matrix2D matrix) { }

	[IteratorStateMachine(typeof(VectorUtils.<SceneNodes>d__68))]
	// RVA: 0x482260 Offset: 0x480C60 VA: 0x180482260
	public static IEnumerable<SceneNode> SceneNodes(SceneNode root) { }

	[IteratorStateMachine(typeof(VectorUtils.<WorldTransformedSceneNodes>d__70))]
	// RVA: 0x486220 Offset: 0x484C20 VA: 0x180486220
	private static IEnumerable<VectorUtils.SceneNodeWorldTransform> WorldTransformedSceneNodes(SceneNode child, Dictionary<SceneNode, float> nodeOpacities, VectorUtils.SceneNodeWorldTransform parent) { }

	// RVA: 0x4862F0 Offset: 0x484CF0 VA: 0x1804862F0
	public static IEnumerable<VectorUtils.SceneNodeWorldTransform> WorldTransformedSceneNodes(SceneNode root, Dictionary<SceneNode, float> nodeOpacities) { }

	// RVA: 0x480D50 Offset: 0x47F750 VA: 0x180480D50
	public static void RealignVerticesInBounds(IList<Vector2> vertices, Rect bounds, bool flip) { }

	// RVA: 0x47BC90 Offset: 0x47A690 VA: 0x18047BC90
	public static void FlipVerticesInBounds(IList<Vector2> vertices, Rect bounds) { }

	// RVA: 0x479820 Offset: 0x478220 VA: 0x180479820
	internal static void ClampVerticesInBounds(IList<Vector2> vertices, Rect bounds) { }

	[IteratorStateMachine(typeof(VectorUtils.<SegmentsInPath>d__75))]
	// RVA: 0x482980 Offset: 0x481380 VA: 0x180482980
	public static IEnumerable<BezierSegment> SegmentsInPath(IEnumerable<BezierPathSegment> segments, bool closed = False) { }

	// RVA: 0x4831F0 Offset: 0x481BF0 VA: 0x1804831F0
	private static void SolveQuadratic(float a, float b, float c, out float s1, out float s2) { }

	// RVA: 0x47E960 Offset: 0x47D360 VA: 0x18047E960
	public static Vector2 IntersectLines(Vector2 line1Pt1, Vector2 line1Pt2, Vector2 line2Pt1, Vector2 line2Pt2) { }

	// RVA: 0x47E7D0 Offset: 0x47D1D0 VA: 0x18047E7D0
	public static Vector2 IntersectLineSegments(Vector2 line1Pt1, Vector2 line1Pt2, Vector2 line2Pt1, Vector2 line2Pt2) { }

	// RVA: 0x480BF0 Offset: 0x47F5F0 VA: 0x180480BF0
	private static bool PointOnTheLeftOfLine(Vector2 lineFrom, Vector2 lineTo, Vector2 point) { }

	// RVA: 0x47B280 Offset: 0x479C80 VA: 0x18047B280
	public static float[] FindBezierLineIntersections(BezierSegment segment, Vector2 p0, Vector2 p1) { }

	// RVA: 0x47A070 Offset: 0x478A70 VA: 0x18047A070
	private static float[] CubicRoots(double a, double b, double c, double d) { }

	// RVA: 0x477260 Offset: 0x475C60 VA: 0x180477260
	private static Vector2[] BezierCoefficients(BezierSegment segment) { }

	// RVA: 0x481C50 Offset: 0x480650 VA: 0x180481C50
	public static Rect SceneNodeBounds(SceneNode root) { }

	// RVA: 0x476B90 Offset: 0x475590 VA: 0x180476B90
	public static Rect ApproximateSceneNodeBounds(SceneNode root) { }

	// RVA: 0x47EB20 Offset: 0x47D520 VA: 0x18047EB20
	internal static bool IsEmptySegment(BezierSegment bs) { }

	// RVA: 0x486460 Offset: 0x484E60 VA: 0x180486460
	private static void .cctor() { }
}
