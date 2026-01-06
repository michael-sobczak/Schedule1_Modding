public abstract class JsonReader : IDisposable // TypeDefIndex: 11008
{
	// Fields
	private JsonToken _tokenType; // 0x10
	private object _value; // 0x18
	internal char _quoteChar; // 0x20
	internal JsonReader.State _currentState; // 0x24
	private JsonPosition _currentPosition; // 0x28
	private CultureInfo _culture; // 0x40
	private DateTimeZoneHandling _dateTimeZoneHandling; // 0x48
	private Nullable<int> _maxDepth; // 0x4C
	private bool _hasExceededMaxDepth; // 0x54
	internal DateParseHandling _dateParseHandling; // 0x58
	internal FloatParseHandling _floatParseHandling; // 0x5C
	private string _dateFormatString; // 0x60
	private List<JsonPosition> _stack; // 0x68
	[CompilerGenerated]
	private bool <CloseInput>k__BackingField; // 0x70
	[CompilerGenerated]
	private bool <SupportMultipleContent>k__BackingField; // 0x71

	// Properties
	protected JsonReader.State CurrentState { get; }
	public bool CloseInput { get; set; }
	public bool SupportMultipleContent { get; set; }
	public virtual char QuoteChar { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public DateParseHandling DateParseHandling { get; set; }
	public FloatParseHandling FloatParseHandling { get; set; }
	public string DateFormatString { get; set; }
	public Nullable<int> MaxDepth { get; set; }
	public virtual JsonToken TokenType { get; }
	public virtual object Value { get; }
	public virtual Type ValueType { get; }
	public virtual int Depth { get; }
	[Nullable(1)]
	public virtual string Path { get; }
	[Nullable(1)]
	public CultureInfo Culture { get; set; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1D12A60 Offset: 0x1D11460 VA: 0x181D12A60 Slot: 5
	public virtual Task<bool> ReadAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	[AsyncStateMachine(typeof(JsonReader.<SkipAsync>d__1))]
	// RVA: 0x1D14380 Offset: 0x1D12D80 VA: 0x181D14380
	public Task SkipAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonReader.<ReaderReadAndAssertAsync>d__2))]
	[NullableContext(1)]
	// RVA: 0x1D13EA0 Offset: 0x1D128A0 VA: 0x181D13EA0
	internal Task ReaderReadAndAssertAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	// RVA: 0x1D10610 Offset: 0x1D0F010 VA: 0x181D10610 Slot: 6
	public virtual Task<Nullable<bool>> ReadAsBooleanAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D10AB0 Offset: 0x1D0F4B0 VA: 0x181D10AB0 Slot: 7
	public virtual Task<byte[]> ReadAsBytesAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonReader.<ReadArrayIntoByteArrayAsync>d__5))]
	// RVA: 0x1D103F0 Offset: 0x1D0EDF0 VA: 0x181D103F0
	internal Task<byte[]> ReadArrayIntoByteArrayAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	// RVA: 0x1D10FE0 Offset: 0x1D0F9E0 VA: 0x181D10FE0 Slot: 8
	public virtual Task<Nullable<DateTime>> ReadAsDateTimeAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	// RVA: 0x1D110C0 Offset: 0x1D0FAC0 VA: 0x181D110C0 Slot: 9
	public virtual Task<Nullable<DateTimeOffset>> ReadAsDateTimeOffsetAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	// RVA: 0x1D117E0 Offset: 0x1D101E0 VA: 0x181D117E0 Slot: 10
	public virtual Task<Nullable<Decimal>> ReadAsDecimalAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	// RVA: 0x1D11D80 Offset: 0x1D10780 VA: 0x181D11D80 Slot: 11
	public virtual Task<Nullable<double>> ReadAsDoubleAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	// RVA: 0x1D121A0 Offset: 0x1D10BA0 VA: 0x181D121A0 Slot: 12
	public virtual Task<Nullable<int>> ReadAsInt32Async(CancellationToken cancellationToken) { }

	// RVA: 0x1D12690 Offset: 0x1D11090 VA: 0x181D12690 Slot: 13
	public virtual Task<string> ReadAsStringAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonReader.<ReadAndMoveToContentAsync>d__12))]
	[NullableContext(1)]
	// RVA: 0x1D10020 Offset: 0x1D0EA20 VA: 0x181D10020
	internal Task<bool> ReadAndMoveToContentAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	// RVA: 0x1D0F820 Offset: 0x1D0E220 VA: 0x181D0F820
	internal Task<bool> MoveToContentAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	[AsyncStateMachine(typeof(JsonReader.<MoveToContentFromNonContentAsync>d__14))]
	// RVA: 0x1D0F9B0 Offset: 0x1D0E3B0 VA: 0x181D0F9B0
	private Task<bool> MoveToContentFromNonContentAsync(CancellationToken cancellationToken) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	protected JsonReader.State get_CurrentState() { }

	[CompilerGenerated]
	// RVA: 0x83DB90 Offset: 0x83C590 VA: 0x18083DB90
	public bool get_CloseInput() { }

	[CompilerGenerated]
	// RVA: 0x83DBC0 Offset: 0x83C5C0 VA: 0x18083DBC0
	public void set_CloseInput(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1D14B40 Offset: 0x1D13540 VA: 0x181D14B40
	public bool get_SupportMultipleContent() { }

	[CompilerGenerated]
	// RVA: 0x1D14D80 Offset: 0x1D13780 VA: 0x181D14D80
	public void set_SupportMultipleContent(bool value) { }

	// RVA: 0xCC4E70 Offset: 0xCC3870 VA: 0x180CC4E70 Slot: 14
	public virtual char get_QuoteChar() { }

	// RVA: 0xCC4EA0 Offset: 0xCC38A0 VA: 0x180CC4EA0 Slot: 15
	protected internal virtual void set_QuoteChar(char value) { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0x1D14BE0 Offset: 0x1D135E0 VA: 0x181D14BE0
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	public DateParseHandling get_DateParseHandling() { }

	// RVA: 0x1D14B70 Offset: 0x1D13570 VA: 0x181D14B70
	public void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0x54CEC0 Offset: 0x54B8C0 VA: 0x18054CEC0
	public FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0x1D14C50 Offset: 0x1D13650 VA: 0x181D14C50
	public void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public string get_DateFormatString() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_DateFormatString(string value) { }

	// RVA: 0x1D14A20 Offset: 0x1D13420 VA: 0x181D14A20
	public Nullable<int> get_MaxDepth() { }

	// RVA: 0x1D14CC0 Offset: 0x1D136C0 VA: 0x181D14CC0
	public void set_MaxDepth(Nullable<int> value) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 16
	public virtual JsonToken get_TokenType() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 17
	public virtual object get_Value() { }

	// RVA: 0x1D14B50 Offset: 0x1D13550 VA: 0x181D14B50 Slot: 18
	public virtual Type get_ValueType() { }

	// RVA: 0x1D149B0 Offset: 0x1D133B0 VA: 0x181D149B0 Slot: 19
	public virtual int get_Depth() { }

	[NullableContext(1)]
	// RVA: 0x1D14A30 Offset: 0x1D13430 VA: 0x181D14A30 Slot: 20
	public virtual string get_Path() { }

	[NullableContext(1)]
	// RVA: 0x1D14950 Offset: 0x1D13350 VA: 0x181D14950
	public CultureInfo get_Culture() { }

	[NullableContext(1)]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_Culture(CultureInfo value) { }

	// RVA: 0x1D0F680 Offset: 0x1D0E080 VA: 0x181D0F680
	internal JsonPosition GetPosition(int depth) { }

	// RVA: 0x1D148D0 Offset: 0x1D132D0 VA: 0x181D148D0
	protected void .ctor() { }

	// RVA: 0x1D0FC70 Offset: 0x1D0E670 VA: 0x181D0FC70
	private void Push(JsonContainerType value) { }

	// RVA: 0x1D0FB30 Offset: 0x1D0E530 VA: 0x181D0FB30
	private JsonContainerType Pop() { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	private JsonContainerType Peek() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract bool Read();

	// RVA: 0x1D12270 Offset: 0x1D10C70 VA: 0x181D12270 Slot: 22
	public virtual Nullable<int> ReadAsInt32() { }

	// RVA: 0x1D13A40 Offset: 0x1D12440 VA: 0x181D13A40
	internal Nullable<int> ReadInt32String(string s) { }

	// RVA: 0x1D12760 Offset: 0x1D11160 VA: 0x181D12760 Slot: 23
	public virtual string ReadAsString() { }

	// RVA: 0x1D10B80 Offset: 0x1D0F580 VA: 0x181D10B80 Slot: 24
	public virtual byte[] ReadAsBytes() { }

	[NullableContext(1)]
	// RVA: 0x1D10510 Offset: 0x1D0EF10 VA: 0x181D10510
	internal byte[] ReadArrayIntoByteArray() { }

	[NullableContext(1)]
	// RVA: 0x1D101A0 Offset: 0x1D0EBA0 VA: 0x181D101A0
	private bool ReadArrayElementIntoByteArrayReportDone(List<byte> buffer) { }

	// RVA: 0x1D11E10 Offset: 0x1D10810 VA: 0x181D11E10 Slot: 25
	public virtual Nullable<double> ReadAsDouble() { }

	// RVA: 0x1D13550 Offset: 0x1D11F50 VA: 0x181D13550
	internal Nullable<double> ReadDoubleString(string s) { }

	// RVA: 0x1D106E0 Offset: 0x1D0F0E0 VA: 0x181D106E0 Slot: 26
	public virtual Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x1D12B10 Offset: 0x1D11510 VA: 0x181D12B10
	internal Nullable<bool> ReadBooleanString(string s) { }

	// RVA: 0x1D118D0 Offset: 0x1D102D0 VA: 0x181D118D0 Slot: 27
	public virtual Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x1D13260 Offset: 0x1D11C60 VA: 0x181D13260
	internal Nullable<Decimal> ReadDecimalString(string s) { }

	// RVA: 0x1D114E0 Offset: 0x1D0FEE0 VA: 0x181D114E0 Slot: 28
	public virtual Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0x1D12FB0 Offset: 0x1D119B0 VA: 0x181D12FB0
	internal Nullable<DateTime> ReadDateTimeString(string s) { }

	// RVA: 0x1D111B0 Offset: 0x1D0FBB0 VA: 0x181D111B0 Slot: 29
	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x1D12CA0 Offset: 0x1D116A0 VA: 0x181D12CA0
	internal Nullable<DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	// RVA: 0x1D13F90 Offset: 0x1D12990 VA: 0x181D13F90
	internal void ReaderReadAndAssert() { }

	[NullableContext(1)]
	// RVA: 0x1D0F5A0 Offset: 0x1D0DFA0 VA: 0x181D0F5A0
	internal JsonReaderException CreateUnexpectedEndException() { }

	// RVA: 0x1D13C00 Offset: 0x1D12600 VA: 0x181D13C00
	internal void ReadIntoWrappedTypeObject() { }

	// RVA: 0x1D14480 Offset: 0x1D12E80 VA: 0x181D14480
	public void Skip() { }

	// RVA: 0x1D14360 Offset: 0x1D12D60 VA: 0x181D14360
	protected void SetToken(JsonToken newToken) { }

	// RVA: 0x1D14340 Offset: 0x1D12D40 VA: 0x181D14340
	protected void SetToken(JsonToken newToken, object value) { }

	// RVA: 0x1D14140 Offset: 0x1D12B40 VA: 0x181D14140
	protected void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	// RVA: 0x1D14000 Offset: 0x1D12A00 VA: 0x181D14000
	internal void SetPostValueState(bool updateIndex) { }

	// RVA: 0x1D145B0 Offset: 0x1D12FB0 VA: 0x181D145B0
	private void UpdateScopeWithFinishedValue() { }

	// RVA: 0x1D145C0 Offset: 0x1D12FC0 VA: 0x181D145C0
	private void ValidateEnd(JsonToken endToken) { }

	// RVA: 0x1D14030 Offset: 0x1D12A30 VA: 0x181D14030
	protected void SetStateBasedOnCurrent() { }

	// RVA: 0x1D13FE0 Offset: 0x1D129E0 VA: 0x181D13FE0
	private void SetFinished() { }

	// RVA: 0x1D0F730 Offset: 0x1D0E130 VA: 0x181D0F730
	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	// RVA: 0x1D14540 Offset: 0x1D12F40 VA: 0x181D14540 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1D0F5E0 Offset: 0x1D0DFE0 VA: 0x181D0F5E0 Slot: 30
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1D0F580 Offset: 0x1D0DF80 VA: 0x181D0F580 Slot: 31
	public virtual void Close() { }

	// RVA: 0x1D0FFC0 Offset: 0x1D0E9C0 VA: 0x181D0FFC0
	internal void ReadAndAssert() { }

	// RVA: 0x1D13720 Offset: 0x1D12120 VA: 0x181D13720
	internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter) { }

	// RVA: 0x1D13770 Offset: 0x1D12170 VA: 0x181D13770
	internal bool ReadForType(JsonContract contract, bool hasConverter) { }

	// RVA: 0x1D10140 Offset: 0x1D0EB40 VA: 0x181D10140
	internal bool ReadAndMoveToContent() { }

	// RVA: 0x1D0FAD0 Offset: 0x1D0E4D0 VA: 0x181D0FAD0
	internal bool MoveToContent() { }

	// RVA: 0x1D0F610 Offset: 0x1D0E010 VA: 0x181D0F610
	private JsonToken GetContentToken() { }
}
