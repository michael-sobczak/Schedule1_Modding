internal class TraceJsonWriter : JsonWriter // TypeDefIndex: 11278
{
	// Fields
	private readonly JsonWriter _innerWriter; // 0x60
	private readonly JsonTextWriter _textWriter; // 0x68
	private readonly StringWriter _sw; // 0x70

	// Methods

	// RVA: 0x1DB1530 Offset: 0x1DAFF30 VA: 0x181DB1530
	public void .ctor(JsonWriter innerWriter) { }

	// RVA: 0x1DAF7D0 Offset: 0x1DAE1D0 VA: 0x181DAF7D0
	public string GetSerializedJsonMessage() { }

	// RVA: 0x1DB0170 Offset: 0x1DAEB70 VA: 0x181DB0170 Slot: 99
	public override void WriteValue(Decimal value) { }

	// RVA: 0x1DB0430 Offset: 0x1DAEE30 VA: 0x181DB0430 Slot: 116
	public override void WriteValue(Nullable<Decimal> value) { }

	// RVA: 0x1DB03C0 Offset: 0x1DAEDC0 VA: 0x181DB03C0 Slot: 93
	public override void WriteValue(bool value) { }

	// RVA: 0x1DB0680 Offset: 0x1DAF080 VA: 0x181DB0680 Slot: 110
	public override void WriteValue(Nullable<bool> value) { }

	// RVA: 0x1DAFE70 Offset: 0x1DAE870 VA: 0x181DAFE70 Slot: 97
	public override void WriteValue(byte value) { }

	// RVA: 0x1DB09F0 Offset: 0x1DAF3F0 VA: 0x181DB09F0 Slot: 114
	public override void WriteValue(Nullable<byte> value) { }

	// RVA: 0x1DB0610 Offset: 0x1DAF010 VA: 0x181DB0610 Slot: 96
	public override void WriteValue(char value) { }

	// RVA: 0x1DB0AA0 Offset: 0x1DAF4A0 VA: 0x181DB0AA0 Slot: 113
	public override void WriteValue(Nullable<char> value) { }

	[NullableContext(2)]
	// RVA: 0x1DB1320 Offset: 0x1DAFD20 VA: 0x181DB1320 Slot: 121
	public override void WriteValue(byte[] value) { }

	// RVA: 0x1DB10C0 Offset: 0x1DAFAC0 VA: 0x181DB10C0 Slot: 100
	public override void WriteValue(DateTime value) { }

	// RVA: 0x1DAFEE0 Offset: 0x1DAE8E0 VA: 0x181DAFEE0 Slot: 117
	public override void WriteValue(Nullable<DateTime> value) { }

	// RVA: 0x1DB0200 Offset: 0x1DAEC00 VA: 0x181DB0200 Slot: 101
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x1DB0520 Offset: 0x1DAEF20 VA: 0x181DB0520 Slot: 118
	public override void WriteValue(Nullable<DateTimeOffset> value) { }

	// RVA: 0x1DB0290 Offset: 0x1DAEC90 VA: 0x181DB0290 Slot: 92
	public override void WriteValue(double value) { }

	// RVA: 0x1DB0850 Offset: 0x1DAF250 VA: 0x181DB0850 Slot: 109
	public override void WriteValue(Nullable<double> value) { }

	// RVA: 0x1DAFCF0 Offset: 0x1DAE6F0 VA: 0x181DAFCF0 Slot: 83
	public override void WriteUndefined() { }

	// RVA: 0x1DAF990 Offset: 0x1DAE390 VA: 0x181DAF990 Slot: 82
	public override void WriteNull() { }

	// RVA: 0x1DB0D70 Offset: 0x1DAF770 VA: 0x181DB0D70 Slot: 91
	public override void WriteValue(float value) { }

	// RVA: 0x1DB11F0 Offset: 0x1DAFBF0 VA: 0x181DB11F0 Slot: 108
	public override void WriteValue(Nullable<float> value) { }

	// RVA: 0x1DB0C10 Offset: 0x1DAF610 VA: 0x181DB0C10 Slot: 102
	public override void WriteValue(Guid value) { }

	// RVA: 0x1DB0DE0 Offset: 0x1DAF7E0 VA: 0x181DB0DE0 Slot: 119
	public override void WriteValue(Nullable<Guid> value) { }

	// RVA: 0x1DB0100 Offset: 0x1DAEB00 VA: 0x181DB0100 Slot: 87
	public override void WriteValue(int value) { }

	// RVA: 0x1DAFD50 Offset: 0x1DAE750 VA: 0x181DAFD50 Slot: 104
	public override void WriteValue(Nullable<int> value) { }

	// RVA: 0x1DB0F30 Offset: 0x1DAF930 VA: 0x181DB0F30 Slot: 89
	public override void WriteValue(long value) { }

	// RVA: 0x1DB0300 Offset: 0x1DAED00 VA: 0x181DB0300 Slot: 106
	public override void WriteValue(Nullable<long> value) { }

	[NullableContext(2)]
	// RVA: 0x1DB0FA0 Offset: 0x1DAF9A0 VA: 0x181DB0FA0 Slot: 123
	public override void WriteValue(object value) { }

	// RVA: 0x1DAFE00 Offset: 0x1DAE800 VA: 0x181DAFE00 Slot: 98
	public override void WriteValue(sbyte value) { }

	// RVA: 0x1DAFFA0 Offset: 0x1DAE9A0 VA: 0x181DAFFA0 Slot: 115
	public override void WriteValue(Nullable<sbyte> value) { }

	// RVA: 0x1DB13A0 Offset: 0x1DAFDA0 VA: 0x181DB13A0 Slot: 94
	public override void WriteValue(short value) { }

	// RVA: 0x1DB0050 Offset: 0x1DAEA50 VA: 0x181DB0050 Slot: 111
	public override void WriteValue(Nullable<short> value) { }

	[NullableContext(2)]
	// RVA: 0x1DB07E0 Offset: 0x1DAF1E0 VA: 0x181DB07E0 Slot: 86
	public override void WriteValue(string value) { }

	// RVA: 0x1DB0910 Offset: 0x1DAF310 VA: 0x181DB0910 Slot: 103
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0x1DB0B50 Offset: 0x1DAF550 VA: 0x181DB0B50 Slot: 120
	public override void WriteValue(Nullable<TimeSpan> value) { }

	// RVA: 0x1DB0EC0 Offset: 0x1DAF8C0 VA: 0x181DB0EC0 Slot: 88
	public override void WriteValue(uint value) { }

	// RVA: 0x1DB1410 Offset: 0x1DAFE10 VA: 0x181DB1410 Slot: 105
	public override void WriteValue(Nullable<uint> value) { }

	// RVA: 0x1DB12B0 Offset: 0x1DAFCB0 VA: 0x181DB12B0 Slot: 90
	public override void WriteValue(ulong value) { }

	// RVA: 0x1DB1130 Offset: 0x1DAFB30 VA: 0x181DB1130 Slot: 107
	public override void WriteValue(Nullable<ulong> value) { }

	[NullableContext(2)]
	// RVA: 0x1DB0CA0 Offset: 0x1DAF6A0 VA: 0x181DB0CA0 Slot: 122
	public override void WriteValue(Uri value) { }

	// RVA: 0x1DB0980 Offset: 0x1DAF380 VA: 0x181DB0980 Slot: 95
	public override void WriteValue(ushort value) { }

	// RVA: 0x1DB0730 Offset: 0x1DAF130 VA: 0x181DB0730 Slot: 112
	public override void WriteValue(Nullable<ushort> value) { }

	// RVA: 0x1DB14C0 Offset: 0x1DAFEC0 VA: 0x181DB14C0 Slot: 125
	public override void WriteWhitespace(string ws) { }

	[NullableContext(2)]
	// RVA: 0x1DAF800 Offset: 0x1DAE200 VA: 0x181DAF800 Slot: 124
	public override void WriteComment(string text) { }

	// RVA: 0x1DAFBC0 Offset: 0x1DAE5C0 VA: 0x181DAFBC0 Slot: 70
	public override void WriteStartArray() { }

	// RVA: 0x1DAF870 Offset: 0x1DAE270 VA: 0x181DAF870 Slot: 71
	public override void WriteEndArray() { }

	// RVA: 0x1DAFC20 Offset: 0x1DAE620 VA: 0x181DAFC20 Slot: 72
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x1DAF8D0 Offset: 0x1DAE2D0 VA: 0x181DAF8D0 Slot: 73
	public override void WriteEndConstructor() { }

	// RVA: 0x1DAF9F0 Offset: 0x1DAE3F0 VA: 0x181DAF9F0 Slot: 74
	public override void WritePropertyName(string name) { }

	// RVA: 0x1DAFA60 Offset: 0x1DAE460 VA: 0x181DAFA60 Slot: 75
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0x1DAFC90 Offset: 0x1DAE690 VA: 0x181DAFC90 Slot: 68
	public override void WriteStartObject() { }

	// RVA: 0x1DAF930 Offset: 0x1DAE330 VA: 0x181DAF930 Slot: 69
	public override void WriteEndObject() { }

	[NullableContext(2)]
	// RVA: 0x1DAFAE0 Offset: 0x1DAE4E0 VA: 0x181DAFAE0 Slot: 85
	public override void WriteRawValue(string json) { }

	[NullableContext(2)]
	// RVA: 0x1DAFB50 Offset: 0x1DAE550 VA: 0x181DAFB50 Slot: 84
	public override void WriteRaw(string json) { }

	// RVA: 0x1DAF720 Offset: 0x1DAE120 VA: 0x181DAF720 Slot: 67
	public override void Close() { }

	// RVA: 0x1DAF780 Offset: 0x1DAE180 VA: 0x181DAF780 Slot: 66
	public override void Flush() { }
}
