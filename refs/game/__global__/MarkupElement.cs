internal struct MarkupElement // TypeDefIndex: 15000
{
	// Fields
	private MarkupAttribute[] m_Attributes; // 0x0

	// Properties
	public int NameHashCode { get; set; }
	public int ValueHashCode { get; set; }
	public int ValueStartIndex { get; set; }
	public int ValueLength { get; set; }
	public MarkupAttribute[] Attributes { get; set; }

	// Methods

	// RVA: 0x2C321E0 Offset: 0x2C30BE0 VA: 0x182C321E0
	public int get_NameHashCode() { }

	// RVA: 0x2C322A0 Offset: 0x2C30CA0 VA: 0x182C322A0
	public void set_NameHashCode(int value) { }

	// RVA: 0x2C32210 Offset: 0x2C30C10 VA: 0x182C32210
	public int get_ValueHashCode() { }

	// RVA: 0x2C32320 Offset: 0x2C30D20 VA: 0x182C32320
	public void set_ValueHashCode(int value) { }

	// RVA: 0x2C32270 Offset: 0x2C30C70 VA: 0x182C32270
	public int get_ValueStartIndex() { }

	// RVA: 0x2C32380 Offset: 0x2C30D80 VA: 0x182C32380
	public void set_ValueStartIndex(int value) { }

	// RVA: 0x2C32240 Offset: 0x2C30C40 VA: 0x182C32240
	public int get_ValueLength() { }

	// RVA: 0x2C32350 Offset: 0x2C30D50 VA: 0x182C32350
	public void set_ValueLength(int value) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public MarkupAttribute[] get_Attributes() { }

	// RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	public void set_Attributes(MarkupAttribute[] value) { }

	// RVA: 0x2C32130 Offset: 0x2C30B30 VA: 0x182C32130
	public void .ctor(int nameHashCode, int startIndex, int length) { }
}
