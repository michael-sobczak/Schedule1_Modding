public class JTokenWriter : JsonWriter // TypeDefIndex: 11357
{
	// Fields
	private JContainer _token; // 0x60
	private JContainer _parent; // 0x68
	private JValue _value; // 0x70
	private JToken _current; // 0x78

	// Properties
	public JToken CurrentToken { get; }
	public JToken Token { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1DDD560 Offset: 0x1DDBF60 VA: 0x181DDD560 Slot: 24
	internal override Task WriteTokenAsync(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, CancellationToken cancellationToken) { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public JToken get_CurrentToken() { }

	// RVA: 0x1DDEE00 Offset: 0x1DDD800 VA: 0x181DDEE00
	public JToken get_Token() { }

	[NullableContext(1)]
	// RVA: 0x1DDED60 Offset: 0x1DDD760 VA: 0x181DDED60
	public void .ctor(JContainer container) { }

	// RVA: 0x1DDED10 Offset: 0x1DDD710 VA: 0x181DDED10
	public void .ctor() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 66
	public override void Flush() { }

	// RVA: 0x1DDD060 Offset: 0x1DDBA60 VA: 0x181DDD060 Slot: 67
	public override void Close() { }

	// RVA: 0x1DDD4C0 Offset: 0x1DDBEC0 VA: 0x181DDD4C0 Slot: 68
	public override void WriteStartObject() { }

	[NullableContext(1)]
	// RVA: 0x1DDCF30 Offset: 0x1DDB930 VA: 0x181DDCF30
	private void AddParent(JContainer container) { }

	// RVA: 0x1DDD070 Offset: 0x1DDBA70 VA: 0x181DDD070
	private void RemoveParent() { }

	// RVA: 0x1DDD370 Offset: 0x1DDBD70 VA: 0x181DDD370 Slot: 70
	public override void WriteStartArray() { }

	[NullableContext(1)]
	// RVA: 0x1DDD410 Offset: 0x1DDBE10 VA: 0x181DDD410 Slot: 72
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x1DDD070 Offset: 0x1DDBA70 VA: 0x181DDD070 Slot: 78
	protected override void WriteEnd(JsonToken token) { }

	[NullableContext(1)]
	// RVA: 0x1DDD1F0 Offset: 0x1DDBBF0 VA: 0x181DDD1F0 Slot: 74
	public override void WritePropertyName(string name) { }

	// RVA: 0x1DDCF90 Offset: 0x1DDB990 VA: 0x181DDCF90
	private void AddRawValue(object value, JTokenType type, JsonToken token) { }

	// RVA: 0x1DDCE50 Offset: 0x1DDB850 VA: 0x181DDCE50
	internal void AddJValue(JValue value, JsonToken token) { }

	// RVA: 0x1DDE170 Offset: 0x1DDCB70 VA: 0x181DDE170 Slot: 123
	public override void WriteValue(object value) { }

	// RVA: 0x1DDD1C0 Offset: 0x1DDBBC0 VA: 0x181DDD1C0 Slot: 82
	public override void WriteNull() { }

	// RVA: 0x1DDDA10 Offset: 0x1DDC410 VA: 0x181DDDA10 Slot: 83
	public override void WriteUndefined() { }

	// RVA: 0x1DDD2F0 Offset: 0x1DDBCF0 VA: 0x181DDD2F0 Slot: 84
	public override void WriteRaw(string json) { }

	// RVA: 0x1DDD100 Offset: 0x1DDBB00 VA: 0x181DDD100 Slot: 124
	public override void WriteComment(string text) { }

	// RVA: 0x1DDDBD0 Offset: 0x1DDC5D0 VA: 0x181DDDBD0 Slot: 86
	public override void WriteValue(string value) { }

	// RVA: 0x1DDE210 Offset: 0x1DDCC10 VA: 0x181DDE210 Slot: 87
	public override void WriteValue(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DDDCA0 Offset: 0x1DDC6A0 VA: 0x181DDDCA0 Slot: 88
	public override void WriteValue(uint value) { }

	// RVA: 0x1DDE290 Offset: 0x1DDCC90 VA: 0x181DDE290 Slot: 89
	public override void WriteValue(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DDDF50 Offset: 0x1DDC950 VA: 0x181DDDF50 Slot: 90
	public override void WriteValue(ulong value) { }

	// RVA: 0x1DDDE40 Offset: 0x1DDC840 VA: 0x181DDDE40 Slot: 91
	public override void WriteValue(float value) { }

	// RVA: 0x1DDEAD0 Offset: 0x1DDD4D0 VA: 0x181DDEAD0 Slot: 92
	public override void WriteValue(double value) { }

	// RVA: 0x1DDE810 Offset: 0x1DDD210 VA: 0x181DDE810 Slot: 93
	public override void WriteValue(bool value) { }

	// RVA: 0x1DDE920 Offset: 0x1DDD320 VA: 0x181DDE920 Slot: 94
	public override void WriteValue(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DDE690 Offset: 0x1DDD090 VA: 0x181DDE690 Slot: 95
	public override void WriteValue(ushort value) { }

	// RVA: 0x1DDE9A0 Offset: 0x1DDD3A0 VA: 0x181DDE9A0 Slot: 96
	public override void WriteValue(char value) { }

	// RVA: 0x1DDDB50 Offset: 0x1DDC550 VA: 0x181DDDB50 Slot: 97
	public override void WriteValue(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DDDAD0 Offset: 0x1DDC4D0 VA: 0x181DDDAD0 Slot: 98
	public override void WriteValue(sbyte value) { }

	// RVA: 0x1DDDD20 Offset: 0x1DDC720 VA: 0x181DDDD20 Slot: 99
	public override void WriteValue(Decimal value) { }

	// RVA: 0x1DDEBE0 Offset: 0x1DDD5E0 VA: 0x181DDEBE0 Slot: 100
	public override void WriteValue(DateTime value) { }

	// RVA: 0x1DDE580 Offset: 0x1DDCF80 VA: 0x181DDE580 Slot: 101
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x1DDE3A0 Offset: 0x1DDCDA0 VA: 0x181DDE3A0 Slot: 121
	public override void WriteValue(byte[] value) { }

	// RVA: 0x1DDE710 Offset: 0x1DDD110 VA: 0x181DDE710 Slot: 103
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0x1DDE470 Offset: 0x1DDCE70 VA: 0x181DDE470 Slot: 102
	public override void WriteValue(Guid value) { }

	// RVA: 0x1DDE050 Offset: 0x1DDCA50 VA: 0x181DDE050 Slot: 122
	public override void WriteValue(Uri value) { }

	[NullableContext(1)]
	// RVA: 0x1DDD670 Offset: 0x1DDC070 VA: 0x181DDD670 Slot: 77
	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }
}
