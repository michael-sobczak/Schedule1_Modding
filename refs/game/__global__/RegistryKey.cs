public sealed class RegistryKey : MarshalByRefObject, IDisposable // TypeDefIndex: 3534
{
	// Fields
	internal static readonly IntPtr HKEY_CLASSES_ROOT; // 0x0
	internal static readonly IntPtr HKEY_CURRENT_USER; // 0x8
	internal static readonly IntPtr HKEY_LOCAL_MACHINE; // 0x10
	internal static readonly IntPtr HKEY_USERS; // 0x18
	internal static readonly IntPtr HKEY_PERFORMANCE_DATA; // 0x20
	internal static readonly IntPtr HKEY_CURRENT_CONFIG; // 0x28
	internal static readonly IntPtr HKEY_DYN_DATA; // 0x30
	private static readonly string[] s_hkeyNames; // 0x38
	private SafeRegistryHandle _hkey; // 0x18
	private string _keyName; // 0x20
	private bool _remoteKey; // 0x28
	private RegistryKey.StateFlags _state; // 0x2C
	private RegistryKeyPermissionCheck _checkMode; // 0x30
	private RegistryView _regView; // 0x34

	// Methods

	// RVA: 0x1AA3590 Offset: 0x1AA1F90 VA: 0x181AA3590
	private void ClosePerfDataKey() { }

	// RVA: 0x1AA4E00 Offset: 0x1AA3800 VA: 0x181AA4E00
	private static RegistryKey OpenBaseKeyCore(RegistryHive hKeyHive, RegistryView view) { }

	// RVA: 0x1AA4A30 Offset: 0x1AA3430 VA: 0x181AA4A30
	private RegistryKey InternalOpenSubKeyCore(string name, bool writable, bool throwOnPermissionFailure) { }

	// RVA: 0x1AA4C20 Offset: 0x1AA3620 VA: 0x181AA4C20
	private int InternalSubKeyCountCore() { }

	// RVA: 0x1AA3E10 Offset: 0x1AA2810 VA: 0x181AA3E10
	private string[] InternalGetSubKeyNamesCore(int subkeys) { }

	// RVA: 0x1AA4040 Offset: 0x1AA2A40 VA: 0x181AA4040
	private object InternalGetValueCore(string name, object defaultValue, bool doNotExpand) { }

	// RVA: 0x1AA5770 Offset: 0x1AA4170 VA: 0x181AA5770
	private void Win32Error(int errorCode, string str) { }

	// RVA: 0x1AA3AD0 Offset: 0x1AA24D0 VA: 0x181AA3AD0
	private static int GetRegistryKeyAccess(bool isWritable) { }

	// RVA: 0x1AA5C00 Offset: 0x1AA4600 VA: 0x181AA5C00
	private void .ctor(SafeRegistryHandle hkey, bool writable, bool systemkey, bool remoteKey, bool isPerfData, RegistryView view) { }

	// RVA: 0x1AA35F0 Offset: 0x1AA1FF0 VA: 0x181AA35F0 Slot: 6
	public void Dispose() { }

	// RVA: 0x1AA4F70 Offset: 0x1AA3970 VA: 0x181AA4F70
	public static RegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view) { }

	// RVA: 0x1AA5170 Offset: 0x1AA3B70 VA: 0x181AA5170
	public RegistryKey OpenSubKey(string name, bool writable) { }

	// RVA: 0x1AA4CC0 Offset: 0x1AA36C0 VA: 0x181AA4CC0
	private int InternalSubKeyCount() { }

	// RVA: 0x1AA3AF0 Offset: 0x1AA24F0 VA: 0x181AA3AF0
	public string[] GetSubKeyNames() { }

	// RVA: 0x1AA3AF0 Offset: 0x1AA24F0 VA: 0x181AA3AF0
	private string[] InternalGetSubKeyNames() { }

	// RVA: 0x1AA3CE0 Offset: 0x1AA26E0 VA: 0x181AA3CE0
	public object GetValue(string name, object defaultValue, RegistryValueOptions options) { }

	// RVA: 0x1AA4980 Offset: 0x1AA3380 VA: 0x181AA4980
	private object InternalGetValue(string name, object defaultValue, bool doNotExpand, bool checkSecurity) { }

	// RVA: 0x1AA5250 Offset: 0x1AA3C50 VA: 0x181AA5250 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AA3770 Offset: 0x1AA2170 VA: 0x181AA3770
	private static string FixupName(string name) { }

	// RVA: 0x1AA3990 Offset: 0x1AA2390 VA: 0x181AA3990
	private static void FixupPath(StringBuilder path) { }

	// RVA: 0x1AA3710 Offset: 0x1AA2110 VA: 0x181AA3710
	private void EnsureNotDisposed() { }

	// RVA: 0x1AA3C80 Offset: 0x1AA2680 VA: 0x181AA3C80
	private RegistryKeyPermissionCheck GetSubKeyPermissionCheck(bool subkeyWritable) { }

	// RVA: 0x1AA52C0 Offset: 0x1AA3CC0 VA: 0x181AA52C0
	private static void ValidateKeyName(string name) { }

	// RVA: 0x1AA5710 Offset: 0x1AA4110 VA: 0x181AA5710
	private static void ValidateKeyView(RegistryView view) { }

	// RVA: 0x1AA4DE0 Offset: 0x1AA37E0 VA: 0x181AA4DE0
	private bool IsSystemKey() { }

	// RVA: 0x1AA4DC0 Offset: 0x1AA37C0 VA: 0x181AA4DC0
	private bool IsPerfDataKey() { }

	// RVA: 0x1AA5910 Offset: 0x1AA4310 VA: 0x181AA5910
	private static void .cctor() { }
}
