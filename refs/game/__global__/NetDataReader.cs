public class NetDataReader // TypeDefIndex: 12431
{
	// Fields
	protected byte[] _data; // 0x10
	protected int _position; // 0x18
	protected int _dataSize; // 0x1C
	private int _offset; // 0x20
	private static readonly UTF8Encoding _uTF8Encoding; // 0x0

	// Properties
	public byte[] RawData { get; }
	public int RawDataSize { get; }
	public int UserDataOffset { get; }
	public int UserDataSize { get; }
	public bool IsNull { get; }
	public int Position { get; }
	public bool EndOfData { get; }
	public int AvailableBytes { get; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public byte[] get_RawData() { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_RawDataSize() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_UserDataOffset() { }

	// RVA: 0xCF72B0 Offset: 0xCF5CB0 VA: 0x180CF72B0
	public int get_UserDataSize() { }

	// RVA: 0xB2C8B0 Offset: 0xB2B2B0 VA: 0x180B2C8B0
	public bool get_IsNull() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_Position() { }

	// RVA: 0xCF72A0 Offset: 0xCF5CA0 VA: 0x180CF72A0
	public bool get_EndOfData() { }

	// RVA: 0xCF7290 Offset: 0xCF5C90 VA: 0x180CF7290
	public int get_AvailableBytes() { }

	// RVA: 0xCF6B70 Offset: 0xCF5570 VA: 0x180CF6B70
	public void SkipBytes(int count) { }

	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	public void SetPosition(int position) { }

	// RVA: 0xCF6B20 Offset: 0xCF5520 VA: 0x180CF6B20
	public void SetSource(NetDataWriter dataWriter) { }

	// RVA: 0xCF6AD0 Offset: 0xCF54D0 VA: 0x180CF6AD0
	public void SetSource(byte[] source) { }

	// RVA: 0xCF6A90 Offset: 0xCF5490 VA: 0x180CF6A90
	public void SetSource(byte[] source, int offset, int maxSize) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0xCF7240 Offset: 0xCF5C40 VA: 0x180CF7240
	public void .ctor(NetDataWriter writer) { }

	// RVA: 0xCF7190 Offset: 0xCF5B90 VA: 0x180CF7190
	public void .ctor(byte[] source) { }

	// RVA: 0xCF71E0 Offset: 0xCF5BE0 VA: 0x180CF71E0
	public void .ctor(byte[] source, int offset, int maxSize) { }

	// RVA: 0xCF5DE0 Offset: 0xCF47E0 VA: 0x180CF5DE0
	public IPEndPoint GetNetEndPoint() { }

	// RVA: 0xCF58B0 Offset: 0xCF42B0 VA: 0x180CF58B0
	public byte GetByte() { }

	// RVA: 0xCF58B0 Offset: 0xCF42B0 VA: 0x180CF58B0
	public sbyte GetSByte() { }

	// RVA: 0xCF57E0 Offset: 0xCF41E0 VA: 0x180CF57E0
	public bool[] GetBoolArray() { }

	// RVA: 0xCF6710 Offset: 0xCF5110 VA: 0x180CF6710
	public ushort[] GetUShortArray() { }

	// RVA: 0xCF6010 Offset: 0xCF4A10 VA: 0x180CF6010
	public short[] GetShortArray() { }

	// RVA: 0xCF5D10 Offset: 0xCF4710 VA: 0x180CF5D10
	public long[] GetLongArray() { }

	// RVA: 0xCF6670 Offset: 0xCF5070 VA: 0x180CF6670
	public ulong[] GetULongArray() { }

	// RVA: 0xCF5C40 Offset: 0xCF4640 VA: 0x180CF5C40
	public int[] GetIntArray() { }

	// RVA: 0xCF65D0 Offset: 0xCF4FD0 VA: 0x180CF65D0
	public uint[] GetUIntArray() { }

	// RVA: 0xCF5B70 Offset: 0xCF4570 VA: 0x180CF5B70
	public float[] GetFloatArray() { }

	// RVA: 0xCF5AA0 Offset: 0xCF44A0 VA: 0x180CF5AA0
	public double[] GetDoubleArray() { }

	// RVA: 0xCF6180 Offset: 0xCF4B80 VA: 0x180CF6180
	public string[] GetStringArray() { }

	// RVA: 0xCF60B0 Offset: 0xCF4AB0 VA: 0x180CF60B0
	public string[] GetStringArray(int maxStringLength) { }

	// RVA: 0xCF5870 Offset: 0xCF4270 VA: 0x180CF5870
	public bool GetBool() { }

	// RVA: 0xCF5A70 Offset: 0xCF4470 VA: 0x180CF5A70
	public char GetChar() { }

	// RVA: 0xCF5A70 Offset: 0xCF4470 VA: 0x180CF5A70
	public ushort GetUShort() { }

	// RVA: 0xCF5A70 Offset: 0xCF4470 VA: 0x180CF5A70
	public short GetShort() { }

	// RVA: 0xCF5DB0 Offset: 0xCF47B0 VA: 0x180CF5DB0
	public long GetLong() { }

	// RVA: 0xCF5DB0 Offset: 0xCF47B0 VA: 0x180CF5DB0
	public ulong GetULong() { }

	// RVA: 0xCF5CE0 Offset: 0xCF46E0 VA: 0x180CF5CE0
	public int GetInt() { }

	// RVA: 0xCF5CE0 Offset: 0xCF46E0 VA: 0x180CF5CE0
	public uint GetUInt() { }

	// RVA: 0xCF5C10 Offset: 0xCF4610 VA: 0x180CF5C10
	public float GetFloat() { }

	// RVA: 0xCF5B40 Offset: 0xCF4540 VA: 0x180CF5B40
	public double GetDouble() { }

	// RVA: 0xCF6250 Offset: 0xCF4C50 VA: 0x180CF6250
	public string GetString(int maxLength) { }

	// RVA: 0xCF6470 Offset: 0xCF4E70 VA: 0x180CF6470
	public string GetString() { }

	// RVA: 0xCF58F0 Offset: 0xCF42F0 VA: 0x180CF58F0
	public ArraySegment<byte> GetBytesSegment(int count) { }

	// RVA: 0xCF5E70 Offset: 0xCF4870 VA: 0x180CF5E70
	public ArraySegment<byte> GetRemainingBytesSegment() { }

	// RVA: -1 Offset: -1
	public T Get<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0E330 Offset: 0xF0CD30 VA: 0x180F0E330
	|-NetDataReader.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0xCF5EF0 Offset: 0xCF48F0 VA: 0x180CF5EF0
	public byte[] GetRemainingBytes() { }

	// RVA: 0xCF5A30 Offset: 0xCF4430 VA: 0x180CF5A30
	public void GetBytes(byte[] destination, int start, int count) { }

	// RVA: 0xCF59F0 Offset: 0xCF43F0 VA: 0x180CF59F0
	public void GetBytes(byte[] destination, int count) { }

	// RVA: 0xCF5F80 Offset: 0xCF4980 VA: 0x180CF5F80
	public sbyte[] GetSBytesWithLength() { }

	// RVA: 0xCF5960 Offset: 0xCF4360 VA: 0x180CF5960
	public byte[] GetBytesWithLength() { }

	// RVA: 0xCF67E0 Offset: 0xCF51E0 VA: 0x180CF67E0
	public byte PeekByte() { }

	// RVA: 0xCF67E0 Offset: 0xCF51E0 VA: 0x180CF67E0
	public sbyte PeekSByte() { }

	// RVA: 0xCF67B0 Offset: 0xCF51B0 VA: 0x180CF67B0
	public bool PeekBool() { }

	// RVA: 0xCF6810 Offset: 0xCF5210 VA: 0x180CF6810
	public char PeekChar() { }

	// RVA: 0xCF6810 Offset: 0xCF5210 VA: 0x180CF6810
	public ushort PeekUShort() { }

	// RVA: 0xCF6810 Offset: 0xCF5210 VA: 0x180CF6810
	public short PeekShort() { }

	// RVA: 0xCF6850 Offset: 0xCF5250 VA: 0x180CF6850
	public long PeekLong() { }

	// RVA: 0xCF6850 Offset: 0xCF5250 VA: 0x180CF6850
	public ulong PeekULong() { }

	// RVA: 0xCF6840 Offset: 0xCF5240 VA: 0x180CF6840
	public int PeekInt() { }

	// RVA: 0xCF6840 Offset: 0xCF5240 VA: 0x180CF6840
	public uint PeekUInt() { }

	// RVA: 0xCF6830 Offset: 0xCF5230 VA: 0x180CF6830
	public float PeekFloat() { }

	// RVA: 0xCF6820 Offset: 0xCF5220 VA: 0x180CF6820
	public double PeekDouble() { }

	// RVA: 0xCF6920 Offset: 0xCF5320 VA: 0x180CF6920
	public string PeekString(int maxLength) { }

	// RVA: 0xCF6860 Offset: 0xCF5260 VA: 0x180CF6860
	public string PeekString() { }

	// RVA: 0xCF6BE0 Offset: 0xCF55E0 VA: 0x180CF6BE0
	public bool TryGetByte(out byte result) { }

	// RVA: 0xCF6BE0 Offset: 0xCF55E0 VA: 0x180CF6BE0
	public bool TryGetSByte(out sbyte result) { }

	// RVA: 0xCF6B80 Offset: 0xCF5580 VA: 0x180CF6B80
	public bool TryGetBool(out bool result) { }

	// RVA: 0xCF6D30 Offset: 0xCF5730 VA: 0x180CF6D30
	public bool TryGetChar(out char result) { }

	// RVA: 0xCF6EF0 Offset: 0xCF58F0 VA: 0x180CF6EF0
	public bool TryGetShort(out short result) { }

	// RVA: 0xCF6EF0 Offset: 0xCF58F0 VA: 0x180CF6EF0
	public bool TryGetUShort(out ushort result) { }

	// RVA: 0xCF6E40 Offset: 0xCF5840 VA: 0x180CF6E40
	public bool TryGetInt(out int result) { }

	// RVA: 0xCF6E40 Offset: 0xCF5840 VA: 0x180CF6E40
	public bool TryGetUInt(out uint result) { }

	// RVA: 0xCF6E90 Offset: 0xCF5890 VA: 0x180CF6E90
	public bool TryGetLong(out long result) { }

	// RVA: 0xCF6E90 Offset: 0xCF5890 VA: 0x180CF6E90
	public bool TryGetULong(out ulong result) { }

	// RVA: 0xCF6DE0 Offset: 0xCF57E0 VA: 0x180CF6DE0
	public bool TryGetFloat(out float result) { }

	// RVA: 0xCF6D80 Offset: 0xCF5780 VA: 0x180CF6D80
	public bool TryGetDouble(out double result) { }

	// RVA: 0xCF7090 Offset: 0xCF5A90 VA: 0x180CF7090
	public bool TryGetString(out string result) { }

	// RVA: 0xCF6F40 Offset: 0xCF5940 VA: 0x180CF6F40
	public bool TryGetStringArray(out string[] result) { }

	// RVA: 0xCF6C30 Offset: 0xCF5630 VA: 0x180CF6C30
	public bool TryGetBytesWithLength(out byte[] result) { }

	// RVA: 0xCF57C0 Offset: 0xCF41C0 VA: 0x180CF57C0
	public void Clear() { }

	// RVA: 0xCF7110 Offset: 0xCF5B10 VA: 0x180CF7110
	private static void .cctor() { }
}
