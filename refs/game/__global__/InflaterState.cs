internal enum InflaterState // TypeDefIndex: 17648
{
	// Fields
	public int value__; // 0x0
	public const InflaterState ReadingHeader = 0;
	public const InflaterState ReadingBFinal = 2;
	public const InflaterState ReadingBType = 3;
	public const InflaterState ReadingNumLitCodes = 4;
	public const InflaterState ReadingNumDistCodes = 5;
	public const InflaterState ReadingNumCodeLengthCodes = 6;
	public const InflaterState ReadingCodeLengthCodes = 7;
	public const InflaterState ReadingTreeCodesBefore = 8;
	public const InflaterState ReadingTreeCodesAfter = 9;
	public const InflaterState DecodeTop = 10;
	public const InflaterState HaveInitialLength = 11;
	public const InflaterState HaveFullLength = 12;
	public const InflaterState HaveDistCode = 13;
	public const InflaterState UncompressedAligning = 15;
	public const InflaterState UncompressedByte1 = 16;
	public const InflaterState UncompressedByte2 = 17;
	public const InflaterState UncompressedByte3 = 18;
	public const InflaterState UncompressedByte4 = 19;
	public const InflaterState DecodingUncompressed = 20;
	public const InflaterState StartReadingFooter = 21;
	public const InflaterState ReadingFooter = 22;
	public const InflaterState VerifyingFooter = 23;
	public const InflaterState Done = 24;
}
