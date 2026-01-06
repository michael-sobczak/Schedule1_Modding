public class CreateParams // TypeDefIndex: 5297
{
	// Fields
	private string caption; // 0x10
	private string class_name; // 0x18
	private int class_style; // 0x20
	private int ex_style; // 0x24
	private int x; // 0x28
	private int y; // 0x2C
	private int height; // 0x30
	private int width; // 0x34
	private int style; // 0x38
	private object param; // 0x40
	private IntPtr parent; // 0x48
	internal Menu menu; // 0x50
	internal Control control; // 0x58

	// Properties
	public string Caption { get; set; }
	public string ClassName { get; set; }
	public int ClassStyle { get; set; }
	public int ExStyle { get; set; }
	public int X { get; set; }
	public int Y { get; set; }
	public int Width { get; set; }
	public int Height { get; set; }
	public int Style { get; set; }
	public object Param { set; }
	public IntPtr Parent { get; set; }
	internal bool HasWindowManager { get; }
	internal WindowExStyles WindowExStyle { get; set; }
	internal WindowStyles WindowStyle { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Caption() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Caption(string value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_ClassName() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_ClassName(string value) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_ClassStyle() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_ClassStyle(int value) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_ExStyle() { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_ExStyle(int value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_X() { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void set_X(int value) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public int get_Y() { }

	// RVA: 0x65E020 Offset: 0x65CA20 VA: 0x18065E020
	public void set_Y(int value) { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public int get_Width() { }

	// RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40
	public void set_Width(int value) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public int get_Height() { }

	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	public void set_Height(int value) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public int get_Style() { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	public void set_Style(int value) { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_Param(object value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public IntPtr get_Parent() { }

	// RVA: 0xCC6410 Offset: 0xCC4E10 VA: 0x180CC6410
	public void set_Parent(IntPtr value) { }

	// RVA: 0x230D850 Offset: 0x230C250 VA: 0x18230D850
	internal bool IsSet(WindowStyles Style) { }

	// RVA: 0x230D860 Offset: 0x230C260 VA: 0x18230D860
	internal bool IsSet(WindowExStyles ExStyle) { }

	// RVA: 0xD4A560 Offset: 0xD48F60 VA: 0x180D4A560
	internal static bool IsSet(WindowStyles Style, WindowStyles Option) { }

	// RVA: 0x230DBE0 Offset: 0x230C5E0 VA: 0x18230DBE0
	internal bool get_HasWindowManager() { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	internal WindowExStyles get_WindowExStyle() { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	internal void set_WindowExStyle(WindowExStyles value) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	internal WindowStyles get_WindowStyle() { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	internal void set_WindowStyle(WindowStyles value) { }

	// RVA: 0x230D870 Offset: 0x230C270 VA: 0x18230D870 Slot: 3
	public override string ToString() { }
}
