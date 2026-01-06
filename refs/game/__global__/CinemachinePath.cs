public class CinemachinePath : CinemachinePathBase // TypeDefIndex: 16072
{
	// Fields
	[Tooltip("If checked, then the path ends are joined to form a continuous loop.")]
	public bool m_Looped; // 0x50
	[Tooltip("The waypoints that define the path.  They will be interpolated using a bezier curve.")]
	public CinemachinePath.Waypoint[] m_Waypoints; // 0x58

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

	// RVA: 0xBF32A0 Offset: 0xBF1CA0 VA: 0x180BF32A0
	private void Reset() { }

	// RVA: 0xBF3280 Offset: 0xBF1C80 VA: 0x180BF3280
	private void OnValidate() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 16
	public override int get_DistanceCacheSampleStepsPerSegment() { }

	// RVA: 0xBF2F10 Offset: 0xBF1910 VA: 0x180BF2F10
	private float GetBoundingIndices(float pos, out int indexA, out int indexB) { }

	// RVA: 0xBF2A70 Offset: 0xBF1470 VA: 0x180BF2A70 Slot: 11
	public override Vector3 EvaluateLocalPosition(float pos) { }

	// RVA: 0xBF2CC0 Offset: 0xBF16C0 VA: 0x180BF2CC0 Slot: 12
	public override Vector3 EvaluateLocalTangent(float pos) { }

	// RVA: 0xBF2700 Offset: 0xBF1100 VA: 0x180BF2700 Slot: 13
	public override Quaternion EvaluateLocalOrientation(float pos) { }

	// RVA: 0xBF3150 Offset: 0xBF1B50 VA: 0x180BF3150
	internal float GetRoll(int indexA, int indexB, float standardizedPos) { }

	// RVA: 0xBF33B0 Offset: 0xBF1DB0 VA: 0x180BF33B0
	private static Quaternion RollAroundForward(float angle) { }

	// RVA: 0xBF3400 Offset: 0xBF1E00 VA: 0x180BF3400
	public void .ctor() { }
}
