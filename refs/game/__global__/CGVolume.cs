public class CGVolume : CGPath // TypeDefIndex: 10661
{
	// Fields
	public bool CrossClosed; // 0xA8
	public bool CrossSeamless; // 0xA9
	public float CrossFShift; // 0xAC
	public SamplePointsMaterialGroupCollection CrossMaterialGroups; // 0xB0
	private SubArray<Vector3> vertices; // 0xB8
	private SubArray<Vector3> vertexNormals; // 0xC8
	private SubArray<float> crossRelativeDistances; // 0xD8
	private SubArray<float> crossCustomValues; // 0xE8
	private SubArray<Vector2> scales; // 0xF8
	[Obsolete("Do not use this. Use the GetCrossLength method instead")]
	[UsedImplicitly]
	private float[] _segmentLength; // 0x108

	// Properties
	public SubArray<Vector3> Vertices { get; set; }
	public SubArray<Vector3> VertexNormals { get; set; }
	public SubArray<float> CrossRelativeDistances { get; set; }
	public SubArray<float> CrossCustomValues { get; set; }
	public SubArray<Vector2> Scales { get; set; }
	[UsedImplicitly]
	[Obsolete("Use Vertices instead")]
	public Vector3[] Vertex { get; set; }
	[UsedImplicitly]
	[Obsolete("Use VertexNormals instead")]
	public Vector3[] VertexNormal { get; set; }
	[UsedImplicitly]
	[Obsolete("Use CrossRelativeDistances instead")]
	public float[] CrossF { get; set; }
	[UsedImplicitly]
	[Obsolete("Use CrossCustomValues instead")]
	public float[] CrossMap { get; set; }
	[UsedImplicitly]
	[Obsolete("Do not use this. Use the GetCrossLength method instead")]
	public float[] SegmentLength { get; set; }
	public int CrossSize { get; }
	public int VertexCount { get; }

	// Methods

	// RVA: 0x505A80 Offset: 0x504480 VA: 0x180505A80
	public SubArray<Vector3> get_Vertices() { }

	// RVA: 0x506330 Offset: 0x504D30 VA: 0x180506330
	public void set_Vertices(SubArray<Vector3> value) { }

	// RVA: 0x5059C0 Offset: 0x5043C0 VA: 0x1805059C0
	public SubArray<Vector3> get_VertexNormals() { }

	// RVA: 0x506110 Offset: 0x504B10 VA: 0x180506110
	public void set_VertexNormals(SubArray<Vector3> value) { }

	// RVA: 0x505850 Offset: 0x504250 VA: 0x180505850
	public SubArray<float> get_CrossRelativeDistances() { }

	// RVA: 0x505DE0 Offset: 0x5047E0 VA: 0x180505DE0
	public void set_CrossRelativeDistances(SubArray<float> value) { }

	// RVA: 0x5056E0 Offset: 0x5040E0 VA: 0x1805056E0
	public SubArray<float> get_CrossCustomValues() { }

	// RVA: 0x505A90 Offset: 0x504490 VA: 0x180505A90
	public void set_CrossCustomValues(SubArray<float> value) { }

	// RVA: 0x505870 Offset: 0x504270 VA: 0x180505870
	public SubArray<Vector2> get_Scales() { }

	// RVA: 0x505ED0 Offset: 0x5048D0 VA: 0x180505ED0
	public void set_Scales(SubArray<Vector2> value) { }

	// RVA: 0x5059D0 Offset: 0x5043D0 VA: 0x1805059D0
	public Vector3[] get_Vertex() { }

	// RVA: 0x506200 Offset: 0x504C00 VA: 0x180506200
	public void set_Vertex(Vector3[] value) { }

	// RVA: 0x505910 Offset: 0x504310 VA: 0x180505910
	public Vector3[] get_VertexNormal() { }

	// RVA: 0x505FE0 Offset: 0x5049E0 VA: 0x180505FE0
	public void set_VertexNormal(Vector3[] value) { }

	// RVA: 0x5056F0 Offset: 0x5040F0 VA: 0x1805056F0
	public float[] get_CrossF() { }

	// RVA: 0x505B80 Offset: 0x504580 VA: 0x180505B80
	public void set_CrossF(float[] value) { }

	// RVA: 0x5057A0 Offset: 0x5041A0 VA: 0x1805057A0
	public float[] get_CrossMap() { }

	// RVA: 0x505CB0 Offset: 0x5046B0 VA: 0x180505CB0
	public void set_CrossMap(float[] value) { }

	// RVA: 0x505880 Offset: 0x504280 VA: 0x180505880
	public float[] get_SegmentLength() { }

	// RVA: 0x505FC0 Offset: 0x5049C0 VA: 0x180505FC0
	public void set_SegmentLength(float[] value) { }

	// RVA: 0x505860 Offset: 0x504260 VA: 0x180505860
	public int get_CrossSize() { }

	// RVA: 0x505900 Offset: 0x504300 VA: 0x180505900
	public int get_VertexCount() { }

	[Obsolete("Use one of the other constructors")]
	[UsedImplicitly]
	// RVA: 0x505550 Offset: 0x503F50 VA: 0x180505550
	public void .ctor() { }

	// RVA: 0x505050 Offset: 0x503A50 VA: 0x180505050
	public void .ctor(int samplePoints, CGShape crossShape) { }

	// RVA: 0x504B40 Offset: 0x503540 VA: 0x180504B40
	public void .ctor(CGPath path, CGShape crossShape) { }

	// RVA: 0x504580 Offset: 0x502F80 VA: 0x180504580
	public void .ctor(CGVolume source) { }

	// RVA: 0x502A80 Offset: 0x501480 VA: 0x180502A80 Slot: 5
	protected override bool Dispose(bool disposing) { }

	[NotNull]
	// RVA: 0x503470 Offset: 0x501E70 VA: 0x180503470
	public static CGVolume Get(CGVolume data, CGPath path, CGShape crossShape) { }

	// RVA: -1 Offset: -1 Slot: 7
	public override T Clone<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5CD50 Offset: 0xE5B750 VA: 0x180E5CD50
	|-CGVolume.Clone<object>
	*/

	// RVA: 0x504160 Offset: 0x502B60 VA: 0x180504160
	public void InterpolateVolume(float f, float crossF, out Vector3 pos, out Vector3 dir, out Vector3 up) { }

	// RVA: 0x503BB0 Offset: 0x5025B0 VA: 0x180503BB0
	public Vector3 InterpolateVolumePosition(float f, float crossF) { }

	// RVA: 0x503980 Offset: 0x502380 VA: 0x180503980
	public Vector3 InterpolateVolumeDirection(float f, float crossF) { }

	// RVA: 0x503EE0 Offset: 0x5028E0 VA: 0x180503EE0
	public Vector3 InterpolateVolumeUp(float f, float crossF) { }

	// RVA: 0x502F70 Offset: 0x501970 VA: 0x180502F70
	public float GetCrossLength(float pathF) { }

	// RVA: 0x502A30 Offset: 0x501430 VA: 0x180502A30
	public float CrossFToDistance(float f, float crossF, CurvyClamping crossClamping = 0) { }

	// RVA: 0x5029E0 Offset: 0x5013E0 VA: 0x1805029E0
	public float CrossDistanceToF(float f, float distance, CurvyClamping crossClamping = 0) { }

	[Obsolete("Method will get removed. Copy its content if you still need it")]
	[UsedImplicitly]
	// RVA: 0x503120 Offset: 0x501B20 VA: 0x180503120
	public void GetSegmentIndices(float pathF, out int segment0Index, out int segment1Index, out float frag) { }

	// RVA: 0x503110 Offset: 0x501B10 VA: 0x180503110
	public int GetSegmentIndex(int segment) { }

	// RVA: 0x502EE0 Offset: 0x5018E0 VA: 0x180502EE0
	public int GetCrossFIndex(float crossF, out float frag) { }

	// RVA: 0x5033A0 Offset: 0x501DA0 VA: 0x1805033A0
	public int GetVertexIndex(float pathF, out float pathFrag) { }

	// RVA: 0x5033C0 Offset: 0x501DC0 VA: 0x1805033C0
	public int GetVertexIndex(float pathF, float crossF, out float pathFrag, out float crossFrag) { }

	// RVA: 0x5031A0 Offset: 0x501BA0 VA: 0x1805031A0
	public Vector3[] GetSegmentVertices(int[] segmentIndices) { }

	// RVA: 0x505560 Offset: 0x503F60 VA: 0x180505560
	private float calcSegmentLength(int segmentIndex) { }
}
