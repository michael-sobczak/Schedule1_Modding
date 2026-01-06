public static class GUIDManager // TypeDefIndex: 16
{
	// Fields
	private static List<Guid> registeredGUIDs; // 0x0
	private static Dictionary<Guid, object> guidToObject; // 0x8

	// Methods

	// RVA: 0x55DFD0 Offset: 0x55C9D0 VA: 0x18055DFD0
	public static void RegisterObject(IGUIDRegisterable obj, GameObject go) { }

	// RVA: 0x55DB60 Offset: 0x55C560 VA: 0x18055DB60
	public static void DeregisterObject(IGUIDRegisterable obj) { }

	// RVA: -1 Offset: -1
	public static T GetObject<T>(Guid guid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBC060 Offset: 0xEBAA60 VA: 0x180EBC060
	|-GUIDManager.GetObject<object>
	|
	|-RVA: 0xEBBE20 Offset: 0xEBA820 VA: 0x180EBBE20
	|-GUIDManager.GetObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x55DE00 Offset: 0x55C800 VA: 0x18055DE00
	public static Type GetObjectType(Guid guid) { }

	// RVA: 0x55DD50 Offset: 0x55C750 VA: 0x18055DD50
	public static Guid GenerateUniqueGUID() { }

	// RVA: 0x55DE80 Offset: 0x55C880 VA: 0x18055DE80
	public static bool IsGUIDAlreadyRegistered(Guid guid) { }

	// RVA: 0x55DF10 Offset: 0x55C910 VA: 0x18055DF10
	public static bool IsGUIDValid(string guid) { }

	// RVA: 0x55DA80 Offset: 0x55C480 VA: 0x18055DA80
	public static void Clear() { }

	// RVA: 0x55E4D0 Offset: 0x55CED0 VA: 0x18055E4D0
	private static void .cctor() { }
}
