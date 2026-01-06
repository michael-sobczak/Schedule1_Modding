internal static class MonoBtlsError // TypeDefIndex: 9429
{
	// Methods

	// RVA: 0x20172E0 Offset: 0x2015CE0 VA: 0x1820172E0
	private static extern void mono_btls_error_clear_error() { }

	// RVA: 0x20176D0 Offset: 0x20160D0 VA: 0x1820176D0
	private static extern int mono_btls_error_get_error_line(out IntPtr file, out int line) { }

	// RVA: 0x2017760 Offset: 0x2016160 VA: 0x182017760
	private static extern void mono_btls_error_get_error_string_n(int error, IntPtr buf, int len) { }

	// RVA: 0x2017350 Offset: 0x2015D50 VA: 0x182017350
	private static extern int mono_btls_error_get_reason(int error) { }

	// RVA: 0x20172E0 Offset: 0x2015CE0 VA: 0x1820172E0
	public static void ClearError() { }

	// RVA: 0x20173D0 Offset: 0x2015DD0 VA: 0x1820173D0
	public static string GetErrorString(int error) { }

	// RVA: 0x20175C0 Offset: 0x2015FC0 VA: 0x1820175C0
	public static int GetError(out string file, out int line) { }

	// RVA: 0x2017350 Offset: 0x2015D50 VA: 0x182017350
	public static int GetErrorReason(int error) { }
}
