public class NetDataWriter // TypeDefIndex: 12432
{
	// Fields
	protected byte[] _data; // 0x10
	protected int _position; // 0x18
	private const int InitialSize = 64;
	private readonly bool _autoResize; // 0x1C
	private static readonly UTF8Encoding _uTF8Encoding; // 0x0
	public const int StringBufferMaxLength = 32768;
	private readonly byte[] _stringBuffer; // 0x20

	// Properties
	public int Capacity { get; }
	public byte[] Data { get; }
	public int Length { get; }

	// Methods

	// RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	public int get_Capacity() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public byte[] get_Data() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_Length() { }

	// RVA: 0xD142D0 Offset: 0xD12CD0 VA: 0x180D142D0
	public void .ctor() { }

	// RVA: 0xD142C0 Offset: 0xD12CC0 VA: 0x180D142C0
	public void .ctor(bool autoResize) { }

	// RVA: 0xD14220 Offset: 0xD12C20 VA: 0x180D14220
	public void .ctor(bool autoResize, int initialSize) { }

	// RVA: 0xD12FD0 Offset: 0xD119D0 VA: 0x180D12FD0
	public static NetDataWriter FromBytes(byte[] bytes, bool copy) { }

	// RVA: 0xD130E0 Offset: 0xD11AE0 VA: 0x180D130E0
	public static NetDataWriter FromBytes(byte[] bytes, int offset, int length) { }

	// RVA: 0xD131A0 Offset: 0xD11BA0 VA: 0x180D131A0
	public static NetDataWriter FromString(string value) { }

	// RVA: 0xD140F0 Offset: 0xD12AF0 VA: 0x180D140F0
	public void ResizeIfNeed(int newSize) { }

	// RVA: 0xD12F20 Offset: 0xD11920 VA: 0x180D12F20
	public void EnsureFit(int additionalSize) { }

	// RVA: 0xD140D0 Offset: 0xD12AD0 VA: 0x180D140D0
	public void Reset(int size) { }

	// RVA: 0xBCB890 Offset: 0xBCA290 VA: 0x180BCB890
	public void Reset() { }

	// RVA: 0xD12EB0 Offset: 0xD118B0 VA: 0x180D12EB0
	public byte[] CopyData() { }

	// RVA: 0xD14190 Offset: 0xD12B90 VA: 0x180D14190
	public int SetPosition(int position) { }

	// RVA: 0xD13DB0 Offset: 0xD127B0 VA: 0x180D13DB0
	public void Put(float value) { }

	// RVA: 0xD13CF0 Offset: 0xD126F0 VA: 0x180D13CF0
	public void Put(double value) { }

	// RVA: 0xD13AF0 Offset: 0xD124F0 VA: 0x180D13AF0
	public void Put(long value) { }

	// RVA: 0xD13AF0 Offset: 0xD124F0 VA: 0x180D13AF0
	public void Put(ulong value) { }

	// RVA: 0xD13A00 Offset: 0xD12400 VA: 0x180D13A00
	public void Put(int value) { }

	// RVA: 0xD13A00 Offset: 0xD12400 VA: 0x180D13A00
	public void Put(uint value) { }

	// RVA: 0xD13BB0 Offset: 0xD125B0 VA: 0x180D13BB0
	public void Put(char value) { }

	// RVA: 0xD13BB0 Offset: 0xD125B0 VA: 0x180D13BB0
	public void Put(ushort value) { }

	// RVA: 0xD13BB0 Offset: 0xD125B0 VA: 0x180D13BB0
	public void Put(short value) { }

	// RVA: 0xD13A90 Offset: 0xD12490 VA: 0x180D13A90
	public void Put(sbyte value) { }

	// RVA: 0xD13A90 Offset: 0xD12490 VA: 0x180D13A90
	public void Put(byte value) { }

	// RVA: 0xD14060 Offset: 0xD12A60 VA: 0x180D14060
	public void Put(byte[] data, int offset, int length) { }

	// RVA: 0xD13B40 Offset: 0xD12540 VA: 0x180D13B40
	public void Put(byte[] data) { }

	// RVA: 0xD13910 Offset: 0xD12310 VA: 0x180D13910
	public void PutSBytesWithLength(sbyte[] data, int offset, int length) { }

	// RVA: 0xD13830 Offset: 0xD12230 VA: 0x180D13830
	public void PutSBytesWithLength(sbyte[] data) { }

	// RVA: 0xD13910 Offset: 0xD12310 VA: 0x180D13910
	public void PutBytesWithLength(byte[] data, int offset, int length) { }

	// RVA: 0xD13830 Offset: 0xD12230 VA: 0x180D13830
	public void PutBytesWithLength(byte[] data) { }

	// RVA: 0xD13D40 Offset: 0xD12740 VA: 0x180D13D40
	public void Put(bool value) { }

	// RVA: 0xD13750 Offset: 0xD12150 VA: 0x180D13750
	private void PutArray(Array arr, int sz) { }

	// RVA: 0xD13220 Offset: 0xD11C20 VA: 0x180D13220
	public void PutArray(float[] value) { }

	// RVA: 0xD13670 Offset: 0xD12070 VA: 0x180D13670
	public void PutArray(double[] value) { }

	// RVA: 0xD13670 Offset: 0xD12070 VA: 0x180D13670
	public void PutArray(long[] value) { }

	// RVA: 0xD13670 Offset: 0xD12070 VA: 0x180D13670
	public void PutArray(ulong[] value) { }

	// RVA: 0xD13220 Offset: 0xD11C20 VA: 0x180D13220
	public void PutArray(int[] value) { }

	// RVA: 0xD13220 Offset: 0xD11C20 VA: 0x180D13220
	public void PutArray(uint[] value) { }

	// RVA: 0xD133D0 Offset: 0xD11DD0 VA: 0x180D133D0
	public void PutArray(ushort[] value) { }

	// RVA: 0xD133D0 Offset: 0xD11DD0 VA: 0x180D133D0
	public void PutArray(short[] value) { }

	// RVA: 0xD134B0 Offset: 0xD11EB0 VA: 0x180D134B0
	public void PutArray(bool[] value) { }

	// RVA: 0xD13300 Offset: 0xD11D00 VA: 0x180D13300
	public void PutArray(string[] value) { }

	// RVA: 0xD13590 Offset: 0xD11F90 VA: 0x180D13590
	public void PutArray(string[] value, int strMaxLength) { }

	// RVA: 0xD13C20 Offset: 0xD12620 VA: 0x180D13C20
	public void Put(IPEndPoint endPoint) { }

	// RVA: 0xD13DA0 Offset: 0xD127A0 VA: 0x180D13DA0
	public void Put(string value) { }

	// RVA: 0xD13E50 Offset: 0xD12850 VA: 0x180D13E50
	public void Put(string value, int maxLength) { }

	// RVA: -1 Offset: -1
	public void Put<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0E4D0 Offset: 0xF0CED0 VA: 0x180F0E4D0
	|-NetDataWriter.Put<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0xD141A0 Offset: 0xD12BA0 VA: 0x180D141A0
	private static void .cctor() { }
}
