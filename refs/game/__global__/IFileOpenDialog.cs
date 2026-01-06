internal interface IFileOpenDialog : IFileDialog, IModalWindow // TypeDefIndex: 17330
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Show([In] IntPtr parent);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetFileTypes([In] uint cFileTypes, in NativeMethods.COMDLG_FILTERSPEC rgFilterSpec);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetFileTypeIndex([In] uint iFileType);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GetFileTypeIndex(out uint piFileType);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Advise([In] IFileDialogEvents pfde, out uint pdwCookie);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Unadvise([In] uint dwCookie);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetOptions([In] NativeMethods.FOS fos);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void GetOptions(out NativeMethods.FOS pfos);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetDefaultFolder([In] IShellItem psi);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SetFolder([In] IShellItem psi);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void GetFolder(out IShellItem ppsi);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void GetCurrentSelection(out IShellItem ppsi);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void SetFileName([In] string pszName);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void GetFileName(out string pszName);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void SetTitle([In] string pszTitle);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void SetOkButtonLabel([In] string pszText);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void SetFileNameLabel([In] string pszLabel);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void GetResult(out IShellItem ppsi);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void AddPlace([In] IShellItem psi, NativeMethods.FDAP fdap);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void SetDefaultExtension([In] string pszDefaultExtension);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void Close(int hr);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void SetClientGuid(in Guid guid);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void ClearClientData();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void SetFilter(IntPtr pFilter);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void GetResults(out IShellItemArray ppenum);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void GetSelectedItems(out IShellItemArray ppsai);
}
