public abstract class Attribute // TypeDefIndex: 3800
{
	// Properties
	public virtual object TypeId { get; }

	// Methods

	// RVA: 0x1C99B10 Offset: 0x1C98510 VA: 0x181C99B10
	private static Attribute[] InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit) { }

	// RVA: 0x1C99A60 Offset: 0x1C98460 VA: 0x181C99A60
	private static Attribute[] InternalGetCustomAttributes(EventInfo element, Type type, bool inherit) { }

	// RVA: 0x1C99CA0 Offset: 0x1C986A0 VA: 0x181C99CA0
	private static Attribute[] InternalParamGetCustomAttributes(ParameterInfo parameter, Type attributeType, bool inherit) { }

	// RVA: 0x1C99C30 Offset: 0x1C98630 VA: 0x181C99C30
	private static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x1C99BC0 Offset: 0x1C985C0 VA: 0x181C99BC0
	private static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x1C98A70 Offset: 0x1C97470 VA: 0x181C98A70
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type) { }

	// RVA: 0x1C98E60 Offset: 0x1C97860 VA: 0x181C98E60
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type, bool inherit) { }

	// RVA: 0x1C98740 Offset: 0x1C97140 VA: 0x181C98740
	public static Attribute[] GetCustomAttributes(MemberInfo element) { }

	// RVA: 0x1C996A0 Offset: 0x1C980A0 VA: 0x181C996A0
	public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit) { }

	// RVA: 0x1C9A190 Offset: 0x1C98B90 VA: 0x181C9A190
	public static bool IsDefined(MemberInfo element, Type attributeType) { }

	// RVA: 0x1C9A1A0 Offset: 0x1C98BA0 VA: 0x181C9A1A0
	public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x1C98480 Offset: 0x1C96E80 VA: 0x181C98480
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	// RVA: 0x1C983D0 Offset: 0x1C96DD0 VA: 0x181C983D0
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x1C98750 Offset: 0x1C97150 VA: 0x181C98750
	public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x1C98530 Offset: 0x1C96F30 VA: 0x181C98530
	public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit) { }

	// RVA: 0x1C98D00 Offset: 0x1C97700 VA: 0x181C98D00
	public static Attribute[] GetCustomAttributes(Module element, bool inherit) { }

	// RVA: 0x1C99190 Offset: 0x1C97B90 VA: 0x181C99190
	public static Attribute[] GetCustomAttributes(Module element, Type attributeType, bool inherit) { }

	// RVA: 0x1C98730 Offset: 0x1C97130 VA: 0x181C98730
	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType) { }

	// RVA: 0x1C98A80 Offset: 0x1C97480 VA: 0x181C98A80
	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit) { }

	// RVA: 0x1C99570 Offset: 0x1C97F70 VA: 0x181C99570
	public static Attribute[] GetCustomAttributes(Assembly element) { }

	// RVA: 0x1C99430 Offset: 0x1C97E30 VA: 0x181C99430
	public static Attribute[] GetCustomAttributes(Assembly element, bool inherit) { }

	// RVA: 0x1C98320 Offset: 0x1C96D20 VA: 0x181C98320
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	// RVA: 0x1C98270 Offset: 0x1C96C70 VA: 0x181C98270
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x1C98000 Offset: 0x1C96A00 VA: 0x181C98000 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C97E20 Offset: 0x1C96820 VA: 0x181C97E20
	private static bool AreFieldValuesEqual(object thisValue, object thatValue) { }

	// RVA: 0x1C998E0 Offset: 0x1C982E0 VA: 0x181C998E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C8F6B0 Offset: 0x1C8E0B0 VA: 0x181C8F6B0 Slot: 4
	public virtual object get_TypeId() { }

	// RVA: 0x1C9A500 Offset: 0x1C98F00 VA: 0x181C9A500 Slot: 5
	public virtual bool Match(object obj) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 6
	public virtual bool IsDefaultAttribute() { }
}
