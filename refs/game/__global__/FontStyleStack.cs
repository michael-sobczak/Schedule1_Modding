internal struct FontStyleStack // TypeDefIndex: 16754
{
	// Fields
	public byte bold; // 0x0
	public byte italic; // 0x1
	public byte underline; // 0x2
	public byte strikethrough; // 0x3
	public byte highlight; // 0x4
	public byte superscript; // 0x5
	public byte subscript; // 0x6
	public byte uppercase; // 0x7
	public byte lowercase; // 0x8
	public byte smallcaps; // 0x9

	// Methods

	// RVA: 0x2C326D0 Offset: 0x2C310D0 VA: 0x182C326D0
	public void Clear() { }

	// RVA: 0x2C32620 Offset: 0x2C31020 VA: 0x182C32620
	public byte Add(FontStyles style) { }

	// RVA: 0x2C326E0 Offset: 0x2C310E0 VA: 0x182C326E0
	public byte Remove(FontStyles style) { }
}
