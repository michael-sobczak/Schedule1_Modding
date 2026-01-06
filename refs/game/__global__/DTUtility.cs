public static class DTUtility // TypeDefIndex: 10403
{
	// Fields
	public const string HelpUrlBase = "https://curvyeditor.com/doclink/";

	// Properties
	public static bool IsEditorStateChange { get; }
	public static bool IsInEditMode { get; }

	// Methods

	[Obsolete("Will get removed since it is not used by Curvy, and needs maintenance to be compatible with Unity's Enter Play Mode Settings")]
	[UsedImplicitly]
	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	public static Material GetDefaultMaterial() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public static bool get_IsEditorStateChange() { }

	// RVA: 0x492900 Offset: 0x491300 VA: 0x180492900
	public static float GetHandleSize(Vector3 position) { }

	// RVA: 0x492780 Offset: 0x491180 VA: 0x180492780
	public static float GetHandleSize(Vector3 position, Camera camera, float cameraCenterWidth, float cameraCenterHeight, Vector3 cameraPosition, Vector3 cameraZDirection, Vector3 cameraXDirection) { }

	// RVA: -1 Offset: -1
	public static void SetPlayerPrefs<T>(string key, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE73200 Offset: 0xE71C00 VA: 0x180E73200
	|-DTUtility.SetPlayerPrefs<bool>
	|
	|-RVA: 0xE739E0 Offset: 0xE723E0 VA: 0x180E739E0
	|-DTUtility.SetPlayerPrefs<Color>
	|
	|-RVA: 0xE75250 Offset: 0xE73C50 VA: 0x180E75250
	|-DTUtility.SetPlayerPrefs<int>
	|
	|-RVA: 0xE74A80 Offset: 0xE73480 VA: 0x180E74A80
	|-DTUtility.SetPlayerPrefs<Int32Enum>
	|
	|-RVA: 0xE75A10 Offset: 0xE74410 VA: 0x180E75A10
	|-DTUtility.SetPlayerPrefs<float>
	|
	|-RVA: 0xE74180 Offset: 0xE72B80 VA: 0x180E74180
	|-DTUtility.SetPlayerPrefs<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T GetPlayerPrefs<T>(string key, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE70040 Offset: 0xE6EA40 VA: 0x180E70040
	|-DTUtility.GetPlayerPrefs<bool>
	|
	|-RVA: 0xE70850 Offset: 0xE6F250 VA: 0x180E70850
	|-DTUtility.GetPlayerPrefs<Color>
	|
	|-RVA: 0xE72200 Offset: 0xE70C00 VA: 0x180E72200
	|-DTUtility.GetPlayerPrefs<int>
	|
	|-RVA: 0xE719F0 Offset: 0xE703F0 VA: 0x180E719F0
	|-DTUtility.GetPlayerPrefs<Int32Enum>
	|
	|-RVA: 0xE729F0 Offset: 0xE713F0 VA: 0x180E729F0
	|-DTUtility.GetPlayerPrefs<float>
	|
	|-RVA: 0xE71050 Offset: 0xE6FA50 VA: 0x180E71050
	|-DTUtility.GetPlayerPrefs<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x492F90 Offset: 0x491990 VA: 0x180492F90
	public static float RandomSign() { }

	// RVA: 0x492E00 Offset: 0x491800 VA: 0x180492E00
	public static string GetHelpUrl(object forClass) { }

	// RVA: 0x492CB0 Offset: 0x4916B0 VA: 0x180492CB0
	public static string GetHelpUrl(Type classType) { }

	// RVA: 0x492670 Offset: 0x491070 VA: 0x180492670
	public static Vector3 GetCenterPosition(Vector3 fallback, Vector3[] vectors) { }

	// RVA: -1 Offset: -1
	public static T CreateGameObject<T>(Transform parent, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6FED0 Offset: 0xE6E8D0 VA: 0x180E6FED0
	|-DTUtility.CreateGameObject<object>
	*/

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public static bool get_IsInEditMode() { }
}
