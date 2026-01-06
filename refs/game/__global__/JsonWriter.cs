public abstract class JsonWriter : IDisposable // TypeDefIndex: 11091
{
	// Fields
	private static readonly JsonWriter.State[][] StateArray; // 0x0
	internal static readonly JsonWriter.State[][] StateArrayTemplate; // 0x8
	[Nullable(2)]
	private List<JsonPosition> _stack; // 0x10
	private JsonPosition _currentPosition; // 0x18
	private JsonWriter.State _currentState; // 0x30
	private Formatting _formatting; // 0x34
	[CompilerGenerated]
	private bool <CloseOutput>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <AutoCompleteOnClose>k__BackingField; // 0x39
	private DateFormatHandling _dateFormatHandling; // 0x3C
	private DateTimeZoneHandling _dateTimeZoneHandling; // 0x40
	private StringEscapeHandling _stringEscapeHandling; // 0x44
	private FloatFormatHandling _floatFormatHandling; // 0x48
	[Nullable(2)]
	private string _dateFormatString; // 0x50
	[Nullable(2)]
	private CultureInfo _culture; // 0x58

	// Properties
	public bool CloseOutput { get; set; }
	public bool AutoCompleteOnClose { get; set; }
	protected internal int Top { get; }
	public WriteState WriteState { get; }
	internal string ContainerPath { get; }
	public string Path { get; }
	public Formatting Formatting { get; set; }
	public DateFormatHandling DateFormatHandling { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public StringEscapeHandling StringEscapeHandling { get; set; }
	public FloatFormatHandling FloatFormatHandling { get; set; }
	[Nullable(2)]
	public string DateFormatString { get; set; }
	public CultureInfo Culture { get; set; }

	// Methods

	// RVA: 0x1D45E60 Offset: 0x1D44860 VA: 0x181D45E60
	internal Task AutoCompleteAsync(JsonToken tokenBeingWritten, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<AutoCompleteAsync>d__1))]
	// RVA: 0x1D46160 Offset: 0x1D44B60 VA: 0x181D46160
	private Task AutoCompleteAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D46910 Offset: 0x1D45310 VA: 0x181D46910 Slot: 5
	public virtual Task CloseAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D46B30 Offset: 0x1D45530 VA: 0x181D46B30 Slot: 6
	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D489B0 Offset: 0x1D473B0 VA: 0x181D489B0 Slot: 7
	protected virtual Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	// RVA: 0x1D48FC0 Offset: 0x1D479C0 VA: 0x181D48FC0 Slot: 8
	protected virtual Task WriteIndentAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D4EA90 Offset: 0x1D4D490 VA: 0x181D4EA90 Slot: 9
	protected virtual Task WriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D49090 Offset: 0x1D47A90 VA: 0x181D49090 Slot: 10
	protected virtual Task WriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D49450 Offset: 0x1D47E50 VA: 0x181D49450 Slot: 11
	public virtual Task WriteRawAsync(string json, CancellationToken cancellationToken) { }

	// RVA: 0x1D488E0 Offset: 0x1D472E0 VA: 0x181D488E0 Slot: 12
	public virtual Task WriteEndAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D48B70 Offset: 0x1D47570 VA: 0x181D48B70
	internal Task WriteEndInternalAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D46CE0 Offset: 0x1D456E0 VA: 0x181D46CE0
	internal Task InternalWriteEndAsync(JsonContainerType type, CancellationToken cancellationToken) { }

	// RVA: 0x1D48800 Offset: 0x1D47200 VA: 0x181D48800 Slot: 13
	public virtual Task WriteEndArrayAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D48A90 Offset: 0x1D47490 VA: 0x181D48A90 Slot: 14
	public virtual Task WriteEndConstructorAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D48CF0 Offset: 0x1D476F0 VA: 0x181D48CF0 Slot: 15
	public virtual Task WriteEndObjectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D49160 Offset: 0x1D47B60 VA: 0x181D49160 Slot: 16
	public virtual Task WriteNullAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D49250 Offset: 0x1D47C50 VA: 0x181D49250 Slot: 17
	public virtual Task WritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	// RVA: 0x1D49330 Offset: 0x1D47D30 VA: 0x181D49330 Slot: 18
	public virtual Task WritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken) { }

	// RVA: 0x1D46F60 Offset: 0x1D45960 VA: 0x181D46F60
	internal Task InternalWritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	// RVA: 0x1D49660 Offset: 0x1D48060 VA: 0x181D49660 Slot: 19
	public virtual Task WriteStartArrayAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<InternalWriteStartAsync>d__20))]
	// RVA: 0x1D47060 Offset: 0x1D45A60 VA: 0x181D47060
	internal Task InternalWriteStartAsync(JsonToken token, JsonContainerType container, CancellationToken cancellationToken) { }

	// RVA: 0x1D48540 Offset: 0x1D46F40 VA: 0x181D48540 Slot: 20
	public virtual Task WriteCommentAsync(string text, CancellationToken cancellationToken) { }

	// RVA: 0x1D46CC0 Offset: 0x1D456C0 VA: 0x181D46CC0
	internal Task InternalWriteCommentAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D49530 Offset: 0x1D47F30 VA: 0x181D49530 Slot: 21
	public virtual Task WriteRawValueAsync(string json, CancellationToken cancellationToken) { }

	// RVA: 0x1D49740 Offset: 0x1D48140 VA: 0x181D49740 Slot: 22
	public virtual Task WriteStartConstructorAsync(string name, CancellationToken cancellationToken) { }

	// RVA: 0x1D49830 Offset: 0x1D48230 VA: 0x181D49830 Slot: 23
	public virtual Task WriteStartObjectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D49A50 Offset: 0x1D48450 VA: 0x181D49A50
	public Task WriteTokenAsync(JsonReader reader, CancellationToken cancellationToken) { }

	// RVA: 0x1D4A4D0 Offset: 0x1D48ED0 VA: 0x181D4A4D0
	public Task WriteTokenAsync(JsonReader reader, bool writeChildren, CancellationToken cancellationToken) { }

	// RVA: 0x1D4A570 Offset: 0x1D48F70 VA: 0x181D4A570
	public Task WriteTokenAsync(JsonToken token, CancellationToken cancellationToken) { }

	// RVA: 0x1D49AE0 Offset: 0x1D484E0 VA: 0x181D49AE0
	public Task WriteTokenAsync(JsonToken token, object value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<WriteTokenAsync>d__30))]
	// RVA: 0x1D49910 Offset: 0x1D48310 VA: 0x181D49910 Slot: 24
	internal virtual Task WriteTokenAsync(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<WriteTokenSyncReadingAsync>d__31))]
	// RVA: 0x1D4A590 Offset: 0x1D48F90 VA: 0x181D4A590
	internal Task WriteTokenSyncReadingAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<WriteConstructorDateAsync>d__32))]
	// RVA: 0x1D48620 Offset: 0x1D47020 VA: 0x181D48620
	private Task WriteConstructorDateAsync(JsonReader reader, CancellationToken cancellationToken) { }

	// RVA: 0x1D4D120 Offset: 0x1D4BB20 VA: 0x181D4D120 Slot: 25
	public virtual Task WriteValueAsync(bool value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4BD80 Offset: 0x1D4A780 VA: 0x181D4BD80 Slot: 26
	public virtual Task WriteValueAsync(Nullable<bool> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4BCA0 Offset: 0x1D4A6A0 VA: 0x181D4BCA0 Slot: 27
	public virtual Task WriteValueAsync(byte value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4CAE0 Offset: 0x1D4B4E0 VA: 0x181D4CAE0 Slot: 28
	public virtual Task WriteValueAsync(Nullable<byte> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4BBC0 Offset: 0x1D4A5C0 VA: 0x181D4BBC0 Slot: 29
	public virtual Task WriteValueAsync(byte[] value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4C590 Offset: 0x1D4AF90 VA: 0x181D4C590 Slot: 30
	public virtual Task WriteValueAsync(char value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4CCA0 Offset: 0x1D4B6A0 VA: 0x181D4CCA0 Slot: 31
	public virtual Task WriteValueAsync(Nullable<char> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4BF40 Offset: 0x1D4A940 VA: 0x181D4BF40 Slot: 32
	public virtual Task WriteValueAsync(DateTime value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4E6E0 Offset: 0x1D4D0E0 VA: 0x181D4E6E0 Slot: 33
	public virtual Task WriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4C4A0 Offset: 0x1D4AEA0 VA: 0x181D4C4A0 Slot: 34
	public virtual Task WriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4E8B0 Offset: 0x1D4D2B0 VA: 0x181D4E8B0 Slot: 35
	public virtual Task WriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4CD80 Offset: 0x1D4B780 VA: 0x181D4CD80 Slot: 36
	public virtual Task WriteValueAsync(Decimal value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4C020 Offset: 0x1D4AA20 VA: 0x181D4C020 Slot: 37
	public virtual Task WriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4C3C0 Offset: 0x1D4ADC0 VA: 0x181D4C3C0 Slot: 38
	public virtual Task WriteValueAsync(double value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4B570 Offset: 0x1D49F70 VA: 0x181D4B570 Slot: 39
	public virtual Task WriteValueAsync(Nullable<double> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4C2E0 Offset: 0x1D4ACE0 VA: 0x181D4C2E0 Slot: 40
	public virtual Task WriteValueAsync(float value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4C920 Offset: 0x1D4B320 VA: 0x181D4C920 Slot: 41
	public virtual Task WriteValueAsync(Nullable<float> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4B9E0 Offset: 0x1D4A3E0 VA: 0x181D4B9E0 Slot: 42
	public virtual Task WriteValueAsync(Guid value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4D030 Offset: 0x1D4BA30 VA: 0x181D4D030 Slot: 43
	public virtual Task WriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4E9B0 Offset: 0x1D4D3B0 VA: 0x181D4E9B0 Slot: 44
	public virtual Task WriteValueAsync(int value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4C120 Offset: 0x1D4AB20 VA: 0x181D4C120 Slot: 45
	public virtual Task WriteValueAsync(Nullable<int> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4C760 Offset: 0x1D4B160 VA: 0x181D4C760 Slot: 46
	public virtual Task WriteValueAsync(long value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4B480 Offset: 0x1D49E80 VA: 0x181D4B480 Slot: 47
	public virtual Task WriteValueAsync(Nullable<long> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4BE60 Offset: 0x1D4A860 VA: 0x181D4BE60 Slot: 48
	public virtual Task WriteValueAsync(object value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x1D4E7D0 Offset: 0x1D4D1D0 VA: 0x181D4E7D0 Slot: 49
	public virtual Task WriteValueAsync(sbyte value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x1D4B900 Offset: 0x1D4A300 VA: 0x181D4B900 Slot: 50
	public virtual Task WriteValueAsync(Nullable<sbyte> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4C200 Offset: 0x1D4AC00 VA: 0x181D4C200 Slot: 51
	public virtual Task WriteValueAsync(short value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4CE70 Offset: 0x1D4B870 VA: 0x181D4CE70 Slot: 52
	public virtual Task WriteValueAsync(Nullable<short> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4C840 Offset: 0x1D4B240 VA: 0x181D4C840 Slot: 53
	public virtual Task WriteValueAsync(string value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4CA00 Offset: 0x1D4B400 VA: 0x181D4CA00 Slot: 54
	public virtual Task WriteValueAsync(TimeSpan value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4C670 Offset: 0x1D4B070 VA: 0x181D4C670 Slot: 55
	public virtual Task WriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x1D4D200 Offset: 0x1D4BC00 VA: 0x181D4D200 Slot: 56
	public virtual Task WriteValueAsync(uint value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x1D4CBC0 Offset: 0x1D4B5C0 VA: 0x181D4CBC0 Slot: 57
	public virtual Task WriteValueAsync(Nullable<uint> value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x1D4CF50 Offset: 0x1D4B950 VA: 0x181D4CF50 Slot: 58
	public virtual Task WriteValueAsync(ulong value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x1D4BAD0 Offset: 0x1D4A4D0 VA: 0x181D4BAD0 Slot: 59
	public virtual Task WriteValueAsync(Nullable<ulong> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4B820 Offset: 0x1D4A220 VA: 0x181D4B820 Slot: 60
	public virtual Task WriteValueAsync(Uri value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x1D4B660 Offset: 0x1D4A060 VA: 0x181D4B660 Slot: 61
	public virtual Task WriteValueAsync(ushort value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x1D4B740 Offset: 0x1D4A140 VA: 0x181D4B740 Slot: 62
	public virtual Task WriteValueAsync(Nullable<ushort> value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4B390 Offset: 0x1D49D90 VA: 0x181D4B390 Slot: 63
	public virtual Task WriteUndefinedAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1D50AA0 Offset: 0x1D4F4A0 VA: 0x181D50AA0 Slot: 64
	public virtual Task WriteWhitespaceAsync(string ws, CancellationToken cancellationToken) { }

	// RVA: 0x1D47310 Offset: 0x1D45D10 VA: 0x181D47310
	internal Task InternalWriteValueAsync(JsonToken token, CancellationToken cancellationToken) { }

	// RVA: 0x1D47950 Offset: 0x1D46350 VA: 0x181D47950
	protected Task SetWriteStateAsync(JsonToken token, object value, CancellationToken cancellationToken) { }

	// RVA: 0x1D4D2E0 Offset: 0x1D4BCE0 VA: 0x181D4D2E0
	internal static Task WriteValueAsync(JsonWriter writer, PrimitiveTypeCode typeCode, object value, CancellationToken cancellationToken) { }

	// RVA: 0x1D46540 Offset: 0x1D44F40 VA: 0x181D46540
	internal static JsonWriter.State[][] BuildStateArray() { }

	// RVA: 0x1D50B80 Offset: 0x1D4F580 VA: 0x181D50B80
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_CloseOutput() { }

	[CompilerGenerated]
	// RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	public void set_CloseOutput(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8D2180 Offset: 0x8D0B80 VA: 0x1808D2180
	public bool get_AutoCompleteOnClose() { }

	[CompilerGenerated]
	// RVA: 0xCD74A0 Offset: 0xCD5EA0 VA: 0x180CD74A0
	public void set_AutoCompleteOnClose(bool value) { }

	// RVA: 0x1D510E0 Offset: 0x1D4FAE0 VA: 0x181D510E0
	protected internal int get_Top() { }

	// RVA: 0x1D51140 Offset: 0x1D4FB40 VA: 0x181D51140
	public WriteState get_WriteState() { }

	// RVA: 0x1D50ED0 Offset: 0x1D4F8D0 VA: 0x181D50ED0
	internal string get_ContainerPath() { }

	// RVA: 0x1D50FD0 Offset: 0x1D4F9D0 VA: 0x181D50FD0
	public string get_Path() { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public Formatting get_Formatting() { }

	// RVA: 0x1D513B0 Offset: 0x1D4FDB0 VA: 0x181D513B0
	public void set_Formatting(Formatting value) { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	public DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0x1D51260 Offset: 0x1D4FC60 VA: 0x181D51260
	public void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0x1D512D0 Offset: 0x1D4FCD0 VA: 0x181D512D0
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x594500 Offset: 0x592F00 VA: 0x180594500
	public StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0x1D51420 Offset: 0x1D4FE20 VA: 0x181D51420
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 65
	internal virtual void OnStringEscapeHandlingChanged() { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0x1D51340 Offset: 0x1D4FD40 VA: 0x181D51340
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	[NullableContext(2)]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_DateFormatString() { }

	[NullableContext(2)]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_DateFormatString(string value) { }

	// RVA: 0x1D50F70 Offset: 0x1D4F970 VA: 0x181D50F70
	public CultureInfo get_Culture() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_Culture(CultureInfo value) { }

	// RVA: 0x1D50EA0 Offset: 0x1D4F8A0 VA: 0x181D50EA0
	protected void .ctor() { }

	// RVA: 0x1D48530 Offset: 0x1D46F30 VA: 0x181D48530
	internal void UpdateScopeWithFinishedValue() { }

	// RVA: 0x1D47640 Offset: 0x1D46040 VA: 0x181D47640
	private void Push(JsonContainerType value) { }

	// RVA: 0x1D47530 Offset: 0x1D45F30 VA: 0x181D47530
	private JsonContainerType Pop() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	private JsonContainerType Peek() { }

	// RVA: -1 Offset: -1 Slot: 66
	public abstract void Flush();

	// RVA: 0x1D469E0 Offset: 0x1D453E0 VA: 0x181D469E0 Slot: 67
	public virtual void Close() { }

	// RVA: 0x1D49900 Offset: 0x1D48300 VA: 0x181D49900 Slot: 68
	public virtual void WriteStartObject() { }

	// RVA: 0x1D48DC0 Offset: 0x1D477C0 VA: 0x181D48DC0 Slot: 69
	public virtual void WriteEndObject() { }

	// RVA: 0x1D49730 Offset: 0x1D48130 VA: 0x181D49730 Slot: 70
	public virtual void WriteStartArray() { }

	// RVA: 0x1D488D0 Offset: 0x1D472D0 VA: 0x181D488D0 Slot: 71
	public virtual void WriteEndArray() { }

	// RVA: 0x1D49820 Offset: 0x1D48220 VA: 0x181D49820 Slot: 72
	public virtual void WriteStartConstructor(string name) { }

	// RVA: 0x1D48B60 Offset: 0x1D47560 VA: 0x181D48B60 Slot: 73
	public virtual void WriteEndConstructor() { }

	// RVA: 0x1D47030 Offset: 0x1D45A30 VA: 0x181D47030 Slot: 74
	public virtual void WritePropertyName(string name) { }

	// RVA: 0x1D49430 Offset: 0x1D47E30 VA: 0x181D49430 Slot: 75
	public virtual void WritePropertyName(string name, bool escape) { }

	// RVA: 0x1D48DD0 Offset: 0x1D477D0 VA: 0x181D48DD0 Slot: 76
	public virtual void WriteEnd() { }

	// RVA: 0x1D4AA20 Offset: 0x1D49420 VA: 0x181D4AA20
	public void WriteToken(JsonReader reader) { }

	// RVA: 0x1D4B300 Offset: 0x1D49D00 VA: 0x181D4B300
	public void WriteToken(JsonReader reader, bool writeChildren) { }

	[NullableContext(2)]
	// RVA: 0x1D4AA40 Offset: 0x1D49440 VA: 0x181D4AA40
	public void WriteToken(JsonToken token, object value) { }

	// RVA: 0x1D4AA30 Offset: 0x1D49430 VA: 0x181D4AA30
	public void WriteToken(JsonToken token) { }

	// RVA: 0x1D4A6B0 Offset: 0x1D490B0 VA: 0x181D4A6B0 Slot: 77
	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	// RVA: 0x1D47450 Offset: 0x1D45E50 VA: 0x181D47450
	private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth) { }

	// RVA: 0x1D468A0 Offset: 0x1D452A0 VA: 0x181D468A0
	private int CalculateWriteTokenInitialDepth(JsonReader reader) { }

	// RVA: 0x1D46830 Offset: 0x1D45230 VA: 0x181D46830
	private int CalculateWriteTokenFinalDepth(JsonReader reader) { }

	// RVA: 0x1D48740 Offset: 0x1D47140 VA: 0x181D48740
	private void WriteConstructorDate(JsonReader reader) { }

	// RVA: 0x1D48ED0 Offset: 0x1D478D0 VA: 0x181D48ED0
	private void WriteEnd(JsonContainerType type) { }

	// RVA: 0x1D45DF0 Offset: 0x1D447F0 VA: 0x181D45DF0
	private void AutoCompleteAll() { }

	// RVA: 0x1D46C00 Offset: 0x1D45600 VA: 0x181D46C00
	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	// RVA: 0x1D46250 Offset: 0x1D44C50 VA: 0x181D46250
	private void AutoCompleteClose(JsonContainerType type) { }

	// RVA: 0x1D46730 Offset: 0x1D45130 VA: 0x181D46730
	private int CalculateLevelsToComplete(JsonContainerType type) { }

	// RVA: 0x1D48460 Offset: 0x1D46E60 VA: 0x181D48460
	private void UpdateCurrentState() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 78
	protected virtual void WriteEnd(JsonToken token) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 79
	protected virtual void WriteIndent() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 80
	protected virtual void WriteValueDelimiter() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 81
	protected virtual void WriteIndentSpace() { }

	// RVA: 0x1D46310 Offset: 0x1D44D10 VA: 0x181D46310
	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	// RVA: 0x1D49230 Offset: 0x1D47C30 VA: 0x181D49230 Slot: 82
	public virtual void WriteNull() { }

	// RVA: 0x1D4B460 Offset: 0x1D49E60 VA: 0x181D4B460 Slot: 83
	public virtual void WriteUndefined() { }

	[NullableContext(2)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 84
	public virtual void WriteRaw(string json) { }

	[NullableContext(2)]
	// RVA: 0x1D49610 Offset: 0x1D48010 VA: 0x181D49610 Slot: 85
	public virtual void WriteRawValue(string json) { }

	[NullableContext(2)]
	// RVA: 0x1D4EF80 Offset: 0x1D4D980 VA: 0x181D4EF80 Slot: 86
	public virtual void WriteValue(string value) { }

	// RVA: 0x1D4EBE0 Offset: 0x1D4D5E0 VA: 0x181D4EBE0 Slot: 87
	public virtual void WriteValue(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D4EBE0 Offset: 0x1D4D5E0 VA: 0x181D4EBE0 Slot: 88
	public virtual void WriteValue(uint value) { }

	// RVA: 0x1D4EBE0 Offset: 0x1D4D5E0 VA: 0x181D4EBE0 Slot: 89
	public virtual void WriteValue(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D4EBE0 Offset: 0x1D4D5E0 VA: 0x181D4EBE0 Slot: 90
	public virtual void WriteValue(ulong value) { }

	// RVA: 0x1D4EDC0 Offset: 0x1D4D7C0 VA: 0x181D4EDC0 Slot: 91
	public virtual void WriteValue(float value) { }

	// RVA: 0x1D4EDC0 Offset: 0x1D4D7C0 VA: 0x181D4EDC0 Slot: 92
	public virtual void WriteValue(double value) { }

	// RVA: 0x1D4F0B0 Offset: 0x1D4DAB0 VA: 0x181D4F0B0 Slot: 93
	public virtual void WriteValue(bool value) { }

	// RVA: 0x1D4EBE0 Offset: 0x1D4D5E0 VA: 0x181D4EBE0 Slot: 94
	public virtual void WriteValue(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D4EBE0 Offset: 0x1D4D5E0 VA: 0x181D4EBE0 Slot: 95
	public virtual void WriteValue(ushort value) { }

	// RVA: 0x1D4EF80 Offset: 0x1D4D980 VA: 0x181D4EF80 Slot: 96
	public virtual void WriteValue(char value) { }

	// RVA: 0x1D4EBE0 Offset: 0x1D4D5E0 VA: 0x181D4EBE0 Slot: 97
	public virtual void WriteValue(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D4EBE0 Offset: 0x1D4D5E0 VA: 0x181D4EBE0 Slot: 98
	public virtual void WriteValue(sbyte value) { }

	// RVA: 0x1D4EDC0 Offset: 0x1D4D7C0 VA: 0x181D4EDC0 Slot: 99
	public virtual void WriteValue(Decimal value) { }

	// RVA: 0x1D4EC00 Offset: 0x1D4D600 VA: 0x181D4EC00 Slot: 100
	public virtual void WriteValue(DateTime value) { }

	// RVA: 0x1D4EC00 Offset: 0x1D4D600 VA: 0x181D4EC00 Slot: 101
	public virtual void WriteValue(DateTimeOffset value) { }

	// RVA: 0x1D4EF80 Offset: 0x1D4D980 VA: 0x181D4EF80 Slot: 102
	public virtual void WriteValue(Guid value) { }

	// RVA: 0x1D4EF80 Offset: 0x1D4D980 VA: 0x181D4EF80 Slot: 103
	public virtual void WriteValue(TimeSpan value) { }

	// RVA: 0x1D50900 Offset: 0x1D4F300 VA: 0x181D50900 Slot: 104
	public virtual void WriteValue(Nullable<int> value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D4EEF0 Offset: 0x1D4D8F0 VA: 0x181D4EEF0 Slot: 105
	public virtual void WriteValue(Nullable<uint> value) { }

	// RVA: 0x1D505F0 Offset: 0x1D4EFF0 VA: 0x181D505F0 Slot: 106
	public virtual void WriteValue(Nullable<long> value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D4F0D0 Offset: 0x1D4DAD0 VA: 0x181D4F0D0 Slot: 107
	public virtual void WriteValue(Nullable<ulong> value) { }

	// RVA: 0x1D4EDE0 Offset: 0x1D4D7E0 VA: 0x181D4EDE0 Slot: 108
	public virtual void WriteValue(Nullable<float> value) { }

	// RVA: 0x1D4EFA0 Offset: 0x1D4D9A0 VA: 0x181D4EFA0 Slot: 109
	public virtual void WriteValue(Nullable<double> value) { }

	// RVA: 0x1D50840 Offset: 0x1D4F240 VA: 0x181D50840 Slot: 110
	public virtual void WriteValue(Nullable<bool> value) { }

	// RVA: 0x1D4F150 Offset: 0x1D4DB50 VA: 0x181D4F150 Slot: 111
	public virtual void WriteValue(Nullable<short> value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D50A20 Offset: 0x1D4F420 VA: 0x181D50A20 Slot: 112
	public virtual void WriteValue(Nullable<ushort> value) { }

	// RVA: 0x1D4EB60 Offset: 0x1D4D560 VA: 0x181D4EB60 Slot: 113
	public virtual void WriteValue(Nullable<char> value) { }

	// RVA: 0x1D4F020 Offset: 0x1D4DA20 VA: 0x181D4F020 Slot: 114
	public virtual void WriteValue(Nullable<byte> value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D4ED30 Offset: 0x1D4D730 VA: 0x181D4ED30 Slot: 115
	public virtual void WriteValue(Nullable<sbyte> value) { }

	// RVA: 0x1D4ECA0 Offset: 0x1D4D6A0 VA: 0x181D4ECA0 Slot: 116
	public virtual void WriteValue(Nullable<Decimal> value) { }

	// RVA: 0x1D4EC20 Offset: 0x1D4D620 VA: 0x181D4EC20 Slot: 117
	public virtual void WriteValue(Nullable<DateTime> value) { }

	// RVA: 0x1D4F1D0 Offset: 0x1D4DBD0 VA: 0x181D4F1D0 Slot: 118
	public virtual void WriteValue(Nullable<DateTimeOffset> value) { }

	// RVA: 0x1D50990 Offset: 0x1D4F390 VA: 0x181D50990 Slot: 119
	public virtual void WriteValue(Nullable<Guid> value) { }

	// RVA: 0x1D4EE70 Offset: 0x1D4D870 VA: 0x181D4EE70 Slot: 120
	public virtual void WriteValue(Nullable<TimeSpan> value) { }

	[NullableContext(2)]
	// RVA: 0x1D508D0 Offset: 0x1D4F2D0 VA: 0x181D508D0 Slot: 121
	public virtual void WriteValue(byte[] value) { }

	[NullableContext(2)]
	// RVA: 0x1D50670 Offset: 0x1D4F070 VA: 0x181D50670 Slot: 122
	public virtual void WriteValue(Uri value) { }

	[NullableContext(2)]
	// RVA: 0x1D50710 Offset: 0x1D4F110 VA: 0x181D50710 Slot: 123
	public virtual void WriteValue(object value) { }

	[NullableContext(2)]
	// RVA: 0x1D46CD0 Offset: 0x1D456D0 VA: 0x181D46CD0 Slot: 124
	public virtual void WriteComment(string text) { }

	// RVA: 0x1D473F0 Offset: 0x1D45DF0 VA: 0x181D473F0 Slot: 125
	public virtual void WriteWhitespace(string ws) { }

	// RVA: 0x1D47F30 Offset: 0x1D46930 VA: 0x181D47F30 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1D46B00 Offset: 0x1D45500 VA: 0x181D46B00 Slot: 126
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1D4F260 Offset: 0x1D4DC60 VA: 0x181D4F260
	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0x1D477B0 Offset: 0x1D461B0 VA: 0x181D477B0
	private static void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out object value) { }

	// RVA: 0x1D46A50 Offset: 0x1D45450 VA: 0x181D46A50
	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	// RVA: 0x1D47CC0 Offset: 0x1D466C0 VA: 0x181D47CC0
	protected void SetWriteState(JsonToken token, object value) { }

	// RVA: 0x1D46250 Offset: 0x1D44C50 VA: 0x181D46250
	internal void InternalWriteEnd(JsonContainerType container) { }

	// RVA: 0x1D47030 Offset: 0x1D45A30 VA: 0x181D47030
	internal void InternalWritePropertyName(string name) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void InternalWriteRaw() { }

	// RVA: 0x1D47180 Offset: 0x1D45B80 VA: 0x181D47180
	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	// RVA: 0x1D473D0 Offset: 0x1D45DD0 VA: 0x181D473D0
	internal void InternalWriteValue(JsonToken token) { }

	// RVA: 0x1D473F0 Offset: 0x1D45DF0 VA: 0x181D473F0
	internal void InternalWriteWhitespace(string ws) { }

	// RVA: 0x1D46CD0 Offset: 0x1D456D0 VA: 0x181D46CD0
	internal void InternalWriteComment() { }

	[AsyncStateMachine(typeof(JsonWriter.<<InternalWriteEndAsync>g__AwaitProperty|11_0>d))]
	[CompilerGenerated]
	// RVA: 0x1D48210 Offset: 0x1D46C10 VA: 0x181D48210
	private Task <InternalWriteEndAsync>g__AwaitProperty|11_0(Task task, int LevelsToComplete, JsonToken token, CancellationToken CancellationToken) { }

	[CompilerGenerated]
	[AsyncStateMachine(typeof(JsonWriter.<<InternalWriteEndAsync>g__AwaitIndent|11_1>d))]
	// RVA: 0x1D480D0 Offset: 0x1D46AD0 VA: 0x181D480D0
	private Task <InternalWriteEndAsync>g__AwaitIndent|11_1(Task task, int LevelsToComplete, JsonToken token, CancellationToken CancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<<InternalWriteEndAsync>g__AwaitEnd|11_2>d))]
	[CompilerGenerated]
	// RVA: 0x1D47FA0 Offset: 0x1D469A0 VA: 0x181D47FA0
	private Task <InternalWriteEndAsync>g__AwaitEnd|11_2(Task task, int LevelsToComplete, CancellationToken CancellationToken) { }

	[CompilerGenerated]
	[AsyncStateMachine(typeof(JsonWriter.<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d))]
	// RVA: 0x1D48350 Offset: 0x1D46D50 VA: 0x181D48350
	private Task <InternalWriteEndAsync>g__AwaitRemaining|11_3(int LevelsToComplete, CancellationToken CancellationToken) { }
}
