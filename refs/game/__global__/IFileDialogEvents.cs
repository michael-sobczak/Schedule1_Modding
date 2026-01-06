internal interface IFileDialogEvents // TypeDefIndex: 17332
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract HRESULT OnFileOk([In] IFileDialog pfd);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract HRESULT OnFolderChanging([In] IFileDialog pfd, [In] IShellItem psiFolder);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnFolderChange([In] IFileDialog pfd);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnSelectionChange([In] IFileDialog pfd);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnShareViolation([In] IFileDialog pfd, [In] IShellItem psi);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnTypeChange([In] IFileDialog pfd);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnOverwrite([In] IFileDialog pfd, [In] IShellItem psi);
}
