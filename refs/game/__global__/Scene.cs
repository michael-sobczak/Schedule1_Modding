public struct Scene // TypeDefIndex: 11980
{
	// Fields
	[HideInInspector]
	[SerializeField]
	private int m_Handle; // 0x0

	// Properties
	public int handle { get; }
	internal string guid { get; }
	public string name { get; }
	public bool isLoaded { get; }
	public int buildIndex { get; }
	public int rootCount { get; }

	// Methods

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x2CEA820 Offset: 0x2CE9220 VA: 0x182CEA820
	private static bool IsValidInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x2CEA420 Offset: 0x2CE8E20 VA: 0x182CEA420
	private static string GetNameInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x2CEA3A0 Offset: 0x2CE8DA0 VA: 0x182CEA3A0
	private static string GetGUIDInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x2CEA3E0 Offset: 0x2CE8DE0 VA: 0x182CEA3E0
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x2CEA360 Offset: 0x2CE8D60 VA: 0x182CEA360
	private static int GetBuildIndexInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x2CEA460 Offset: 0x2CE8E60 VA: 0x182CEA460
	private static int GetRootCountInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x2CEA4A0 Offset: 0x2CE8EA0 VA: 0x182CEA4A0
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	public int get_handle() { }

	// RVA: 0x2CEA8E0 Offset: 0x2CE92E0 VA: 0x182CEA8E0
	internal string get_guid() { }

	// RVA: 0x2CEA860 Offset: 0x2CE9260 VA: 0x182CEA860
	public bool IsValid() { }

	// RVA: 0x2CEA960 Offset: 0x2CE9360 VA: 0x182CEA960
	public string get_name() { }

	// RVA: 0x2CEA920 Offset: 0x2CE9320 VA: 0x182CEA920
	public bool get_isLoaded() { }

	// RVA: 0x2CEA8A0 Offset: 0x2CE92A0 VA: 0x182CEA8A0
	public int get_buildIndex() { }

	// RVA: 0x2CEA9A0 Offset: 0x2CE93A0 VA: 0x182CEA9A0
	public int get_rootCount() { }

	// RVA: 0x2CEA750 Offset: 0x2CE9150 VA: 0x182CEA750
	public GameObject[] GetRootGameObjects() { }

	// RVA: 0x2CEA4E0 Offset: 0x2CE8EE0 VA: 0x182CEA4E0
	public void GetRootGameObjects(List<GameObject> rootGameObjects) { }

	// RVA: 0x2CC3F40 Offset: 0x2CC2940 VA: 0x182CC3F40
	public static bool op_Equality(Scene lhs, Scene rhs) { }

	// RVA: 0x2CEA9E0 Offset: 0x2CE93E0 VA: 0x182CEA9E0
	public static bool op_Inequality(Scene lhs, Scene rhs) { }

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CEA2E0 Offset: 0x2CE8CE0 VA: 0x182CEA2E0 Slot: 0
	public override bool Equals(object other) { }
}
