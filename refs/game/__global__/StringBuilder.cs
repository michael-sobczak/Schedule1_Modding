public sealed class StringBuilder : ISerializable // TypeDefIndex: 4121
{
	// Fields
	internal char[] m_ChunkChars; // 0x10
	internal StringBuilder m_ChunkPrevious; // 0x18
	internal int m_ChunkLength; // 0x20
	internal int m_ChunkOffset; // 0x24
	internal int m_MaxCapacity; // 0x28
	internal const int DefaultCapacity = 16;
	private const string CapacityField = "Capacity";
	private const string MaxCapacityField = "m_MaxCapacity";
	private const string StringValueField = "m_StringValue";
	private const string ThreadIDField = "m_currentThread";
	internal const int MaxChunkSize = 8000;
	private const int IndexLimit = 1000000;
	private const int WidthLimit = 1000000;

	// Properties
	public int Capacity { get; set; }
	public int MaxCapacity { get; }
	public int Length { get; set; }
	public char Chars { get; set; }
	private Span<char> RemainingCurrentChunk { get; }

	// Methods

	// RVA: 0x1AC05C0 Offset: 0x1ABEFC0 VA: 0x181AC05C0
	public void .ctor() { }

	// RVA: 0x1AC0620 Offset: 0x1ABF020 VA: 0x181AC0620
	public void .ctor(int capacity) { }

	// RVA: 0x1AC0F70 Offset: 0x1ABF970 VA: 0x181AC0F70
	public void .ctor(string value) { }

	// RVA: 0x1AC0FB0 Offset: 0x1ABF9B0 VA: 0x181AC0FB0
	public void .ctor(string value, int capacity) { }

	// RVA: 0x1AC0820 Offset: 0x1ABF220 VA: 0x181AC0820
	public void .ctor(string value, int startIndex, int length, int capacity) { }

	// RVA: 0x1AC0630 Offset: 0x1ABF030 VA: 0x181AC0630
	public void .ctor(int capacity, int maxCapacity) { }

	// RVA: 0x1AC0B10 Offset: 0x1ABF510 VA: 0x181AC0B10
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1ABFE90 Offset: 0x1ABE890 VA: 0x181ABFE90 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AC0FF0 Offset: 0x1ABF9F0 VA: 0x181AC0FF0
	public int get_Capacity() { }

	// RVA: 0x1AC1190 Offset: 0x1ABFB90 VA: 0x181AC1190
	public void set_Capacity(int value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_MaxCapacity() { }

	// RVA: 0x1AC0470 Offset: 0x1ABEE70 VA: 0x181AC0470 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AC0230 Offset: 0x1ABEC30 VA: 0x181AC0230
	public string ToString(int startIndex, int length) { }

	// RVA: 0x1ABDD70 Offset: 0x1ABC770 VA: 0x181ABDD70
	public StringBuilder Clear() { }

	// RVA: 0x1AC10E0 Offset: 0x1ABFAE0 VA: 0x181AC10E0
	public int get_Length() { }

	// RVA: 0x1AC1480 Offset: 0x1ABFE80 VA: 0x181AC1480
	public void set_Length(int value) { }

	// RVA: 0x1AC1010 Offset: 0x1ABFA10 VA: 0x181AC1010
	public char get_Chars(int index) { }

	// RVA: 0x1AC1360 Offset: 0x1ABFD60 VA: 0x181AC1360
	public void set_Chars(int index, char value) { }

	// RVA: 0x1ABDA00 Offset: 0x1ABC400 VA: 0x181ABDA00
	public StringBuilder Append(char value, int repeatCount) { }

	// RVA: 0x1ABD740 Offset: 0x1ABC140 VA: 0x181ABD740
	public StringBuilder Append(char[] value, int startIndex, int charCount) { }

	// RVA: 0x1ABD1C0 Offset: 0x1ABBBC0 VA: 0x181ABD1C0
	public StringBuilder Append(string value) { }

	// RVA: 0x1ABD0C0 Offset: 0x1ABBAC0 VA: 0x181ABD0C0
	private void AppendHelper(string value) { }

	// RVA: 0x1ABDB80 Offset: 0x1ABC580 VA: 0x181ABDB80
	public StringBuilder Append(string value, int startIndex, int count) { }

	// RVA: 0x1ABD6C0 Offset: 0x1ABC0C0 VA: 0x181ABD6C0
	public StringBuilder Append(StringBuilder value) { }

	// RVA: 0x1ABC170 Offset: 0x1ABAB70 VA: 0x181ABC170
	private StringBuilder AppendCore(StringBuilder value, int startIndex, int count) { }

	// RVA: 0x1ABD110 Offset: 0x1ABBB10 VA: 0x181ABD110
	public StringBuilder AppendLine() { }

	// RVA: 0x1ABD140 Offset: 0x1ABBB40 VA: 0x181ABD140
	public StringBuilder AppendLine(string value) { }

	// RVA: 0x1ABDD90 Offset: 0x1ABC790 VA: 0x181ABDD90
	public void CopyTo(int sourceIndex, Span<char> destination, int count) { }

	// RVA: 0x1ABEF70 Offset: 0x1ABD970 VA: 0x181ABEF70
	public StringBuilder Remove(int startIndex, int length) { }

	// RVA: 0x1ABD920 Offset: 0x1ABC320 VA: 0x181ABD920
	public StringBuilder Append(bool value) { }

	// RVA: 0x1ABD600 Offset: 0x1ABC000 VA: 0x181ABD600
	public StringBuilder Append(char value) { }

	// RVA: 0x1ABD310 Offset: 0x1ABBD10 VA: 0x181ABD310
	public StringBuilder Append(byte value) { }

	// RVA: 0x1ABD2C0 Offset: 0x1ABBCC0 VA: 0x181ABD2C0
	public StringBuilder Append(int value) { }

	// RVA: 0x1ABD670 Offset: 0x1ABC070 VA: 0x181ABD670
	public StringBuilder Append(float value) { }

	// RVA: 0x1ABD170 Offset: 0x1ABBB70 VA: 0x181ABD170
	public StringBuilder Append(double value) { }

	[CLSCompliant(False)]
	// RVA: 0x1ABD5B0 Offset: 0x1ABBFB0 VA: 0x181ABD5B0
	public StringBuilder Append(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x1ABD560 Offset: 0x1ABBF60 VA: 0x181ABD560
	public StringBuilder Append(uint value) { }

	// RVA: -1 Offset: -1
	private StringBuilder AppendSpanFormattable<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF52EB0 Offset: 0xF518B0 VA: 0x180F52EB0
	|-StringBuilder.AppendSpanFormattable<byte>
	|
	|-RVA: 0xF52F40 Offset: 0xF51940 VA: 0x180F52F40
	|-StringBuilder.AppendSpanFormattable<double>
	|
	|-RVA: 0xF53100 Offset: 0xF51B00 VA: 0x180F53100
	|-StringBuilder.AppendSpanFormattable<int>
	|
	|-RVA: 0xF53190 Offset: 0xF51B90 VA: 0x180F53190
	|-StringBuilder.AppendSpanFormattable<float>
	|
	|-RVA: 0xF53220 Offset: 0xF51C20 VA: 0x180F53220
	|-StringBuilder.AppendSpanFormattable<ushort>
	|
	|-RVA: 0xF532B0 Offset: 0xF51CB0 VA: 0x180F532B0
	|-StringBuilder.AppendSpanFormattable<uint>
	|
	|-RVA: 0xF52FD0 Offset: 0xF519D0 VA: 0x180F52FD0
	|-StringBuilder.AppendSpanFormattable<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1ABD360 Offset: 0x1ABBD60 VA: 0x181ABD360
	public StringBuilder Append(object value) { }

	// RVA: 0x1ABD700 Offset: 0x1ABC100 VA: 0x181ABD700
	public StringBuilder Append(char[] value) { }

	// RVA: 0x1ABD980 Offset: 0x1ABC380 VA: 0x181ABD980
	public StringBuilder Append(ReadOnlySpan<char> value) { }

	// RVA: 0x1ABE9E0 Offset: 0x1ABD3E0 VA: 0x181ABE9E0
	public StringBuilder Insert(int index, string value) { }

	// RVA: 0x1ABE360 Offset: 0x1ABCD60 VA: 0x181ABE360
	public StringBuilder Insert(int index, char value) { }

	// RVA: 0x1ABD050 Offset: 0x1ABBA50 VA: 0x181ABD050
	public StringBuilder AppendFormat(string format, object arg0) { }

	// RVA: 0x1ABCFD0 Offset: 0x1ABB9D0 VA: 0x181ABCFD0
	public StringBuilder AppendFormat(string format, object arg0, object arg1) { }

	// RVA: 0x1ABCE30 Offset: 0x1ABB830 VA: 0x181ABCE30
	public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x1ABCD60 Offset: 0x1ABB760 VA: 0x181ABCD60
	public StringBuilder AppendFormat(string format, object[] args) { }

	// RVA: 0x1ABCF50 Offset: 0x1ABB950 VA: 0x181ABCF50
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x1ABCEC0 Offset: 0x1ABB8C0 VA: 0x181ABCEC0
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x1ABE310 Offset: 0x1ABCD10 VA: 0x181ABE310
	private static void FormatError() { }

	// RVA: 0x1ABC3D0 Offset: 0x1ABADD0 VA: 0x181ABC3D0
	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x1ABFD80 Offset: 0x1ABE780 VA: 0x181ABFD80
	public StringBuilder Replace(string oldValue, string newValue) { }

	// RVA: 0x1ABDFC0 Offset: 0x1ABC9C0 VA: 0x181ABDFC0
	public bool Equals(StringBuilder sb) { }

	// RVA: 0x1ABF860 Offset: 0x1ABE260 VA: 0x181ABF860
	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x1ABD3B0 Offset: 0x1ABBDB0 VA: 0x181ABD3B0
	public StringBuilder Append(char* value, int valueCount) { }

	// RVA: 0x1ABE390 Offset: 0x1ABCD90 VA: 0x181ABE390
	private void Insert(int index, char* value, int valueCount) { }

	// RVA: 0x1ABF470 Offset: 0x1ABDE70 VA: 0x181ABF470
	private void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value) { }

	// RVA: 0x1ABFDB0 Offset: 0x1ABE7B0 VA: 0x181ABFDB0
	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value) { }

	// RVA: 0x1ABF690 Offset: 0x1ABE090 VA: 0x181ABF690
	private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count) { }

	// RVA: 0x1ABFFC0 Offset: 0x1ABE9C0 VA: 0x181ABFFC0
	private static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x1AC0090 Offset: 0x1ABEA90 VA: 0x181AC0090
	private static void ThreadSafeCopy(char[] source, int sourceIndex, Span<char> destination, int destinationIndex, int count) { }

	// RVA: 0x1ABE2D0 Offset: 0x1ABCCD0 VA: 0x181ABE2D0
	private StringBuilder FindChunkForIndex(int index) { }

	// RVA: 0x1AC10F0 Offset: 0x1ABFAF0 VA: 0x181AC10F0
	private Span<char> get_RemainingCurrentChunk() { }

	// RVA: 0x1ABEF20 Offset: 0x1ABD920 VA: 0x181ABEF20
	private StringBuilder Next(StringBuilder chunk) { }

	// RVA: 0x1ABE0E0 Offset: 0x1ABCAE0 VA: 0x181ABE0E0
	private void ExpandByABlock(int minBlockCharCount) { }

	// RVA: 0x1AC0F00 Offset: 0x1ABF900 VA: 0x181AC0F00
	private void .ctor(StringBuilder from) { }

	// RVA: 0x1ABEAA0 Offset: 0x1ABD4A0 VA: 0x181ABEAA0
	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doNotMoveFollowingChars) { }

	// RVA: 0x1AC0E60 Offset: 0x1ABF860 VA: 0x181AC0E60
	private void .ctor(int size, int maxCapacity, StringBuilder previousBlock) { }

	// RVA: 0x1ABF290 Offset: 0x1ABDC90 VA: 0x181ABF290
	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk) { }
}
