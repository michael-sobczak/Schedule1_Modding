public struct SamplePointUData : IEquatable<SamplePointUData> // TypeDefIndex: 10691
{
	// Fields
	public int Vertex; // 0x0
	public bool UVEdge; // 0x4
	public bool HardEdge; // 0x5
	public float FirstU; // 0x8
	public float SecondU; // 0xC

	// Methods

	[Obsolete("Use other constructors")]
	[UsedImplicitly]
	// RVA: 0x526660 Offset: 0x525060 VA: 0x180526660
	public void .ctor(int vertexIndex, bool uvEdge, float firstU, float secondU) { }

	// RVA: 0x526600 Offset: 0x525000 VA: 0x180526600
	public void .ctor(int vertexIndex, bool uvEdge, bool hardEdge, float firstU, float secondU) { }

	// RVA: 0x526630 Offset: 0x525030 VA: 0x180526630
	public void .ctor(int vertexIndex, ControlPointOption controlPointsOption) { }

	// RVA: 0x526330 Offset: 0x524D30 VA: 0x180526330 Slot: 3
	public override string ToString() { }

	// RVA: 0x526110 Offset: 0x524B10 VA: 0x180526110 Slot: 4
	public bool Equals(SamplePointUData other) { }

	// RVA: 0x526180 Offset: 0x524B80 VA: 0x180526180 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x526270 Offset: 0x524C70 VA: 0x180526270 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x526680 Offset: 0x525080 VA: 0x180526680
	public static bool op_Equality(SamplePointUData left, SamplePointUData right) { }

	// RVA: 0x526700 Offset: 0x525100 VA: 0x180526700
	public static bool op_Inequality(SamplePointUData left, SamplePointUData right) { }
}
