public class JsonSerializerSettings // TypeDefIndex: 11014
{
	// Fields
	internal const ReferenceLoopHandling DefaultReferenceLoopHandling = 0;
	internal const MissingMemberHandling DefaultMissingMemberHandling = 0;
	internal const NullValueHandling DefaultNullValueHandling = 0;
	internal const DefaultValueHandling DefaultDefaultValueHandling = 0;
	internal const ObjectCreationHandling DefaultObjectCreationHandling = 0;
	internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = 0;
	internal const ConstructorHandling DefaultConstructorHandling = 0;
	internal const TypeNameHandling DefaultTypeNameHandling = 0;
	internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = 0;
	internal static readonly StreamingContext DefaultContext; // 0x0
	internal const Formatting DefaultFormatting = 0;
	internal const DateFormatHandling DefaultDateFormatHandling = 0;
	internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = 3;
	internal const DateParseHandling DefaultDateParseHandling = 1;
	internal const FloatParseHandling DefaultFloatParseHandling = 0;
	internal const FloatFormatHandling DefaultFloatFormatHandling = 0;
	internal const StringEscapeHandling DefaultStringEscapeHandling = 0;
	internal const TypeNameAssemblyFormatHandling DefaultTypeNameAssemblyFormatHandling = 0;
	[Nullable(1)]
	internal static readonly CultureInfo DefaultCulture; // 0x10
	internal const bool DefaultCheckAdditionalContent = False;
	[Nullable(1)]
	internal const string DefaultDateFormatString = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.FFFFFFFK";
	internal const int DefaultMaxDepth = 64;
	internal Nullable<Formatting> _formatting; // 0x10
	internal Nullable<DateFormatHandling> _dateFormatHandling; // 0x18
	internal Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; // 0x20
	internal Nullable<DateParseHandling> _dateParseHandling; // 0x28
	internal Nullable<FloatFormatHandling> _floatFormatHandling; // 0x30
	internal Nullable<FloatParseHandling> _floatParseHandling; // 0x38
	internal Nullable<StringEscapeHandling> _stringEscapeHandling; // 0x40
	internal CultureInfo _culture; // 0x48
	internal Nullable<bool> _checkAdditionalContent; // 0x50
	internal Nullable<int> _maxDepth; // 0x54
	internal bool _maxDepthSet; // 0x5C
	internal string _dateFormatString; // 0x60
	internal bool _dateFormatStringSet; // 0x68
	internal Nullable<TypeNameAssemblyFormatHandling> _typeNameAssemblyFormatHandling; // 0x6C
	internal Nullable<DefaultValueHandling> _defaultValueHandling; // 0x74
	internal Nullable<PreserveReferencesHandling> _preserveReferencesHandling; // 0x7C
	internal Nullable<NullValueHandling> _nullValueHandling; // 0x84
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; // 0x8C
	internal Nullable<MissingMemberHandling> _missingMemberHandling; // 0x94
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; // 0x9C
	internal Nullable<StreamingContext> _context; // 0xA8
	internal Nullable<ConstructorHandling> _constructorHandling; // 0xC0
	internal Nullable<TypeNameHandling> _typeNameHandling; // 0xC8
	internal Nullable<MetadataPropertyHandling> _metadataPropertyHandling; // 0xD0
	[Nullable(1)]
	[CompilerGenerated]
	private IList<JsonConverter> <Converters>k__BackingField; // 0xD8
	[CompilerGenerated]
	private IContractResolver <ContractResolver>k__BackingField; // 0xE0
	[CompilerGenerated]
	private IEqualityComparer <EqualityComparer>k__BackingField; // 0xE8
	[CompilerGenerated]
	private Func<IReferenceResolver> <ReferenceResolverProvider>k__BackingField; // 0xF0
	[CompilerGenerated]
	private ITraceWriter <TraceWriter>k__BackingField; // 0xF8
	[CompilerGenerated]
	private ISerializationBinder <SerializationBinder>k__BackingField; // 0x100
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private EventHandler<ErrorEventArgs> <Error>k__BackingField; // 0x108

	// Properties
	public ReferenceLoopHandling ReferenceLoopHandling { get; set; }
	public MissingMemberHandling MissingMemberHandling { get; set; }
	public ObjectCreationHandling ObjectCreationHandling { get; set; }
	public NullValueHandling NullValueHandling { get; set; }
	public DefaultValueHandling DefaultValueHandling { get; set; }
	[Nullable(1)]
	public IList<JsonConverter> Converters { get; set; }
	public PreserveReferencesHandling PreserveReferencesHandling { get; set; }
	public TypeNameHandling TypeNameHandling { get; set; }
	public MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	public FormatterAssemblyStyle TypeNameAssemblyFormat { get; set; }
	public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { get; set; }
	public ConstructorHandling ConstructorHandling { get; set; }
	public IContractResolver ContractResolver { get; set; }
	public IEqualityComparer EqualityComparer { get; set; }
	[Obsolete("ReferenceResolver property is obsolete. Use the ReferenceResolverProvider property to set the IReferenceResolver: settings.ReferenceResolverProvider = () => resolver")]
	public IReferenceResolver ReferenceResolver { get; set; }
	public Func<IReferenceResolver> ReferenceResolverProvider { get; set; }
	public ITraceWriter TraceWriter { get; set; }
	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	public SerializationBinder Binder { get; set; }
	public ISerializationBinder SerializationBinder { get; set; }
	[Nullable(new[] { 2, 1 })]
	public EventHandler<ErrorEventArgs> Error { get; set; }
	public StreamingContext Context { get; set; }
	[Nullable(1)]
	public string DateFormatString { get; set; }
	public Nullable<int> MaxDepth { get; set; }
	public Formatting Formatting { get; set; }
	public DateFormatHandling DateFormatHandling { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public DateParseHandling DateParseHandling { get; set; }
	public FloatFormatHandling FloatFormatHandling { get; set; }
	public FloatParseHandling FloatParseHandling { get; set; }
	public StringEscapeHandling StringEscapeHandling { get; set; }
	[Nullable(1)]
	public CultureInfo Culture { get; set; }
	public bool CheckAdditionalContent { get; set; }

	// Methods

	// RVA: 0x1D15BC0 Offset: 0x1D145C0 VA: 0x181D15BC0
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0x1D16420 Offset: 0x1D14E20 VA: 0x181D16420
	public void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x1D15AC0 Offset: 0x1D144C0 VA: 0x181D15AC0
	public MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0x1D162A0 Offset: 0x1D14CA0 VA: 0x181D162A0
	public void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x1D15B40 Offset: 0x1D14540 VA: 0x181D15B40
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0x1D16360 Offset: 0x1D14D60 VA: 0x181D16360
	public void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x1D15B00 Offset: 0x1D14500 VA: 0x181D15B00
	public NullValueHandling get_NullValueHandling() { }

	// RVA: 0x1D16300 Offset: 0x1D14D00 VA: 0x181D16300
	public void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x1D15920 Offset: 0x1D14320 VA: 0x181D15920
	public DefaultValueHandling get_DefaultValueHandling() { }

	// RVA: 0x1D16000 Offset: 0x1D14A00 VA: 0x181D16000
	public void set_DefaultValueHandling(DefaultValueHandling value) { }

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x4E8C90 Offset: 0x4E7690 VA: 0x1804E8C90
	public IList<JsonConverter> get_Converters() { }

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x4E8E20 Offset: 0x4E7820 VA: 0x1804E8E20
	public void set_Converters(IList<JsonConverter> value) { }

	// RVA: 0x1D15B80 Offset: 0x1D14580 VA: 0x181D15B80
	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0x1D163C0 Offset: 0x1D14DC0 VA: 0x181D163C0
	public void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0x1D15CA0 Offset: 0x1D146A0 VA: 0x181D15CA0
	public TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0x1D16620 Offset: 0x1D15020 VA: 0x181D16620
	public void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x1D15A80 Offset: 0x1D14480 VA: 0x181D15A80
	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x1D16240 Offset: 0x1D14C40 VA: 0x181D16240
	public void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0x1D15C60 Offset: 0x1D14660 VA: 0x181D15C60
	public FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	// RVA: 0x1D165C0 Offset: 0x1D14FC0 VA: 0x181D165C0
	public void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x1D15C60 Offset: 0x1D14660 VA: 0x181D15C60
	public TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	// RVA: 0x1D165C0 Offset: 0x1D14FC0 VA: 0x181D165C0
	public void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0x1D156A0 Offset: 0x1D140A0 VA: 0x181D156A0
	public ConstructorHandling get_ConstructorHandling() { }

	// RVA: 0x1D15DD0 Offset: 0x1D147D0 VA: 0x181D15DD0
	public void set_ConstructorHandling(ConstructorHandling value) { }

	[CompilerGenerated]
	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	public IContractResolver get_ContractResolver() { }

	[CompilerGenerated]
	// RVA: 0x4E8E40 Offset: 0x4E7840 VA: 0x1804E8E40
	public void set_ContractResolver(IContractResolver value) { }

	[CompilerGenerated]
	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0
	public IEqualityComparer get_EqualityComparer() { }

	[CompilerGenerated]
	// RVA: 0x4E8E60 Offset: 0x4E7860 VA: 0x1804E8E60
	public void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0x1D15C00 Offset: 0x1D14600 VA: 0x181D15C00
	public IReferenceResolver get_ReferenceResolver() { }

	// RVA: 0x1D16480 Offset: 0x1D14E80 VA: 0x181D16480
	public void set_ReferenceResolver(IReferenceResolver value) { }

	[CompilerGenerated]
	// RVA: 0x5162A0 Offset: 0x514CA0 VA: 0x1805162A0
	public Func<IReferenceResolver> get_ReferenceResolverProvider() { }

	[CompilerGenerated]
	// RVA: 0x605200 Offset: 0x603C00 VA: 0x180605200
	public void set_ReferenceResolverProvider(Func<IReferenceResolver> value) { }

	[CompilerGenerated]
	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170
	public ITraceWriter get_TraceWriter() { }

	[CompilerGenerated]
	// RVA: 0x605220 Offset: 0x603C20 VA: 0x180605220
	public void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0x1D155A0 Offset: 0x1D13FA0 VA: 0x181D155A0
	public SerializationBinder get_Binder() { }

	// RVA: 0x1D15CE0 Offset: 0x1D146E0 VA: 0x181D15CE0
	public void set_Binder(SerializationBinder value) { }

	[CompilerGenerated]
	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	public ISerializationBinder get_SerializationBinder() { }

	[CompilerGenerated]
	// RVA: 0x51DD20 Offset: 0x51C720 VA: 0x18051DD20
	public void set_SerializationBinder(ISerializationBinder value) { }

	[CompilerGenerated]
	// RVA: 0x516260 Offset: 0x514C60 VA: 0x180516260
	public EventHandler<ErrorEventArgs> get_Error() { }

	[CompilerGenerated]
	// RVA: 0x505FC0 Offset: 0x5049C0 VA: 0x180505FC0
	public void set_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0x1D156E0 Offset: 0x1D140E0 VA: 0x181D156E0
	public StreamingContext get_Context() { }

	// RVA: 0x1D15E30 Offset: 0x1D14830 VA: 0x181D15E30
	public void set_Context(StreamingContext value) { }

	[NullableContext(1)]
	// RVA: 0x1D15840 Offset: 0x1D14240 VA: 0x181D15840
	public string get_DateFormatString() { }

	[NullableContext(1)]
	// RVA: 0x1D15F20 Offset: 0x1D14920 VA: 0x181D15F20
	public void set_DateFormatString(string value) { }

	// RVA: 0x1D15A20 Offset: 0x1D14420 VA: 0x181D15A20
	public Nullable<int> get_MaxDepth() { }

	// RVA: 0x1D16180 Offset: 0x1D14B80 VA: 0x181D16180
	public void set_MaxDepth(Nullable<int> value) { }

	// RVA: 0x1D159E0 Offset: 0x1D143E0 VA: 0x181D159E0
	public Formatting get_Formatting() { }

	// RVA: 0x1D16120 Offset: 0x1D14B20 VA: 0x181D16120
	public void set_Formatting(Formatting value) { }

	// RVA: 0x1D15800 Offset: 0x1D14200 VA: 0x181D15800
	public DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0x1D15EC0 Offset: 0x1D148C0 VA: 0x181D15EC0
	public void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0x1D158D0 Offset: 0x1D142D0 VA: 0x181D158D0
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0x1D15FA0 Offset: 0x1D149A0 VA: 0x181D15FA0
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x1D15880 Offset: 0x1D14280 VA: 0x181D15880
	public DateParseHandling get_DateParseHandling() { }

	// RVA: 0x1D15F40 Offset: 0x1D14940 VA: 0x181D15F40
	public void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0x1D15960 Offset: 0x1D14360 VA: 0x181D15960
	public FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0x1D16060 Offset: 0x1D14A60 VA: 0x181D16060
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	// RVA: 0x1D159A0 Offset: 0x1D143A0 VA: 0x181D159A0
	public FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0x1D160C0 Offset: 0x1D14AC0 VA: 0x181D160C0
	public void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0x1D15C20 Offset: 0x1D14620 VA: 0x181D15C20
	public StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0x1D16560 Offset: 0x1D14F60 VA: 0x181D16560
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	[NullableContext(1)]
	// RVA: 0x1D157A0 Offset: 0x1D141A0 VA: 0x181D157A0
	public CultureInfo get_Culture() { }

	[NullableContext(1)]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_Culture(CultureInfo value) { }

	// RVA: 0x1D15660 Offset: 0x1D14060 VA: 0x181D15660
	public bool get_CheckAdditionalContent() { }

	// RVA: 0x1D15D70 Offset: 0x1D14770 VA: 0x181D15D70
	public void set_CheckAdditionalContent(bool value) { }

	// RVA: 0x1D15250 Offset: 0x1D13C50 VA: 0x181D15250
	private static void .cctor() { }

	[DebuggerStepThrough]
	// RVA: 0x1D15520 Offset: 0x1D13F20 VA: 0x181D15520
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x1D152E0 Offset: 0x1D13CE0 VA: 0x181D152E0
	public void .ctor(JsonSerializerSettings original) { }
}
