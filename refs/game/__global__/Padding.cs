public struct Padding // TypeDefIndex: 5527
{
	// Fields
	private int _bottom; // 0x0
	private int _left; // 0x4
	private int _right; // 0x8
	private int _top; // 0xC
	private bool _all; // 0x10
	public static readonly Padding Empty; // 0x0

	// Properties
	[RefreshProperties(1)]
	public int All { get; }
	[RefreshProperties(1)]
	public int Bottom { get; set; }
	[Browsable(False)]
	public int Horizontal { get; }
	[RefreshProperties(1)]
	public int Left { get; set; }
	[RefreshProperties(1)]
	public int Right { get; set; }
	[RefreshProperties(1)]
	public int Top { get; set; }
	[Browsable(False)]
	public int Vertical { get; }

	// Methods

	// RVA: 0x239CC20 Offset: 0x239B620 VA: 0x18239CC20
	public void .ctor(int all) { }

	// RVA: 0x239CBF0 Offset: 0x239B5F0 VA: 0x18239CBF0
	public void .ctor(int left, int top, int right, int bottom) { }

	// RVA: 0x239CB90 Offset: 0x239B590 VA: 0x18239CB90
	private static void .cctor() { }

	// RVA: 0x239CC30 Offset: 0x239B630 VA: 0x18239CC30
	public int get_All() { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public int get_Bottom() { }

	// RVA: 0x239CCE0 Offset: 0x239B6E0 VA: 0x18239CCE0
	public void set_Bottom(int value) { }

	// RVA: 0x239CC40 Offset: 0x239B640 VA: 0x18239CC40
	public int get_Horizontal() { }

	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public int get_Left() { }

	// RVA: 0x239CCF0 Offset: 0x239B6F0 VA: 0x18239CCF0
	public void set_Left(int value) { }

	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	public int get_Right() { }

	// RVA: 0x239CD00 Offset: 0x239B700 VA: 0x18239CD00
	public void set_Right(int value) { }

	// RVA: 0x4975D0 Offset: 0x495FD0 VA: 0x1804975D0
	public int get_Top() { }

	// RVA: 0x239CD10 Offset: 0x239B710 VA: 0x18239CD10
	public void set_Top(int value) { }

	// RVA: 0x239CC50 Offset: 0x239B650 VA: 0x18239CC50
	public int get_Vertical() { }

	// RVA: 0x239C640 Offset: 0x239B040 VA: 0x18239C640 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1C60960 Offset: 0x1C5F360 VA: 0x181C60960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x239C780 Offset: 0x239B180 VA: 0x18239C780 Slot: 3
	public override string ToString() { }

	// RVA: 0x239CC60 Offset: 0x239B660 VA: 0x18239CC60
	public static bool op_Inequality(Padding p1, Padding p2) { }
}
