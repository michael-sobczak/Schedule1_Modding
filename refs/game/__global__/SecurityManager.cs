public static class SecurityManager // TypeDefIndex: 4158
{
	// Properties
	[Obsolete("The security manager cannot be turned off on MS runtime")]
	public static bool SecurityEnabled { get; }

	// Methods

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public static bool get_SecurityEnabled() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void EnsureElevatedPermissions() { }
}
