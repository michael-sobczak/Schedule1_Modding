internal sealed class SerializationEvents // TypeDefIndex: 4425
{
	// Fields
	private readonly List<MethodInfo> _onSerializingMethods; // 0x10
	private readonly List<MethodInfo> _onSerializedMethods; // 0x18
	private readonly List<MethodInfo> _onDeserializingMethods; // 0x20
	private readonly List<MethodInfo> _onDeserializedMethods; // 0x28

	// Properties
	internal bool HasOnSerializingEvents { get; }

	// Methods

	// RVA: 0x1B40400 Offset: 0x1B3EE00 VA: 0x181B40400
	internal void .ctor(Type t) { }

	// RVA: 0x1B400D0 Offset: 0x1B3EAD0 VA: 0x181B400D0
	private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t) { }

	// RVA: 0x1B40550 Offset: 0x1B3EF50 VA: 0x181B40550
	internal bool get_HasOnSerializingEvents() { }

	// RVA: 0x1B403B0 Offset: 0x1B3EDB0 VA: 0x181B403B0
	internal void InvokeOnSerializing(object obj, StreamingContext context) { }

	// RVA: 0x1B40360 Offset: 0x1B3ED60 VA: 0x181B40360
	internal void InvokeOnDeserializing(object obj, StreamingContext context) { }

	// RVA: 0x1B40310 Offset: 0x1B3ED10 VA: 0x181B40310
	internal void InvokeOnDeserialized(object obj, StreamingContext context) { }

	// RVA: 0x1B400B0 Offset: 0x1B3EAB0 VA: 0x181B400B0
	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler) { }

	// RVA: 0x1B40090 Offset: 0x1B3EA90 VA: 0x181B40090
	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler) { }

	// RVA: 0x1B402D0 Offset: 0x1B3ECD0 VA: 0x181B402D0
	private static void InvokeOnDelegate(object obj, StreamingContext context, List<MethodInfo> methods) { }

	// RVA: 0x1B3FE90 Offset: 0x1B3E890 VA: 0x181B3FE90
	private static SerializationEventHandler AddOnDelegate(object obj, SerializationEventHandler handler, List<MethodInfo> methods) { }
}
