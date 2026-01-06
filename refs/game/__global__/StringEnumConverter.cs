public class StringEnumConverter : JsonConverter // TypeDefIndex: 11406
{
	// Fields
	[Nullable(2)]
	[CompilerGenerated]
	private NamingStrategy <NamingStrategy>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <AllowIntegerValues>k__BackingField; // 0x18

	// Properties
	[Obsolete("StringEnumConverter.CamelCaseText is obsolete. Set StringEnumConverter.NamingStrategy with CamelCaseNamingStrategy instead.")]
	public bool CamelCaseText { get; set; }
	[Nullable(2)]
	public NamingStrategy NamingStrategy { get; set; }
	public bool AllowIntegerValues { get; set; }

	// Methods

	// RVA: 0x1DF1F50 Offset: 0x1DF0950 VA: 0x181DF1F50
	public bool get_CamelCaseText() { }

	// RVA: 0x1DF1FC0 Offset: 0x1DF09C0 VA: 0x181DF1FC0
	public void set_CamelCaseText(bool value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public NamingStrategy get_NamingStrategy() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_NamingStrategy(NamingStrategy value) { }

	[CompilerGenerated]
	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	public bool get_AllowIntegerValues() { }

	[CompilerGenerated]
	// RVA: 0x698000 Offset: 0x696A00 VA: 0x180698000
	public void set_AllowIntegerValues(bool value) { }

	// RVA: 0x1DF1D30 Offset: 0x1DF0730 VA: 0x181DF1D30
	public void .ctor() { }

	[Obsolete("StringEnumConverter(bool) is obsolete. Create a converter with StringEnumConverter(NamingStrategy, bool) instead.")]
	// RVA: 0x1DF1CB0 Offset: 0x1DF06B0 VA: 0x181DF1CB0
	public void .ctor(bool camelCaseText) { }

	// RVA: 0x1DF1C60 Offset: 0x1DF0660 VA: 0x181DF1C60
	public void .ctor(NamingStrategy namingStrategy, bool allowIntegerValues = True) { }

	// RVA: 0x1DF1D40 Offset: 0x1DF0740 VA: 0x181DF1D40
	public void .ctor(Type namingStrategyType) { }

	// RVA: 0x1DF1DE0 Offset: 0x1DF07E0 VA: 0x181DF1DE0
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters) { }

	// RVA: 0x1DF1E90 Offset: 0x1DF0890 VA: 0x181DF1E90
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues) { }

	// RVA: 0x1DF1A50 Offset: 0x1DF0450 VA: 0x181DF1A50 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1DF15E0 Offset: 0x1DEFFE0 VA: 0x181DF15E0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1DF1570 Offset: 0x1DEFF70 VA: 0x181DF1570 Slot: 6
	public override bool CanConvert(Type objectType) { }
}
