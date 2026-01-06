internal class Style // TypeDefIndex: 5215
{
	// Fields
	private string name; // 0x10
	private StyleType type; // 0x18
	private bool additive; // 0x1C
	private int num; // 0x20
	private int based_on; // 0x24
	private int next_par; // 0x28
	private StyleElement elements; // 0x30
	private Style next; // 0x38

	// Properties
	public string Name { get; set; }
	public StyleType Type { set; }
	public bool Additive { set; }
	public int BasedOn { set; }
	public StyleElement Elements { get; set; }
	public int NextPar { get; set; }
	public int Num { get; set; }

	// Methods

	// RVA: 0x21D5B30 Offset: 0x21D4530 VA: 0x1821D5B30
	public void .ctor(RTF rtf) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Name() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Name(string value) { }

	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	public void set_Type(StyleType value) { }

	// RVA: 0xCDF8D0 Offset: 0xCDE2D0 VA: 0x180CDF8D0
	public void set_Additive(bool value) { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_BasedOn(int value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public StyleElement get_Elements() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_Elements(StyleElement value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_NextPar() { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void set_NextPar(int value) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_Num() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_Num(int value) { }
}
