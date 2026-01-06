public class BZip2InputStream : Stream // TypeDefIndex: 16637
{
	// Fields
	private bool _disposed; // 0x28
	private bool _leaveOpen; // 0x29
	private long totalBytesRead; // 0x30
	private int last; // 0x38
	private int origPtr; // 0x3C
	private int blockSize100k; // 0x40
	private bool blockRandomised; // 0x44
	private int bsBuff; // 0x48
	private int bsLive; // 0x4C
	private readonly CRC32 crc; // 0x50
	private int nInUse; // 0x58
	private Stream input; // 0x60
	private int currentChar; // 0x68
	private BZip2InputStream.CState currentState; // 0x6C
	private uint storedBlockCRC; // 0x70
	private uint storedCombinedCRC; // 0x74
	private uint computedBlockCRC; // 0x78
	private uint computedCombinedCRC; // 0x7C
	private int su_count; // 0x80
	private int su_ch2; // 0x84
	private int su_chPrev; // 0x88
	private int su_i2; // 0x8C
	private int su_j2; // 0x90
	private int su_rNToGo; // 0x94
	private int su_rTPos; // 0x98
	private int su_tPos; // 0x9C
	private char su_z; // 0xA0
	private BZip2InputStream.DecompressionState data; // 0xA8

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1E5DA40 Offset: 0x1E5C440 VA: 0x181E5DA40
	public void .ctor(Stream input) { }

	// RVA: 0x1E5DB10 Offset: 0x1E5C510 VA: 0x181E5DB10
	public void .ctor(Stream input, bool leaveOpen) { }

	// RVA: 0x1E5CBF0 Offset: 0x1E5B5F0 VA: 0x181E5CBF0 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E5C6F0 Offset: 0x1E5B0F0 VA: 0x181E5C6F0
	private void MakeMaps() { }

	// RVA: 0x1E5C770 Offset: 0x1E5B170 VA: 0x181E5C770 Slot: 36
	public override int ReadByte() { }

	// RVA: 0x1E5F070 Offset: 0x1E5DA70 VA: 0x181E5F070 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1E5F100 Offset: 0x1E5DB00 VA: 0x181E5F100 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1E5C250 Offset: 0x1E5AC50 VA: 0x181E5C250 Slot: 22
	public override void Flush() { }

	// RVA: 0x1E5F190 Offset: 0x1E5DB90 VA: 0x181E5F190 Slot: 11
	public override long get_Length() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1E5FB40 Offset: 0x1E5E540 VA: 0x181E5FB40 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1E5CEF0 Offset: 0x1E5B8F0 VA: 0x181E5CEF0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1E5CF30 Offset: 0x1E5B930 VA: 0x181E5CF30 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x1E5DA00 Offset: 0x1E5C400 VA: 0x181E5DA00 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1E5C0C0 Offset: 0x1E5AAC0 VA: 0x181E5C0C0 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1E5F4A0 Offset: 0x1E5DEA0 VA: 0x181E5F4A0
	private void init() { }

	// RVA: 0x1E5BEF0 Offset: 0x1E5A8F0 VA: 0x181E5BEF0
	private void CheckMagicChar(char expected, int position) { }

	// RVA: 0x1E5C3C0 Offset: 0x1E5ADC0 VA: 0x181E5C3C0
	private void InitBlock() { }

	// RVA: 0x1E5C160 Offset: 0x1E5AB60 VA: 0x181E5C160
	private void EndBlock() { }

	// RVA: 0x1E5DCA0 Offset: 0x1E5C6A0 VA: 0x181E5DCA0
	private void complete() { }

	// RVA: 0x1E5C010 Offset: 0x1E5AA10 VA: 0x181E5C010 Slot: 20
	public override void Close() { }

	// RVA: 0x1E5C2E0 Offset: 0x1E5ACE0 VA: 0x181E5C2E0
	private int GetBits(int n) { }

	// RVA: 0x1E5DBF0 Offset: 0x1E5C5F0 VA: 0x181E5DBF0
	private bool bsGetBit() { }

	// RVA: 0x1E5DC90 Offset: 0x1E5C690 VA: 0x181E5DC90
	private char bsGetUByte() { }

	// RVA: 0x1E5DC10 Offset: 0x1E5C610 VA: 0x181E5DC10
	private uint bsGetInt() { }

	// RVA: 0x1E5F1D0 Offset: 0x1E5DBD0 VA: 0x181E5F1D0
	private static void hbCreateDecodeTables(int[] limit, int[] bbase, int[] perm, char[] length, int minLen, int maxLen, int alphaSize) { }

	// RVA: 0x1E5F680 Offset: 0x1E5E080 VA: 0x181E5F680
	private void recvDecodingTables() { }

	// RVA: 0x1E5DD90 Offset: 0x1E5C790 VA: 0x181E5DD90
	private void createHuffmanDecodingTables(int alphaSize, int nGroups) { }

	// RVA: 0x1E5E410 Offset: 0x1E5CE10 VA: 0x181E5E410
	private void getAndMoveToFrontDecode() { }

	// RVA: 0x1E5E200 Offset: 0x1E5CC00 VA: 0x181E5E200
	private int getAndMoveToFrontDecode0(int groupNo) { }

	// RVA: 0x1E5CF70 Offset: 0x1E5B970 VA: 0x181E5CF70
	private void SetupBlock() { }

	// RVA: 0x1E5D670 Offset: 0x1E5C070 VA: 0x181E5D670
	private void SetupRandPartA() { }

	// RVA: 0x1E5D450 Offset: 0x1E5BE50 VA: 0x181E5D450
	private void SetupNoRandPartA() { }

	// RVA: 0x1E5D800 Offset: 0x1E5C200 VA: 0x181E5D800
	private void SetupRandPartB() { }

	// RVA: 0x1E5D990 Offset: 0x1E5C390 VA: 0x181E5D990
	private void SetupRandPartC() { }

	// RVA: 0x1E5D530 Offset: 0x1E5BF30 VA: 0x181E5D530
	private void SetupNoRandPartB() { }

	// RVA: 0x1E5D600 Offset: 0x1E5C000 VA: 0x181E5D600
	private void SetupNoRandPartC() { }
}
