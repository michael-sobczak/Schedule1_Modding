public class JsonSerializer // TypeDefIndex: 11012
{
	// Fields
	internal TypeNameHandling _typeNameHandling; // 0x10
	internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling; // 0x14
	internal PreserveReferencesHandling _preserveReferencesHandling; // 0x18
	internal ReferenceLoopHandling _referenceLoopHandling; // 0x1C
	internal MissingMemberHandling _missingMemberHandling; // 0x20
	internal ObjectCreationHandling _objectCreationHandling; // 0x24
	internal NullValueHandling _nullValueHandling; // 0x28
	internal DefaultValueHandling _defaultValueHandling; // 0x2C
	internal ConstructorHandling _constructorHandling; // 0x30
	internal MetadataPropertyHandling _metadataPropertyHandling; // 0x34
	[Nullable(2)]
	internal JsonConverterCollection _converters; // 0x38
	internal IContractResolver _contractResolver; // 0x40
	[Nullable(2)]
	internal ITraceWriter _traceWriter; // 0x48
	[Nullable(2)]
	internal IEqualityComparer _equalityComparer; // 0x50
	internal ISerializationBinder _serializationBinder; // 0x58
	internal StreamingContext _context; // 0x60
	[Nullable(2)]
	private IReferenceResolver _referenceResolver; // 0x70
	private Nullable<Formatting> _formatting; // 0x78
	private Nullable<DateFormatHandling> _dateFormatHandling; // 0x80
	private Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; // 0x88
	private Nullable<DateParseHandling> _dateParseHandling; // 0x90
	private Nullable<FloatFormatHandling> _floatFormatHandling; // 0x98
	private Nullable<FloatParseHandling> _floatParseHandling; // 0xA0
	private Nullable<StringEscapeHandling> _stringEscapeHandling; // 0xA8
	private CultureInfo _culture; // 0xB0
	private Nullable<int> _maxDepth; // 0xB8
	private bool _maxDepthSet; // 0xC0
	private Nullable<bool> _checkAdditionalContent; // 0xC1
	[Nullable(2)]
	private string _dateFormatString; // 0xC8
	private bool _dateFormatStringSet; // 0xD0
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private EventHandler<ErrorEventArgs> Error; // 0xD8

	// Properties
	[Nullable(2)]
	public virtual IReferenceResolver ReferenceResolver { get; set; }
	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	public virtual SerializationBinder Binder { get; set; }
	public virtual ISerializationBinder SerializationBinder { get; set; }
	[Nullable(2)]
	public virtual ITraceWriter TraceWriter { get; set; }
	[Nullable(2)]
	public virtual IEqualityComparer EqualityComparer { get; set; }
	public virtual TypeNameHandling TypeNameHandling { get; set; }
	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	public virtual FormatterAssemblyStyle TypeNameAssemblyFormat { get; set; }
	public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { get; set; }
	public virtual PreserveReferencesHandling PreserveReferencesHandling { get; set; }
	public virtual ReferenceLoopHandling ReferenceLoopHandling { get; set; }
	public virtual MissingMemberHandling MissingMemberHandling { get; set; }
	public virtual NullValueHandling NullValueHandling { get; set; }
	public virtual DefaultValueHandling DefaultValueHandling { get; set; }
	public virtual ObjectCreationHandling ObjectCreationHandling { get; set; }
	public virtual ConstructorHandling ConstructorHandling { get; set; }
	public virtual MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	public virtual JsonConverterCollection Converters { get; }
	public virtual IContractResolver ContractResolver { get; set; }
	public virtual StreamingContext Context { get; set; }
	public virtual Formatting Formatting { get; set; }
	public virtual DateFormatHandling DateFormatHandling { get; set; }
	public virtual DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public virtual DateParseHandling DateParseHandling { get; set; }
	public virtual FloatParseHandling FloatParseHandling { get; set; }
	public virtual FloatFormatHandling FloatFormatHandling { get; set; }
	public virtual StringEscapeHandling StringEscapeHandling { get; set; }
	public virtual string DateFormatString { get; set; }
	public virtual CultureInfo Culture { get; set; }
	public virtual Nullable<int> MaxDepth { get; set; }
	public virtual bool CheckAdditionalContent { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D18FC0 Offset: 0x1D179C0 VA: 0x181D18FC0 Slot: 4
	public virtual void add_Error(EventHandler<ErrorEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1D19500 Offset: 0x1D17F00 VA: 0x181D19500 Slot: 5
	public virtual void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(2)]
	// RVA: 0x1D17B30 Offset: 0x1D16530 VA: 0x181D17B30 Slot: 6
	public virtual IReferenceResolver get_ReferenceResolver() { }

	[NullableContext(2)]
	// RVA: 0x1D19EA0 Offset: 0x1D188A0 VA: 0x181D19EA0 Slot: 7
	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0x1D19080 Offset: 0x1D17A80 VA: 0x181D19080 Slot: 8
	public virtual SerializationBinder get_Binder() { }

	// RVA: 0x1D195C0 Offset: 0x1D17FC0 VA: 0x181D195C0 Slot: 9
	public virtual void set_Binder(SerializationBinder value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0 Slot: 10
	public virtual ISerializationBinder get_SerializationBinder() { }

	// RVA: 0x1D19F30 Offset: 0x1D18930 VA: 0x181D19F30 Slot: 11
	public virtual void set_SerializationBinder(ISerializationBinder value) { }

	[NullableContext(2)]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80 Slot: 12
	public virtual ITraceWriter get_TraceWriter() { }

	[NullableContext(2)]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30 Slot: 13
	public virtual void set_TraceWriter(ITraceWriter value) { }

	[NullableContext(2)]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 14
	public virtual IEqualityComparer get_EqualityComparer() { }

	[NullableContext(2)]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0 Slot: 15
	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 16
	public virtual TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0x1D1A100 Offset: 0x1D18B00 VA: 0x181D1A100 Slot: 17
	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70 Slot: 18
	public virtual FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	// RVA: 0x1D1A090 Offset: 0x1D18A90 VA: 0x181D1A090 Slot: 19
	public virtual void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70 Slot: 20
	public virtual TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	// RVA: 0x1D1A020 Offset: 0x1D18A20 VA: 0x181D1A020 Slot: 21
	public virtual void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90 Slot: 22
	public virtual PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0x1D19DC0 Offset: 0x1D187C0 VA: 0x181D19DC0 Slot: 23
	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70 Slot: 24
	public virtual ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0x1D19E30 Offset: 0x1D18830 VA: 0x181D19E30 Slot: 25
	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 26
	public virtual MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0x1D19C70 Offset: 0x1D18670 VA: 0x181D19C70 Slot: 27
	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430 Slot: 28
	public virtual NullValueHandling get_NullValueHandling() { }

	// RVA: 0x1D19CE0 Offset: 0x1D186E0 VA: 0x181D19CE0 Slot: 29
	public virtual void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590 Slot: 30
	public virtual DefaultValueHandling get_DefaultValueHandling() { }

	// RVA: 0x1D199B0 Offset: 0x1D183B0 VA: 0x181D199B0 Slot: 31
	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40 Slot: 32
	public virtual ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0x1D19D50 Offset: 0x1D18750 VA: 0x181D19D50 Slot: 33
	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90 Slot: 34
	public virtual ConstructorHandling get_ConstructorHandling() { }

	// RVA: 0x1D19720 Offset: 0x1D18120 VA: 0x181D19720 Slot: 35
	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00 Slot: 36
	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x1D19C00 Offset: 0x1D18600 VA: 0x181D19C00 Slot: 37
	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0x1D191C0 Offset: 0x1D17BC0 VA: 0x181D191C0 Slot: 38
	public virtual JsonConverterCollection get_Converters() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 39
	public virtual IContractResolver get_ContractResolver() { }

	// RVA: 0x1D197B0 Offset: 0x1D181B0 VA: 0x181D197B0 Slot: 40
	public virtual void set_ContractResolver(IContractResolver value) { }

	// RVA: 0x1D191B0 Offset: 0x1D17BB0 VA: 0x181D191B0 Slot: 41
	public virtual StreamingContext get_Context() { }

	// RVA: 0x1D19790 Offset: 0x1D18190 VA: 0x181D19790 Slot: 42
	public virtual void set_Context(StreamingContext value) { }

	// RVA: 0x1D19480 Offset: 0x1D17E80 VA: 0x181D19480 Slot: 43
	public virtual Formatting get_Formatting() { }

	// RVA: 0x1D19AE0 Offset: 0x1D184E0 VA: 0x181D19AE0 Slot: 44
	public virtual void set_Formatting(Formatting value) { }

	// RVA: 0x1D192C0 Offset: 0x1D17CC0 VA: 0x181D192C0 Slot: 45
	public virtual DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0x1D19860 Offset: 0x1D18260 VA: 0x181D19860 Slot: 46
	public virtual void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0x1D193A0 Offset: 0x1D17DA0 VA: 0x181D193A0 Slot: 47
	public virtual DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0x1D19950 Offset: 0x1D18350 VA: 0x181D19950 Slot: 48
	public virtual void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x1D19340 Offset: 0x1D17D40 VA: 0x181D19340 Slot: 49
	public virtual DateParseHandling get_DateParseHandling() { }

	// RVA: 0x1D198F0 Offset: 0x1D182F0 VA: 0x181D198F0 Slot: 50
	public virtual void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0x1D19440 Offset: 0x1D17E40 VA: 0x181D19440 Slot: 51
	public virtual FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0x1D19A80 Offset: 0x1D18480 VA: 0x181D19A80 Slot: 52
	public virtual void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0x1D19400 Offset: 0x1D17E00 VA: 0x181D19400 Slot: 53
	public virtual FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0x1D19A20 Offset: 0x1D18420 VA: 0x181D19A20 Slot: 54
	public virtual void set_FloatFormatHandling(FloatFormatHandling value) { }

	// RVA: 0x1D194C0 Offset: 0x1D17EC0 VA: 0x181D194C0 Slot: 55
	public virtual StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0x1D19FC0 Offset: 0x1D189C0 VA: 0x181D19FC0 Slot: 56
	public virtual void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0x1D19300 Offset: 0x1D17D00 VA: 0x181D19300 Slot: 57
	public virtual string get_DateFormatString() { }

	// RVA: 0x1D198C0 Offset: 0x1D182C0 VA: 0x181D198C0 Slot: 58
	public virtual void set_DateFormatString(string value) { }

	// RVA: 0x1D19250 Offset: 0x1D17C50 VA: 0x181D19250 Slot: 59
	public virtual CultureInfo get_Culture() { }

	// RVA: 0x4B6C80 Offset: 0x4B5680 VA: 0x1804B6C80 Slot: 60
	public virtual void set_Culture(CultureInfo value) { }

	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160 Slot: 61
	public virtual Nullable<int> get_MaxDepth() { }

	// RVA: 0x1D19B40 Offset: 0x1D18540 VA: 0x181D19B40 Slot: 62
	public virtual void set_MaxDepth(Nullable<int> value) { }

	// RVA: 0x1D19170 Offset: 0x1D17B70 VA: 0x181D19170 Slot: 63
	public virtual bool get_CheckAdditionalContent() { }

	// RVA: 0x1D196C0 Offset: 0x1D180C0 VA: 0x181D196C0 Slot: 64
	public virtual void set_CheckAdditionalContent(bool value) { }

	// RVA: 0x1D17BA0 Offset: 0x1D165A0 VA: 0x181D17BA0
	internal bool IsCheckAdditionalContentSet() { }

	// RVA: 0x1D18E60 Offset: 0x1D17860 VA: 0x181D18E60
	public void .ctor() { }

	// RVA: 0x1D17440 Offset: 0x1D15E40 VA: 0x181D17440
	public static JsonSerializer Create() { }

	// RVA: 0x1D17290 Offset: 0x1D15C90 VA: 0x181D17290
	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	// RVA: 0x1D16F80 Offset: 0x1D15980 VA: 0x181D16F80
	public static JsonSerializer CreateDefault() { }

	// RVA: 0x1D171C0 Offset: 0x1D15BC0 VA: 0x181D171C0
	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	// RVA: 0x1D16680 Offset: 0x1D15080 VA: 0x181D16680
	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	// RVA: 0x1D17F10 Offset: 0x1D16910 VA: 0x181D17F10
	public void Populate(TextReader reader, object target) { }

	[DebuggerStepThrough]
	// RVA: 0x1D17EF0 Offset: 0x1D168F0 VA: 0x181D17EF0
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0x1D17C10 Offset: 0x1D16610 VA: 0x181D17C10 Slot: 65
	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	[DebuggerStepThrough]
	// RVA: 0x1D178C0 Offset: 0x1D162C0 VA: 0x181D178C0
	public object Deserialize(JsonReader reader) { }

	[DebuggerStepThrough]
	// RVA: 0x1D17900 Offset: 0x1D16300 VA: 0x181D17900
	public object Deserialize(TextReader reader, Type objectType) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public T Deserialize<T>(JsonReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7490 Offset: 0xEE5E90 VA: 0x180EE7490
	|-JsonSerializer.Deserialize<Int32Enum>
	|
	|-RVA: 0xEE7380 Offset: 0xEE5D80 VA: 0x180EE7380
	|-JsonSerializer.Deserialize<__Il2CppFullySharedGenericType>
	*/

	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: 0x1D178E0 Offset: 0x1D162E0 VA: 0x181D178E0
	public object Deserialize(JsonReader reader, Type objectType) { }

	[NullableContext(2)]
	// RVA: 0x1D175D0 Offset: 0x1D15FD0 VA: 0x181D175D0 Slot: 66
	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	[NullableContext(2)]
	// RVA: 0x1D189E0 Offset: 0x1D173E0 VA: 0x181D189E0
	internal void SetupReader(JsonReader reader, out CultureInfo previousCulture, out Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, out Nullable<DateParseHandling> previousDateParseHandling, out Nullable<FloatParseHandling> previousFloatParseHandling, out Nullable<int> previousMaxDepth, out string previousDateFormatString) { }

	[NullableContext(2)]
	// RVA: 0x1D17FA0 Offset: 0x1D169A0 VA: 0x181D17FA0
	private void ResetReader(JsonReader reader, CultureInfo previousCulture, Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, Nullable<DateParseHandling> previousDateParseHandling, Nullable<FloatParseHandling> previousFloatParseHandling, Nullable<int> previousMaxDepth, string previousDateFormatString) { }

	// RVA: 0x1D18920 Offset: 0x1D17320 VA: 0x181D18920
	public void Serialize(TextWriter textWriter, object value) { }

	[NullableContext(2)]
	// RVA: 0x1D18900 Offset: 0x1D17300 VA: 0x181D18900
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x1D18860 Offset: 0x1D17260 VA: 0x181D18860
	public void Serialize(TextWriter textWriter, object value, Type objectType) { }

	// RVA: 0x1D189B0 Offset: 0x1D173B0 VA: 0x181D189B0
	public void Serialize(JsonWriter jsonWriter, object value) { }

	// RVA: 0x1D17200 Offset: 0x1D15C00 VA: 0x181D17200
	private TraceJsonReader CreateTraceJsonReader(JsonReader reader) { }

	[NullableContext(2)]
	// RVA: 0x1D182A0 Offset: 0x1D16CA0 VA: 0x181D182A0 Slot: 67
	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x1D17B30 Offset: 0x1D16530 VA: 0x181D17B30
	internal IReferenceResolver GetReferenceResolver() { }

	// RVA: 0x1D17990 Offset: 0x1D16390 VA: 0x181D17990
	internal JsonConverter GetMatchingConverter(Type type) { }

	// RVA: 0x1D17A60 Offset: 0x1D16460 VA: 0x181D17A60
	internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType) { }

	// RVA: 0x1D17BE0 Offset: 0x1D165E0 VA: 0x181D17BE0
	internal void OnError(ErrorEventArgs e) { }
}
