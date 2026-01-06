public static class xxHash3 // TypeDefIndex: 15924
{
	// Fields
	private const int STRIPE_LEN = 64;
	private const int ACC_NB = 8;
	private const int SECRET_CONSUME_RATE = 8;
	private const int SECRET_KEY_SIZE = 192;
	private const int SECRET_KEY_MIN_SIZE = 136;
	private const int SECRET_LASTACC_START = 7;
	private const int NB_ROUNDS = 16;
	private const int BLOCK_LEN = 1024;
	private const uint PRIME32_1 = 2654435761;
	private const uint PRIME32_2 = 2246822519;
	private const uint PRIME32_3 = 3266489917;
	private const uint PRIME32_5 = 374761393;
	private const ulong PRIME64_1 = 11400714785074694791;
	private const ulong PRIME64_2 = 14029467366897019727;
	private const ulong PRIME64_3 = 1609587929392839161;
	private const ulong PRIME64_4 = 9650029242287828579;
	private const ulong PRIME64_5 = 2870177450012600261;
	private const int MIDSIZE_MAX = 240;
	private const int MIDSIZE_STARTOFFSET = 3;
	private const int MIDSIZE_LASTOFFSET = 17;
	private const int SECRET_MERGEACCS_START = 11;

	// Methods

	// RVA: 0x2743B40 Offset: 0x2742540 VA: 0x182743B40
	internal static void Avx2HashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64) { }

	// RVA: 0x2743DE0 Offset: 0x27427E0 VA: 0x182743DE0
	internal static void Avx2ScrambleAcc(ulong* acc, byte* secret) { }

	// RVA: 0x2743A40 Offset: 0x2742440 VA: 0x182743A40
	internal static void Avx2Accumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64) { }

	// RVA: 0x2743650 Offset: 0x2742050 VA: 0x182743650
	internal static void Avx2Accumulate512(ulong* acc, byte* input, byte* dest, byte* secret) { }

	// RVA: 0x2746BA0 Offset: 0x27455A0 VA: 0x182746BA0
	public static uint2 Hash64(void* input, long length) { }

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static uint2 Hash64<T>(in T input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF876F0 Offset: 0xF860F0 VA: 0x180F876F0
	|-xxHash3.Hash64<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2746AE0 Offset: 0x27454E0 VA: 0x182746AE0
	public static uint2 Hash64(void* input, long length, ulong seed) { }

	// RVA: 0x2745D70 Offset: 0x2744770 VA: 0x182745D70
	public static uint4 Hash128(void* input, long length) { }

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static uint4 Hash128<T>(in T input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF87670 Offset: 0xF86070 VA: 0x180F87670
	|-xxHash3.Hash128<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2745BE0 Offset: 0x27445E0 VA: 0x182745BE0
	public static uint4 Hash128(void* input, void* destination, long length) { }

	// RVA: 0x2745B20 Offset: 0x2744520 VA: 0x182745B20
	public static uint4 Hash128(void* input, long length, ulong seed) { }

	// RVA: 0x2745CA0 Offset: 0x27446A0 VA: 0x182745CA0
	public static uint4 Hash128(void* input, void* destination, long length, ulong seed) { }

	// RVA: 0x2745E20 Offset: 0x2744820 VA: 0x182745E20
	internal static ulong Hash64Internal(byte* input, byte* dest, long length, byte* secret, ulong seed) { }

	// RVA: 0x27449F0 Offset: 0x27433F0 VA: 0x1827449F0
	internal static void Hash128Internal(byte* input, byte* dest, long length, byte* secret, ulong seed, out uint4 result) { }

	// RVA: 0x2746780 Offset: 0x2745180 VA: 0x182746780
	private static ulong Hash64Len1To3(byte* input, long len, byte* secret, ulong seed) { }

	// RVA: 0x2746800 Offset: 0x2745200 VA: 0x182746800
	private static ulong Hash64Len4To8(byte* input, long length, byte* secret, ulong seed) { }

	// RVA: 0x2746890 Offset: 0x2745290 VA: 0x182746890
	private static ulong Hash64Len9To16(byte* input, long length, byte* secret, ulong seed) { }

	// RVA: 0x2746200 Offset: 0x2744C00 VA: 0x182746200
	private static ulong Hash64Len0To16(byte* input, long length, byte* secret, ulong seed) { }

	// RVA: 0x2746570 Offset: 0x2744F70 VA: 0x182746570
	private static ulong Hash64Len17To128(byte* input, long length, byte* secret, ulong seed) { }

	// RVA: 0x27463E0 Offset: 0x2744DE0 VA: 0x1827463E0
	private static ulong Hash64Len129To240(byte* input, long length, byte* secret, ulong seed) { }

	[BurstCompile]
	// RVA: 0x2746A60 Offset: 0x2745460 VA: 0x182746A60
	private static ulong Hash64Long(byte* input, byte* dest, long length, byte* secret) { }

	// RVA: 0x2745610 Offset: 0x2744010 VA: 0x182745610
	private static void Hash128Len1To3(byte* input, long length, byte* secret, ulong seed, out uint4 result) { }

	// RVA: 0x2745710 Offset: 0x2744110 VA: 0x182745710
	private static void Hash128Len4To8(byte* input, long len, byte* secret, ulong seed, out uint4 result) { }

	// RVA: 0x27457F0 Offset: 0x27441F0 VA: 0x1827457F0
	private static void Hash128Len9To16(byte* input, long len, byte* secret, ulong seed, out uint4 result) { }

	// RVA: 0x2744B90 Offset: 0x2743590 VA: 0x182744B90
	private static void Hash128Len0To16(byte* input, long length, byte* secret, ulong seed, out uint4 result) { }

	// RVA: 0x27452D0 Offset: 0x2743CD0 VA: 0x1827452D0
	private static void Hash128Len17To128(byte* input, long length, byte* secret, ulong seed, out uint4 result) { }

	// RVA: 0x2744ED0 Offset: 0x27438D0 VA: 0x182744ED0
	private static void Hash128Len129To240(byte* input, long length, byte* secret, ulong seed, out uint4 result) { }

	[BurstCompile]
	// RVA: 0x2745AA0 Offset: 0x27444A0 VA: 0x182745AA0
	private static void Hash128Long(byte* input, byte* dest, long length, byte* secret, out uint4 result) { }

	// RVA: 0x2746F10 Offset: 0x2745910 VA: 0x182746F10
	internal static uint2 ToUint2(ulong u) { }

	// RVA: 0x2746F30 Offset: 0x2745930 VA: 0x182746F30
	internal static uint4 ToUint4(ulong ul0, ulong ul1) { }

	// RVA: 0x27449B0 Offset: 0x27433B0 VA: 0x1827449B0
	internal static void EncodeSecretKey(byte* dst, byte* secret, ulong seed) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	private static ulong Read64LE(void* addr) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	private static uint Read32LE(void* addr) { }

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	private static void Write64LE(void* addr, ulong value) { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	private static void Read32LE(void* addr, uint value) { }

	// RVA: 0x1C6D990 Offset: 0x1C6C390 VA: 0x181C6D990
	private static ulong Mul32To64(uint x, uint y) { }

	// RVA: 0xBBE090 Offset: 0xBBCA90 VA: 0x180BBE090
	private static ulong Swap64(ulong x) { }

	// RVA: 0xD15280 Offset: 0xD13C80 VA: 0x180D15280
	private static uint Swap32(uint x) { }

	// RVA: 0x1C63F50 Offset: 0x1C62950 VA: 0x181C63F50
	private static uint RotL32(uint x, int r) { }

	// RVA: 0x2746EF0 Offset: 0x27458F0 VA: 0x182746EF0
	private static ulong RotL64(ulong x, int r) { }

	// RVA: 0x2746F50 Offset: 0x2745950 VA: 0x182746F50
	private static ulong XorShift64(ulong v64, int shift) { }

	// RVA: 0x2746EC0 Offset: 0x27458C0 VA: 0x182746EC0
	private static ulong Mul128Fold64(ulong lhs, ulong rhs) { }

	// RVA: 0x2746D60 Offset: 0x2745760 VA: 0x182746D60
	private static ulong Mix16(byte* input, byte* secret, ulong seed) { }

	// RVA: 0x2746DD0 Offset: 0x27457D0 VA: 0x182746DD0
	private static xxHash3.ulong2 Mix32(xxHash3.ulong2 acc, byte* input_1, byte* input_2, byte* secret, ulong seed) { }

	// RVA: 0x2743620 Offset: 0x2742020 VA: 0x182743620
	private static ulong Avalanche(ulong h64) { }

	// RVA: 0x27435E0 Offset: 0x2741FE0 VA: 0x1827435E0
	private static ulong AvalancheH64(ulong h64) { }

	// RVA: 0x2746F70 Offset: 0x2745970 VA: 0x182746F70
	private static ulong rrmxmx(ulong h64, ulong length) { }

	// RVA: 0x2746DA0 Offset: 0x27457A0 VA: 0x182746DA0
	private static ulong Mix2Acc(ulong acc0, ulong acc1, byte* secret) { }

	// RVA: 0x2746C50 Offset: 0x2745650 VA: 0x182746C50
	internal static ulong MergeAcc(ulong* acc, byte* secret, ulong start) { }

	// RVA: 0x27445D0 Offset: 0x2742FD0 VA: 0x1827445D0
	private static void DefaultHashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64) { }

	// RVA: 0x27443F0 Offset: 0x2742DF0 VA: 0x1827443F0
	internal static void DefaultAccumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64) { }

	// RVA: 0x2744290 Offset: 0x2742C90 VA: 0x182744290
	internal static void DefaultAccumulate512(ulong* acc, byte* input, byte* dest, byte* secret, int isHash64) { }

	// RVA: 0x27448D0 Offset: 0x27432D0 VA: 0x1827448D0
	internal static void DefaultScrambleAcc(ulong* acc, byte* secret) { }

	[BurstCompile]
	// RVA: 0x2746920 Offset: 0x2745320 VA: 0x182746920
	public static ulong Hash64Long$BurstManaged(byte* input, byte* dest, long length, byte* secret) { }

	[BurstCompile]
	// RVA: 0x2745920 Offset: 0x2744320 VA: 0x182745920
	public static void Hash128Long$BurstManaged(byte* input, byte* dest, long length, byte* secret, out uint4 result) { }
}
