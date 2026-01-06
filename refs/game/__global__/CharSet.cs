internal class Charset // TypeDefIndex: 5200
{
	// Fields
	private CharsetType id; // 0x10
	private CharsetFlags flags; // 0x14
	private Charcode code; // 0x18
	private string file; // 0x20

	// Properties
	public CharsetFlags Flags { get; }
	public CharsetType ID { set; }
	public StandardCharCode Item { get; }

	// Methods

	// RVA: 0x21ACBC0 Offset: 0x21AB5C0 VA: 0x1821ACBC0
	public void .ctor() { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public CharsetFlags get_Flags() { }

	// RVA: 0x21ACD00 Offset: 0x21AB700 VA: 0x1821ACD00
	public void set_ID(CharsetType value) { }

	// RVA: 0x21ACCB0 Offset: 0x21AB6B0 VA: 0x1821ACCB0
	public StandardCharCode get_Item(int c) { }

	// RVA: 0x21ACB10 Offset: 0x21AB510 VA: 0x1821ACB10
	public bool ReadMap() { }
}
