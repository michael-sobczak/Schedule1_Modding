public static class ComponentSingleton<TType> // TypeDefIndex: 13557
{
	// Fields
	private static TType s_Instance; // 0x0

	// Properties
	public static TType instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static TType get_instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B5F50 Offset: 0x14B4950 VA: 0x1814B5F50
	|-ComponentSingleton<object>.get_instance
	*/

	// RVA: -1 Offset: -1
	public static void Release() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B5DF0 Offset: 0x14B47F0 VA: 0x1814B5DF0
	|-ComponentSingleton<object>.Release
	*/
}
