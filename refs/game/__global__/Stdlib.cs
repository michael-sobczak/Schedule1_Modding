public class Stdlib // TypeDefIndex: 19227
{
	// Fields
	private static bool versionCheckPerformed; // 0x0
	private static readonly IntPtr _SIG_DFL; // 0x8
	private static readonly IntPtr _SIG_ERR; // 0x10
	private static readonly IntPtr _SIG_IGN; // 0x18
	[CLSCompliant(False)]
	public static readonly SignalHandler SIG_DFL; // 0x20
	[CLSCompliant(False)]
	public static readonly SignalHandler SIG_ERR; // 0x28
	[CLSCompliant(False)]
	public static readonly SignalHandler SIG_IGN; // 0x30
	[CLSCompliant(False)]
	public static readonly int _IOFBF; // 0x38
	[CLSCompliant(False)]
	public static readonly int _IOLBF; // 0x3C
	[CLSCompliant(False)]
	public static readonly int _IONBF; // 0x40
	[CLSCompliant(False)]
	public static readonly int BUFSIZ; // 0x44
	[CLSCompliant(False)]
	public static readonly int EOF; // 0x48
	[CLSCompliant(False)]
	public static readonly int FOPEN_MAX; // 0x4C
	[CLSCompliant(False)]
	public static readonly int FILENAME_MAX; // 0x50
	[CLSCompliant(False)]
	public static readonly int L_tmpnam; // 0x54
	public static readonly IntPtr stderr; // 0x58
	public static readonly IntPtr stdin; // 0x60
	public static readonly IntPtr stdout; // 0x68
	[CLSCompliant(False)]
	public static readonly int TMP_MAX; // 0x70
	private static object tmpnam_lock; // 0x78
	[CLSCompliant(False)]
	public static readonly int EXIT_FAILURE; // 0x80
	[CLSCompliant(False)]
	public static readonly int EXIT_SUCCESS; // 0x84
	[CLSCompliant(False)]
	public static readonly int MB_CUR_MAX; // 0x88
	[CLSCompliant(False)]
	public static readonly int RAND_MAX; // 0x8C
	private static object strerror_lock; // 0x90

	// Methods

	// RVA: 0x1A52120 Offset: 0x1A50B20 VA: 0x181A52120
	private static extern IntPtr VersionStringPtr() { }

	// RVA: 0x1A51EC0 Offset: 0x1A508C0 VA: 0x181A51EC0
	internal static void VersionCheck() { }

	// RVA: 0x1A52460 Offset: 0x1A50E60 VA: 0x181A52460
	private static void .cctor() { }

	// RVA: 0x1A516E0 Offset: 0x1A500E0 VA: 0x181A516E0
	private static extern IntPtr GetDefaultSignal() { }

	// RVA: 0x1A517C0 Offset: 0x1A501C0 VA: 0x181A517C0
	private static extern IntPtr GetErrorSignal() { }

	// RVA: 0x1A51A60 Offset: 0x1A50460 VA: 0x181A51A60
	private static extern IntPtr GetIgnoreSignal() { }

	// RVA: 0x1A52280 Offset: 0x1A50C80 VA: 0x181A52280
	private static void _ErrorHandler(int signum) { }

	// RVA: 0x1A52190 Offset: 0x1A50B90 VA: 0x181A52190
	private static void _DefaultHandler(int signum) { }

	// RVA: 0x1A52370 Offset: 0x1A50D70 VA: 0x181A52370
	private static void _IgnoreHandler(int signum) { }

	// RVA: 0x1A519F0 Offset: 0x1A503F0 VA: 0x181A519F0
	private static extern int GetFullyBuffered() { }

	// RVA: 0x1A51AD0 Offset: 0x1A504D0 VA: 0x181A51AD0
	private static extern int GetLineBuffered() { }

	// RVA: 0x1A51BB0 Offset: 0x1A505B0 VA: 0x181A51BB0
	private static extern int GetNonBuffered() { }

	// RVA: 0x1A51670 Offset: 0x1A50070 VA: 0x181A51670
	private static extern int GetBufferSize() { }

	// RVA: 0x1A51750 Offset: 0x1A50150 VA: 0x181A51750
	private static extern int GetEOF() { }

	// RVA: 0x1A51910 Offset: 0x1A50310 VA: 0x181A51910
	private static extern int GetFilenameMax() { }

	// RVA: 0x1A51980 Offset: 0x1A50380 VA: 0x181A51980
	private static extern int GetFopenMax() { }

	// RVA: 0x1A51E50 Offset: 0x1A50850 VA: 0x181A51E50
	private static extern int GetTmpnamLength() { }

	// RVA: 0x1A51D00 Offset: 0x1A50700 VA: 0x181A51D00
	private static extern IntPtr GetStandardInput() { }

	// RVA: 0x1A51D70 Offset: 0x1A50770 VA: 0x181A51D70
	private static extern IntPtr GetStandardOutput() { }

	// RVA: 0x1A51C90 Offset: 0x1A50690 VA: 0x181A51C90
	private static extern IntPtr GetStandardError() { }

	// RVA: 0x1A51DE0 Offset: 0x1A507E0 VA: 0x181A51DE0
	private static extern int GetTmpMax() { }

	// RVA: 0x1A51830 Offset: 0x1A50230 VA: 0x181A51830
	private static extern int GetExitFailure() { }

	// RVA: 0x1A518A0 Offset: 0x1A502A0 VA: 0x181A518A0
	private static extern int GetExitSuccess() { }

	// RVA: 0x1A51B40 Offset: 0x1A50540 VA: 0x181A51B40
	private static extern int GetMbCurMax() { }

	// RVA: 0x1A51C20 Offset: 0x1A50620 VA: 0x181A51C20
	private static extern int GetRandMax() { }
}
