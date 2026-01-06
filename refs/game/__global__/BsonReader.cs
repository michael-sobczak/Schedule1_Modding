public class BsonReader : JsonReader // TypeDefIndex: 11435
{
	// Fields
	private const int MaxCharBytesSize = 128;
	private static readonly byte[] SeqRange1; // 0x0
	private static readonly byte[] SeqRange2; // 0x8
	private static readonly byte[] SeqRange3; // 0x10
	private static readonly byte[] SeqRange4; // 0x18
	private readonly BinaryReader _reader; // 0x78
	private readonly List<BsonReader.ContainerContext> _stack; // 0x80
	private byte[] _byteBuffer; // 0x88
	private char[] _charBuffer; // 0x90
	private BsonType _currentElementType; // 0x98
	private BsonReader.BsonReaderState _bsonReaderState; // 0x9C
	private BsonReader.ContainerContext _currentContext; // 0xA0
	private bool _readRootValueAsArray; // 0xA8
	private bool _jsonNet35BinaryCompatibility; // 0xA9
	private DateTimeKind _dateTimeKindHandling; // 0xAC

	// Properties
	[Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
	public bool JsonNet35BinaryCompatibility { get; set; }
	public bool ReadRootValueAsArray { get; set; }
	public DateTimeKind DateTimeKindHandling { get; set; }

	// Methods

	// RVA: 0x1DEF7C0 Offset: 0x1DEE1C0 VA: 0x181DEF7C0
	public bool get_JsonNet35BinaryCompatibility() { }

	// RVA: 0x1DEF7D0 Offset: 0x1DEE1D0 VA: 0x181DEF7D0
	public void set_JsonNet35BinaryCompatibility(bool value) { }

	// RVA: 0x4D63F0 Offset: 0x4D4DF0 VA: 0x1804D63F0
	public bool get_ReadRootValueAsArray() { }

	// RVA: 0x4D6660 Offset: 0x4D5060 VA: 0x1804D6660
	public void set_ReadRootValueAsArray(bool value) { }

	// RVA: 0xBBA750 Offset: 0xBB9150 VA: 0x180BBA750
	public DateTimeKind get_DateTimeKindHandling() { }

	// RVA: 0xBBA820 Offset: 0xBB9220 VA: 0x180BBA820
	public void set_DateTimeKindHandling(DateTimeKind value) { }

	// RVA: 0x1DEF5B0 Offset: 0x1DEDFB0 VA: 0x181DEF5B0
	public void .ctor(Stream stream) { }

	// RVA: 0x1DEF4F0 Offset: 0x1DEDEF0 VA: 0x181DEF4F0
	public void .ctor(BinaryReader reader) { }

	// RVA: 0x1DEF6B0 Offset: 0x1DEE0B0 VA: 0x181DEF6B0
	public void .ctor(Stream stream, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling) { }

	// RVA: 0x1DEF410 Offset: 0x1DEDE10 VA: 0x181DEF410
	public void .ctor(BinaryReader reader, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling) { }

	// RVA: 0x1DEDF90 Offset: 0x1DEC990 VA: 0x181DEDF90
	private string ReadElement() { }

	// RVA: 0x1DEF120 Offset: 0x1DEDB20 VA: 0x181DEF120 Slot: 21
	public override bool Read() { }

	// RVA: 0x1DED4D0 Offset: 0x1DEBED0 VA: 0x181DED4D0 Slot: 31
	public override void Close() { }

	// RVA: 0x1DEDCE0 Offset: 0x1DEC6E0 VA: 0x181DEDCE0
	private bool ReadCodeWScope() { }

	// RVA: 0x1DEE430 Offset: 0x1DECE30 VA: 0x181DEE430
	private bool ReadReference() { }

	// RVA: 0x1DEE0F0 Offset: 0x1DECAF0 VA: 0x181DEE0F0
	private bool ReadNormal() { }

	// RVA: 0x1DED9D0 Offset: 0x1DEC3D0 VA: 0x181DED9D0
	private void PopContext() { }

	// RVA: 0x1DEDAA0 Offset: 0x1DEC4A0 VA: 0x181DEDAA0
	private void PushContext(BsonReader.ContainerContext newContext) { }

	// RVA: 0x1DEDC60 Offset: 0x1DEC660 VA: 0x181DEDC60
	private byte ReadByte() { }

	// RVA: 0x1DEEA00 Offset: 0x1DED400 VA: 0x181DEEA00
	private void ReadType(BsonType type) { }

	// RVA: 0x1DEDB60 Offset: 0x1DEC560 VA: 0x181DEDB60
	private byte[] ReadBinary(out BsonBinaryType binaryType) { }

	// RVA: 0x1DEE710 Offset: 0x1DED110 VA: 0x181DEE710
	private string ReadString() { }

	// RVA: 0x1DEE060 Offset: 0x1DECA60 VA: 0x181DEE060
	private string ReadLengthString() { }

	// RVA: 0x1DED680 Offset: 0x1DEC080 VA: 0x181DED680
	private string GetString(int length) { }

	// RVA: 0x1DED5E0 Offset: 0x1DEBFE0 VA: 0x181DED5E0
	private int GetLastFullCharStop(int start) { }

	// RVA: 0x1DED2E0 Offset: 0x1DEBCE0 VA: 0x181DED2E0
	private int BytesInSequence(byte b) { }

	// RVA: 0x1DED510 Offset: 0x1DEBF10 VA: 0x181DED510
	private void EnsureBuffers() { }

	// RVA: 0x1DEDF50 Offset: 0x1DEC950 VA: 0x181DEDF50
	private double ReadDouble() { }

	// RVA: 0x1DEDFE0 Offset: 0x1DEC9E0 VA: 0x181DEDFE0
	private int ReadInt32() { }

	// RVA: 0x1DEE020 Offset: 0x1DECA20 VA: 0x181DEE020
	private long ReadInt64() { }

	// RVA: 0x1DEF0E0 Offset: 0x1DEDAE0 VA: 0x181DEF0E0
	private BsonType ReadType() { }

	// RVA: 0x1DED9B0 Offset: 0x1DEC3B0 VA: 0x181DED9B0
	private void MovePosition(int count) { }

	// RVA: 0x1DEDCA0 Offset: 0x1DEC6A0 VA: 0x181DEDCA0
	private byte[] ReadBytes(int count) { }

	// RVA: 0x1DEF260 Offset: 0x1DEDC60 VA: 0x181DEF260
	private static void .cctor() { }
}
