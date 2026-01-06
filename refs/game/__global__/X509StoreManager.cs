public sealed class X509StoreManager // TypeDefIndex: 17499
{
	// Fields
	private static string _userPath; // 0x0
	private static string _localMachinePath; // 0x8
	private static string _newUserPath; // 0x10
	private static string _newLocalMachinePath; // 0x18
	private static X509Stores _userStore; // 0x20
	private static X509Stores _machineStore; // 0x28

	// Properties
	internal static string CurrentUserPath { get; }
	internal static string LocalMachinePath { get; }
	internal static string NewCurrentUserPath { get; }
	internal static string NewLocalMachinePath { get; }
	public static X509Stores CurrentUser { get; }
	public static X509Stores LocalMachine { get; }
	public static X509CertificateCollection TrustedRootCertificates { get; }

	// Methods

	// RVA: 0x1A6D250 Offset: 0x1A6BC50 VA: 0x181A6D250
	internal static string get_CurrentUserPath() { }

	// RVA: 0x1A6D550 Offset: 0x1A6BF50 VA: 0x181A6D550
	internal static string get_LocalMachinePath() { }

	// RVA: 0x1A6D870 Offset: 0x1A6C270 VA: 0x181A6D870
	internal static string get_NewCurrentUserPath() { }

	// RVA: 0x1A6D9A0 Offset: 0x1A6C3A0 VA: 0x181A6D9A0
	internal static string get_NewLocalMachinePath() { }

	// RVA: 0x1A6D370 Offset: 0x1A6BD70 VA: 0x181A6D370
	public static X509Stores get_CurrentUser() { }

	// RVA: 0x1A6D680 Offset: 0x1A6C080 VA: 0x181A6D680
	public static X509Stores get_LocalMachine() { }

	// RVA: 0x1A6DAD0 Offset: 0x1A6C4D0 VA: 0x181A6DAD0
	public static X509CertificateCollection get_TrustedRootCertificates() { }
}
