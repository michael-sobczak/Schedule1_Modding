public class JsonObjectContract : JsonContainerContract // TypeDefIndex: 11251
{
	// Fields
	[CompilerGenerated]
	private MemberSerialization <MemberSerialization>k__BackingField; // 0xC0
	[CompilerGenerated]
	private Nullable<MissingMemberHandling> <MissingMemberHandling>k__BackingField; // 0xC4
	[CompilerGenerated]
	private Nullable<Required> <ItemRequired>k__BackingField; // 0xCC
	[CompilerGenerated]
	private Nullable<NullValueHandling> <ItemNullValueHandling>k__BackingField; // 0xD4
	[CompilerGenerated]
	[Nullable(1)]
	private readonly JsonPropertyCollection <Properties>k__BackingField; // 0xE0
	[CompilerGenerated]
	private ExtensionDataSetter <ExtensionDataSetter>k__BackingField; // 0xE8
	[CompilerGenerated]
	private ExtensionDataGetter <ExtensionDataGetter>k__BackingField; // 0xF0
	[Nullable(new[] { 2, 1, 1 })]
	[CompilerGenerated]
	private Func<string, string> <ExtensionDataNameResolver>k__BackingField; // 0xF8
	internal bool ExtensionDataIsJToken; // 0x100
	private Nullable<bool> _hasRequiredOrDefaultValueProperties; // 0x101
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _overrideCreator; // 0x108
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _parameterizedCreator; // 0x110
	private JsonPropertyCollection _creatorParameters; // 0x118
	private Type _extensionDataValueType; // 0x120

	// Properties
	public MemberSerialization MemberSerialization { get; set; }
	public Nullable<MissingMemberHandling> MissingMemberHandling { get; set; }
	public Nullable<Required> ItemRequired { get; set; }
	public Nullable<NullValueHandling> ItemNullValueHandling { get; set; }
	[Nullable(1)]
	public JsonPropertyCollection Properties { get; }
	[Nullable(1)]
	public JsonPropertyCollection CreatorParameters { get; }
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> OverrideCreator { get; set; }
	[Nullable(new[] { 2, 1 })]
	internal ObjectConstructor<object> ParameterizedCreator { get; set; }
	public ExtensionDataSetter ExtensionDataSetter { get; set; }
	public ExtensionDataGetter ExtensionDataGetter { get; set; }
	public Type ExtensionDataValueType { get; set; }
	[Nullable(new[] { 2, 1, 1 })]
	public Func<string, string> ExtensionDataNameResolver { get; set; }
	internal bool HasRequiredOrDefaultValueProperties { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x505900 Offset: 0x504300 VA: 0x180505900
	public MemberSerialization get_MemberSerialization() { }

	[CompilerGenerated]
	// RVA: 0x1A3AF30 Offset: 0x1A39930 VA: 0x181A3AF30
	public void set_MemberSerialization(MemberSerialization value) { }

	[CompilerGenerated]
	// RVA: 0x1D84FF0 Offset: 0x1D839F0 VA: 0x181D84FF0
	public Nullable<MissingMemberHandling> get_MissingMemberHandling() { }

	[CompilerGenerated]
	// RVA: 0x1D85110 Offset: 0x1D83B10 VA: 0x181D85110
	public void set_MissingMemberHandling(Nullable<MissingMemberHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x1D84FE0 Offset: 0x1D839E0 VA: 0x181D84FE0
	public Nullable<Required> get_ItemRequired() { }

	[CompilerGenerated]
	// RVA: 0x1D85100 Offset: 0x1D83B00 VA: 0x181D85100
	public void set_ItemRequired(Nullable<Required> value) { }

	[CompilerGenerated]
	// RVA: 0x1D84FD0 Offset: 0x1D839D0 VA: 0x181D84FD0
	public Nullable<NullValueHandling> get_ItemNullValueHandling() { }

	[CompilerGenerated]
	// RVA: 0x1D850F0 Offset: 0x1D83AF0 VA: 0x181D850F0
	public void set_ItemNullValueHandling(Nullable<NullValueHandling> value) { }

	[CompilerGenerated]
	[NullableContext(1)]
	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	public JsonPropertyCollection get_Properties() { }

	[NullableContext(1)]
	// RVA: 0x1D84C70 Offset: 0x1D83670 VA: 0x181D84C70
	public JsonPropertyCollection get_CreatorParameters() { }

	// RVA: 0x516260 Offset: 0x514C60 VA: 0x180516260
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x505FC0 Offset: 0x5049C0 VA: 0x180505FC0
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0x8937F0 Offset: 0x8921F0 VA: 0x1808937F0
	internal void set_ParameterizedCreator(ObjectConstructor<object> value) { }

	[CompilerGenerated]
	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	[CompilerGenerated]
	// RVA: 0x4E8E60 Offset: 0x4E7860 VA: 0x1804E8E60
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	[CompilerGenerated]
	// RVA: 0x5162A0 Offset: 0x514CA0 VA: 0x1805162A0
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	[CompilerGenerated]
	// RVA: 0x605200 Offset: 0x603C00 VA: 0x180605200
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public Type get_ExtensionDataValueType() { }

	// RVA: 0x1D85000 Offset: 0x1D83A00 VA: 0x181D85000
	public void set_ExtensionDataValueType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170
	public Func<string, string> get_ExtensionDataNameResolver() { }

	[CompilerGenerated]
	// RVA: 0x605220 Offset: 0x603C20 VA: 0x180605220
	public void set_ExtensionDataNameResolver(Func<string, string> value) { }

	// RVA: 0x1D84D00 Offset: 0x1D83700 VA: 0x181D84D00
	internal bool get_HasRequiredOrDefaultValueProperties() { }

	[NullableContext(1)]
	// RVA: 0x1D84BE0 Offset: 0x1D835E0 VA: 0x181D84BE0
	public void .ctor(Type underlyingType) { }

	[NullableContext(1)]
	// RVA: 0x1D84AD0 Offset: 0x1D834D0 VA: 0x181D84AD0
	internal object GetUninitializedObject() { }
}
