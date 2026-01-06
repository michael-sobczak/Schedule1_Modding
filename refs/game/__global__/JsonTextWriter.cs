public class JsonTextWriter : JsonWriter // TypeDefIndex: 11075
{
	// Fields
	private readonly bool _safeAsync; // 0x60
	private const int IndentCharBufferSize = 12;
	private readonly TextWriter _writer; // 0x68
	[Nullable(2)]
	private Base64Encoder _base64Encoder; // 0x70
	private char _indentChar; // 0x78
	private int _indentation; // 0x7C
	private char _quoteChar; // 0x80
	private bool _quoteName; // 0x82
	[Nullable(2)]
	private bool[] _charEscapeFlags; // 0x88
	[Nullable(2)]
	private char[] _writeBuffer; // 0x90
	[Nullable(2)]
	private IArrayPool<char> _arrayPool; // 0x98
	[Nullable(2)]
	private char[] _indentChars; // 0xA0

	// Properties
	private Base64Encoder Base64Encoder { get; }
	[Nullable(2)]
	public IArrayPool<char> ArrayPool { get; set; }
	public int Indentation { get; set; }
	public char QuoteChar { get; set; }
	public char IndentChar { get; set; }
	public bool QuoteName { get; set; }

	// Methods

	// RVA: 0x1D2C920 Offset: 0x1D2B320 VA: 0x181D2C920 Slot: 6
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D29D70 Offset: 0x1D28770 VA: 0x181D29D70
	internal Task DoFlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D30B20 Offset: 0x1D2F520 VA: 0x181D30B20 Slot: 9
	protected override Task WriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D2C700 Offset: 0x1D2B100 VA: 0x181D2C700
	internal Task DoWriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D2CE90 Offset: 0x1D2B890 VA: 0x181D2CE90 Slot: 7
	protected override Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	// RVA: 0x1D29F10 Offset: 0x1D28910 VA: 0x181D29F10
	internal Task DoWriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	// RVA: 0x1D299A0 Offset: 0x1D283A0 VA: 0x181D299A0 Slot: 5
	public override Task CloseAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoCloseAsync>d__8))]
	// RVA: 0x1D29C80 Offset: 0x1D28680 VA: 0x181D29C80
	internal Task DoCloseAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<CloseBufferAndWriterAsync>d__9))]
	// RVA: 0x1D29AC0 Offset: 0x1D284C0 VA: 0x181D29AC0
	private Task CloseBufferAndWriterAsync() { }

	// RVA: 0x1D2CE70 Offset: 0x1D2B870 VA: 0x181D2CE70 Slot: 12
	public override Task WriteEndAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D2D340 Offset: 0x1D2BD40 VA: 0x181D2D340 Slot: 8
	protected override Task WriteIndentAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D2A050 Offset: 0x1D28A50 VA: 0x181D2A050
	internal Task DoWriteIndentAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<WriteIndentAsync>d__13))]
	// RVA: 0x1D2D520 Offset: 0x1D2BF20 VA: 0x181D2D520
	private Task WriteIndentAsync(int currentIndentCount, int newLineLen, CancellationToken cancellationToken) { }

	// RVA: 0x1D30D10 Offset: 0x1D2F710 VA: 0x181D30D10
	private Task WriteValueInternalAsync(JsonToken token, string value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<WriteValueInternalAsync>d__15))]
	// RVA: 0x1D30BD0 Offset: 0x1D2F5D0 VA: 0x181D30BD0
	private Task WriteValueInternalAsync(Task task, string value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2D640 Offset: 0x1D2C040 VA: 0x181D2D640 Slot: 10
	protected override Task WriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D2A210 Offset: 0x1D28C10 VA: 0x181D2A210
	internal Task DoWriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D2E410 Offset: 0x1D2CE10 VA: 0x181D2E410 Slot: 11
	public override Task WriteRawAsync(string json, CancellationToken cancellationToken) { }

	// RVA: 0x1D2A7C0 Offset: 0x1D291C0 VA: 0x181D2A7C0
	internal Task DoWriteRawAsync(string json, CancellationToken cancellationToken) { }

	// RVA: 0x1D2DE90 Offset: 0x1D2C890 VA: 0x181D2DE90 Slot: 16
	public override Task WriteNullAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D2A280 Offset: 0x1D28C80 VA: 0x181D2A280
	internal Task DoWriteNullAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D2CD60 Offset: 0x1D2B760 VA: 0x181D2CD60
	private Task WriteDigitsAsync(ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	// RVA: 0x1D2D840 Offset: 0x1D2C240 VA: 0x181D2D840
	private Task WriteIntegerValueAsync(ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<WriteIntegerValueAsync>d__24))]
	// RVA: 0x1D2DAE0 Offset: 0x1D2C4E0 VA: 0x181D2DAE0
	private Task WriteIntegerValueAsync(Task task, ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	// RVA: 0x1D2DAA0 Offset: 0x1D2C4A0 VA: 0x181D2DAA0
	internal Task WriteIntegerValueAsync(long value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2DC30 Offset: 0x1D2C630 VA: 0x181D2DC30
	internal Task WriteIntegerValueAsync(ulong uvalue, CancellationToken cancellationToken) { }

	// RVA: 0x1D2D160 Offset: 0x1D2BB60 VA: 0x181D2D160
	private Task WriteEscapedStringAsync(string value, bool quote, CancellationToken cancellationToken) { }

	// RVA: 0x1D2E2A0 Offset: 0x1D2CCA0 VA: 0x181D2E2A0 Slot: 17
	public override Task WritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	// RVA: 0x1D2A570 Offset: 0x1D28F70 VA: 0x181D2A570
	internal Task DoWritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWritePropertyNameAsync>d__30))]
	// RVA: 0x1D2A430 Offset: 0x1D28E30 VA: 0x181D2A430
	private Task DoWritePropertyNameAsync(Task task, string name, CancellationToken cancellationToken) { }

	// RVA: 0x1D2E150 Offset: 0x1D2CB50 VA: 0x181D2E150 Slot: 18
	public override Task WritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWritePropertyNameAsync>d__32))]
	// RVA: 0x1D2A300 Offset: 0x1D28D00 VA: 0x181D2A300
	internal Task DoWritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken) { }

	// RVA: 0x1D2E6D0 Offset: 0x1D2D0D0 VA: 0x181D2E6D0 Slot: 19
	public override Task WriteStartArrayAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D2AB30 Offset: 0x1D29530 VA: 0x181D2AB30
	internal Task DoWriteStartArrayAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteStartArrayAsync>d__35))]
	// RVA: 0x1D2ACE0 Offset: 0x1D296E0 VA: 0x181D2ACE0
	internal Task DoWriteStartArrayAsync(Task task, CancellationToken cancellationToken) { }

	// RVA: 0x1D2EB00 Offset: 0x1D2D500 VA: 0x181D2EB00 Slot: 23
	public override Task WriteStartObjectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D2AF20 Offset: 0x1D29920 VA: 0x181D2AF20
	internal Task DoWriteStartObjectAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteStartObjectAsync>d__38))]
	// RVA: 0x1D2B0D0 Offset: 0x1D29AD0 VA: 0x181D2B0D0
	internal Task DoWriteStartObjectAsync(Task task, CancellationToken cancellationToken) { }

	// RVA: 0x1D2E910 Offset: 0x1D2D310 VA: 0x181D2E910 Slot: 22
	public override Task WriteStartConstructorAsync(string name, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteStartConstructorAsync>d__40))]
	// RVA: 0x1D2AE00 Offset: 0x1D29800 VA: 0x181D2AE00
	internal Task DoWriteStartConstructorAsync(string name, CancellationToken cancellationToken) { }

	// RVA: 0x1D2ED40 Offset: 0x1D2D740 VA: 0x181D2ED40 Slot: 63
	public override Task WriteUndefinedAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D2B1F0 Offset: 0x1D29BF0 VA: 0x181D2B1F0
	internal Task DoWriteUndefinedAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteUndefinedAsync>d__43))]
	// RVA: 0x1D2B3C0 Offset: 0x1D29DC0 VA: 0x181D2B3C0
	private Task DoWriteUndefinedAsync(Task task, CancellationToken cancellationToken) { }

	// RVA: 0x1D32880 Offset: 0x1D31280 VA: 0x181D32880 Slot: 64
	public override Task WriteWhitespaceAsync(string ws, CancellationToken cancellationToken) { }

	// RVA: 0x1D2C770 Offset: 0x1D2B170 VA: 0x181D2C770
	internal Task DoWriteWhitespaceAsync(string ws, CancellationToken cancellationToken) { }

	// RVA: 0x1D2F7B0 Offset: 0x1D2E1B0 VA: 0x181D2F7B0 Slot: 25
	public override Task WriteValueAsync(bool value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2C130 Offset: 0x1D2AB30 VA: 0x181D2C130
	internal Task DoWriteValueAsync(bool value, CancellationToken cancellationToken) { }

	// RVA: 0x1D30170 Offset: 0x1D2EB70 VA: 0x181D30170 Slot: 26
	public override Task WriteValueAsync(Nullable<bool> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2C0A0 Offset: 0x1D2AAA0 VA: 0x181D2C0A0
	internal Task DoWriteValueAsync(Nullable<bool> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D305D0 Offset: 0x1D2EFD0 VA: 0x181D305D0 Slot: 27
	public override Task WriteValueAsync(byte value, CancellationToken cancellationToken) { }

	// RVA: 0x1D300C0 Offset: 0x1D2EAC0 VA: 0x181D300C0 Slot: 28
	public override Task WriteValueAsync(Nullable<byte> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2C010 Offset: 0x1D2AA10 VA: 0x181D2C010
	internal Task DoWriteValueAsync(Nullable<byte> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2FD30 Offset: 0x1D2E730 VA: 0x181D2FD30 Slot: 29
	public override Task WriteValueAsync(byte[] value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<WriteValueNonNullAsync>d__54))]
	// RVA: 0x1D30F00 Offset: 0x1D2F900 VA: 0x181D30F00
	internal Task WriteValueNonNullAsync(byte[] value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2F8C0 Offset: 0x1D2E2C0 VA: 0x181D2F8C0 Slot: 30
	public override Task WriteValueAsync(char value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2BE50 Offset: 0x1D2A850 VA: 0x181D2BE50
	internal Task DoWriteValueAsync(char value, CancellationToken cancellationToken) { }

	// RVA: 0x1D30530 Offset: 0x1D2EF30 VA: 0x181D30530 Slot: 31
	public override Task WriteValueAsync(Nullable<char> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2B950 Offset: 0x1D2A350 VA: 0x181D2B950
	internal Task DoWriteValueAsync(Nullable<char> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2FCE0 Offset: 0x1D2E6E0 VA: 0x181D2FCE0 Slot: 32
	public override Task WriteValueAsync(DateTime value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteValueAsync>d__60))]
	// RVA: 0x1D2BD40 Offset: 0x1D2A740 VA: 0x181D2BD40
	internal Task DoWriteValueAsync(DateTime value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2F4D0 Offset: 0x1D2DED0 VA: 0x181D2F4D0 Slot: 33
	public override Task WriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2C1B0 Offset: 0x1D2ABB0 VA: 0x181D2C1B0
	internal Task DoWriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2F8E0 Offset: 0x1D2E2E0 VA: 0x181D2F8E0 Slot: 34
	public override Task WriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteValueAsync>d__64))]
	// RVA: 0x1D2BAF0 Offset: 0x1D2A4F0 VA: 0x181D2BAF0
	internal Task DoWriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2FE80 Offset: 0x1D2E880 VA: 0x181D2FE80 Slot: 35
	public override Task WriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2B4E0 Offset: 0x1D29EE0 VA: 0x181D2B4E0
	internal Task DoWriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2F210 Offset: 0x1D2DC10 VA: 0x181D2F210 Slot: 36
	public override Task WriteValueAsync(Decimal value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2C4C0 Offset: 0x1D2AEC0 VA: 0x181D2C4C0
	internal Task DoWriteValueAsync(Decimal value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2F0A0 Offset: 0x1D2DAA0 VA: 0x181D2F0A0 Slot: 37
	public override Task WriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2C230 Offset: 0x1D2AC30 VA: 0x181D2C230
	internal Task DoWriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2FF50 Offset: 0x1D2E950 VA: 0x181D2FF50 Slot: 38
	public override Task WriteValueAsync(double value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2EFE0 Offset: 0x1D2D9E0 VA: 0x181D2EFE0
	internal Task WriteValueAsync(double value, bool nullable, CancellationToken cancellationToken) { }

	// RVA: 0x1D30610 Offset: 0x1D2F010 VA: 0x181D30610 Slot: 39
	public override Task WriteValueAsync(Nullable<double> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2FD00 Offset: 0x1D2E700 VA: 0x181D2FD00 Slot: 40
	public override Task WriteValueAsync(float value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2FF80 Offset: 0x1D2E980 VA: 0x181D2FF80
	internal Task WriteValueAsync(float value, bool nullable, CancellationToken cancellationToken) { }

	// RVA: 0x1D2FC20 Offset: 0x1D2E620 VA: 0x181D2FC20 Slot: 41
	public override Task WriteValueAsync(Nullable<float> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D30430 Offset: 0x1D2EE30 VA: 0x181D30430 Slot: 42
	public override Task WriteValueAsync(Guid value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteValueAsync>d__78))]
	// RVA: 0x1D2C3B0 Offset: 0x1D2ADB0 VA: 0x181D2C3B0
	internal Task DoWriteValueAsync(Guid value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2F630 Offset: 0x1D2E030 VA: 0x181D2F630 Slot: 43
	public override Task WriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2C550 Offset: 0x1D2AF50 VA: 0x181D2C550
	internal Task DoWriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D30A00 Offset: 0x1D2F400 VA: 0x181D30A00 Slot: 44
	public override Task WriteValueAsync(int value, CancellationToken cancellationToken) { }

	// RVA: 0x1D30A50 Offset: 0x1D2F450 VA: 0x181D30A50 Slot: 45
	public override Task WriteValueAsync(Nullable<int> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2C310 Offset: 0x1D2AD10 VA: 0x181D2C310
	internal Task DoWriteValueAsync(Nullable<int> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D303A0 Offset: 0x1D2EDA0 VA: 0x181D303A0 Slot: 46
	public override Task WriteValueAsync(long value, CancellationToken cancellationToken) { }

	// RVA: 0x1D30460 Offset: 0x1D2EE60 VA: 0x181D30460 Slot: 47
	public override Task WriteValueAsync(Nullable<long> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2B5F0 Offset: 0x1D29FF0 VA: 0x181D2B5F0
	internal Task DoWriteValueAsync(Nullable<long> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2FB60 Offset: 0x1D2E560 VA: 0x181D2FB60
	internal Task WriteValueAsync(BigInteger value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2F2D0 Offset: 0x1D2DCD0 VA: 0x181D2F2D0 Slot: 48
	public override Task WriteValueAsync(object value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x1D30070 Offset: 0x1D2EA70 VA: 0x181D30070 Slot: 49
	public override Task WriteValueAsync(sbyte value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x1D302D0 Offset: 0x1D2ECD0 VA: 0x181D302D0 Slot: 50
	public override Task WriteValueAsync(Nullable<sbyte> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2BF60 Offset: 0x1D2A960 VA: 0x181D2BF60
	internal Task DoWriteValueAsync(Nullable<sbyte> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2F1C0 Offset: 0x1D2DBC0 VA: 0x181D2F1C0 Slot: 51
	public override Task WriteValueAsync(short value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2F6F0 Offset: 0x1D2E0F0 VA: 0x181D2F6F0 Slot: 52
	public override Task WriteValueAsync(Nullable<short> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2B690 Offset: 0x1D2A090 VA: 0x181D2B690
	internal Task DoWriteValueAsync(Nullable<short> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D307B0 Offset: 0x1D2F1B0 VA: 0x181D307B0 Slot: 53
	public override Task WriteValueAsync(string value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2B730 Offset: 0x1D2A130 VA: 0x181D2B730
	internal Task DoWriteValueAsync(string value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteValueAsync>d__97))]
	// RVA: 0x1D2BC00 Offset: 0x1D2A600 VA: 0x181D2BC00
	private Task DoWriteValueAsync(Task task, string value, CancellationToken cancellationToken) { }

	// RVA: 0x1D306E0 Offset: 0x1D2F0E0 VA: 0x181D306E0 Slot: 54
	public override Task WriteValueAsync(TimeSpan value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteValueAsync>d__99))]
	// RVA: 0x1D2B9E0 Offset: 0x1D2A3E0 VA: 0x181D2B9E0
	internal Task DoWriteValueAsync(TimeSpan value, CancellationToken cancellationToken) { }

	// RVA: 0x1D30700 Offset: 0x1D2F100 VA: 0x181D30700 Slot: 55
	public override Task WriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2B570 Offset: 0x1D29F70 VA: 0x181D2B570
	internal Task DoWriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x1D2F7D0 Offset: 0x1D2E1D0 VA: 0x181D2F7D0 Slot: 56
	public override Task WriteValueAsync(uint value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x1D2F580 Offset: 0x1D2DF80 VA: 0x181D2F580 Slot: 57
	public override Task WriteValueAsync(Nullable<uint> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2BED0 Offset: 0x1D2A8D0 VA: 0x181D2BED0
	internal Task DoWriteValueAsync(Nullable<uint> value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x1D30040 Offset: 0x1D2EA40 VA: 0x181D30040 Slot: 58
	public override Task WriteValueAsync(ulong value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x1D2F810 Offset: 0x1D2E210 VA: 0x181D2F810 Slot: 59
	public override Task WriteValueAsync(Nullable<ulong> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2C670 Offset: 0x1D2B070 VA: 0x181D2C670
	internal Task DoWriteValueAsync(Nullable<ulong> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2F910 Offset: 0x1D2E310 VA: 0x181D2F910 Slot: 60
	public override Task WriteValueAsync(Uri value, CancellationToken cancellationToken) { }

	// RVA: 0x1D31160 Offset: 0x1D2FB60 VA: 0x181D31160
	internal Task WriteValueNotNullAsync(Uri value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<WriteValueNotNullAsync>d__110))]
	// RVA: 0x1D31020 Offset: 0x1D2FA20 VA: 0x181D31020
	internal Task WriteValueNotNullAsync(Task task, Uri value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x1D303F0 Offset: 0x1D2EDF0 VA: 0x181D303F0 Slot: 61
	public override Task WriteValueAsync(ushort value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x1D30220 Offset: 0x1D2EC20 VA: 0x181D30220 Slot: 62
	public override Task WriteValueAsync(Nullable<ushort> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2C5E0 Offset: 0x1D2AFE0 VA: 0x181D2C5E0
	internal Task DoWriteValueAsync(Nullable<ushort> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D2CB70 Offset: 0x1D2B570 VA: 0x181D2CB70 Slot: 20
	public override Task WriteCommentAsync(string text, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteCommentAsync>d__115))]
	// RVA: 0x1D29DF0 Offset: 0x1D287F0 VA: 0x181D29DF0
	internal Task DoWriteCommentAsync(string text, CancellationToken cancellationToken) { }

	// RVA: 0x1D2CE50 Offset: 0x1D2B850 VA: 0x181D2CE50 Slot: 13
	public override Task WriteEndArrayAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D2D030 Offset: 0x1D2BA30 VA: 0x181D2D030 Slot: 14
	public override Task WriteEndConstructorAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D2D050 Offset: 0x1D2BA50 VA: 0x181D2D050 Slot: 15
	public override Task WriteEndObjectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D2E4A0 Offset: 0x1D2CEA0 VA: 0x181D2E4A0 Slot: 21
	public override Task WriteRawValueAsync(string json, CancellationToken cancellationToken) { }

	// RVA: 0x1D2A830 Offset: 0x1D29230 VA: 0x181D2A830
	internal Task DoWriteRawValueAsync(string json, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteRawValueAsync>d__121))]
	// RVA: 0x1D2A9F0 Offset: 0x1D293F0 VA: 0x181D2A9F0
	private Task DoWriteRawValueAsync(Task task, string json, CancellationToken cancellationToken) { }

	// RVA: 0x1D2C7F0 Offset: 0x1D2B1F0 VA: 0x181D2C7F0
	internal char[] EnsureWriteBuffer(int length, int copyTo) { }

	// RVA: 0x1D32AC0 Offset: 0x1D314C0 VA: 0x181D32AC0
	private Base64Encoder get_Base64Encoder() { }

	[NullableContext(2)]
	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public IArrayPool<char> get_ArrayPool() { }

	[NullableContext(2)]
	// RVA: 0x1D32B70 Offset: 0x1D31570 VA: 0x181D32B70
	public void set_ArrayPool(IArrayPool<char> value) { }

	// RVA: 0x6A4D90 Offset: 0x6A3790 VA: 0x1806A4D90
	public int get_Indentation() { }

	// RVA: 0x1D32C20 Offset: 0x1D31620 VA: 0x181D32C20
	public void set_Indentation(int value) { }

	// RVA: 0x1D32B50 Offset: 0x1D31550 VA: 0x181D32B50
	public char get_QuoteChar() { }

	// RVA: 0x1D32C90 Offset: 0x1D31690 VA: 0x181D32C90
	public void set_QuoteChar(char value) { }

	// RVA: 0x1D32B40 Offset: 0x1D31540 VA: 0x181D32B40
	public char get_IndentChar() { }

	// RVA: 0x1D32BF0 Offset: 0x1D315F0 VA: 0x181D32BF0
	public void set_IndentChar(char value) { }

	// RVA: 0x1D32B60 Offset: 0x1D31560 VA: 0x181D32B60
	public bool get_QuoteName() { }

	// RVA: 0x1D32D10 Offset: 0x1D31710 VA: 0x181D32D10
	public void set_QuoteName(bool value) { }

	// RVA: 0x1D32970 Offset: 0x1D31370 VA: 0x181D32970
	public void .ctor(TextWriter textWriter) { }

	// RVA: 0x1B78230 Offset: 0x1B76C30 VA: 0x181B78230 Slot: 66
	public override void Flush() { }

	// RVA: 0x1D29C00 Offset: 0x1D28600 VA: 0x181D29C00 Slot: 67
	public override void Close() { }

	// RVA: 0x1D29B90 Offset: 0x1D28590 VA: 0x181D29B90
	private void CloseBufferAndWriter() { }

	// RVA: 0x1D2ECF0 Offset: 0x1D2D6F0 VA: 0x181D2ECF0 Slot: 68
	public override void WriteStartObject() { }

	// RVA: 0x1D2E8C0 Offset: 0x1D2D2C0 VA: 0x181D2E8C0 Slot: 70
	public override void WriteStartArray() { }

	// RVA: 0x1D2EA40 Offset: 0x1D2D440 VA: 0x181D2EA40 Slot: 72
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x1D2D070 Offset: 0x1D2BA70 VA: 0x181D2D070 Slot: 78
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0x1D2E2C0 Offset: 0x1D2CCC0 VA: 0x181D2E2C0 Slot: 74
	public override void WritePropertyName(string name) { }

	// RVA: 0x1D2E320 Offset: 0x1D2CD20 VA: 0x181D2E320 Slot: 75
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0x1D2C9C0 Offset: 0x1D2B3C0 VA: 0x181D2C9C0 Slot: 65
	internal override void OnStringEscapeHandlingChanged() { }

	// RVA: 0x1D2CAF0 Offset: 0x1D2B4F0 VA: 0x181D2CAF0
	private void UpdateCharEscapeFlags() { }

	// RVA: 0x1D2D6F0 Offset: 0x1D2C0F0 VA: 0x181D2D6F0 Slot: 79
	protected override void WriteIndent() { }

	// RVA: 0x1D2C9D0 Offset: 0x1D2B3D0 VA: 0x181D2C9D0
	private int SetIndentChars() { }

	// RVA: 0x1D30BA0 Offset: 0x1D2F5A0 VA: 0x181D30BA0 Slot: 80
	protected override void WriteValueDelimiter() { }

	// RVA: 0x1D2D6C0 Offset: 0x1D2C0C0 VA: 0x181D2D6C0 Slot: 81
	protected override void WriteIndentSpace() { }

	// RVA: 0x1D30ED0 Offset: 0x1D2F8D0 VA: 0x181D30ED0
	private void WriteValueInternal(string value, JsonToken token) { }

	[NullableContext(2)]
	// RVA: 0x1D31770 Offset: 0x1D30170 VA: 0x181D31770 Slot: 123
	public override void WriteValue(object value) { }

	// RVA: 0x1D2DEB0 Offset: 0x1D2C8B0 VA: 0x181D2DEB0 Slot: 82
	public override void WriteNull() { }

	// RVA: 0x1D2EF50 Offset: 0x1D2D950 VA: 0x181D2EF50 Slot: 83
	public override void WriteUndefined() { }

	[NullableContext(2)]
	// RVA: 0x1D2E680 Offset: 0x1D2D080 VA: 0x181D2E680 Slot: 84
	public override void WriteRaw(string json) { }

	[NullableContext(2)]
	// RVA: 0x1D31F90 Offset: 0x1D30990 VA: 0x181D31F90 Slot: 86
	public override void WriteValue(string value) { }

	// RVA: 0x1D2D240 Offset: 0x1D2BC40 VA: 0x181D2D240
	private void WriteEscapedString(string value, bool quote) { }

	// RVA: 0x1D318A0 Offset: 0x1D302A0 VA: 0x181D318A0 Slot: 87
	public override void WriteValue(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D31B60 Offset: 0x1D30560 VA: 0x181D31B60 Slot: 88
	public override void WriteValue(uint value) { }

	// RVA: 0x1D32630 Offset: 0x1D31030 VA: 0x181D32630 Slot: 89
	public override void WriteValue(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D325F0 Offset: 0x1D30FF0 VA: 0x181D325F0 Slot: 90
	public override void WriteValue(ulong value) { }

	// RVA: 0x1D326C0 Offset: 0x1D310C0 VA: 0x181D326C0 Slot: 91
	public override void WriteValue(float value) { }

	// RVA: 0x1D32780 Offset: 0x1D31180 VA: 0x181D32780 Slot: 108
	public override void WriteValue(Nullable<float> value) { }

	// RVA: 0x1D32530 Offset: 0x1D30F30 VA: 0x181D32530 Slot: 92
	public override void WriteValue(double value) { }

	// RVA: 0x1D318E0 Offset: 0x1D302E0 VA: 0x181D318E0 Slot: 109
	public override void WriteValue(Nullable<double> value) { }

	// RVA: 0x1D31D70 Offset: 0x1D30770 VA: 0x181D31D70 Slot: 93
	public override void WriteValue(bool value) { }

	// RVA: 0x1D319E0 Offset: 0x1D303E0 VA: 0x181D319E0 Slot: 94
	public override void WriteValue(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D31B20 Offset: 0x1D30520 VA: 0x181D31B20 Slot: 95
	public override void WriteValue(ushort value) { }

	// RVA: 0x1D324A0 Offset: 0x1D30EA0 VA: 0x181D324A0 Slot: 96
	public override void WriteValue(char value) { }

	// RVA: 0x1D32460 Offset: 0x1D30E60 VA: 0x181D32460 Slot: 97
	public override void WriteValue(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D31F50 Offset: 0x1D30950 VA: 0x181D31F50 Slot: 98
	public override void WriteValue(sbyte value) { }

	// RVA: 0x1D31E00 Offset: 0x1D30800 VA: 0x181D31E00 Slot: 99
	public override void WriteValue(Decimal value) { }

	// RVA: 0x1D32050 Offset: 0x1D30A50 VA: 0x181D32050 Slot: 100
	public override void WriteValue(DateTime value) { }

	// RVA: 0x1D31500 Offset: 0x1D2FF00 VA: 0x181D31500
	private int WriteValueToBuffer(DateTime value) { }

	[NullableContext(2)]
	// RVA: 0x1D31680 Offset: 0x1D30080 VA: 0x181D31680 Slot: 121
	public override void WriteValue(byte[] value) { }

	// RVA: 0x1D31BE0 Offset: 0x1D305E0 VA: 0x181D31BE0 Slot: 101
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x1D31330 Offset: 0x1D2FD30 VA: 0x181D31330
	private int WriteValueToBuffer(DateTimeOffset value) { }

	// RVA: 0x1D31A20 Offset: 0x1D30420 VA: 0x181D31A20 Slot: 102
	public override void WriteValue(Guid value) { }

	// RVA: 0x1D32350 Offset: 0x1D30D50 VA: 0x181D32350 Slot: 103
	public override void WriteValue(TimeSpan value) { }

	[NullableContext(2)]
	// RVA: 0x1D31EA0 Offset: 0x1D308A0 VA: 0x181D31EA0 Slot: 122
	public override void WriteValue(Uri value) { }

	[NullableContext(2)]
	// RVA: 0x1D2CCA0 Offset: 0x1D2B6A0 VA: 0x181D2CCA0 Slot: 124
	public override void WriteComment(string text) { }

	// RVA: 0x1D32920 Offset: 0x1D31320 VA: 0x181D32920 Slot: 125
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1D2C8D0 Offset: 0x1D2B2D0 VA: 0x181D2C8D0
	private void EnsureWriteBuffer() { }

	// RVA: 0x1D2DE30 Offset: 0x1D2C830 VA: 0x181D2DE30
	private void WriteIntegerValue(long value) { }

	// RVA: 0x1D2DC50 Offset: 0x1D2C650 VA: 0x181D2DC50
	private void WriteIntegerValue(ulong value, bool negative) { }

	// RVA: 0x1D2DF40 Offset: 0x1D2C940 VA: 0x181D2DF40
	private int WriteNumberToBuffer(ulong value, bool negative) { }

	// RVA: 0x1D2DD70 Offset: 0x1D2C770 VA: 0x181D2DD70
	private void WriteIntegerValue(int value) { }

	// RVA: 0x1D2DCE0 Offset: 0x1D2C6E0 VA: 0x181D2DCE0
	private void WriteIntegerValue(uint value, bool negative) { }

	// RVA: 0x1D2E060 Offset: 0x1D2CA60 VA: 0x181D2E060
	private int WriteNumberToBuffer(uint value, bool negative) { }
}
