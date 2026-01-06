public struct MinMaxRangeFloat : IEquatable<MinMaxRangeFloat> // TypeDefIndex: 309
{
	// Fields
	[SerializeField]
	private float m_MinValue; // 0x0
	[SerializeField]
	private float m_MaxValue; // 0x4

	// Properties
	public float minValue { get; }
	public float maxValue { get; }
	public float randomValue { get; }
	public Vector2 asVector2 { get; }

	// Methods

	// RVA: 0x474780 Offset: 0x473180 VA: 0x180474780
	public float get_minValue() { }

	// RVA: 0x474770 Offset: 0x473170 VA: 0x180474770
	public float get_maxValue() { }

	// RVA: 0x493BB0 Offset: 0x4925B0 VA: 0x180493BB0
	public float get_randomValue() { }

	// RVA: 0x4A0C40 Offset: 0x49F640 VA: 0x1804A0C40
	public Vector2 get_asVector2() { }

	// RVA: 0x7B38B0 Offset: 0x7B22B0 VA: 0x1807B38B0
	public float GetLerpedValue(float lerp01) { }

	// RVA: 0x7B38F0 Offset: 0x7B22F0 VA: 0x1807B38F0
	public void .ctor(float min, float max) { }

	// RVA: 0x7B3760 Offset: 0x7B2160 VA: 0x1807B3760 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x7B3800 Offset: 0x7B2200 VA: 0x1807B3800 Slot: 4
	public bool Equals(MinMaxRangeFloat other) { }

	// RVA: 0x7B3830 Offset: 0x7B2230 VA: 0x1807B3830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7B3900 Offset: 0x7B2300 VA: 0x1807B3900
	public static bool op_Equality(MinMaxRangeFloat lhs, MinMaxRangeFloat rhs) { }

	// RVA: 0x7B3940 Offset: 0x7B2340 VA: 0x1807B3940
	public static bool op_Inequality(MinMaxRangeFloat lhs, MinMaxRangeFloat rhs) { }
}
