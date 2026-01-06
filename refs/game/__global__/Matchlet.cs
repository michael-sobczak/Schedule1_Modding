internal class Matchlet // TypeDefIndex: 5507
{
	// Fields
	private byte[] byteValue; // 0x10
	private byte[] mask; // 0x18
	private int offset; // 0x20
	private int offsetLength; // 0x24
	private int wordSize; // 0x28
	private ArrayList matchlets; // 0x30

	// Properties
	public byte[] ByteValue { get; set; }
	public byte[] Mask { get; set; }
	public int Offset { get; set; }
	public int OffsetLength { get; set; }
	public ArrayList Matchlets { get; }

	// Methods

	// RVA: 0x23847C0 Offset: 0x23831C0 VA: 0x1823847C0
	public void .ctor() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_ByteValue(byte[] value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public byte[] get_ByteValue() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Mask(byte[] value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public byte[] get_Mask() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_Offset(int value) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_Offset() { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_OffsetLength(int value) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_OffsetLength() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public ArrayList get_Matchlets() { }
}
