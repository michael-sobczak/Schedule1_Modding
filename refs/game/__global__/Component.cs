public class Component : Object // TypeDefIndex: 11814
{
	// Properties
	public Transform transform { get; }
	public GameObject gameObject { get; }
	public string tag { get; }

	// Methods

	[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CBA530 Offset: 0x2CB8F30 VA: 0x182CBA530
	public Transform get_transform() { }

	[FreeFunction("GetGameObject", HasExplicitThis = True)]
	// RVA: 0x2CBA480 Offset: 0x2CB8E80 VA: 0x182CBA480
	public GameObject get_gameObject() { }

	[TypeInferenceRule(0)]
	// RVA: 0x2CBA1E0 Offset: 0x2CB8BE0 VA: 0x182CBA1E0
	public Component GetComponent(Type type) { }

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CBA060 Offset: 0x2CB8A60 VA: 0x182CBA060
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE68C70 Offset: 0xE67670 VA: 0x180E68C70
	|-Component.GetComponent<object>
	|
	|-RVA: 0xE68A90 Offset: 0xE67490 VA: 0x180E68A90
	|-Component.GetComponent<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	// RVA: 0x2CBA330 Offset: 0x2CB8D30 VA: 0x182CBA330
	public bool TryGetComponent(Type type, out Component component) { }

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE69310 Offset: 0xE67D10 VA: 0x180E69310
	|-Component.TryGetComponent<object>
	|
	|-RVA: 0xE692A0 Offset: 0xE67CA0 VA: 0x180E692A0
	|-Component.TryGetComponent<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	// RVA: 0x2CBA0C0 Offset: 0x2CB8AC0 VA: 0x182CBA0C0
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE686F0 Offset: 0xE670F0 VA: 0x180E686F0
	|-Component.GetComponentInChildren<object>
	|
	|-RVA: 0xE68590 Offset: 0xE66F90 VA: 0x180E68590
	|-Component.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE687C0 Offset: 0xE671C0 VA: 0x180E687C0
	|-Component.GetComponentInChildren<object>
	|
	|-RVA: 0xE68440 Offset: 0xE66E40 VA: 0x180E68440
	|-Component.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE68F50 Offset: 0xE67950 VA: 0x180E68F50
	|-Component.GetComponentsInChildren<object>
	|
	|-RVA: 0xE68D40 Offset: 0xE67740 VA: 0x180E68D40
	|-Component.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(bool includeInactive, List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE68EE0 Offset: 0xE678E0 VA: 0x180E68EE0
	|-Component.GetComponentsInChildren<object>
	|
	|-RVA: 0xE68DB0 Offset: 0xE677B0 VA: 0x180E68DB0
	|-Component.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE68E70 Offset: 0xE67870 VA: 0x180E68E70
	|-Component.GetComponentsInChildren<object>
	|
	|-RVA: 0xE68D00 Offset: 0xE67700 VA: 0x180E68D00
	|-Component.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE68FB0 Offset: 0xE679B0 VA: 0x180E68FB0
	|-Component.GetComponentsInChildren<object>
	|
	|-RVA: 0xE68E20 Offset: 0xE67820 VA: 0x180E68E20
	|-Component.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	// RVA: 0x2CBA150 Offset: 0x2CB8B50 VA: 0x182CBA150
	public Component GetComponentInParent(Type t, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE689D0 Offset: 0xE673D0 VA: 0x180E689D0
	|-Component.GetComponentInParent<object>
	|
	|-RVA: 0xE68880 Offset: 0xE67280 VA: 0x180E68880
	|-Component.GetComponentInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE69110 Offset: 0xE67B10 VA: 0x180E69110
	|-Component.GetComponentsInParent<object>
	|
	|-RVA: 0xE68D40 Offset: 0xE67740 VA: 0x180E68D40
	|-Component.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE690A0 Offset: 0xE67AA0 VA: 0x180E690A0
	|-Component.GetComponentsInParent<object>
	|
	|-RVA: 0xE68DB0 Offset: 0xE677B0 VA: 0x180E68DB0
	|-Component.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE69030 Offset: 0xE67A30 VA: 0x180E69030
	|-Component.GetComponentsInParent<object>
	|
	|-RVA: 0xE68D00 Offset: 0xE67700 VA: 0x180E68D00
	|-Component.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2CBA260 Offset: 0x2CB8C60 VA: 0x182CBA260
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	// RVA: 0x2CBA260 Offset: 0x2CB8C60 VA: 0x182CBA260
	public void GetComponents(Type type, List<Component> results) { }

	// RVA: -1 Offset: -1
	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE69170 Offset: 0xE67B70 VA: 0x180E69170
	|-Component.GetComponents<object>
	|-Component.GetComponents<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2CBA4C0 Offset: 0x2CB8EC0 VA: 0x182CBA4C0
	public string get_tag() { }

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE69250 Offset: 0xE67C50 VA: 0x180E69250
	|-Component.GetComponents<object>
	|
	|-RVA: 0xE691F0 Offset: 0xE67BF0 VA: 0x180E691F0
	|-Component.GetComponents<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2CB9FE0 Offset: 0x2CB89E0 VA: 0x182CB9FE0
	public bool CompareTag(string tag) { }

	[FreeFunction("SendMessage", HasExplicitThis = True)]
	// RVA: 0x2CBA2C0 Offset: 0x2CB8CC0 VA: 0x182CBA2C0
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	[FreeFunction("BroadcastMessage", HasExplicitThis = True)]
	// RVA: 0x2CB9F70 Offset: 0x2CB8970 VA: 0x182CB9F70
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	// RVA: 0x2CB9B50 Offset: 0x2CB8550 VA: 0x182CB9B50
	public void .ctor() { }
}
