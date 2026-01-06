internal class Win32DnD // TypeDefIndex: 5707
{
	// Fields
	private static Win32DnD.QueryInterfaceDelegate DOQueryInterface; // 0x0
	private static Win32DnD.AddRefDelegate DOAddRef; // 0x8
	private static Win32DnD.ReleaseDelegate DORelease; // 0x10
	private static Win32DnD.GetDataDelegate GetData; // 0x18
	private static Win32DnD.GetDataHereDelegate GetDataHere; // 0x20
	private static Win32DnD.QueryGetDataDelegate QueryGetData; // 0x28
	private static Win32DnD.GetCanonicalFormatEtcDelegate GetCanonicalFormatEtc; // 0x30
	private static Win32DnD.SetDataDelegate SetData; // 0x38
	private static Win32DnD.EnumFormatEtcDelegate EnumFormatEtc; // 0x40
	private static Win32DnD.DAdviseDelegate DAdvise; // 0x48
	private static Win32DnD.DUnadviseDelegate DUnadvise; // 0x50
	private static Win32DnD.EnumDAdviseDelegate EnumDAdvise; // 0x58
	private static Win32DnD.QueryInterfaceDelegate DSQueryInterface; // 0x60
	private static Win32DnD.AddRefDelegate DSAddRef; // 0x68
	private static Win32DnD.ReleaseDelegate DSRelease; // 0x70
	private static Win32DnD.QueryContinueDragDelegate QueryContinueDrag; // 0x78
	private static Win32DnD.GiveFeedbackDelegate GiveFeedback; // 0x80
	private static Win32DnD.QueryInterfaceDelegate DTQueryInterface; // 0x88
	private static Win32DnD.AddRefDelegate DTAddRef; // 0x90
	private static Win32DnD.ReleaseDelegate DTRelease; // 0x98
	private static Win32DnD.DragEnterDelegate DragEnter; // 0xA0
	private static Win32DnD.DragOverDelegate DragOver; // 0xA8
	private static Win32DnD.DragLeaveDelegate DragLeave; // 0xB0
	private static Win32DnD.DropDelegate Drop; // 0xB8
	private static DragEventArgs DragDropEventArgs; // 0xC0
	private static GiveFeedbackEventArgs DragFeedbackEventArgs; // 0xC8
	private static QueryContinueDragEventArgs DragContinueEventArgs; // 0xD0
	private static ArrayList DragFormats; // 0xD8
	private static Win32DnD.FORMATETC[] DragFormatArray; // 0xE0
	private static ArrayList DragMediums; // 0xE8
	private static readonly Guid IID_IUnknown; // 0xF0
	private static readonly Guid IID_IDataObject; // 0x100
	private static readonly Guid IID_IDropSource; // 0x110
	private static readonly Guid IID_IDropTarget; // 0x120

	// Methods

	// RVA: 0x226E950 Offset: 0x226D350 VA: 0x18226E950
	private static void .cctor() { }

	// RVA: 0x226E010 Offset: 0x226CA10 VA: 0x18226E010
	internal static bool HandleWMDropFiles(ref MSG msg) { }

	// RVA: 0x226DDC0 Offset: 0x226C7C0 VA: 0x18226DDC0
	private static int FindFormat(Win32DnD.FORMATETC pformatetc) { }

	// RVA: 0x226E4F0 Offset: 0x226CEF0 VA: 0x18226E4F0
	internal static bool UnregisterDropTarget(IntPtr Window) { }

	// RVA: 0x226E380 Offset: 0x226CD80 VA: 0x18226E380
	internal static bool RegisterDropTarget(IntPtr Window) { }

	// RVA: 0x226E7A0 Offset: 0x226D1A0 VA: 0x18226E7A0
	private static extern uint Win32RegisterDragDrop(IntPtr Window, IntPtr pDropTarget) { }

	// RVA: 0x226E830 Offset: 0x226D230 VA: 0x18226E830
	private static extern int Win32RevokeDragDrop(IntPtr Window) { }

	// RVA: 0x226E720 Offset: 0x226D120 VA: 0x18226E720
	private static extern int Win32OleInitialize(IntPtr pvReserved) { }

	// RVA: 0x226E5A0 Offset: 0x226CFA0 VA: 0x18226E5A0
	private static extern int Win32DragQueryFile(IntPtr hDrop, int iFile, IntPtr lpszFile, int cch) { }

	// RVA: 0x226E640 Offset: 0x226D040 VA: 0x18226E640
	private static extern int Win32DragQueryFile(IntPtr hDrop, int iFile, StringBuilder lpszFile, int cch) { }

	// RVA: 0x226E8B0 Offset: 0x226D2B0 VA: 0x18226E8B0
	private static extern uint Win32SHCreateStdEnumFmtEtc(uint cfmt, Win32DnD.FORMATETC[] afmt, ref IntPtr ppenumFormatEtc) { }
}
