internal struct ZipGenericExtraField // TypeDefIndex: 17663
{
	// Fields
	private ushort _tag; // 0x0
	private ushort _size; // 0x2
	private byte[] _data; // 0x8

	// Properties
	public ushort Tag { get; }
	public ushort Size { get; }
	public byte[] Data { get; }

	// Methods

	// RVA: 0xCBDF50 Offset: 0xCBC950 VA: 0x180CBDF50
	public ushort get_Tag() { }

	// RVA: 0xCBDFC0 Offset: 0xCBC9C0 VA: 0x180CBDFC0
	public ushort get_Size() { }

	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public byte[] get_Data() { }

	// RVA: 0x217B860 Offset: 0x217A260 VA: 0x18217B860
	public void WriteBlock(Stream stream) { }

	// RVA: 0x217B570 Offset: 0x2179F70 VA: 0x18217B570
	public static bool TryReadBlock(BinaryReader reader, long endExtraField, out ZipGenericExtraField field) { }

	// RVA: 0x217B230 Offset: 0x2179C30 VA: 0x18217B230
	public static List<ZipGenericExtraField> ParseExtraField(Stream extraFieldData) { }

	// RVA: 0x217B450 Offset: 0x2179E50 VA: 0x18217B450
	public static int TotalSize(List<ZipGenericExtraField> fields) { }

	// RVA: 0x217B6A0 Offset: 0x217A0A0 VA: 0x18217B6A0
	public static void WriteAllBlocks(List<ZipGenericExtraField> fields, Stream stream) { }
}
