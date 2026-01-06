public class NtpPacket // TypeDefIndex: 12475
{
	// Fields
	private static readonly DateTime Epoch; // 0x0
	[CompilerGenerated]
	private readonly byte[] <Bytes>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<DateTime> <DestinationTimestamp>k__BackingField; // 0x18

	// Properties
	public byte[] Bytes { get; }
	public NtpLeapIndicator LeapIndicator { get; }
	public int VersionNumber { get; set; }
	public NtpMode Mode { get; set; }
	public int Stratum { get; }
	public int Poll { get; }
	public int Precision { get; }
	public TimeSpan RootDelay { get; }
	public TimeSpan RootDispersion { get; }
	public uint ReferenceId { get; }
	public Nullable<DateTime> ReferenceTimestamp { get; }
	public Nullable<DateTime> OriginTimestamp { get; }
	public Nullable<DateTime> ReceiveTimestamp { get; }
	public Nullable<DateTime> TransmitTimestamp { get; set; }
	public Nullable<DateTime> DestinationTimestamp { get; set; }
	public TimeSpan RoundTripTime { get; }
	public TimeSpan CorrectionOffset { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public byte[] get_Bytes() { }

	// RVA: 0xD15BE0 Offset: 0xD145E0 VA: 0x180D15BE0
	public NtpLeapIndicator get_LeapIndicator() { }

	// RVA: 0xD15F90 Offset: 0xD14990 VA: 0x180D15F90
	public int get_VersionNumber() { }

	// RVA: 0xD161D0 Offset: 0xD14BD0 VA: 0x180D161D0
	private void set_VersionNumber(int value) { }

	// RVA: 0xD15C10 Offset: 0xD14610 VA: 0x180D15C10
	public NtpMode get_Mode() { }

	// RVA: 0xD15FC0 Offset: 0xD149C0 VA: 0x180D15FC0
	private void set_Mode(NtpMode value) { }

	// RVA: 0xD15F30 Offset: 0xD14930 VA: 0x180D15F30
	public int get_Stratum() { }

	// RVA: 0xD15C70 Offset: 0xD14670 VA: 0x180D15C70
	public int get_Poll() { }

	// RVA: 0xD15CA0 Offset: 0xD146A0 VA: 0x180D15CA0
	public int get_Precision() { }

	// RVA: 0xD15D90 Offset: 0xD14790 VA: 0x180D15D90
	public TimeSpan get_RootDelay() { }

	// RVA: 0xD15DA0 Offset: 0xD147A0 VA: 0x180D15DA0
	public TimeSpan get_RootDispersion() { }

	// RVA: 0xD15D00 Offset: 0xD14700 VA: 0x180D15D00
	public uint get_ReferenceId() { }

	// RVA: 0xD15D60 Offset: 0xD14760 VA: 0x180D15D60
	public Nullable<DateTime> get_ReferenceTimestamp() { }

	// RVA: 0xD15C40 Offset: 0xD14640 VA: 0x180D15C40
	public Nullable<DateTime> get_OriginTimestamp() { }

	// RVA: 0xD15CD0 Offset: 0xD146D0 VA: 0x180D15CD0
	public Nullable<DateTime> get_ReceiveTimestamp() { }

	// RVA: 0xD15F60 Offset: 0xD14960 VA: 0x180D15F60
	public Nullable<DateTime> get_TransmitTimestamp() { }

	// RVA: 0xD16000 Offset: 0xD14A00 VA: 0x180D16000
	private void set_TransmitTimestamp(Nullable<DateTime> value) { }

	[CompilerGenerated]
	// RVA: 0x526100 Offset: 0x524B00 VA: 0x180526100
	public Nullable<DateTime> get_DestinationTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x691670 Offset: 0x690070 VA: 0x180691670
	private void set_DestinationTimestamp(Nullable<DateTime> value) { }

	// RVA: 0xD15DB0 Offset: 0xD147B0 VA: 0x180D15DB0
	public TimeSpan get_RoundTripTime() { }

	// RVA: 0xD15A50 Offset: 0xD14450 VA: 0x180D15A50
	public TimeSpan get_CorrectionOffset() { }

	// RVA: 0xD15730 Offset: 0xD14130 VA: 0x180D15730
	public void .ctor() { }

	// RVA: 0xD15690 Offset: 0xD14090 VA: 0x180D15690
	internal void .ctor(byte[] bytes) { }

	// RVA: 0xD14B40 Offset: 0xD13540 VA: 0x180D14B40
	public static NtpPacket FromServerResponse(byte[] bytes, DateTime destinationTimestamp) { }

	// RVA: 0xD154D0 Offset: 0xD13ED0 VA: 0x180D154D0
	internal void ValidateRequest() { }

	// RVA: 0xD152F0 Offset: 0xD13CF0 VA: 0x180D152F0
	internal void ValidateReply() { }

	// RVA: 0xD14980 Offset: 0xD13380 VA: 0x180D14980
	private void CheckTimestamps() { }

	// RVA: 0xD14C50 Offset: 0xD13650 VA: 0x180D14C50
	private Nullable<DateTime> GetDateTime64(int offset) { }

	// RVA: 0xD14FF0 Offset: 0xD139F0 VA: 0x180D14FF0
	private void SetDateTime64(int offset, Nullable<DateTime> value) { }

	// RVA: 0xD14E90 Offset: 0xD13890 VA: 0x180D14E90
	private TimeSpan GetTimeSpan32(int offset) { }

	// RVA: 0xD14F40 Offset: 0xD13940 VA: 0x180D14F40
	private ulong GetUInt64BE(int offset) { }

	// RVA: 0xD151C0 Offset: 0xD13BC0 VA: 0x180D151C0
	private void SetUInt64BE(int offset, ulong value) { }

	// RVA: 0xD14E30 Offset: 0xD13830 VA: 0x180D14E30
	private int GetInt32BE(int offset) { }

	// RVA: 0xD14E30 Offset: 0xD13830 VA: 0x180D14E30
	private uint GetUInt32BE(int offset) { }

	// RVA: 0xD15280 Offset: 0xD13C80 VA: 0x180D15280
	private static uint SwapEndianness(uint x) { }

	// RVA: 0xD15290 Offset: 0xD13C90 VA: 0x180D15290
	private static ulong SwapEndianness(ulong x) { }

	// RVA: 0xD15630 Offset: 0xD14030 VA: 0x180D15630
	private static void .cctor() { }
}
