public struct Size : IEquatable<Size> // TypeDefIndex: 17113
{
	// Fields
	public static readonly Size Empty; // 0x0
	private int width; // 0x0
	private int height; // 0x4

	// Properties
	[Browsable(False)]
	public bool IsEmpty { get; }
	public int Width { get; set; }
	public int Height { get; set; }

	// Methods

	// RVA: 0x541AB0 Offset: 0x5404B0 VA: 0x180541AB0
	public void .ctor(int width, int height) { }

	// RVA: 0x214C690 Offset: 0x214B090 VA: 0x18214C690
	public static SizeF op_Implicit(Size p) { }

	// RVA: 0x214C670 Offset: 0x214B070 VA: 0x18214C670
	public static Size op_Addition(Size sz1, Size sz2) { }

	// RVA: 0x50DD70 Offset: 0x50C770 VA: 0x18050DD70
	public static bool op_Equality(Size sz1, Size sz2) { }

	// RVA: 0x50DD90 Offset: 0x50C790 VA: 0x18050DD90
	public static bool op_Inequality(Size sz1, Size sz2) { }

	// RVA: 0x214DAB0 Offset: 0x214C4B0 VA: 0x18214DAB0
	public bool get_IsEmpty() { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public int get_Width() { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_Width(int value) { }

	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public int get_Height() { }

	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	public void set_Height(int value) { }

	// RVA: 0xB1B7F0 Offset: 0xB1A1F0 VA: 0x180B1B7F0
	public static Size Add(Size sz1, Size sz2) { }

	// RVA: 0x214D810 Offset: 0x214C210 VA: 0x18214D810
	public static Size Ceiling(SizeF value) { }

	// RVA: 0x214DA90 Offset: 0x214C490 VA: 0x18214DA90
	public static Size Truncate(SizeF value) { }

	// RVA: 0x214D880 Offset: 0x214C280 VA: 0x18214D880 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x214C410 Offset: 0x214AE10 VA: 0x18214C410 Slot: 4
	public bool Equals(Size other) { }

	// RVA: 0x214D910 Offset: 0x214C310 VA: 0x18214D910 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x214D970 Offset: 0x214C370 VA: 0x18214D970 Slot: 3
	public override string ToString() { }
}
