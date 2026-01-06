public sealed class Syscall : Stdlib // TypeDefIndex: 19231
{
	// Fields
	internal static object readdir_lock; // 0x0
	public static readonly int AT_FDCWD; // 0x8
	internal static object fstab_lock; // 0x10
	internal static object grp_lock; // 0x18
	internal static object pwd_lock; // 0x20
	private static object signal_lock; // 0x28
	public static readonly int L_ctermid; // 0x30
	public static readonly int L_cuserid; // 0x34
	internal static object getlogin_lock; // 0x38
	public static readonly IntPtr MAP_FAILED; // 0x40
	public static readonly long UTIME_NOW; // 0x48
	public static readonly long UTIME_OMIT; // 0x50
	private static object tty_lock; // 0x58
	internal static object usershell_lock; // 0x60

	// Methods

	// RVA: 0x1A53480 Offset: 0x1A51E80 VA: 0x181A53480
	private static extern int get_at_fdcwd() { }

	// RVA: 0x1A52F10 Offset: 0x1A51910 VA: 0x181A52F10
	private static extern int _L_ctermid() { }

	// RVA: 0x1A52F80 Offset: 0x1A51980 VA: 0x181A52F80
	private static extern int _L_cuserid() { }

	// RVA: 0x1A53A50 Offset: 0x1A52450 VA: 0x181A53A50
	private static extern int sys_poll([In] [Out] Syscall._pollfd[] ufds, uint nfds, int timeout) { }

	// RVA: 0x1A53600 Offset: 0x1A52000 VA: 0x181A53600
	public static int poll(Pollfd[] fds, uint nfds, int timeout) { }

	// RVA: 0x1A53500 Offset: 0x1A51F00 VA: 0x181A53500
	private static extern long get_utime_now() { }

	// RVA: 0x1A53580 Offset: 0x1A51F80 VA: 0x181A53580
	private static extern long get_utime_omit() { }

	// RVA: 0x1A52FF0 Offset: 0x1A519F0 VA: 0x181A52FF0
	private static void .cctor() { }
}
