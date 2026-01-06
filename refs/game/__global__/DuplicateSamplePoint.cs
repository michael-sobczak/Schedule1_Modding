public struct DuplicateSamplePoint : IEquatable<DuplicateSamplePoint> // TypeDefIndex: 10677
{
	// Fields
	[CompilerGenerated]
	private readonly int <StartIndex>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly int <EndIndex>k__BackingField; // 0x4
	[CompilerGenerated]
	private readonly bool <IsHardEdge>k__BackingField; // 0x8

	// Properties
	public int StartIndex { get; }
	public int EndIndex { get; }
	public bool IsHardEdge { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public int get_StartIndex() { }

	[CompilerGenerated]
	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public int get_EndIndex() { }

	[CompilerGenerated]
	// RVA: 0x48A510 Offset: 0x488F10 VA: 0x18048A510
	public bool get_IsHardEdge() { }

	// RVA: 0x50B580 Offset: 0x509F80 VA: 0x18050B580
	public void .ctor(int startIndex, int endIndex, bool isHardEdge) { }

	// RVA: 0x50B140 Offset: 0x509B40 VA: 0x18050B140 Slot: 4
	public bool Equals(DuplicateSamplePoint other) { }

	// RVA: 0x50B160 Offset: 0x509B60 VA: 0x18050B160 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x50B210 Offset: 0x509C10 VA: 0x18050B210 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x50B5A0 Offset: 0x509FA0 VA: 0x18050B5A0
	public static bool op_Equality(DuplicateSamplePoint left, DuplicateSamplePoint right) { }

	// RVA: 0x50B5E0 Offset: 0x509FE0 VA: 0x18050B5E0
	public static bool op_Inequality(DuplicateSamplePoint left, DuplicateSamplePoint right) { }

	// RVA: 0x50B290 Offset: 0x509C90 VA: 0x18050B290 Slot: 3
	public override string ToString() { }
}
