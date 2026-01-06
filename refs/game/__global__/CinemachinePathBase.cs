public abstract class CinemachinePathBase : MonoBehaviour // TypeDefIndex: 16149
{
	// Fields
	[Range(1, 100)]
	[Tooltip("Path samples per waypoint.  This is used for calculating path distances.")]
	public int m_Resolution; // 0x20
	[Tooltip("The settings that control how the path will appear in the editor scene view.")]
	public CinemachinePathBase.Appearance m_Appearance; // 0x28
	private float[] m_DistanceToPos; // 0x30
	private float[] m_PosToDistance; // 0x38
	private int m_CachedSampleSteps; // 0x40
	private float m_PathLength; // 0x44
	private float m_cachedPosStepSize; // 0x48
	private float m_cachedDistanceStepSize; // 0x4C

	// Properties
	public abstract float MinPos { get; }
	public abstract float MaxPos { get; }
	public abstract bool Looped { get; }
	public abstract int DistanceCacheSampleStepsPerSegment { get; }
	public float PathLength { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_MinPos();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_MaxPos();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_Looped();

	// RVA: 0xC1B420 Offset: 0xC19E20 VA: 0x180C1B420 Slot: 7
	public virtual float StandardizePos(float pos) { }

	// RVA: 0xC1A730 Offset: 0xC19130 VA: 0x180C1A730 Slot: 8
	public virtual Vector3 EvaluatePosition(float pos) { }

	// RVA: 0xC1A830 Offset: 0xC19230 VA: 0x180C1A830 Slot: 9
	public virtual Vector3 EvaluateTangent(float pos) { }

	// RVA: 0xC1A4F0 Offset: 0xC18EF0 VA: 0x180C1A4F0 Slot: 10
	public virtual Quaternion EvaluateOrientation(float pos) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Vector3 EvaluateLocalPosition(float pos);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Vector3 EvaluateLocalTangent(float pos);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Quaternion EvaluateLocalOrientation(float pos);

	// RVA: 0xC1A8D0 Offset: 0xC192D0 VA: 0x180C1A8D0 Slot: 14
	public virtual float FindClosestPoint(Vector3 p, int startSegment, int searchRadius, int stepsPerSegment) { }

	// RVA: 0xC1AEC0 Offset: 0xC198C0 VA: 0x180C1AEC0
	public float MinUnit(CinemachinePathBase.PositionUnits units) { }

	// RVA: 0xC1AE90 Offset: 0xC19890 VA: 0x180C1AE90
	public float MaxUnit(CinemachinePathBase.PositionUnits units) { }

	// RVA: 0xC1B510 Offset: 0xC19F10 VA: 0x180C1B510 Slot: 15
	public virtual float StandardizeUnit(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: 0xC1A6D0 Offset: 0xC190D0 VA: 0x180C1A6D0
	public Vector3 EvaluatePositionAtUnit(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: 0xC1A7D0 Offset: 0xC191D0 VA: 0x180C1A7D0
	public Vector3 EvaluateTangentAtUnit(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: 0xC1A490 Offset: 0xC18E90 VA: 0x180C1A490
	public Quaternion EvaluateOrientationAtUnit(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int get_DistanceCacheSampleStepsPerSegment();

	// RVA: 0xC1AE50 Offset: 0xC19850 VA: 0x180C1AE50 Slot: 17
	public virtual void InvalidateDistanceCache() { }

	// RVA: 0xC1A3F0 Offset: 0xC18DF0 VA: 0x180C1A3F0
	public bool DistanceCacheIsValid() { }

	// RVA: 0xC1B800 Offset: 0xC1A200 VA: 0x180C1B800
	public float get_PathLength() { }

	// RVA: 0xC1B360 Offset: 0xC19D60 VA: 0x180C1B360
	public float StandardizePathDistance(float distance) { }

	// RVA: 0xC1B5C0 Offset: 0xC19FC0 VA: 0x180C1B5C0
	public float ToNativePathUnits(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: 0xC1ACF0 Offset: 0xC196F0 VA: 0x180C1ACF0
	public float FromPathNativeUnits(float pos, CinemachinePathBase.PositionUnits units) { }

	// RVA: 0xC1AEF0 Offset: 0xC198F0 VA: 0x180C1AEF0
	private void ResamplePath(int stepsPerSegment) { }

	// RVA: 0xC1B770 Offset: 0xC1A170 VA: 0x180C1B770
	protected void .ctor() { }
}
