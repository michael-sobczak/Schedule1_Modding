public class Object // TypeDefIndex: 11854
{
	// Fields
	private IntPtr m_CachedPtr; // 0x10
	internal static int OffsetOfInstanceIDInCPlusPlusObject; // 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null.";
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

	// Properties
	public string name { get; set; }
	public HideFlags hideFlags { get; set; }

	// Methods

	// RVA: 0x2CC0F90 Offset: 0x2CBF990 VA: 0x182CC0F90
	public int GetInstanceID() { }

	// RVA: 0x2CC0F80 Offset: 0x2CBF980 VA: 0x182CC0F80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CC0AC0 Offset: 0x2CBF4C0 VA: 0x182CC0AC0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2CC2260 Offset: 0x2CC0C60 VA: 0x182CC2260
	public static bool op_Implicit(Object exists) { }

	// RVA: 0x2CC0820 Offset: 0x2CBF220 VA: 0x182CC0820
	private static bool CompareBaseObjects(Object lhs, Object rhs) { }

	// RVA: 0x2CC1F30 Offset: 0x2CC0930 VA: 0x182CC1F30
	private static bool IsNativeObjectAlive(Object o) { }

	// RVA: 0x180D270 Offset: 0x180BC70 VA: 0x18180D270
	private IntPtr GetCachedPtr() { }

	// RVA: 0x2CC20E0 Offset: 0x2CC0AE0 VA: 0x182CC20E0
	public string get_name() { }

	// RVA: 0x2CC2440 Offset: 0x2CC0E40 VA: 0x182CC2440
	public void set_name(string value) { }

	[TypeInferenceRule(3)]
	// RVA: 0x2CC1600 Offset: 0x2CC0000 VA: 0x182CC1600
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRule(3)]
	// RVA: 0x2CC1170 Offset: 0x2CBFB70 VA: 0x182CC1170
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[TypeInferenceRule(3)]
	// RVA: 0x2CC1470 Offset: 0x2CBFE70 VA: 0x182CC1470
	public static Object Instantiate(Object original) { }

	[TypeInferenceRule(3)]
	// RVA: 0x2CC1110 Offset: 0x2CBFB10 VA: 0x182CC1110
	public static Object Instantiate(Object original, Transform parent) { }

	[TypeInferenceRule(3)]
	// RVA: 0x2CC18A0 Offset: 0x2CC02A0 VA: 0x182CC18A0
	public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { }

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF19D60 Offset: 0xF18760 VA: 0x180F19D60
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF19A90 Offset: 0xF18490 VA: 0x180F19A90
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF19B70 Offset: 0xF18570 VA: 0x180F19B70
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF19C70 Offset: 0xF18670 VA: 0x180F19C70
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF19E90 Offset: 0xF18890 VA: 0x180F19E90
	|-Object.Instantiate<object>
	*/

	[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2CC09C0 Offset: 0x2CBF3C0 VA: 0x182CC09C0
	public static void Destroy(Object obj, float t) { }

	[ExcludeFromDocs]
	// RVA: 0x2CC0A10 Offset: 0x2CBF410 VA: 0x182CC0A10
	public static void Destroy(Object obj) { }

	[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2CC0970 Offset: 0x2CBF370 VA: 0x182CC0970
	public static void DestroyImmediate(Object obj, bool allowDestroyingAssets) { }

	[ExcludeFromDocs]
	// RVA: 0x2CC0900 Offset: 0x2CBF300 VA: 0x182CC0900
	public static void DestroyImmediate(Object obj) { }

	// RVA: 0x2CC0E80 Offset: 0x2CBF880 VA: 0x182CC0E80
	public static Object[] FindObjectsOfType(Type type) { }

	[TypeInferenceRule(2)]
	[FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
	// RVA: 0x2CC0EF0 Offset: 0x2CBF8F0 VA: 0x182CC0EF0
	public static Object[] FindObjectsOfType(Type type, bool includeInactive) { }

	[FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = True)]
	// RVA: 0x2CC0A80 Offset: 0x2CBF480 VA: 0x182CC0A80
	public static void DontDestroyOnLoad(Object target) { }

	// RVA: 0x2CC20A0 Offset: 0x2CC0AA0 VA: 0x182CC20A0
	public HideFlags get_hideFlags() { }

	// RVA: 0x2CC2400 Offset: 0x2CC0E00 VA: 0x182CC2400
	public void set_hideFlags(HideFlags value) { }

	// RVA: -1 Offset: -1
	public static T[] FindObjectsOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF199F0 Offset: 0xF183F0 VA: 0x180F199F0
	|-Object.FindObjectsOfType<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] FindObjectsOfType<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF19940 Offset: 0xF18340 VA: 0x180F19940
	|-Object.FindObjectsOfType<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindObjectOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF19770 Offset: 0xF18170 VA: 0x180F19770
	|-Object.FindObjectOfType<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindObjectOfType<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF19850 Offset: 0xF18250 VA: 0x180F19850
	|-Object.FindObjectOfType<object>
	*/

	// RVA: 0x2CC07C0 Offset: 0x2CBF1C0 VA: 0x182CC07C0
	private static void CheckNullArgument(object arg, string message) { }

	[TypeInferenceRule(0)]
	// RVA: 0x2CC0DF0 Offset: 0x2CBF7F0 VA: 0x182CC0DF0
	public static Object FindObjectOfType(Type type) { }

	[TypeInferenceRule(0)]
	// RVA: 0x2CC0D50 Offset: 0x2CBF750 VA: 0x182CC0D50
	public static Object FindObjectOfType(Type type, bool includeInactive) { }

	// RVA: 0x2CC1FB0 Offset: 0x2CC09B0 VA: 0x182CC1FB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2CC2150 Offset: 0x2CC0B50 VA: 0x182CC2150
	public static bool op_Equality(Object x, Object y) { }

	// RVA: 0x2CC22F0 Offset: 0x2CC0CF0 VA: 0x182CC22F0
	public static bool op_Inequality(Object x, Object y) { }

	[NativeMethod(Name = "Object::GetOffsetOfInstanceIdMember", IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x2CC10E0 Offset: 0x2CBFAE0 VA: 0x182CC10E0
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[NativeMethod(Name = "CloneObject", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2CC1CF0 Offset: 0x2CC06F0 VA: 0x182CC1CF0
	private static Object Internal_CloneSingle(Object data) { }

	[FreeFunction("CloneObject")]
	// RVA: 0x2CC1C90 Offset: 0x2CC0690 VA: 0x182CC1C90
	private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) { }

	[FreeFunction("InstantiateObject")]
	// RVA: 0x2CC1EA0 Offset: 0x2CC08A0 VA: 0x182CC1EA0
	private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) { }

	[FreeFunction("InstantiateObject")]
	// RVA: 0x2CC1DA0 Offset: 0x2CC07A0 VA: 0x182CC1DA0
	private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) { }

	[FreeFunction("UnityEngineObjectBindings::ToString")]
	// RVA: 0x2CC2020 Offset: 0x2CC0A20 VA: 0x182CC2020
	private static string ToString(Object obj) { }

	[FreeFunction("UnityEngineObjectBindings::GetName")]
	// RVA: 0x2CC10A0 Offset: 0x2CBFAA0 VA: 0x182CC10A0
	private static string GetName(Object obj) { }

	[FreeFunction("UnityEngineObjectBindings::SetName")]
	// RVA: 0x2CC1F60 Offset: 0x2CC0960 VA: 0x182CC1F60
	private static void SetName(Object obj, string name) { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectFromInstanceID")]
	[VisibleToOtherModules]
	// RVA: 0x2CC0D10 Offset: 0x2CBF710 VA: 0x182CC0D10
	internal static Object FindObjectFromInstanceID(int instanceID) { }

	[VisibleToOtherModules]
	[FreeFunction("UnityEngineObjectBindings::ForceLoadFromInstanceID")]
	// RVA: 0x2CC0F40 Offset: 0x2CBF940 VA: 0x182CC0F40
	internal static Object ForceLoadFromInstanceID(int instanceID) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x2CC2060 Offset: 0x2CC0A60 VA: 0x182CC2060
	private static void .cctor() { }

	// RVA: 0x2CC1E40 Offset: 0x2CC0840 VA: 0x182CC1E40
	private static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot) { }

	// RVA: 0x2CC1D30 Offset: 0x2CC0730 VA: 0x182CC1D30
	private static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }
}
