public class JsonTextReader : JsonReader, IJsonLineInfo // TypeDefIndex: 11053
{
	// Fields
	private readonly bool _safeAsync; // 0x78
	private const char UnicodeReplacementChar = '\xfffd';
	private const int MaximumJavascriptIntegerCharacterLength = 380;
	private const int LargeBufferLength = 1073741823;
	private readonly TextReader _reader; // 0x80
	[Nullable(2)]
	private char[] _chars; // 0x88
	private int _charsUsed; // 0x90
	private int _charPos; // 0x94
	private int _lineStartPos; // 0x98
	private int _lineNumber; // 0x9C
	private bool _isEndOfFile; // 0xA0
	private StringBuffer _stringBuffer; // 0xA8
	private StringReference _stringReference; // 0xB8
	[Nullable(2)]
	private IArrayPool<char> _arrayPool; // 0xC8
	[Nullable(2)]
	[CompilerGenerated]
	private JsonNameTable <PropertyNameTable>k__BackingField; // 0xD0

	// Properties
	[Nullable(2)]
	public JsonNameTable PropertyNameTable { get; set; }
	[Nullable(2)]
	public IArrayPool<char> ArrayPool { get; set; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x1D24CE0 Offset: 0x1D236E0 VA: 0x181D24CE0 Slot: 5
	public override Task<bool> ReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D1AE70 Offset: 0x1D19870 VA: 0x181D1AE70
	internal Task<bool> DoReadAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsync>d__3))]
	// RVA: 0x1D1B550 Offset: 0x1D19F50 VA: 0x181D1B550
	private Task<bool> DoReadAsync(Task<bool> task, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParsePostValueAsync>d__4))]
	// RVA: 0x1D1EE30 Offset: 0x1D1D830 VA: 0x181D1EE30
	private Task<bool> ParsePostValueAsync(bool ignoreComments, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadFromFinishedAsync>d__5))]
	// RVA: 0x1D255E0 Offset: 0x1D23FE0 VA: 0x181D255E0
	private Task<bool> ReadFromFinishedAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D25170 Offset: 0x1D23B70 VA: 0x181D25170
	private Task<int> ReadDataAsync(bool append, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadDataAsync>d__7))]
	// RVA: 0x1D25030 Offset: 0x1D23A30 VA: 0x181D25030
	private Task<int> ReadDataAsync(bool append, int charsRequired, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseValueAsync>d__8))]
	// RVA: 0x1D215E0 Offset: 0x1D1FFE0 VA: 0x181D215E0
	private Task<bool> ParseValueAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadStringIntoBufferAsync>d__9))]
	// RVA: 0x1D269C0 Offset: 0x1D253C0 VA: 0x181D269C0
	private Task ReadStringIntoBufferAsync(char quote, CancellationToken cancellationToken) { }

	// RVA: 0x1D22210 Offset: 0x1D20C10 VA: 0x181D22210
	private Task ProcessCarriageReturnAsync(bool append, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ProcessCarriageReturnAsync>d__11))]
	// RVA: 0x1D22110 Offset: 0x1D20B10 VA: 0x181D22110
	private Task ProcessCarriageReturnAsync(Task<bool> task) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseUnicodeAsync>d__12))]
	// RVA: 0x1D20FD0 Offset: 0x1D1F9D0 VA: 0x181D20FD0
	private Task<char> ParseUnicodeAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D1BA10 Offset: 0x1D1A410 VA: 0x181D1BA10
	private Task<bool> EnsureCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadCharsAsync>d__14))]
	// RVA: 0x1D24DA0 Offset: 0x1D237A0 VA: 0x181D24DA0
	private Task<bool> ReadCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseObjectAsync>d__15))]
	// RVA: 0x1D1EB10 Offset: 0x1D1D510 VA: 0x181D1EB10
	private Task<bool> ParseObjectAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseCommentAsync>d__16))]
	// RVA: 0x1D1CDF0 Offset: 0x1D1B7F0 VA: 0x181D1CDF0
	private Task ParseCommentAsync(bool setToken, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<EatWhitespaceAsync>d__17))]
	// RVA: 0x1D1B690 Offset: 0x1D1A090 VA: 0x181D1B690
	private Task EatWhitespaceAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseStringAsync>d__18))]
	// RVA: 0x1D20B70 Offset: 0x1D1F570 VA: 0x181D20B70
	private Task ParseStringAsync(char quote, ReadType readType, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<MatchValueAsync>d__19))]
	// RVA: 0x1D1C740 Offset: 0x1D1B140 VA: 0x181D1C740
	private Task<bool> MatchValueAsync(string value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<MatchValueWithTrailingSeparatorAsync>d__20))]
	// RVA: 0x1D1C880 Offset: 0x1D1B280 VA: 0x181D1C880
	private Task<bool> MatchValueWithTrailingSeparatorAsync(string value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<MatchAndSetAsync>d__21))]
	// RVA: 0x1D1C5F0 Offset: 0x1D1AFF0 VA: 0x181D1C5F0
	private Task MatchAndSetAsync(string value, JsonToken newToken, object tokenValue, CancellationToken cancellationToken) { }

	// RVA: 0x1D20CF0 Offset: 0x1D1F6F0 VA: 0x181D20CF0
	private Task ParseTrueAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D1D7F0 Offset: 0x1D1C1F0 VA: 0x181D1D7F0
	private Task ParseFalseAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D1D990 Offset: 0x1D1C390 VA: 0x181D1D990
	private Task ParseNullAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseConstructorAsync>d__25))]
	// RVA: 0x1D1D2E0 Offset: 0x1D1BCE0 VA: 0x181D1D2E0
	private Task ParseConstructorAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseNumberNaNAsync>d__26))]
	// RVA: 0x1D1DBE0 Offset: 0x1D1C5E0 VA: 0x181D1DBE0
	private Task<object> ParseNumberNaNAsync(ReadType readType, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseNumberPositiveInfinityAsync>d__27))]
	// RVA: 0x1D1E5A0 Offset: 0x1D1CFA0 VA: 0x181D1E5A0
	private Task<object> ParseNumberPositiveInfinityAsync(ReadType readType, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseNumberNegativeInfinityAsync>d__28))]
	// RVA: 0x1D1E0C0 Offset: 0x1D1CAC0 VA: 0x181D1E0C0
	private Task<object> ParseNumberNegativeInfinityAsync(ReadType readType, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseNumberAsync>d__29))]
	// RVA: 0x1D1DAD0 Offset: 0x1D1C4D0 VA: 0x181D1DAD0
	private Task ParseNumberAsync(ReadType readType, CancellationToken cancellationToken) { }

	// RVA: 0x1D20E90 Offset: 0x1D1F890 VA: 0x181D20E90
	private Task ParseUndefinedAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParsePropertyAsync>d__31))]
	// RVA: 0x1D1F2D0 Offset: 0x1D1DCD0 VA: 0x181D1F2D0
	private Task<bool> ParsePropertyAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadNumberIntoBufferAsync>d__32))]
	// RVA: 0x1D25B30 Offset: 0x1D24530 VA: 0x181D25B30
	private Task ReadNumberIntoBufferAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseUnquotedPropertyAsync>d__33))]
	// RVA: 0x1D212A0 Offset: 0x1D1FCA0 VA: 0x181D212A0
	private Task ParseUnquotedPropertyAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadNullCharAsync>d__34))]
	// RVA: 0x1D25800 Offset: 0x1D24200 VA: 0x181D25800
	private Task<bool> ReadNullCharAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<HandleNullAsync>d__35))]
	// RVA: 0x1D1C290 Offset: 0x1D1AC90 VA: 0x181D1C290
	private Task HandleNullAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadFinishedAsync>d__36))]
	// RVA: 0x1D25390 Offset: 0x1D23D90 VA: 0x181D25390
	private Task ReadFinishedAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadStringValueAsync>d__37))]
	// RVA: 0x1D27240 Offset: 0x1D25C40 VA: 0x181D27240
	private Task<object> ReadStringValueAsync(ReadType readType, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadNumberValueAsync>d__38))]
	// RVA: 0x1D25E50 Offset: 0x1D24850 VA: 0x181D25E50
	private Task<object> ReadNumberValueAsync(ReadType readType, CancellationToken cancellationToken) { }

	// RVA: 0x1D22680 Offset: 0x1D21080 VA: 0x181D22680 Slot: 6
	public override Task<Nullable<bool>> ReadAsBooleanAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsBooleanAsync>d__40))]
	// RVA: 0x1D1A540 Offset: 0x1D18F40 VA: 0x181D1A540
	internal Task<Nullable<bool>> DoReadAsBooleanAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D23290 Offset: 0x1D21C90 VA: 0x181D23290 Slot: 7
	public override Task<byte[]> ReadAsBytesAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsBytesAsync>d__42))]
	// RVA: 0x1D1A680 Offset: 0x1D19080 VA: 0x181D1A680
	internal Task<byte[]> DoReadAsBytesAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadIntoWrappedTypeObjectAsync>d__43))]
	// RVA: 0x1D25710 Offset: 0x1D24110 VA: 0x181D25710
	private Task ReadIntoWrappedTypeObjectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D23DB0 Offset: 0x1D227B0 VA: 0x181D23DB0 Slot: 8
	public override Task<Nullable<DateTime>> ReadAsDateTimeAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsDateTimeAsync>d__45))]
	// RVA: 0x1D1A7B0 Offset: 0x1D191B0 VA: 0x181D1A7B0
	internal Task<Nullable<DateTime>> DoReadAsDateTimeAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D23FB0 Offset: 0x1D229B0 VA: 0x181D23FB0 Slot: 9
	public override Task<Nullable<DateTimeOffset>> ReadAsDateTimeOffsetAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsDateTimeOffsetAsync>d__47))]
	// RVA: 0x1D1A8D0 Offset: 0x1D192D0 VA: 0x181D1A8D0
	internal Task<Nullable<DateTimeOffset>> DoReadAsDateTimeOffsetAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D24310 Offset: 0x1D22D10 VA: 0x181D24310 Slot: 10
	public override Task<Nullable<Decimal>> ReadAsDecimalAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsDecimalAsync>d__49))]
	// RVA: 0x1D1A9F0 Offset: 0x1D193F0 VA: 0x181D1A9F0
	internal Task<Nullable<Decimal>> DoReadAsDecimalAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D245D0 Offset: 0x1D22FD0 VA: 0x181D245D0 Slot: 11
	public override Task<Nullable<double>> ReadAsDoubleAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsDoubleAsync>d__51))]
	// RVA: 0x1D1AB10 Offset: 0x1D19510 VA: 0x181D1AB10
	internal Task<Nullable<double>> DoReadAsDoubleAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D24830 Offset: 0x1D23230 VA: 0x181D24830 Slot: 12
	public override Task<Nullable<int>> ReadAsInt32Async(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsInt32Async>d__53))]
	// RVA: 0x1D1AC30 Offset: 0x1D19630 VA: 0x181D1AC30
	internal Task<Nullable<int>> DoReadAsInt32Async(CancellationToken cancellationToken) { }

	// RVA: 0x1D24AA0 Offset: 0x1D234A0 VA: 0x181D24AA0 Slot: 13
	public override Task<string> ReadAsStringAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsStringAsync>d__55))]
	// RVA: 0x1D1AD50 Offset: 0x1D19750 VA: 0x181D1AD50
	internal Task<string> DoReadAsStringAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D28530 Offset: 0x1D26F30 VA: 0x181D28530
	public void .ctor(TextReader reader) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	public JsonNameTable get_PropertyNameTable() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x4B6CE0 Offset: 0x4B56E0 VA: 0x1804B6CE0
	public void set_PropertyNameTable(JsonNameTable value) { }

	[NullableContext(2)]
	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	public IArrayPool<char> get_ArrayPool() { }

	[NullableContext(2)]
	// RVA: 0x1D28700 Offset: 0x1D27100 VA: 0x181D28700
	public void set_ArrayPool(IArrayPool<char> value) { }

	// RVA: 0x1D1B940 Offset: 0x1D1A340 VA: 0x181D1B940
	private void EnsureBufferNotEmpty() { }

	// RVA: 0x1D282B0 Offset: 0x1D26CB0 VA: 0x181D282B0
	private void SetNewLine(bool hasNextChar) { }

	// RVA: 0x1D1CDE0 Offset: 0x1D1B7E0 VA: 0x181D1CDE0
	private void OnNewLine(int pos) { }

	// RVA: 0x1D20C90 Offset: 0x1D1F690 VA: 0x181D20C90
	private void ParseString(char quote, ReadType readType) { }

	// RVA: 0x1D20800 Offset: 0x1D1F200 VA: 0x181D20800
	private void ParseReadString(char quote, ReadType readType) { }

	// RVA: 0x1D1A1F0 Offset: 0x1D18BF0 VA: 0x181D1A1F0
	private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0x1D28310 Offset: 0x1D26D10 VA: 0x181D28310
	private void ShiftBufferIfNeeded() { }

	// RVA: 0x1D252B0 Offset: 0x1D23CB0 VA: 0x181D252B0
	private int ReadData(bool append) { }

	// RVA: 0x1D21F00 Offset: 0x1D20900 VA: 0x181D21F00
	private void PrepareBufferForReadData(bool append, int charsRequired) { }

	// RVA: 0x1D252C0 Offset: 0x1D23CC0 VA: 0x181D252C0
	private int ReadData(bool append, int charsRequired) { }

	// RVA: 0x1D1BBF0 Offset: 0x1D1A5F0 VA: 0x181D1BBF0
	private bool EnsureChars(int relativePosition, bool append) { }

	// RVA: 0x1D24EF0 Offset: 0x1D238F0 VA: 0x181D24EF0
	private bool ReadChars(int relativePosition, bool append) { }

	// RVA: 0x1D27F90 Offset: 0x1D26990 VA: 0x181D27F90 Slot: 21
	public override bool Read() { }

	// RVA: 0x1D24A10 Offset: 0x1D23410 VA: 0x181D24A10 Slot: 22
	public override Nullable<int> ReadAsInt32() { }

	// RVA: 0x1D24270 Offset: 0x1D22C70 VA: 0x181D24270 Slot: 28
	public override Nullable<DateTime> ReadAsDateTime() { }

	[NullableContext(2)]
	// RVA: 0x1D24C80 Offset: 0x1D23680 VA: 0x181D24C80 Slot: 23
	public override string ReadAsString() { }

	[NullableContext(2)]
	// RVA: 0x1D23490 Offset: 0x1D21E90 VA: 0x181D23490 Slot: 24
	public override byte[] ReadAsBytes() { }

	[NullableContext(2)]
	// RVA: 0x1D27380 Offset: 0x1D25D80 VA: 0x181D27380
	private object ReadStringValue(ReadType readType) { }

	[NullableContext(2)]
	// RVA: 0x1D1BEB0 Offset: 0x1D1A8B0 VA: 0x181D1BEB0
	private object FinishReadQuotedStringValue(ReadType readType) { }

	// RVA: 0x1D1A480 Offset: 0x1D18E80 VA: 0x181D1A480
	private JsonReaderException CreateUnexpectedCharacterException(char c) { }

	// RVA: 0x1D22880 Offset: 0x1D21280 VA: 0x181D22880 Slot: 26
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x1D22600 Offset: 0x1D21000 VA: 0x181D22600
	private void ProcessValueComma() { }

	[NullableContext(2)]
	// RVA: 0x1D25F90 Offset: 0x1D24990 VA: 0x181D25F90
	private object ReadNumberValue(ReadType readType) { }

	[NullableContext(2)]
	// RVA: 0x1D1BD40 Offset: 0x1D1A740 VA: 0x181D1BD40
	private object FinishReadQuotedNumber(ReadType readType) { }

	// RVA: 0x1D241C0 Offset: 0x1D22BC0 VA: 0x181D241C0 Slot: 29
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x1D24520 Offset: 0x1D22F20 VA: 0x181D24520 Slot: 27
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x1D24790 Offset: 0x1D23190 VA: 0x181D24790 Slot: 25
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0x1D1C390 Offset: 0x1D1AD90 VA: 0x181D1C390
	private void HandleNull() { }

	// RVA: 0x1D25490 Offset: 0x1D23E90 VA: 0x181D25490
	private void ReadFinished() { }

	// RVA: 0x1D25920 Offset: 0x1D24320 VA: 0x181D25920
	private bool ReadNullChar() { }

	// RVA: 0x1D1B9A0 Offset: 0x1D1A3A0 VA: 0x181D1B9A0
	private void EnsureBuffer() { }

	// RVA: 0x1D26AF0 Offset: 0x1D254F0 VA: 0x181D26AF0
	private void ReadStringIntoBuffer(char quote) { }

	// RVA: 0x1D1C180 Offset: 0x1D1AB80 VA: 0x181D1C180
	private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition) { }

	// RVA: 0x1D284C0 Offset: 0x1D26EC0 VA: 0x181D284C0
	private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) { }

	// RVA: 0x1D1A2E0 Offset: 0x1D18CE0 VA: 0x181D1A2E0
	private char ConvertUnicode(bool enoughChars) { }

	// RVA: 0x1D210F0 Offset: 0x1D1FAF0 VA: 0x181D210F0
	private char ParseUnicode() { }

	// RVA: 0x1D25C30 Offset: 0x1D24630 VA: 0x181D25C30
	private void ReadNumberIntoBuffer() { }

	// RVA: 0x1D25970 Offset: 0x1D24370 VA: 0x181D25970
	private bool ReadNumberCharIntoBuffer(char currentChar, int charPos) { }

	// RVA: 0x1D1A210 Offset: 0x1D18C10 VA: 0x181D1A210
	private void ClearRecentString() { }

	// RVA: 0x1D1EF70 Offset: 0x1D1D970 VA: 0x181D1EF70
	private bool ParsePostValue(bool ignoreComments) { }

	// RVA: 0x1D1EC40 Offset: 0x1D1D640 VA: 0x181D1EC40
	private bool ParseObject() { }

	// RVA: 0x1D1F400 Offset: 0x1D1DE00 VA: 0x181D1F400
	private bool ParseProperty() { }

	// RVA: 0x1D28450 Offset: 0x1D26E50 VA: 0x181D28450
	private bool ValidIdentifierChar(char value) { }

	// RVA: 0x1D213A0 Offset: 0x1D1FDA0 VA: 0x181D213A0
	private void ParseUnquotedProperty() { }

	// RVA: 0x1D27DE0 Offset: 0x1D267E0 VA: 0x181D27DE0
	private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition) { }

	// RVA: 0x1D21710 Offset: 0x1D20110 VA: 0x181D21710
	private bool ParseValue() { }

	// RVA: 0x1D225E0 Offset: 0x1D20FE0 VA: 0x181D225E0
	private void ProcessLineFeed() { }

	// RVA: 0x1D22570 Offset: 0x1D20F70 VA: 0x181D22570
	private void ProcessCarriageReturn(bool append) { }

	// RVA: 0x1D1B790 Offset: 0x1D1A190 VA: 0x181D1B790
	private void EatWhitespace() { }

	// RVA: 0x1D1D3F0 Offset: 0x1D1BDF0 VA: 0x181D1D3F0
	private void ParseConstructor() { }

	// RVA: 0x1D1EA80 Offset: 0x1D1D480 VA: 0x181D1EA80
	private void ParseNumber(ReadType readType) { }

	// RVA: 0x1D1F6D0 Offset: 0x1D1E0D0 VA: 0x181D1F6D0
	private void ParseReadNumber(ReadType readType, char firstChar, int initialPosition) { }

	// RVA: 0x1D283F0 Offset: 0x1D26DF0 VA: 0x181D283F0
	private JsonReaderException ThrowReaderError(string message, Exception ex) { }

	// RVA: 0x1D1A170 Offset: 0x1D18B70 VA: 0x181D1A170
	private static object BigIntegerParse(string number, CultureInfo culture) { }

	// RVA: 0x1D1CF10 Offset: 0x1D1B910 VA: 0x181D1CF10
	private void ParseComment(bool setToken) { }

	// RVA: 0x1D1B8F0 Offset: 0x1D1A2F0 VA: 0x181D1B8F0
	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	// RVA: 0x1D1CCF0 Offset: 0x1D1B6F0 VA: 0x181D1CCF0
	private bool MatchValue(string value) { }

	// RVA: 0x1D1CC10 Offset: 0x1D1B610 VA: 0x181D1CC10
	private bool MatchValue(bool enoughChars, string value) { }

	// RVA: 0x1D1C9C0 Offset: 0x1D1B3C0 VA: 0x181D1C9C0
	private bool MatchValueWithTrailingSeparator(string value) { }

	// RVA: 0x1D1C4A0 Offset: 0x1D1AEA0 VA: 0x181D1C4A0
	private bool IsSeparator(char c) { }

	// RVA: 0x1D20DA0 Offset: 0x1D1F7A0 VA: 0x181D20DA0
	private void ParseTrue() { }

	// RVA: 0x1D1DA10 Offset: 0x1D1C410 VA: 0x181D1DA10
	private void ParseNull() { }

	// RVA: 0x1D20F10 Offset: 0x1D1F910 VA: 0x181D20F10
	private void ParseUndefined() { }

	// RVA: 0x1D1D8A0 Offset: 0x1D1C2A0 VA: 0x181D1D8A0
	private void ParseFalse() { }

	// RVA: 0x1D1E3A0 Offset: 0x1D1CDA0 VA: 0x181D1E3A0
	private object ParseNumberNegativeInfinity(ReadType readType) { }

	// RVA: 0x1D1E1F0 Offset: 0x1D1CBF0 VA: 0x181D1E1F0
	private object ParseNumberNegativeInfinity(ReadType readType, bool matched) { }

	// RVA: 0x1D1E880 Offset: 0x1D1D280 VA: 0x181D1E880
	private object ParseNumberPositiveInfinity(ReadType readType) { }

	// RVA: 0x1D1E6D0 Offset: 0x1D1D0D0 VA: 0x181D1E6D0
	private object ParseNumberPositiveInfinity(ReadType readType, bool matched) { }

	// RVA: 0x1D1DD10 Offset: 0x1D1C710 VA: 0x181D1DD10
	private object ParseNumberNaN(ReadType readType) { }

	// RVA: 0x1D1DF10 Offset: 0x1D1C910 VA: 0x181D1DF10
	private object ParseNumberNaN(ReadType readType, bool matched) { }

	// RVA: 0x1D1A230 Offset: 0x1D18C30 VA: 0x181D1A230 Slot: 31
	public override void Close() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 32
	public bool HasLineInfo() { }

	// RVA: 0x1D286A0 Offset: 0x1D270A0 VA: 0x181D286A0 Slot: 33
	public int get_LineNumber() { }

	// RVA: 0x1D286F0 Offset: 0x1D270F0 VA: 0x181D286F0 Slot: 34
	public int get_LinePosition() { }
}
