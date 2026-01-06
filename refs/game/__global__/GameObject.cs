public sealed class GameObject : Object // TypeDefIndex: 11827
{
	// Properties
	public Transform transform { get; }
	public int layer { get; set; }
	public bool activeSelf { get; }
	public bool activeInHierarchy { get; }
	public bool isStatic { get; set; }
	public string tag { get; set; }
	public Scene scene { get; }
	public ulong sceneCullingMask { get; }
	public GameObject gameObject { get; }

	// Methods

	[FreeFunction("GameObjectBindings::CreatePrimitive")]
	// RVA: 0x2CBE0E0 Offset: 0x2CBCAE0 VA: 0x182CBE0E0
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBCD20 Offset: 0xEBB720 VA: 0x180EBCD20
	|-GameObject.GetComponent<object>
	|
	|-RVA: 0xEBCB40 Offset: 0xEBB540 VA: 0x180EBCB40
	|-GameObject.GetComponent<__Il2CppFullySharedGenericType>
	*/

	[FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(0)]
	// RVA: 0x2CBE300 Offset: 0x2CBCD00 VA: 0x182CBE300
	public Component GetComponent(Type type) { }

	[NativeWritableSelf]
	[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CBE1E0 Offset: 0x2CBCBE0 VA: 0x182CBE1E0
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(0)]
	// RVA: 0x2CBE240 Offset: 0x2CBCC40 VA: 0x182CBE240
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBC680 Offset: 0xEBB080 VA: 0x180EBC680
	|-GameObject.GetComponentInChildren<object>
	|
	|-RVA: 0xEBC570 Offset: 0xEBAF70 VA: 0x180EBC570
	|-GameObject.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBC760 Offset: 0xEBB160 VA: 0x180EBC760
	|-GameObject.GetComponentInChildren<object>
	|
	|-RVA: 0xEBC410 Offset: 0xEBAE10 VA: 0x180EBC410
	|-GameObject.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	[FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CBE2A0 Offset: 0x2CBCCA0 VA: 0x182CBE2A0
	public Component GetComponentInParent(Type type, bool includeInactive) { }

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBCA60 Offset: 0xEBB460 VA: 0x180EBCA60
	|-GameObject.GetComponentInParent<object>
	|
	|-RVA: 0xEBC570 Offset: 0xEBAF70 VA: 0x180EBC570
	|-GameObject.GetComponentInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBC990 Offset: 0xEBB390 VA: 0x180EBC990
	|-GameObject.GetComponentInParent<object>
	|
	|-RVA: 0xEBC830 Offset: 0xEBB230 VA: 0x180EBC830
	|-GameObject.GetComponentInParent<__Il2CppFullySharedGenericType>
	*/

	[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CBE350 Offset: 0x2CBCD50 VA: 0x182CBE350
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBD2B0 Offset: 0xEBBCB0 VA: 0x180EBD2B0
	|-GameObject.GetComponents<object>
	|-GameObject.GetComponents<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBD210 Offset: 0xEBBC10 VA: 0x180EBD210
	|-GameObject.GetComponents<object>
	|-GameObject.GetComponents<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBCE60 Offset: 0xEBB860 VA: 0x180EBCE60
	|-GameObject.GetComponentsInChildren<object>
	|-GameObject.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBCDB0 Offset: 0xEBB7B0 VA: 0x180EBCDB0
	|-GameObject.GetComponentsInChildren<object>
	|-GameObject.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBCF60 Offset: 0xEBB960 VA: 0x180EBCF60
	|-GameObject.GetComponentsInChildren<object>
	|
	|-RVA: 0xE68D00 Offset: 0xE67700 VA: 0x180E68D00
	|-GameObject.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBD160 Offset: 0xEBBB60 VA: 0x180EBD160
	|-GameObject.GetComponentsInParent<object>
	|-GameObject.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBD060 Offset: 0xEBBA60 VA: 0x180EBD060
	|-GameObject.GetComponentsInParent<object>
	|-GameObject.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBD5E0 Offset: 0xEBBFE0 VA: 0x180EBD5E0
	|-GameObject.TryGetComponent<object>
	|
	|-RVA: 0xEBD3A0 Offset: 0xEBBDA0 VA: 0x180EBD3A0
	|-GameObject.TryGetComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2CBE590 Offset: 0x2CBCF90 VA: 0x182CBE590
	public bool TryGetComponent(Type type, out Component component) { }

	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(0)]
	// RVA: 0x2CBE540 Offset: 0x2CBCF40 VA: 0x182CBE540
	internal Component TryGetComponentInternal(Type type) { }

	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	[NativeWritableSelf]
	// RVA: 0x2CBE4E0 Offset: 0x2CBCEE0 VA: 0x182CBE4E0
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = True)]
	// RVA: 0x2CBE040 Offset: 0x2CBCA40 VA: 0x182CBE040
	private Component Internal_AddComponentWithType(Type componentType) { }

	[TypeInferenceRule(0)]
	// RVA: 0x2CBE040 Offset: 0x2CBCA40 VA: 0x182CBE040
	public Component AddComponent(Type componentType) { }

	// RVA: -1 Offset: -1
	public T AddComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBC320 Offset: 0xEBAD20 VA: 0x180EBC320
	|-GameObject.AddComponent<object>
	*/

	[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = True)]
	// RVA: 0x2CBEAC0 Offset: 0x2CBD4C0 VA: 0x182CBEAC0
	public Transform get_transform() { }

	// RVA: 0x2CBE960 Offset: 0x2CBD360 VA: 0x182CBE960
	public int get_layer() { }

	// RVA: 0x2CBEB50 Offset: 0x2CBD550 VA: 0x182CBEB50
	public void set_layer(int value) { }

	[NativeMethod(Name = "SetSelfActive")]
	// RVA: 0x2CBE490 Offset: 0x2CBCE90 VA: 0x182CBE490
	public void SetActive(bool value) { }

	[NativeMethod(Name = "IsSelfActive")]
	// RVA: 0x2CBE8E0 Offset: 0x2CBD2E0 VA: 0x182CBE8E0
	public bool get_activeSelf() { }

	[NativeMethod(Name = "IsActive")]
	// RVA: 0x2CBE8A0 Offset: 0x2CBD2A0 VA: 0x182CBE8A0
	public bool get_activeInHierarchy() { }

	[NativeMethod(Name = "GetIsStaticDeprecated")]
	// RVA: 0x2CBE920 Offset: 0x2CBD320 VA: 0x182CBE920
	public bool get_isStatic() { }

	[NativeMethod(Name = "SetIsStaticDeprecated")]
	// RVA: 0x2CBEB00 Offset: 0x2CBD500 VA: 0x182CBEB00
	public void set_isStatic(bool value) { }

	[FreeFunction("GameObjectBindings::GetTag", HasExplicitThis = True)]
	// RVA: 0x2CBEA80 Offset: 0x2CBD480 VA: 0x182CBEA80
	public string get_tag() { }

	[FreeFunction("GameObjectBindings::SetTag", HasExplicitThis = True)]
	// RVA: 0x2CBEB90 Offset: 0x2CBD590 VA: 0x182CBEB90
	public void set_tag(string value) { }

	[FreeFunction(Name = "GameObjectBindings::CompareTag", HasExplicitThis = True)]
	// RVA: 0x2CBE090 Offset: 0x2CBCA90 VA: 0x182CBE090
	public bool CompareTag(string tag) { }

	[FreeFunction(Name = "GameObjectBindings::FindGameObjectWithTag", ThrowsException = True)]
	// RVA: 0x2CBE120 Offset: 0x2CBCB20 VA: 0x182CBE120
	public static GameObject FindGameObjectWithTag(string tag) { }

	[FreeFunction(Name = "GameObjectBindings::FindGameObjectsWithTag", ThrowsException = True)]
	// RVA: 0x2CBE160 Offset: 0x2CBCB60 VA: 0x182CBE160
	public static GameObject[] FindGameObjectsWithTag(string tag) { }

	[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = True)]
	// RVA: 0x2CBE420 Offset: 0x2CBCE20 VA: 0x182CBE420
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	// RVA: 0x2CBE6B0 Offset: 0x2CBD0B0 VA: 0x182CBE6B0
	public void .ctor(string name) { }

	// RVA: 0x2CBE830 Offset: 0x2CBD230 VA: 0x182CBE830
	public void .ctor() { }

	// RVA: 0x2CBE730 Offset: 0x2CBD130 VA: 0x182CBE730
	public void .ctor(string name, Type[] components) { }

	[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
	// RVA: 0x2CBE3D0 Offset: 0x2CBCDD0 VA: 0x182CBE3D0
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	[FreeFunction(Name = "GameObjectBindings::Find")]
	// RVA: 0x2CBE1A0 Offset: 0x2CBCBA0 VA: 0x182CBE1A0
	public static GameObject Find(string name) { }

	[FreeFunction("GameObjectBindings::GetScene", HasExplicitThis = True)]
	// RVA: 0x2CBEA30 Offset: 0x2CBD430 VA: 0x182CBEA30
	public Scene get_scene() { }

	[FreeFunction(Name = "GameObjectBindings::GetSceneCullingMask", HasExplicitThis = True)]
	// RVA: 0x2CBE9A0 Offset: 0x2CBD3A0 VA: 0x182CBE9A0
	public ulong get_sceneCullingMask() { }

	// RVA: 0x1CC1010 Offset: 0x1CBFA10 VA: 0x181CC1010
	public GameObject get_gameObject() { }

	// RVA: 0x2CBE9E0 Offset: 0x2CBD3E0 VA: 0x182CBE9E0
	private void get_scene_Injected(out Scene ret) { }
}
