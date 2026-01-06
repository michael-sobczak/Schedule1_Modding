public struct RectangleF : IEquatable<RectangleF> // TypeDefIndex: 17112
{
	// Fields
	private float x; // 0x0
	private float y; // 0x4
	private float width; // 0x8
	private float height; // 0xC

	// Properties
	[Browsable(False)]
	public PointF Location { set; }
	[Browsable(False)]
	public SizeF Size { set; }
	public float X { get; set; }
	public float Y { get; set; }
	public float Width { get; set; }
	public float Height { get; set; }
	[Browsable(False)]
	public float Right { get; }
	[Browsable(False)]
	public float Bottom { get; }

	// Methods

	// RVA: 0xDA46A0 Offset: 0xDA30A0 VA: 0x180DA46A0
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x214CB60 Offset: 0x214B560 VA: 0x18214CB60
	public void .ctor(PointF location, SizeF size) { }

	// RVA: 0x214CC40 Offset: 0x214B640 VA: 0x18214CC40
	public void set_Location(PointF value) { }

	// RVA: 0x214CC60 Offset: 0x214B660 VA: 0x18214CC60
	public void set_Size(SizeF value) { }

	// RVA: 0x474780 Offset: 0x473180 VA: 0x180474780
	public float get_X() { }

	// RVA: 0x4D53B0 Offset: 0x4D3DB0 VA: 0x1804D53B0
	public void set_X(float value) { }

	// RVA: 0x474770 Offset: 0x473170 VA: 0x180474770
	public float get_Y() { }

	// RVA: 0x4D5390 Offset: 0x4D3D90 VA: 0x1804D5390
	public void set_Y(float value) { }

	// RVA: 0x4747A0 Offset: 0x4731A0 VA: 0x1804747A0
	public float get_Width() { }

	// RVA: 0x4D53A0 Offset: 0x4D3DA0 VA: 0x1804D53A0
	public void set_Width(float value) { }

	// RVA: 0x474790 Offset: 0x473190 VA: 0x180474790
	public float get_Height() { }

	// RVA: 0x4D5380 Offset: 0x4D3D80 VA: 0x1804D5380
	public void set_Height(float value) { }

	// RVA: 0x214CBB0 Offset: 0x214B5B0 VA: 0x18214CBB0
	public float get_Right() { }

	// RVA: 0x214CBA0 Offset: 0x214B5A0 VA: 0x18214CBA0
	public float get_Bottom() { }

	// RVA: 0x214C760 Offset: 0x214B160 VA: 0x18214C760 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x214C830 Offset: 0x214B230 VA: 0x18214C830 Slot: 4
	public bool Equals(RectangleF other) { }

	// RVA: 0x214CBC0 Offset: 0x214B5C0 VA: 0x18214CBC0
	public static bool op_Equality(RectangleF left, RectangleF right) { }

	// RVA: 0x214C880 Offset: 0x214B280 VA: 0x18214C880 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x214CC00 Offset: 0x214B600 VA: 0x18214CC00
	public static RectangleF op_Implicit(Rectangle r) { }

	// RVA: 0x214C970 Offset: 0x214B370 VA: 0x18214C970 Slot: 3
	public override string ToString() { }
}
