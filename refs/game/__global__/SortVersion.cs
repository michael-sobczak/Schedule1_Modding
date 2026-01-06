public sealed class SortVersion : IEquatable<SortVersion> // TypeDefIndex: 4814
{
	// Fields
	private int m_NlsVersion; // 0x10
	private Guid m_SortId; // 0x14

	// Methods

	// RVA: 0x1BAF410 Offset: 0x1BADE10 VA: 0x181BAF410 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1BAF3A0 Offset: 0x1BADDA0 VA: 0x181BAF3A0 Slot: 4
	public bool Equals(SortVersion other) { }

	// RVA: 0x1BAF4D0 Offset: 0x1BADED0 VA: 0x181BAF4D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1BAF4F0 Offset: 0x1BADEF0 VA: 0x181BAF4F0
	public static bool op_Equality(SortVersion left, SortVersion right) { }

	// RVA: 0x1BAF510 Offset: 0x1BADF10 VA: 0x181BAF510
	public static bool op_Inequality(SortVersion left, SortVersion right) { }
}
