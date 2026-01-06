internal sealed class OutputWindow // TypeDefIndex: 17654
{
	// Fields
	private readonly byte[] _window; // 0x10
	private int _end; // 0x18
	private int _bytesUsed; // 0x1C

	// Properties
	public int FreeBytes { get; }
	public int AvailableBytes { get; }

	// Methods

	// RVA: 0x2171100 Offset: 0x216FB00 VA: 0x182171100
	public void Write(byte b) { }

	// RVA: 0x2170FC0 Offset: 0x216F9C0 VA: 0x182170FC0
	public void WriteLengthDistance(int length, int distance) { }

	// RVA: 0x2170C70 Offset: 0x216F670 VA: 0x182170C70
	public int CopyFrom(InputBuffer input, int length) { }

	// RVA: 0x21711A0 Offset: 0x216FBA0 VA: 0x1821711A0
	public int get_FreeBytes() { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_AvailableBytes() { }

	// RVA: 0x2170F00 Offset: 0x216F900 VA: 0x182170F00
	public int CopyTo(byte[] output, int offset, int length) { }

	// RVA: 0x2171140 Offset: 0x216FB40 VA: 0x182171140
	public void .ctor() { }
}
