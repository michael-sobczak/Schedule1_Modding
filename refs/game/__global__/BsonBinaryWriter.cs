internal class BsonBinaryWriter // TypeDefIndex: 11431
{
	// Fields
	private static readonly Encoding Encoding; // 0x0
	private readonly BinaryWriter _writer; // 0x10
	private byte[] _largeByteBuffer; // 0x18
	[CompilerGenerated]
	private DateTimeKind <DateTimeKindHandling>k__BackingField; // 0x20

	// Properties
	public DateTimeKind DateTimeKindHandling { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public DateTimeKind get_DateTimeKindHandling() { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_DateTimeKindHandling(DateTimeKind value) { }

	// RVA: 0x1DECC40 Offset: 0x1DEB640 VA: 0x181DECC40
	public void .ctor(BinaryWriter writer) { }

	// RVA: 0x1DEB9A0 Offset: 0x1DEA3A0 VA: 0x181DEB9A0
	public void Flush() { }

	// RVA: 0x1DB2C00 Offset: 0x1DB1600 VA: 0x181DB2C00
	public void Close() { }

	// RVA: 0x1DEC9F0 Offset: 0x1DEB3F0 VA: 0x181DEC9F0
	public void WriteToken(BsonToken t) { }

	// RVA: 0x1DEBBF0 Offset: 0x1DEA5F0 VA: 0x181DEBBF0
	private void WriteTokenInternal(BsonToken t) { }

	// RVA: 0x1DEB9D0 Offset: 0x1DEA3D0 VA: 0x181DEB9D0
	private void WriteString(string s, int byteCount, Nullable<int> calculatedlengthPrefix) { }

	// RVA: 0x1DECA20 Offset: 0x1DEB420 VA: 0x181DECA20
	public void WriteUtf8Bytes(string s, int byteCount) { }

	// RVA: 0x1DEB2C0 Offset: 0x1DE9CC0 VA: 0x181DEB2C0
	private int CalculateSize(int stringByteCount) { }

	// RVA: 0x1DEB2B0 Offset: 0x1DE9CB0 VA: 0x181DEB2B0
	private int CalculateSizeWithLength(int stringByteCount, bool includeSize) { }

	// RVA: 0x1DEB2D0 Offset: 0x1DE9CD0 VA: 0x181DEB2D0
	private int CalculateSize(BsonToken t) { }

	// RVA: 0x1DECBC0 Offset: 0x1DEB5C0 VA: 0x181DECBC0
	private static void .cctor() { }
}
