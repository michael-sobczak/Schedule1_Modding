public static class PathPool // TypeDefIndex: 13182
{
	// Fields
	private static readonly Dictionary<Type, Stack<Path>> pool; // 0x0
	private static readonly Dictionary<Type, int> totalCreated; // 0x8

	// Methods

	// RVA: 0xB25E70 Offset: 0xB24870 VA: 0x180B25E70
	public static void Pool(Path path) { }

	// RVA: 0xB25DD0 Offset: 0xB247D0 VA: 0x180B25DD0
	public static int GetTotalCreated(Type type) { }

	// RVA: 0xB25D20 Offset: 0xB24720 VA: 0x180B25D20
	public static int GetSize(Type type) { }

	// RVA: -1 Offset: -1
	public static T GetPath<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1D1E0 Offset: 0xF1BBE0 VA: 0x180F1D1E0
	|-PathPool.GetPath<object>
	*/

	// RVA: 0xB26190 Offset: 0xB24B90 VA: 0x180B26190
	private static void .cctor() { }
}
