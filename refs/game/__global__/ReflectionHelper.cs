internal class ReflectionHelper // TypeDefIndex: 18886
{
	// Fields
	private static readonly BindingFlags _allBindings; // 0x0
	private static readonly BindingFlags _staticBindings; // 0x4
	private static Dictionary<string, MethodInfo> _methodCache; // 0x8
	private static Dictionary<string, Type> _typeNameCache; // 0x10
	private static Dictionary<Type, Type[]> _typeCache; // 0x18

	// Methods

	// RVA: -1 Offset: -1
	public static object GetPropertyValue<T>(object obj, string propertyName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF304A0 Offset: 0xF2EEA0 VA: 0x180F304A0
	|-ReflectionHelper.GetPropertyValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static object GetPropertyValue<T>(string propertyName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF30590 Offset: 0xF2EF90 VA: 0x180F30590
	|-ReflectionHelper.GetPropertyValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Invoke<T>(object obj, string methodName, object[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF30DE0 Offset: 0xF2F7E0 VA: 0x180F30DE0
	|-ReflectionHelper.Invoke<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Invoke<T>(string methodName, object[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF30B70 Offset: 0xF2F570 VA: 0x180F30B70
	|-ReflectionHelper.Invoke<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2F6FD80 Offset: 0x2F6E780 VA: 0x182F6FD80
	public static bool Invoke(string typeName, string methodName, object[] parameters) { }

	// RVA: -1 Offset: -1
	public static bool Invoke<T>(string typeName, string methodName, out T returnValue, object[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF30A10 Offset: 0xF2F410 VA: 0x180F30A10
	|-ReflectionHelper.Invoke<bool>
	|
	|-RVA: 0xF30F60 Offset: 0xF2F960 VA: 0x180F30F60
	|-ReflectionHelper.Invoke<int>
	|
	|-RVA: 0xF30C30 Offset: 0xF2F630 VA: 0x180F30C30
	|-ReflectionHelper.Invoke<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Type[] GetTypesDerivedFrom<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF30660 Offset: 0xF2F060 VA: 0x180F30660
	|-ReflectionHelper.GetTypesDerivedFrom<object>
	*/

	// RVA: 0x2F6FB30 Offset: 0x2F6E530 VA: 0x182F6FB30
	public static Type GetType(string fullName) { }

	// RVA: 0x2F6FE70 Offset: 0x2F6E870 VA: 0x182F6FE70
	private static bool Invoke(Type type, string methodName, out object returnValue, object[] parameters) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x2F700C0 Offset: 0x2F6EAC0 VA: 0x182F700C0
	private static void .cctor() { }
}
