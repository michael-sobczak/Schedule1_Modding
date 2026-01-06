internal class BZip2Compressor // TypeDefIndex: 16634
{
	// Fields
	private int blockSize100k; // 0x10
	private int currentByte; // 0x14
	private int runLength; // 0x18
	private int last; // 0x1C
	private int outBlockFillThreshold; // 0x20
	private BZip2Compressor.CompressionState cstate; // 0x28
	private readonly CRC32 crc; // 0x30
	private BitWriter bw; // 0x38
	private int runs; // 0x40
	private int workDone; // 0x44
	private int workLimit; // 0x48
	private bool firstAttempt; // 0x4C
	private bool blockRandomised; // 0x4D
	private int origPtr; // 0x50
	private int nInUse; // 0x54
	private int nMTF; // 0x58
	private static readonly int SETMASK; // 0x0
	private static readonly int CLEARMASK; // 0x4
	private static readonly byte GREATER_ICOST; // 0x8
	private static readonly byte LESSER_ICOST; // 0x9
	private static readonly int SMALL_THRESH; // 0xC
	private static readonly int DEPTH_THRESH; // 0x10
	private static readonly int WORK_FACTOR; // 0x14
	private static readonly int[] increments; // 0x18
	[CompilerGenerated]
	private uint <Crc32>k__BackingField; // 0x5C
	[CompilerGenerated]
	private int <AvailableBytesOut>k__BackingField; // 0x60

	// Properties
	public int BlockSize { get; }
	public uint Crc32 { get; set; }
	public int AvailableBytesOut { get; set; }
	public int UncompressedBytes { get; }

	// Methods

	// RVA: 0x1E45330 Offset: 0x1E43D30 VA: 0x181E45330
	public void .ctor(BitWriter writer) { }

	// RVA: 0x1E454F0 Offset: 0x1E43EF0 VA: 0x181E454F0
	public void .ctor(BitWriter writer, int blockSize) { }

	// RVA: 0x1E45210 Offset: 0x1E43C10 VA: 0x181E45210
	private static void .cctor() { }

	// RVA: 0x1E451A0 Offset: 0x1E43BA0 VA: 0x181E451A0
	private void Reset() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_BlockSize() { }

	[CompilerGenerated]
	// RVA: 0x54CEC0 Offset: 0x54B8C0 VA: 0x18054CEC0
	public uint get_Crc32() { }

	[CompilerGenerated]
	// RVA: 0x8E6930 Offset: 0x8E5330 VA: 0x1808E6930
	private void set_Crc32(uint value) { }

	[CompilerGenerated]
	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	public int get_AvailableBytesOut() { }

	[CompilerGenerated]
	// RVA: 0x4E2900 Offset: 0x4E1300 VA: 0x1804E2900
	private void set_AvailableBytesOut(int value) { }

	// RVA: 0x1E45DF0 Offset: 0x1E447F0 VA: 0x181E45DF0
	public int get_UncompressedBytes() { }

	// RVA: 0x1E45070 Offset: 0x1E43A70 VA: 0x181E45070
	public int Fill(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E49B80 Offset: 0x1E48580 VA: 0x181E49B80
	private int write0(byte b) { }

	// RVA: 0x1E44C50 Offset: 0x1E43650 VA: 0x181E44C50
	private bool AddRunToOutputBlock(bool final) { }

	// RVA: 0x1E44F10 Offset: 0x1E43910 VA: 0x181E44F10
	public void CompressAndWrite() { }

	// RVA: 0x1E47FF0 Offset: 0x1E469F0 VA: 0x181E47FF0
	private void randomiseBlock() { }

	// RVA: 0x1E47450 Offset: 0x1E45E50 VA: 0x181E47450
	private void mainSort() { }

	// RVA: 0x1E45670 Offset: 0x1E44070 VA: 0x181E45670
	private void blockSort() { }

	// RVA: 0x1E46CB0 Offset: 0x1E456B0 VA: 0x181E46CB0
	private bool mainSimpleSort(BZip2Compressor.CompressionState dataShadow, int lo, int hi, int d) { }

	// RVA: 0x1E49AC0 Offset: 0x1E484C0 VA: 0x181E49AC0
	private static void vswap(int[] fmap, int p1, int p2, int n) { }

	// RVA: 0x1E47F70 Offset: 0x1E46970 VA: 0x181E47F70
	private static byte med3(byte a, byte b, byte c) { }

	// RVA: 0x1E46520 Offset: 0x1E44F20 VA: 0x181E46520
	private void mainQSort3(BZip2Compressor.CompressionState dataShadow, int loSt, int hiSt, int dSt) { }

	// RVA: 0x1E458C0 Offset: 0x1E442C0 VA: 0x181E458C0
	private void generateMTFValues() { }

	// RVA: 0x1E45E00 Offset: 0x1E44800 VA: 0x181E45E00
	private static void hbAssignCodes(int[] code, byte[] length, int minLen, int maxLen, int alphaSize) { }

	// RVA: 0x1E496F0 Offset: 0x1E480F0 VA: 0x181E496F0
	private void sendMTFValues() { }

	// RVA: 0x1E48150 Offset: 0x1E46B50 VA: 0x181E48150
	private void sendMTFValues0(int nGroups, int alphaSize) { }

	// RVA: 0x1E45E90 Offset: 0x1E44890 VA: 0x181E45E90
	private static void hbMakeCodeLengths(byte[] len, int[] freq, BZip2Compressor.CompressionState state1, int alphaSize, int maxLen) { }

	// RVA: 0x1E483E0 Offset: 0x1E46DE0 VA: 0x181E483E0
	private int sendMTFValues1(int nGroups, int alphaSize) { }

	// RVA: 0x1E48CD0 Offset: 0x1E476D0 VA: 0x181E48CD0
	private void sendMTFValues2(int nGroups, int nSelectors) { }

	// RVA: 0x1E48DD0 Offset: 0x1E477D0 VA: 0x181E48DD0
	private void sendMTFValues3(int nGroups, int alphaSize) { }

	// RVA: 0x1E49000 Offset: 0x1E47A00 VA: 0x181E49000
	private void sendMTFValues4() { }

	// RVA: 0x1E491B0 Offset: 0x1E47BB0 VA: 0x181E491B0
	private void sendMTFValues5(int nGroups, int nSelectors) { }

	// RVA: 0x1E492D0 Offset: 0x1E47CD0 VA: 0x181E492D0
	private void sendMTFValues6(int nGroups, int alphaSize) { }

	// RVA: 0x1E49490 Offset: 0x1E47E90 VA: 0x181E49490
	private void sendMTFValues7(int nSelectors) { }

	// RVA: 0x1E47FA0 Offset: 0x1E469A0 VA: 0x181E47FA0
	private void moveToFrontCodeAndSend() { }
}
