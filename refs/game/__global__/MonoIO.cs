internal static class MonoIO // TypeDefIndex: 5109
{
	// Fields
	public static readonly IntPtr InvalidHandle; // 0x0
	private static bool dump_handles; // 0x8

	// Properties
	public static IntPtr ConsoleOutput { get; }
	public static IntPtr ConsoleInput { get; }
	public static IntPtr ConsoleError { get; }
	public static char VolumeSeparatorChar { get; }
	public static char DirectorySeparatorChar { get; }
	public static char AltDirectorySeparatorChar { get; }
	public static char PathSeparator { get; }

	// Methods

	// RVA: 0x1C33730 Offset: 0x1C32130 VA: 0x181C33730
	public static Exception GetException(MonoIOError error) { }

	// RVA: 0x1C33040 Offset: 0x1C31A40 VA: 0x181C33040
	public static Exception GetException(string path, MonoIOError error) { }

	// RVA: 0x1C33030 Offset: 0x1C31A30 VA: 0x181C33030
	public static string GetCurrentDirectory(out MonoIOError error) { }

	// RVA: 0x1C33DD0 Offset: 0x1C327D0 VA: 0x181C33DD0
	private static bool SetFileAttributes(char* path, FileAttributes attrs, out MonoIOError error) { }

	// RVA: 0x1C33DE0 Offset: 0x1C327E0 VA: 0x181C33DE0
	public static bool SetFileAttributes(string path, FileAttributes attrs, out MonoIOError error) { }

	// RVA: 0x1C33950 Offset: 0x1C32350 VA: 0x181C33950
	private static MonoFileType GetFileType(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x1C33840 Offset: 0x1C32240 VA: 0x181C33840
	public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x1C33020 Offset: 0x1C31A20 VA: 0x181C33020
	public static bool FindCloseFile(IntPtr hnd) { }

	// RVA: 0x1C33A80 Offset: 0x1C32480 VA: 0x181C33A80
	private static IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x1C33A90 Offset: 0x1C32490 VA: 0x181C33A90
	public static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x1C32ED0 Offset: 0x1C318D0 VA: 0x181C32ED0
	private static bool Cancel_internal(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x1C32EE0 Offset: 0x1C318E0 VA: 0x181C32EE0
	internal static bool Cancel(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x1C33000 Offset: 0x1C31A00 VA: 0x181C33000
	public static bool Close(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x1C33C60 Offset: 0x1C32660 VA: 0x181C33C60
	private static int Read(IntPtr handle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x1C33B20 Offset: 0x1C32520 VA: 0x181C33B20
	public static int Read(SafeHandle safeHandle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x1C340E0 Offset: 0x1C32AE0 VA: 0x181C340E0
	private static int Write(IntPtr handle, [In] byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x1C33FA0 Offset: 0x1C329A0 VA: 0x181C33FA0
	public static int Write(SafeHandle safeHandle, byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x1C33DC0 Offset: 0x1C327C0 VA: 0x181C33DC0
	private static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x1C33C80 Offset: 0x1C32680 VA: 0x181C33C80
	public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x1C33960 Offset: 0x1C32360 VA: 0x181C33960
	private static long GetLength(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x1C33970 Offset: 0x1C32370 VA: 0x181C33970
	public static long GetLength(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x1C33E60 Offset: 0x1C32860 VA: 0x181C33E60
	private static bool SetLength(IntPtr handle, long length, out MonoIOError error) { }

	// RVA: 0x1C33E70 Offset: 0x1C32870 VA: 0x181C33E70
	public static bool SetLength(SafeHandle safeHandle, long length, out MonoIOError error) { }

	// RVA: 0x1C341A0 Offset: 0x1C32BA0 VA: 0x181C341A0
	public static IntPtr get_ConsoleOutput() { }

	// RVA: 0x1C34190 Offset: 0x1C32B90 VA: 0x181C34190
	public static IntPtr get_ConsoleInput() { }

	// RVA: 0x1C34180 Offset: 0x1C32B80 VA: 0x181C34180
	public static IntPtr get_ConsoleError() { }

	// RVA: 0x1C33010 Offset: 0x1C31A10 VA: 0x181C33010
	public static bool DuplicateHandle(IntPtr source_process_handle, IntPtr source_handle, IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options, out MonoIOError error) { }

	// RVA: 0x1C341D0 Offset: 0x1C32BD0 VA: 0x181C341D0
	public static char get_VolumeSeparatorChar() { }

	// RVA: 0x1C341B0 Offset: 0x1C32BB0 VA: 0x181C341B0
	public static char get_DirectorySeparatorChar() { }

	// RVA: 0x1C34170 Offset: 0x1C32B70 VA: 0x181C34170
	public static char get_AltDirectorySeparatorChar() { }

	// RVA: 0x1C341C0 Offset: 0x1C32BC0 VA: 0x181C341C0
	public static char get_PathSeparator() { }

	// RVA: 0x1B936D0 Offset: 0x1B920D0 VA: 0x181B936D0
	private static void DumpHandles() { }

	// RVA: 0x1C33C70 Offset: 0x1C32670 VA: 0x181C33C70
	public static bool RemapPath(string path, out string newPath) { }

	// RVA: 0x1C340F0 Offset: 0x1C32AF0 VA: 0x181C340F0
	private static void .cctor() { }
}
