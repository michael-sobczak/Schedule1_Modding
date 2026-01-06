public class TMP_Style // TypeDefIndex: 14967
{
	// Fields
	internal static TMP_Style k_NormalStyle; // 0x0
	[SerializeField]
	private string m_Name; // 0x10
	[SerializeField]
	private int m_HashCode; // 0x18
	[SerializeField]
	private string m_OpeningDefinition; // 0x20
	[SerializeField]
	private string m_ClosingDefinition; // 0x28
	[SerializeField]
	private uint[] m_OpeningTagArray; // 0x30
	[SerializeField]
	private uint[] m_ClosingTagArray; // 0x38

	// Properties
	public static TMP_Style NormalStyle { get; }
	public string name { get; set; }
	public int hashCode { get; set; }
	public string styleOpeningDefinition { get; }
	public string styleClosingDefinition { get; }
	public uint[] styleOpeningTagArray { get; }
	public uint[] styleClosingTagArray { get; }

	// Methods

	// RVA: 0x2C2C0C0 Offset: 0x2C2AAC0 VA: 0x182C2C0C0
	public static TMP_Style get_NormalStyle() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_name() { }

	// RVA: 0x2C2C1C0 Offset: 0x2C2ABC0 VA: 0x182C2C1C0
	public void set_name(string value) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_hashCode() { }

	// RVA: 0x2C2C1B0 Offset: 0x2C2ABB0 VA: 0x182C2C1B0
	public void set_hashCode(int value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_styleOpeningDefinition() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_styleClosingDefinition() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public uint[] get_styleOpeningTagArray() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public uint[] get_styleClosingTagArray() { }

	// RVA: 0x2C2C000 Offset: 0x2C2AA00 VA: 0x182C2C000
	internal void .ctor(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	// RVA: 0x2C2BE50 Offset: 0x2C2A850 VA: 0x182C2BE50
	public void RefreshStyle() { }
}
