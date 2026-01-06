internal class JsonSerializerProxy : JsonSerializer // TypeDefIndex: 11263
{
	// Fields
	[Nullable(2)]
	private readonly JsonSerializerInternalReader _serializerReader; // 0xE0
	[Nullable(2)]
	private readonly JsonSerializerInternalWriter _serializerWriter; // 0xE8
	internal readonly JsonSerializer _serializer; // 0xF0

	// Properties
	[Nullable(2)]
	public override IReferenceResolver ReferenceResolver { get; set; }
	[Nullable(2)]
	public override ITraceWriter TraceWriter { get; set; }
	[Nullable(2)]
	public override IEqualityComparer EqualityComparer { get; set; }
	public override JsonConverterCollection Converters { get; }
	public override DefaultValueHandling DefaultValueHandling { get; set; }
	public override IContractResolver ContractResolver { get; set; }
	public override MissingMemberHandling MissingMemberHandling { get; set; }
	public override NullValueHandling NullValueHandling { get; set; }
	public override ObjectCreationHandling ObjectCreationHandling { get; set; }
	public override ReferenceLoopHandling ReferenceLoopHandling { get; set; }
	public override PreserveReferencesHandling PreserveReferencesHandling { get; set; }
	public override TypeNameHandling TypeNameHandling { get; set; }
	public override MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	public override FormatterAssemblyStyle TypeNameAssemblyFormat { get; set; }
	public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { get; set; }
	public override ConstructorHandling ConstructorHandling { get; set; }
	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	public override SerializationBinder Binder { get; set; }
	public override ISerializationBinder SerializationBinder { get; set; }
	public override StreamingContext Context { get; set; }
	public override Formatting Formatting { get; set; }
	public override DateFormatHandling DateFormatHandling { get; set; }
	public override DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public override DateParseHandling DateParseHandling { get; set; }
	public override FloatFormatHandling FloatFormatHandling { get; set; }
	public override FloatParseHandling FloatParseHandling { get; set; }
	public override StringEscapeHandling StringEscapeHandling { get; set; }
	public override string DateFormatString { get; set; }
	public override CultureInfo Culture { get; set; }
	public override Nullable<int> MaxDepth { get; set; }
	public override bool CheckAdditionalContent { get; set; }

	// Methods

	// RVA: 0x1DABEA0 Offset: 0x1DAA8A0 VA: 0x181DABEA0 Slot: 4
	public override void add_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0x1DAC460 Offset: 0x1DAAE60 VA: 0x181DAC460 Slot: 5
	public override void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(2)]
	// RVA: 0x1DAC310 Offset: 0x1DAAD10 VA: 0x181DAC310 Slot: 6
	public override IReferenceResolver get_ReferenceResolver() { }

	[NullableContext(2)]
	// RVA: 0x1DAC8C0 Offset: 0x1DAB2C0 VA: 0x181DAC8C0 Slot: 7
	public override void set_ReferenceResolver(IReferenceResolver value) { }

	[NullableContext(2)]
	// RVA: 0x1DAC3A0 Offset: 0x1DAADA0 VA: 0x181DAC3A0 Slot: 12
	public override ITraceWriter get_TraceWriter() { }

	[NullableContext(2)]
	// RVA: 0x1DAC950 Offset: 0x1DAB350 VA: 0x181DAC950 Slot: 13
	public override void set_TraceWriter(ITraceWriter value) { }

	[NullableContext(2)]
	// RVA: 0x1A45340 Offset: 0x1A43D40 VA: 0x181A45340 Slot: 14
	public override IEqualityComparer get_EqualityComparer() { }

	[NullableContext(2)]
	// RVA: 0x1DAC6B0 Offset: 0x1DAB0B0 VA: 0x181DAC6B0 Slot: 15
	public override void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0x1DABFE0 Offset: 0x1DAA9E0 VA: 0x181DABFE0 Slot: 38
	public override JsonConverterCollection get_Converters() { }

	// RVA: 0x1DAC100 Offset: 0x1DAAB00 VA: 0x181DAC100 Slot: 30
	public override DefaultValueHandling get_DefaultValueHandling() { }

	// RVA: 0x1DAC680 Offset: 0x1DAB080 VA: 0x181DAC680 Slot: 31
	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x1DABFB0 Offset: 0x1DAA9B0 VA: 0x181DABFB0 Slot: 39
	public override IContractResolver get_ContractResolver() { }

	// RVA: 0x1DAC560 Offset: 0x1DAAF60 VA: 0x181DAC560 Slot: 40
	public override void set_ContractResolver(IContractResolver value) { }

	// RVA: 0x1DAC220 Offset: 0x1DAAC20 VA: 0x181DAC220 Slot: 26
	public override MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0x1DAC7D0 Offset: 0x1DAB1D0 VA: 0x181DAC7D0 Slot: 27
	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x1DAC250 Offset: 0x1DAAC50 VA: 0x181DAC250 Slot: 28
	public override NullValueHandling get_NullValueHandling() { }

	// RVA: 0x1DAC800 Offset: 0x1DAB200 VA: 0x181DAC800 Slot: 29
	public override void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x1DAC280 Offset: 0x1DAAC80 VA: 0x181DAC280 Slot: 32
	public override ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0x1DAC830 Offset: 0x1DAB230 VA: 0x181DAC830 Slot: 33
	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x1DAC2E0 Offset: 0x1DAACE0 VA: 0x181DAC2E0 Slot: 24
	public override ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0x1DAC890 Offset: 0x1DAB290 VA: 0x181DAC890 Slot: 25
	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x1DAC2B0 Offset: 0x1DAACB0 VA: 0x181DAC2B0 Slot: 22
	public override PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0x1DAC860 Offset: 0x1DAB260 VA: 0x181DAC860 Slot: 23
	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0x1DAC430 Offset: 0x1DAAE30 VA: 0x181DAC430 Slot: 16
	public override TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0x1DAC9E0 Offset: 0x1DAB3E0 VA: 0x181DAC9E0 Slot: 17
	public override void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x1DAC1F0 Offset: 0x1DAABF0 VA: 0x181DAC1F0 Slot: 36
	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x1DAC7A0 Offset: 0x1DAB1A0 VA: 0x181DAC7A0 Slot: 37
	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0x1DAC400 Offset: 0x1DAAE00 VA: 0x181DAC400 Slot: 18
	public override FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	// RVA: 0x1DAC9B0 Offset: 0x1DAB3B0 VA: 0x181DAC9B0 Slot: 19
	public override void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x1DAC3D0 Offset: 0x1DAADD0 VA: 0x181DAC3D0 Slot: 20
	public override TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	// RVA: 0x1DAC980 Offset: 0x1DAB380 VA: 0x181DAC980 Slot: 21
	public override void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0x1DABF30 Offset: 0x1DAA930 VA: 0x181DABF30 Slot: 34
	public override ConstructorHandling get_ConstructorHandling() { }

	// RVA: 0x1DAC4F0 Offset: 0x1DAAEF0 VA: 0x181DAC4F0 Slot: 35
	public override void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x1DABED0 Offset: 0x1DAA8D0 VA: 0x181DABED0 Slot: 8
	public override SerializationBinder get_Binder() { }

	// RVA: 0x1DAC490 Offset: 0x1DAAE90 VA: 0x181DAC490 Slot: 9
	public override void set_Binder(SerializationBinder value) { }

	// RVA: 0x1DAC340 Offset: 0x1DAAD40 VA: 0x181DAC340 Slot: 10
	public override ISerializationBinder get_SerializationBinder() { }

	// RVA: 0x1DAC8F0 Offset: 0x1DAB2F0 VA: 0x181DAC8F0 Slot: 11
	public override void set_SerializationBinder(ISerializationBinder value) { }

	// RVA: 0x1DABF60 Offset: 0x1DAA960 VA: 0x181DABF60 Slot: 41
	public override StreamingContext get_Context() { }

	// RVA: 0x1DAC520 Offset: 0x1DAAF20 VA: 0x181DAC520 Slot: 42
	public override void set_Context(StreamingContext value) { }

	// RVA: 0x1DAC190 Offset: 0x1DAAB90 VA: 0x181DAC190 Slot: 43
	public override Formatting get_Formatting() { }

	// RVA: 0x1DAC740 Offset: 0x1DAB140 VA: 0x181DAC740 Slot: 44
	public override void set_Formatting(Formatting value) { }

	// RVA: 0x1DAC040 Offset: 0x1DAAA40 VA: 0x181DAC040 Slot: 45
	public override DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0x1DAC5C0 Offset: 0x1DAAFC0 VA: 0x181DAC5C0 Slot: 46
	public override void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0x1DAC0D0 Offset: 0x1DAAAD0 VA: 0x181DAC0D0 Slot: 47
	public override DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0x1DAC650 Offset: 0x1DAB050 VA: 0x181DAC650 Slot: 48
	public override void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x1DAC0A0 Offset: 0x1DAAAA0 VA: 0x181DAC0A0 Slot: 49
	public override DateParseHandling get_DateParseHandling() { }

	// RVA: 0x1DAC620 Offset: 0x1DAB020 VA: 0x181DAC620 Slot: 50
	public override void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0x1DAC130 Offset: 0x1DAAB30 VA: 0x181DAC130 Slot: 53
	public override FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0x1DAC6E0 Offset: 0x1DAB0E0 VA: 0x181DAC6E0 Slot: 54
	public override void set_FloatFormatHandling(FloatFormatHandling value) { }

	// RVA: 0x1DAC160 Offset: 0x1DAAB60 VA: 0x181DAC160 Slot: 51
	public override FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0x1DAC710 Offset: 0x1DAB110 VA: 0x181DAC710 Slot: 52
	public override void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0x1DAC370 Offset: 0x1DAAD70 VA: 0x181DAC370 Slot: 55
	public override StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0x1DAC920 Offset: 0x1DAB320 VA: 0x181DAC920 Slot: 56
	public override void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0x1DAC070 Offset: 0x1DAAA70 VA: 0x181DAC070 Slot: 57
	public override string get_DateFormatString() { }

	// RVA: 0x1DAC5F0 Offset: 0x1DAAFF0 VA: 0x181DAC5F0 Slot: 58
	public override void set_DateFormatString(string value) { }

	// RVA: 0x1DAC010 Offset: 0x1DAAA10 VA: 0x181DAC010 Slot: 59
	public override CultureInfo get_Culture() { }

	// RVA: 0x1DAC590 Offset: 0x1DAAF90 VA: 0x181DAC590 Slot: 60
	public override void set_Culture(CultureInfo value) { }

	// RVA: 0x1DAC1C0 Offset: 0x1DAABC0 VA: 0x181DAC1C0 Slot: 61
	public override Nullable<int> get_MaxDepth() { }

	// RVA: 0x1DAC770 Offset: 0x1DAB170 VA: 0x181DAC770 Slot: 62
	public override void set_MaxDepth(Nullable<int> value) { }

	// RVA: 0x1DABF00 Offset: 0x1DAA900 VA: 0x181DABF00 Slot: 63
	public override bool get_CheckAdditionalContent() { }

	// RVA: 0x1DAC4C0 Offset: 0x1DAAEC0 VA: 0x181DAC4C0 Slot: 64
	public override void set_CheckAdditionalContent(bool value) { }

	// RVA: 0x1DABCC0 Offset: 0x1DAA6C0 VA: 0x181DABCC0
	internal JsonSerializerInternalBase GetInternalSerializer() { }

	// RVA: 0x1DABE10 Offset: 0x1DAA810 VA: 0x181DABE10
	public void .ctor(JsonSerializerInternalReader serializerReader) { }

	// RVA: 0x1DABD80 Offset: 0x1DAA780 VA: 0x181DABD80
	public void .ctor(JsonSerializerInternalWriter serializerWriter) { }

	[NullableContext(2)]
	// RVA: 0x1DABC70 Offset: 0x1DAA670 VA: 0x181DABC70 Slot: 66
	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0x1DABCE0 Offset: 0x1DAA6E0 VA: 0x181DABCE0 Slot: 65
	internal override void PopulateInternal(JsonReader reader, object target) { }

	[NullableContext(2)]
	// RVA: 0x1DABD30 Offset: 0x1DAA730 VA: 0x181DABD30 Slot: 67
	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }
}
