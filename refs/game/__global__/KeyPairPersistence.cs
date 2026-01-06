internal class KeyPairPersistence // TypeDefIndex: 3511
{
	// Fields
	private static bool _userPathExists; // 0x0
	private static string _userPath; // 0x8
	private static bool _machinePathExists; // 0x10
	private static string _machinePath; // 0x18
	private CspParameters _params; // 0x10
	private string _keyvalue; // 0x18
	private string _filename; // 0x20
	private string _container; // 0x28
	private static object lockobj; // 0x20

	// Properties
	public string Filename { get; }
	public string KeyValue { get; set; }
	private static string UserPath { get; }
	private static string MachinePath { get; }
	private bool CanChange { get; }
	private bool UseDefaultKeyContainer { get; }
	private bool UseMachineKeyStore { get; }
	private string ContainerName { get; }

	// Methods

	// RVA: 0x1A88C40 Offset: 0x1A87640 VA: 0x181A88C40
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x1A88B10 Offset: 0x1A87510 VA: 0x181A88B10
	public void .ctor(CspParameters parameters, string keyPair) { }

	// RVA: 0x1A88EC0 Offset: 0x1A878C0 VA: 0x181A88EC0
	public string get_Filename() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_KeyValue() { }

	// RVA: 0x1A89B50 Offset: 0x1A88550 VA: 0x181A89B50
	public void set_KeyValue(string value) { }

	// RVA: 0x1A88380 Offset: 0x1A86D80 VA: 0x181A88380
	public bool Load() { }

	// RVA: 0x1A886A0 Offset: 0x1A870A0 VA: 0x181A886A0
	public void Save() { }

	// RVA: 0x1A88680 Offset: 0x1A87080 VA: 0x181A88680
	public void Remove() { }

	// RVA: 0x1A89610 Offset: 0x1A88010 VA: 0x181A89610
	private static string get_UserPath() { }

	// RVA: 0x1A89080 Offset: 0x1A87A80 VA: 0x181A89080
	private static string get_MachinePath() { }

	// RVA: 0x1A88A80 Offset: 0x1A87480 VA: 0x181A88A80
	internal static bool _CanSecure(char* root) { }

	// RVA: 0x1A88A80 Offset: 0x1A87480 VA: 0x181A88A80
	internal static bool _ProtectUser(char* path) { }

	// RVA: 0x1A88A80 Offset: 0x1A87480 VA: 0x181A88A80
	internal static bool _ProtectMachine(char* path) { }

	// RVA: 0x1A88A80 Offset: 0x1A87480 VA: 0x181A88A80
	internal static bool _IsUserProtected(char* path) { }

	// RVA: 0x1A88A80 Offset: 0x1A87480 VA: 0x181A88A80
	internal static bool _IsMachineProtected(char* path) { }

	// RVA: 0x1A87E80 Offset: 0x1A86880 VA: 0x181A87E80
	private static bool CanSecure(string path) { }

	// RVA: 0x1A88580 Offset: 0x1A86F80 VA: 0x181A88580
	private static bool ProtectUser(string path) { }

	// RVA: 0x1A88480 Offset: 0x1A86E80 VA: 0x181A88480
	private static bool ProtectMachine(string path) { }

	// RVA: 0x1A88280 Offset: 0x1A86C80 VA: 0x181A88280
	private static bool IsUserProtected(string path) { }

	// RVA: 0x1A88180 Offset: 0x1A86B80 VA: 0x181A88180
	private static bool IsMachineProtected(string path) { }

	// RVA: 0x16675B0 Offset: 0x1665FB0 VA: 0x1816675B0
	private bool get_CanChange() { }

	// RVA: 0x1A895D0 Offset: 0x1A87FD0 VA: 0x181A895D0
	private bool get_UseDefaultKeyContainer() { }

	// RVA: 0x1A895F0 Offset: 0x1A87FF0 VA: 0x181A895F0
	private bool get_UseMachineKeyStore() { }

	// RVA: 0x1A88D70 Offset: 0x1A87770 VA: 0x181A88D70
	private string get_ContainerName() { }

	// RVA: 0x1A87F10 Offset: 0x1A86910 VA: 0x181A87F10
	private CspParameters Copy(CspParameters p) { }

	// RVA: 0x1A87FC0 Offset: 0x1A869C0 VA: 0x181A87FC0
	private void FromXml(string xml) { }

	// RVA: 0x1A88870 Offset: 0x1A87270 VA: 0x181A88870
	private string ToXml() { }

	// RVA: 0x1A88A90 Offset: 0x1A87490 VA: 0x181A88A90
	private static void .cctor() { }
}
