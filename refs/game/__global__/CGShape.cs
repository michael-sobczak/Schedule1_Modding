public class CGShape : CGData // TypeDefIndex: 10653
{
	// Fields
	[CompilerGenerated]
	private List<DuplicateSamplePoint> <DuplicatePoints>k__BackingField; // 0x20
	public List<SamplePointsMaterialGroup> MaterialGroups; // 0x28
	public bool SourceIsManaged; // 0x30
	public bool Closed; // 0x31
	public bool Seamless; // 0x32
	public float Length; // 0x34
	private SubArray<float> relativeDistances; // 0x38
	private SubArray<float> sourceRelativeDistances; // 0x48
	private SubArray<Vector3> positions; // 0x58
	private SubArray<Vector3> normals; // 0x68
	private SubArray<float> customValues; // 0x78
	private float mCacheLastF; // 0x88
	private int mCacheLastIndex; // 0x8C
	private float mCacheLastFrag; // 0x90

	// Properties
	public SubArray<float> RelativeDistances { get; set; }
	public SubArray<float> SourceRelativeDistances { get; set; }
	public SubArray<Vector3> Positions { get; set; }
	public SubArray<Vector3> Normals { get; set; }
	public SubArray<float> CustomValues { get; set; }
	public List<DuplicateSamplePoint> DuplicatePoints { get; set; }
	[Obsolete("Use RelativeDistances instead")]
	[UsedImplicitly]
	public float[] F { get; set; }
	[Obsolete("Use SourceRelativeDistances instead")]
	[UsedImplicitly]
	public float[] SourceF { get; set; }
	[Obsolete("Use Positions instead")]
	[UsedImplicitly]
	public Vector3[] Position { get; set; }
	[UsedImplicitly]
	[Obsolete("Use Normals instead")]
	public Vector3[] Normal { get; set; }
	[Obsolete("Use CustomValues instead")]
	[UsedImplicitly]
	public float[] Map { get; set; }
	public override int Count { get; }

	// Methods

	// RVA: 0x4F9F20 Offset: 0x4F8920 VA: 0x1804F9F20
	public SubArray<float> get_RelativeDistances() { }

	// RVA: 0x4FA750 Offset: 0x4F9150 VA: 0x1804FA750
	public void set_RelativeDistances(SubArray<float> value) { }

	// RVA: 0x4F9FE0 Offset: 0x4F89E0 VA: 0x1804F9FE0
	public SubArray<float> get_SourceRelativeDistances() { }

	// RVA: 0x4FA960 Offset: 0x4F9360 VA: 0x1804FA960
	public void set_SourceRelativeDistances(SubArray<float> value) { }

	// RVA: 0x4F9F10 Offset: 0x4F8910 VA: 0x1804F9F10
	public SubArray<Vector3> get_Positions() { }

	// RVA: 0x4FA670 Offset: 0x4F9070 VA: 0x1804FA670
	public void set_Positions(SubArray<Vector3> value) { }

	// RVA: 0x4F9E50 Offset: 0x4F8850 VA: 0x1804F9E50
	public SubArray<Vector3> get_Normals() { }

	// RVA: 0x4FA460 Offset: 0x4F8E60 VA: 0x1804FA460
	public void set_Normals(SubArray<Vector3> value) { }

	// RVA: 0x4F9C30 Offset: 0x4F8630 VA: 0x1804F9C30
	public SubArray<float> get_CustomValues() { }

	// RVA: 0x4F9FF0 Offset: 0x4F89F0 VA: 0x1804F9FF0
	public void set_CustomValues(SubArray<float> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public List<DuplicateSamplePoint> get_DuplicatePoints() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_DuplicatePoints(List<DuplicateSamplePoint> value) { }

	// RVA: 0x4F9C40 Offset: 0x4F8640 VA: 0x1804F9C40
	public float[] get_F() { }

	// RVA: 0x4FA0D0 Offset: 0x4F8AD0 VA: 0x1804FA0D0
	public void set_F(float[] value) { }

	// RVA: 0x4F9F30 Offset: 0x4F8930 VA: 0x1804F9F30
	public float[] get_SourceF() { }

	// RVA: 0x4FA830 Offset: 0x4F9230 VA: 0x1804FA830
	public void set_SourceF(float[] value) { }

	// RVA: 0x4F9E60 Offset: 0x4F8860 VA: 0x1804F9E60
	public Vector3[] get_Position() { }

	// RVA: 0x4FA540 Offset: 0x4F8F40 VA: 0x1804FA540
	public void set_Position(Vector3[] value) { }

	// RVA: 0x4F9DA0 Offset: 0x4F87A0 VA: 0x1804F9DA0
	public Vector3[] get_Normal() { }

	// RVA: 0x4FA330 Offset: 0x4F8D30 VA: 0x1804FA330
	public void set_Normal(Vector3[] value) { }

	// RVA: 0x4F9CF0 Offset: 0x4F86F0 VA: 0x1804F9CF0
	public float[] get_Map() { }

	// RVA: 0x4FA200 Offset: 0x4F8C00 VA: 0x1804FA200
	public void set_Map(float[] value) { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40 Slot: 6
	public override int get_Count() { }

	// RVA: 0x4F9800 Offset: 0x4F8200 VA: 0x1804F9800
	public void .ctor() { }

	// RVA: 0x4F9040 Offset: 0x4F7A40 VA: 0x1804F9040
	public void .ctor(CGShape source) { }

	// RVA: 0x4F70F0 Offset: 0x4F5AF0 VA: 0x1804F70F0 Slot: 5
	protected override bool Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 7
	public override T Clone<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5CA10 Offset: 0xE5B410 VA: 0x180E5CA10
	|-CGShape.Clone<object>
	*/

	// RVA: 0x4F6C40 Offset: 0x4F5640 VA: 0x1804F6C40
	public static void Copy(CGShape dest, CGShape source) { }

	// RVA: 0x4F6C30 Offset: 0x4F5630 VA: 0x1804F6C30
	public void Copy(CGShape source) { }

	// RVA: 0x4F73C0 Offset: 0x4F5DC0 VA: 0x1804F73C0
	public float DistanceToF(float distance) { }

	// RVA: 0x4F73F0 Offset: 0x4F5DF0 VA: 0x1804F73F0
	public float FToDistance(float f) { }

	// RVA: 0x4F7420 Offset: 0x4F5E20 VA: 0x1804F7420
	public int GetFIndex(float f, out float frag) { }

	// RVA: 0x4F74B0 Offset: 0x4F5EB0 VA: 0x1804F74B0
	public Vector3 InterpolatePosition(float f) { }

	// RVA: 0x4F75D0 Offset: 0x4F5FD0 VA: 0x1804F75D0
	public Vector3 InterpolateUp(float f) { }

	// RVA: 0x4F76F0 Offset: 0x4F60F0 VA: 0x1804F76F0
	public void Interpolate(float f, out Vector3 position, out Vector3 up) { }

	// RVA: 0x4F7960 Offset: 0x4F6360 VA: 0x1804F7960
	public void Move(ref float f, ref int direction, float speed, CurvyClamping clamping) { }

	// RVA: 0x4F78C0 Offset: 0x4F62C0 VA: 0x1804F78C0
	public void MoveBy(ref float f, ref int direction, float speedDist, CurvyClamping clamping) { }

	// RVA: 0x4F8B00 Offset: 0x4F7500 VA: 0x1804F8B00 Slot: 8
	public virtual void Recalculate() { }

	[UsedImplicitly]
	[Obsolete("Use another overload of RecalculateNormals instead")]
	// RVA: 0x4F7E70 Offset: 0x4F6870 VA: 0x1804F7E70
	public void RecalculateNormals(List<int> softEdges) { }

	// RVA: 0x4F79A0 Offset: 0x4F63A0 VA: 0x1804F79A0
	public void RecalculateNormals(CurvySpline spline) { }

	// RVA: 0x4F84B0 Offset: 0x4F6EB0 VA: 0x1804F84B0
	public void RecalculateNormals() { }
}
