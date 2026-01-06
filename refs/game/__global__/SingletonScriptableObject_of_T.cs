public abstract class SingletonScriptableObject<T> : ScriptableObject // TypeDefIndex: 18203
{
	// Fields
	private static T _instance; // 0x0

	// Properties
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C2B60 Offset: 0x11C1560 VA: 0x1811C2B60
	|-SingletonScriptableObject<object>.get_Instance
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	|-SingletonScriptableObject<object>..ctor
	*/
}
