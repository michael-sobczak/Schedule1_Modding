public static class ComponentExt // TypeDefIndex: 10472
{
	// Methods

	[Extension]
	// RVA: 0x48B030 Offset: 0x489A30 VA: 0x18048B030
	public static void StripComponents(Component c, Type[] toKeep) { }

	[Extension]
	[UsedImplicitly]
	[Obsolete]
	// RVA: 0x48AD80 Offset: 0x489780 VA: 0x18048AD80
	public static GameObject AddChildGameObject(Component c, string name) { }

	[Obsolete]
	[Extension]
	[UsedImplicitly]
	// RVA: -1 Offset: -1
	public static T AddChildGameObject<T>(Component c, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE67350 Offset: 0xE65D50 VA: 0x180E67350
	|-ComponentExt.AddChildGameObject<object>
	*/

	[NotNull]
	[Extension]
	// RVA: -1 Offset: -1
	public static T DuplicateGameObject<T>(Component source, Transform newParent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE67660 Offset: 0xE66060 VA: 0x180E67660
	|-ComponentExt.DuplicateGameObject<object>
	*/

	[Extension]
	[Obsolete("Use the other DuplicateGameObject method instead")]
	[UsedImplicitly]
	[CanBeNull]
	// RVA: -1 Offset: -1
	public static T DuplicateGameObject<T>(Component source, Transform newParent, bool keepPrefabConnection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE67410 Offset: 0xE65E10 VA: 0x180E67410
	|-ComponentExt.DuplicateGameObject<object>
	*/

	[Obsolete("Use the other DuplicateGameObject method instead")]
	[UsedImplicitly]
	[Extension]
	// RVA: 0x48AE20 Offset: 0x489820 VA: 0x18048AE20
	public static Component DuplicateGameObject(Component source, Transform newParent, bool keepPrefabConnection = False) { }
}
