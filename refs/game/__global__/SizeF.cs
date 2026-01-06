public struct SizeF : IEquatable<SizeF> // TypeDefIndex: 17114
{
	// Fields
	public static readonly SizeF Empty; // 0x0
	private float width; // 0x0
	private float height; // 0x4

	// Properties
	[Browsable(False)]
	public bool IsEmpty { get; }
	public float Width { get; set; }
	public float Height { get; set; }

	// Methods

	// RVA: 0x7B38F0 Offset: 0x7B22F0 VA: 0x1807B38F0
	public void .ctor(float width, float height) { }

	// RVA: 0x7B3900 Offset: 0x7B2300 VA: 0x1807B3900
	public static bool op_Equality(SizeF sz1, SizeF sz2) { }

	// RVA: 0x7B3940 Offset: 0x7B2340 VA: 0x1807B3940
	public static bool op_Inequality(SizeF sz1, SizeF sz2) { }

	// RVA: 0x214D7F0 Offset: 0x214C1F0 VA: 0x18214D7F0
	public bool get_IsEmpty() { }

	// RVA: 0x474780 Offset: 0x473180 VA: 0x180474780
	public float get_Width() { }

	// RVA: 0x4D53B0 Offset: 0x4D3DB0 VA: 0x1804D53B0
	public void set_Width(float value) { }

	// RVA: 0x474770 Offset: 0x473170 VA: 0x180474770
	public float get_Height() { }

	// RVA: 0x4D5390 Offset: 0x4D3D90 VA: 0x1804D5390
	public void set_Height(float value) { }

	// RVA: 0x214D570 Offset: 0x214BF70 VA: 0x18214D570 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x214C190 Offset: 0x214AB90 VA: 0x18214C190 Slot: 4
	public bool Equals(SizeF other) { }

	// RVA: 0x214D610 Offset: 0x214C010 VA: 0x18214D610 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x214D6A0 Offset: 0x214C0A0 VA: 0x18214D6A0
	public Size ToSize() { }

	// RVA: 0x214D6D0 Offset: 0x214C0D0 VA: 0x18214D6D0 Slot: 3
	public override string ToString() { }
}
