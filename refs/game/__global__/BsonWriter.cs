public class BsonWriter : JsonWriter // TypeDefIndex: 11447
{
	// Fields
	private readonly BsonBinaryWriter _writer; // 0x60
	private BsonToken _root; // 0x68
	private BsonToken _parent; // 0x70
	private string _propertyName; // 0x78

	// Properties
	public DateTimeKind DateTimeKindHandling { get; set; }

	// Methods

	// RVA: 0x1DF1500 Offset: 0x1DEFF00 VA: 0x181DF1500
	public DateTimeKind get_DateTimeKindHandling() { }

	// RVA: 0x1DF1520 Offset: 0x1DEFF20 VA: 0x181DF1520
	public void set_DateTimeKindHandling(DateTimeKind value) { }

	// RVA: 0x1DF1400 Offset: 0x1DEFE00 VA: 0x181DF1400
	public void .ctor(Stream stream) { }

	// RVA: 0x1DF1330 Offset: 0x1DEFD30 VA: 0x181DF1330
	public void .ctor(BinaryWriter writer) { }

	// RVA: 0x1DEFE70 Offset: 0x1DEE870 VA: 0x181DEFE70 Slot: 66
	public override void Flush() { }

	// RVA: 0x1DEFF30 Offset: 0x1DEE930 VA: 0x181DEFF30 Slot: 78
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0x1DEFEE0 Offset: 0x1DEE8E0 VA: 0x181DEFEE0 Slot: 124
	public override void WriteComment(string text) { }

	// RVA: 0x1DF03F0 Offset: 0x1DEEDF0 VA: 0x181DF03F0 Slot: 72
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x1DF0170 Offset: 0x1DEEB70 VA: 0x181DF0170 Slot: 84
	public override void WriteRaw(string json) { }

	// RVA: 0x1DF0120 Offset: 0x1DEEB20 VA: 0x181DF0120 Slot: 85
	public override void WriteRawValue(string json) { }

	// RVA: 0x1DF0310 Offset: 0x1DEED10 VA: 0x181DF0310 Slot: 70
	public override void WriteStartArray() { }

	// RVA: 0x1DF0440 Offset: 0x1DEEE40 VA: 0x181DF0440 Slot: 68
	public override void WriteStartObject() { }

	// RVA: 0x1DF00E0 Offset: 0x1DEEAE0 VA: 0x181DF00E0 Slot: 74
	public override void WritePropertyName(string name) { }

	// RVA: 0x1DEFE20 Offset: 0x1DEE820 VA: 0x181DEFE20 Slot: 67
	public override void Close() { }

	// RVA: 0x1DEF970 Offset: 0x1DEE370 VA: 0x181DEF970
	private void AddParent(BsonToken container) { }

	// RVA: 0x1DEFEB0 Offset: 0x1DEE8B0 VA: 0x181DEFEB0
	private void RemoveParent() { }

	// RVA: 0x1DEFD90 Offset: 0x1DEE790 VA: 0x181DEFD90
	private void AddValue(object value, BsonType type) { }

	// RVA: 0x1DEF9B0 Offset: 0x1DEE3B0 VA: 0x181DEF9B0
	internal void AddToken(BsonToken token) { }

	// RVA: 0x1DF0600 Offset: 0x1DEF000 VA: 0x181DF0600 Slot: 123
	public override void WriteValue(object value) { }

	// RVA: 0x1DEFFB0 Offset: 0x1DEE9B0 VA: 0x181DEFFB0 Slot: 82
	public override void WriteNull() { }

	// RVA: 0x1DF0520 Offset: 0x1DEEF20 VA: 0x181DF0520 Slot: 83
	public override void WriteUndefined() { }

	// RVA: 0x1DF1140 Offset: 0x1DEFB40 VA: 0x181DF1140 Slot: 86
	public override void WriteValue(string value) { }

	// RVA: 0x1DF08A0 Offset: 0x1DEF2A0 VA: 0x181DF08A0 Slot: 87
	public override void WriteValue(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DF0730 Offset: 0x1DEF130 VA: 0x181DF0730 Slot: 88
	public override void WriteValue(uint value) { }

	// RVA: 0x1DF0910 Offset: 0x1DEF310 VA: 0x181DF0910 Slot: 89
	public override void WriteValue(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DF07E0 Offset: 0x1DEF1E0 VA: 0x181DF07E0 Slot: 90
	public override void WriteValue(ulong value) { }

	// RVA: 0x1DF1060 Offset: 0x1DEFA60 VA: 0x181DF1060 Slot: 91
	public override void WriteValue(float value) { }

	// RVA: 0x1DF0DE0 Offset: 0x1DEF7E0 VA: 0x181DF0DE0 Slot: 92
	public override void WriteValue(double value) { }

	// RVA: 0x1DF0FB0 Offset: 0x1DEF9B0 VA: 0x181DF0FB0 Slot: 93
	public override void WriteValue(bool value) { }

	// RVA: 0x1DF0B00 Offset: 0x1DEF500 VA: 0x181DF0B00 Slot: 94
	public override void WriteValue(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DF0590 Offset: 0x1DEEF90 VA: 0x181DF0590 Slot: 95
	public override void WriteValue(ushort value) { }

	// RVA: 0x1DF0980 Offset: 0x1DEF380 VA: 0x181DF0980 Slot: 96
	public override void WriteValue(char value) { }

	// RVA: 0x1DF0CA0 Offset: 0x1DEF6A0 VA: 0x181DF0CA0 Slot: 97
	public override void WriteValue(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1DF10D0 Offset: 0x1DEFAD0 VA: 0x181DF10D0 Slot: 98
	public override void WriteValue(sbyte value) { }

	// RVA: 0x1DF0B70 Offset: 0x1DEF570 VA: 0x181DF0B70 Slot: 99
	public override void WriteValue(Decimal value) { }

	// RVA: 0x1DF0E50 Offset: 0x1DEF850 VA: 0x181DF0E50 Slot: 100
	public override void WriteValue(DateTime value) { }

	// RVA: 0x1DF0A80 Offset: 0x1DEF480 VA: 0x181DF0A80 Slot: 101
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x1DF0BF0 Offset: 0x1DEF5F0 VA: 0x181DF0BF0 Slot: 121
	public override void WriteValue(byte[] value) { }

	// RVA: 0x1DF0F00 Offset: 0x1DEF900 VA: 0x181DF0F00 Slot: 102
	public override void WriteValue(Guid value) { }

	// RVA: 0x1DF0D10 Offset: 0x1DEF710 VA: 0x181DF0D10 Slot: 103
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0x1DF1220 Offset: 0x1DEFC20 VA: 0x181DF1220 Slot: 122
	public override void WriteValue(Uri value) { }

	// RVA: 0x1DF0020 Offset: 0x1DEEA20 VA: 0x181DF0020
	public void WriteObjectId(byte[] value) { }

	// RVA: 0x1DF01C0 Offset: 0x1DEEBC0 VA: 0x181DF01C0
	public void WriteRegex(string pattern, string options) { }
}
