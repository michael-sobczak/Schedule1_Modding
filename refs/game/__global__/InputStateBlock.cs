public struct InputStateBlock // TypeDefIndex: 7708
{
	// Fields
	public const uint InvalidOffset = 4294967295;
	public const uint AutomaticOffset = 4294967294;
	public static readonly FourCC FormatInvalid; // 0x0
	internal const int kFormatInvalid = 0;
	public static readonly FourCC FormatBit; // 0x4
	internal const int kFormatBit = 1112101920;
	public static readonly FourCC FormatSBit; // 0x8
	internal const int kFormatSBit = 1396853076;
	public static readonly FourCC FormatInt; // 0xC
	internal const int kFormatInt = 1229870112;
	public static readonly FourCC FormatUInt; // 0x10
	internal const int kFormatUInt = 1430867540;
	public static readonly FourCC FormatShort; // 0x14
	internal const int kFormatShort = 1397248596;
	public static readonly FourCC FormatUShort; // 0x18
	internal const int kFormatUShort = 1431521364;
	public static readonly FourCC FormatByte; // 0x1C
	internal const int kFormatByte = 1113150533;
	public static readonly FourCC FormatSByte; // 0x20
	internal const int kFormatSByte = 1396857172;
	public static readonly FourCC FormatLong; // 0x24
	internal const int kFormatLong = 1280198432;
	public static readonly FourCC FormatULong; // 0x28
	internal const int kFormatULong = 1431064135;
	public static readonly FourCC FormatFloat; // 0x2C
	internal const int kFormatFloat = 1179407392;
	public static readonly FourCC FormatDouble; // 0x30
	internal const int kFormatDouble = 1145195552;
	public static readonly FourCC FormatVector2; // 0x34
	internal const int kFormatVector2 = 1447379762;
	public static readonly FourCC FormatVector3; // 0x38
	internal const int kFormatVector3 = 1447379763;
	public static readonly FourCC FormatQuaternion; // 0x3C
	internal const int kFormatQuaternion = 1364541780;
	public static readonly FourCC FormatVector2Short; // 0x40
	public static readonly FourCC FormatVector3Short; // 0x44
	public static readonly FourCC FormatVector2Byte; // 0x48
	public static readonly FourCC FormatVector3Byte; // 0x4C
	public static readonly FourCC FormatPose; // 0x50
	internal const int kFormatPose = 1349481317;
	[CompilerGenerated]
	private FourCC <format>k__BackingField; // 0x0
	internal uint m_ByteOffset; // 0x4
	[CompilerGenerated]
	private uint <bitOffset>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <sizeInBits>k__BackingField; // 0xC

	// Properties
	public FourCC format { get; set; }
	public uint byteOffset { get; set; }
	public uint bitOffset { get; set; }
	public uint sizeInBits { get; set; }
	internal uint alignedSizeInBytes { get; }
	internal uint effectiveByteOffset { get; }
	internal uint effectiveBitOffset { get; }

	// Methods

	// RVA: 0x28752A0 Offset: 0x2873CA0 VA: 0x1828752A0
	public static int GetSizeOfPrimitiveFormatInBits(FourCC type) { }

	// RVA: 0x2874CB0 Offset: 0x28736B0 VA: 0x182874CB0
	public static FourCC GetPrimitiveFormatFromType(Type type) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public FourCC get_format() { }

	[CompilerGenerated]
	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_format(FourCC value) { }

	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public uint get_byteOffset() { }

	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	public void set_byteOffset(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	public uint get_bitOffset() { }

	[CompilerGenerated]
	// RVA: 0x4975E0 Offset: 0x495FE0 VA: 0x1804975E0
	public void set_bitOffset(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4975D0 Offset: 0x495FD0 VA: 0x1804975D0
	public uint get_sizeInBits() { }

	[CompilerGenerated]
	// RVA: 0x4975F0 Offset: 0x495FF0 VA: 0x1804975F0
	public void set_sizeInBits(uint value) { }

	// RVA: 0x28773F0 Offset: 0x2875DF0 VA: 0x1828773F0
	internal uint get_alignedSizeInBytes() { }

	// RVA: 0x2877490 Offset: 0x2875E90 VA: 0x182877490
	internal uint get_effectiveByteOffset() { }

	// RVA: 0x2877440 Offset: 0x2875E40 VA: 0x182877440
	internal uint get_effectiveBitOffset() { }

	// RVA: 0x2875EF0 Offset: 0x28748F0 VA: 0x182875EF0
	public int ReadInt(void* statePtr) { }

	// RVA: 0x2876930 Offset: 0x2875330 VA: 0x182876930
	public void WriteInt(void* statePtr, int value) { }

	// RVA: 0x2875A90 Offset: 0x2874490 VA: 0x182875A90
	public float ReadFloat(void* statePtr) { }

	// RVA: 0x2876580 Offset: 0x2874F80 VA: 0x182876580
	public void WriteFloat(void* statePtr, float value) { }

	// RVA: 0x2874880 Offset: 0x2873280 VA: 0x182874880
	internal PrimitiveValue FloatToPrimitiveValue(float value) { }

	// RVA: 0x28755F0 Offset: 0x2873FF0 VA: 0x1828755F0
	public double ReadDouble(void* statePtr) { }

	// RVA: 0x28761A0 Offset: 0x2874BA0 VA: 0x1828761A0
	public void WriteDouble(void* statePtr, double value) { }

	// RVA: 0x2876B80 Offset: 0x2875580 VA: 0x182876B80
	public void Write(void* statePtr, PrimitiveValue value) { }

	// RVA: 0x2874730 Offset: 0x2873130 VA: 0x182874730
	public void CopyToFrom(void* toStatePtr, void* fromStatePtr) { }

	// RVA: 0x2876ED0 Offset: 0x28758D0 VA: 0x182876ED0
	private static void .cctor() { }
}
