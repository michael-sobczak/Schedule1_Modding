public struct SamplePointsPatch : IEquatable<SamplePointsPatch> // TypeDefIndex: 10690
{
	// Fields
	public int Start; // 0x0
	public int Count; // 0x4

	// Properties
	public int End { get; set; }
	public int TriangleCount { get; }

	// Methods

	// RVA: 0x50DD50 Offset: 0x50C750 VA: 0x18050DD50
	public int get_End() { }

	// RVA: 0x50DDB0 Offset: 0x50C7B0 VA: 0x18050DDB0
	public void set_End(int value) { }

	// RVA: 0x50DD60 Offset: 0x50C760 VA: 0x18050DD60
	public int get_TriangleCount() { }

	// RVA: 0x50DD40 Offset: 0x50C740 VA: 0x18050DD40
	public void .ctor(int start) { }

	// RVA: 0x50DB00 Offset: 0x50C500 VA: 0x18050DB00 Slot: 3
	public override string ToString() { }

	// RVA: 0x50DAD0 Offset: 0x50C4D0 VA: 0x18050DAD0 Slot: 4
	public bool Equals(SamplePointsPatch other) { }

	// RVA: 0x50DA40 Offset: 0x50C440 VA: 0x18050DA40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x50DAF0 Offset: 0x50C4F0 VA: 0x18050DAF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x50DD70 Offset: 0x50C770 VA: 0x18050DD70
	public static bool op_Equality(SamplePointsPatch left, SamplePointsPatch right) { }

	// RVA: 0x50DD90 Offset: 0x50C790 VA: 0x18050DD90
	public static bool op_Inequality(SamplePointsPatch left, SamplePointsPatch right) { }
}
