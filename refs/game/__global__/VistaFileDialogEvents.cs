internal class VistaFileDialogEvents : IFileDialogEvents, IFileDialogControlEvents // TypeDefIndex: 17313
{
	// Fields
	private const uint S_OK = 0;
	private const uint S_FALSE = 1;
	private const uint E_NOTIMPL = 2147500033;
	private VistaFileDialog _dialog; // 0x10

	// Methods

	// RVA: 0x1E13E00 Offset: 0x1E12800 VA: 0x181E13E00
	public void .ctor(VistaFileDialog dialog) { }

	// RVA: 0x1E13D10 Offset: 0x1E12710 VA: 0x181E13D10 Slot: 4
	public HRESULT OnFileOk(IFileDialog pfd) { }

	// RVA: 0x1E13DB0 Offset: 0x1E127B0 VA: 0x181E13DB0 Slot: 5
	public HRESULT OnFolderChanging(IFileDialog pfd, IShellItem psiFolder) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	public void OnFolderChange(IFileDialog pfd) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	public void OnSelectionChange(IFileDialog pfd) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public void OnShareViolation(IFileDialog pfd, IShellItem psi) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	public void OnTypeChange(IFileDialog pfd) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	public void OnOverwrite(IFileDialog pfd, IShellItem psi) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	public void OnItemSelected(IFileDialogCustomize pfdc, int dwIDCtl, int dwIDItem) { }

	// RVA: 0x1E13C70 Offset: 0x1E12670 VA: 0x181E13C70 Slot: 12
	public void OnButtonClicked(IFileDialogCustomize pfdc, int dwIDCtl) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 13
	public void OnCheckButtonToggled(IFileDialogCustomize pfdc, int dwIDCtl, bool bChecked) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 14
	public void OnControlActivating(IFileDialogCustomize pfdc, int dwIDCtl) { }
}
