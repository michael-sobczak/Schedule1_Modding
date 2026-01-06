public static class JsonUtility // TypeDefIndex: 19208
{
	// Methods

	[FreeFunction("ToJsonInternal", True)]
	[ThreadSafe]
	// RVA: 0x2D2BB90 Offset: 0x2D2A590 VA: 0x182D2BB90
	private static string ToJsonInternal(object obj, bool prettyPrint) { }

	[ThreadSafe]
	[FreeFunction("FromJsonInternal", True, ThrowsException = True)]
	// RVA: 0x2D2B780 Offset: 0x2D2A180 VA: 0x182D2B780
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	// RVA: 0x2D2BBE0 Offset: 0x2D2A5E0 VA: 0x182D2BBE0
	public static string ToJson(object obj) { }

	// RVA: 0x2D2BD50 Offset: 0x2D2A750 VA: 0x182D2BD50
	public static string ToJson(object obj, bool prettyPrint) { }

	// RVA: -1 Offset: -1
	public static T FromJson<T>(string json) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7C20 Offset: 0xEE6620 VA: 0x180EE7C20
	|-JsonUtility.FromJson<Board>
	|
	|-RVA: 0xEE7B50 Offset: 0xEE6550 VA: 0x180EE7B50
	|-JsonUtility.FromJson<BoardCollection>
	|-JsonUtility.FromJson<LabelCollection>
	|-JsonUtility.FromJson<ListCollection>
	|-JsonUtility.FromJson<InputActionMap.BindingOverrideListJson>
	|
	|-RVA: 0xEE8830 Offset: 0xEE7230 VA: 0x180EE8830
	|-JsonUtility.FromJson<object>
	|
	|-RVA: 0xEE88F0 Offset: 0xEE72F0 VA: 0x180EE88F0
	|-JsonUtility.FromJson<Subscribed>
	|
	|-RVA: 0xEE8380 Offset: 0xEE6D80 VA: 0x180EE8380
	|-JsonUtility.FromJson<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xEE8280 Offset: 0xEE6C80 VA: 0x180EE8280
	|-JsonUtility.FromJson<HID.HIDDeviceDescriptor>
	|
	|-RVA: 0xEE8740 Offset: 0xEE7140 VA: 0x180EE8740
	|-JsonUtility.FromJson<InputActionAsset.ReadFileJson>
	|
	|-RVA: 0xEE8090 Offset: 0xEE6A90 VA: 0x180EE8090
	|-JsonUtility.FromJson<InputActionMap.ReadFileJson>
	|-JsonUtility.FromJson<InputRemoting.ChangeUsageMsg.Data>
	|
	|-RVA: 0xEE8610 Offset: 0xEE7010 VA: 0x180EE8610
	|-JsonUtility.FromJson<InputControlLayout.LayoutJson>
	|
	|-RVA: 0xEE84D0 Offset: 0xEE6ED0 VA: 0x180EE84D0
	|-JsonUtility.FromJson<InputControlLayout.LayoutJsonNameAndDescriptorOnly>
	|
	|-RVA: 0xEE8170 Offset: 0xEE6B70 VA: 0x180EE8170
	|-JsonUtility.FromJson<InputDeviceDescription.DeviceDescriptionJson>
	|
	|-RVA: 0xEE7D90 Offset: 0xEE6790 VA: 0x180EE7D90
	|-JsonUtility.FromJson<XInputController.Capabilities>
	|
	|-RVA: 0xEE7E80 Offset: 0xEE6880 VA: 0x180EE7E80
	|-JsonUtility.FromJson<InputRemoting.NewDeviceMsg.Data>
	|
	|-RVA: 0xEE7FA0 Offset: 0xEE69A0 VA: 0x180EE7FA0
	|-JsonUtility.FromJson<InputRemoting.NewLayoutMsg.Data>
	*/

	// RVA: 0x2D2B990 Offset: 0x2D2A390 VA: 0x182D2B990
	public static object FromJson(string json, Type type) { }

	// RVA: 0x2D2B7E0 Offset: 0x2D2A1E0 VA: 0x182D2B7E0
	public static void FromJsonOverwrite(string json, object objectToOverwrite) { }
}
