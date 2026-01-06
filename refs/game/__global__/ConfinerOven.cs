internal class ConfinerOven // TypeDefIndex: 16173
{
	// Fields
	private float m_MinFrustumHeightWithBones; // 0x10
	private float m_SkeletonPadding; // 0x14
	private List<List<ClipperLib.IntPoint>> m_OriginalPolygon; // 0x18
	private ClipperLib.IntPoint m_MidPoint; // 0x20
	private List<List<ClipperLib.IntPoint>> m_Skeleton; // 0x30
	private const long k_FloatToIntScaler = 100000;
	private const float k_IntToFloatScaler = 1E-05;
	private const float k_MinStepSize = 0.0005;
	private Rect m_PolygonRect; // 0x38
	private ConfinerOven.AspectStretcher m_AspectStretcher; // 0x48
	private float m_MaxComputationTimeForFullSkeletonBakeInSeconds; // 0x54
	[CompilerGenerated]
	private ConfinerOven.BakingState <State>k__BackingField; // 0x58
	public float bakeProgress; // 0x5C
	private ConfinerOven.BakingStateCache m_Cache; // 0x60

	// Properties
	public ConfinerOven.BakingState State { get; set; }

	// Methods

	// RVA: 0xC23340 Offset: 0xC21D40 VA: 0x180C23340
	public void .ctor(in List<List<Vector2>> inputPath, in float aspectRatio, float maxFrustumHeight, float skeletonPadding) { }

	// RVA: 0xC221F0 Offset: 0xC20BF0 VA: 0x180C221F0
	public ConfinerOven.BakedSolution GetBakedSolution(float frustumHeight) { }

	[CompilerGenerated]
	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	public ConfinerOven.BakingState get_State() { }

	[CompilerGenerated]
	// RVA: 0x4E2910 Offset: 0x4E1310 VA: 0x1804E2910
	private void set_State(ConfinerOven.BakingState value) { }

	// RVA: 0xC22620 Offset: 0xC21020 VA: 0x180C22620
	private void Initialize(in List<List<Vector2>> inputPath, in float aspectRatio, float maxFrustumHeight, float skeletonPadding) { }

	// RVA: 0xC21CE0 Offset: 0xC206E0 VA: 0x180C21CE0
	public void BakeConfiner(float maxComputationTimePerFrameInSeconds) { }

	[CompilerGenerated]
	// RVA: 0xC23120 Offset: 0xC21B20 VA: 0x180C23120
	internal static Rect <Initialize>g__GetPolygonBoundingBox|24_0(in List<List<Vector2>> polygons) { }

	[CompilerGenerated]
	// RVA: 0xC232F0 Offset: 0xC21CF0 VA: 0x180C232F0
	internal static ClipperLib.IntPoint <Initialize>g__MidPointOfIntRect|24_1(ClipperLib.IntRect bounds) { }

	[CompilerGenerated]
	// RVA: 0xC22D10 Offset: 0xC21710 VA: 0x180C22D10
	private void <BakeConfiner>g__ComputeSkeleton|25_0(in List<ConfinerOven.PolygonSolution> solutions) { }
}
