public class CinemachineSmoothPath : CinemachinePathBase // TypeDefIndex: 16076
{
	// Fields
	[Tooltip("If checked, then the path ends are joined to form a continuous loop.")]
	public bool m_Looped; // 0x50
	[Tooltip("The waypoints that define the path.  They will be interpolated using a bezier curve.")]
	public CinemachineSmoothPath.Waypoint[] m_Waypoints; // 0x58
	internal CinemachineSmoothPath.Waypoint[] m_ControlPoints1; // 0x60
	internal CinemachineSmoothPath.Waypoint[] m_ControlPoints2; // 0x68
	private bool m_IsLoopedCache; // 0x70

	// Properties
	public override float MinPos { get; }
	public override float MaxPos { get; }
	public override bool Looped { get; }
	public override int DistanceCacheSampleStepsPerSegment { get; }

	// Methods

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590 Slot: 4
	public override float get_MinPos() { }

	// RVA: 0xBF34B0 Offset: 0xBF1EB0 VA: 0x180BF34B0 Slot: 5
	public override float get_MaxPos() { }

	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0 Slot: 6
	public override bool get_Looped() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 16
	public override int get_DistanceCacheSampleStepsPerSegment() { }

	// RVA: 0xBF3280 Offset: 0xBF1C80 VA: 0x180BF3280
	private void OnValidate() { }

	// RVA: 0xC01DB0 Offset: 0xC007B0 VA: 0x180C01DB0
	private void Reset() { }

	// RVA: 0xC01D70 Offset: 0xC00770 VA: 0x180C01D70 Slot: 17
	public override void InvalidateDistanceCache() { }

	// RVA: 0xC01EB0 Offset: 0xC008B0 VA: 0x180C01EB0
	internal void UpdateControlPoints() { }

	// RVA: 0xC01C50 Offset: 0xC00650 VA: 0x180C01C50
	private float GetBoundingIndices(float pos, out int indexA, out int indexB) { }

	// RVA: 0xC017F0 Offset: 0xC001F0 VA: 0x180C017F0 Slot: 11
	public override Vector3 EvaluateLocalPosition(float pos) { }

	// RVA: 0xC01A10 Offset: 0xC00410 VA: 0x180C01A10 Slot: 12
	public override Vector3 EvaluateLocalTangent(float pos) { }

	// RVA: 0xC01470 Offset: 0xBFFE70 VA: 0x180C01470 Slot: 13
	public override Quaternion EvaluateLocalOrientation(float pos) { }

	// RVA: 0xBF33B0 Offset: 0xBF1DB0 VA: 0x180BF33B0
	private static Quaternion RollAroundForward(float angle) { }

	// RVA: 0xC02180 Offset: 0xC00B80 VA: 0x180C02180
	public void .ctor() { }
}
