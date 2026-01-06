internal class PathDistanceForwardIterator // TypeDefIndex: 10356
{
	// Fields
	[CompilerGenerated]
	private readonly IList<BezierPathSegment> <Segments>k__BackingField; // 0x10
	private readonly bool closed; // 0x18
	private readonly bool needTangentsDuringEval; // 0x19
	private readonly float maxCordDeviationSq; // 0x1C
	private readonly float maxTanAngleDevCosine; // 0x20
	private readonly float stepSizeT; // 0x24
	private int currentSegment; // 0x28
	private float currentT; // 0x2C
	private float segmentLengthSoFar; // 0x30
	private float lengthSoFar; // 0x34
	private Vector2 lastPointEval; // 0x38
	private Vector2 currentTTangent; // 0x40
	private BezierSegment currentBezSeg; // 0x48

	// Properties
	public IList<BezierPathSegment> Segments { get; }
	public bool Closed { get; }
	public int CurrentSegment { get; }
	public float CurrentT { get; }
	public float LengthSoFar { get; }
	public float SegmentLengthSoFar { get; }
	public bool Ended { get; }

	// Methods

	// RVA: 0x496DB0 Offset: 0x4957B0 VA: 0x180496DB0
	public void .ctor(IList<BezierPathSegment> pathSegments, bool closed, float maxCordDeviationSq, float maxTanAngleDevCosine, float stepSizeT) { }

	// RVA: 0x496C80 Offset: 0x495680 VA: 0x180496C80
	private float PointToLineDistanceSq(Vector2 point, Vector2 lineStart, Vector2 lineEnd) { }

	// RVA: 0x4964D0 Offset: 0x494ED0 VA: 0x1804964D0
	public PathDistanceForwardIterator.Result AdvanceBy(float units, out float unitsRemaining) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public IList<BezierPathSegment> get_Segments() { }

	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	public bool get_Closed() { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_CurrentSegment() { }

	// RVA: 0x4971C0 Offset: 0x495BC0 VA: 0x1804971C0
	public float get_CurrentT() { }

	// RVA: 0x497250 Offset: 0x495C50 VA: 0x180497250
	public float get_LengthSoFar() { }

	// RVA: 0x497260 Offset: 0x495C60 VA: 0x180497260
	public float get_SegmentLengthSoFar() { }

	// RVA: 0x4971D0 Offset: 0x495BD0 VA: 0x1804971D0
	public bool get_Ended() { }

	// RVA: 0x496BF0 Offset: 0x4955F0 VA: 0x180496BF0
	public Vector2 EvalCurrent() { }
}
