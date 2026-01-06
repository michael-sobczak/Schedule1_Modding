public abstract class EventInfo : MemberInfo // TypeDefIndex: 4695
{
	// Fields
	private EventInfo.AddEventAdapter cached_add_event; // 0x10

	// Properties
	public override MemberTypes MemberType { get; }
	public virtual Type EventHandlerType { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x1B7F190 Offset: 0x1B7DB90 VA: 0x181B7F190 Slot: 16
	public MethodInfo GetAddMethod() { }

	// RVA: 0x1B21EB0 Offset: 0x1B208B0 VA: 0x181B21EB0 Slot: 17
	public MethodInfo GetRemoveMethod() { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract MethodInfo GetAddMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract MethodInfo GetRemoveMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract MethodInfo GetRaiseMethod(bool nonPublic);

	// RVA: 0x1B89280 Offset: 0x1B87C80 VA: 0x181B89280 Slot: 21
	public virtual Type get_EventHandlerType() { }

	// RVA: 0xC82B80 Offset: 0xC81580 VA: 0x180C82B80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B85710 Offset: 0x1B84110 VA: 0x181B85710
	public static bool op_Equality(EventInfo left, EventInfo right) { }

	// RVA: 0x1B893D0 Offset: 0x1B87DD0 VA: 0x181B893D0
	public static bool op_Inequality(EventInfo left, EventInfo right) { }

	// RVA: 0x1B893C0 Offset: 0x1B87DC0 VA: 0x181B893C0
	private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x1B891B0 Offset: 0x1B87BB0 VA: 0x181B891B0
	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType) { }
}
