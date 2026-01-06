public class VisualStyleElement // TypeDefIndex: 6021
{
	// Fields
	private string class_name; // 0x10
	private int part; // 0x18
	private int state; // 0x1C

	// Properties
	public string ClassName { get; }
	public int Part { get; }
	public int State { get; }

	// Methods

	// RVA: 0x7A3DD0 Offset: 0x7A27D0 VA: 0x1807A3DD0
	internal void .ctor(string className, int part, int state) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_ClassName() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_Part() { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_State() { }

	// RVA: 0x22E4A10 Offset: 0x22E3410 VA: 0x1822E4A10
	public static VisualStyleElement CreateElement(string className, int part, int state) { }
}
