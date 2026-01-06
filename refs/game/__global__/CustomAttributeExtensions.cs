public static class CustomAttributeExtensions // TypeDefIndex: 4740
{
	// Methods

	[Extension]
	// RVA: 0x1B86C90 Offset: 0x1B85690 VA: 0x181B86C90
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	[Extension]
	// RVA: 0x1B86CA0 Offset: 0x1B856A0 VA: 0x181B86CA0
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(Assembly element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6FAF0 Offset: 0xE6E4F0 VA: 0x180E6FAF0
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6FBB0 Offset: 0xE6E5B0 VA: 0x180E6FBB0
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: 0x1B86CB0 Offset: 0x1B856B0 VA: 0x181B86CB0
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(MemberInfo element, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6FC70 Offset: 0xE6E670 VA: 0x180E6FC70
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: 0x1B86CE0 Offset: 0x1B856E0 VA: 0x181B86CE0
	public static IEnumerable<Attribute> GetCustomAttributes(Assembly element) { }

	[Extension]
	// RVA: 0x1B86CD0 Offset: 0x1B856D0 VA: 0x181B86CD0
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element) { }

	[Extension]
	// RVA: 0x1B86CF0 Offset: 0x1B856F0 VA: 0x181B86CF0
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element, Type attributeType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetCustomAttributes<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6FD40 Offset: 0xE6E740 VA: 0x180E6FD40
	|-CustomAttributeExtensions.GetCustomAttributes<object>
	*/

	[Extension]
	// RVA: 0x1B86CC0 Offset: 0x1B856C0 VA: 0x181B86CC0
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element, Type attributeType, bool inherit) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetCustomAttributes<T>(MemberInfo element, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6FE00 Offset: 0xE6E800 VA: 0x180E6FE00
	|-CustomAttributeExtensions.GetCustomAttributes<object>
	*/

	[Extension]
	// RVA: 0x1B86D00 Offset: 0x1B85700 VA: 0x181B86D00
	public static bool IsDefined(MemberInfo element, Type attributeType) { }
}
