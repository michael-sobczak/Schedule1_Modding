public static class GameObjectExt // TypeDefIndex: 10471
{
	// Methods

	[Extension]
	// RVA: 0x4940E0 Offset: 0x492AE0 VA: 0x1804940E0
	public static GameObject DuplicateGameObject(GameObject source, Transform newParent, bool keepPrefabReference = False) { }

	[Extension]
	// RVA: 0x4941D0 Offset: 0x492BD0 VA: 0x1804941D0
	public static void StripComponents(GameObject go, Type[] toKeep) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T UndoableAddComponent<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBC210 Offset: 0xEBAC10 VA: 0x180EBC210
	|-GameObjectExt.UndoableAddComponent<object>
	*/
}
