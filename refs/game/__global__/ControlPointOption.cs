public struct ControlPointOption : IEquatable<ControlPointOption> // TypeDefIndex: 10665
{
	// Fields
	public float TF; // 0x0
	public float Distance; // 0x4
	public bool Include; // 0x8
	public int MaterialID; // 0xC
	public bool HardEdge; // 0x10
	public float MaxStepDistance; // 0x14
	public bool UVEdge; // 0x18
	public bool UVShift; // 0x19
	public float FirstU; // 0x1C
	public float SecondU; // 0x20

	// Methods

	// RVA: 0x506700 Offset: 0x505100 VA: 0x180506700
	public void .ctor(float tf, float dist, bool includeAnyways, int materialID, bool hardEdge, float maxStepDistance, bool uvEdge, bool uvShift, float firstU, float secondU) { }

	// RVA: 0x506460 Offset: 0x504E60 VA: 0x180506460 Slot: 4
	public bool Equals(ControlPointOption other) { }

	// RVA: 0x506520 Offset: 0x504F20 VA: 0x180506520 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5065D0 Offset: 0x504FD0 VA: 0x1805065D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x506760 Offset: 0x505160 VA: 0x180506760
	public static bool op_Equality(ControlPointOption left, ControlPointOption right) { }

	// RVA: 0x506790 Offset: 0x505190 VA: 0x180506790
	public static bool op_Inequality(ControlPointOption left, ControlPointOption right) { }
}
