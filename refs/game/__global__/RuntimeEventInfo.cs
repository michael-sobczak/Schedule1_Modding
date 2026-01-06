internal sealed class RuntimeEventInfo : EventInfo, ISerializable // TypeDefIndex: 4754
{
	// Fields
	private IntPtr klass; // 0x18
	private IntPtr handle; // 0x20

	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override string Name { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x1B92EB0 Offset: 0x1B918B0 VA: 0x181B92EB0
	private static void get_event_info(RuntimeEventInfo ev, out MonoEventInfo info) { }

	// RVA: 0x1B929F0 Offset: 0x1B913F0 VA: 0x181B929F0
	internal static MonoEventInfo GetEventInfo(RuntimeEventInfo ev) { }

	// RVA: 0x1B92C60 Offset: 0x1B91660 VA: 0x181B92C60 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x1B92740 Offset: 0x1B91140 VA: 0x181B92740
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x1B92970 Offset: 0x1B91370 VA: 0x181B92970
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x1B92E00 Offset: 0x1B91800 VA: 0x181B92E00
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x1B92C60 Offset: 0x1B91660 VA: 0x181B92C60
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x1B92A30 Offset: 0x1B91430 VA: 0x181B92A30 Slot: 22
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B92740 Offset: 0x1B91140 VA: 0x181B92740
	internal BindingFlags GetBindingFlags() { }

	// RVA: 0x1B926C0 Offset: 0x1B910C0 VA: 0x181B926C0 Slot: 18
	public override MethodInfo GetAddMethod(bool nonPublic) { }

	// RVA: 0x1B92B60 Offset: 0x1B91560 VA: 0x181B92B60 Slot: 20
	public override MethodInfo GetRaiseMethod(bool nonPublic) { }

	// RVA: 0x1B92BE0 Offset: 0x1B915E0 VA: 0x181B92BE0 Slot: 19
	public override MethodInfo GetRemoveMethod(bool nonPublic) { }

	// RVA: 0x1B92DA0 Offset: 0x1B917A0 VA: 0x181B92DA0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x1B92E80 Offset: 0x1B91880 VA: 0x181B92E80 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1B92DD0 Offset: 0x1B917D0 VA: 0x181B92DD0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1B92D00 Offset: 0x1B91700 VA: 0x181B92D00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B92C90 Offset: 0x1B91690 VA: 0x181B92C90 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1B92910 Offset: 0x1B91310 VA: 0x181B92910 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B928A0 Offset: 0x1B912A0 VA: 0x181B928A0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B92620 Offset: 0x1B91020 VA: 0x181B92620 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x1B92620 Offset: 0x1B91020 VA: 0x181B92620
	internal static int get_metadata_token(RuntimeEventInfo monoEvent) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
