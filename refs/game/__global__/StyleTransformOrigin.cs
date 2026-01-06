public struct StyleTransformOrigin : IStyleValue<TransformOrigin>, IEquatable<StyleTransformOrigin> // TypeDefIndex: 6824
{
	// Fields
	private TransformOrigin m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x14

	// Properties
	public TransformOrigin value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x2F05CB0 Offset: 0x2F046B0 VA: 0x182F05CB0 Slot: 4
	public TransformOrigin get_value() { }

	// RVA: 0x1667070 Offset: 0x1665A70 VA: 0x181667070 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x2EFF9A0 Offset: 0x2EFE3A0 VA: 0x182EFF9A0
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x2EFF980 Offset: 0x2EFE380 VA: 0x182EFF980
	internal void .ctor(TransformOrigin v, StyleKeyword keyword) { }

	// RVA: 0x2F05DD0 Offset: 0x2F047D0 VA: 0x182F05DD0
	public static bool op_Equality(StyleTransformOrigin lhs, StyleTransformOrigin rhs) { }

	// RVA: 0x2EFFA80 Offset: 0x2EFE480 VA: 0x182EFFA80
	public static StyleTransformOrigin op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x2F05A90 Offset: 0x2F04490 VA: 0x182F05A90 Slot: 6
	public bool Equals(StyleTransformOrigin other) { }

	// RVA: 0x2F05B80 Offset: 0x2F04580 VA: 0x182F05B80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F05C20 Offset: 0x2F04620 VA: 0x182F05C20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F05C40 Offset: 0x2F04640 VA: 0x182F05C40 Slot: 3
	public override string ToString() { }
}
