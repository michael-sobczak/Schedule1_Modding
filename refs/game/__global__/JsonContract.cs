public abstract class JsonContract // TypeDefIndex: 11245
{
	// Fields
	internal bool IsNullable; // 0x10
	internal bool IsConvertable; // 0x11
	internal bool IsEnum; // 0x12
	internal Type NonNullableUnderlyingType; // 0x18
	internal ReadType InternalReadType; // 0x20
	internal JsonContractType ContractType; // 0x24
	internal bool IsReadOnlyOrFixedSize; // 0x28
	internal bool IsSealed; // 0x29
	internal bool IsInstantiable; // 0x2A
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onDeserializedCallbacks; // 0x30
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onDeserializingCallbacks; // 0x38
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onSerializedCallbacks; // 0x40
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onSerializingCallbacks; // 0x48
	[Nullable(new[] { 2, 1 })]
	private List<SerializationErrorCallback> _onErrorCallbacks; // 0x50
	private Type _createdType; // 0x58
	[CompilerGenerated]
	private readonly Type <UnderlyingType>k__BackingField; // 0x60
	[CompilerGenerated]
	private Nullable<bool> <IsReference>k__BackingField; // 0x68
	[Nullable(2)]
	[CompilerGenerated]
	private JsonConverter <Converter>k__BackingField; // 0x70
	[Nullable(2)]
	[CompilerGenerated]
	private JsonConverter <InternalConverter>k__BackingField; // 0x78
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private Func<object> <DefaultCreator>k__BackingField; // 0x80
	[CompilerGenerated]
	private bool <DefaultCreatorNonPublic>k__BackingField; // 0x88

	// Properties
	public Type UnderlyingType { get; }
	public Type CreatedType { get; set; }
	public Nullable<bool> IsReference { get; set; }
	[Nullable(2)]
	public JsonConverter Converter { get; set; }
	[Nullable(2)]
	public JsonConverter InternalConverter { get; set; }
	public IList<SerializationCallback> OnDeserializedCallbacks { get; }
	public IList<SerializationCallback> OnDeserializingCallbacks { get; }
	public IList<SerializationCallback> OnSerializedCallbacks { get; }
	public IList<SerializationCallback> OnSerializingCallbacks { get; }
	public IList<SerializationErrorCallback> OnErrorCallbacks { get; }
	[Nullable(new[] { 2, 1 })]
	public Func<object> DefaultCreator { get; set; }
	public bool DefaultCreatorNonPublic { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public Type get_UnderlyingType() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public Type get_CreatedType() { }

	// RVA: 0x1D82680 Offset: 0x1D81080 VA: 0x181D82680
	public void set_CreatedType(Type value) { }

	[CompilerGenerated]
	// RVA: 0xCC6390 Offset: 0xCC4D90 VA: 0x180CC6390
	public Nullable<bool> get_IsReference() { }

	[CompilerGenerated]
	// RVA: 0xCC6450 Offset: 0xCC4E50 VA: 0x180CC6450
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public JsonConverter get_Converter() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	public void set_Converter(JsonConverter value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public JsonConverter get_InternalConverter() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	internal void set_InternalConverter(JsonConverter value) { }

	// RVA: 0x1D82400 Offset: 0x1D80E00 VA: 0x181D82400
	public IList<SerializationCallback> get_OnDeserializedCallbacks() { }

	// RVA: 0x1D82480 Offset: 0x1D80E80 VA: 0x181D82480
	public IList<SerializationCallback> get_OnDeserializingCallbacks() { }

	// RVA: 0x1D82580 Offset: 0x1D80F80 VA: 0x181D82580
	public IList<SerializationCallback> get_OnSerializedCallbacks() { }

	// RVA: 0x1D82600 Offset: 0x1D81000 VA: 0x181D82600
	public IList<SerializationCallback> get_OnSerializingCallbacks() { }

	// RVA: 0x1D82500 Offset: 0x1D80F00 VA: 0x181D82500
	public IList<SerializationErrorCallback> get_OnErrorCallbacks() { }

	[CompilerGenerated]
	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public Func<object> get_DefaultCreator() { }

	[CompilerGenerated]
	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	public void set_DefaultCreator(Func<object> value) { }

	[CompilerGenerated]
	// RVA: 0xDA2600 Offset: 0xDA1000 VA: 0x180DA2600
	public bool get_DefaultCreatorNonPublic() { }

	[CompilerGenerated]
	// RVA: 0xDA2C80 Offset: 0xDA1680 VA: 0x180DA2C80
	public void set_DefaultCreatorNonPublic(bool value) { }

	// RVA: 0x1D82250 Offset: 0x1D80C50 VA: 0x181D82250
	internal void .ctor(Type underlyingType) { }

	// RVA: 0x1D82120 Offset: 0x1D80B20 VA: 0x181D82120
	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	// RVA: 0x1D81FF0 Offset: 0x1D809F0 VA: 0x181D81FF0
	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	// RVA: 0x1D81D70 Offset: 0x1D80770 VA: 0x181D81D70
	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	// RVA: 0x1D81C40 Offset: 0x1D80640 VA: 0x181D81C40
	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	// RVA: 0x1D81EA0 Offset: 0x1D808A0 VA: 0x181D81EA0
	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0x1D81A00 Offset: 0x1D80400 VA: 0x181D81A00
	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	// RVA: 0x1D81AB0 Offset: 0x1D804B0 VA: 0x181D81AB0
	internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) { }
}
