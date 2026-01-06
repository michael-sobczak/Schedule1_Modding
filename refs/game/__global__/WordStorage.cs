public struct WordStorage // TypeDefIndex: 15941
{
	// Fields
	private NativeArray<byte> buffer; // 0x0
	private NativeArray<WordStorage.Entry> entry; // 0x10
	private NativeParallelMultiHashMap<int, int> hash; // 0x20
	private int chars; // 0x30
	private int entries; // 0x34
	private const int kMaxEntries = 16384;
	private const int kMaxChars = 2097152;
	public const int kMaxCharsPerEntry = 4096;

	// Properties
	[NotBurstCompatible]
	public static WordStorage Instance { get; }
	public int Entries { get; }

	// Methods

	// RVA: 0x27431D0 Offset: 0x2741BD0 VA: 0x1827431D0
	public static ref WordStorage get_Instance() { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public int get_Entries() { }

	[NotBurstCompatible]
	// RVA: 0x2742D70 Offset: 0x2741770 VA: 0x182742D70
	public static void Initialize() { }

	[NotBurstCompatible]
	// RVA: 0x27430C0 Offset: 0x2741AC0 VA: 0x1827430C0
	public static void Shutdown() { }

	[NotBurstCompatible]
	// RVA: 0x2742BC0 Offset: 0x27415C0 VA: 0x182742BC0
	public static void Clear() { }

	[NotBurstCompatible]
	// RVA: 0x27430B0 Offset: 0x2741AB0 VA: 0x1827430B0
	public static void Setup() { }

	// RVA: -1 Offset: -1
	public void GetFixedString<T>(int index, ref T temp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF77950 Offset: 0xF76350 VA: 0x180F77950
	|-WordStorage.GetFixedString<FixedString128Bytes>
	|-WordStorage.GetFixedString<FixedString512Bytes>
	|
	|-RVA: 0xF77A00 Offset: 0xF76400 VA: 0x180F77A00
	|-WordStorage.GetFixedString<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public int GetIndexFromHashAndFixedString<T>(int h, ref T temp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF77C40 Offset: 0xF76640 VA: 0x180F77C40
	|-WordStorage.GetIndexFromHashAndFixedString<FixedString32Bytes>
	|-WordStorage.GetIndexFromHashAndFixedString<FixedString512Bytes>
	|
	|-RVA: 0xF77D80 Offset: 0xF76780 VA: 0x180F77D80
	|-WordStorage.GetIndexFromHashAndFixedString<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool Contains<T>(ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF777F0 Offset: 0xF761F0 VA: 0x180F777F0
	|-WordStorage.Contains<FixedString512Bytes>
	|
	|-RVA: 0xF77860 Offset: 0xF76260 VA: 0x180F77860
	|-WordStorage.Contains<__Il2CppFullySharedGenericType>
	*/

	[NotBurstCompatible]
	// RVA: 0x2742C90 Offset: 0x2741690 VA: 0x182742C90
	public bool Contains(string value) { }

	// RVA: -1 Offset: -1
	public int GetOrCreateIndex<T>(ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF78070 Offset: 0xF76A70 VA: 0x180F78070
	|-WordStorage.GetOrCreateIndex<FixedString32Bytes>
	|
	|-RVA: 0xF78190 Offset: 0xF76B90 VA: 0x180F78190
	|-WordStorage.GetOrCreateIndex<FixedString512Bytes>
	|
	|-RVA: 0xF782B0 Offset: 0xF76CB0 VA: 0x180F782B0
	|-WordStorage.GetOrCreateIndex<__Il2CppFullySharedGenericType>
	*/
}
